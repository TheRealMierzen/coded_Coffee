using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _213
{
    public partial class OrderForm : Form
    {
        public string items;
        double costperItems = 0.0;
        double Grandtotal = 0.0;
        string selectedItem = null;
        private Action<object, EventArgs> roundButton3_Click;

        public OrderForm()
        {
            InitializeComponent();
            gpxOrders.Hide();
            gbxPayment.Hide();
            gpxSearch.Hide();
            cbxOrder.Sorted = true;
            AddOrderBtn.Enabled = false;
            cbxOrders.SelectedIndex = 0;
        }

        public OrderForm(string usert)
        {
            InitializeComponent();
            gpxOrders.Hide();
            gbxPayment.Hide();
            gpxSearch.Hide();
            cbxOrder.Sorted = true;
            AddOrderBtn.Enabled = false;
            cbxOrders.SelectedIndex = 0;
            user = usert;
        }

        string user;

        public OrderForm(Action<object, EventArgs> roundButton3_Click)
        {
            this.roundButton3_Click = roundButton3_Click;
        }

        private void roundButton3(object sender, EventArgs e)
        {
            OrderForm OF2 = new OrderForm();
            
            
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            /*this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;*/
            txtMaker.Focus();
        }

        private void AddOrderBtn_Click(object sender, EventArgs e)
        {
            //verander die net dat dit pas volgens textboxes en goed
            //as received date "" is dan insert hy 1900-01-01..so wanneer received en datum is 1900-01-01 dan moet datum geupdate word na current toe         
            //if (addOrder(Properties.Settings.Default.Branch, "Nvidia", "GTX TitanX x 20, GTX 1080 x 7, GTX Titan x 5", "R55555", 0, 0, DateTime.Now.Date.ToString(), "", 0,getEta()))
            //    MessageBox.Show("Order added");
            //else
            //    MessageBox.Show("Order was not added");

            /*gebruik util = new gebruik();       
            frOrderConfirm f1 = new frOrderConfirm();
            f1.Show();*/

            items = items.Remove(items.Length - 1);
            if (items != null)
            {
                if (MessageBox.Show("Are you sure you want to add this order ", "Place order", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (addOrder(Properties.Settings.Default.Branch, txtMaker.Text, items, Grandtotal.ToString(), 0, 0, DateTime.Now.ToString(), "", checkSpesialorder(), getEta(), txtCust_email.Text))
                    {
                        displayListbox(1);
                    }
                    gebruik.addAction(user);
                    //gebruik.log(DateTime.Now, user, "Placed order");
                }
            }
            else
                MessageBox.Show("Please select items to place a order for","Cannot place order",MessageBoxButtons.OK,MessageBoxIcon.Information);
            
        }

        public bool addOrder(string branch, string order_supplier, string order_items, string total_cost, int invoice_sent, int received, string order_date, string received_date, int special_order,string eta, string cust_email)
        {
            
            try
            {

                gebruik util = new gebruik();
                int last;
                last = util.getLastIdentity("Orders", "order_id", "int");

                using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True"))
                {

                    string cmdstring = "INSERT INTO Orders(branch, order_id, order_supplier, order_items, total_cost, invoice_sent, received, order_date, received_date, special_order, eta,cust_email) VALUES (@branch, @order_id, @order_supplier, @order_items, @total_cost, @invoice_sent, @received, @order_date, @received_date, @special_order,@eta,@cust_email)";
                    using (SqlCommand comm = new SqlCommand(cmdstring, con))
                    {

                        comm.Parameters.AddWithValue("@branch", branch);
                        comm.Parameters.AddWithValue("@order_id", last + 1);
                        comm.Parameters.AddWithValue("@order_supplier", order_supplier);
                        comm.Parameters.AddWithValue("@order_items", order_items);
                        comm.Parameters.AddWithValue("@total_cost", total_cost);
                        comm.Parameters.AddWithValue("@invoice_sent", invoice_sent);
                        comm.Parameters.AddWithValue("@received", received);
                        comm.Parameters.AddWithValue("@order_date", order_date);
                        comm.Parameters.AddWithValue("@received_date", received_date);
                        comm.Parameters.AddWithValue("@special_order", special_order);
                        comm.Parameters.AddWithValue("@eta", eta);
                        comm.Parameters.AddWithValue("@cust_email", cust_email);

                        con.Open();
                        comm.ExecuteNonQuery();

                    }
                         
                }

                txtMaker.Enabled = true;
               return true;

            }
            catch(IndexOutOfRangeException ior)
            {
                
                MessageBox.Show("An error occurred during the " + ior.TargetSite + " process. Please verify the entered information and try again. If the problem persists, please contact our support team: blahblahsuppot \r\n" + ior.Message,"Error");
                return true;

            }
            catch(Exception e)
            {

                MessageBox.Show("An error occurred during the " + e.TargetSite  + " process. Please verify the entered information and try again. If the problem persists, please contact our support team: blahblahsuppot \r\n" + e.Message + " addOrder - line 256", "Error");
                return false;

            }

            

        }

        private void cbxOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxOrders.SelectedIndex == 0)
                orders();
            else if (cbxOrders.SelectedIndex == 1)
                searchOrderandDeleteOrder();

        }
        public void searchOrderandDeleteOrder()
        {
            gpxOrders.Hide();
            gbxPayment.Hide();
            gpxSearch.Show();
            btnCancel.Show();
            lbxsearchordelete.Items.Clear();
            cbxOrder.Items.Clear();
            populateCombobox();
            lblOrder.Text = "";
        }

        public void orders()
        {
            gpxSearch.Hide();
            gpxOrders.Show();
            displayListbox(1);
        }


        private void cbxSpecialorder_CheckedChanged(object sender, EventArgs e)
        {
            gbxPayment.Show();
            if (cbxSpecialorder.Checked == false)
                gbxPayment.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (checkOrderfordelete())
            {
                if (MessageBox.Show("Are you sure you want to cancel order " + selectedItem, "Cancel order", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True"))
                        {
                            con.Open();
                            using (SqlCommand comm = new SqlCommand("DELETE FROM Orders WHERE order_id LIKE " + selectedItem + " ", con))
                            {
                                comm.ExecuteNonQuery();
                            }
                            con.Close();
                        }
                        lbxsearchordelete.Items.Clear();
                        lblOrder.Text = "";
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Please enter a id to search for", "Order ID not entered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
                MessageBox.Show("Please enter a id to search for", "Order ID not entered", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void btnAdditem_Click(object sender, EventArgs e)
        {
           try
            {
                costperItems = Convert.ToDouble(txtPricofeachitem.Text) * Convert.ToDouble(txtQuatity.Text);
                items = items + txtItem.Text + " X " + txtQuatity.Text + ",";
                Grandtotal = Grandtotal + costperItems;
                if (lbxIndex() > 4)
                {
                    lbxOutput.Items.RemoveAt(lbxIndex()-1);
                    lbxOutput.Items.RemoveAt(lbxIndex()-1);
                }

                string itemsinTxtbox = "";
                itemsinTxtbox = itemsinTxtbox + txtMaker.Text + " " + txtItem.Text + " X " + txtQuatity.Text + "\t\t\t" + "R" + costperItems.ToString() + "\n";
                lbxOutput.Items.Add(itemsinTxtbox);

                lbxOutput.Items.Add("=====================================================");
                lbxOutput.Items.Add("Total(vat incl)\t\t\tR" + Grandtotal.ToString());

                txtMaker.Enabled = false;
                txtItem.Clear();
                txtPricofeachitem.Clear();
                txtQuatity.Clear();
                AddOrderBtn.Enabled = true;
            }
            catch(FormatException)
            {
                MessageBox.Show("Please enter valid criteria");
            }
        }

        private void btnClearOrder_Click(object sender, EventArgs e)
        {
            lbxOutput.Items.Clear();
            txtItem.Clear();
            txtPricofeachitem.Clear();
            txtQuatity.Clear();
            costperItems = 0.0;
            txtMaker.ReadOnly = false;
            txtMaker.Clear();
            displayListbox(1);
            items = null;
        }

        public int checkSpesialorder()
        {
            if (cbxSpecialorder.Checked)
                return 1;
            else
                return 0;
        }

        public void displayListbox(int i)
        {
            if (i == 1)
            {
                lbxOutput.Items.Clear();
                lbxOutput.Items.Add("==============================================================================");
                lbxOutput.Items.Add("Matrix Warehouse");
                lbxOutput.Items.Add(DateTime.Now.ToString());
                lbxOutput.Items.Add("==============================================================================");
            }
            else
            {
                lbxsearchordelete.Items.Clear();
                lbxsearchordelete.Items.Add("==============================================================================");
                lbxsearchordelete.Items.Add("Matrix Warehouse");
                lbxsearchordelete.Items.Add(DateTime.Now.ToString());
                lbxsearchordelete.Items.Add("==============================================================================");
            }
        }

        private void btnremovePrevouis_Click(object sender, EventArgs e)
        {
            try
            {
                char[] charr = { ',' };
                string[] components;

                components = items.Split(charr);
                items = null;
                for (int i = 0; i < components.Length - 2; i++)
                {
                    items = items + components[i];
                }
                lbxOutput.Items.RemoveAt(lbxOutput.Items.Count - 3);
                lbxOutput.Items.RemoveAt(lbxOutput.Items.Count-1);
                lbxOutput.Items.RemoveAt(lbxOutput.Items.Count-1);
                lbxOutput.Items.Add("=====================================================");
                Grandtotal = Grandtotal - costperItems;
                lbxOutput.Items.Add("Total(vat incl)\t\t\tR" + Grandtotal.ToString());
            }
            catch(NullReferenceException)
            {
                items = null;
                displayListbox(1);
            }
        }

        public int lbxIndex()
        {
           return lbxOutput.Items.Count;
        }

        public string getEta()
        {
            return DateTime.Now.AddDays(9).ToString();
        }

        public void populateCombobox()
        {
            cbxOrder.Items.Clear();
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True"))
                {
                    using (SqlCommand comm = new SqlCommand("SELECT * FROM Orders", con))
                    {
                        con.Open();
                        SqlDataReader sqlreader = comm.ExecuteReader();

                        while (sqlreader.Read())
                        {
                            cbxOrder.Items.Add(Convert.ToInt16(sqlreader[1]));
                        }
                        sqlreader.Close();
                        con.Close();
                    }
                 }

            }
            catch (SqlException)
            {
                MessageBox.Show("Please enter a id to search for", "Order ID not entered", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void displayOrder(string id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True"))
                {
                    using (SqlCommand comm = new SqlCommand("SELECT * FROM Orders WHERE order_id = " + id + "" , con))
                    {
                        con.Open();
                        SqlDataReader sqlreader = comm.ExecuteReader();
                        while (sqlreader.Read())
                        {
                            displayListbox(2);
                            lbxsearchordelete.Items.Add("Order ID:\t\t\t\t" + sqlreader[1]);
                            lbxsearchordelete.Items.Add("Customer contact information:\t\t" + sqlreader[11]);
                            lbxOutput.Items.Add("==============================================================================");
                            string displayItems = sqlreader[3].ToString();
                            char[] charr = { ',' };
                            string[] components = displayItems.Split(charr);
                            for (int i = 0; i < components.Length; i++)
                            {
                                lbxsearchordelete.Items.Add(sqlreader[2].ToString() + "\t\t\t\t" + components[i]);
                            }
                            lbxsearchordelete.Items.Add("eta\t\t\t\t" + sqlreader[10]);
                            lbxsearchordelete.Items.Add("==============================================================================");
                            lbxsearchordelete.Items.Add("Total \t\t\t\tR" + sqlreader[4]);
                        }
                        sqlreader.Close();
                        con.Close();
                    }
                }

            }
            catch (SqlException)
            {
                MessageBox.Show("Please enter a id to search for", "Order ID not entered", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool checkOrderfordelete()
        {
            try
            {
                int count = 0;
                using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True"))
                {
                    using (SqlCommand comm = new SqlCommand("SELECT * FROM Orders Where order_id = " + selectedItem + "", con))
                    {
                        con.Open();
                        SqlDataReader sqlreader = comm.ExecuteReader();

                        while (sqlreader.Read())
                        {
                            count++;
                        }
                        sqlreader.Close();
                        con.Close();
                    }
                }
                if (count == 0)
                    return false;
                else
                    return true;
            }
            catch (SqlException)
            {
                MessageBox.Show("Please enter a id to search for", "Order ID not entered", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
        }

        private void cbxOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedItem = cbxOrder.Text;
            try
            {
                lblOrder.Text = "Selected Order number: " + selectedItem;
                populateCombobox();
                using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True"))
                {
                    using (SqlCommand comm = new SqlCommand("SELECT * FROM Orders WHERE order_id LIKE " + selectedItem + " ", con))
                    {
                        con.Open();
                        comm.ExecuteNonQuery();
                        con.Close();
                    }
                }
                displayOrder(selectedItem);
            }
            catch (SqlException)
            {
                MessageBox.Show("Please enter a id to search for", "Order ID not entered", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
