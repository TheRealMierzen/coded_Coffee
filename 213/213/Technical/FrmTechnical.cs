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
        string allBuilditemsID;//set item status na cms id
        string orderNumber;
        string items;
        string textBoxitems;
        int last;
        int count;
        bool order = false;
        private string useranme;
 
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
            
            

        }
        public void setItems(string items)
        {
            orderedItems = orderedItems + items + ",";
            lbxoutput.Items.Add(orderedItems);
        }

        public void setOrderId(string id)
        {

            orderNumber = id + ",";

        }

        private void getItem(string itemID)
        {
            using (SqlConnection con = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
            {
                string cmdstring = "SELECT item_name, item_type FROM Stock WHERE item_id = @id";


                using (SqlCommand comm = new SqlCommand(cmdstring, con))
                {
                    con.Open();
                    comm.Parameters.AddWithValue("@id", itemID);
                    if (comm.ExecuteScalar() != null)
                    {
                        using (var reader = comm.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (reader.GetString(1).Equals("Mobo"))
                                {
                                    txtmobo.SelectedItem = (reader.GetString(0));
                                }
                                else   if (reader.GetString(1).Equals("RAM"))
                                {
                                    txtRam.SelectedItem = (reader.GetString(0));
                                }
                                else   if (reader.GetString(1).Equals("GPU"))
                                {
                                    txtGpu.SelectedItem = (reader.GetString(0));
                                }
                                else if (reader.GetString(1).Equals("PSU"))
                                {
                                    txtPsu.SelectedItem = (reader.GetString(0));
                                }
                                else   if (reader.GetString(1).Equals("CPU"))
                                {
                                    txtCpu.SelectedItem = (reader.GetString(0));
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("ID is not recognized by the system", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void fillCombo()
        {
            using (SqlConnection con = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
            {
                string cmdstring = "SELECT item_name, item_type FROM Stock WHERE branch = @branch AND Status = @status";
           

                using (SqlCommand comm = new SqlCommand(cmdstring, con))
                {
                    con.Open();
                    comm.Parameters.AddWithValue("@branch", Properties.Settings.Default.Branch);
                    MessageBox.Show(Properties.Settings.Default.Branch);
                    comm.Parameters.AddWithValue("@status", "In Stock");
                    using (var reader = comm.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader.GetString(1).Equals("Mobo"))
                            {
                                txtmobo.Items.Add(reader.GetString(0));
                            }
                            else if (reader.GetString(1).Equals("RAM"))
                            {
                                txtRam.Items.Add(reader.GetString(0));
                            }
                            else if (reader.GetString(1).Equals("GPU"))
                            {
                                txtGpu.Items.Add(reader.GetString(0));                              
                            }
                            else  if (reader.GetString(1).Equals("PSU"))
                            {
                                txtPsu.Items.Add(reader.GetString(0));
                            }
                            else  if (reader.GetString(1).Equals("CPU"))
                            {
                                txtCpu.Items.Add(reader.GetString(0));
                            }
                            
                        }
                    }
                    con.Close();

                }
            }
        }

        private void FrmTechnical_Load(object sender, EventArgs e)
        {
            gpbClient.Hide();
            gpxtech.Hide();
            lbxoutput.Hide();
            btnQuote.Hide();
            btnPlaceorder.Hide();
            cbxLayout.SelectedIndex = 0;
            fillCombo();
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
            SqlConnection con = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT");
            con.Open();
            if(txtCpu.Text == null || txtGpu.Text == null || txtmobo.Text ==null || txtPsu.Text == null || txtMics.Text == null || txtRam.Text == null)
            {
                if(MessageBox.Show("Are you sure you entered all the fields correctly?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    //Send to order form
                    int count = 0;
                    string ids = "";
                    string names = "";


                    if (txtCpu.Text == null)
                        count++;
                    else
                    {
                        ids = ids + txtCpu.Text + ",";
                        SqlCommand getID = new SqlCommand("SELECT item_id FROM Stock WHERE item_name = @name",con);
                        getID.Parameters.AddWithValue("@name", txtCpu.Text);
                        names = names + getID.ExecuteScalar().ToString() + ",";
                    }
                    if (txtGpu.Text == null)
                        count++;
                    else
                    {
                        ids = ids + txtGpu.Text + ",";
                        SqlCommand getID = new SqlCommand("SELECT item_id FROM Stock WHERE item_name = @name",con);
                        getID.Parameters.AddWithValue("@name", txtGpu.Text);
                        names = names + getID.ExecuteScalar().ToString() + ",";
                    }
                    if (txtmobo.Text == null)
                        count++;
                    else
                    {
                        ids = ids + txtmobo.Text + ",";
                        SqlCommand getID = new SqlCommand("SELECT item_id FROM Stock WHERE item_name = @name",con);
                        getID.Parameters.AddWithValue("@name", txtmobo.Text);
                        names = names + getID.ExecuteScalar().ToString() + ",";
                    }
                    if (txtPsu.Text == null)
                        count++;
                    else
                    {
                        ids = ids + txtPsu.Text;
                        SqlCommand getID = new SqlCommand("SELECT item_id FROM Stock WHERE item_name = @name",con);
                        getID.Parameters.AddWithValue("@name", txtPsu.Text);
                        names = names + getID.ExecuteScalar().ToString() + ",";
                    }
                    if (txtMics.Text == null)
                        count++;
                    else
                    {
                        ids = ids + txtMics.Text + ",";
                        SqlCommand getID = new SqlCommand("SELECT item_id FROM Stock WHERE item_name = @name",con);
                        getID.Parameters.AddWithValue("@name", txtMics.Text);
                        names = names + getID.ExecuteScalar().ToString() + ",";
                    }
                    if (txtRam.Text == null)
                        count++;
                    else
                    {
                        ids = ids + txtRam.Text + ",";
                        SqlCommand getID = new SqlCommand("SELECT item_id FROM Stock WHERE item_name = @name",con);
                        getID.Parameters.AddWithValue("@name", txtRam.Text);
                        names = names + getID.ExecuteScalar().ToString() + ",";
                    }

                    gebruik util = new gebruik();
                    last = util.getLastIdentity("Cms", "cms_id", "int");
                    AddCustomBuild(Properties.Settings.Default.Branch, last.ToString(), names, ids, "", "", txtEmail.Text, "", 0);
                    OrderForm Of = new OrderForm(useranme, count, txtEmail.Text);
                    
                }
                else
                {
                    //Close message
                }
            }
            else
            {
                if(MessageBox.Show("Are you sure you entered all the fields correctly?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string itemIDS = "";
                    gebruik util = new gebruik();
                    last = util.getLastIdentity("Cms", "cms_id", "int");
                    string itemNames = txtCpu.Text + "," + txtGpu.Text + "," + txtMics.Text + "," + txtmobo.Text + "," + txtPsu.Text + "," + txtRam.Text + ",";
                    SqlCommand getID = new SqlCommand("SELECT item_id FROM Stock WHERE item_name = @name",con);
                    getID.Parameters.AddWithValue("@name", txtCpu.Text);
                    itemIDS = itemIDS + getID.ExecuteScalar().ToString() + ",";
                                        SqlCommand getID2 = new SqlCommand("SELECT item_id FROM Stock WHERE item_name = @name",con);
                    getID2.Parameters.AddWithValue("@name", txtGpu.Text);
                    itemIDS = itemIDS + getID.ExecuteScalar().ToString() + ",";
                                        SqlCommand getID3 = new SqlCommand("SELECT item_id FROM Stock WHERE item_name = @name",con);
                    getID3.Parameters.AddWithValue("@name", txtMics.Text);
                    itemIDS = itemIDS + getID.ExecuteScalar().ToString() + ",";
                                        SqlCommand getID4 = new SqlCommand("SELECT item_id FROM Stock WHERE item_name = @name",con);
                    getID4.Parameters.AddWithValue("@name", txtmobo.Text);
                    itemIDS = itemIDS + getID.ExecuteScalar().ToString() + ",";
                                        SqlCommand getID5 = new SqlCommand("SELECT item_id FROM Stock WHERE item_name = @name",con);
                    getID5.Parameters.AddWithValue("@name", txtPsu.Text);
                    itemIDS = itemIDS + getID.ExecuteScalar().ToString() + ",";
                                        SqlCommand getID6 = new SqlCommand("SELECT item_id FROM Stock WHERE item_name = @name",con);
                    getID6.Parameters.AddWithValue("@name", txtRam.Text);
                    itemIDS = itemIDS + getID.ExecuteScalar().ToString() + ",";
                    AddCustomBuild(Properties.Settings.Default.Branch, last.ToString(), itemNames, itemIDS, "", "", txtEmail.Text, DateTime.Now.ToString(), 1);
                    MessageBox.Show("All items are accounted for the custom build, refferance number: " + last.ToString(), "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void FrmTechnical_Activated(object sender, EventArgs e)
        {

        }

        public void orderItems(string message)
        {
            if (count == 0 && message != "0")
                if (MessageBox.Show("Item " + message +" not in stock. Do you want to order? ", "Order item", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    OrderForm OF = new OrderForm(true, this);
                    
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

        public bool AddCustomBuild(string branch, string cms_id,string cms_Items,string cms_itemIDs,string cms_order,string cms_OrderID,string cms_email,string date_complete,int complete)
        {
            try
            {


                using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True"))
                {

                    string cmdstring = "INSERT INTO Cms(branch, cms_id, cms_items,cms_itemsIDs,cms_order,cms_orderID,cms_email,date_complete,complete) VALUES (@branch, @cms_id, @cms_items,@cms_itemsIDs,@cms_order,@cms_orderID,@cms_email,@date_complete,@complete)";
                    using (SqlCommand comm = new SqlCommand(cmdstring, con))
                    {

                        comm.Parameters.AddWithValue("@branch", Properties.Settings.Default.Branch);
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
             if (MessageBox.Show("Are you sure you want to add this order ", "Place order", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
             {
                 if(AddCustomBuild(Properties.Settings.Default.Branch,last.ToString(), allBuilditems, allBuilditemsID, orderedItems, orderNumber, txtEmail.Text,"", 0))
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbID_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txbID_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
            {
            if (e.KeyData == Keys.Tab)
            {
                getItem(txbID.Text);
            }
        }
     }
}
