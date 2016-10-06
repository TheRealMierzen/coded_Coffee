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
    public partial class frmRemoveOrder : Form
    {

        private SqlConnection conn;
        private string user;

        public frmRemoveOrder()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        public frmRemoveOrder(string userName)
        {
            InitializeComponent();
            this.TopMost = true;
            user = userName;
        }

        private void frmRemoveOrder_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT");
        }

        private void txtOrderID_TextChanged(object sender, EventArgs e)
        {
            btnRemove.Enabled = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {

                string cmdStr;

                using (conn)
                {

                    cmdStr = "Delete from Orders where order_id = @id";

                    using (SqlCommand deleteOrder = new SqlCommand(cmdStr, conn))
                    {
                        deleteOrder.Parameters.AddWithValue("@id", txtOrderID.Text);

                        conn.Open();
                        deleteOrder.ExecuteNonQuery();
                        conn.Close();
                    }
                }

                gebruik.addAction(user);

                frmHQ hq = new frmHQ();
                hq.Show();
                this.Hide();
            }
            catch (SqlException se)
            {
                if (se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection())
                        btnRemove_Click();
                }
            }


        }
    }
}
