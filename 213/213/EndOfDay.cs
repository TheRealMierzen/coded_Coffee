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
using Nemiro.OAuth;
using Nemiro.OAuth.LoginForms;
using System.IO;
using System.Web;

namespace _213
{
    public partial class EndOfDay : Form
    {
        string myFile;
        private string CurrentPath = "/";
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True");
        public EndOfDay()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string cmd1 = "SELECT * FROM Orders";
            using (SqlCommand comm1 = new SqlCommand(cmd1, con))
            {
                comm1.Parameters.AddWithValue("Orders", cmd1);

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = comm1;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                BindingSource bs = new BindingSource();

                bs.DataSource = dt;

                dataGridView1.DataSource = bs;
                sda.Update(dt);

            }


            //con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string cmd2 = "SELECT * FROM Sales";
            using (SqlCommand comm2 = new SqlCommand(cmd2, con))
            {
                comm2.Parameters.AddWithValue("Sales", cmd2);

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = comm2;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                BindingSource bs = new BindingSource();

                bs.DataSource = dt;

                dataGridView1.DataSource = bs;
                sda.Update(dt);

            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable("Stock");
            string cmd3 = "SELECT * FROM Stock";
            using (SqlCommand comm3 = new SqlCommand(cmd3, con))
            {

                comm3.Parameters.AddWithValue("Stock", cmd3);

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = comm3;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                BindingSource bs = new BindingSource();

                bs.DataSource = dt;

                dataGridView1.DataSource = bs;
                sda.Update(dt);

            }

            con.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {

            string cmd4 = "SELECT * FROM Transfers";
            using (SqlCommand comm4 = new SqlCommand(cmd4, con))
            {
                comm4.Parameters.AddWithValue("Transfers", cmd4);

                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = comm4;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                BindingSource bs = new BindingSource();

                bs.DataSource = dt;

                dataGridView1.DataSource = bs;
                sda.Update(dt);
            }


        }

        private void EndOfDay_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

        }

        private void button5_Click(object sender, EventArgs e)
        {

            string ordr = "SELECT COUNT(*) FROM Orders";
            using (SqlCommand comm4 = new SqlCommand(ordr, con))
            {
                comm4.Parameters.AddWithValue("Transfers", ordr);
                con.Open();
                object count = comm4.ExecuteScalar();


                /*SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = comm4;
                DataTable dt = new DataTable();
                sda.Fill(dt);
                BindingSource bs = new BindingSource();

                bs.DataSource = dt;

                dataGridView1.DataSource = bs;
                sda.Update(dt);*/

                //Orders

                textBox1.AppendText("ORDERS REPORT\r\n");
                textBox1.AppendText("******************************\r\n");
                textBox1.AppendText("******************************\r\n");
                textBox1.AppendText("Total Orders Placed: " + count.ToString() + "\r\n");

                con.Close();
            }

            string sale = "SELECT COUNT(*) FROM Sales";
            using (SqlCommand com1 = new SqlCommand(sale, con))
            {
                com1.Parameters.AddWithValue("Sales", sale);
                con.Open();
                object count1 = com1.ExecuteScalar();
                //Sales
                textBox1.AppendText("\r\n");
                textBox1.AppendText("SALES REPORT\r\n");
                textBox1.AppendText("******************************\r\n");
                textBox1.AppendText("******************************\r\n");

                textBox1.AppendText("Total Sales Made: " + count1.ToString() + "\r\n");
                con.Close();
            }

            string stck = "SELECT COUNT(*) FROM Stock";
            using (SqlCommand com1 = new SqlCommand(stck, con))
            {
                com1.Parameters.AddWithValue("Stock", stck);
                con.Open();
                object count2 = com1.ExecuteScalar();
                //Stock
                textBox1.AppendText("\r\n");
                textBox1.AppendText("STOCK REPORT\r\n");
                textBox1.AppendText("******************************\r\n");
                textBox1.AppendText("******************************\r\n");

                textBox1.AppendText("Total Stock Reduced: " + count2.ToString() + "\r\n");
                con.Close();
            }

            string trns = "SELECT COUNT(*) FROM Transfers";
            using (SqlCommand com1 = new SqlCommand(trns, con))
            {
                com1.Parameters.AddWithValue("Transfers", trns);
                con.Open();
                object count3 = com1.ExecuteScalar();
                //Transfers
                textBox1.AppendText("\r\n");
                textBox1.AppendText("TRANSFERS REPORT\r\n");
                textBox1.AppendText("******************************\r\n");
                textBox1.AppendText("******************************\r\n");

                textBox1.AppendText("Total transfers: " + count3.ToString() + "\r\n");

                textBox1.AppendText("If you want to view more about the transfers click on the 'Transfers Report'!!");

                con.Close();
            }



        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();


        }

