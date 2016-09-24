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
    public partial class frmRUser : Form
    {
        public frmRUser()
        {
            InitializeComponent();
        }

        public frmRUser(string usert)
        {
            InitializeComponent();
            user = usert;
        }

        string user;

        private void frmRUser_Load(object sender, EventArgs e)
        {
            txtAuthUser.Text = user;
            txtAuthUser.Enabled = false;

            txtRUser.Focus();
        }

        private void btnRAcc_Click(object sender, EventArgs e)
        {

            if (txtRUser.Text == txtCRUser.Text && txtAuthPass.Text != "")
            {

                loginForm lf = new loginForm();
                gebruik other = new gebruik();

                if (lf.validateUser(txtAuthUser.Text, txtAuthPass.Text) && other.checkAuthor(txtAuthUser.Text))
                {
                    if (!lf.checkUser(txtCRUser.Text))
                    {
                        using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True"))
                        {
                            string cmdstring = "DELETE FROM Users WHERE username = @user";
                            using (SqlCommand comm = new SqlCommand(cmdstring, con))
                            {

                                con.Open();
                                comm.Parameters.AddWithValue("@user", txtCRUser.Text);
                                comm.ExecuteNonQuery();

                                MessageBox.Show("The account has successfully been deleted.");

                                gebruik.addAction(user);
                                DateTime local = DateTime.Now;
                                gebruik.log(local, user, "removed user");

                                this.Close();

                            }
                        }
                    }
                    else
                        MessageBox.Show("The user you want to remove does not exist. Please verify the entered information and try again.");
                    
                }
                else
                    MessageBox.Show("The authorization account's password is incorrect. Please try again.");
            }
            else
                MessageBox.Show("Please verify the account you wanted to delete's information and try again.");

            
        }

        private void txtRUser_TextChanged(object sender, EventArgs e)
        {
            if (txtRUser.Text == txtCRUser.Text && txtAuthPass.Text != "" && txtRUser.Text != "")
            {
                txtCRUser.ForeColor = DefaultForeColor;
                btnRAcc.Enabled = true;
            }
            else if (txtRUser.Text != txtCRUser.Text)
            {
                txtCRUser.ForeColor = Color.Red;
                btnRAcc.Enabled = false;
            }
        }

        private void txtCRUser_TextChanged(object sender, EventArgs e)
        {
            if (txtRUser.Text == txtCRUser.Text && txtAuthPass.Text != "" && txtRUser.Text != "")
            {
                txtCRUser.ForeColor = DefaultForeColor;
                btnRAcc.Enabled = true;
            }
            else if(txtRUser.Text != txtCRUser.Text)
            {
                txtCRUser.ForeColor = Color.Red;
                btnRAcc.Enabled = false;
            }
            else if(txtRUser.Text == txtCRUser.Text)
                txtCRUser.ForeColor = DefaultForeColor;
        }

        private void txtAuthPass_TextChanged(object sender, EventArgs e)
        {
            if (txtAuthPass.Text != "" && txtRUser.Text == txtCRUser.Text && txtRUser.Text != "")
                btnRAcc.Enabled = true;
            else
                btnRAcc.Enabled = false;
        }

        private void btnRUCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
