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
        private int count;
        string myFile;
        private string CurrentPath = "/Branch/Summary";
        private string CurrentPath1 = "/Branch/Transfer";
        private string CurrentPath2 = "/Branch/Sales";
        private string CurrentPath3 = "/Branch/Stock";
        private string CurrentPath4 = "/Branch/Orders";
        SqlConnection con = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT");
        public EndOfDay()
        {

            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
            /*try
            {

            }
            catch(SqlException se)
            {
                if(se.Number == 53)
                {
                    gebruik obj = new gebruik();
                    if(obj.CheckConnection() && count<4)
                    {
                        count++;
                    }
                    else
                    {

                    }
                }
            }*/

            string cmd1 = "SELECT * FROM Orders WHERE order_date = @order AND branch = @branch";
            using (SqlCommand comm1 = new SqlCommand(cmd1, con))
            {
                comm1.Parameters.AddWithValue("@branch", Properties.Settings.Default.Branch);
                comm1.Parameters.AddWithValue("@order", DateTime.Today);

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

            string cmd2 = "SELECT * FROM Sales WHERE sale_date = @sale";
            using (SqlCommand comm2 = new SqlCommand(cmd2, con))
            {
                comm2.Parameters.AddWithValue("@sale", Properties.Settings.Default.Branch);
                comm2.Parameters.AddWithValue("@sale", DateTime.Now);
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
            string cmd3 = "SELECT * FROM Stock WHERE initial_add = @stock";
            using (SqlCommand comm3 = new SqlCommand(cmd3, con))
            {

                comm3.Parameters.AddWithValue("@stock", Properties.Settings.Default.Branch);
                comm3.Parameters.AddWithValue("@stock", DateTime.Today);

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
             
            string cmd4 = "SELECT * FROM Transfers WHERE send_date = @trans";
            using (SqlCommand comm4 = new SqlCommand(cmd4, con))
            {
                comm4.Parameters.AddWithValue("@trans", Properties.Settings.Default.Branch);
                comm4.Parameters.AddWithValue("@trans", DateTime.Today);

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
            //order
            string ordr = "SELECT COUNT(order_id) FROM Orders WHERE order_date = @order";
            using (SqlCommand comm4 = new SqlCommand(ordr, con))
            {
                comm4.Parameters.AddWithValue("@order", Properties.Settings.Default.Branch);
                comm4.Parameters.AddWithValue("@order", DateTime.Today);
                con.Open();
                object count = comm4.ExecuteScalar();

                textBox1.AppendText("ORDERS REPORT\r\n");
                textBox1.AppendText("******************************\r\n");
                textBox1.AppendText("******************************\r\n");
                textBox1.AppendText("Total Orders Placed: " + count.ToString() + "\r\n");

                con.Close();
            }
            //sale
            string sale = "SELECT COUNT(sale_id) FROM Sales WHERE sale_date = @sale";
            using (SqlCommand com1 = new SqlCommand(sale, con))
            {
                com1.Parameters.AddWithValue("@sale", Properties.Settings.Default.Branch);
                com1.Parameters.AddWithValue("@sale", DateTime.Now);
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
            //stock
            string stck = "SELECT COUNT(item_id) FROM Stock WHERE initial_add = @stock";
            using (SqlCommand com1 = new SqlCommand(stck, con))
            {
                com1.Parameters.AddWithValue("@stock", Properties.Settings.Default.Branch);
                com1.Parameters.AddWithValue("@stock", DateTime.Today);
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
            //transfers
            string trns = "SELECT COUNT(transfer_id) FROM Transfers WHERE send_date = @trans";
            using (SqlCommand com1 = new SqlCommand(trns, con))
            {
                com1.Parameters.AddWithValue("@trans", Properties.Settings.Default.Branch);
                com1.Parameters.AddWithValue("@trans", DateTime.Today);
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

            //Upload na Dropbox
            if (openFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
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
        //
        //
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
            

            
            string trns = "SELECT COUNT(transfer_id) FROM Transfers WHERE send_date = @transCount";
            using (SqlCommand com1 = new SqlCommand(trns, con))
            {
                com1.Parameters.AddWithValue("@transCount", Properties.Settings.Default.Branch);
                com1.Parameters.AddWithValue("@transCount", DateTime.Today);
                con.Open();
                object count = com1.ExecuteScalar();

                //
                string trn1 = "SELECT transfer_id FROM Transfers WHERE send_date = @transID";
                using (SqlCommand comm4 = new SqlCommand(trn1, con))
                {
                    comm4.Parameters.AddWithValue("@transID", Properties.Settings.Default.Branch);
                    comm4.Parameters.AddWithValue("@transID", DateTime.Today);
                    

                    object count1 = comm4.ExecuteScalar();


                    //from branch
                    string trn2 = "SELECT from_branch FROM Transfers WHERE send_date = @transBranch";
                    using (SqlCommand co1 = new SqlCommand(trn2, con))
                    {
                        co1.Parameters.AddWithValue("@transBranch", Properties.Settings.Default.Branch);
                        co1.Parameters.AddWithValue("@transBranch", DateTime.Today);
                        

                        object count2 = co1.ExecuteScalar();

                        //To Branch
                        string trn3 = "SELECT to_branch FROM Transfers WHERE send_date = @transTo";
                        using (SqlCommand co2 = new SqlCommand(trn3, con))
                        {
                            co2.Parameters.AddWithValue("@transTo", Properties.Settings.Default.Branch);
                            co2.Parameters.AddWithValue("@transTo", DateTime.Today);
                            

                            object count3 = co2.ExecuteScalar();

                            //item ids
                            string trn4 = "SELECT item_ids FROM Transfers WHERE send_date = @transItem";
                            using (SqlCommand co3 = new SqlCommand(trn4, con))
                            {
                                co3.Parameters.AddWithValue("@transItem", Properties.Settings.Default.Branch);
                                co3.Parameters.AddWithValue("@transItem", DateTime.Today);
                              

                                object count4 = co1.ExecuteScalar();

                                //send date
                                string trn5 = "SELECT send_date FROM Transfers WHERE send_date = @transSend";
                                using (SqlCommand co4 = new SqlCommand(trn5, con))
                                {
                                    co4.Parameters.AddWithValue("@transSend", Properties.Settings.Default.Branch);
                                    co4.Parameters.AddWithValue("@transSend", DateTime.Today);
                                    

                                    object count5 = co1.ExecuteScalar();

                                    //eta
                                    string trn6 = "SELECT eta FROM Transfers WHERE send_date = @transEta";
                                    using (SqlCommand co5 = new SqlCommand(trn6, con))
                                    {
                                        co5.Parameters.AddWithValue("@transEta", Properties.Settings.Default.Branch);
                                        co5.Parameters.AddWithValue("@transEta", DateTime.Today);
                                        

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
            
            //Upload na Dropbox
            if (openFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }


            OAuthUtility.PutAsync
            (
                 "https://content.dropboxapi.com/1/files_put/auto/<path>?param=val",
                     new HttpParameterCollection
                    {
                        {"access_token", Properties.Settings.Default.AccessToken},
                        {"path", Path.Combine(this.CurrentPath1, Path.GetFileName(openFileDialog1.FileName)).Replace("\\", "/")},
                        {"overwrite", "true"},
                        {"autorename", "true"},
                        {openFileDialog1.OpenFile()}
                    },
                     callback: Upload_Result
            );
           
        }

        private void button14_Click(object sender, EventArgs e)//Stock Summary
        {
           
            string stk = "SELECT COUNT(item_id) FROM Stock WHERE initial_add = @stockCount";
            using (SqlCommand com1 = new SqlCommand(stk, con))
            {
                com1.Parameters.AddWithValue("@stockCount", Properties.Settings.Default.Branch);
                com1.Parameters.AddWithValue("@stockCount",DateTime.Today);
                con.Open();
                object count = com1.ExecuteScalar();

                //item id
                string stk1 = "SELECT item_id FROM Stock WHERE initial_add = @stock1";
                using (SqlCommand comm4 = new SqlCommand(stk1, con))
                {
                    comm4.Parameters.AddWithValue("@stock1", Properties.Settings.Default.Branch);
                    comm4.Parameters.AddWithValue("@stock1", DateTime.Today);


                    object count1 = comm4.ExecuteScalar();


                    //manufacturer
                    string stk2 = "SELECT manufacturer FROM Stock WHERE initial_add = @stock2";
                    using (SqlCommand co1 = new SqlCommand(stk2, con))
                    {
                        co1.Parameters.AddWithValue("@stock2", Properties.Settings.Default.Branch);
                        co1.Parameters.AddWithValue("@stock2", DateTime.Today);


                        object count2 = co1.ExecuteScalar();

                        //Warranty
                        string stk3 = "SELECT warranty FROM Stock WHERE initial_add = @stock3";
                        using (SqlCommand co2 = new SqlCommand(stk3, con))
                        {
                            co2.Parameters.AddWithValue("@stock3", Properties.Settings.Default.Branch);
                            co2.Parameters.AddWithValue("@stock3", DateTime.Today);


                            object count3 = co2.ExecuteScalar();

                            //Retail Price
                            string stk4 = "SELECT retail_price FROM Stock WHERE initial_add = @stock4";
                            using (SqlCommand co3 = new SqlCommand(stk4, con))
                            {
                                co3.Parameters.AddWithValue("@stock4", Properties.Settings.Default.Branch);
                                co3.Parameters.AddWithValue("@stock4", DateTime.Today);


                                object count4 = co3.ExecuteScalar();

                                //item type
                                string stk5 = "SELECT item_type FROM Stock WHERE initial_add = @stock5";
                                using (SqlCommand co4 = new SqlCommand(stk5, con))
                                {
                                    co4.Parameters.AddWithValue("@stock5", Properties.Settings.Default.Branch);
                                    co4.Parameters.AddWithValue("@stock5", DateTime.Today);


                                    object count5 = co4.ExecuteScalar();

                                    //status
                                    string stk6 = "SELECT status FROM Stock WHERE initial_add = @stock6";
                                    using (SqlCommand co5 = new SqlCommand(stk6, con))
                                    {
                                        co5.Parameters.AddWithValue("@stock6", Properties.Settings.Default.Branch);
                                        co5.Parameters.AddWithValue("@stock6", DateTime.Today);


                                        object count6 = co5.ExecuteScalar();

                                    //Checked
                                    string stk7 = "SELECT checked FROM Stock WHERE initial_add = @stock7";
                                    using (SqlCommand co6 = new SqlCommand(stk7, con))
                                    {
                                        co6.Parameters.AddWithValue("@stock7", Properties.Settings.Default.Branch);
                                        co6.Parameters.AddWithValue("@stock7", DateTime.Today);


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

            //Upload na Dropbox
            

            if (openFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }


            OAuthUtility.PutAsync
            (
                 "https://content.dropboxapi.com/1/files_put/auto/<path>?param=val",
                     new HttpParameterCollection
                    {
                        {"access_token", Properties.Settings.Default.AccessToken},
                        {"path", Path.Combine(this.CurrentPath3, Path.GetFileName(openFileDialog1.FileName)).Replace("\\", "/")},
                        {"overwrite", "true"},
                        {"autorename", "true"},
                        {openFileDialog1.OpenFile()}
                    },
                     callback: Upload_Result
            );
        }

        private void button13_Click(object sender, EventArgs e)//Sales Summary
        {
          
            //count sales
            string stk = "SELECT COUNT(sale_id) FROM Sales WHERE sale_date = @saleCount";
            using (SqlCommand com1 = new SqlCommand(stk, con))
            {
                com1.Parameters.AddWithValue("@saleCount", Properties.Settings.Default.Branch);
                com1.Parameters.AddWithValue("@saleCount", DateTime.Now);
                con.Open();
                object count = com1.ExecuteScalar();

                //item id
                string stk1 = "SELECT sale_id FROM Sales WHERE sale_date = @saleID";
                using (SqlCommand comm4 = new SqlCommand(stk1, con))
                {
                    comm4.Parameters.AddWithValue("@saleID", Properties.Settings.Default.Branch);
                    comm4.Parameters.AddWithValue("@saleID", DateTime.Now);


                    object count1 = comm4.ExecuteScalar();


                    //manufacturer
                    string stk2 = "SELECT sale_date FROM Sales WHERE sale_date = @saleDate";
                    using (SqlCommand co1 = new SqlCommand(stk2, con))
                    {
                        co1.Parameters.AddWithValue("@saleDate", Properties.Settings.Default.Branch);
                        co1.Parameters.AddWithValue("@saleDate", DateTime.Now);


                        object count2 = co1.ExecuteScalar();

                        //Warranty
                        string stk3 = "SELECT item_ids FROM Sales WHERE sale_date = @saleItem";
                        using (SqlCommand co2 = new SqlCommand(stk3, con))
                        {
                            co2.Parameters.AddWithValue("@saleItem", Properties.Settings.Default.Branch);
                            co2.Parameters.AddWithValue("@saleItem", DateTime.Now);


                            object count3 = co2.ExecuteScalar();

                            //Retail Price
                            string stk4 = "SELECT total_cost FROM Sales WHERE sale_date = @saleCost";
                            using (SqlCommand co3 = new SqlCommand(stk4, con))
                            {
                                co3.Parameters.AddWithValue("@saleCost", Properties.Settings.Default.Branch);
                                co3.Parameters.AddWithValue("@saleCost", DateTime.Now);


                                object count4 = co3.ExecuteScalar();

                                //item type
                                string stk5 = "SELECT total_paid FROM Sales WHERE sale_date = @salePaid";
                                using (SqlCommand co4 = new SqlCommand(stk5, con))
                                {
                                    co4.Parameters.AddWithValue("@salePaid", Properties.Settings.Default.Branch);
                                    co4.Parameters.AddWithValue("@salePaid", DateTime.Now);


                                    object count5 = co4.ExecuteScalar();

                                    //status
                                    string stk6 = "SELECT promotion FROM Sales WHERE sale_date = @salePromo";
                                    using (SqlCommand co5 = new SqlCommand(stk6, con))
                                    {
                                        co5.Parameters.AddWithValue("@salePromo", Properties.Settings.Default.Branch);
                                        co5.Parameters.AddWithValue("@salePromo", DateTime.Now);


                                        object count6 = co5.ExecuteScalar();

                                        //Checked
                                        string stk7 = "SELECT payment_method FROM Sales WHERE sale_date = @salePay";
                                        using (SqlCommand co6 = new SqlCommand(stk7, con))
                                        {
                                            co6.Parameters.AddWithValue("@salePay", Properties.Settings.Default.Branch);
                                            co6.Parameters.AddWithValue("@salePay", DateTime.Now);


                                            object count7 = co6.ExecuteScalar();

                                            //Checked
                                            string stk8 = "SELECT sale_branch FROM Sales WHERE sale_date = @saleBranch";
                                            using (SqlCommand co7 = new SqlCommand(stk8, con))
                                            {
                                                co7.Parameters.AddWithValue("@saleBranch", Properties.Settings.Default.Branch);
                                                co7.Parameters.AddWithValue("@saleBranch", DateTime.Now);


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
            //Upload na Dropbox
            

            if (openFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
            {
                return;
            }


            OAuthUtility.PutAsync
            (
                 "https://content.dropboxapi.com/1/files_put/auto/<path>?param=val",
                     new HttpParameterCollection
                    {
                        {"access_token", Properties.Settings.Default.AccessToken},
                        {"path", Path.Combine(this.CurrentPath2, Path.GetFileName(openFileDialog1.FileName)).Replace("\\", "/")},
                        {"overwrite", "true"},
                        {"autorename", "true"},
                        {openFileDialog1.OpenFile()}
                    },
                     callback: Upload_Result
            );
             
        }

        private void button12_Click(object sender, EventArgs e)//Orders Summary
        {
            
                //count sales
                string stk = "SELECT COUNT(order_id) FROM Orders WHERE order_date = @order";
                using (SqlCommand com1 = new SqlCommand(stk, con))
                {
                    com1.Parameters.AddWithValue("@order", Properties.Settings.Default.Branch);
                    com1.Parameters.AddWithValue("@order", DateTime.Today);
                    con.Open();
                    object count = com1.ExecuteScalar();

                    //item id
                    string stk1 = "SELECT order_id FROM Orders WHERE order_date = @orderid";
                    using (SqlCommand comm4 = new SqlCommand(stk1, con))
                    {
                        comm4.Parameters.AddWithValue("@orderid", Properties.Settings.Default.Branch);
                        comm4.Parameters.AddWithValue("@orderid", DateTime.Today);


                        object count1 = comm4.ExecuteScalar();


                        //manufacturer
                        string stk2 = "SELECT order_date FROM Orders WHERE order_date = @orderDate";
                        using (SqlCommand co1 = new SqlCommand(stk2, con))
                        {
                            co1.Parameters.AddWithValue("@orderDate", Properties.Settings.Default.Branch);
                            co1.Parameters.AddWithValue("@orderDate", DateTime.Today);


                            object count2 = co1.ExecuteScalar();

                            //Warranty
                            string stk3 = "SELECT order_items FROM Orders WHERE order_date = @orderItem";
                            using (SqlCommand co2 = new SqlCommand(stk3, con))
                            {
                                co2.Parameters.AddWithValue("@orderItem", Properties.Settings.Default.Branch);
                                co2.Parameters.AddWithValue("@orderItem", DateTime.Today);


                                object count3 = co2.ExecuteScalar();

                                //Retail Price
                                string stk4 = "SELECT order_supplier FROM Orders WHERE order_date = @orderSuply";
                                using (SqlCommand co3 = new SqlCommand(stk4, con))
                                {
                                    co3.Parameters.AddWithValue("@orderSuply", Properties.Settings.Default.Branch);
                                    co3.Parameters.AddWithValue("@orderSuply", DateTime.Today);


                                    object count4 = co3.ExecuteScalar();

                                    //item type
                                    string stk5 = "SELECT eta FROM Orders WHERE order_date = @orderEta";
                                    using (SqlCommand co4 = new SqlCommand(stk5, con))
                                    {
                                        co4.Parameters.AddWithValue("@orderEta", Properties.Settings.Default.Branch);
                                        co4.Parameters.AddWithValue("@orderEta", DateTime.Today);


                                        object count5 = co4.ExecuteScalar();

                                        //status
                                        string stk6 = "SELECT received_date FROM Orders WHERE order_date = @orderRecieve";
                                        using (SqlCommand co5 = new SqlCommand(stk6, con))
                                        {
                                            co5.Parameters.AddWithValue("@orderRecieve", Properties.Settings.Default.Branch);
                                            co5.Parameters.AddWithValue("@orderRecieve", DateTime.Today);


                                            object count6 = co5.ExecuteScalar();

                                            //Checked
                                            string stk7 = "SELECT received FROM Orders WHERE order_date = @orderRecieved";
                                            using (SqlCommand co6 = new SqlCommand(stk7, con))
                                            {
                                                co6.Parameters.AddWithValue("@orderRecieved", Properties.Settings.Default.Branch);
                                                co6.Parameters.AddWithValue("@orderRecieved", DateTime.Today);


                                                object count7 = co6.ExecuteScalar();

                                                //Checked
                                                string stk8 = "SELECT total_cost FROM Orders WHERE order_date = @orderCost";
                                                using (SqlCommand co7 = new SqlCommand(stk8, con))
                                                {
                                                    co7.Parameters.AddWithValue("@orderCost", Properties.Settings.Default.Branch);
                                                    co7.Parameters.AddWithValue("@orderCost", DateTime.Today);


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
            // Upload na Dropbox
                if (openFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                {
                    return;
                }


                OAuthUtility.PutAsync
                (
                     "https://content.dropboxapi.com/1/files_put/auto/<path>?param=val",
                         new HttpParameterCollection
                    {
                        {"access_token", Properties.Settings.Default.AccessToken},
                        {"path", Path.Combine(this.CurrentPath4, Path.GetFileName(openFileDialog1.FileName)).Replace("\\", "/")},
                        {"overwrite", "true"},
                        {"autorename", "true"},
                        {openFileDialog1.OpenFile()}
                    },
                         callback: Upload_Result
                );
            
        }

       

        private void button16_Click(object sender, EventArgs e)
        {
            con.Open();
            //Stock Finalize
            SqlCommand finalizeStock = new SqlCommand("DELETE FROM Stock WHERE branch = @branch AND status = @status",con);
            finalizeStock.Parameters.AddWithValue("@branch", Properties.Settings.Default.Branch);
            finalizeStock.Parameters.AddWithValue("@branch","Removed");
            finalizeStock.ExecuteNonQuery();
            SqlCommand resetStock = new SqlCommand("UPDATE Stock SET Checked = @check WHERE branch = @branch AND Status = @status",con);
            resetStock.Parameters.AddWithValue("@check", 0);
            resetStock.Parameters.AddWithValue("@branch", Properties.Settings.Default.Branch);
            resetStock.Parameters.AddWithValue("@status", "In stock");
            resetStock.ExecuteNonQuery();
            //orders finalize
            SqlCommand finalOrders = new SqlCommand("DELETE FROM Orders WHERE branch = @branch AND recieved = @rec",con);
            finalOrders.Parameters.AddWithValue("@branch", Properties.Settings.Default.Branch);
            finalOrders.Parameters.AddWithValue("@rec", 1);
            finalOrders.ExecuteNonQuery();

            //Sales


        }

        /*private void Upload_Result(RequestResult result)
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
        }*/


        private void button17_Click(object sender, EventArgs e)//Orders Dropbox
        {
           
        }

        
        

        private void button18_Click(object sender, EventArgs e)//Sales Dropbox
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

        
        

        private void button19_Click(object sender, EventArgs e)//Stock Dropbox
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
        

       


        private void button20_Click(object sender, EventArgs e)//Transfer Dropbox
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

        
        }
    }
