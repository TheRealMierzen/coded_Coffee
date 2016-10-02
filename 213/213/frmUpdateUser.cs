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
    public partial class frmUpdateUser : Form
    {
        public frmUpdateUser()
        {
            InitializeComponent();
        }

        public frmUpdateUser(string usert)
        {
            InitializeComponent();
            user = usert;
        }

        string user;

        private void uUserCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbUuser_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbUuser.SelectedItem.ToString() == "Email address")
            {

                txtUserEmail.Visible = true;
                txtCNEmail.Visible = true;
                txtNEmail.Visible = true;

                lblUserEmail.Visible = true;
                lblCNEmail.Visible = true;
                lblNEmail.Visible = true;

                txtCUser.Clear();
                txtNUser.Clear();
                txtCNUser.Clear();
               
                txtLvlUser.Clear();
                txtUserEmail.Clear();
                txtCNEmail.Clear();
                txtNEmail.Clear();

                txtCUser.Visible = false;
                txtNUser.Visible = false;
                txtCNUser.Visible = false;

                lblNUser.Visible = false;
                lblCUser.Visible = false;
                lblCNUser.Visible = false;

                lblLevel.Visible = false;
                cbLevel.Visible = false;
                lblLvlUser.Visible = false;
                txtLvlUser.Visible = false;

                txtUserEmail.Focus();

            }

            if (cbUuser.SelectedItem.ToString() == "Username")
            {
                txtCUser.Clear();
                txtNUser.Clear();
                txtCNUser.Clear();
       
                txtLvlUser.Clear();
                txtUserEmail.Clear();
                txtCNEmail.Clear();
                txtNEmail.Clear();
                txtLvlUser.Focus();


                txtCUser.Visible = true;
                txtNUser.Visible = true;
                txtCNUser.Visible = true;

                lblNUser.Visible = true;
                lblCUser.Visible = true;
                lblCNUser.Visible = true;

                txtUserEmail.Visible = false;
                txtCNEmail.Visible = false;
                txtNEmail.Visible = false;

                lblUserEmail.Visible = false;
                lblCNEmail.Visible = false;
                lblNEmail.Visible = false;

                lblLevel.Visible = false;
                cbLevel.Visible = false;
                lblLvlUser.Visible = false;
                txtLvlUser.Visible = false;

                txtCUser.Focus();

            }

            if (cbUuser.SelectedItem.ToString() == "Account level")
            {

                txtCUser.Visible = false;
                txtNUser.Visible = false;
                txtCNUser.Visible = false;

                lblNUser.Visible = false;
                lblCUser.Visible = false;
                lblCNUser.Visible = false;

                txtUserEmail.Visible = false;
                txtCNEmail.Visible = false;
                txtNEmail.Visible = false;

                lblUserEmail.Visible = false;
                lblCNEmail.Visible = false;
                lblNEmail.Visible = false;

                lblLevel.Visible = true;
                cbLevel.Visible = true;
                lblLvlUser.Visible = true;
                txtLvlUser.Visible = true;

                txtCUser.Clear();
                txtNUser.Clear();
                txtCNUser.Clear();
       
                txtLvlUser.Clear();
                txtUserEmail.Clear();
                txtCNEmail.Clear();
                txtNEmail.Clear();
                txtLvlUser.Focus();

            }
        }

        private void frmUpdateUser_Load(object sender, EventArgs e)
        {

            cbLevel.SelectedItem = "5";

            txtUserEmail.Visible = false;
            txtCNEmail.Visible = false;
            txtNEmail.Visible = false;

            lblUserEmail.Visible = false;
            lblCNEmail.Visible = false;
            lblNEmail.Visible = false;

            txtCUser.Visible = false;
            txtNUser.Visible = false;
            txtCNUser.Visible = false;

            lblNUser.Visible = false;
            lblCUser.Visible = false;
            lblCNUser.Visible = false;

            lblLevel.Visible = true;
            cbLevel.Visible = true;

            lblLvlUser.Visible = true;
            txtLvlUser.Visible = true;


            cbUuser.SelectedItem = "Account level";
            txtLvlUser.Focus();



        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if ((txtUserEmail.Text != "" && txtNEmail.Text != "" && txtCNEmail.Text != "") || (txtCUser.Text != "" && txtNUser.Text != "" && txtCNUser.Text != "") || (txtLvlUser.Text != "" && cbLevel.SelectedItem.ToString() != ""))
            {
                using (SqlConnection con = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                {
                    string cmdstring = "";
                    string fvalue = "", tValue = "";
                    int lvl = -1;

                    if (cbUuser.SelectedItem.ToString() == "Email address")
                    {
                        if (txtCNEmail.Text == txtNEmail.Text)
                        {
                            fvalue = txtCNEmail.Text;
                            tValue = txtUserEmail.Text;
                            cmdstring = "UPDATE Users SET email_address = @value WHERE username = @TValue";
                        }
                        else
                            MessageBox.Show("Please ensure that the new email address and the confirm new email address fields are teh same and try again.");

                    }
                    else if (cbUuser.SelectedItem.ToString() == "Username")
                    {
                        if (txtNUser.Text == txtCNUser.Text)
                        {
                            fvalue = txtNUser.Text;
                            tValue = txtCUser.Text;

                            if (txtCUser.Text.EndsWith(".com"))
                                cmdstring = "UPDATE Users SET userName = @value WHERE email_address = @TValue";
                            else
                                cmdstring = "UPDATE Users SET userName = @value WHERE userName = @TValue";
                        }
                        else
                            MessageBox.Show("Please ensure that the new username and the confirm new username fields are the same and try again.");

                    }
                    else if (cbUuser.SelectedItem.ToString() == "Account level")
                    {
                        lvl = Convert.ToInt16(cbLevel.SelectedItem.ToString());
                        tValue = txtLvlUser.Text;
                        cmdstring = "UPDATE Users SET authLevel = @value WHERE userName = @TValue";

                    }

                    

                    using (SqlCommand comm = new SqlCommand(cmdstring, con))
                    {
                        con.Open();

                        if(lvl == -1)
                            comm.Parameters.AddWithValue("@value", fvalue);
                        else
                            comm.Parameters.AddWithValue("@value", lvl);
                       
                        comm.Parameters.AddWithValue("@TValue", tValue);

                        comm.ExecuteNonQuery();

                        if (cbUuser.SelectedItem.ToString() == "Email address")
                            MessageBox.Show("The email address has been updated");
                        else if (cbUuser.SelectedItem.ToString() == "Username")
                            MessageBox.Show("The username has been updated");
                        else if (cbUuser.SelectedItem.ToString() == "Account level")
                            MessageBox.Show("The account level has been updated");

                    }
                    con.Close();

                    gebruik.addAction(user);
                    DateTime local = DateTime.Now;
                    gebruik.log(local, user, "updated user");
                    this.Close();

                    this.Close();
                }
            }
            else
                MessageBox.Show("Some information is missing. Please verify that all the fields have been filled and try again.");
        }

        private void txtCNUser_TextChanged(object sender, EventArgs e)
        {

            if (txtCUser.Text != "" && txtNUser.Text != "" && txtCNUser.Text != "")
                btnUpdate.Enabled = true;
            else
                btnUpdate.Enabled = false;

            if (txtCNUser.Text != txtNUser.Text)
            {
                btnUpdate.Enabled = false;
                txtCNUser.ForeColor = Color.Red;

            }
            else
                txtCNUser.ForeColor = DefaultForeColor;

            
        }

        private void txtCNEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtCNEmail.Text != txtNEmail.Text)
            {
                btnUpdate.Enabled = false;
                txtCNEmail.ForeColor = Color.Red;

            }
            else
                txtCNEmail.ForeColor = DefaultForeColor;

            if (txtUserEmail.Text != "" && txtNEmail.Text != "" && txtCNEmail.Text != "" && txtNEmail.Text.EndsWith(".com") && txtCNEmail.Text.EndsWith(".com"))
                btnUpdate.Enabled = true;
            else
                btnUpdate.Enabled = false;
        }

        private void txtAuthLevel_TextChanged(object sender, EventArgs e)
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

                if (txtLvlUser.Text != "" && cbLevel.SelectedItem.ToString() != "")
                    btnUpdate.Enabled = true;
                else
                    btnUpdate.Enabled = false;

            }
        }

        private void txtCUser_TextChanged(object sender, EventArgs e)
        {
            if (txtCUser.Text != "" && txtNUser.Text != "" && txtCNUser.Text != "")
                btnUpdate.Enabled = true;
            else
                btnUpdate.Enabled = false;
        }

        private void txtNUser_TextChanged(object sender, EventArgs e)
        {

            if (txtCUser.Text != "" && txtNUser.Text != "" && txtCNUser.Text != "")
                btnUpdate.Enabled = true;
            else
                btnUpdate.Enabled = false;

            if (txtNUser.Text != txtCNUser.Text)
            {
                btnUpdate.Enabled = false;
                txtCNUser.ForeColor = Color.Red;

            }
            else
                txtCNUser.ForeColor = DefaultForeColor;

        }

        private void txtLvlUser_TextChanged(object sender, EventArgs e)
        {
            if (txtLvlUser.Text != "" && cbLevel.SelectedItem.ToString() != "")
                btnUpdate.Enabled = true;
            else
                btnUpdate.Enabled = false;
        }

        private void txtUserEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtUserEmail.Text != "" && txtNEmail.Text != "" && txtCNEmail.Text != "" && txtNEmail.Text.EndsWith(".com") && txtCNEmail.Text.EndsWith(".com"))
                btnUpdate.Enabled = true;
            else
                btnUpdate.Enabled = false;
        }

        private void txtNEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtCNEmail.Text != txtNEmail.Text)
            {
                btnUpdate.Enabled = false;
                txtCNEmail.ForeColor = Color.Red;

            }
            else
                txtCNEmail.ForeColor = DefaultForeColor;

            if (txtUserEmail.Text != "" && txtNEmail.Text != "" && txtCNEmail.Text != "" && txtNEmail.Text.EndsWith(".com") && txtCNEmail.Text.EndsWith(".com"))
                btnUpdate.Enabled = true;
            else
                btnUpdate.Enabled = false;
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
