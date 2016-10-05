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
    public partial class StockTransferRecieve : Form
    {
        private string userNme;
        private string id;
        private string tI;
        private string cur;
        public StockTransferRecieve()
        {
            InitializeComponent();
        }

        public StockTransferRecieve(string user, string ids, string tID)
        {
            InitializeComponent();
            userNme = user;
            id = ids;
            tI = tID;
        }

        private void StockTransferRecieve_Shown(object sender, EventArgs e)
        {

        }

        private void btnConfirmAddCLN_Click(object sender, EventArgs e)
        {
            try
            {
                if (id != "")
                {
                    string gID;
                    int pos = id.IndexOf(',');
                    gID = id.Substring(0, pos);
                    id = id.Remove(0, pos + 1);
                    SqlConnection stockConnection = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT");
                    // SqlConnection stockConnection = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                    stockConnection.Open();
                    SqlCommand getDes = new SqlCommand("SELECT item_name, manufacturer, manufacturer_price, retail_price FROM Stock WHERE item_id = @id", stockConnection);
                    getDes.Parameters.AddWithValue("@id", gID);
                    SqlDataReader reader = getDes.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            txbItemName.Text = reader.GetString(0);
                            txbBrandAddUPD.Text = reader.GetString(1);
                            txbMPriceAddUPD.Text = reader.GetString(2);
                            txbRPriceUPD.Text = reader.GetString(3);
                            txbRPriceUPD.Enabled = true;
                            btnConfirmAddCLN.Enabled = false;

                            cur = gID;
                        }


                    }
                    reader.Close();
                    stockConnection.Close();
                    if (id == "")
                    {
                        MessageBox.Show("All items have been transfered successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gebruik.addAction(userNme);
                        //  gebruik.log(DateTime.Now, userNme, "Recieved stock");
                        btnCancelAddCLN.Enabled = true;
                        del(tI);
                    }
                }
            }
            catch (SqlException s)
            {
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
            update(cur);
        }

        private void btnCancelAddCLN_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void update(string gID)
        {
            SqlConnection stockConnection = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT");
         //   SqlConnection stockConnection = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT");
            stockConnection.Open();
            gebruik.addAction(userNme);
            SqlCommand updates = new SqlCommand("UPDATE Stock SET branch = @branch, status = @stock WHERE item_id = @id", stockConnection);
            //update.Parameters.AddWithValue("@branch", "Pretoria");
            updates.Parameters.AddWithValue("@branch", Properties.Settings.Default.Branch);
            updates.Parameters.AddWithValue("@stock", "In Stock");
            updates.Parameters.AddWithValue("@id", gID);
            updates.ExecuteNonQuery();
            stockConnection.Close();
        }

        private void del(string gID)
        { 

                SqlConnection stockConnection = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT");
                stockConnection.Open();
                SqlCommand delete = new SqlCommand("DELETE FROM transfers WHERE transfer_id = @transfer",stockConnection);
                delete.Parameters.AddWithValue("@transfer", gID);
                delete.ExecuteNonQuery();
            stockConnection.Close();
        }
    }
}
