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
    public partial class FrmTechnical : Form
    {
        string allBuilditems;
        string orderedItems;
        string allBuilditemsID;
        string orderNumber;
        string items;
        string textBoxitems;
        int last;
        int count;
        bool order = false;
 
        public FrmTechnical()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        public FrmTechnical(string items,string ordernumber)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            orderedItems = orderedItems + items + ",";
            orderNumber = ordernumber + ",";

        }
        public void setItems(string items)
        {
            this.items = items;
        }

        private void FrmTechnical_Load(object sender, EventArgs e)
        {
            gpbClient.Hide();
            gpxtech.Hide();
            lbxoutput.Hide();
            btnQuote.Hide();
            btnPlaceorder.Hide();
            cbxLayout.SelectedIndex = 0;
        }


        private void custombuilds()//Om die layout van die form te verander na die custombuilds
        {
            gpbClient.Show();
            gpxtech.Show();
            lbxoutput.Show();
            btnPlaceorder.Show();
            gpxtech.Text = "Custom builds";
            lbxoutput.Text = "Quote for custom builds ";
            groupBox2.Text = "Custom build";
            btnQuote.Show();
           
        }

        private void repairs()//Om die layout van die from te verander na die repairs
        {
            gpbClient.Show();
            gpxtech.Text = "Repairs";
            gpxtech.Show();
            lbxoutput.Show();
            btnPlaceorder.Show();
            lbxoutput.Text = "Quote for repairs ";
            groupBox2.Text = "Repairs";
        }

        private void repairs(string itemfromOrder)//Om die layout van die from te verander na die repairs
        {
            
        }

        private void cbxLayout_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxLayout.SelectedIndex == 0)
                custombuilds();

            if (cbxLayout.SelectedIndex == 1)
                repairs();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Activate();
            this.Hide();
            this.Close();
        }

        private void btnQuote_Click(object sender, EventArgs e)
        {
            lbxoutput.Items.Clear();
            lbxoutput.Items.Add("\n");
            lbxoutput.Items.Add("\n Client Info");
            lbxoutput.Items.Add("\n " + txtName.Text);
            lbxoutput.Items.Add(" \n " + txtEmail.Text);
            lbxoutput.Items.Add("\n");
            lbxoutput.Items.Add("\n Components");

            Mobo();
            lbxoutput.Items.Add("\n " + items);
            Ram();
            lbxoutput.Items.Add("\n " + items);
            CPU();
            lbxoutput.Items.Add("\n " + items);
            GPU();
            lbxoutput.Items.Add("\n " + items);
            Mics();
            lbxoutput.Items.Add("\n " + items);
            PSU();
            lbxoutput.Items.Add("\n " + items);
            HDDprimary();
            lbxoutput.Items.Add("\n " + items);
            HDDprimary();
            lbxoutput.Items.Add("\n " + items);
        }

        private void FrmTechnical_Activated(object sender, EventArgs e)
        {

        }

        public void orderItems(string message)
        {
            if (count == 0 && message != "0")
                if (MessageBox.Show("Item " + message +" not in stock. Do you want to order? ", "Order item", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    OrderForm OF = new OrderForm(true);
                    //OF.Activate();twyfel of die nodig is, niks van myne het dit in nie
                    OF.ShowDialog();

                }
        }
        
        public void Mobo()
        {
            try
            {
                count = 0;
                using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True"))
                {
                    using (SqlCommand comm = new SqlCommand("SELECT * FROM Stock WHERE item_id LIKE " + Convert.ToInt16(txtmobo.Text) + "", con))
                    {
                        con.Open();
                        SqlDataReader sqlreader = comm.ExecuteReader();

                        while (sqlreader.Read())
                        {
                            items = (string)sqlreader[2] + " " + (string)sqlreader[8];
                            allBuilditems = allBuilditems + (string)sqlreader[8] + ",";
                            allBuilditemsID = allBuilditemsID + (string)sqlreader[1] + ",";
                            txtmobo.Text = items;
                            count++;
                            textBoxitems = textBoxitems + " ,";
                        }
                        sqlreader.Close();
                        con.Close();
                    }
                }
                orderItems(txtmobo.Text);
            }
            catch (SqlException)
            {
                //MessageBox.Show("No items could be found", "No items found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                orderItems("0");
            }
        }

        public void Ram()
        {
            try
            {
                count = 0;
                using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True"))
                {
                    using (SqlCommand comm = new SqlCommand("SELECT * FROM Stock WHERE item_id LIKE " + Convert.ToInt16(txtRam.Text) +"", con))
                    {
                        con.Open();
                        SqlDataReader sqlreader = comm.ExecuteReader();

                        while (sqlreader.Read())
                        {
                            items = (string)sqlreader[2] + " " + (string)sqlreader[8];
                            allBuilditems = allBuilditems + (string)sqlreader[8] + ",";
                            allBuilditemsID = allBuilditemsID + (string)sqlreader[1] + ",";
                            txtRam.Text = items;
                            textBoxitems = textBoxitems + " ,";
                        }
                        sqlreader.Close();
                        con.Close();
                    }
                }
                orderItems(txtRam.Text);
            }
            catch (SqlException)
            {
                //MessageBox.Show("No items could be found", "No items found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                orderItems("0");
            }
        }


        public void CPU()
        {
            try
            {
                count = 0;
                using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True"))
                {
                    using (SqlCommand comm = new SqlCommand("SELECT * FROM Stock WHERE item_id = " + txtCpu.Text +"", con))
                    {
                        con.Open();
                        SqlDataReader sqlreader = comm.ExecuteReader();

                        while (sqlreader.Read())
                        {
                            items = (string)sqlreader[2] + " " + (string)sqlreader[8];
                            allBuilditems = allBuilditems + (string)sqlreader[8] + ",";
                            allBuilditemsID = allBuilditemsID + (string)sqlreader[1] + ",";
                            txtCpu.Text = items;
                            textBoxitems = textBoxitems + " ,";
                        }
                        sqlreader.Close();
                        con.Close();
                    }
                }
                orderItems(txtmobo.Text);
            }
            catch (SqlException)
            {
                //MessageBox.Show("No items could be found", "No items found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                orderItems("0");
            }
        }

        public void PSU()
        {
            try
            {
                count = 0;
                using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True"))
                {
                    using (SqlCommand comm = new SqlCommand("SELECT * FROM Stock WHERE item_id = " + txtPsu.Text + "", con))
                    {
                        con.Open();
                        SqlDataReader sqlreader = comm.ExecuteReader();

                        while (sqlreader.Read())
                        {
                            items = (string)sqlreader[2] + " " + (string)sqlreader[8];
                            allBuilditems = allBuilditems + (string)sqlreader[8] + ",";
                            allBuilditemsID = allBuilditemsID + (string)sqlreader[1] + ",";
                            txtPsu.Text = items;
                            textBoxitems = textBoxitems + " ,";
                        }
                        sqlreader.Close();
                        con.Close();
                    }
                }
                orderItems(txtPsu.Text);
            }
            catch (SqlException)
            {
               // MessageBox.Show("No items could be found", "No items found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                orderItems("0");
            }
        }

        public void GPU()
        {
            try
            {
                count = 0;
                using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True"))
                {
                    using (SqlCommand comm = new SqlCommand("SELECT * FROM Stock WHERE item_id = " + txtGpu.Text + "", con))
                    {
                        con.Open();
                        SqlDataReader sqlreader = comm.ExecuteReader();

                        while (sqlreader.Read())
                        {
                            items = (string)sqlreader[2] + " " + (string)sqlreader[8];
                            allBuilditems = allBuilditems + (string)sqlreader[8] + ",";
                            allBuilditemsID = allBuilditemsID + (string)sqlreader[1] + ",";
                            txtGpu.Text = items;
                            textBoxitems = textBoxitems + " ,";
                        }
                        sqlreader.Close();
                        con.Close();
                    }
                }
                orderItems(txtGpu.Text);
            }
            catch (SqlException)
            {
                //MessageBox.Show("No items could be found", "No items found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                orderItems("0");
            }
        }

        public void HDDprimary()
        {
            try
            {
                count = 0;
                using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True"))
                {
                    using (SqlCommand comm = new SqlCommand("SELECT * FROM Stock WHERE item_id = " + txtPrim.Text + "", con))
                    {
                        con.Open();
                        SqlDataReader sqlreader = comm.ExecuteReader();

                        while (sqlreader.Read())
                        {
                            items = (string)sqlreader[2] + " " + (string)sqlreader[8];
                            allBuilditems = allBuilditems + (string)sqlreader[8] + ",";
                            allBuilditemsID = allBuilditemsID + (string)sqlreader[1] + ",";
                            txtPrim.Text = items;
                        }
                        sqlreader.Close();
                        con.Close();
                    }
                }

            }
            catch (SqlException)
            {
                //MessageBox.Show("No items could be found", "No items found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                orderItems("0");
            }
        }


        public void HDDSecondary()
        {
            try
            {
                count = 0;
                using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True"))
                {
                    using (SqlCommand comm = new SqlCommand("SELECT * FROM Stock WHERE item_id = " + txtSec.Text + "", con))
                    {
                        con.Open();
                        SqlDataReader sqlreader = comm.ExecuteReader();

                        while (sqlreader.Read())
                        {
                            items = (string)sqlreader[2] + " " + (string)sqlreader[8];
                            allBuilditems = allBuilditems + (string)sqlreader[8] + ",";
                            allBuilditemsID = allBuilditemsID + (string)sqlreader[1] + ",";
                        }
                        sqlreader.Close();
                        con.Close();
                    }
                }

            }
            catch (SqlException)
            {
                //MessageBox.Show("No items could be found", "No items found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                orderItems("0");
            }
        }

        public void Mics()
        {
            try
            {
                count = 0;
                using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True"))
                {
                    using (SqlCommand comm = new SqlCommand("SELECT * FROM Stock WHERE item_id = " + Convert.ToInt16(txtMics.Text) + "", con))
                    {
                        con.Open();
                        SqlDataReader sqlreader = comm.ExecuteReader();

                        while (sqlreader.Read())
                        {
                            items = (string)sqlreader[2] + " " + (string)sqlreader[8];
                            allBuilditems = allBuilditems + (string)sqlreader[8] + ",";
                            allBuilditemsID = allBuilditemsID + (string)sqlreader[1] + ",";
                            txtMics.Text = items;
                            textBoxitems = textBoxitems + " ,";
                        }
                        sqlreader.Close();
                        con.Close();
                    }
                }
                orderItems(txtMics.Text);
            }
            catch (SqlException)
            {
                //MessageBox.Show("No items could be found", "No items found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                orderItems("0");
            }
        }

        public bool AddCustomBuild(string cms_id,string cms_Items,string cms_itemIDs,string cms_order,string cms_OrderID,string cms_email,string date_complete,int complete)
        {
            try
            {
                gebruik util = new gebruik();
                last = util.getLastIdentity("Cms", "cms_id", "int");

                using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True"))
                {

                    string cmdstring = "INSERT INTO Cms(cms_id, cms_items,cms_itemsIDs,cms_order,cms_orderID,cms_email,date_complete,complete) VALUES (@cms_id, @cms_items,@cms_itemsIDs,@cms_order,@cms_orderID,@cms_email,@date_complete,@complete)";
                    using (SqlCommand comm = new SqlCommand(cmdstring, con))
                    {

                        comm.Parameters.AddWithValue("@cms_id", last + 1);
                        comm.Parameters.AddWithValue("@cms_items", cms_Items);
                        comm.Parameters.AddWithValue("@cms_itemsIDs", cms_itemIDs);
                        comm.Parameters.AddWithValue("@cms_order", cms_order);
                        comm.Parameters.AddWithValue("@cms_orderID", cms_OrderID);
                        comm.Parameters.AddWithValue("@cms_email", cms_email);
                        comm.Parameters.AddWithValue("@date_complete", date_complete);
                        comm.Parameters.AddWithValue("@complete", complete);

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

        private void btnPlaceorder_Click(object sender, EventArgs e)
        {
             if (MessageBox.Show("Are you sure you want to add this order ", "Place order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
             {
                 if(AddCustomBuild(last.ToString(), allBuilditems, allBuilditemsID, orderedItems, orderNumber, txtEmail.Text,"", 0))
                 {
                    if (order == false)
                    {
                        gebruik util = new gebruik();
                       
                    }
                 }
             }
        }


        private void txtmobo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }

        private void txtRam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }

        private void txtGpu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }

        private void txtPsu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }

        private void txtCpu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }

        private void txtMics_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;
        }
     }
}
