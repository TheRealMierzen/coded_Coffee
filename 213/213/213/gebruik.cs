using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Mail;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Net;

namespace _213
{
    class gebruik
    {

        public static void log(DateTime tyd, string user, string action, string appPath)
        {

            
            if (File.Exists(appPath))
            {
                StreamWriter outstream = File.AppendText(appPath);
                
                if (action == "login")
                    outstream.WriteLine("\n" + user + " logged in : " + tyd.ToString());
                else if (action == "logout")
                    outstream.WriteLine("\n" + user + " logged out : " + tyd.ToString());
                
                outstream.Close();
            }
            else
            {
                
                File.CreateText(appPath).Close();
                StreamWriter outstream = File.AppendText(appPath);
                outstream.WriteLine(user + " logged in : " + tyd.ToString());

                outstream.Close();

            }
            
            
        }

        //As user iets delete/add/update of whatever
        public static void addAction(string user)
        {

            using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True"))
            {

                conn.Open();
                SqlCommand uLogin = new SqlCommand("UPDATE Users SET numberOfLogins = numberOfLogins + 1 WHERE userName = '" + user + "'", conn);
                uLogin.ExecuteNonQuery();
                conn.Close();

            }

        }
       
        /*Om te roep
        Random start = new Random();
        MessageBox.Show(util.genPassword(start.Next(0,10)));*/
        public string genPassword(int begin)
        {
            int[] fibo = new int[16];
            fibo[0]  = 1;
            fibo[1]  = 1;
            fibo[2]  = 2;
            fibo[3]  = 3;
            fibo[4]  = 5;
            fibo[5]  = 8;
            fibo[6]  = 13;
            fibo[7]  = 21;
            fibo[8]  = 34;
            fibo[9]  = 55;
            fibo[10] = 89;
            fibo[11] = 144;
            fibo[12] = 233;
            fibo[13] = 377;
            fibo[14] = 610;
            fibo[15] = 987;

            //kry som van fibo getalle
            int som = Convert.ToInt16(fibo[begin]);
            for(int tel = begin; tel < fibo.Length; tel++)
            {

                som += (int)fibo[tel];

            }

            //kry 2de som van fibo getalle
            Random gedeelte = new Random();
            int nuweBegin = gedeelte.Next(0,10);
            while(nuweBegin == begin)
            {

                nuweBegin = gedeelte.Next(0, 10);

            }
            int som2 = Convert.ToInt16(fibo[begin]);

            for (int tel = nuweBegin; tel < fibo.Length; tel++)
            {

                som2 += (int)fibo[tel];

            }

            try
            {

                som = Convert.ToInt32(som.ToString() + som2.ToString());

            }
            catch(StackOverflowException)
            {

                som = Convert.ToInt32(som.ToString() + som2.ToString());

            }
            

            string antwoord = "";
            
            //kry 2 randomly en sit hulle in antwoord
            for (int deel = 0; deel < som.ToString().Length; deel++)
            {

                int getal1 = gedeelte.Next(0, som.ToString().Length);
                int getal2 = gedeelte.Next(0, som.ToString().Length);
                antwoord += (som.ToString()).Substring(getal1,1) + (som.ToString()).Substring(getal2,1);

            }

            //generate string password
            string password = "";
            for(int tel = 0; tel < 8; tel++)
            {

                int getal = (int)gedeelte.Next(0,antwoord.Length);
                int getal2 = (int)gedeelte.Next(0, antwoord.Length);

                while(Convert.ToInt32(antwoord.Substring(getal,1) + antwoord.Substring(getal2, 1)) < 33 || (Convert.ToInt32(antwoord.Substring(getal, 1) + antwoord.Substring(getal2, 1)) > 127))
                {

                    getal = gedeelte.Next(0, antwoord.Length);
                    getal2 = gedeelte.Next(0, antwoord.Length);

                }
                
                string test = antwoord.Substring(getal, 1) + antwoord.Substring(getal2, 1);
                if (test.Contains("44"))
                {
                    getal += gedeelte.Next(1, 4);
                    getal2 += gedeelte.Next(0,9);
                    test = (Convert.ToInt32(test) + Convert.ToInt32(getal.ToString() + getal2.ToString())).ToString();

                }

                if (test.Contains("35"))
                    test = antwoord.Substring(getal2, 1) + antwoord.Substring(getal, 1);
                //int ascii = antwoord[Convert.ToInt16(test)];
                password += Convert.ToChar(Convert.ToInt16(test));
            }

            //validation
            for(int check = 0; check < 8; check++)
            {
                try
                {
                    if (password.Contains(",") || password.Contains("#"))
                    {

                        password = this.genPassword(begin);

                    }
                }
                catch(StackOverflowException)
                {

                    password = this.genPassword(begin);

                }

                char[] symbol = password.ToCharArray();
                int count = 0;

                for (int tel = 0; tel < symbol.Length; tel++)
                {

                    try
                    {
                        for (int b = 0; b < symbol.Length; b++)
                        {
                            if ((symbol[tel] == symbol[b]) && (tel != symbol.Length) && (b != symbol.Length))
                                count++;

                            if (count >= 4)
                            {
                                count = 0;
                                password = this.genPassword(begin);
                            }
                            
                                
                        }
                        count = 0;
                    }
                    catch (IndexOutOfRangeException)
                    {

                        break;

                    }
                }

            }

            return password;
            
        }


