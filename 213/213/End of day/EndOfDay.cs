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
        SqlConnection con = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT");
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
            myFile = textBox2.Text + ".doc";
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
                MessageBox.Show("error with obtaining the AccessToken from DropBox. "+ "\r\n"+" Check APP key and security.");
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
                MessageBox.Show("Error with retrieving the file."+"\r\n" +"Check if there are contents and if path is still good");
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
                MessageBox.Show("Error with upload. Check Paths and Parameters");
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
                MessageBox.Show("Error with Creating a folder");
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

        private void button15_Click(object sender, EventArgs e)//Transfers Summary
        {
            

            
            string trns = "SELECT COUNT(*) FROM Transfers";
            using (SqlCommand com1 = new SqlCommand(trns, con))
            {
                com1.Parameters.AddWithValue("Transfers", trns);
                con.Open();
                object count = com1.ExecuteScalar();

                //
                string trn1 = "SELECT transfer_id FROM Transfers";
                using (SqlCommand comm4 = new SqlCommand(trn1, con))
                {
                    comm4.Parameters.AddWithValue("Transfers", trn1);

                    

                    object count1 = comm4.ExecuteScalar();


                    //from branch
                    string trn2 = "SELECT from_branch FROM Transfers";
                    using (SqlCommand co1 = new SqlCommand(trn2, con))
                    {
                        co1.Parameters.AddWithValue("Transfers", trn2);

                        

                        object count2 = co1.ExecuteScalar();

                        //To Branch
                        string trn3 = "SELECT to_branch FROM Transfers";
                        using (SqlCommand co2 = new SqlCommand(trn3, con))
                        {
                            co2.Parameters.AddWithValue("Transfers", trn3);

                            

                            object count3 = co2.ExecuteScalar();

                            //item ids
                            string trn4 = "SELECT item_ids FROM Transfers";
                            using (SqlCommand co3 = new SqlCommand(trn4, con))
                            {
                                co3.Parameters.AddWithValue("Transfers", trn4);

                              

                                object count4 = co1.ExecuteScalar();

                                //send date
                                string trn5 = "SELECT send_date FROM Transfers";
                                using (SqlCommand co4 = new SqlCommand(trn5, con))
                                {
                                    co4.Parameters.AddWithValue("Transfers", trn5);

                                    

                                    object count5 = co1.ExecuteScalar();

                                    //eta
                                    string trn6 = "SELECT eta FROM Transfers";
                                    using (SqlCommand co5 = new SqlCommand(trn6, con))
                                    {
                                        co5.Parameters.AddWithValue("Transfers", trn6);

                                        

                                        object count6 = co1.ExecuteScalar();



                                        if (count.Equals(0))
                                        {
                                            MessageBox.Show("There are no Transfers");
                                        }
                                        else
                                        {
                                            for (int i = 0; i <= Convert.ToInt32(count); i++)
                                            {
                                                textBox1.AppendText("TRANSFERS REPORT(INDIVIDUAL)" + "\r\n" + "**********************");
                                                textBox1.AppendText("Transfer ID: " + count1 + "\r\n");
                                                textBox1.AppendText("Transfer From Branch: " + count2 + "\r\n");
                                                textBox1.AppendText("Transfer To Branch: " + count3 + "\r\n");
                                                textBox1.AppendText("Transfer Items ID: " + count4 + "\r\n");
                                                textBox1.AppendText("Transfer Send Date: " + count5 + "\r\n");
                                                textBox1.AppendText("Transfer Estimated Time of Arrival: " + count6 + "\r\n");
                                            }
                                        }


                                    }
                                }
                            }
                        }
                    }
                }
            }
            
            con.Close();
            //transfer_id, from_branch, to_branch, item_ids, send_date, eta
           
        }

        private void button14_Click(object sender, EventArgs e)//Stock Summary
        {
           
            string stk = "SELECT COUNT(*) FROM Stock";
            using (SqlCommand com1 = new SqlCommand(stk, con))
            {
                com1.Parameters.AddWithValue("Transfers", stk);
                con.Open();
                object count = com1.ExecuteScalar();

                //item id
                string stk1 = "SELECT item_id FROM Stock";
                using (SqlCommand comm4 = new SqlCommand(stk1, con))
                {
                    comm4.Parameters.AddWithValue("Transfers", stk1);



                    object count1 = comm4.ExecuteScalar();


                    //manufacturer
                    string stk2 = "SELECT manufacturer FROM Stock";
                    using (SqlCommand co1 = new SqlCommand(stk2, con))
                    {
                        co1.Parameters.AddWithValue("Transfers", stk2);



                        object count2 = co1.ExecuteScalar();

                        //Warranty
                        string stk3 = "SELECT warranty FROM Stock";
                        using (SqlCommand co2 = new SqlCommand(stk3, con))
                        {
                            co2.Parameters.AddWithValue("Transfers", stk3);



                            object count3 = co2.ExecuteScalar();

                            //Retail Price
                            string stk4 = "SELECT retail_price FROM Stock";
                            using (SqlCommand co3 = new SqlCommand(stk4, con))
                            {
                                co3.Parameters.AddWithValue("Transfers", stk4);



                                object count4 = co3.ExecuteScalar();

                                //item type
                                string stk5 = "SELECT item_type FROM Stock";
                                using (SqlCommand co4 = new SqlCommand(stk5, con))
                                {
                                    co4.Parameters.AddWithValue("Transfers", stk5);



                                    object count5 = co4.ExecuteScalar();

                                    //status
                                    string stk6 = "SELECT status FROM Stock";
                                    using (SqlCommand co5 = new SqlCommand(stk6, con))
                                    {
                                        co5.Parameters.AddWithValue("Transfers", stk6);



                                        object count6 = co5.ExecuteScalar();

                                    //Checked
                                    string stk7 = "SELECT checked FROM Stock";
                                    using (SqlCommand co6 = new SqlCommand(stk7, con))
                                    {
                                        co6.Parameters.AddWithValue("Transfers", stk7);



                                        object count7 = co6.ExecuteScalar();



                                        if (count.Equals(0))
                                        {
                                            MessageBox.Show("There is no Stock available");
                                        }
                                        else
                                        {
                                            for (int i = 0; i <= Convert.ToInt32(count); i++)
                                            {
                                                textBox1.AppendText("STOCK REPORT(INDIVIDUAL)" + "\r\n" + "**********************");
                                                textBox1.AppendText("Stock Item ID: " + count1 + "\r\n");
                                                textBox1.AppendText("Stock Manufacturer: " + count2 + "\r\n");
                                                textBox1.AppendText("Stock Warranty: " + count3 + "\r\n");
                                                textBox1.AppendText("Stock Retail Price: " + count4 + "\r\n");
                                                textBox1.AppendText("Stock Item Type: " + count5 + "\r\n");
                                                textBox1.AppendText("Stock Item Status: " + count6 + "\r\n");
                                                textBox1.AppendText("Stock Checked: " + count7 + "\r\n");
                                            }
                                        }
                                    }

                                    }
                                }
                            }
                        }
                    }
                }
            }

           
            con.Close();
        }

        private void button13_Click(object sender, EventArgs e)//Sales Summary
        {
          
            //count sales
            string stk = "SELECT COUNT(*) FROM Sales";
            using (SqlCommand com1 = new SqlCommand(stk, con))
            {
                com1.Parameters.AddWithValue("Transfers", stk);
                con.Open();
                object count = com1.ExecuteScalar();

                //item id
                string stk1 = "SELECT sale_id FROM Sales";
                using (SqlCommand comm4 = new SqlCommand(stk1, con))
                {
                    comm4.Parameters.AddWithValue("Transfers", stk1);



                    object count1 = comm4.ExecuteScalar();


                    //manufacturer
                    string stk2 = "SELECT sale_date FROM Sales";
                    using (SqlCommand co1 = new SqlCommand(stk2, con))
                    {
                        co1.Parameters.AddWithValue("Transfers", stk2);



                        object count2 = co1.ExecuteScalar();

                        //Warranty
                        string stk3 = "SELECT item_ids FROM Sales";
                        using (SqlCommand co2 = new SqlCommand(stk3, con))
                        {
                            co2.Parameters.AddWithValue("Transfers", stk3);



                            object count3 = co2.ExecuteScalar();

                            //Retail Price
                            string stk4 = "SELECT total_cost FROM Sales";
                            using (SqlCommand co3 = new SqlCommand(stk4, con))
                            {
                                co3.Parameters.AddWithValue("Transfers", stk4);



                                object count4 = co3.ExecuteScalar();

                                //item type
                                string stk5 = "SELECT total_paid FROM Sales";
                                using (SqlCommand co4 = new SqlCommand(stk5, con))
                                {
                                    co4.Parameters.AddWithValue("Transfers", stk5);



                                    object count5 = co4.ExecuteScalar();

                                    //status
                                    string stk6 = "SELECT promotion FROM Sales";
                                    using (SqlCommand co5 = new SqlCommand(stk6, con))
                                    {
                                        co5.Parameters.AddWithValue("Transfers", stk6);



                                        object count6 = co5.ExecuteScalar();

                                        //Checked
                                        string stk7 = "SELECT payment_method FROM Sales";
                                        using (SqlCommand co6 = new SqlCommand(stk7, con))
                                        {
                                            co6.Parameters.AddWithValue("Transfers", stk7);



                                            object count7 = co6.ExecuteScalar();

                                            //Checked
                                            string stk8 = "SELECT sale_branch FROM Sales";
                                            using (SqlCommand co7 = new SqlCommand(stk8, con))
                                            {
                                                co7.Parameters.AddWithValue("Transfers", stk8);



                                                object count8 = co6.ExecuteScalar();

                                                if (count.Equals(0))
                                                {
                                                    MessageBox.Show("There were no Sales made");
                                                }
                                                else
                                                {
                                                    for (int i = 0; i <= Convert.ToInt32(count); i++)
                                                    {
                                                        textBox1.AppendText("SALES REPORT(INDIVIDUAL)" + "\r\n" + "**********************");
                                                        textBox1.AppendText("Sales ID: " + count1 + "\r\n");
                                                        textBox1.AppendText("Sales Date: " + count2 + "\r\n");
                                                        textBox1.AppendText("Sales Item ID: " + count3 + "\r\n");
                                                        textBox1.AppendText("Sales Total Cost: " + count4 + "\r\n");
                                                        textBox1.AppendText("Sales Total Paid: " + count5 + "\r\n");
                                                        textBox1.AppendText("Sales Payment Method: " + count7 + "\r\n");
                                                        textBox1.AppendText("Sales Promotion: " + count6 + "\r\n");
                                                        textBox1.AppendText("Sales Branch: " + count8 + "\r\n");
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            con.Close();
             
        }

        private void button12_Click(object sender, EventArgs e)//Orders Summary
        {
            
                //count sales
                string stk = "SELECT COUNT(*) FROM Orders";
                using (SqlCommand com1 = new SqlCommand(stk, con))
                {
                    com1.Parameters.AddWithValue("Transfers", stk);
                    con.Open();
                    object count = com1.ExecuteScalar();

                    //item id
                    string stk1 = "SELECT order_id FROM Orders";
                    using (SqlCommand comm4 = new SqlCommand(stk1, con))
                    {
                        comm4.Parameters.AddWithValue("Transfers", stk1);



                        object count1 = comm4.ExecuteScalar();


                        //manufacturer
                        string stk2 = "SELECT order_date FROM Orders";
                        using (SqlCommand co1 = new SqlCommand(stk2, con))
                        {
                            co1.Parameters.AddWithValue("Transfers", stk2);



                            object count2 = co1.ExecuteScalar();

                            //Warranty
                            string stk3 = "SELECT order_items FROM Orders";
                            using (SqlCommand co2 = new SqlCommand(stk3, con))
                            {
                                co2.Parameters.AddWithValue("Transfers", stk3);



                                object count3 = co2.ExecuteScalar();

                                //Retail Price
                                string stk4 = "SELECT order_supplier FROM Orders";
                                using (SqlCommand co3 = new SqlCommand(stk4, con))
                                {
                                    co3.Parameters.AddWithValue("Transfers", stk4);



                                    object count4 = co3.ExecuteScalar();

                                    //item type
                                    string stk5 = "SELECT eta FROM Orders";
                                    using (SqlCommand co4 = new SqlCommand(stk5, con))
                                    {
                                        co4.Parameters.AddWithValue("Transfers", stk5);



                                        object count5 = co4.ExecuteScalar();

                                        //status
                                        string stk6 = "SELECT received_date FROM Orders";
                                        using (SqlCommand co5 = new SqlCommand(stk6, con))
                                        {
                                            co5.Parameters.AddWithValue("Transfers", stk6);



                                            object count6 = co5.ExecuteScalar();

                                            //Checked
                                            string stk7 = "SELECT received FROM Orders";
                                            using (SqlCommand co6 = new SqlCommand(stk7, con))
                                            {
                                                co6.Parameters.AddWithValue("Transfers", stk7);



                                                object count7 = co6.ExecuteScalar();

                                                //Checked
                                                string stk8 = "SELECT total_cost FROM Orders";
                                                using (SqlCommand co7 = new SqlCommand(stk8, con))
                                                {
                                                    co7.Parameters.AddWithValue("Transfers", stk8);



                                                    object count8 = co6.ExecuteScalar();

                                                    if (count.Equals(0))
                                                    {
                                                        MessageBox.Show("There were no Orders made");
                                                    }
                                                    else
                                                    {
                                                        for (int i = 0; i <= Convert.ToInt32(count); i++)
                                                        {
                                                            textBox1.AppendText("ORDERS REPORT(INDIVIDUAL)" + "\r\n" + "**********************");
                                                            textBox1.AppendText("Orders ID: " + count1 + "\r\n");
                                                            textBox1.AppendText("Orders Date: " + count2 + "\r\n");
                                                            textBox1.AppendText("Orders Items: " + count3 + "\r\n");
                                                            textBox1.AppendText("Orders Supplier: " + count4 + "\r\n");
                                                            textBox1.AppendText("Orders ETA: " + count5 + "\r\n");
                                                            textBox1.AppendText("Orders Recieved Date: " + count6 + "\r\n");
                                                            textBox1.AppendText("Orders Recieved: " + count7 + "\r\n");
                                                            textBox1.AppendText("Orders Total Cost: " + count8 + "\r\n");
                                                        }
                                                    }
                                                }

                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

                con.Close();
            
        }
    }
}