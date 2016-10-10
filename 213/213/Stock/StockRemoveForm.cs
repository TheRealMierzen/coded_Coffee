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
    public partial class StockRemoveForm : Form
    {
        private string userNme;
        private int count; 
        public StockRemoveForm()
        {
            InitializeComponent();
        }
        public StockRemoveForm(string user)
        {
            InitializeComponent();
            userNme = user;
        }

        private void btnConfirmFind_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection stockConnection = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT");
                stockConnection.Open();
                count = 0;
                SqlCommand stockCon = new SqlCommand("SELECT item_id FROM Stock WHERE item_id = @id",stockConnection);
                stockCon.Parameters.AddWithValue("@id", txtDeleteID.Text);
                if (stockCon.ExecuteScalar() == null)
                {
                    MessageBox.Show("ID does not exsist","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand stockDelete = new SqlCommand("UPDATE Stock SET Status = @status WHERE item_id = @id", stockConnection);
                    stockDelete.Parameters.AddWithValue("@id", txtDeleteID.Text);
                    stockDelete.Parameters.AddWithValue("@Status", "Removed");
                    stockDelete.ExecuteNonQuery();
                    if (rbDisposal.Checked == true)
                    {
                        gebruik.log(DateTime.Now, userNme, "Removed Stock: " + rbDisposal.Text);
                        gebruik.addAction(userNme);
                        MessageBox.Show("Item Successfully Removed", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (rbFaulty.Checked == true)
                    {
                        gebruik.log(DateTime.Now, userNme, "Removed Stock: " + rbFaulty.Text);
                        gebruik.addAction(userNme);
                        MessageBox.Show("Item Successfully Removed", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Please select a reason", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                           

                    stockConnection.Close();
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
                        btnConfirmFind.PerformClick();
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelFind_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