        /*true if sent
          false if failed*/
          //needs backgroundrunners
        public bool Mail(string to, string source, string message)
        {

            try
            {
                var fromAddress = new MailAddress("codedCoffeeTest@gmail.com");
                var toAddress = new MailAddress(to);
                const string fromPassword = "UR44R:5:";
                string subject = source;
                string body = message;

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new System.Net.NetworkCredential(fromAddress.Address, fromPassword)
                };
                using (var mail = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(mail);
                    return true;
                }
            }
            catch(Exception)
            {

                return false;

            }        

        }

        public int getLastIdentity(string tableName, string column, string returnType)
        {

            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True"))
                {

                    con.Open();
                    SqlCommand lastId = new SqlCommand("SELECT MAX(cast( " + column + " as int)) FROM " + tableName + " ", con);


                    int last = 0;

                    if (returnType == "int")
                    {
                        

                        SqlDataReader dr = lastId.ExecuteReader();

                        while (dr.Read())
                        {

                            last = dr.GetInt32(0);

                        }
                        dr.Close();

                    }

                    return Convert.ToInt16(last);

                }
            }
            catch(Exception e)
            {

                MessageBox.Show("An error occurred during the " + e.TargetSite + " process. Please verify the entered information and try again. If the problem persists, please contact our support team: blahblahsuppot \r\n" + e.Message, "Error");
                return -1;

            }

        }

        //MessageBox.Show(util.getDayOrders("2016-12-05"));
        public string getDayOrders(string orderDate)
        {

            try
            {
                int records = 0;
                using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True"))
                {

                    con.Open();
                    SqlCommand dayOrdersCount = new SqlCommand("SELECT COUNT(order_id) AS r_count FROM Orders WHERE order_date = '" + orderDate + "'",con);
                    records = (int) dayOrdersCount.ExecuteScalar();

                    MessageBox.Show(records.ToString());
                    SqlCommand dayOrders = new SqlCommand("SELECT order_items FROM Orders WHERE order_date = '" + orderDate + "'", con);
                    SqlDataReader dr = dayOrders.ExecuteReader();

                    string items = "";
                    while (dr.Read())
                    {

                        items += dr.GetString(0) + "\r\n";

                    }
                    dr.Close();

                    return items;
                }
            }
            catch(Exception e)
            {

                MessageBox.Show("An error occurred during the " + e.TargetSite + " process. Please verify the entered information and try again. If the problem persists, please contact our support team: blahblahsuppot \r\n" + e.Message, "Error");
                return "";

            }

        }

        public void sendOrders(string items, string supplier, string supplier_email)
        {

            gebruik util = new gebruik();

            int high = -1;
            int low = -1;
            int records = -1;

            using (SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True"))
            {
                con.Open();
                SqlCommand dayOrdersCount = new SqlCommand("SELECT COUNT(order_id) AS r_count FROM Orders WHERE order_date = '" + DateTime.Now.Date.ToString() + "'", con);
                records = (int)dayOrdersCount.ExecuteScalar();

                if (records == 1)
                    high = util.getLastIdentity("Orders", "order_id", "int");

                if (records > 1)
                {
                    high = util.getLastIdentity("Orders", "order_id", "int");
                    string cmdstring = "SELECT TOP 1 order_id FROM Orders WHERE order_date = @order_date ORDER BY order_id";
                    using (SqlCommand comm = new SqlCommand(cmdstring, con))
                    {
                        comm.Parameters.AddWithValue("@order_date", DateTime.Now.Date.ToString());
                        low = Convert.ToInt32(comm.ExecuteScalar());

                    }

                }
            }


            //supplier email
            if (records > 1)
                if (util.Mail(supplier_email, DateTime.Now.Date.ToShortDateString() + " codedCoffee stock orders", "Good evening \r\nThe following are stock that we wish to order: \r\n" + items + " \r\nPlease confirm the items and contact us about any updates. \r\nOrder ids: " + low.ToString() + "-" + high.ToString() + "\r\nThank you in advance"))
                {
                    using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True"))
                    {

                        string cmd = "UPDATE Orders SET invoice_sent = 1 WHERE order_date = @order_date";
                        using (SqlCommand comm = new SqlCommand(cmd, conn))
                        {
                            comm.Parameters.AddWithValue("@order_date", DateTime.Now.Date.ToString());
                            conn.Open();
                            comm.ExecuteNonQuery();
                            conn.Close();
                        }

                    }
                    MessageBox.Show("The suppliername has been emailed with the contents of orders " + low.ToString() + "-" + high.ToString());
                }
            if (records == 1)
                if (util.Mail(supplier_email, DateTime.Now.Date.ToShortDateString() + " codedCoffee stock orders", "Good evening \r\nThe following are stock that we wish to order: \r\n" + items + "\r\nPlease confirm the items and contact us about any updates. \r\nOrder id: " + high.ToString() + "\r\nThank you in advance"))
                {
                    using (SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=stockI.T;Integrated Security=True"))
                    {

                        string cmd = "UPDATE Orders SET invoice_sent = 1 WHERE order_date = @order_date";
                        using (SqlCommand comm = new SqlCommand(cmd, conn))
                        {
                            comm.Parameters.AddWithValue("@order_date", DateTime.Now.Date.ToString());
                            conn.Open();
                            comm.ExecuteNonQuery();
                            conn.Close();
                        }

                    }
                    MessageBox.Show("The suppliername has been emailed with the contents of order " + high.ToString());
                }

        }

/// <summary>
/// Used to get location/branch of user
/// </summary>
/// <returns></returns>
        public string getIP()
        {
            try
            {
                
                string url = "http://checkip.dyndns.org";

                System.Net.WebRequest req = System.Net.WebRequest.Create(url);
                System.Net.WebResponse resp = req.GetResponse();
                System.IO.StreamReader sr = new System.IO.StreamReader(resp.GetResponseStream());

                string response = sr.ReadToEnd().Trim();
                string[] a = response.Split(':');
                string a2 = a[1].Substring(1);
                string[] a3 = a2.Split('<');
                string a4 = a3[0];

                return a4;
            }
            catch(System.Net.WebException we)
            {

                MessageBox.Show("An error occurred during the " + we.TargetSite + " process. Please verify the entered information and try again. If the problem persists, please contact our support team: blahblahsuppot \r\n" + we.Message, "Error");
                return "";

            }

        }

        public string GetLocation(string ip)
        {
            int tel = 0;
            var res = "";

            WebRequest request = WebRequest.Create("http://ipinfo.io/" + ip);
            using (WebResponse response = request.GetResponse())
            using (StreamReader stream = new StreamReader(response.GetResponseStream()))
            {
                string line;
                
                while ((line = stream.ReadLine()) != null)
                {
                    tel += 1;
                    
                    if (tel == 4)
                        res += line.Substring(11, line.Length - 13);
                }
            }
            return res;
        }
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    }
}
