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

        private List<string> ids = new List<string>();
        private List<string> sur = new List<string>();
        private List<string> email = new List<string>();
        private List<string> cel = new List<string>();

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            


         
        }

        private void txtCEmail_TextChanged(object sender, EventArgs e)
        {
            try
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
                    if (txtNEmail.Text == txtCNEmail.Text && txtCNEmail.Text != "" && cbID.SelectedItem != null)
                        btnUpdateEmp.Enabled = true;
                }
                else if (!txtCEmail.Text.EndsWith(".com") || txtCEmail.Text.Length < 7)
                {
                    txtCEmail.ForeColor = Color.Red;
                    btnUpdateEmp.Enabled = false;
                }
            }
            catch(FormatException)
            { }
            catch(InvalidCastException)
            { }
            catch(Exception)
            { }
        }

        private void txtNEmail_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtNEmail.Text == txtCNEmail.Text)
                    txtCNEmail.ForeColor = DefaultForeColor;
                else
                    txtCNEmail.ForeColor = Color.Red;

                if (txtCEmail.Text != txtNEmail.Text && txtNEmail.Text != "" && txtNEmail.Text.EndsWith(".com"))
                {
                    txtNEmail.ForeColor = DefaultForeColor;
                    if (cbID.SelectedItem != null && txtCEmail.Text != "" && txtNEmail.Text == txtCNEmail.Text)
                    {
                        txtCNEmail.ForeColor = DefaultForeColor;
                        btnUpdateEmp.Enabled = true;
                    }

                }
                else
                {

                    if (txtNEmail.Text == txtCEmail.Text)
                    {

                        txtNEmail.ForeColor = Color.Red;
                        btnUpdateEmp.Enabled = false;

                    }

                    if (txtNEmail.Text != txtCNEmail.Text)
                    {

                        txtCNEmail.ForeColor = Color.Red;
                        btnUpdateEmp.Enabled = false;

                    }

                }
            }
            catch(FormatException)
            { }
            catch(InvalidCastException)
            { }
            catch(Exception)
            { }
            
        }

        private void txtCNEmail_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtNEmail.Text == txtCNEmail.Text)
                    txtCNEmail.ForeColor = DefaultForeColor;

                if (txtNEmail.Text == txtCNEmail.Text && txtCEmail.Text != txtNEmail.Text && txtNEmail.Text != "" && txtNEmail.Text.EndsWith(".com"))
                {
                    txtCNEmail.ForeColor = DefaultForeColor;
                    if (cbID.SelectedItem != null && txtCEmail.Text != "")
                        btnUpdateEmp.Enabled = true;
                }
                else
                {
                    txtCNEmail.ForeColor = Color.Red;
                    btnUpdateEmp.Enabled = false;
                }
            }
            catch(FormatException)
            { }
            catch(InvalidCastException)
            { }
            catch(Exception)
            { }
        }

        private void frmUEmp_Load(object sender, EventArgs e)
        {

            gebruik.fillBranches(cbBranches, cbOriBranch);
            checkHQ(user);
            fillIds();
            dtUntil.MinDate = DateTime.Now;

            cbUEmp.SelectedItem = "Email address";
            cbID.Focus();
        }

        private void cbUEmp_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (cbUEmp.SelectedItem.ToString() == "Email address")
                {
                    btnUpdateEmp.Enabled = false;
                    cbID.Visible = true;
                    txtCEmail.Visible = true;
                    txtNEmail.Visible = true;
                    txtCNEmail.Visible = true;

                    lblID.Visible = true;
                    lblNEmail.Visible = true;
                    lblCEmail.Visible = true;
                    lblCNEmail.Visible = true;
                    cbID.Focus();

                }
                else
                {

                    cbID.Visible = false;
                    txtCEmail.Visible = false;
                    txtNEmail.Visible = false;
                    txtCNEmail.Visible = false;

                    txtCEmail.Clear();
                    txtNEmail.Clear();
                    txtCNEmail.Clear();
                    cbID.SelectedItem = null;

                    lblID.Visible = false;
                    lblNEmail.Visible = false;
                    lblCEmail.Visible = false;
                    lblCNEmail.Visible = false;

                }


                if (cbUEmp.SelectedItem.ToString() == "Extend/shorten employment")
                {
                    btnUpdateEmp.Enabled = false;
                    cbPeriodID.Visible = true;
                    dtUntil.Visible = true;

                    lblPeriodId.Visible = true;
                    lblUntil.Visible = true;
                    cbPeriodID.Focus();

                }
                else
                {
                    cbPeriodID.SelectedItem = null;
                    cbPeriodID.Visible = false;
                    dtUntil.Visible = false;

                    dtUntil.Value = DateTime.Now;

                    lblPeriodId.Visible = false;
                    lblUntil.Visible = false;

                }

                if (cbUEmp.SelectedItem.ToString() == "Cellphone nr")
                {
                    btnUpdateEmp.Enabled = false;
                    cbCellId.Visible = true;
                    txtNCell.Visible = true;
                    txtCNCell.Visible = true;
                    txtCCell.Visible = true;

                    lblCellId.Visible = true;
                    lblNCell.Visible = true;
                    lblCNCell.Visible = true;
                    lblCCell.Visible = true;
                    cbCellId.Focus();

                }
                else
                {

                    cbCellId.Visible = false;
                    txtNCell.Visible = false;
                    txtCNCell.Visible = false;
                    txtCCell.Visible = false;

                    lblCellId.Visible = false;
                    lblNCell.Visible = false;
                    lblCNCell.Visible = false;
                    lblCCell.Visible = false;

                    cbCellId.SelectedItem = null;
                    txtCCell.Clear();
                    txtNCell.Clear();
                    txtCNCell.Clear();


                }

                if (cbUEmp.SelectedItem.ToString() == "Surname")
                {
                    btnUpdateEmp.Enabled = false;
                    cbSurID.Visible = true;
                    txtCSur.Visible = true;
                    txtNSur.Visible = true;
                    txtCNSur.Visible = true;

                    lblSID.Visible = true;
                    lblCSur.Visible = true;
                    lblNSur.Visible = true;
                    lblCNSur.Visible = true;
                    cbSurID.Focus();

                }
                else
                {

                    cbSurID.Visible = false;
                    txtCSur.Visible = false;
                    txtNSur.Visible = false;
                    txtCNSur.Visible = false;

                    lblSID.Visible = false;
                    lblCSur.Visible = false;
                    lblNSur.Visible = false;
                    lblCNSur.Visible = false;

                    cbSurID.SelectedItem = null;
                    txtCSur.Clear();
                    txtNSur.Clear();
                    txtCNSur.Clear();


                }

                if (cbUEmp.SelectedItem.ToString() == "Other")
                {
                    btnUpdateEmp.Enabled = false;
                    cbOID.Visible = true;
                    cbTemp.Visible = true;
                    cbUser.Visible = true;
                    cbBranches.Visible = true;
                    cbOriBranch.Visible = true;
                    lblOriBranch.Visible = true;
                    lblBranches.Visible = true;
                    cbOID.Focus();

                }
                else
                {
                    cbOID.SelectedItem = null;
                    cbBranches.SelectedItem = null;
                    cbOID.Visible = false;
                    cbTemp.Visible = false;
                    cbUser.Visible = false;
                    cbOriBranch.Visible = false;
                    lblOriBranch.Visible = false;
                    cbBranches.Visible = false;
                    lblBranches.Visible = false;

                }
            }
            catch(FormatException)
            { }
            catch(NullReferenceException)
            { }
            catch(Exception)
            { }
        }


        private void dtUntil_ValueChanged(object sender, EventArgs e)
        {
            if(dtUntil.Value > DateTime.Now)
            {

                if(cbPeriodID.SelectedItem != null)
                {

                    btnUpdateEmp.Enabled = true;

                }

            }
        }

        private void txtCCell_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (txtCCell.Text.Length != 10 || !txtCCell.Text.StartsWith("0"))
                {

                    txtCCell.ForeColor = Color.Red;
                    btnUpdateEmp.Enabled = false;

                }
                else
                {

                    txtCCell.ForeColor = DefaultForeColor;

                    if (cbCellId.SelectedItem != null && txtNCell.Text == txtCNCell.Text && txtCNCell.Text != "" && txtNCell.Text != txtCCell.Text)
                    {

                        btnUpdateEmp.Enabled = true;

                    }

                }
            }
            catch(FormatException)
            { }
            catch(InvalidCastException)
            { }
            catch(Exception)
            { }
        }

        private void txtNCell_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (txtCNCell.Text != txtNCell.Text)
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

                    if (cbCellId.SelectedItem != null && txtCCell.Text != txtNCell.Text && txtCNCell.Text == txtNCell.Text && txtNCell.Text != "")
                    {

                        btnUpdateEmp.Enabled = true;

                    }

                }
            }
            catch(FormatException)
            { }
            catch(InvalidCastException)
            { }
            catch(Exception)
            { }
           
        }

        private void txtCNCell_TextChanged(object sender, EventArgs e)
        {

            try
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

                    if (cbCellId.SelectedItem != null && txtNCell.Text == txtCNCell.Text && txtCNCell.Text != "" && txtNCell.Text != txtCCell.Text)
                    {

                        btnUpdateEmp.Enabled = true;

                    }

                }
            }
            catch(FormatException)
            { }
            catch(InvalidCastException)
            { }
            catch(Exception)
            { }
            
        }


        private void txtSurID_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void txtCSur_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (txtNSur.Text == txtCSur.Text)
                {

                    txtNSur.ForeColor = Color.Red;
                    btnUpdateEmp.Enabled = false;

                }
                else
                {

                    txtNSur.ForeColor = DefaultForeColor;
                    if (cbSurID.SelectedItem != null && txtNSur.Text == txtCNSur.Text && txtCNSur.Text != "" && txtCSur.Text != "")
                        btnUpdateEmp.Enabled = true;

                }
            }
            catch(FormatException)
            { }
            catch(InvalidCastException)
            { }
            catch(Exception)
            { }

        }

        private void txtNSur_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtCNSur.Text != txtNSur.Text)
                {

                    txtCNSur.ForeColor = Color.Red;
                    btnUpdateEmp.Enabled = false;

                }

                if (txtNSur.Text == txtCSur.Text)
                {

                    txtNSur.ForeColor = Color.Red;
                    btnUpdateEmp.Enabled = false;

                }
                else
                {

                    txtNSur.ForeColor = DefaultForeColor;

                    if (cbSurID.SelectedItem != null && txtNSur.Text == txtCNSur.Text && txtCNSur.Text != "" && txtCSur.Text != "")
                        btnUpdateEmp.Enabled = true;

                }
            }
            catch(FormatException)
            { }
            catch(InvalidCastException)
            { }
            catch(Exception)
            { }
        }

        private void txtCNSur_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (txtCNSur.Text != txtNSur.Text)
                {

                    txtCNSur.ForeColor = Color.Red;
                    btnUpdateEmp.Enabled = false;

                }
                else
                {

                    txtCNSur.ForeColor = DefaultForeColor;

                    if (cbSurID.SelectedItem != null && txtNSur.Text == txtCNSur.Text && txtCNSur.Text != "" && txtCSur.Text != "")
                        btnUpdateEmp.Enabled = true;

                }
            }
            catch(InvalidCastException)
            { }
            catch(FormatException)
            { }
            catch(Exception)
            { }
        }

        

        private void btnUpdateEmp_Click(object sender, EventArgs e)
        {

            try
            {
                string cmdstring = "";

                using (SqlConnection con = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                {
                    string find = "";
                    if (cbUEmp.SelectedItem.ToString() == "Email address")
                    {

                        if (cbID.SelectedItem != null)
                            find = "employee_id";

                        cmdstring = "UPDATE Employees SET email_address = @value WHERE " + find + " = @findV AND email_address = @value2";

                    }

                    if (cbUEmp.SelectedItem.ToString() == "Cellphone nr" || cbUEmp.SelectedItem.ToString() == "Extend/shorten employment" || cbUEmp.SelectedItem.ToString() == "Surname" || cbUEmp.SelectedItem.ToString() == "Other")
                    {

                        try
                        {
                            if (cbPeriodID.SelectedItem != null & cbPeriodID.SelectedItem.ToString().Length == 13)
                                find = "id_num";
                            else if (cbPeriodID.SelectedItem.ToString().Length == 10)
                                find = "employee_id";
                        }
                        catch (NullReferenceException)
                        { }

                        if (cbOID.SelectedItem != null)
                            find = "employee_id";

                        try
                        {
                            if (cbPeriodID.SelectedItem.ToString().Length == 13)
                                find = "id_num";
                            else if (cbPeriodID.SelectedItem.ToString().Length == 10)
                                find = "employee_id";
                        }
                        catch (NullReferenceException)
                        { }

                        if (cbSurID.SelectedItem != null)
                            find = "employee_id";


                        if (cbUEmp.SelectedItem.ToString() == "Cellphone nr")
                            cmdstring = "UPDATE Employees SET cell = @value WHERE cell = @test2";

                        if (cbUEmp.SelectedItem.ToString() == "Extend/shorten employment")
                            cmdstring = "UPDATE Employees SET employed_until = @until WHERE " + find + " = @value";

                        if (cbUEmp.SelectedItem.ToString() == "Surname")
                            cmdstring = "UPDATE Employees SET surname = @value WHERE " + find + " = @test  AND surname = @test2";

                        if (cbUEmp.SelectedItem.ToString() == "Other")
                        {
                            if (cbBranches.SelectedItem != null)
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

                            comm.Parameters.AddWithValue("@findV", cbID.SelectedItem.ToString());
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
                            comm.Parameters.AddWithValue("@value", cbPeriodID.SelectedItem.ToString());

                        }
                        //update cell
                        if (cbUEmp.SelectedItem.ToString() == "Cellphone nr")
                        {

                            comm.Parameters.AddWithValue("@value", txtCNCell.Text);
                            comm.Parameters.AddWithValue("@test", cbCellId.SelectedItem.ToString());
                            comm.Parameters.AddWithValue("@test2", txtCCell.Text);

                        }
                        //update surname
                        if (cbUEmp.SelectedItem.ToString() == "Surname")
                        {

                            comm.Parameters.AddWithValue("@value", txtCNSur.Text);
                            comm.Parameters.AddWithValue("@test", cbSurID.SelectedItem.ToString());
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
                                comm.Parameters.AddWithValue("@test", cbOID.SelectedItem.ToString());

                            }
                            else
                            {

                                comm.Parameters.AddWithValue("@user", cbUser.Checked);
                                comm.Parameters.AddWithValue("@temp", cbTemp.Checked);
                                comm.Parameters.AddWithValue("@test", cbOID.SelectedItem.ToString());


                            }
                        }



                        if (cbUEmp.SelectedItem.ToString() == "Other" && !cbUser.Checked && other.isUser(cbOID.SelectedItem.ToString()) && other.getUsername(other.getEmail(id)) != "")
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
                                DialogResult choice;
                                choice = MessageBox.Show("Would you like to update another employee?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                                if (choice == DialogResult.Yes)
                                {

                                    string old = cbUEmp.SelectedItem.ToString();
                                    if (cbUEmp.SelectedItem.ToString() == "Other")
                                    {

                                        cbUEmp.SelectedItem = "Email address";
                                        cbUEmp.SelectedItem = "Other";

                                    }
                                    else
                                    {
                                        cbUEmp.SelectedItem = "Other";
                                        cbUEmp.SelectedItem = old;
                                    }

                                }
                                else
                                    this.Close();


                            }

                        }
                        else if (cbUEmp.SelectedItem.ToString() == "Other" && cbUser.Checked && !other.isUser(cbOID.SelectedItem.ToString()) && other.getUsername(other.getEmail(id)) == "")
                        {
                            comm.ExecuteNonQuery();

                            gebruik.addAction(user);
                            DateTime local = DateTime.Now;
                            gebruik.log(local, user, "updated employee");

                            DialogResult result = MessageBox.Show("The employee's information has been updated.\r\n\r\nThe system has detected that this employee does not currently have an account for the system. Would you like to create it now?", "Info", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {

                                frmAddUser aU = new frmAddUser(user, other.getUsername(other.getEmail(id)));

                                aU.ShowDialog();

                                DialogResult choice2;
                                choice2 = MessageBox.Show("The employee's informations has been updated.\r\nWould you like to update another employee?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                                if (choice2 == DialogResult.Yes)
                                {
                                    string old = cbUEmp.SelectedItem.ToString();
                                    if (cbUEmp.SelectedItem.ToString() == "Other")
                                    {

                                        cbUEmp.SelectedItem = "Email address";
                                        cbUEmp.SelectedItem = "Other";

                                    }
                                    else
                                    {
                                        cbUEmp.SelectedItem = "Other";
                                        cbUEmp.SelectedItem = old;
                                    }

                                }
                                else
                                    this.Close();

                            }

                            DialogResult choice;
                            choice = MessageBox.Show("The employee's informations has been updated.\r\nWould you like to update another employee?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                            if (choice == DialogResult.Yes)
                            {

                                string old = cbUEmp.SelectedItem.ToString();
                                if (cbUEmp.SelectedItem.ToString() == "Other")
                                {

                                    cbUEmp.SelectedItem = "Email address";
                                    cbUEmp.SelectedItem = "Other";

                                }
                                else
                                {
                                    cbUEmp.SelectedItem = "Other";
                                    cbUEmp.SelectedItem = old;
                                }

                            }
                            else
                                this.Close();

                        }
                        else
                        {

                            comm.ExecuteNonQuery();

                            gebruik.addAction(user);
                            DateTime local = DateTime.Now;
                            gebruik.log(local, user, "updated employee");

                            DialogResult choice;
                            choice = MessageBox.Show("The employee's informations has been updated.\r\nWould you like to update another employee?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                            if (choice == DialogResult.Yes)
                            {

                                string old = cbUEmp.SelectedItem.ToString();
                                if (cbUEmp.SelectedItem.ToString() == "Other")
                                {

                                    cbUEmp.SelectedItem = "Email address";
                                    cbUEmp.SelectedItem = "Other";

                                }
                                else
                                {
                                    cbUEmp.SelectedItem = "Other";
                                    cbUEmp.SelectedItem = old;
                                }

                            }
                            else
                                this.Close();

                        }

                    }
                }
            }
            catch(FormatException)
            { }
            catch(InvalidCastException)
            { }
            catch (SqlException se)
            {

                if (se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection())
                        btnUpdateEmp.PerformClick();
                    else
                        MessageBox.Show("It appears that you have lost internet connection. Please verify your internet connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

            }
            catch (Exception)
            { }
        }

        

        private void setUserEmail(string newMail, string mail)
        {
            try
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
            catch(FormatException)
            { }
            catch(InvalidCastException)
            { }
            catch (SqlException se)
            {

                if (se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection())
                        setUserEmail(newMail,mail);
                    else
                        MessageBox.Show("It appears that you have lost internet connection. Please verify your internet connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

            }
            catch(Exception)
            { }

        }

        private void checkHQ(string user)
        {

            try
            {
                using (SqlConnection con = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                {
                    string cmdstring = "SELECT branch FROM Users WHERE userName = @user";

                    using (SqlCommand comm = new SqlCommand(cmdstring, con))
                    {
                        con.Open();
                        comm.Parameters.AddWithValue("@user", user);

                        string branch = "";

                        using (var reader = comm.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                branch = reader.GetString(0);

                            }

                        }

                        if (branch == "HQ")
                        {

                            cbOriBranch.Enabled = true;

                        }
                        else
                        {

                            cbOriBranch.SelectedItem = Properties.Settings.Default.Branch;
                            cbOriBranch.Enabled = false;

                        }



                    }
                }
            }
            catch(FormatException)
            { }
            catch(InvalidCastException)
            { }
            catch (SqlException se)
            {

                if (se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection())
                        checkHQ(user);
                    else
                        MessageBox.Show("It appears that you have lost internet connection. Please verify your internet connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

            }
            catch(Exception)
            { }
        }

        private void fillIds()
        {

            try
            {
                using (SqlConnection con = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                {
                    string cmdstring = "SELECT employee_id, surname, email_address, cell FROM Employees WHERE branch = @thisbranch";

                    using (SqlCommand comm = new SqlCommand(cmdstring, con))
                    {
                        con.Open();
                        comm.Parameters.AddWithValue("@thisbranch", Properties.Settings.Default.Branch);

                        using (var reader = comm.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                string id = reader.GetString(0);
                                cbCellId.Items.Add(id);
                                cbID.Items.Add(id);
                                cbOID.Items.Add(id);
                                cbPeriodID.Items.Add(id);
                                cbSurID.Items.Add(id);

                                ids.Add(id);
                                sur.Add(reader.GetString(1));
                                email.Add(reader.GetString(2));
                                cel.Add(reader.GetString(3));

                            }

                        }

                        con.Close();

                    }
                }
            }
            catch(FormatException)
            { }
            catch(InvalidCastException)
            { }
            catch (SqlException se)
            {

                if (se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection())
                        fillIds();
                    else
                        MessageBox.Show("It appears that you have lost internet connection. Please verify your internet connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

            }
            catch(Exception)
            { }

        }

        private void cbCellId_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                if (cbCellId.SelectedItem != null)
                {
                    id = cbCellId.SelectedItem.ToString();
                    if (txtCCell.Text.Length == 10 && txtNCell.Text.Length == 10 && txtCNCell.Text.Length == 10)
                        btnUpdateEmp.Enabled = true;

                    txtCCell.Text = cel.ElementAt(ids.IndexOf(cbCellId.SelectedItem.ToString()));

                }
            }
            catch(FormatException)
            { }
            catch(InvalidCastException)
            { }
            catch(NullReferenceException)
            { }
            catch(Exception)
            { }

        }

        private void cbPeriodID_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                if (cbPeriodID.SelectedItem != null)
                {
                    id = cbPeriodID.SelectedItem.ToString();
                    if (dtUntil.Value > DateTime.Now)
                        btnUpdateEmp.Enabled = true;

                }
            }
            catch(FormatException)
            { }
            catch(InvalidCastException)
            { }
            catch(NullReferenceException)
            { }
            catch(Exception)
            { }
        }

        private void cbID_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                if (cbID.SelectedItem != null)
                {
                    txtCEmail.Text = email.ElementAt(ids.IndexOf(cbID.SelectedItem.ToString()));

                    id = cbID.SelectedItem.ToString();
                    if (txtCEmail.Text != "" && txtNEmail.Text != "" && txtCNEmail.Text == txtNEmail.Text)
                        btnUpdateEmp.Enabled = true;
                }
                else if (cbID.SelectedItem == null)
                {
                    btnUpdateEmp.Enabled = false;
                }
            }
            catch(InvalidCastException)
            { }
            catch(FormatException)
            { }
            catch(NullReferenceException)
            { }
            catch(Exception)
            { }
        }

        private void cbOID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbOID.SelectedItem != null)
                {
                    id = cbOID.SelectedItem.ToString();

                    btnUpdateEmp.Enabled = true;

                }
                else
                {

                    btnUpdateEmp.Enabled = false;
                }
            }
            catch(FormatException)
            { }
            catch(InvalidCastException)
            { }
            catch(NullReferenceException)
            { }
            catch(Exception)
            { }
        }

        private void cbSurID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbSurID.SelectedItem != null)
                {
                    txtCSur.Text = sur.ElementAt(ids.IndexOf(cbSurID.SelectedItem.ToString()));

                    if (cbSurID.SelectedItem != null && txtNSur.Text == txtCNSur.Text && txtCNSur.Text != "" && txtCSur.Text != "")
                        btnUpdateEmp.Enabled = true;
                }
                else
                {
                    btnUpdateEmp.Enabled = false;
                }
            }
            catch (FormatException)
            { }
            catch (InvalidCastException)
            { }
            catch (NullReferenceException)
            { }
            catch (Exception)
            { }
        }

        private void txtCCell_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtNCell_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtCNCell_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
