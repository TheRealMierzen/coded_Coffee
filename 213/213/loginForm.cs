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


        private string appPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));//verander as networking reg is

        private void loginForm_Load(object sender, EventArgs e)
        {
            //////////////Maak/Fullscreen////////////////
            /*this.TopMost = true;*/
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            /////////////////////////////////////////////
            

            if (!checkFile())
            {
                //Create user and password file
                if(MessageBox.Show("It appears that this is the first time you're using stockI.T. Would you like to create an administrative account now?", "Info",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    textBox1.Enabled = true;
                    textBox2.Enabled = true;
                    btnCreate.Visible = true;
                    txtLEmail.Visible = true;             

                }
                else
                {

                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    txtLEmail.Visible = false;

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
        public bool addUser(string username, string pass, string level, string email, string authorize, string authorizePass)
        {

            //Find authorize in file and check level, if level is valid create user
            if (authorize == "admin" && authorizePass == "HUEHUEHUE")
            {
                //initial account
                using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True"))
                {
                    string saltyness = BCrypt.Net.BCrypt.GenerateSalt(15);
                    string hsh = BCrypt.Net.BCrypt.HashPassword(pass, saltyness);

                    gebruik other = new gebruik();
                    //kort Settings.Default.branch
                    con.Open();
                    SqlCommand cAddUser = new SqlCommand("INSERT INTO Users (userName, password, authLevel, salt, numberOfLogins, numberOfActions, email_address) VALUES ('" + username + "','" + hsh + "', 10, '" + saltyness + "', 0, 0, '" + email + "')", con);
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
                    using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True"))
                    {

                        string saltyness = BCrypt.Net.BCrypt.GenerateSalt(15);
                        string hsh = BCrypt.Net.BCrypt.HashPassword(pass, saltyness);

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
                        //Valid authorization account, add new user
                        if (authorize == user && BCrypt.Net.BCrypt.Verify(authorizePass, hPass))
                        {
                            saltyness = BCrypt.Net.BCrypt.GenerateSalt(15);
                            hsh = BCrypt.Net.BCrypt.HashPassword(pass, saltyness);
                            SqlCommand AddUser = new SqlCommand("INSERT INTO Users (userName, password, authLevel, salt, numberOfLogins, numberOfActions, email_address, branch) VALUES ('" + username + "','" + hsh + "'," + level + ", '" + saltyness + "', 0, 0, '" + email + "','" + "-" + "')", con);
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

            using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True"))
            {

                con.Open();
                SqlCommand cAddUser = new SqlCommand("SELECT userName FROM Users WHERE userName= '" + userName + "'", con);
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
            bool adres = false;

            for(int c = 0; c < textBox2.Text.Length; c++)
            {

                if (textBox2.Text[c] == ',' || textBox2.Text[c] == '#')
                    valid = false;

            }

            if (textBox2.Text.Length != 8)
                tooShort = true;

            if (textBox1.Text != "")
                adres = true;

            if (valid && !tooShort && adres)
            {
                if(addUser(textBox1.Text, textBox2.Text, "", "10", "admin", "HUEHUEHUE"))
                    MessageBox.Show("The account has succesfully been created.", "Info");
            }
            else if(!valid)
                MessageBox.Show("The entered password contains an illegal character. Please choose another password. (Password may not contain a ',' or a '#')", "Error");
            else if(textBox2.Text.Length < 8)
                MessageBox.Show("The entered password is too short. Please choose another password. (Password must be 8 characters in length.)", "Error");
            else if(textBox1.Text == "")
                MessageBox.Show("It appears that no email address was entered. Please enter one and attempt to create the account again.", "Error");
            else
                MessageBox.Show("The entered password is too long. Please choose another password. (Password must be 8 characters in length.)","Error");

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (validateUser(textBox1.Text, textBox2.Text))
            {
                
                Form1 f1 = new Form1(textBox1.Text,this);
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

        private void txtLEmail_Enter(object sender, EventArgs e)
        {
            txtLEmail.Text = "";
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}

