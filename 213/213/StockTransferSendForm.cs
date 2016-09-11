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
        public StockTransferSendForm()
        {
            InitializeComponent();
        }

        private void btnConfirmSend_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to complete this action?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //as user ja se
                //Hier kom die code om die nuwe Stock listing te add
                SqlConnection stockConnection = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                stockConnection.Open();
                
                SqlCommand getStockCountCLN = new SqlCommand("SELECT COUNT(transfer_id) FROM Transfers", stockConnection);
                int TotalItems = 0;
                //stockAddAdapterCLN.SelectCommand = getStockCountCLN;
                TotalItems = Convert.ToInt16(getStockCountCLN.ExecuteScalar()) + 1;
               // SqlCommand addTransfer = new SqlCommand("INSERT INTO Transfers VALUES ('"+ TotalItems +"', '')", stockConnection);
                this.Hide();
                this.Close();
                StockMainFormCLN frmStockMain = new StockMainFormCLN();
                frmStockMain.Show();
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
                StockMainFormCLN frmStockMain = new StockMainFormCLN();
                frmStockMain.Show();
            }
            else
            {
                //as user nee se

            }
        }

        private void StockTransferSendForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_stockI_TDataSet.Branches' table. You can move, or remove it, as needed.
            this.branchesTableAdapter.Fill(this._stockI_TDataSet.Branches);
            // TODO: This line of code loads data into the '_stockI_TDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this._stockI_TDataSet.Employees);

        }

        private void cmbBranchSend_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void lblSelectItem_Click(object sender, EventArgs e)
        {

        }

        private void btnAddToTransferList_Click(object sender, EventArgs e)
        {
            SqlConnection stockConnection = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            stockConnection.Open();
            SqlCommand getStockID = new SqlCommand("SELECT item_id FROM Stock Where item_id = '" + txbItemIDTransfer.Text + "'", stockConnection);
            SqlCommand getDescription = new SqlCommand("SELECT description from Stock WHERE item_id = '" + txbItemIDTransfer.Text + "'", stockConnection);
            string stockID = getStockID.ExecuteScalar().ToString();
            string stockName = getDescription.ExecuteScalar().ToString();
            string ids = stockID + "/";
            stockConnection.Close();
            txbStockTransferReport.AppendText("\r\n" + stockID + "       " + stockName + "\r\n");
        }

        private void StockTransferSendForm_Shown(object sender, EventArgs e)
        {
            txbStockTransferReport.AppendText("MATRIX WAREHOUSE \r\n");
            txbStockTransferReport.AppendText("====================== \r\n");
            txbStockTransferReport.AppendText("Transfer stock from: \r\n");
            txbStockTransferReport.AppendText("====================== \r\n");

        }

        private void btnUndoLastTransfer_Click(object sender, EventArgs e)
        {
            txbStockTransferReport.Text = (txbStockTransferReport.Text.Remove(txbStockTransferReport.Text.LastIndexOf(Environment.NewLine)));
            
        }
    }
}
