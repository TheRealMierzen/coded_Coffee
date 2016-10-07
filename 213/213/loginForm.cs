using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;


namespace _213
{
    public partial class loginForm : Form
    {

        public loginForm()
        {
            InitializeComponent();
        }

        private int attempts = 0;
        private string prev;
        private bool firstrun = false;
        private bool promoR;
        private bool promoA;
        private bool valid;

        private void loginForm_Load(object sender, EventArgs e)
        {
            //////////////Maak/Fullscreen////////////////
            /*this.TopMost = true;*/
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            /////////////////////////////////////////////

            TimeSpan TOD = DateTime.Now.TimeOfDay;
            TimeSpan EOD = TimeSpan.Parse("17:00");

            if (TOD < EOD)
                button2.Enabled = false;
            else
                button2.Enabled = true;

            if(DateTime.Now.Month != Properties.Settings.Default.Month)
            {
                
                Properties.Settings.Default.EOM =  EOM();
                Properties.Settings.Default.Month = DateTime.Now.Month;
                Properties.Settings.Default.Save();
                reset();

            }

            gebruik util = new gebruik();
            if (Properties.Settings.Default.Branch == "-")
            {
                //kort backgroundrunner
                
                util.setLocation();
                checkBranch(Properties.Settings.Default.Branch);
                firstrun = true;

            }
            
            if (!checkFile() && util.CheckConnection())
            {

                //Create user and password file
                MessageBox.Show("It appears that this is the first time you're using stockI.T. Please enter this branch's administrative account's details now.", "Info", MessageBoxButtons.OK);
                {

                    textbox1.Enabled = true;
                    txtLPass.Enabled = true;
                    btnCreate.Visible = true;
                    txtLEmail.Visible = true;
                    button2.Enabled = true;            

                }
                

            }
            else if(util.CheckConnection())
            {
                checkPromos();
                

                if (promoA && promoR)
                {

                    notification.Icon = SystemIcons.Information;
                    notification.ShowBalloonTip(100000, "Important Notice", "Some promotions have ended, but there are still others active today.", ToolTipIcon.Info);
                }
                else if(promoA && !promoR)
                {
                    notification.Icon = SystemIcons.Information;
                    notification.ShowBalloonTip(100000, "Important Notice", "There are promotions active today.", ToolTipIcon.Info);

                }
                else if (!promoA && promoR)
                {
                    notification.Icon = SystemIcons.Information;
                    notification.ShowBalloonTip(100000, "Important Notice", "Some promotions have ended.", ToolTipIcon.Info);

                }

                textbox1.Enabled = true;
                txtLPass.Enabled = true;
                button1.Visible = true;
                textbox1.Focus();
  
            }
            else
            {

                txtLEmail.Enabled = false;
                txtLPass.Enabled = false;
                textbox1.Enabled = false;
                button2.Enabled = true;

            }
        }
        
       
        private bool checkFile()
        {
            try
            {
                using (SqlConnection con = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                {
                    string cmdstring = "SELECT COUNT(*) AS CountOfRecords FROM Users WHERE branch = @branch  AND authLevel = 10";

                    using (SqlCommand comm = new SqlCommand(cmdstring, con))
                    {
                        con.Open();
                        comm.Parameters.AddWithValue("@branch", Properties.Settings.Default.Branch);
                        int records = Convert.ToInt32(comm.ExecuteScalar());
                        con.Close();

                        if (records > 0)
                            return true;
                        else
                            return false;
                    }
                }
            }
            catch(SqlException se)
            {

                if (se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection())
                        return checkFile();
                    else
                    {
                        MessageBox.Show("It appears that you have lost internet connection. Please verify your internet connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                    return false;
                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        //Adds a user to the database
        public bool addUser(string username, string pass, string level, string email, string authorize, string authorizePass)
        {
            try
            {
                bgWCreate.ReportProgress(10);

                //Find authorize in file and check level, if level is valid create user
                if (authorize == "admin" && authorizePass == "HUEHUEHUE")
                {
                    //initial account
                    using (SqlConnection con = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                    {
                        string saltyness = BCrypt.Net.BCrypt.GenerateSalt(15);
                        bgWCreate.ReportProgress(35);
                        string hsh = BCrypt.Net.BCrypt.HashPassword(pass, saltyness);

                        gebruik other = new gebruik();
                        //kort Settings.Default.branch
                        con.Open();
                        SqlCommand cAddUser = new SqlCommand("INSERT INTO Users (userName, password, authLevel, salt, numberOfLogins, numberOfActions, email_address, branch) VALUES ('" + username + "','" + hsh + "', 10, '" + saltyness + "', 0, 0, '" + email + "','" + Properties.Settings.Default.Branch + "')", con);
                        cAddUser.ExecuteNonQuery();
                        
                        con.Close();
                        bgWCreate.ReportProgress(85);
                        return true;

                    }

                }
                else
                {
                    //Accounts after intial
                    if (checkUser(username))
                    {
                        //find authority account and validate
                        using (SqlConnection con = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                        {

                            string saltyness = BCrypt.Net.BCrypt.GenerateSalt(15);
                            string hsh = BCrypt.Net.BCrypt.HashPassword(pass, saltyness);

                            con.Open();
                            SqlCommand findAdmin = new SqlCommand("SELECT userName, password, authLevel, salt FROM Users WHERE userName= '" + authorize + "'", con);
                            findAdmin.ExecuteNonQuery();

                            SqlDataReader dr = findAdmin.ExecuteReader();

                            string salt = "";
                            string hPass = "";
                            string user = "";

                            while (dr.Read())
                            {

                                salt = dr.GetString(3);
                                hPass = dr.GetString(1);
                                user = dr.GetString(0);

                            }

                            dr.Close();
                            //Valid authorization account, add new user
                            if (authorize == user && BCrypt.Net.BCrypt.Verify(authorizePass, hPass))
                            {
                                saltyness = BCrypt.Net.BCrypt.GenerateSalt(15);
                                hsh = BCrypt.Net.BCrypt.HashPassword(pass, saltyness);
                                SqlCommand AddUser = new SqlCommand("INSERT INTO Users (userName, password, authLevel, salt, numberOfLogins, numberOfActions, email_address, branch) VALUES ('" + username + "','" + hsh + "'," + level + ", '" + saltyness + "', 0, 0, '" + email + "','" + Properties.Settings.Default.Branch + "')", con);
                                AddUser.ExecuteNonQuery();
                            }

                            btnCreate.Visible = false;
                            button1.Visible = true;
                            con.Close();

                            return true;

                        }

                    }
                    else
                    {
                        MessageBox.Show("The username you entered is already taken. Please try again.", "Error");
                        return false;
                    }

                }
            }
            catch(InvalidCastException)
            { }
            catch(FormatException)
            { }
            catch (SqlException se)
            {

                if (se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection())
                        return addUser(username, pass, level, email, authorize, authorizePass);
                    else
                    { 
                        
                        MessageBox.Show("It appears that you have lost internet connection. Please verify your internet connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                    return false;

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return false;

        }
        


        public bool validateUser(string userName, string pass)
        {

            try
            {
                using (SqlConnection con = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                {
                    bgWLogin.ReportProgress(10);
                    con.Open();
                    SqlCommand cAddUser = new SqlCommand("SELECT userName FROM Users WHERE userName= '" + userName + "' AND branch = '" + Properties.Settings.Default.Branch + "'", con);
                    string user = "";
                    user = (string)cAddUser.ExecuteScalar();

                    bgWLogin.ReportProgress(20);
                    string salt = "";
                    SqlCommand cSalty = new SqlCommand("SELECT salt FROM Users WHERE userName= '" + userName + "'", con);
                    salt = (string)cSalty.ExecuteScalar();

                    bgWLogin.ReportProgress(50);
                    string hPass = "";
                    SqlCommand cPassword = new SqlCommand("SELECT password FROM Users WHERE userName= '" + userName + "'", con);
                    hPass = (string)cPassword.ExecuteScalar();

                    bgWLogin.ReportProgress(65);
                    con.Close();

                    if (userName == user && BCrypt.Net.BCrypt.Verify(pass, hPass))
                    {
                        if (txtLEmail.Visible != true)
                        {
                            bgWLogin.ReportProgress(100);
                            return true;
                        }
                        else

                            return true;
                    }
                    else
                        return false;

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
                        return validateUser(userName, pass);
                    else
                    {
                        MessageBox.Show("It appears that you have lost internet connection. Please verify your internet connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                {
                    MessageBox.Show("Something went wrong");
                    return false;
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return false;
        }


        private void textBox2_Enter(object sender, EventArgs e)
        {
            Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (btnCreate.Visible == true)
                {
                    if (textbox1.Text != "" && txtLPass.Text != "" && txtLEmail.Text != "" && txtLEmail.Text.EndsWith(".com"))
                        btnCreate.Enabled = true;
                    else
                        btnCreate.Enabled = false;
                }
                else
                {
                    if (textbox1.Text != "" && txtLPass.Text != "")
                        button1.Enabled = true;
                    else
                        button1.Enabled = false;
                }
            }
            catch(FormatException)
            { }
            catch(InvalidCastException)
            { }
            catch(Exception)
            { }

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            Text = "";
        }

        //Create user
        private void button3_Click(object sender, EventArgs e)
        {

            try
            {

                textbox1.Enabled = false;
                txtLPass.Enabled = false;
                txtLEmail.Enabled = false;
                btnCreate.Enabled = false;
                button2.Enabled = false;

                bgWCreate.ReportProgress(20);
                loginProgress.Visible = true;
                bgWCreate.RunWorkerAsync();
            }
            catch(FormatException)
            { }
            catch(InvalidCastException)
            { }
            catch(Exception)
            { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                textbox1.Enabled = false;
                txtLPass.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
                loginProgress.Visible = true;
                lblWait.Visible = true;

                Cursor.Current = Cursors.WaitCursor;

                bgWLogin.RunWorkerAsync();
                
               
                
            }
            catch(InvalidCastException)
            { }
            catch(FormatException)
            { }
            catch(Exception)
            { }

        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {

            if(e.KeyCode == Keys.Enter)
                button1.PerformClick();

        }

        //true if username is available
        public bool checkUser(string name)
        {

            try
            {
                using (SqlConnection con = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                {
                    con.Open();

                    SqlCommand cAddUser = new SqlCommand("SELECT COUNT(*) FROM Users WHERE userName= '" + name + "'", con);
                    int recs = (int)cAddUser.ExecuteScalar();
                    con.Close();

                    if (recs == 0)
                        return true;
                    else
                        return false;
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
                        return checkUser(name);
                    else
                    {
                        MessageBox.Show("It appears that you have lost internet connection. Please verify your internet connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }
                else
                    return false;

            }
            catch(Exception)
            { }
            return false;

        }

        private void txtLEmail_Enter(object sender, EventArgs e)
        {
            txtLEmail.Text = "";
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

            try
            {
                textbox1.Text = "";
                if (textbox1.Text != "" && txtLPass.Text != "" && txtLEmail.Text != "")
                    btnCreate.Enabled = true;
                else
                    btnCreate.Enabled = false;
            }
            catch (FormatException)
            { }
            catch (InvalidCastException)
            { }
            catch (Exception)
            { }

        }

        private void btnLForgotPass_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLForgotPass_Click(object sender, EventArgs e)
        {
            try
            {
                this.TopMost = false;
                frmForgotPass fp = new frmForgotPass(prev, this);
                fp.ShowDialog();
            }
            catch(Exception)
            { }
            
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            try
            {
                if (textbox1.Text != "" && txtLPass.Text != "" && txtLEmail.Text != "" && txtLEmail.Text.EndsWith(".com") && txtLEmail.Text.Length > 7)
                    btnCreate.Enabled = true;
                else
                    btnCreate.Enabled = false;
            }
            catch(InvalidCastException)
            { }
            catch(FormatException)
            { }
            catch(Exception)
            { }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {

            try
            {
                if (textbox1.Text != "" && txtLPass.Text != "" && txtLEmail.Text != "" && txtLEmail.Text.EndsWith(".com") && txtLEmail.Text.Length > 7)
                    btnCreate.Enabled = true;
                else
                    btnCreate.Enabled = false;
            }
            catch(InvalidCastException)
            { }
            catch(FormatException)
            { }
            catch(Exception)
            { }
        }

        private void txtLEmail_Leave(object sender, EventArgs e)
        {
            try
            {
                if (textbox1.Text != "" && txtLPass.Text != "" && txtLEmail.Text != "" && txtLEmail.Text.EndsWith(".com") && txtLEmail.Text.Length > 7)
                    btnCreate.Enabled = true;
                else
                    btnCreate.Enabled = false;
            }
            catch(FormatException)
            { }
            catch(InvalidCastException)
            { }
            catch(Exception)
            { }
        }

        private void txtLEmail_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }


        private void checkBranch(string b)
        {
            try
            {
                if (Properties.Settings.Default.Branch.Contains(@"'"))
                {

                    Properties.Settings.Default.Branch = Properties.Settings.Default.Branch.Remove(Properties.Settings.Default.Branch.IndexOf(@"'"), 1);
                    Properties.Settings.Default.Save();



                }
            }
            catch(FormatException)
            { }
            catch(InvalidCastException)
            { }
            catch(Exception)
            { }

        }

        private void checkBranchExist(string b)
        {

            try
            {

                using (SqlConnection con = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                {
                    con.Open();

                    SqlCommand cAddUser = new SqlCommand("SELECT COUNT(*) FROM Branches WHERE branch_location= '" + Properties.Settings.Default.Branch + "'", con);
                    int recs = (int)cAddUser.ExecuteScalar();
                    con.Close();

                    if (recs == 0)
                    {
                        string cmdstring = "INSERT INTO Branches (branch_id, branch_Capacity, current_capacity, branch_location, branch_employeenum, manager_name, manager_email, manager_cell) VALUES (@branch_id, @branch_cap, @branch_cCap, @branch_location, @branch_emp, @manName, @manEmail, @manCell)";
                        using (SqlCommand comm = new SqlCommand(cmdstring, con))
                        {
                            con.Open();
                            gebruik other = new gebruik();
                            string branchid = other.generateLuhn();
                            while (branchid.Length != 10)
                            {

                                branchid = other.generateLuhn();

                            }
                            comm.Parameters.AddWithValue("@branch_id", branchid);
                            comm.Parameters.AddWithValue("@branch_cap", 50000);
                            comm.Parameters.AddWithValue("@branch_cCap", 0);
                            comm.Parameters.AddWithValue("@branch_location", Properties.Settings.Default.Branch);
                            comm.Parameters.AddWithValue("@branch_emp", 0);
                            comm.Parameters.AddWithValue("@manName", "-");
                            comm.Parameters.AddWithValue("@manEmail", txtLEmail.Text);
                            comm.Parameters.AddWithValue("@manCell", "-");

                            comm.ExecuteNonQuery();
                            con.Close();


                        }
                    }
                    bgWLogin.ReportProgress(20);
                }
            }
            catch(InvalidCastException)
            { }
            catch(FormatException)
            { }
            catch (SqlException se)
            {

                if (se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection())
                        checkBranchExist(b);
                    else
                        MessageBox.Show("It appears that you have lost internet connection. Please verify your internet connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void txtLPass_TextChanged(object sender, EventArgs e)
        {

            try
            {
                if (textbox1.Text != "" && txtLPass.Text != "" && txtLPass.TextLength == 8)
                    button1.Enabled = true;
                else
                    button1.Enabled = false;

                int remaining = 8 - txtLPass.TextLength;
                if (lblRemaining.Text.Length == 8)
                    lblRemaining.Text = "";
                else
                    lblRemaining.Text = remaining.ToString() + " remaining";
            }
            catch(FormatException)
            { }
            catch(InvalidCastException)
            { }
            catch(Exception)
            { }
        }

        private void textbox1_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (textbox1.Text != "" && txtLPass.Text != "")
                    button1.Enabled = true;
                else
                    button1.Enabled = false;
            }
            catch(FormatException)
            { }
            catch(InvalidCastException)
            { }
            catch(Exception)
            { }
        }

        private void checkPromos()
        {
            try
            {
                using (SqlConnection conUser = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                {

                    string cmdstring = "SELECT promo_id, start_date, end_date, quantity FROM Promotions WHERE branch = @branch";
                    using (SqlCommand commUser = new SqlCommand(cmdstring, conUser))
                    {
                        conUser.Open();
                        commUser.Parameters.AddWithValue("@branch", Properties.Settings.Default.Branch);
                        using (var reader = commUser.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                string id = reader.GetString(0);
                                DateTime start = reader.GetDateTime(1);
                                DateTime end = reader.GetDateTime(2);
                                int quantity = reader.GetInt32(3);

                                if (quantity == 0 || DateTime.Now > end)
                                    removePromo(id);

                                if (DateTime.Now > start && DateTime.Now < end)
                                    setPromoActive(id);


                            }

                        }

                        conUser.Close();
                    }
                }
            }
            catch(InvalidCastException)
            { }
            catch(FormatException)
            { }
            catch (SqlException se)
            {

                if (se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection())
                        checkPromos();
                    else
                        MessageBox.Show("It appears that you have lost internet connection. Please verify your internet connection and try again.","Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            { }

        }

        private void setPromoActive(string id)
        {
            promoA = true;

            try
            {
                using (SqlConnection conactive = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                {

                    string cmdstring = "UPDATE Promotions SET active = @active WHERE promo_id = @id";
                    using (SqlCommand commActive = new SqlCommand(cmdstring, conactive))
                    {
                        conactive.Open();
                        commActive.Parameters.AddWithValue("@active", 1);
                        commActive.Parameters.AddWithValue("@id", id);

                        commActive.ExecuteNonQuery();

                        conactive.Close();

                        gebruik.log(DateTime.Now, "Promotion " + id, "has been automatically activated");
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
                        setPromoActive(id);
                    else
                        MessageBox.Show("It appears that you have lost internet connection. Please verify your internet connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            { }

        }

        private void removePromo(string id)
        {
            promoR = true;

            try
            {
                using (SqlConnection conRemove = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                {

                    string cmdstring = "DELETE FROM Promotions WHERE promo_id = @id";
                    using (SqlCommand commRemove = new SqlCommand(cmdstring, conRemove))
                    {
                        conRemove.Open();
                        commRemove.Parameters.AddWithValue("@id", id);

                        commRemove.ExecuteNonQuery();

                        conRemove.Close();

                        gebruik.log(DateTime.Now, "Promotion " + id, "has been automatically removed");
                    }
                }
            }
            catch(InvalidCastException)
            { }
            catch(FormatException)
            { }
            catch (SqlException se)
            {

                if (se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection())
                        removePromo(id);
                    else
                        MessageBox.Show("It appears that you have lost internet connection. Please verify your internet connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            { }

        }


        private string EOM()
        {

            try
            {
                using (SqlConnection conEOM = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                {

                    string cmdstring = "SELECT name, surname FROM Employees WHERE email_address = (SELECT TOP 1 email_address FROM Users WHERE branch = @branch ORDER BY (numberOfActions * numberOfLogins))";
                    using (SqlCommand commEOM = new SqlCommand(cmdstring, conEOM))
                    {
                        conEOM.Open();
                        commEOM.Parameters.AddWithValue("@branch", Properties.Settings.Default.Branch);

                        string name = "";
                        string surname = "";
                        using (var reader = commEOM.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                name = reader.GetString(0);
                                surname += reader.GetString(1);


                            }

                        }

                        conEOM.Close();

                        return name + " " + surname;

                    }

                }
            }
            catch(InvalidCastException)
            { }
            catch(FormatException)
            { }
            catch (SqlException se)
            {

                if (se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection())
                        return EOM();
                    else
                        MessageBox.Show("It appears that you have lost internet connection. Please verify your internet connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    return "";

            }
            catch (Exception)
            { }

            return "";
        }
        private void reset()
        {

            try
            {
                using (SqlConnection conRemove = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                {

                    string cmdstring = "UPDATE Users SET numberOfLogins = 0, numberOfActions = 0 WHERE branch = @branch";
                    using (SqlCommand commRemove = new SqlCommand(cmdstring, conRemove))
                    {
                        conRemove.Open();
                        commRemove.Parameters.AddWithValue("@branch", Properties.Settings.Default.Branch);

                        commRemove.ExecuteNonQuery();

                        conRemove.Close();

                        gebruik.log(DateTime.Now, "Employee of the month has been reset", "");
                    }
                }

            }
            catch(InvalidCastException)
            { }
            catch(FormatException)
            { }
            catch (SqlException se)
            {

                if (se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection())
                        reset();
                    else
                        MessageBox.Show("It appears that you have lost internet connection. Please verify your internet connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            { }
        }

        private void txtLEmail_TextChanged_1(object sender, EventArgs e)
        {

            try
            {
                gebruik other = new gebruik();
                if (other.IsValidEmail(txtLEmail.Text) && txtLPass.Text.Length == 8 && textbox1.Text != "")
                    btnCreate.Enabled = true;
                else
                    btnCreate.Enabled = false;
            }
            catch(FormatException)
            { }
            catch(InvalidCastException)
            { }
            catch(Exception)
            { }
        }


        private void bgWlogin_DoWork(object sender, DoWorkEventArgs e)
        {

            BackgroundWorker worker = sender as BackgroundWorker;

            valid = validateUser(textbox1.Text, txtLPass.Text);

        }

        private void bgWlogin_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            loginProgress.Value = e.ProgressPercentage;
        }

        private void bgWlogin_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (valid)
            {
                Form1 f1;
                if (firstrun)
                    f1 = new Form1(textbox1.Text, this, firstrun, txtLEmail.Text);
                else
                    f1 = new Form1(textbox1.Text, this);

                f1.Show();
                DateTime local = DateTime.Now;
                gebruik.log(local, textbox1.Text, "logged in");

                //kort background
                using (SqlConnection conn = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                {

                    conn.Open();
                    SqlCommand uLogin = new SqlCommand("UPDATE Users SET numberOfLogins = numberOfLogins + 1 WHERE userName = '" + textbox1.Text + "'", conn);
                    uLogin.ExecuteNonQuery();
                    conn.Close();

                }

                textbox1.Clear();
                txtLPass.Clear();
                lblWait.Visible = false;
                loginProgress.Value = 0;
                loginProgress.Visible = false;
                textbox1.Enabled = true;
                txtLPass.Enabled = true;
                textbox1.Focus();


            }
            else
            {

                if (prev == textbox1.Text)
                    attempts += 1;
                else
                    attempts = 1;

                if (attempts >= 3)
                    btnLForgotPass.Visible = true;


                prev = textbox1.Text;

                loginProgress.Visible = false;
                MessageBox.Show("The username or password you entered was incorrect", "Error");

                txtLPass.Text = "";
                textbox1.Text = "";
                textbox1.Focus();

            }

            Cursor.Current = Cursors.Default;

        }
        ////////////////////////////////////////////////////////////////////////////////////////////////
        private void bgWCreate_DoWork(object sender, DoWorkEventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            BackgroundWorker worker = sender as BackgroundWorker;
            //loginProgress.Visible = true;
            //lblWait.Visible = true;
            checkBranchExist(Properties.Settings.Default.Branch);

            bool valid = true;
            bool tooShort = false;
            bool adres = false;

            if (!checkUser(textbox1.Text))
            {
                valid = false;

            }

            if (txtLPass.Text.Length != 8)
                tooShort = true;

            gebruik other = new gebruik();
            if (other.IsValidEmail(txtLEmail.Text))
                adres = true;
            bgWCreate.ReportProgress(50);
            if (valid && !tooShort && adres)
            {

                if(addUser(textbox1.Text, txtLPass.Text, "10", txtLEmail.Text, "admin", "HUEHUEHUE"))
                    bgWCreate.ReportProgress(100);

                Cursor.Current = Cursors.Default;
            }
            else if (!valid)
            {
                loginProgress.Visible = false;
                MessageBox.Show("The username you entered is already taken. Please enter another username and try again.", "Error");
            }
            else if (txtLPass.Text.Length < 8)
            {
                loginProgress.Visible = false;
                MessageBox.Show("The entered password is too short. Please choose another password. (Password must be 8 characters in length.)", "Error");

            }
                
            else if (textbox1.Text == "")
            {
                loginProgress.Visible = false;
                MessageBox.Show("It appears that no email address was entered. Please enter one and attempt to create the account again.", "Error");

            }
                
            else
            {
                loginProgress.Visible = false;
                MessageBox.Show("The entered password is too long. Please choose another password. (Password must be 8 characters in length.)", "Error");

            }
                
            

        }

        private void bgWCreate_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            loginProgress.Value = e.ProgressPercentage;
        }

        private void bgWCreate_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            loginProgress.Visible = false;
            button1.Visible = true;
            lblWait.Visible = false;
            btnCreate.Visible = false;
            textbox1.Enabled = true;
            txtLPass.Enabled = true;
            button2.Enabled = true;
            txtLEmail.Enabled = true;
            textbox1.Clear();
            txtLPass.Clear();
            textbox1.Focus();
            txtLEmail.Visible = false;


            MessageBox.Show("The account has succesfully been created.", "Info");

        }

    }
}

