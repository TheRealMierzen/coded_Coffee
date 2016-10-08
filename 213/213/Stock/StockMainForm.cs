using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Data.Sql;
using System.Data.OleDb;
using System.IO;
using System.Data.SqlClient;

namespace _213
{
   
    public partial class StockMainFormCLN : Form
    {
        private string userNme;
        private string missID = "";
        public StockMainFormCLN()
        {
            InitializeComponent();
        }
        public StockMainFormCLN(string user)
        {
            InitializeComponent();
            userNme = user;
        }

        private void cmbSelectStockAction_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void StockMainForm_Shown(object sender, EventArgs e)
        {
            try
            {

                //  this.TopMost = true;
                this.FormBorderStyle = FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                txbStockTake.AppendText("\r\n=======================================");
                txbStockTake.AppendText("\r\nList of Items Recorded:");
                txbStockTake.AppendText("\r\n=======================================");
                SqlConnection stockConnection = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT");
                stockConnection.Open();

                SqlCommand getStockCountCLN = new SqlCommand("SELECT COUNT(item_id) FROM Stock", stockConnection);
                int TotalItems = 0;
                TotalItems = Convert.ToInt16(getStockCountCLN.ExecuteScalar());
                txbStockTakeReport.AppendText("\r\n Items Added Today:");

                SqlCommand getStock = new SqlCommand("SELECT item_id, item_name FROM Stock WHERE initial_add = @add AND branch = @branch", stockConnection);
                getStock.Parameters.AddWithValue("@add", DateTime.Today);

                getStock.Parameters.AddWithValue("@branch", Properties.Settings.Default.Branch);
                if (getStock.ExecuteScalar() == null)
                {
                    txbStockTakeReport.AppendText("\r\nNo Stock Added Today");
                }
                else
                {
                    SqlDataReader reader = getStock.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            txbStockTakeReport.AppendText("\r\n" + reader.GetString(1) + "\t" + reader.GetString(0));
                        }
                    }
                    else
                    {
                        txtStockTakeItemID.AppendText("\r\n");
                    }
                    reader.Close();
                }

                txbStockTakeReport.AppendText("\r\n=======================================");
                txbStockTakeReport.AppendText("\r\n Items Sold Today:");

