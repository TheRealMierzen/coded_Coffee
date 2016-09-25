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
    public partial class StockTakeForm : Form
    {
        private string userNme;
        private string recID = "";
        public StockTakeForm()
        {
            InitializeComponent();
        }

        public StockTakeForm(string user)
        {
            InitializeComponent();
            userNme = user;
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            SqlConnection stockConnection = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            stockConnection.Open();
            SqlCommand getStock = new SqlCommand("SELECT item_id FROM Stock WHERE item_id = '" + txtStockTakeItemID.Text + "'", stockConnection);
            string getID = getStock.ExecuteScalar().ToString();
            if(getID == null)
            {
                
            }
            else
            {
                SqlCommand getDesc = new SqlCommand("SELECT description FROM Stock WHERE item_id = '" + txtStockTakeItemID.Text + "'", stockConnection);
                string getDes = getDesc.ExecuteScalar().ToString();
                txbStockTake.AppendText("\r\n" + getDes + "     " + getID);
                recID = recID + getID + ",";
            }
            stockConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // StockMainFormCLN smf = new StockMainFormCLN();
            this.Hide();
            //smf.Show();
        }

        private void StockTakeForm_Shown(object sender, EventArgs e)
        {
            SqlConnection stockConnection = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            stockConnection.Open();
            SqlCommand getStockCountCLN = new SqlCommand("SELECT COUNT(item_id) FROM Stock", stockConnection);
            int TotalItems = 0;
            TotalItems = Convert.ToInt16(getStockCountCLN.ExecuteScalar());
            string stockID = "";
            txbStockTakeReport.AppendText("Items Added Today:");
            for (int i = 0; i <= TotalItems; i++)
            {
                SqlCommand getStock = new SqlCommand("SELECT item_id FROM Stock WHERE intial_add = CONVERT(date,GETDATE()) AND item_id = '" + i + "'", stockConnection);
                if (getStock.ExecuteScalar() == null)
                {

                }
                else
                {
                    SqlCommand getDes = new SqlCommand("SELECT description FROM Stock WHERE intial_add = CONVERT(date,GETDATE()) AND item_id = '" + i + "'", stockConnection);
                    string stockDes = getDes.ExecuteScalar().ToString();
                    stockID = getStock.ExecuteScalar().ToString();
                   // txbStockTakeReport.AppendText("Items Added:");
                    txbStockTakeReport.AppendText("\r\n" + stockDes + "    " + stockID);
                    
                }               
            }
            txbStockTakeReport.AppendText("\r\n=======================================");
            txbStockTakeReport.AppendText("\r\n Items Sold Today:");
            // string temp = "";
          //  txbStockTakeReport.AppendText("Items Sold:");
            for (int i = 0; i <= TotalItems; i++)
            {
                SqlCommand getSale = new SqlCommand("SELECT item_id FROM Stock WHERE intial_add = CONVERT(date,GETDATE()) AND Status = 'Sold' AND item_id = '" + i + "'", stockConnection);
                if (getSale.ExecuteScalar() == null)
                {

                }
                else
                {
                    SqlCommand getDes = new SqlCommand("SELECT description FROM Stock WHERE intial_add = CONVERT(date,GETDATE()) AND item_id = '" + i + "'", stockConnection);
                    string stockDes = "";
                    stockDes = getDes.ExecuteScalar().ToString();
                    stockID = getSale.ExecuteScalar().ToString();                    
                    txbStockTakeReport.AppendText("\r\n" + stockDes + "    " + stockID);
                }
            }
            txbStockTakeReport.AppendText("\r\n=======================================");
            txbStockTakeReport.AppendText("\r\n Items Removed Today:");
            for (int i = 0; i <= TotalItems; i++)
            {
                SqlCommand getSale = new SqlCommand("SELECT item_id FROM Stock WHERE intial_add = CONVERT(date,GETDATE()) AND Status = 'Removed' AND item_id = '" + i + "'", stockConnection);
                if (getSale.ExecuteScalar() == null)
                {

                }
                else
                {
                    SqlCommand getDes = new SqlCommand("SELECT description FROM Stock WHERE intial_add = CONVERT(date,GETDATE()) AND item_id = '" + i + "'", stockConnection);
                    string stockDes = "";
                    stockDes = getDes.ExecuteScalar().ToString();
                    stockID = getSale.ExecuteScalar().ToString();
                    txbStockTakeReport.AppendText("\r\n" + stockDes + "    " + stockID);
                }
            }
            txbStockTakeReport.AppendText("\r\n=======================================");
            txbStockTakeReport.AppendText("\r\n Items Transfered Today:");
            for (int i = 0; i <= TotalItems; i++)
            {
                SqlCommand getSale = new SqlCommand("SELECT item_id FROM Stock WHERE intial_add = CONVERT(date,GETDATE()) AND Status = 'In Transit' AND item_id = '" + i + "'", stockConnection);
                if (getSale.ExecuteScalar() == null)
                {

                }
                else
                {
                    SqlCommand getDes = new SqlCommand("SELECT description FROM Stock WHERE intial_add = CONVERT(date,GETDATE()) AND item_id = '" + i + "'", stockConnection);
                    string stockDes = "";
                    stockDes = getDes.ExecuteScalar().ToString();
                    stockID = getSale.ExecuteScalar().ToString();
                    txbStockTakeReport.AppendText("\r\n" + stockDes + "    " + stockID);
                }
            }
            txbStockTakeReport.AppendText("\r\n=======================================");
            txbStockTakeReport.AppendText("\r\nTOETS");
            for (int i = 0; i <= TotalItems; i++)
            {
                SqlCommand getSale = new SqlCommand("SELECT item_id FROM Stock", stockConnection);
                string toets = getSale.ExecuteScalar().ToString();
                txbStockTakeReport.AppendText("\r\n" + toets);
            }


            txbStockTakeReport.AppendText("\r\n=======================================");
            stockConnection.Close();

        }

        private void btnCompleteStockTake_Click(object sender, EventArgs e)
        {
            txbStockTake.AppendText("\r\n===STOCK TAKE COMPLETE");
                SqlConnection stockConnection = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                stockConnection.Open();
                SqlCommand getStockCountCLN = new SqlCommand("SELECT COUNT(item_id) FROM Stock", stockConnection);
                int TotalItems = 0;
                TotalItems = Convert.ToInt16(getStockCountCLN.ExecuteScalar());
                string dbIDS = "";
                for (int i = 0; i <= TotalItems; i++)
                {
                    SqlCommand getStock = new SqlCommand("SELECT item_id FROM Stock WHERE item_id = '" + i + "'", stockConnection);
                    if (getStock.ExecuteScalar() == null)
                    {

                    }
                    else
                    {
                        dbIDS = dbIDS + (getStock.ExecuteScalar().ToString() + ",");
                    }
                }
                string s3 = dbIDS.Replace(recID, "");
            do
            {
                int pos = s3.IndexOf(',');
                if (pos != -1)
                {
                    string id = s3.Substring(0, pos);
                    SqlCommand getid = new SqlCommand("SELECT item_id FROM Stock WHERE item_id = '" + id + "'", stockConnection);
                    if (getid.ExecuteScalar().ToString() == null)
                    {
                        txbStockTake.AppendText("\r\nItem ID: " + id + " is not found in the database");
                    }
                    else
                    {
                        txtStockTakeItemID.AppendText("\r\nItem ID: " + id + "is not found in Stock");
                    }
                    s3 = s3.Remove(0, pos);
                }
            } while (s3 != "");
        }
    }
}
