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
    public partial class frmAddEmp : Form
    {
        public frmAddEmp()
        {
            InitializeComponent();
        }

        public frmAddEmp(string usert)
        {
            InitializeComponent();
            user = usert;
        }

     
        private bool branch;
        private gebruik other = new gebruik();

        public frmAddEmp(string usert, string em)
        {
            InitializeComponent();
            user = usert;

            txtEmpEmail.Text = em;
            cbIsUser.Checked = true;
            rbManager.Checked = true;
            branch = true;
            btnCancelEmp.Enabled = false;
            
        }

        string user;

        private void frmAddEmp_Load(object sender, EventArgs e)
        {
            gebruik other = new gebruik();

            dtStart.MinDate = DateTime.Now;
            dtEnd.MinDate = DateTime.Now;

            while (txtEmpID.Text == "" || txtEmpID.Text.Length != 10)
            {
                txtEmpID.Text = other.generateLuhn();
            }

            txtEmpID.Enabled = false;
        }

        private void rbTemp_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtEmpID.Text.Length == 10 && txtEmpName.Text != "" && txtEmpSurname.Text != "" && txtEmpRSAID.Text.Length == 13)
                {

                    if (other.CheckDate(txtEmpRSAID.Text.Substring(0, 6)) && txtEmpCell.Text.Length == 10 && txtEmpEmail.Text.EndsWith(".com") && txtEmpEmail.Text.Length > 7)
                    {

                        if (rbTemp.Checked || rbManager.Checked || rbFull.Checked)
                        {

                            if (rbTemp.Checked && dtEnd.Value >= dtStart.Value)
                                btnAddEmp.Enabled = true;
                            else if (!rbTemp.Checked)
                                btnAddEmp.Enabled = true;
                            else
                                btnAddEmp.Enabled = false;

                        }
                        else
                            btnAddEmp.Enabled = false;

                    }
                    else
                        btnAddEmp.Enabled = false;

                }
                else
                    btnAddEmp.Enabled = false;

                if (rbTemp.Checked)
                {

                    dtEnd.Visible = true;
                    lblEndDate.Visible = true;

                }
                else
                {

                    dtEnd.Visible = false;
                    lblEndDate.Visible = false;

                }
            }
            catch(FormatException)
            { }
            catch(InvalidCastException)
            { }
            catch(Exception)
            { }
        }

        private void btnCancelEmp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEmpID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtEmpID.Text.Length == 10)
                {
                    txtEmpID.ForeColor = DefaultForeColor;


                    if (txtEmpName.Text != "" && txtEmpSurname.Text != "" && txtEmpRSAID.Text.Length == 13)
                    {
                        gebruik other = new gebruik();
                        if (other.validateId(txtEmpRSAID.Text))
                        {
                            txtEmpRSAID.ForeColor = DefaultForeColor;

                            if (txtEmpCell.Text.Length == 10 && txtEmpEmail.Text.EndsWith(".com") && txtEmpEmail.Text.Length > 7)
                            {

                                if (rbTemp.Checked || rbManager.Checked || rbFull.Checked)
                                {

                                    if (rbTemp.Checked && dtEnd.Value >= dtStart.Value)
                                        btnAddEmp.Enabled = true;
                                    else if (!rbTemp.Checked)
                                        btnAddEmp.Enabled = true;
                                    else
                                        btnAddEmp.Enabled = false;

                                }
                                else
                                    btnAddEmp.Enabled = false;

                            }
                            else
                                btnAddEmp.Enabled = false;
                        }
                        else
                        {

                            btnAddEmp.Enabled = false;
                            txtEmpRSAID.ForeColor = Color.Red;

                        }

                    }

                }
                else if (txtEmpID.Text.Length != 10)
                {
                    txtEmpID.ForeColor = Color.Red;
                    btnAddEmp.Enabled = false;
                }
                else
                {
                    btnAddEmp.Enabled = false;
                }
            }
            catch(FormatException)
            { }
            catch(InvalidCastException)
            { }
            catch(Exception)
            { }

        }

        private void txtEmpName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtEmpID.Text.Length == 10 && txtEmpName.Text != "" && txtEmpSurname.Text != "" && txtEmpRSAID.Text.Length == 13)
                {

                    if (other.CheckDate(txtEmpRSAID.Text.Substring(0, 6)) && txtEmpCell.Text.Length == 10 && txtEmpEmail.Text.EndsWith(".com") && txtEmpEmail.Text.Length > 7)
                    {

                        if (rbTemp.Checked || rbManager.Checked || rbFull.Checked)
                        {

                            if (rbTemp.Checked && dtEnd.Value >= dtStart.Value)
                                btnAddEmp.Enabled = true;
                            else if (!rbTemp.Checked)
                                btnAddEmp.Enabled = true;
                            else
                                btnAddEmp.Enabled = false;

                        }
                        else
                            btnAddEmp.Enabled = false;

                    }
                    else
                        btnAddEmp.Enabled = false;

                }
                else
                    btnAddEmp.Enabled = false;
            }
            catch(FormatException)
            { }
            catch(InvalidCastException)
            { }
            catch(Exception)
            { }

        }

        private void txtEmpSurname_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtEmpID.Text.Length == 10 && txtEmpName.Text != "" && txtEmpSurname.Text != "" && txtEmpRSAID.Text.Length == 13)
                {

                    if (other.CheckDate(txtEmpRSAID.Text.Substring(0, 6)) && txtEmpCell.Text.Length == 10 && txtEmpEmail.Text.EndsWith(".com") && txtEmpEmail.Text.Length > 7)
                    {

                        if (rbTemp.Checked || rbManager.Checked || rbFull.Checked)
                        {

                            if (rbTemp.Checked && dtEnd.Value >= dtStart.Value)
                                btnAddEmp.Enabled = true;
                            else if (!rbTemp.Checked)
                                btnAddEmp.Enabled = true;
                            else
                                btnAddEmp.Enabled = false;

                        }
                        else
                            btnAddEmp.Enabled = false;

                    }
                    else
                        btnAddEmp.Enabled = false;

                }
                else
                    btnAddEmp.Enabled = false;
            }
            catch(FormatException)
            { }
            catch(InvalidCastException)
            { }
            catch(Exception)
            { }

        }

        private void txtEmpRSAID_TextChanged(object sender, EventArgs e)
        {

            gebruik other = new gebruik();

            try
            {
               
                if (txtEmpRSAID.Text.Length == 13 && other.validateId(txtEmpRSAID.Text))
                {

                    txtEmpRSAID.ForeColor = DefaultForeColor;
                    if (txtEmpID.Text.Length == 10 && txtEmpName.Text != "" && txtEmpSurname.Text != "")
                    {
                        if (other.CheckDate(txtEmpRSAID.Text.Substring(0, 6)) && txtEmpCell.Text.Length == 10 && txtEmpEmail.Text.EndsWith(".com") && txtEmpEmail.Text.Length > 7)
                        {

                            if (rbTemp.Checked || rbManager.Checked || rbFull.Checked)
                            {

                                if (rbTemp.Checked && dtEnd.Value >= dtStart.Value)
                                    btnAddEmp.Enabled = true;
                                else if (!rbTemp.Checked)
                                    btnAddEmp.Enabled = true;
                                else
                                    btnAddEmp.Enabled = false;

                            }
                            else
                                btnAddEmp.Enabled = false;

                        }
                        else
                            btnAddEmp.Enabled = false;
                    }

                }
                else if (txtEmpRSAID.Text.Length != 13)
                {
                    txtEmpRSAID.ForeColor = Color.Red;
                    btnAddEmp.Enabled = false;
                }
                else
                {
                    txtEmpRSAID.ForeColor = Color.Red;
                    btnAddEmp.Enabled = false;
                }

                if (!other.CheckDate(txtEmpRSAID.Text.Substring(0, 6)))
                {

                    btnAddEmp.Enabled = false;
                    txtEmpRSAID.ForeColor = Color.Red;

                }

            }
            catch (FormatException)
            { }
            catch (InvalidCastException)
            { }
            catch (Exception)
            { }


        }

        private void txtEmpEmail_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtEmpEmail.Text.EndsWith(".com") && txtEmpEmail.Text.Length > 7)
                {
                    txtEmpEmail.ForeColor = DefaultForeColor;
                    if (other.CheckDate(txtEmpRSAID.Text.Substring(0, 6)) && txtEmpID.Text.Length == 10 && txtEmpName.Text != "" && txtEmpSurname.Text != "" && txtEmpRSAID.Text.Length == 13)
                    {


                        if (txtEmpCell.Text.Length == 10 && txtEmpCell.Text.StartsWith("0"))
                        {

                            if (rbTemp.Checked || rbManager.Checked || rbFull.Checked)
                            {

                                if (rbTemp.Checked && dtEnd.Value >= dtStart.Value)
                                    btnAddEmp.Enabled = true;
                                else if (!rbTemp.Checked)
                                    btnAddEmp.Enabled = true;
                                else
                                    btnAddEmp.Enabled = false;

                            }
                            else
                                btnAddEmp.Enabled = false;
                        }

                    }

                    else
                        btnAddEmp.Enabled = false;

                }
                else if (!txtEmpEmail.Text.EndsWith(".com") || txtEmpEmail.Text.Length < 7)
                {
                    txtEmpEmail.ForeColor = Color.Red;
                    btnAddEmp.Enabled = false;
                }
                else
                    btnAddEmp.Enabled = false;
            }
            catch(FormatException)
            { }
            catch(InvalidCastException)
            { }
            catch(Exception)
            { }

        }

        private void txtEmpCell_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtEmpCell.Text.Length == 10 && txtEmpCell.Text.StartsWith("0"))
                {
                    txtEmpCell.ForeColor = DefaultForeColor;
                    if (other.CheckDate(txtEmpRSAID.Text.Substring(0, 6)) && txtEmpID.Text.Length == 10 && txtEmpName.Text != "" && txtEmpSurname.Text != "" && txtEmpRSAID.Text.Length == 13)
                    {


                        if (txtEmpEmail.Text.EndsWith(".com") && txtEmpEmail.Text.Length > 7)
                        {
                            if (rbTemp.Checked || rbManager.Checked || rbFull.Checked)
                            {

                                if (rbTemp.Checked && dtEnd.Value >= dtStart.Value)
                                    btnAddEmp.Enabled = true;
                                else if (!rbTemp.Checked)
                                    btnAddEmp.Enabled = true;
                                else
                                    btnAddEmp.Enabled = false;

                            }
                            else
                                btnAddEmp.Enabled = false;
                        }

                    }

                    else
                        btnAddEmp.Enabled = false;
                }
                else if (txtEmpCell.Text.Length != 10 || !txtEmpCell.Text.StartsWith("0"))
                {
                    txtEmpCell.ForeColor = Color.Red;
                    btnAddEmp.Enabled = false;

                }
                else
                    btnAddEmp.Enabled = false;

            }
            catch (FormatException)
            { }
            catch (InvalidCastException)
            { }
            catch (Exception)
            { }

        }

        private void rbManager_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtEmpID.Text.Length == 10 && txtEmpName.Text != "" && txtEmpSurname.Text != "" && txtEmpRSAID.Text.Length == 13)
                {

                    if (txtEmpCell.Text.Length == 10 && txtEmpEmail.Text.EndsWith(".com") && txtEmpEmail.Text.Length > 7)
                    {

                        if (rbTemp.Checked || rbManager.Checked || rbFull.Checked)
                        {

                            if (rbTemp.Checked && dtEnd.Value >= dtStart.Value)
                                btnAddEmp.Enabled = true;
                            else if (!rbTemp.Checked)
                                btnAddEmp.Enabled = true;
                            else
                                btnAddEmp.Enabled = false;

                        }
                        else
                            btnAddEmp.Enabled = false;

                    }
                    else
                        btnAddEmp.Enabled = false;

                }
                else
                    btnAddEmp.Enabled = false;
            }
            catch(FormatException)
            { }
            catch(InvalidCastException)
            { }
            catch(Exception)
            { }

        }

        private void rbFull_ControlAdded(object sender, ControlEventArgs e)
        {
            try
            {
                if (txtEmpID.Text.Length == 10 && txtEmpName.Text != "" && txtEmpSurname.Text != "" && txtEmpRSAID.Text.Length == 13)
                {

                    if (txtEmpCell.Text.Length == 10 && txtEmpEmail.Text.EndsWith(".com") && txtEmpEmail.Text.Length > 7)
                    {

                        if (rbTemp.Checked || rbManager.Checked || rbFull.Checked)
                        {

                            if (rbTemp.Checked && dtEnd.Value >= dtStart.Value)
                                btnAddEmp.Enabled = true;
                            else if (!rbTemp.Checked)
                                btnAddEmp.Enabled = true;
                            else
                                btnAddEmp.Enabled = false;

                        }
                        else
                            btnAddEmp.Enabled = false;

                    }
                    else
                        btnAddEmp.Enabled = false;

                }
                else
                    btnAddEmp.Enabled = false;
            }
            catch(FormatException)
            { }
            catch(InvalidCastException)
            { }
            catch(Exception)
            { }

        }

        private void cbIsUser_CheckedChanged(object sender, EventArgs e)
        {

            

        }

        private void dtEnd_ValueChanged(object sender, EventArgs e)
        {

            try
            {
                if (txtEmpID.Text.Length == 10 && txtEmpName.Text != "" && txtEmpSurname.Text != "" && txtEmpRSAID.Text.Length == 13)
                {

                    if (other.CheckDate(txtEmpRSAID.Text.Substring(0, 6)) && txtEmpCell.Text.Length == 10 && txtEmpEmail.Text.EndsWith(".com") && txtEmpEmail.Text.Length > 7)
                    {

                        if (rbTemp.Checked || rbManager.Checked || rbFull.Checked)
                        {

                            if (rbTemp.Checked && dtEnd.Value >= dtStart.Value)
                            {
                                dtEnd.CalendarForeColor = DefaultForeColor;
                                btnAddEmp.Enabled = true;
                            }
                            else if (dtEnd.Value < dtStart.Value)
                                dtEnd.CalendarForeColor = Color.Red;
                            else if (!rbTemp.Checked)
                                btnAddEmp.Enabled = true;
                            else
                                btnAddEmp.Enabled = false;

                        }
                        else
                            btnAddEmp.Enabled = false;

                    }
                    else
                        btnAddEmp.Enabled = false;

                }
                else
                    btnAddEmp.Enabled = false;

                if (dtEnd.Value < dtStart.Value)
                {
                    dtEnd.CalendarForeColor = Color.Red;
                    btnAddEmp.Enabled = false;
                }
            }
            catch(FormatException)
            { }
            catch(InvalidCastException)
            { }
            catch(Exception)
            { }

        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            try
            {
                if (dtEnd.Value >= dtStart.Value && rbTemp.Checked)
                {

                    addEmp();

                }
                else if (!rbTemp.Checked)
                {
                    if (branch)
                        updateBranch();
                    addEmp();

                }
                else
                {
                    frmMessages placeHolder = new frmMessages("The end date of employment can not be earlier than the starting date. Please verify the dates and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception)
            { }
        }

        private void addEmp()
        {
            try
            {
                using (SqlConnection con = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                {

                    string cmdstring = "INSERT INTO Employees (branch, employee_id, name, surname, id_num, email_address, cell, is_user, date_appointed, employed_until, is_temp) VALUES (@branch, @emp_id, @name, @surname, @id, @email, @cell, @user, @dateApp, @dateEmp, @temp)";


                    using (SqlCommand comm = new SqlCommand(cmdstring, con))
                    {
                        con.Open();

                        gebruik other = new gebruik();

                        comm.Parameters.AddWithValue("@branch", Properties.Settings.Default.Branch);
                        comm.Parameters.AddWithValue("@emp_id", txtEmpID.Text);
                        comm.Parameters.AddWithValue("@name", txtEmpName.Text);
                        comm.Parameters.AddWithValue("@surname", txtEmpSurname.Text);
                        comm.Parameters.AddWithValue("@id", txtEmpRSAID.Text);
                        comm.Parameters.AddWithValue("@email", txtEmpEmail.Text);
                        comm.Parameters.AddWithValue("@cell", txtEmpCell.Text);
                        comm.Parameters.AddWithValue("@user", cbIsUser.Checked);
                        comm.Parameters.AddWithValue("@dateApp", dtStart.Value);
                        comm.Parameters.AddWithValue("@dateEmp", dtEnd.Value);
                        comm.Parameters.AddWithValue("@temp", rbTemp.Checked);

                        if (other.Mail(txtEmpEmail.Text, "Added as employee", "You have been added as an employee at Matrix Warehouse, " + Properties.Settings.Default.Branch + ".\r\n\r\nYour employee id is: " + txtEmpID.Text + "\r\n\r\nAccording to our system, your starting date is: " + dtStart.Value.ToString().Substring(0, 9) + "\r\n\r\nPlease keep this email for future reference."))
                        {
                            comm.ExecuteNonQuery();

                            gebruik.addAction(user);
                            gebruik.log(DateTime.Now, user, "added employee");
                            updateEmployNum("add");

                            if (cbIsUser.Checked)
                            {

                                if (!branch)
                                {
                                    DialogResult result = MessageBox.Show("The employee's information has successfully been added.\r\n\r\nThe system has detected that this employee will use this system. Would you like to create their account now?", "Info", MessageBoxButtons.YesNo);
                                    if (result == DialogResult.Yes)
                                    {
                                        frmAddUser adU = new frmAddUser(user, txtEmpEmail.Text);

                                        adU.ShowDialog();
                                        this.Close();

                                    }
                                    else
                                    {

                                        DialogResult choice;
                                        choice = MessageBox.Show("The employee's informations has successfully been added..\r\nWould you like to add another employee?", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                                        if (choice == DialogResult.Yes)
                                        {
                                            txtEmpID.Clear();
                                            while (txtEmpID.Text == "")
                                            {
                                                txtEmpID.Text = other.generateLuhn();
                                            }

                                            txtEmpID.Enabled = false;

                                            txtEmpName.Clear();
                                            txtEmpSurname.Clear();
                                            txtEmpRSAID.Clear();

                                            txtEmpEmail.Clear();
                                            txtEmpCell.Clear();

                                            dtStart.Value = DateTime.Now;
                                            dtEnd.Value = DateTime.Now;
                                            rbFull.Checked = true;
                                            cbIsUser.Checked = false;

                                        }
                                        else
                                            this.Close();

                                    }
                                }
                                else
                                {

                                    frmMessages placeHolder = new frmMessages("The employee's information has succesfully been added", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    this.Close();

                                }


                            }
                            else
                            {
                                frmMessages placeHolder = new frmMessages("The employee's information has succesfully been added", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                this.Close();
                            }
                        }
                        else
                        {

                            MessageBox.Show("An error occurred while adding the employee. Please check your internet connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }
                }
            }
            catch (SqlException se)
            {

                if (se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection())
                        addEmp();
                    else
                        MessageBox.Show("It appears that you have lost internet connection. Please verify your internet connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                

            }
            catch(Exception)
            { }

        }

        private void updateEmployNum(string logic)
        {

            try
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
            catch (SqlException se)
            {

                if (se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection())
                        updateEmployNum(logic);
                    else
                        MessageBox.Show("It appears that you have lost internet connection. Please verify your internet connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }             

            }
            catch(Exception)
            { }

        }

        private void updateBranch()
        {
            try
            {
                using (SqlConnection con = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                {

                    con.Open();
                    string cmdstring = "";

                    cmdstring = "UPDATE Branches SET manager_name = @name, manager_email = @mail, manager_cell = @cell WHERE branch_location = @branch";

                    using (SqlCommand comm = new SqlCommand(cmdstring, con))
                    {
                        comm.Parameters.AddWithValue("@name", txtEmpName.Text);
                        comm.Parameters.AddWithValue("@mail", txtEmpEmail.Text);
                        comm.Parameters.AddWithValue("@cell", txtEmpCell.Text);
                        comm.Parameters.AddWithValue("@branch", Properties.Settings.Default.Branch);


                        comm.ExecuteNonQuery();
                    }
                    con.Close();

                }
            }
            catch (SqlException se)
            {

                if (se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection())
                       updateBranch();
                    else
                        MessageBox.Show("It appears that you have lost internet connection. Please verify your internet connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                

            }
            catch(Exception)
            { }

        }

        private void txtEmpRSAID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtEmpCell_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void dtStart_ValueChanged(object sender, EventArgs e)
        {
            dtEnd.MinDate = dtStart.Value;
        }
    }
}
