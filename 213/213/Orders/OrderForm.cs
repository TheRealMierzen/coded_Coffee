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
using System.IO;

namespace _213
{
    public partial class OrderForm : Form
    {
        public string items;
        private string userName;
        double costperItems = 0.0;
        double Grandtotal = 0.0;
        string selectedItem = null;
        string path;
        string Ordernumber;
        private int c = 0;
        int last;
        private int t = 0;
        bool custombuild = false;
        int counter = 0;
        private string it = "";
        string s = "";
        //private Action<object, EventArgs> roundButton3_Click;

        public OrderForm()
        {
            InitializeComponent();
            gpxOrders.Hide();
            gbxPayment.Hide();
            gpxSearch.Hide();
            cbxOrder.Sorted = true;
            AddOrderBtn.Enabled = false;
            cbxOrders.SelectedIndex = 0;
            txtMaker.Focus();
        }

        public OrderForm(string userN)
        {
            userName = userN;
            InitializeComponent();
            gpxOrders.Hide();
            gbxPayment.Hide();
            gpxSearch.Hide();
            cbxOrder.Sorted = true;
            AddOrderBtn.Enabled = false;
            cbxOrders.SelectedIndex = 0;
            txtMaker.Focus();
        }

        public OrderForm(string usert, int counters, string email)
        {
            InitializeComponent();
            gpxOrders.Hide();
            gbxPayment.Hide();
            gpxSearch.Hide();
            cbxOrder.Sorted = true;
            AddOrderBtn.Enabled = false;
            cbxOrders.SelectedIndex = 0;
            userName = usert;
            counter = counters;
            cbxSpecialorder.Enabled = false;
            cbxSpecialorder.Checked = true;
            txtCust_email.Text = email;
            txtCust_email.Enabled = false;
            txtCust_email.Show();
            c = counters;
            btnBack.Enabled = false;
            MessageBox.Show("You may only order " + counter + " items for this build", "Custom build", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void makeOrder()
        {
            addOrder(Properties.Settings.Default.Branch, txtMaker.Text, s, txtPricofeachitem.Text, 0, 0, DateTime.Today.ToString(), "0", checkSpesialorder(), getEta(), txtCust_email.Text);
            it = it + txtItem.Text + ",";
                SqlConnection con = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT");
                con.Open();
                SqlCommand updateCms = new SqlCommand("Update Cms SET cms_Order = @Order AND cms_orderID = @id", con);
                updateCms.Parameters.AddWithValue("@Order", it);
                updateCms.Parameters.AddWithValue("@ID", last);
                updateCms.ExecuteNonQuery();
            
        }

        public OrderForm(FrmTechnical tf)
        {
            InitializeComponent();
            gpxOrders.Hide();
            gbxPayment.Hide();
            gpxSearch.Hide();
            cbxOrder.Sorted = true;
            AddOrderBtn.Enabled = false;
            cbxOrders.SelectedIndex = 0;
            txtMaker.Focus();
            parent = tf;
        }
        FrmTechnical parent;   

        public OrderForm(string path,string ordernumber)
        {
            InitializeComponent();
            gpxOrders.Hide();
            gbxPayment.Hide();
            gpxSearch.Hide();
            cbxOrder.Sorted = true;
            AddOrderBtn.Enabled = false;
            cbxOrders.SelectedIndex = 0;
        }

        public OrderForm(bool custombuild, FrmTechnical ft)
        {
            InitializeComponent();
            gpxOrders.Hide();
            gbxPayment.Hide();
            gpxSearch.Hide();
            cbxOrder.Sorted = true;
            AddOrderBtn.Enabled = false;
            cbxOrders.SelectedIndex = 0;
            this.custombuild = custombuild;
            tech = ft;
        }

        FrmTechnical tech;
        /*public OrderForm(Action<object, EventArgs> roundButton3_Click)
        {
            this.roundButton3_Click = roundButton3_Click;
        }

        private void roundButton3(object sender, EventArgs e)
        {
            //OrderForm OF2 = new OrderForm();
            
            
        }*/

        private void OrderForm_Load(object sender, EventArgs e)
        {
            //this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void AddOrderBtn_Click(object sender, EventArgs e)
        {
            if(c == 0)
            {
              

                //MEANS NO CUSTOM BUILD
                //verander die net dat dit pas volgens textboxes en goed
                //as received date "" is dan insert hy 1900-01-01..so wanneer received en datum is 1900-01-01 dan moet datum geupdate word na current toe         
                //if (addOrder(Properties.Settings.Default.Branch, "Nvidia", "GTX TitanX x 20, GTX 1080 x 7, GTX Titan x 5", "R55555", 0, 0, DateTime.Now.Date.ToString(), "", 0,getEta()))
                //    MessageBox.Show("Order added");
                //else
                //    MessageBox.Show("Order was not added");
                try
                {
                   
                    items = items.Remove(items.Length - 1);
                    if (items != null)
                    {
                        if (MessageBox.Show("Are you sure you want to add this order ", "Place order", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            if (addOrder(Properties.Settings.Default.Branch, txtMaker.Text, items, Grandtotal.ToString(), 0, 0, DateTime.Now.ToString(), "", checkSpesialorder(), getEta(), txtCust_email.Text))
                            {
                                path = AppDomain.CurrentDomain.BaseDirectory + @"\Orders\";
                                Ordernumber = "Order," + last.ToString() + ".txt";
                                StreamWriter skryf;

                                skryf = File.CreateText(path + Ordernumber);
                                skryf.WriteLine(lbxOutput.Text);
                                skryf.Close();

                                displayListbox(1);
                                AddOrderBtn.Enabled = false;
                                txtMaker.Clear();
                            }
                            gebruik.addAction(userName);
                            gebruik.log(DateTime.Now, userName, "Placed order");
                            if (c == 0)
                                btnBack.Enabled = true;
                            
                        }
                    }
                    else
                        MessageBox.Show("Please select items to place a order for", "Cannot place order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Please select items to place a order for", "Cannot place order", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                makeOrder();
                c = c - 1;
                if (c == 0)
                    btnBack.Enabled = true;
            }
            
      }


        public bool addOrder(string branch, string order_supplier, string order_items, string total_cost, int invoice_sent, int received, string order_date, string received_date, int special_order,string eta, string cust_email)
        {
            
            try
            {

                gebruik util = new gebruik();
                last = util.getLastIdentity("Orders", "order_id", "int");

                using (SqlConnection con = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
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
            gpxSearch.Focus();
            btnCancel.Show();
            lbxsearchordelete.Items.Clear();
            cbxOrder.Items.Clear();
            populateCombobox();
            lblOrder.Text = "";
            selectedItem = null;
            tableLayoutPanel2.Hide();
            tableLayoutPanel3.Show();
        }

        public void orders()
        {
            gpxSearch.Hide();
            gpxOrders.Show();
            displayListbox(1);
            tableLayoutPanel2.Show();
            tableLayoutPanel3.Hide();
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
                                lbxsearchordelete.Items.Clear();
                            }
                            con.Close();
                        }
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
                c++;
                s = txtItem.Text;   
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
                MessageBox.Show("Please enter valid createria", "Cannot place order", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClearOrder_Click(object sender, EventArgs e)
        {
            if(items == null)
                MessageBox.Show("No items to order", "No items", MessageBoxButtons.OK, MessageBoxIcon.Information);   
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

        private void btnremovePrevouis_Click(object sender, EventArgs e)//Removes the item from the output and from the local varible if the customer made a error
        {
            try
            {
                char[] charr = { ',' };
                string[] components;

                components = items.Split(charr);
                items = null;
                for (int i = 0; i < components.Length - 2; i++)
                {
                    items = items + components[i] +',';
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
                MessageBox.Show("No items to remove", "Cannot remove item", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        public int lbxIndex()//I use this metode to manipulalte the ouput in the output displays
        {
           return lbxOutput.Items.Count;
        }

        public string getEta()// This metode set the eta for die order. For the customer to colect it
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

        public void displayOrder(string id)//Display all the order in the ouput display
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

        public bool checkOrderfordelete()// The program check what orders there are in the database. If its finds a order you can delete it.
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
                return false;
            }
        }

        private void cbxOrder_SelectedIndexChanged(object sender, EventArgs e)//Select all the orders from the database according to cbxOrder index 
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

        private void button1_Click(object sender, EventArgs e)//back to home
        {
            Form1 f1 = new Form1();
            
            this.Hide();
            this.Close();
        }
    }
}
