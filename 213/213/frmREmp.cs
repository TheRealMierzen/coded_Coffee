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
    public partial class frmREmp : Form
    {
        public frmREmp()
        {
            InitializeComponent();
        }

        public frmREmp(string usert)
        {
            InitializeComponent();
            user = usert;
        }

        string user;

        private void frmREmp_Load(object sender, EventArgs e)
        {
            txtAuthUser.Text = user;
            txtAuthUser.Enabled = false;
        }

        private void txtCREmp_TextChanged(object sender, EventArgs e)
        {

            if(txtCREmp.Text.Length != 13 && txtCREmp.Text.Length != 10)
            {

                txtCREmp.ForeColor = Color.Red;
                btnREmp.Enabled = false;

            }

            if(txtCREmp.Text == txtREmp.Text)
            {

                txtCREmp.ForeColor = DefaultForeColor;
                if (txtAuthPass.Text != "")
                    btnREmp.Enabled = true;

            }

            long cell;
            try
            {
                cell = Convert.ToInt64(txtCREmp.Text);

            }
            catch
            {

                try
                {
                    txtCREmp.Text = txtCREmp.Text.Substring(0, txtCREmp.Text.Length - 1);
                    txtCREmp.Focus();
                    txtCREmp.SelectionStart = txtCREmp.Text.Length;
                }
                catch
                {

                    txtCREmp.Text = "";

                }

            }
        }

        private void txtREmp_TextChanged(object sender, EventArgs e)
        {
            long cell;

            if (txtREmp.Text.Length != 13 && txtREmp.Text.Length != 10)
            {

                txtREmp.ForeColor = Color.Red;
                btnREmp.Enabled = false;

            }
            else
                txtREmp.ForeColor = DefaultForeColor;
            if(txtREmp.Text != txtCREmp.Text)
            {

                txtCREmp.ForeColor = Color.Red;
                btnREmp.Enabled = false;

            }

            if(txtCREmp.Text == txtREmp.Text && txtCREmp.Text != "")
            {

                txtCREmp.ForeColor = DefaultForeColor;
                if (txtAuthPass.Text != "")
                    btnREmp.Enabled = false;

            }

            try
            {
                cell = Convert.ToInt64(txtREmp.Text);

            }
            catch
            {

                try
                {
                    txtREmp.Text = txtREmp.Text.Substring(0, txtREmp.Text.Length - 1);
                    txtREmp.Focus();
                    txtREmp.SelectionStart = txtREmp.Text.Length;
                }
                catch
                {

                    txtREmp.Text = "";

                }

            }
        }

        private void txtAuthPass_TextChanged(object sender, EventArgs e)
        {
            if (txtAuthPass.Text != "")
            {
                if (txtCREmp.Text == txtREmp.Text && txtREmp.Text != "")
                    btnREmp.Enabled = true;
            }
            else
                btnREmp.Enabled = false;
        }

        private void btnREmp_Click(object sender, EventArgs e)
        {

            //Employee exists
            if(checkID(txtCREmp.Text))
            {

                using (SqlConnection con = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                {
                    gebruik other = new gebruik();

                    con.Open();

                    string cmdstring = "";
                    if (txtCREmp.Text.Length == 13)
                        cmdstring = "DELETE FROM Employees WHERE id_num = @id";
                    else
                        cmdstring = "DELETE FROM Employees WHERE employee_id = @id";

                    using (SqlCommand comm = new SqlCommand(cmdstring, con))
                    {

                        comm.Parameters.AddWithValue("@id", txtCREmp.Text);

                        comm.ExecuteNonQuery();

                        gebruik.addAction(user);
                        DateTime local = DateTime.Now;
                        gebruik.log(local, user, "removed employee");

                        updateEmployNum("remove");
                        string message = "";
                        if (other.getUsername(getMail(txtCREmp.Text)) != "")
                        {
                            DialogResult result = MessageBox.Show("The system has detected the this employee has an account with the current email address. Would you like to automatically remove the user account too?", "Info", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {

                                removeUser(other.getUsername(getMail(txtCREmp.Text)));
                                message = "The employee and user has successfully been removed.";

                            }
                            else
                                message = "The employee has successfully been removed.";

                        }
                        else
                            message = "The employee has successfully been removed.";


                        DialogResult choice;
                        choice = MessageBox.Show(message + "\r\nWould you like to remove another employee?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                        if (choice == DialogResult.Yes)
                        {

                            txtAuthPass.Clear();
                            txtREmp.Clear();
                            txtCREmp.Clear();
                        }
                        else
                            this.Close();

                    }
                }
            }

        }

        private bool checkID(string id)
        {

            using (SqlConnection con = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
            {
                con.Open();

                string cmdstring = "";
                if(id.Length == 13)
                    cmdstring = "SELECT COUNT(*) AS CountOfRecords FROM Employees WHERE id_num = @id";
                else
                    cmdstring = "SELECT COUNT(*) AS CountOfRecords FROM Employees WHERE employee_id = @id";

                using (SqlCommand comm = new SqlCommand(cmdstring, con))
                {
                    comm.Parameters.AddWithValue("@id", id);

                    int records = Convert.ToInt32(comm.ExecuteScalar());

                    con.Close();

                    if (records > 0)
                        return true;
                    else
                        return false;
                }
            }

        }

        private string getMail(string id)
        {

            using (SqlConnection con = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
            {
                con.Open();

                string cmdstring = "";
                if (id.Length == 13)
                    cmdstring = "SELECT email_address FROM Employees WHERE id_num = @id";
                else
                    cmdstring = "SELECT email_address FROM Employees WHERE employee_id = @id";

                using (SqlCommand comm = new SqlCommand(cmdstring, con))
                {
                    comm.Parameters.AddWithValue("@id", id);

                    using (var reader = comm.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            string email = reader.GetString(0);
                            return email;

                        }

                    }

                    con.Close();

                    return "";
                    
                }
            }
        }


        private void removeUser(string username)
        {

            using (SqlConnection con = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
            {
                con.Open();

                string cmdstring = "DELETE FROM Users WHERE userName = @user";

                using (SqlCommand comm = new SqlCommand(cmdstring, con))
                {
                    comm.Parameters.AddWithValue("@user", username);

                    comm.ExecuteNonQuery();

                    gebruik.addAction(user);
                    DateTime local = DateTime.Now;
                    gebruik.log(local, user, "removed user");

                    con.Close();

                }
            }

        }

        private void updateEmployNum(string logic)
        {

            using (SqlConnection con = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
            {

                con.Open();
                string cmdstring = "";
                if (logic == "add")
                    cmdstring = "UPDATE Branches SET branch_employeenum = branch_employeenum + 1 WHERE branch_location = @branch";
                else
                    cmdstring = "UPDATE Branches SET branch_employeenum = branch_employeenum - 1 WHERE branch_location = @branch";

                using (SqlCommand comm = new SqlCommand(cmdstring, con))
                {
                    comm.Parameters.AddWithValue("@branch", Properties.Settings.Default.Branch);

                    comm.ExecuteNonQuery();
                }
                con.Close();

            }

        }

    }
}
