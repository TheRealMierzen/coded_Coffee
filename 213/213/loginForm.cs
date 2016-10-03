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


        private string appPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments));//verander as networking reg is
        private int attempts = 0;
        private string prev;
        private bool firstrun = false;

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

            if (Properties.Settings.Default.Branch == "-")
            {
                //kort backgroundrunner
                gebruik util = new gebruik();
                util.setLocation();
                checkBranch(Properties.Settings.Default.Branch);
                firstrun = true;

            }
            
            if (!checkFile())
            {

                //Create user and password file
                if (MessageBox.Show("It appears that this is the first time you're using stockI.T. Would you like to create an administrative account now?", "Info",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    textbox1.Enabled = true;
                    txtLPass.Enabled = true;
                    btnCreate.Visible = true;
                    txtLEmail.Visible = true;             

                }
                else
                {

                    textbox1.Enabled = false;
                    txtLPass.Enabled = false;
                    txtLEmail.Visible = false;

                }

            }
            else 
            {
                checkPromos();
                textbox1.Enabled = true;
                txtLPass.Enabled = true;
                button1.Visible = true;
                textbox1.Focus();
  
            }
        }
        
       
        private bool checkFile()
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

        private void button2_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        //Adds a user to the database
        public bool addUser(string username, string pass, string level, string email, string authorize, string authorizePass)
        {
            
            //Find authorize in file and check level, if level is valid create user
            if (authorize == "admin" && authorizePass == "HUEHUEHUE")
            {
                //initial account
                using (SqlConnection con = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                {
                    string saltyness = BCrypt.Net.BCrypt.GenerateSalt(15);
                    string hsh = BCrypt.Net.BCrypt.HashPassword(pass, saltyness);

                    gebruik other = new gebruik();
                    //kort Settings.Default.branch
                    con.Open();
                    SqlCommand cAddUser = new SqlCommand("INSERT INTO Users (userName, password, authLevel, salt, numberOfLogins, numberOfActions, email_address, branch) VALUES ('" + username + "','" + hsh + "', 10, '" + saltyness + "', 0, 0, '" + email + "','" + Properties.Settings.Default.Branch + "')", con);
                    cAddUser.ExecuteNonQuery();
                    btnCreate.Visible = false;
                    button1.Visible = true;
                    con.Close();
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
        


        public bool validateUser(string userName, string pass)
        {

            using (SqlConnection con = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
            {

                con.Open();
                SqlCommand cAddUser = new SqlCommand("SELECT userName FROM Users WHERE userName= '" + userName + "' AND branch = '" + Properties.Settings.Default.Branch + "'", con);
                string user = "";
                user = (string) cAddUser.ExecuteScalar();

                string salt = "";
                SqlCommand cSalty = new SqlCommand("SELECT salt FROM Users WHERE userName= '" + userName + "'", con);
                salt = (string) cSalty.ExecuteScalar();

                string hPass = "";
                SqlCommand cPassword = new SqlCommand("SELECT password FROM Users WHERE userName= '" + userName + "'", con);
                hPass = (string) cPassword.ExecuteScalar();

                con.Close();

                if (userName == user && BCrypt.Net.BCrypt.Verify(pass, hPass))
                    return true;
                else
                    return false;
                
            }

        }


        private void textBox2_Enter(object sender, EventArgs e)
        {
            Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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

        private void textBox2_Click(object sender, EventArgs e)
        {
            Text = "";
        }

        //Create user
        private void button3_Click(object sender, EventArgs e)
        {

            checkBranchExist(Properties.Settings.Default.Branch);

            bool valid = true;
            bool tooShort = false;
            bool adres = false;

            for(int c = 0; c < txtLPass.Text.Length; c++)
            {

                if (!checkUser(textbox1.Text))
                {
                    valid = false;
                    
                }

            }

            if (txtLPass.Text.Length != 8)
                tooShort = true;

            if (textbox1.Text != "")
                adres = true;

            if (valid && !tooShort && adres)
            {
                if (addUser(textbox1.Text, txtLPass.Text, "", txtLEmail.Text, "admin", "HUEHUEHUE"))
                {
                    MessageBox.Show("The account has succesfully been created.", "Info");
                    txtLEmail.Visible = false;
                    txtLPass.Clear();
                    txtLPass.Focus();
                }
            }
            else if(!valid)
                MessageBox.Show("The username you entered is already taken. Please enter another username and try again.", "Error");
            else if(txtLPass.Text.Length < 8)
                MessageBox.Show("The entered password is too short. Please choose another password. (Password must be 8 characters in length.)", "Error");
            else if(textbox1.Text == "")
                MessageBox.Show("It appears that no email address was entered. Please enter one and attempt to create the account again.", "Error");
            else
                MessageBox.Show("The entered password is too long. Please choose another password. (Password must be 8 characters in length.)","Error");

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (validateUser(textbox1.Text, txtLPass.Text))
            {

                Form1 f1 = new Form1(textbox1.Text, this, firstrun, txtLEmail.Text);
                f1.Show();

                DateTime local = DateTime.Now;
                gebruik.log(local, textbox1.Text, "logged in");

                using (SqlConnection conn = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                {

                    conn.Open();
                    SqlCommand uLogin = new SqlCommand("UPDATE Users SET numberOfLogins = numberOfLogins + 1 WHERE userName = '" + textbox1.Text + "'", conn);
                    uLogin.ExecuteNonQuery();
                    conn.Close();

                }

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

                MessageBox.Show("The username or password you entered was incorrect", "Error");

                txtLPass.Text = "";
                textbox1.Text = "";
                textbox1.Focus();

            }

        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {

            if(e.KeyCode == Keys.Enter)
                button1.PerformClick();

        }

        //true if username is available
        public bool checkUser(string name)
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

        private void txtLEmail_Enter(object sender, EventArgs e)
        {
            txtLEmail.Text = "";
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textbox1.Text = "";
            if (textbox1.Text != "" && txtLPass.Text != "" && txtLEmail.Text != "")
                btnCreate.Enabled = true;
            else
                btnCreate.Enabled = false;
        }

        private void btnLForgotPass_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void btnLForgotPass_Click(object sender, EventArgs e)
        {
            this.TopMost = false;
            frmForgotPass fp = new frmForgotPass(prev, this);
            fp.ShowDialog();
            
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textbox1.Text != "" && txtLPass.Text != "" && txtLEmail.Text != "" && txtLEmail.Text.EndsWith(".com") && txtLEmail.Text.Length > 7)
                btnCreate.Enabled = true;
            else
                btnCreate.Enabled = false;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textbox1.Text != "" && txtLPass.Text != "" && txtLEmail.Text != "" && txtLEmail.Text.EndsWith(".com") && txtLEmail.Text.Length > 7)
                btnCreate.Enabled = true;
            else
                btnCreate.Enabled = false;
        }

        private void txtLEmail_Leave(object sender, EventArgs e)
        {
            if (textbox1.Text != "" && txtLPass.Text != "" && txtLEmail.Text != "" && txtLEmail.Text.EndsWith(".com") && txtLEmail.Text.Length > 7)
                btnCreate.Enabled = true;
            else
                btnCreate.Enabled = false;
        }

        private void txtLEmail_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }


        private void checkBranch(string b)
        {

            if(Properties.Settings.Default.Branch.Contains(@"'"))
            {
        
                Properties.Settings.Default.Branch = Properties.Settings.Default.Branch.Remove(Properties.Settings.Default.Branch.IndexOf(@"'"), 1);
                Properties.Settings.Default.Save();

                

            }

        }

        private void checkBranchExist(string b)
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
                        while(branchid.Length != 10)
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
            }

        }

        private void txtLPass_TextChanged(object sender, EventArgs e)
        {
            if (textbox1.Text != "" && txtLPass.Text != "")
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        private void textbox1_TextChanged_1(object sender, EventArgs e)
        {
            if (textbox1.Text != "" && txtLPass.Text != "")
                button1.Enabled = true;
            else
                button1.Enabled = false;
        }

        private void checkPromos()
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

        private void setPromoActive(string id)
        {

            using (SqlConnection conactive = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
            {

                string cmdstring = "UPDATE Promotions SET active = @active WHERE promo_id = @id";
                using (SqlCommand commActive = new SqlCommand(cmdstring, conactive))
                {
                    conactive.Open();
                    commActive.Parameters.AddWithValue("@active",1);
                    commActive.Parameters.AddWithValue("@id", id);

                    commActive.ExecuteNonQuery();

                    conactive.Close();

                    gebruik.log(DateTime.Now,id,"has been automatcaly activated");
                }
            }

        }

        private void removePromo(string id)
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

                    gebruik.log(DateTime.Now, id, "has been automatcaly removed");
                }
            }

        }
    }
}

