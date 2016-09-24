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
    public partial class frmForgotPass : Form
    {
        public frmForgotPass()
        {
            InitializeComponent();
        }

        public frmForgotPass(string bUser, Form p)
        {
            InitializeComponent();
            user = bUser;
            parent = p;
        }

        private string user;
        private Form parent;

        private void frmForgotPass_Load(object sender, EventArgs e)
        {
            if (user != "")
            {
                txtBlocked.Focus();
                txtBlocked.Text = user;
                txtFPAdminU.Focus();
            }
            else
                txtBlocked.Focus();
        }

        private void btnFPCancel_Click(object sender, EventArgs e)
        {
            parent.TopMost = true;
            this.Close();
        }

        private void btnFPRecover_Click(object sender, EventArgs e)
        {

            if(txtBlocked.Text != "")
            {
                if (txtFPAdminU.Text != "")
                {
                    if (txtFPAdminP.Text != "")
                    {

                        if (checkUsername(user))
                        {//username is there

                            loginForm lf = new loginForm();
                            gebruik util = new gebruik();

                            MessageBox.Show(util.checkAuthor(txtFPAdminU.Text).ToString());
                            if (lf.validateUser(txtFPAdminU.Text, txtFPAdminP.Text) && util.checkAuthor(txtFPAdminU.Text))
                            {
                                
                                Random start = new Random();

                                string newPass = util.genPassword(start.Next(0, 10));
                                
                                //kort background runners
                                string saltyness = BCrypt.Net.BCrypt.GenerateSalt(15);
                                string hsh = BCrypt.Net.BCrypt.HashPassword(newPass, saltyness);

                                using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True"))
                                {
                                    string cmdstring = "UPDATE Users SET password = @pas, salt = @salty WHERE Username = @user";

                                    using (SqlCommand comm = new SqlCommand(cmdstring, con))
                                    {
                                        con.Open();

                                        comm.Parameters.AddWithValue("@pas", hsh);
                                        comm.Parameters.AddWithValue("@salty", saltyness);
                                        comm.Parameters.AddWithValue("@user", user);
                                        comm.ExecuteNonQuery();

                                        using (SqlConnection con1 = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True"))
                                        {
                                            string cmdstring1 = "SELECT email_address FROM Users WHERE userName = @username";

                                            using (SqlCommand comm1 = new SqlCommand(cmdstring1, con1))
                                            {

                                                comm1.Parameters.AddWithValue("@username", txtFPAdminU.Text);

                                                string mail = "";
                                                con1.Open();
                                                SqlDataReader dr = comm1.ExecuteReader();
                                                while (dr.Read())
                                                {

                                                    mail = dr.GetString(0);

                                                }
                                                dr.Close();
                                                con1.Close();

                                                if (util.Mail(mail, "Password recovery", "A new password has been generated.\r\n\r\nThe new details are:\r\n\tUsername: " + user + "\r\n\tPassword: " + newPass + "\r\n\t\r\n\r\nPlease keep this email for future reference."))
                                                {
                                                    MessageBox.Show("The password has been updated. Please consult the adminstrator for the new password.");
                                                    gebruik.addAction(txtFPAdminP.Text);
                                                    this.Close();
                                                }
                                                else
                                                    MessageBox.Show("The password was not updated. Please check your internet connection and try again.");

                                            }
                                        }

                                        con.Close();
                                    }
                                }

                            }
                            else
                                MessageBox.Show("The details entered as the adminstrative account's are incorrect. Please verify the details and try again.");
                        }
                        else
                            MessageBox.Show("The username '" + txtBlocked.Text + "' does not exist. Please verify that the spelling is correct and try again.");

                    }
                    else
                        MessageBox.Show("Please enter the administrative account's password.");
                }
                else
                    MessageBox.Show("Please enter the administrative account's username.");
            }
            else
                MessageBox.Show("Please enter the username of the account to be recovered.");

        }

        //false if username is not in database
        private bool checkUsername(string user)
        {

            using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True"))
            {
                con.Open();
                string cmdstring = "SELECT COUNT(*) AS CountOfRecords FROM Users WHERE userName = @user";
                using (SqlCommand comm = new SqlCommand(cmdstring, con))
                {
                    comm.Parameters.AddWithValue("@user", user);
                    int records = Convert.ToInt32(comm.ExecuteScalar());
                    con.Close();
                    if (records > 0)
                        return true;
                    else
                        return false;
                }
            }

        }

        private void txtBlocked_Leave(object sender, EventArgs e)
        {
            user = txtBlocked.Text;
    }

        private void txtBlocked_TextChanged(object sender, EventArgs e)
        {
            if (txtBlocked.Text != "" && txtFPAdminU.Text != "" && txtFPAdminP.Text != "")
                btnFPRecover.Enabled = true;
            else
                btnFPRecover.Enabled = false;
        }

        private void txtFPAdminU_TextChanged(object sender, EventArgs e)
        {
            if (txtBlocked.Text != "" && txtFPAdminU.Text != "" && txtFPAdminP.Text != "")
                btnFPRecover.Enabled = true;
            else
                btnFPRecover.Enabled = false;
        }

        private void txtFPAdminP_TextChanged(object sender, EventArgs e)
        {
            if (txtBlocked.Text != "" && txtFPAdminU.Text != "" && txtFPAdminP.Text != "")
                btnFPRecover.Enabled = true;
            else
                btnFPRecover.Enabled = false;
        }
    }
}
