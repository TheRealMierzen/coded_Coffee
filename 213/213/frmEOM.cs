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
    public partial class frmEOM : Form
    {
        public frmEOM()
        {
            InitializeComponent();
        }

        private void frmEOM_Load(object sender, EventArgs e)
        {
            

            if(Properties.Settings.Default.EOM != "-")
            {

                Properties.Settings.Default.PEOM = Properties.Settings.Default.EOM;
                Properties.Settings.Default.EOM = "-";
                Properties.Settings.Default.Save();

            }

            lblCEOM.Text = "Employee of the month for " + DateTime.Now.AddMonths(11).ToString("MMM") + ": " + Properties.Settings.Default.PEOM;
            lblFor.Text = "Employee performance for " + DateTime.Now.ToString("MMM") + " (highest to lowest):";


            using (SqlConnection con = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
            {
                con.Open();

                string cmdstring = "SELECT name, surname FROM Employees WHERE branch = @branch ORDER BY (SELECT (numberOfLogins * Users.numberOfActions) AS total FROM Users WHERE branch = @branch)";

                using (SqlCommand comm = new SqlCommand(cmdstring, con))
                {
                    comm.Parameters.AddWithValue("@branch", Properties.Settings.Default.Branch);
                    using (var reader = comm.ExecuteReader())
                    {
  
                        while (reader.Read())
                        {

                            dgEOM.Rows.Add(reader.GetString(0), reader.GetString(1));

                        }

                    }
                    con.Close();

                    for (int i = 0; i < dgEOM.Rows.Count; i++)
                    {
                        DataGridViewRowHeaderCell cell = dgEOM.Rows[i].HeaderCell;
                        cell.Value = (i + 1).ToString();
                        dgEOM.Rows[i].HeaderCell = cell;
                    }


                }
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
