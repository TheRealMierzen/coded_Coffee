using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (lf.addUser(txtNUser.Text, other.genPassword(start.Next(0, 10)), txtNLvl.Text, txtEmail.Text, txtAuthUser.Text, txtAuthPass.Text))
            {
                MessageBox.Show("The account has been created. Please consult the adminstrator for the new account's password.");
                gebruik.addAction(user);
            }
            else
                MessageBox.Show("The account was not created.");

        }
    }
}
