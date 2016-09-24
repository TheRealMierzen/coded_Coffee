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
    public partial class frmAddUser : Form
    {
        public frmAddUser()
        {
            InitializeComponent();
        }

        public frmAddUser(string username)
        {
            InitializeComponent();
            user = username;
        }

        private string user;

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            txtAuthUser.Text = user;
            txtAuthUser.Enabled = false;

            txtNUser.Focus();
        }

        private void btnAduCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {

            loginForm lf = new loginForm();
            gebruik other = new gebruik();
            Random start = new Random();

            if (txtAuthPass.Text != "" && txtEmail.Text != "" && txtNLvl.Text != "" && txtNUser.Text != "")
            {
                if (lf.validateUser(txtAuthUser.Text, txtAuthPass.Text) && other.checkAuthor(txtAuthUser.Text))
                {
                    string ps = other.genPassword(start.Next(0, 10));
                    if (lf.checkUser(txtNUser.Text))
                    {
                        using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True"))
                        {
                            string cmdstring = "SELECT email_address FROM Users WHERE userName = @username";
                            using (SqlCommand comm = new SqlCommand(cmdstring, con))
                            {
                                comm.Parameters.AddWithValue("@username", user);

                                string mail = "";
                                con.Open();
                                SqlDataReader dr = comm.ExecuteReader();

                                while (dr.Read())
                                {

                                    mail = dr.GetString(0);

                                }
                                dr.Close();
                                con.Close();

                                if (other.Mail(mail, "New user added", "A new user has been added.\r\n\r\nThe new account's details are:\r\n\tUsername: " + txtNUser.Text + "\r\n\tPassword: " + ps + "\r\n\tAccount Level: " + txtNLvl.Text + "\r\n\r\nPlease keep this email for future reference."))
                                {
                                    if (lf.addUser(txtNUser.Text, ps, txtNLvl.Text, txtEmail.Text, txtAuthUser.Text, txtAuthPass.Text))
                                    {
                                        MessageBox.Show("The account has been created. Please consult the adminstrator for the new account's password.");

                                        gebruik.addAction(user);
                                        DateTime local = DateTime.Now;
                                        gebruik.log(local,user,"added new user");

                                        this.Close();
                                    }
                                }
                                else
                                    MessageBox.Show("The user was not added. Please check your internet connection and try again.");

                            }
                        }
                    }
                    else
                        MessageBox.Show("The username: " + txtNUser.Text + " is already taken. Please enter another username and try again.");

                }
                else
                {
 
                    MessageBox.Show("The authorization account's password is incorrect. Please try again.");

                }
            }
                MessageBox.Show("Some required field are empty. Please verify the entered information and try again.");

        }

        private void txtNLvl_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (int.Parse(txtNLvl.Text) > 10 || int.Parse(txtNLvl.Text) < 0)
                    txtNLvl.Text = "";

            }
            catch
            {

                txtNLvl.Text = "";

            }
            finally
            {

                if (txtNUser.Text != "" && txtNLvl.Text != "" && txtEmail.Text != "" && txtAuthPass.Text != "" && txtEmail.Text.EndsWith(".com"))
                    btnCreateAcc.Enabled = true;
                else
                    btnCreateAcc.Enabled = false;

            }
        }

        private void txtNUser_TextChanged(object sender, EventArgs e)
        {
            if (txtNUser.Text != "" && txtNLvl.Text != "" && txtEmail.Text != "" && txtAuthPass.Text != "" && txtEmail.Text.EndsWith(".com"))
                btnCreateAcc.Enabled = true;
            else
                btnCreateAcc.Enabled = false;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtNUser.Text != "" && txtNLvl.Text != "" && txtEmail.Text != "" && txtAuthPass.Text != "" && txtEmail.Text.EndsWith(".com"))
                btnCreateAcc.Enabled = true;
            else
                btnCreateAcc.Enabled = false;
        }

        private void txtAuthPass_TextChanged(object sender, EventArgs e)
        {
            if (txtNUser.Text != "" && txtNLvl.Text != "" && txtEmail.Text != "" && txtAuthPass.Text != "" && txtEmail.Text.EndsWith(".com"))
                btnCreateAcc.Enabled = true;
            else
                btnCreateAcc.Enabled = false;
        }
    }
}
