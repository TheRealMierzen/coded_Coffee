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
    public partial class frmUEmp : Form
    {
        public frmUEmp()
        {
            InitializeComponent();
        }

        public frmUEmp(string userr)
        {
            InitializeComponent();
            user = userr;
        }

        string user;
        string id;
        

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            if ((txtID.Text.Length == 13) || (txtID.Text.Length == 10))
            {
                txtID.ForeColor = DefaultForeColor;
                id = txtID.Text;
                if (txtCEmail.Text != "" && txtNEmail.Text != "" && txtCNEmail.Text == txtNEmail.Text)
                    btnUpdateEmp.Enabled = true;
            }
            else if(txtID.Text.Length != 13 || txtID.Text.Length != 10)
            {
                txtID.ForeColor = Color.Red;
                btnUpdateEmp.Enabled = false;
            }


            long cell;
            try
            {
                cell = Convert.ToInt64(txtID.Text);

            }
            catch
            {

                try
                {
                    txtID.Text = txtID.Text.Substring(0, txtID.Text.Length - 1);
                    txtID.Focus();
                    txtID.SelectionStart = txtID.Text.Length;
                }
                catch
                {

                    txtID.Text = "";

                }

            }
        }

        private void txtCEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtCEmail.Text == txtNEmail.Text)
            {

                txtNEmail.ForeColor = Color.Red;
                btnUpdateEmp.Enabled = false;

            }
            else
                txtNEmail.ForeColor = DefaultForeColor;

            if (txtCEmail.Text.EndsWith(".com") && txtCEmail.Text.Length > 7)
            {
                txtCEmail.ForeColor = DefaultForeColor;
                if(txtNEmail.Text == txtCNEmail.Text && txtCNEmail.Text != "" && txtID.Text != "")
                    btnUpdateEmp.Enabled = true;
            }
            else if(!txtCEmail.Text.EndsWith(".com") || txtCEmail.Text.Length < 7)
            {
                txtCEmail.ForeColor = Color.Red;
                btnUpdateEmp.Enabled = false;
            }
        }

        private void txtNEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtNEmail.Text == txtCNEmail.Text)
                txtCNEmail.ForeColor = DefaultForeColor;
            else
                txtCNEmail.ForeColor = Color.Red;

            if(txtCEmail.Text != txtNEmail.Text && txtNEmail.Text != "" && txtNEmail.Text.EndsWith(".com"))
            {
                txtNEmail.ForeColor = DefaultForeColor;
                if (txtID.Text != "" && txtCEmail.Text != "" && txtNEmail.Text == txtCNEmail.Text)
                {
                    txtCNEmail.ForeColor = DefaultForeColor;
                    btnUpdateEmp.Enabled = true;
                }

            }
            else
            {

                if(txtNEmail.Text == txtCEmail.Text)
                {

                    txtNEmail.ForeColor = Color.Red;
                    btnUpdateEmp.Enabled = false;

                }

                if(txtNEmail.Text != txtCNEmail.Text)
                {

                    txtCNEmail.ForeColor = Color.Red;
                    btnUpdateEmp.Enabled = false;

                }

            }
            
        }

        private void txtCNEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtNEmail.Text == txtCNEmail.Text)
                txtCNEmail.ForeColor = DefaultForeColor;

            if (txtNEmail.Text == txtCNEmail.Text && txtCEmail.Text != txtNEmail.Text && txtNEmail.Text != "" && txtNEmail.Text.EndsWith(".com"))
            {
                txtCNEmail.ForeColor = DefaultForeColor;
                if(txtID.Text != "" && txtCEmail.Text != "")
                    btnUpdateEmp.Enabled = true;
            }
            else
            {
                txtCNEmail.ForeColor = Color.Red;
                btnUpdateEmp.Enabled = false;
            }
        }

        private void frmUEmp_Load(object sender, EventArgs e)
        {
            fillBranches();
            dtUntil.MinDate = DateTime.Now;

            cbUEmp.SelectedItem = "Email address";
            txtID.Focus();
        }

        private void cbUEmp_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbUEmp.SelectedItem.ToString() == "Email address")
            {
                btnUpdateEmp.Enabled = false;
                txtID.Visible = true;
                txtCEmail.Visible = true;
                txtNEmail.Visible = true;
                txtCNEmail.Visible = true;

                lblID.Visible = true;
                lblNEmail.Visible = true;
                lblCEmail.Visible = true;
                lblCNEmail.Visible = true;
                txtID.Focus();

            }
            else
            {

                txtID.Visible = false;
                txtCEmail.Visible = false;
                txtNEmail.Visible = false;
                txtCNEmail.Visible = false;

                txtID.Clear();
                txtCEmail.Clear();
                txtNEmail.Clear();
                txtCNEmail.Clear();

                lblID.Visible = false;
                lblNEmail.Visible = false;
                lblCEmail.Visible = false;
                lblCNEmail.Visible = false;

            }


            if (cbUEmp.SelectedItem.ToString() == "Extend/shorten employment")
            {
                btnUpdateEmp.Enabled = false;
                txtPeriodID.Visible = true;
                dtUntil.Visible = true;

                lblPeriodId.Visible = true;
                lblUntil.Visible = true;
                txtPeriodID.Focus();

            }
            else
            {

                txtPeriodID.Visible = false;
                dtUntil.Visible = false;

                txtPeriodID.Clear();
                dtUntil.Value = DateTime.Now;

                lblPeriodId.Visible = false;
                lblUntil.Visible = false;

            }

            if (cbUEmp.SelectedItem.ToString() == "Cellphone nr")
            {
                btnUpdateEmp.Enabled = false;
                txtCellID.Visible = true;
                txtNCell.Visible = true;
                txtCNCell.Visible = true;
                txtCCell.Visible = true;

                lblCellId.Visible = true;
                lblNCell.Visible = true;
                lblCNCell.Visible = true;
                lblCCell.Visible = true;
                txtCellID.Focus();

            }
            else
            {

                txtCellID.Visible = false;
                txtNCell.Visible = false;
                txtCNCell.Visible = false;
                txtCCell.Visible = false;

                lblCellId.Visible = false;
                lblNCell.Visible = false;
                lblCNCell.Visible = false;
                lblCCell.Visible = false;

                txtCCell.Clear();
                txtCellID.Clear();
                txtNCell.Clear();
                txtCNCell.Clear();


            }

            if (cbUEmp.SelectedItem.ToString() == "Surname")
            {
                btnUpdateEmp.Enabled = false;
                txtSurID.Visible = true;
                txtCSur.Visible = true;
                txtNSur.Visible = true;
                txtCNSur.Visible = true;

                lblSID.Visible = true;
                lblCSur.Visible = true;
                lblNSur.Visible = true;
                lblCNSur.Visible = true;
                txtSurID.Focus();

            }
            else
            {

                txtSurID.Visible = false;
                txtCSur.Visible = false;
                txtNSur.Visible = false;
                txtCNSur.Visible = false;

                lblSID.Visible = false;
                lblCSur.Visible = false;
                lblNSur.Visible = false;
                lblCNSur.Visible = false;

                txtSurID.Clear();
                txtCSur.Clear();
                txtNSur.Clear();
                txtCNSur.Clear();


            }

            if (cbUEmp.SelectedItem.ToString() == "Other")
            {
                btnUpdateEmp.Enabled = false;
                txtOID.Visible = true;
                cbTemp.Visible = true;
                cbUser.Visible = true;
                cbBranches.Visible = true;
                lblBranches.Visible = true;
                txtOID.Focus();

            }
            else
            {
                txtOID.Clear();
                cbBranches.SelectedItem = null;
                txtOID.Visible = false;
                cbTemp.Visible = false;
                cbUser.Visible = false;
                cbBranches.Visible = false;
                lblBranches.Visible = false;

            }
        }

        private void txtPeriodID_TextChanged(object sender, EventArgs e)
        {
            if (txtPeriodID.Text.Length != 13 && txtPeriodID.Text.Length != 10)
            {
                txtPeriodID.ForeColor = Color.Red;
                btnUpdateEmp.Enabled = false;

            }
            else
            {
                id = txtPeriodID.Text;
                txtPeriodID.ForeColor = DefaultForeColor;
                if(dtUntil.Value > DateTime.Now)
                    btnUpdateEmp.Enabled = true;

            }

            long empID;
            try
            {
                empID = Convert.ToInt64(txtPeriodID.Text);

            }
            catch
            {
                try
                {
                    txtPeriodID.Text = txtPeriodID.Text.Substring(0, txtPeriodID.Text.Length - 1);
                    txtPeriodID.Focus();
                    txtPeriodID.SelectionStart = txtPeriodID.Text.Length;
                }
                catch
                {

                    txtPeriodID.Text = "";

                }

            }
        }

        private void dtUntil_ValueChanged(object sender, EventArgs e)
        {
            if(dtUntil.Value > DateTime.Now)
            {

                if(txtPeriodID.Text.Length == 13 || txtPeriodID.Text.Length == 10)
                {

                    btnUpdateEmp.Enabled = true;

                }

            }
        }

        private void txtCCell_TextChanged(object sender, EventArgs e)
        {
            if(txtCCell.Text.Length != 10 || !txtCCell.Text.StartsWith("0"))
            {

                txtCCell.ForeColor = Color.Red;
                btnUpdateEmp.Enabled = false;

            }
            else
            {

                txtCCell.ForeColor = DefaultForeColor;

                if(txtCellID.ForeColor != Color.Red && txtNCell.Text == txtCNCell.Text && txtCNCell.Text != "" && txtNCell.Text != txtCCell.Text)
                {

                    btnUpdateEmp.Enabled = true;

                }

            }

            long empID;
            try
            {
                empID = Convert.ToInt64(txtCCell.Text);

            }
            catch
            {
                try
                {
                    txtCCell.Text = txtCCell.Text.Substring(0, txtCCell.Text.Length - 1);
                    txtCCell.Focus();
                    txtCCell.SelectionStart = txtCCell.Text.Length;
                }
                catch
                {

                    txtCCell.Text = "";

                }

            }
        }

        private void txtNCell_TextChanged(object sender, EventArgs e)
        {
            if(txtCNCell.Text != txtNCell.Text)
            {

                txtCNCell.ForeColor = Color.Red;
                btnUpdateEmp.Enabled = false;

            }

            if (txtNCell.Text == txtCCell.Text)
            {
                txtNCell.ForeColor = Color.Red;
                btnUpdateEmp.Enabled = false;

            }
            else
                txtNCell.ForeColor = DefaultForeColor;

            if (txtNCell.Text.Length == 10 || txtNCell.Text.StartsWith("0") || txtNCell.Text != txtCCell.Text)
            {

                txtCCell.ForeColor = DefaultForeColor;

                if (txtCellID.ForeColor != Color.Red && txtCCell.Text != txtNCell.Text && txtCNCell.Text == txtNCell.Text && txtNCell.Text!= "")
                {

                    btnUpdateEmp.Enabled = true;

                }

            }

            long empID;
            try
            {
                empID = Convert.ToInt64(txtNCell.Text);

            }
            catch
            {
                try
                {
                    txtNCell.Text = txtNCell.Text.Substring(0, txtNCell.Text.Length - 1);
                    txtNCell.Focus();
                    txtNCell.SelectionStart = txtNCell.Text.Length;
                }
                catch
                {

                    txtNCell.Text = "";

                }

            }
        }

        private void txtCNCell_TextChanged(object sender, EventArgs e)
        {

            if (txtCNCell.Text != txtNCell.Text)
            {

                txtCNCell.ForeColor = Color.Red;
                btnUpdateEmp.Enabled = false;

            }
            else
                txtCNCell.ForeColor = DefaultForeColor;

            if (txtCNCell.Text.Length == 10 || txtCNCell.Text.StartsWith("0") || txtCNCell.Text == txtNCell.Text)
            {

                txtCCell.ForeColor = DefaultForeColor;

                if (txtCellID.ForeColor != Color.Red && txtNCell.Text == txtCNCell.Text && txtCNCell.Text != "" && txtNCell.Text != txtCCell.Text)
                {

                    btnUpdateEmp.Enabled = true;

                }

            }

            long empID;
            try
            {
                empID = Convert.ToInt64(txtCNCell.Text);

            }
            catch
            {
                try
                {
                    txtCNCell.Text = txtCNCell.Text.Substring(0, txtCNCell.Text.Length - 1);
                    txtCNCell.Focus();
                    txtCNCell.SelectionStart = txtCNCell.Text.Length;
                }
                catch
                {

                    txtCNCell.Text = "";

                }

            }
        }

        private void txtCellID_TextChanged(object sender, EventArgs e)
        {
            if (txtCellID.Text.Length == 13)
                txtCellID.ForeColor = DefaultForeColor;
            else if (txtCellID.Text.Length == 10)
                txtCellID.ForeColor = DefaultForeColor;
            else
            {
                txtCellID.ForeColor = Color.Red;
                btnUpdateEmp.Enabled = false;
            }

            if (txtCellID.Text.Length == 13 || txtCellID.Text.Length == 10)
            {
                id = txtCellID.Text;
                txtCellID.ForeColor = DefaultForeColor;
                if (txtCCell.Text.Length == 10 && txtNCell.Text.Length == 10 && txtCNCell.Text.Length == 10)
                    btnUpdateEmp.Enabled = true;

            }

            long empID;
            try
            {
                empID = Convert.ToInt64(txtCellID.Text);

            }
            catch
            {
                try
                {
                    txtCellID.Text = txtCellID.Text.Substring(0, txtCellID.Text.Length - 1);
                    txtCellID.Focus();
                    txtCellID.SelectionStart = txtCellID.Text.Length;
                }
                catch
                {

                    txtCellID.Text = "";

                }

            }
        }

        private void txtSurID_TextChanged(object sender, EventArgs e)
        {
            if (txtSurID.Text.Length == 13)
            {
                id = txtSurID.Text;
                txtSurID.ForeColor = DefaultForeColor;
                if (txtSurID.ForeColor != Color.Red && txtNSur.Text == txtCNSur.Text && txtCNSur.Text != "" && txtCSur.Text != "")
                    btnUpdateEmp.Enabled = true;
            }
            else if (txtSurID.Text.Length == 10)
            {
                txtSurID.ForeColor = DefaultForeColor;
                if (txtSurID.ForeColor != Color.Red && txtNSur.Text == txtCNSur.Text && txtCNSur.Text != "" && txtCSur.Text != "")
                    btnUpdateEmp.Enabled = true;
            }
            else
            {
                txtSurID.ForeColor = Color.Red;
                btnUpdateEmp.Enabled = false;
            }

            long empID;
            try
            {
                empID = Convert.ToInt64(txtSurID.Text);

            }
            catch
            {
                try
                {
                    txtSurID.Text = txtSurID.Text.Substring(0, txtSurID.Text.Length - 1);
                    txtSurID.Focus();
                    txtSurID.SelectionStart = txtSurID.Text.Length;
                }
                catch
                {

                    txtSurID.Text = "";

                }

            }
        }

        private void txtCSur_TextChanged(object sender, EventArgs e)
        {

            if(txtNSur.Text == txtCSur.Text)
            {

                txtNSur.ForeColor = Color.Red;
                btnUpdateEmp.Enabled = false;

            }
            else
            {

                txtNSur.ForeColor = DefaultForeColor;
                if (txtSurID.ForeColor != Color.Red && txtNSur.Text == txtCNSur.Text && txtCNSur.Text != "" && txtCSur.Text != "")
                    btnUpdateEmp.Enabled = true;

            }

        }

        private void txtNSur_TextChanged(object sender, EventArgs e)
        {
            if(txtCNSur.Text != txtNSur.Text)
            {

                txtCNSur.ForeColor = Color.Red;
                btnUpdateEmp.Enabled = false;

            }

            if(txtNSur.Text == txtCSur.Text)
            {

                txtNSur.ForeColor = Color.Red;
                btnUpdateEmp.Enabled = false;

            }
            else
            {

                txtNSur.ForeColor = DefaultForeColor;

                if (txtSurID.ForeColor != Color.Red && txtNSur.Text == txtCNSur.Text && txtCNSur.Text != "" && txtCSur.Text != "")
                    btnUpdateEmp.Enabled = true;

            }
        }

        private void txtCNSur_TextChanged(object sender, EventArgs e)
        {
            if (txtCNSur.Text != txtNSur.Text)
            {

                txtCNSur.ForeColor = Color.Red;
                btnUpdateEmp.Enabled = false;

            }
            else
            {

                txtCNSur.ForeColor = DefaultForeColor;

                if (txtSurID.ForeColor != Color.Red && txtNSur.Text == txtCNSur.Text && txtCNSur.Text != "" && txtCSur.Text != "")
                    btnUpdateEmp.Enabled = true;

            }
        }

        private void fillBranches()
        {

            using (SqlConnection con = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
            {
                string cmdstring = "SELECT branch_location FROM Branches WHERE branch_location <> @thisbranch";
                using (SqlCommand comm = new SqlCommand(cmdstring, con))
                {
                    con.Open();
                    comm.Parameters.AddWithValue("@thisbranch", Properties.Settings.Default.Branch);
                    using (var reader = comm.ExecuteReader())
                    {
                        while(reader.Read())
                        {

                            string branch = reader.GetString(0);
                            cbBranches.Items.Add(branch);

                        }

                    }


                    con.Close();                    

                }
            }
        }

        private void txtOID_TextChanged(object sender, EventArgs e)
        {
            if (txtOID.Text.Length == 13 || txtOID.Text.Length == 10)
            {
                id = txtOID.Text;
                txtOID.ForeColor = DefaultForeColor;
                btnUpdateEmp.Enabled = true;

            }
            else
            {
                txtOID.ForeColor = Color.Red;
                btnUpdateEmp.Enabled = false;
            }

            long empID;
            try
            {
                empID = Convert.ToInt64(txtOID.Text);

            }
            catch
            {
                try
                {
                    txtOID.Text = txtOID.Text.Substring(0, txtOID.Text.Length - 1);
                    txtOID.Focus();
                    txtOID.SelectionStart = txtOID.Text.Length;
                }
                catch
                {

                    txtOID.Text = "";

                }

            }
        }

        private void btnUpdateEmp_Click(object sender, EventArgs e)
        {

            string cmdstring = "";

            using (SqlConnection con = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
            {
                string find = "";
                if (cbUEmp.SelectedItem.ToString() == "Email address")
                {
                                      
                    if (txtID.Text.Length == 13)
                        find = "id_num";
                    else if (txtID.Text.Length == 10 && !txtID.Text.StartsWith("0"))
                        find = "employee_id";

                    cmdstring = "UPDATE Employees SET email_address = @value WHERE " + find + " = @findV AND email_address = @value2";
                    
                }

                if (cbUEmp.SelectedItem.ToString() == "Cellphone nr" || cbUEmp.SelectedItem.ToString() == "Extend/shorten employment" || cbUEmp.SelectedItem.ToString() == "Surname" || cbUEmp.SelectedItem.ToString() == "Other")
                {

                    if (txtPeriodID.Text.Length == 13)
                        find = "id_num";
                    else if (txtPeriodID.Text.Length == 10)
                        find = "employee_id";

                    if (txtOID.Text.Length == 13)
                        find = "id_num";
                    else if (txtOID.Text.Length == 10)
                        find = "employee_id";

                    if (txtPeriodID.Text.Length == 13)
                        find = "id_num";
                    else if (txtPeriodID.Text.Length == 10)
                        find = "employee_id";

                    if (txtSurID.Text.Length == 13)
                        find = "id_num";
                    else if (txtSurID.Text.Length == 10)
                        find = "employee_id";


                    if (cbUEmp.SelectedItem.ToString() == "Cellphone nr")
                        cmdstring = "UPDATE Employees SET cell = @value WHERE cell = @test2";

                    if (cbUEmp.SelectedItem.ToString() == "Extend/shorten employment")
                        cmdstring = "UPDATE Employees SET employed_until = @until WHERE " + find + " = @value";

                    if (cbUEmp.SelectedItem.ToString() == "Surname")
                        cmdstring = "UPDATE Employees SET surname = @value WHERE " + find + " = @test  AND surname = @test2";

                    if (cbUEmp.SelectedItem.ToString() == "Other")
                    {
                        if(cbBranches.SelectedItem != null)
                            cmdstring = "UPDATE Employees SET branch = @branch, is_user = @user, is_temp = @temp WHERE " + find + " = @test";
                        else
                            cmdstring = "UPDATE Employees SET is_user = @user, is_temp = @temp WHERE " + find + " = @test";
                    }
                }

                using (SqlCommand comm = new SqlCommand(cmdstring, con))
                {
                    gebruik other = new gebruik();

                    con.Open();
                    //update email
                    if (cbUEmp.SelectedItem.ToString() == "Email address")
                    {
                        comm.Parameters.AddWithValue("@value", txtCNEmail.Text);

                        comm.Parameters.AddWithValue("@findV", txtID.Text);
                        comm.Parameters.AddWithValue("@value2", txtCEmail.Text);

                        if (other.getUsername(txtCEmail.Text) != "")
                        {
                            DialogResult result = MessageBox.Show("The system has detected the this employee has an account with the current email address. Would you like to automatically update the user account too?", "Info", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                                setUserEmail(txtCNEmail.Text, txtCEmail.Text);
                        }

                    }
                    //update period
                    if (cbUEmp.SelectedItem.ToString() == "Extend/shorten employment")
                    {

                        comm.Parameters.AddWithValue("@until", dtUntil.Value);
                        comm.Parameters.AddWithValue("@value", txtPeriodID.Text);

                    }
                    //update cell
                    if(cbUEmp.SelectedItem.ToString() == "Cellphone nr")
                    {

                        comm.Parameters.AddWithValue("@value", txtCNCell.Text);
                        comm.Parameters.AddWithValue("@test", txtCellID.Text);
                        comm.Parameters.AddWithValue("@test2",txtCCell.Text);

                    }
                    //update surname
                    if(cbUEmp.SelectedItem.ToString() == "Surname")
                    {

                        comm.Parameters.AddWithValue("@value", txtCNSur.Text);
                        comm.Parameters.AddWithValue("@test", txtSurID.Text);
                        comm.Parameters.AddWithValue("@test2", txtCSur.Text);

                    }
                    //update other
                    if (cbUEmp.SelectedItem.ToString() == "Other")
                    {
                        if (cbBranches.SelectedItem != null)
                        {

                            comm.Parameters.AddWithValue("@branch", cbBranches.SelectedItem.ToString());
                            comm.Parameters.AddWithValue("@user", cbUser.Checked);
                            comm.Parameters.AddWithValue("@temp", cbTemp.Checked);
                            comm.Parameters.AddWithValue("@test", txtOID.Text);

                        }
                        else
                        {

                            comm.Parameters.AddWithValue("@user", cbUser.Checked);
                            comm.Parameters.AddWithValue("@temp", cbTemp.Checked);
                            comm.Parameters.AddWithValue("@test", txtOID.Text);


                        }
                    }



                    if (cbUEmp.SelectedItem.ToString() == "Other" && !cbUser.Checked && other.isUser(txtOID.Text) && other.getUsername(other.getEmail(id)) != "")
                    {
                        comm.ExecuteNonQuery();

                        gebruik.addAction(user);
                        DateTime local = DateTime.Now;
                        gebruik.log(local, user, "updated employee");

                        DialogResult result = MessageBox.Show("The employee's information has been updated.\r\n\r\nThe system has detected that this employee currently has an account for the system. Would you like to remove it now?", "Info", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            
                            frmRUser rU = new frmRUser(user, other.getUsername(other.getEmail(id)));

                            

                            rU.ShowDialog();
                            this.Close();

                        }

                    }
                    else
                    {
                        comm.ExecuteNonQuery();
                        MessageBox.Show("The employee's information has been updated.");

                        gebruik.addAction(user);
                        DateTime local = DateTime.Now;
                        gebruik.log(local, user, "updated employee");

                        this.Close();
                    }

                }
            }
        }

        

        private void setUserEmail(string newMail, string mail)
        {

            using (SqlConnection conEmail = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
            {
                string cmdstring = "UPDATE Users SET email_address = @email WHERE email_address = @test";

                using (SqlCommand commEmail = new SqlCommand(cmdstring, conEmail))
                {
                    conEmail.Open();
                    commEmail.Parameters.AddWithValue("@email", newMail);
                    commEmail.Parameters.AddWithValue("@test", mail);

                    commEmail.ExecuteNonQuery();

                    conEmail.Close();

                }
            }

        }

    }
}
