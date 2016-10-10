using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.OleDb;
using System.IO;
using System.Data.SqlClient;

namespace _213
{
    public partial class StockTransferSendForm : Form
    {
        private string userNme;
        private string ids;
        private int count;
        private string stockID;
        public StockTransferSendForm()
        {


            InitializeComponent();

        }

        public StockTransferSendForm(string user)
        {


            InitializeComponent();
            userNme = user;

        }

        private void btnConfirmSend_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to complete this action?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //as user ja se
                SqlConnection stockConnection = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                stockConnection.Open();

                SqlCommand getStockCountCLN = new SqlCommand("SELECT COUNT(transfer_id) FROM Transfers", stockConnection);
                int TotalItems = 0;
                TotalItems = Convert.ToInt16(getStockCountCLN.ExecuteScalar()) + 1;
                this.Hide();
                this.Close();
            }
            else
            {
                //as user nee se

            }
        }

        private void btnCancelSend_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to complete this action?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //as user ja se
                //Hier kom die code om die nuwe Stock listing te add

                this.Hide();
                this.Close();
            }
            else
            {
                //as user nee se

            }
        }

        private void StockTransferSendForm_Load(object sender, EventArgs e)
        {

        }

        private void cmbBranchSend_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblSelectItem_Click(object sender, EventArgs e)
        {

        }

        private void btnAddToTransferList_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection stockConnection = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT");
                stockConnection.Open();
                count = 0;
                SqlCommand getStockID = new SqlCommand("SELECT item_id FROM Stock WHERE item_id = @id AND Status = @status AND branch = @branch", stockConnection);
                getStockID.Parameters.AddWithValue("@id", txbItemIDTransfer.Text);
                getStockID.Parameters.AddWithValue("@status", "In Stock");

                getStockID.Parameters.AddWithValue("@branch", Properties.Settings.Default.Branch);
                SqlCommand getDescription = new SqlCommand("SELECT item_name from Stock WHERE item_id = @id and Status = @status AND branch = @branch", stockConnection);
                getDescription.Parameters.AddWithValue("@id", txbItemIDTransfer.Text);
                getDescription.Parameters.AddWithValue("@status", "In Stock");

                getDescription.Parameters.AddWithValue("@branch", Properties.Settings.Default.Branch);
                string stockName = "";


                if ((getStockID.ExecuteScalar() == null) | (getDescription.ExecuteScalar() == null))
                {
                    MessageBox.Show("ID not found \r\nMake sure the item is not up for a custom build \r\nor if the item is ment for another branch \r\n or if the item is not already in transit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        stockID = getStockID.ExecuteScalar().ToString();
                        stockName = getDescription.ExecuteScalar().ToString();
                        SqlCommand updateStockTransfer = new SqlCommand("UPDATE Stock SET branch = @branch, last_updated = @last, Status = @status WHERE item_id = @id", stockConnection);
                        updateStockTransfer.Parameters.AddWithValue("@branch", "In Transit");
                        updateStockTransfer.Parameters.AddWithValue("@last", DateTime.Now);
                        updateStockTransfer.Parameters.AddWithValue("Status", "In Transit");
                        updateStockTransfer.Parameters.AddWithValue("@id", stockID);
                        updateStockTransfer.ExecuteNonQuery();

                        ids = ids + stockID + ",";
                        stockConnection.Close();
                        txbStockTransferReport.AppendText("\r\n" + stockID + "       " + stockName + "\r\n");
                        txbItemIDTransfer.Text = "";
                        MessageBox.Show("Item transfer added to manuscript successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (SqlException s)
                    {
                        if (s.Number == 53)
                        {
                            gebruik other = new gebruik();
                            if (other.CheckConnection() && count < 4)
                            {
                                count = count + 1;
                                btnAddToTransferList.PerformClick();
                            }
                            else
                                MessageBox.Show("Error connectiong to Database, Please check internet connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                            MessageBox.Show("Error in database" + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (NullReferenceException s)
                    {
                        MessageBox.Show("Error: Please fill in valid info" + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            }
            catch (SqlException s)
            {
                if (s.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection() && count < 4)
                    {
                        count = count + 1;
                        btnAddToTransferList.PerformClick();
                    }
                    else
                        MessageBox.Show("Error connectiong to Database, Please check internet connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    MessageBox.Show("Error in database" + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullReferenceException s)
            {
                MessageBox.Show("Error: Please fill in valid info" + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void StockTransferSendForm_Shown(object sender, EventArgs e)
        {




        }

        private void btnUndoLastTransfer_Click(object sender, EventArgs e)
        {
           

        }

        private void btnConfirmSend_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection stockConnection = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT");

                    stockConnection.Open();
                    count = 0;
                    SqlCommand getStockCountCLN = new SqlCommand("SELECT COUNT(transfer_id) FROM Transfers", stockConnection);
                    int TotalItems = 0;

                    TotalItems = Convert.ToInt16(getStockCountCLN.ExecuteScalar()) + 1;
                    //ids = ids + stockID + ",";
                    gebruik.addAction(userNme);
                    SqlCommand saveTransfer = new SqlCommand("INSERT INTO Transfers VALUES (@id, @branchF, @branchS, @ids, @date1, @date2)", stockConnection);
                    saveTransfer.Parameters.AddWithValue("@id", TotalItems);

                    saveTransfer.Parameters.AddWithValue("@branchF", Properties.Settings.Default.Branch);
                    saveTransfer.Parameters.AddWithValue("@branchS", cmbBranchSend.Text);
                    saveTransfer.Parameters.AddWithValue("@ids", ids);
                    saveTransfer.Parameters.AddWithValue("@date1", DateTime.Today);
                    saveTransfer.Parameters.AddWithValue("@date2", DateTime.Today.AddDays(9));
                    saveTransfer.ExecuteNonQuery();
                    stockConnection.Close();
                MessageBox.Show("Transfer complete", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gebruik.addAction(userNme);
                //  gebruik.log(DateTime.Now, userNme, "Transfer stock" + txbIDUPD.text);


            }
            catch (SqlException s)
            {
                if (s.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection() && count < 4)
                    {
                        count = count + 1;
                        btnConfirmSend.PerformClick();
                    }
                    else
                        MessageBox.Show("Error connectiong to Database, Please check internet connection.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    MessageBox.Show("Error in database" + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullReferenceException s)
            {
                MessageBox.Show("Error: Please fill in valid info" + s, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void StockTransferSendForm_Load_1(object sender, EventArgs e)
        {

        }

        private void btnCancelSend_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void StockTransferSendForm_Shown_1(object sender, EventArgs e)
        {
            txbStockTransferReport.AppendText("MATRIX WAREHOUSE \r\n");
            txbStockTransferReport.AppendText("====================== \r\n");
            txbStockTransferReport.AppendText("Transfer stock from: " + Properties.Settings.Default.Branch + "\r\n");
            txbStockTransferReport.AppendText("====================== \r\n");

            fillBranches();
        }

        private void btnUndoLastTransfer_Click_1(object sender, EventArgs e)
        {
           
        }

        private void fillBranches()
        {

            using (SqlConnection con = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
            {
                string cmdstring = "SELECT branch_location FROM Branches WHERE branch_location <> @thisbranch";

                using (SqlCommand comm = new SqlCommand(cmdstring, con))
                {
                    con.Open();
                    comm.Parameters.AddWithValue("@thisbranch", Properties.Settings.Default.Branch);

                    using (var reader = comm.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbBranchSend.Items.Add(reader[0]);
                        }
                    }
                    con.Close();

                }
            }
        }
    }
}
