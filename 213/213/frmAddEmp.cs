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

        string user;

        private void frmAddEmp_Load(object sender, EventArgs e)
        {
            gebruik other = new gebruik();

            dtStart.MinDate = DateTime.Now;
            dtEnd.MinDate = DateTime.Now;

            //txtEmpID.Text = other.getLastIdentity + 1;
            txtEmpID.Enabled = false;
        }

        private void rbTemp_CheckedChanged(object sender, EventArgs e)
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

        private void btnCancelEmp_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtEmpID_TextChanged(object sender, EventArgs e)
        {

            if (txtEmpID.Text.Length == 10)
            {
                txtEmpID.ForeColor = DefaultForeColor;
                if (txtEmpName.Text != "" && txtEmpSurname.Text != "" && txtEmpRSAID.Text.Length == 13)
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

            long empID;
            try
            {
                empID = Convert.ToInt64(txtEmpID.Text);

            }
            catch
            {

                txtEmpID.Text = "";

            }

        }

        private void txtEmpName_TextChanged(object sender, EventArgs e)
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

        private void txtEmpSurname_TextChanged(object sender, EventArgs e)
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

        private void txtEmpRSAID_TextChanged(object sender, EventArgs e)
        {

            if (txtEmpRSAID.Text.Length == 13)
            {

                txtEmpRSAID.ForeColor = DefaultForeColor;
                if (txtEmpID.Text.Length == 10 && txtEmpName.Text != "" && txtEmpSurname.Text != "")
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

            }
            else if (txtEmpRSAID.Text.Length != 13)
            {
                txtEmpRSAID.ForeColor = Color.Red;
                btnAddEmp.Enabled = false;
            }
            else
                btnAddEmp.Enabled = false;


            long empID;
            try
            {
                empID = Convert.ToInt64(txtEmpRSAID.Text);

            }
            catch
            {
                try
                {
                    txtEmpRSAID.Text = txtEmpRSAID.Text.Substring(0, txtEmpRSAID.Text.Length - 1);
                    txtEmpRSAID.Focus();
                    txtEmpRSAID.SelectionStart = txtEmpRSAID.Text.Length;
                }
                catch
                {

                    txtEmpRSAID.Text = "";

                }

            }

        }

        private void txtEmpEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmpEmail.Text.EndsWith(".com") && txtEmpEmail.Text.Length > 7)
            {
                txtEmpEmail.ForeColor = DefaultForeColor;
                if (txtEmpID.Text.Length == 10 && txtEmpName.Text != "" && txtEmpSurname.Text != "" && txtEmpRSAID.Text.Length == 13)
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

        private void txtEmpCell_TextChanged(object sender, EventArgs e)
        {
            if (txtEmpCell.Text.Length == 10 && txtEmpCell.Text.StartsWith("0"))
            {
                txtEmpCell.ForeColor = DefaultForeColor;
                if (txtEmpID.Text.Length == 10 && txtEmpName.Text != "" && txtEmpSurname.Text != "" && txtEmpRSAID.Text.Length == 13)
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


            long cell;
            try
            {
                cell = Convert.ToInt64(txtEmpCell.Text);

            }
            catch
            {

                try
                {
                    txtEmpCell.Text = txtEmpCell.Text.Substring(0, txtEmpCell.Text.Length - 1);
                    txtEmpCell.Focus();
                    txtEmpCell.SelectionStart = txtEmpCell.Text.Length;
                }
                catch
                {

                    txtEmpCell.Text = "";

                }

            }

        }

        private void rbManager_TextChanged(object sender, EventArgs e)
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

        private void rbFull_ControlAdded(object sender, ControlEventArgs e)
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

        private void cbIsUser_CheckedChanged(object sender, EventArgs e)
        {

            

        }

        private void dtEnd_ValueChanged(object sender, EventArgs e)
        {

            if (txtEmpID.Text.Length == 10 && txtEmpName.Text != "" && txtEmpSurname.Text != "" && txtEmpRSAID.Text.Length == 13)
            {

                if (txtEmpCell.Text.Length == 10 && txtEmpEmail.Text.EndsWith(".com") && txtEmpEmail.Text.Length > 7)
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

        private void btnAddEmp_Click(object sender, EventArgs e)
        {

            if (dtEnd.Value >= dtStart.Value && rbTemp.Checked)
            {

                addEmp();
                
            }
            else if(!rbTemp.Checked)
            {

                addEmp();

            }
            else
                MessageBox.Show("The end date of employment can not be earlier than the starting date. Please verify the dates and try again.");

        }

        private void addEmp()
        {

            using (SqlConnection con = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
            {
                string cmdstring = "INSERT INTO Employees (branch, employee_id, name, surname, id_num, email_address, cell, is_user, date_appointed, employed_until, is_temp) VALUES (@branch, @emp_id, @name, @surname, @id, @email, @cell, @user, @dateApp, @dateEmp, @temp)";
                using (SqlCommand comm = new SqlCommand(cmdstring, con))
                {
                    con.Open();

                    gebruik other = new gebruik();
                    
                    comm.Parameters.AddWithValue("@branch", Properties.Settings.Default.Branch);
                    comm.Parameters.AddWithValue("@emp_id", txtEmpID.Text); //kort other.lastIdentity + 1;
                    comm.Parameters.AddWithValue("@name", txtEmpName.Text);
                    comm.Parameters.AddWithValue("@surname", txtEmpSurname.Text);
                    comm.Parameters.AddWithValue("@id", txtEmpRSAID.Text);
                    comm.Parameters.AddWithValue("@email", txtEmpEmail.Text);
                    comm.Parameters.AddWithValue("@cell", txtEmpCell.Text);
                    comm.Parameters.AddWithValue("@user", cbIsUser.Checked);
                    comm.Parameters.AddWithValue("@dateApp", dtStart.Value);
                    comm.Parameters.AddWithValue("@dateEmp", dtEnd.Value);
                    comm.Parameters.AddWithValue("@temp", rbTemp.Checked);

                    comm.ExecuteNonQuery();

                    gebruik.addAction(user);
                    gebruik.log(DateTime.Now, user, "added employee");
                    updateEmployNum("add");

                    if (cbIsUser.Checked)
                    {

                        DialogResult result =  MessageBox.Show("The employee has successfully been added.\r\n\r\nThe system has detected that this employee will use this system. Would you like to create their account now?", "Info", MessageBoxButtons.YesNo);
                        if (result == DialogResult.Yes)
                        {
                            frmAddUser adU = new frmAddUser(user, txtEmpEmail.Text);

                            adU.ShowDialog();
                            this.Close();

                        }
                        else
                        {
                            MessageBox.Show("The employee has succesfully been added");
                            
                            this.Close();
                        }

                    }

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
