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
        private Action<object, EventArgs> roundButton3_Click;

        public OrderForm()
        {
            InitializeComponent();
            gpxOrders.Hide();
            gbxPayment.Hide();
            gpxSearch.Hide();
        }

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
        }

        private void AddOrderBtn_Click(object sender, EventArgs e)
        {
            //verander die net dat dit pas volgens textboxes en goed
            //as received date "" is dan insert hy 1900-01-01..so wanneer received en datum is 1900-01-01 dan moet datum geupdate word na current toe         
            //if (addOrder(Properties.Settings.Default.Branch, "Nvidia", "GTX TitanX x 20, GTX 1080 x 7, GTX Titan x 5", "R55555", 0, 0, DateTime.Now.Date.ToString(), "", 0))
              //  MessageBox.Show("Order added");
            //else
             //   MessageBox.Show("Order was not added");

            /*gebruik util = new gebruik();       
            frOrderConfirm f1 = new frOrderConfirm();
            f1.Show();*/
            string id = txtorderID.Text;
            if (MessageBox.Show("Are you sure you want to add this order ", "Place order", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (addOrder(Properties.Settings.Default.Branch, txtMaker.Text, items, Grandtotal.ToString(), 0, 0, DateTime.Now.ToString(), "", checkSpesialorder()))
                    MessageBox.Show("Order added");
            }
            else
                MessageBox.Show("Order not added");
        }

        public bool addOrder(string branch, string order_supplier, string order_items, string total_cost, int invoice_sent, int received, string order_date, string received_date, int special_order)
        {
            
            try
            {

                gebruik util = new gebruik();
                int last;
                last = util.getLastIdentity("Orders", "order_id", "int");

                using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True"))
                {

                    string cmdstring = "INSERT INTO Orders(branch, order_id, order_supplier, order_items, total_cost, invoice_sent, received, order_date, received_date, special_order) VALUES (@branch, @order_id, @order_supplier, @order_items, @total_cost, @invoice_sent, @received, @order_date, @received_date, @special_order)";
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

                        con.Open();
                        comm.ExecuteNonQuery();

                    }
                         
                }

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
                searchOrder();
            else if (cbxOrders.SelectedIndex == 2)
                cancelOrder();

        }

        public void searchOrder()
        {
            gpxOrders.Hide();
            gbxPayment.Hide();
            gpxSearch.Show();
            btnSD.Text = "Find order";
            btnCancel.Hide();
        }

        public void cancelOrder()
        {
            gpxOrders.Hide();
            gbxPayment.Hide();
            gpxSearch.Show();
            btnSD.Text = "Find order";
            btnCancel.Show();
        }

        public void orders()
        {
            gpxOrders.Show();
            gpxSearch.Hide();
            lbxOutput.Items.Add("=========================================");
            lbxOutput.Items.Add("Matrix Warehouse");
            lbxOutput.Items.Add("=========================================");

        }


        private void cbxSpecialorder_CheckedChanged(object sender, EventArgs e)
        {
            gbxPayment.Show();
            if (cbxSpecialorder.Checked == false)
                gbxPayment.Hide();
        }

        private void btnSD_Click(object sender, EventArgs e)//Search for a order in the database
        {
            string id = txtorderID.Text;
            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True"))
                {
                    con.Open();
                    using (SqlCommand comm = new SqlCommand("SELECT * FROM Orders WHERE order_id LIKE " + id + " ", con))
                    {
                        comm.ExecuteNonQuery();
                    }
                    con.Close();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Please enter a id to search for", "Order ID not entered", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string id = txtorderID.Text;
            if ( MessageBox.Show("Are you sure you want to cancel order " + id,"Cancel order",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True"))
                    {
                        con.Open();
                        using (SqlCommand comm = new SqlCommand("DELETE FROM Orders WHERE order_id LIKE " + id + " ", con))
                        {
                            comm.ExecuteNonQuery();
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

        private void btnAdditem_Click(object sender, EventArgs e)
        {
            try
            {
                int remove = 0;
                costperItems = Convert.ToDouble(txtPricofeachitem.Text) * Convert.ToDouble(txtQuatity.Text);
                items = items + txtItem.Text + " X " + txtQuatity.Text + ",";
                Grandtotal = Grandtotal + costperItems;

                string itemsinTxtbox = "";
                itemsinTxtbox = itemsinTxtbox + txtMaker.Text + " " + txtItem.Text + "X" + txtQuatity.Text + "\t\t" + "R" + costperItems.ToString() + "\n";
                lbxOutput.Items.Add(itemsinTxtbox);

                lbxOutput.Items.Add("=========================================");
                remove = lbxOutput.Items.Add("Total(vat incl)\t\tR" + Grandtotal.ToString());

                txtMaker.ReadOnly = true;
                txtItem.Clear();
                txtPricofeachitem.Clear();
                txtQuatity.Clear();

                if (remove > 0)
                {
                    lbxOutput.Items.RemoveAt(remove -1);
                    lbxOutput.Items.RemoveAt(remove);
                }
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

        }

        public int checkSpesialorder()
        {
            if (cbxSpecialorder.Checked)
                return 1;
            else
                return 0;
        }
    }
}
