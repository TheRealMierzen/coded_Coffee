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

        public frmAddUser(string username, string email)
        {
            InitializeComponent();
            user = username;
            txtEmail.Text = email;
        }

        private string user;

        private void frmAddUser_Load(object sender, EventArgs e)
        {
            txtAuthUser.Text = user;
            txtAuthUser.Enabled = false;

            cbLevel.SelectedItem = "5";
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

            if (txtAuthPass.Text != "" && txtEmail.Text != "" && cbLevel.SelectedItem.ToString() != "" && txtNUser.Text != "")
            {
                if (lf.validateUser(txtAuthUser.Text, txtAuthPass.Text) && other.checkAuthor(txtAuthUser.Text))
                {
                    string ps = other.genPassword(start.Next(0, 10));
                    if (lf.checkUser(txtNUser.Text))
                    {
                        using (SqlConnection con = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
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

                                if (other.Mail(txtEmail.Text, "StockI.T account created!", "Your stockI.T account has been created and you can now use the software using the following details:\r\n\r\n\tUsername: " + txtNUser.Text + "\r\n\tYour account level is: " + cbLevel.SelectedItem.ToString() + "\r\n\r\nYour account level determines which tasks you can perform on the system.\r\n\r\nPlease keep this email for future reference."))
                                {
                                    if (other.Mail(mail, "New user added", "A new user has been added.\r\n\r\nThe new account's details are:\r\n\tUsername: " + txtNUser.Text + "\r\n\tAccount Level: " + cbLevel.SelectedItem.ToString() + "\r\n\r\nIf you did not authorize this account, you can remove the new account at any time."))
                                    {
                                        if (lf.addUser(txtNUser.Text, ps, cbLevel.SelectedItem.ToString(), txtEmail.Text, txtAuthUser.Text, txtAuthPass.Text))
                                        {
                                            DialogResult choice;
                                            choice = MessageBox.Show("The account has been created. The account's password has been sent to the new user's email address.\r\nWould you like to add another user?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                                            gebruik.addAction(user);
                                            DateTime local = DateTime.Now;
                                            gebruik.log(local, user, "added new user");                
                                            
                                            if (choice == DialogResult.Yes)
                                            {

                                                txtAuthPass.Clear();
                                                txtEmail.Clear();
                                                txtNUser.Clear();

                                            }
                                            else
                                                this.Close();
                                        }
                                    }
                                    else
                                        MessageBox.Show("The user was not added. Please check your internet connection and try again.");
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
            else
                MessageBox.Show("Some required field are empty. Please verify the entered information and try again.");

        }

        private void txtNLvl_TextChanged(object sender, EventArgs e)
        {
            int cell;
            try
            {
                cell = Convert.ToInt16(cbLevel.SelectedItem.ToString());

            }
            catch
            {

                try
                {
                    cbLevel.SelectedItem = cbLevel.SelectedItem.ToString().Substring(0, cbLevel.SelectedItem.ToString().Length - 1);
                    cbLevel.Focus();
                    cbLevel.SelectionStart = cbLevel.SelectedItem.ToString().Length;
                }
                catch
                {

                    cbLevel.SelectedItem = "";

                }

            }
            finally
            {

                if (txtNUser.Text != "" && cbLevel.SelectedItem.ToString() != "" && txtEmail.Text != "" && txtAuthPass.Text != "" && txtEmail.Text.EndsWith(".com"))
                    btnCreateAcc.Enabled = true;
                else
                    btnCreateAcc.Enabled = false;

            }
        }

        private void txtNUser_TextChanged(object sender, EventArgs e)
        {
            if (txtNUser.Text != "" && cbLevel.SelectedItem.ToString() != "" && txtEmail.Text != "" && txtAuthPass.Text != "" && txtEmail.Text.EndsWith(".com"))
                btnCreateAcc.Enabled = true;
            else
                btnCreateAcc.Enabled = false;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtNUser.Text != "" && cbLevel.SelectedItem.ToString() != "" && txtEmail.Text != "" && txtAuthPass.Text != "" && txtEmail.Text.EndsWith(".com"))
                btnCreateAcc.Enabled = true;
            else
                btnCreateAcc.Enabled = false;
        }

        private void txtAuthPass_TextChanged(object sender, EventArgs e)
        {
            if (txtNUser.Text != "" && cbLevel.SelectedItem.ToString() != "" && txtEmail.Text != "" && txtAuthPass.Text != "" && txtEmail.Text.EndsWith(".com"))
                btnCreateAcc.Enabled = true;
            else
                btnCreateAcc.Enabled = false;
        }
    }
}