        private void button7_Click(object sender, EventArgs e)//exit button
        {
            //MessageBox.Show("Remember to Log Out!!!!!!!!");
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)//Save report
        {
            StreamWriter outstream;
            saveFileDialog1.InitialDirectory = @"c:\";
            myFile = textBox2.Text + ".txt";
            saveFileDialog1.FileName = myFile;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                myFile = saveFileDialog1.FileName;
                outstream = File.CreateText(myFile);
                outstream.Write(textBox1.Text);
                outstream.Close();

            }  

        }

        private void button10_Click(object sender, EventArgs e)
        {
           
            //Sign in and open connection
            if(String.IsNullOrEmpty(Properties.Settings.Default.AccessToken))
            {
                this.GetAccessToken();
            }
            else
            {
                this.GetFile();
            }
           
        }

        private void GetAccessToken()
        {
            var login = new DropboxLogin("nyz292wqqjd3xel", "ijcymtkwx3cxs7o");
            login.Owner = this;
            login.ShowDialog();

            if(login.IsSuccessfully)
            {
                Properties.Settings.Default.AccessToken = login.AccessToken.Value;
                Properties.Settings.Default.Save();
            }
            else
            {
                MessageBox.Show("error....");
            }
        }

        private void GetFile()
        {
            OAuthUtility.GetAsync
            (
                "https://api.dropboxapi.com/1/metadata/auto/",
                new HttpParameterCollection
                {
                    { "path", this.CurrentPath},
                    { "access_token", Properties.Settings.Default.AccessToken},
                },
                callback: GetFile_Result
            );
        }
     
        private void GetFile_Result(RequestResult result)
        {
            if(this.InvokeRequired)
            {
                this.Invoke(new Action<RequestResult>(GetFile_Result), result);
                return;
            }

            if(result.StatusCode == 200)
            {
                //listBox1.Items.Clear();

                foreach(UniValue file in result["contents"])
                {
                    listBox1.Items.Add(file["path"]);
                }

                if (this.CurrentPath != "/")
                {
                    listBox1.Items.Insert(0, "..");
                }
            }
            else
            {
                MessageBox.Show("eror");
            }
        }

        private void button9_Click(object sender, EventArgs e)//upload files
        {
           if(openFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
           {
               return;
           }


           OAuthUtility.PutAsync
           (
                "https://content.dropboxapi.com/1/files_put/auto/<path>?param=val",
                    new HttpParameterCollection
                    {
                        {"access_token", Properties.Settings.Default.AccessToken},
                        {"path", Path.Combine(this.CurrentPath, Path.GetFileName(openFileDialog1.FileName)).Replace("\\", "/")},
                        {"overwrite", "true"},
                        {"autorename", "true"},
                        {openFileDialog1.OpenFile()}
                    },
                    callback: Upload_Result
           );
        }

        private void Upload_Result(RequestResult result)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action<RequestResult>(Upload_Result), result);
                return;
            }

            if (result.StatusCode == 200)
            {
                this.GetFile();
            }
            else
            {
                MessageBox.Show("eror");
            }
        }

        

        private void button11_Click(object sender, EventArgs e)//new folder
        {
            OAuthUtility.PostAsync
               (
                   "https://api.dropboxapi.com/1/fileops/create_folder",
                   new HttpParameterCollection
                    {
                        {"access_token", Properties.Settings.Default.AccessToken},
                        {"root", "auto"},
                        {"path", Path.Combine(this.CurrentPath, textBox3.Text).Replace("\\", "/")}
                    },
                   callback: CreateFolder_Result
               );
            MessageBox.Show("Folder "+ textBox3.Text +" was created");
        }


        private void CreateFolder_Result(RequestResult result)
        {

            if (this.InvokeRequired)
            {
                this.Invoke(new Action<RequestResult>(CreateFolder_Result), result);
                return;
            }

            if (result.StatusCode == 200)
            {
                this.GetFile();
            }
            else
            {
                MessageBox.Show("eror");
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem.ToString() == "..")
            {
                if (this.CurrentPath != "/")
                {
                    this.CurrentPath = Path.GetDirectoryName(this.CurrentPath).Replace("\\", "/");
                }
            }
            else
            {
                this.CurrentPath = listBox1.SelectedItem.ToString();
            }
            this.GetFile();
        }
        
        //this an address to send requests
        //this a method to get a list of files and folders
        //
    




        

        


    }



}