                SqlCommand getSale = new SqlCommand("SELECT item_id, item_name FROM Stock WHERE last_updated = @up AND status = @status AND branch = @branch", stockConnection);
                getSale.Parameters.AddWithValue("@up", DateTime.Today);
                getSale.Parameters.AddWithValue("@status", "Sold");
                getSale.Parameters.AddWithValue("@branch", Properties.Settings.Default.Branch);
                if (getSale.ExecuteScalar() == null)
                {
                    txbStockTakeReport.AppendText("\r\nNo Stock Sold Today");
                }
                else
                {
                    SqlDataReader reader = getSale.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            txbStockTakeReport.AppendText("\r\n" + reader.GetString(1) + "\t" + reader.GetString(0));
                        }
                    }
                    else
                    {
                        txtStockTakeItemID.AppendText("\r\n");
                    }
                    reader.Close();
                }
                
                txbStockTakeReport.AppendText("\r\n=======================================");
                txbStockTakeReport.AppendText("\r\n Items Removed Today:");
                SqlCommand getStockR = new SqlCommand("SELECT item_id, item_name FROM Stock WHERE last_updated = @upp AND status = @status AND branch = @branch", stockConnection);
                getStockR.Parameters.AddWithValue("@upp", DateTime.Today);
                getStockR.Parameters.AddWithValue("@status", "Removed");
                getStockR.Parameters.AddWithValue("@branch", Properties.Settings.Default.Branch);
                if (getStockR.ExecuteScalar() == null)
                {
                    txbStockTakeReport.AppendText("\r\nNo Stock Removed Today");
                }
                else
                {
                    SqlDataReader reader = getStockR.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            txbStockTakeReport.AppendText("\r\n" + reader.GetString(1) + "\t" + reader.GetString(0));
                        }
                    }
                    else
                    {
                        txtStockTakeItemID.AppendText("\r\n");
                    }
                    reader.Close();
                }

                txbStockTakeReport.AppendText("\r\n=======================================");
                txbStockTakeReport.AppendText("\r\n Items Transfered Today (Sent):");

                SqlCommand getStockT = new SqlCommand("SELECT transfer_id, item_ids FROM Transfers WHERE send_date = @send AND from_branch = @branch", stockConnection);
                getStockT.Parameters.AddWithValue("@send", DateTime.Today);
                getStockT.Parameters.AddWithValue("@branch", Properties.Settings.Default.Branch);

                if (getStockT.ExecuteScalar() == null)
                {
                    txbStockTakeReport.AppendText("\r\nNo Stock Trasfered Today");
                }
                else
                {
                    string ids = "";
                    SqlDataReader reader = getStockT.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            ids = reader.GetString(1);
                            do
                            {
                                SqlConnection stockConnection2 = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT");
                                stockConnection2.Open();

                                int pos = ids.IndexOf(',');
                                string id = ids.Substring(0, pos);
                                ids = ids.Remove(0, pos + 1);
                                SqlCommand getDes = new SqlCommand("SELECT item_name from Stock WHERE item_id = @id", stockConnection2);
                                getDes.Parameters.AddWithValue("@id", id);
                                if (getDes.ExecuteScalar() != null)
                                {
                                    string message = ("\r\n Transfer ID: " + reader.GetString(0) + "\t" + getDes.ExecuteScalar().ToString());
                                    txbStockTakeReport.AppendText(message);
                                }
                                else
                                {
                                    ids = "";
                                }

                                stockConnection2.Close();
                            } while (ids != "");

                        }
                    }
                    else
                    {
                        txtStockTakeItemID.AppendText("\r\n");
                    }
                    reader.Close();
                }
                txbStockTakeReport.AppendText("\r\n=======================================");
                stockConnection.Close();
                checkTransfers();
                checkOrders();

            }
            catch (SqlException s)
            {
                if (s.Number == 2627)
                {
                    MessageBox.Show("Error: Duplicate IDs" + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error in database" + s, "Error" + s, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (NullReferenceException s)
            {
                MessageBox.Show("Error: Please fill in all the fields" + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (InvalidOperationException s)
            {
                MessageBox.Show("Error: Invalid Operation" + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception s)
            {
                MessageBox.Show("Error: " + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbSelectStockAction_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Add Stock Selected and Confirmed
            if (cmbSelectStockAction.SelectedIndex == 0)
            {

                //Vra of user nuwe listing will maak of net stock by sit
                if (MessageBox.Show("Do you want to create a new listing?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    StockAddFormCLN frmStockAddCLN = new StockAddFormCLN(userNme);
                    frmStockAddCLN.ShowDialog();
                }
                else
                {
                    StockAddFormUPD frmStockAddUPD = new StockAddFormUPD(userNme);
                    frmStockAddUPD.ShowDialog();
                }

            }
            if (cmbSelectStockAction.SelectedIndex == 1)
            {
                StockFindForm frmStockFind = new StockFindForm(userNme);
                frmStockFind.ShowDialog();
            }
            if (cmbSelectStockAction.SelectedIndex == 2)
            { 
                StockAddFormUPD frmStockAddUPD = new StockAddFormUPD(userNme);
                frmStockAddUPD.ShowDialog();
            }
            if (cmbSelectStockAction.SelectedIndex == 3)
            {
                StockTransferSendForm frmSendStock = new StockTransferSendForm(userNme);                
                frmSendStock.ShowDialog();
            }
            if (cmbSelectStockAction.SelectedIndex == 4)
            {
                StockRemoveForm stf = new StockRemoveForm(userNme);
                stf.ShowDialog();
            }
        }

        private void StockMainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBackMain_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1(userNme);
            this.Hide();
            this.Close();
            frm1.Show();
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCompleteStockTake_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection stockConnection2 = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT");
                stockConnection.Open();
                SqlCommand getMiss = new SqlCommand("SELECT item_id, item_name FROM Stock WHERE checked = @check AND branch = @branch", stockConnection);
                getMiss.Parameters.AddWithValue("@check", 0);
                getMiss.Parameters.AddWithValue("@branch", Properties.Settings.Default.Branch);
                if (getMiss.ExecuteScalar() == null)
                {

                    txbStockTake.AppendText("All Items are Checked");
                }
                else
                {
                    txbStockTake.AppendText("\r\nThese Items were not Checked:");
                    SqlDataReader reader = getMiss.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            txbStockTake.AppendText("\r\n" + reader.GetString(1) + "\t" + reader.GetString(0));
                        }
                    }
                    else
                    {
                        txtStockTakeItemID.AppendText("\r\n");
                    }
                    reader.Close();
                }
                if (missID == "")
                {
                    txbStockTake.AppendText("\r\nNo items missing");
                }
                else
                {
                    txbStockTake.AppendText("\r\nThese item ID's are not recognized by the system: " + missID);
                }
                txbStockTake.AppendText("\r\n=======================================");
                gebruik.addAction(userNme);
                stockConnection.Close();
                gebruik.addAction(userNme);
                //  gebruik.log(DateTime.Now, userNme, "Completed stock take");
            }
            catch (SqlException s)
            {
                if (s.Number == 2627)
                {
                    MessageBox.Show("Error: Duplicate IDs" + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error in database" + s, "Error" + s, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (NullReferenceException s)
            {
                MessageBox.Show("Error: Please fill in all the fields" + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (InvalidOperationException s)
            {
                MessageBox.Show("Error: Invalid Operation" + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception s)
            {
                MessageBox.Show("Error: " + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkOrders()
        {
            try
            {
                SqlConnection stockConnection = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                stockConnection.Open();
                SqlCommand checkOrders = new SqlCommand("SELECT order_id, order_items FROM Orders WHERE branch = @branch AND eta = @eta", stockConnection);
                checkOrders.Parameters.AddWithValue("@branch", Properties.Settings.Default.Branch);
                checkOrders.Parameters.AddWithValue("@eta", DateTime.Today);
                if (checkOrders.ExecuteScalar() != null)
                {
                    SqlDataReader reader = checkOrders.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            if (MessageBox.Show("Order ID: " + reader.GetString(0) + " Was sent to this branch with items: " + reader.GetString(1), "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                StockAddFormCLN frmAddCLN = new StockAddFormCLN(userNme);
                                frmAddCLN.ShowDialog();
                            }
                        }
                    }
                    else
                    {
                        txtStockTakeItemID.AppendText("\r\n");
                    }
                    reader.Close();
                }
            }


            catch (SqlException s)
            {
                if (s.Number == 2627)
                {
                    MessageBox.Show("Error: Duplicate IDs" + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error in database" + s, "Error" + s, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (NullReferenceException s)
            {
                MessageBox.Show("Error: Please fill in all the fields" + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (InvalidOperationException s)
            {
                MessageBox.Show("Error: Invalid Operation" + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception s)
            {
                MessageBox.Show("Error: " + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void checkTransfers()
        {
            try
            {


                SqlConnection stockConnection = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT");
                stockConnection.Open();
                SqlCommand checkTransfers = new SqlCommand("SELECT transfer_id, item_ids, from_branch FROM Transfers WHERE to_branch = @branch AND eta = @eta", stockConnection);

                checkTransfers.Parameters.AddWithValue("@branch", Properties.Settings.Default.Branch);
                checkTransfers.Parameters.AddWithValue("@eta", DateTime.Today);

                if (checkTransfers.ExecuteScalar() != null)
                {
                    SqlDataReader reader = checkTransfers.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            if (MessageBox.Show("Transfer ID: " + reader.GetString(0) + " Was sent to this branch from: " + reader.GetString(2), "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                StockTransferRecieve frmRecieve = new StockTransferRecieve(userNme, reader.GetString(1), reader.GetString(0));
                                frmRecieve.ShowDialog();
                            }
                        }
                    }
                    else
                    {
                        txtStockTakeItemID.AppendText("\r\n");
                    }
                    reader.Close();
                }
            }
            catch (SqlException s)
            {
                if (s.Number == 2627)
                {
                    MessageBox.Show("Error: Duplicate IDs" + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error in database" + s, "Error" + s, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (NullReferenceException s)
            {
                MessageBox.Show("Error: Please fill in all the fields" + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (InvalidOperationException s)
            {
                MessageBox.Show("Error: Invalid Operation" + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception s)
            {
                MessageBox.Show("Error: " + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCompare_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection stockConnection = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                stockConnection.Open();
                SqlCommand getID = new SqlCommand("SELECT item_ID, item_name FROM Stock WHERE item_id = @itemID AND branch = @branch AND status = @status", stockConnection);
                getID.Parameters.AddWithValue("@branch", Properties.Settings.Default.Branch);
                getID.Parameters.AddWithValue("@itemID", txtStockTakeItemID.Text);
                getID.Parameters.AddWithValue("@status", "In Stock");
                if (getID.ExecuteScalar() != null)
                {

                    SqlDataReader reader = getID.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            SqlConnection stockConnection2 = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                            txbStockTake.AppendText("\r\n" + reader.GetString(1) + "\t" + reader.GetString(0));
                            string id = reader.GetString(0);
                            stockConnection2.Open();
                            SqlCommand checkStock = new SqlCommand("UPDATE Stock SET checked = '1' WHERE item_id = @id", stockConnection2);
                            checkStock.Parameters.AddWithValue("@id", id);

                            checkStock.ExecuteNonQuery();
                            stockConnection2.Close();
                        }
                    }
                    else
                    {
                        txbStockTake.AppendText("\r\n");
                    }
                    reader.Close();

                }
                else
                {
                    missID = missID + txtStockTakeItemID.Text + ",";
                    txbStockTake.AppendText("\r\n" + txtStockTakeItemID.Text + ": Unknown ID");
                }
            }
            catch (SqlException s)
            {
                if (s.Number == 2627)
                {
                    MessageBox.Show("Error: Duplicate IDs" + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Error in database" + s, "Error" + s, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (NullReferenceException s)
            {
                MessageBox.Show("Error: Please fill in all the fields" + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (InvalidOperationException s)
            {
                MessageBox.Show("Error: Invalid Operation" + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception s)
            {
                MessageBox.Show("Error: " + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
