using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
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

        private bool valid = false;

        private string appPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));//verander as networking reg is

        private void loginForm_Load(object sender, EventArgs e)
        {
            //////////////Maak/Fullscreen////////////////
            //this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            /////////////////////////////////////////////
            
            if(Properties.Settings.Default.Branch == "-")
            {

                gebruik util = new gebruik();
                Properties.Settings.Default.Branch =  util.GetLocation(util.getIP());
                Properties.Settings.Default.Save();

            }

            if (!checkFile())
            {
                //Create user and password file
                if(MessageBox.Show("It appears that this is the first time you're using stockI.T. Would you like to create an administrative account now?", "Info",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    textBox1.Enabled = true;
                    textBox2.Enabled = true;
                    btnCreate.Visible = true;                  

                }
                else
                {

                    textBox1.Enabled = false;
                    textBox2.Enabled = false;

                }

            }
            else
            {
                
                    textBox1.Enabled = true;
                    textBox2.Enabled = true;
                    button1.Visible = true;
  
            }
        }
        
       
        private bool checkFile()
        {

            using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True"))
            {
                con.Open();
                SqlCommand checkFirst = new SqlCommand("SELECT COUNT(*) AS CountOfRecords FROM Users",con);
                int records = Convert.ToInt32(checkFirst.ExecuteScalar());

                con.Close();
                if (records > 0)
                    return true;
                else
                    return false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        //Adds a user to the file
        public void addUser(string username, string pass, string level, string authorize, string authorizePass)
        {
            
            //Find authorize in file and check level, if level is valid create user
            if (authorize == "admin" && authorizePass == "HUEHUEHUE")
            {

                bgWCreate.ReportProgress(10);
                lblWait.Text = "Creating account...";
                //initial account
                using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True"))
                {
                    string saltyness = BCrypt.Net.BCrypt.GenerateSalt(15);
                    bgWCreate.ReportProgress(35);
                    lblWait.Text = "Creating account...";
                    string hsh = BCrypt.Net.BCrypt.HashPassword(pass, saltyness);

                    con.Open();
                    SqlCommand cAddUser = new SqlCommand("INSERT INTO Users (userName, password, authLevel, salt, numberOfLogins, numberOfActions) VALUES ('" + username + "','" + hsh + "', 10, '" + saltyness + "', 0, 0)", con);
                    cAddUser.ExecuteNonQuery();

                    btnCreate.Visible = false;
                    button1.Visible = true;
                    con.Close();
                    

                }

            }
            else
            {
                //Accounts after intial
                if (checkUser(username))
                {
                    //find authority account and validate
                    using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True"))
                    {

                        string saltyness = BCrypt.Net.BCrypt.GenerateSalt(15);
                        string hsh = BCrypt.Net.BCrypt.HashPassword(pass, saltyness);

                        bgWCreate.ReportProgress(65);
                        lblWait.Text = "Creating account...";

                        con.Open();
                        SqlCommand findAdmin = new SqlCommand("SELECT userName, password, authLevel, salt FROM Users WHERE userName= '" + authorize + "'", con);
                        findAdmin.ExecuteNonQuery();
                        //string user = Convert.ToString(cAddUser.ExecuteScalar());

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

                        bgWCreate.ReportProgress(80);
                        lblWait.Text = "Creating account...";

                        //Valid authorization account, add new user
                        if (authorize == user && BCrypt.Net.BCrypt.Verify(authorizePass, hPass))
                        {
                            saltyness = BCrypt.Net.BCrypt.GenerateSalt(15);
                            hsh = BCrypt.Net.BCrypt.HashPassword(pass, saltyness);
                            SqlCommand AddUser = new SqlCommand("INSERT INTO Users (userName, password, authLevel, salt, numberOfLogins, numberOfActions) VALUES ('" + username + "','" + hsh + "'," + level + ", '" + saltyness + "', 0, 0)", con);
                            AddUser.ExecuteNonQuery();
                        }

                        btnCreate.Visible = false;
                        button1.Visible = true;
                        con.Close();

                        bgWCreate.ReportProgress(100);

                    }

                }
                else
                    MessageBox.Show("The username you entered is already taken. Please try again.","Error");

            }
            
        }
        


        private bool validateUser(string userName, string pass)
        {

            using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True"))
            {
                bgWLogin.ReportProgress(10);
                con.Open();
                SqlCommand cAddUser = new SqlCommand("SELECT userName FROM Users WHERE userName= '" + userName + "'", con);
                string user = "";
                user = (string) cAddUser.ExecuteScalar();

                bgWLogin.ReportProgress(20);
                string salt = "";
                SqlCommand cSalty = new SqlCommand("SELECT salt FROM Users WHERE userName= '" + userName + "'", con);
                salt = (string) cSalty.ExecuteScalar();

                bgWLogin.ReportProgress(50);
                string hPass = "";
                SqlCommand cPassword = new SqlCommand("SELECT password FROM Users WHERE userName= '" + userName + "'", con);
                hPass = (string) cPassword.ExecuteScalar();

                bgWLogin.ReportProgress(65);
                con.Close();


                if (userName == user && BCrypt.Net.BCrypt.Verify(pass, hPass))
                {
                    bgWLogin.ReportProgress(100);
                    return true;
                }
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
            //textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(CheckKeys);

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            Text = "";
        }

        //Create user
        private void button3_Click(object sender, EventArgs e)
        {
            
            bool valid = true;
            bool tooShort = false;

            for(int c = 0; c < textBox2.Text.Length; c++)
            {

                if (textBox2.Text[c] == ',' || textBox2.Text[c] == '#')
                    valid = false;

            }

            if (textBox2.Text.Length != 8)
                tooShort = true;

            if (valid && !tooShort)
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                button2.Enabled = false;
                loginProgress.Visible = true;
                lblWait.Visible = true;
                
                bgWCreate.RunWorkerAsync();
                
            }
            else if(!valid)
                MessageBox.Show("The entered password contains an illegal character. Please choose another password. (Password may not contain a ',' or a '#')", "Error");
            else if(textBox2.Text.Length < 8)
                MessageBox.Show("The entered password is too short. Please choose another password. (Password must be 8 characters in length.)", "Error");
            else
                MessageBox.Show("The entered password is too long. Please choose another password. (Password must be 8 characters in length.)","Error");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            button2.Enabled = false;
            loginProgress.Visible = true;
            lblWait.Visible = true;

            bgWLogin.RunWorkerAsync();

            

        }


        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {

            if(e.KeyCode == Keys.Enter)
                button1.PerformClick();

        }

        //true if username is available
        private bool checkUser(string name)
        {

            using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True"))
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

        private void bgWlogin_DoWork(object sender, DoWorkEventArgs e)
        {

            BackgroundWorker worker = sender as BackgroundWorker;

            valid = validateUser(textBox1.Text, textBox2.Text);
            
        }

        private void bgWlogin_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            loginProgress.Value = e.ProgressPercentage;
        }

        private void bgWlogin_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (valid)
            {

                Form1 f1 = new Form1(textBox1.Text);
                f1.Show();
                DateTime local = DateTime.Now;
                gebruik.log(local, textBox1.Text, "login", appPath + @"\stockI.T" + @"\Activity Log.txt");

                using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True"))
                {

                    conn.Open();
                    SqlCommand uLogin = new SqlCommand("UPDATE Users SET numberOfLogins = numberOfLogins + 1 WHERE userName = '" + textBox1.Text + "'", conn);
                    uLogin.ExecuteNonQuery();
                    conn.Close();

                }

                MessageBox.Show("Welcome " + textBox1.Text);

            }
            else
                MessageBox.Show("The username or password you entered was incorrect", "Error");
        }

////////////////////////////////////////////////////////////////////////////////////////////////
        private void bgWCreate_DoWork(object sender, DoWorkEventArgs e)
        {

            BackgroundWorker worker = sender as BackgroundWorker;
            //loginProgress.Visible = true;
            //lblWait.Visible = true;

            addUser(textBox1.Text, textBox2.Text, "10", "admin", "HUEHUEHUE");

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
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            button2.Enabled = true;
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();

            
            MessageBox.Show("The account has succesfully been created.", "Info");

        }
////////////////////////////////////////////////////////////////////////////////////////////////
    }

}

