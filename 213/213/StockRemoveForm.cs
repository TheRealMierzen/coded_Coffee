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
            SqlConnection stockConnection = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            stockConnection.Open();
            SqlCommand stockDelete = new SqlCommand("UPDATE Stock WHERE item_id = '" + txtDeleteID.Text + "', SET Status = 'Removed'", stockConnection);
            SqlCommand getUserActions = new SqlCommand("Select numberOfActions FROM Users WHERE userName = '" + userNme + "'", stockConnection);
            int count = Convert.ToInt16(getUserActions.ExecuteScalar());
            count = count + 1;
            SqlCommand updateUserActions = new SqlCommand("UPDATE Users SET numberOfActions = '" + count + " WHERE userName = '" + userNme + "'", stockConnection);
            updateUserActions.ExecuteNonQuery();
            stockDelete.ExecuteNonQuery();
            stockConnection.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
