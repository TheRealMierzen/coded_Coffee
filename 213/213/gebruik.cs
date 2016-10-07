using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Mail;
using System.Net;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Globalization;

namespace _213
{
    class gebruik
    {

        public static void log(DateTime tyd, string user, string action)
        {

            string appPath = AppDomain.CurrentDomain.BaseDirectory + @"\Activity log.txt";
            try
            {
            if (File.Exists(appPath))
            {
                    File.SetAttributes(appPath, FileAttributes.Hidden);
                StreamWriter outstream = File.AppendText(appPath);
                
                    outstream.WriteLine("\n" + user + " " + action + ": " + tyd.ToString());
                    File.SetAttributes(appPath, File.GetAttributes(appPath) | FileAttributes.Hidden | FileAttributes.ReadOnly);
                outstream.Close();
            }
            else
            {
                File.CreateText(appPath).Close();
                StreamWriter outstream = File.AppendText(appPath);
                    outstream.WriteLine(user + " logged in: " + tyd.ToString());
                    File.SetAttributes(appPath, File.GetAttributes(appPath) | FileAttributes.Hidden | FileAttributes.ReadOnly);
                outstream.Close();
            }
            }
            catch(IOException)
            { }
            catch(Exception)
            { }
            
            
        }

        //As user iets delete/add/update of whatever
        public static void addAction(string user)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                {

                conn.Open();
                SqlCommand uLogin = new SqlCommand("UPDATE Users SET numberOfLogins = numberOfLogins + 1 WHERE userName = '" + user + "'", conn);
                uLogin.ExecuteNonQuery();
                conn.Close();

            }
            }
            catch (SqlException se)
            {

                if (se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection())
                        addAction(user);
                    else
                        MessageBox.Show("It appears that you have lost internet connection. Please verify your internet connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
       

            }
            catch (Exception)
            { }

        }

        /*Om te roep
        Random start = new Random();
        MessageBox.Show(util.genPassword(start.Next(0,10)));*/
        public string genPassword(int begin)
        {
            int[] fibo = new int[16];
            fibo[0] = 1;
            fibo[1] = 1;
            fibo[2] = 2;
            fibo[3] = 3;
            fibo[4] = 5;
            fibo[5] = 8;
            fibo[6] = 13;
            fibo[7] = 21;
            fibo[8] = 34;
            fibo[9] = 55;
            fibo[10] = 89;
            fibo[11] = 144;
            fibo[12] = 233;
            fibo[13] = 377;
            fibo[14] = 610;
            fibo[15] = 987;

            //kry som van fibo getalle
            int som = Convert.ToInt16(fibo[begin]);
            for (int tel = begin; tel < fibo.Length; tel++)
            {

                som += (int)fibo[tel];

            }

            //kry 2de som van fibo getalle
            Random gedeelte = new Random();
            int nuweBegin = gedeelte.Next(0, 10);
            while (nuweBegin == begin)
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
            catch (StackOverflowException)
            {

                som = Convert.ToInt32(som.ToString() + som2.ToString());

            }
            

            string antwoord = "";
            
            //kry 2 randomly en sit hulle in antwoord
            for (int deel = 0; deel < som.ToString().Length; deel++)
            {

                int getal1 = gedeelte.Next(0, som.ToString().Length);
                int getal2 = gedeelte.Next(0, som.ToString().Length);
                antwoord += (som.ToString()).Substring(getal1, 1) + (som.ToString()).Substring(getal2, 1);

            }

            //generate string password
            string password = "";
            for (int tel = 0; tel < 8; tel++)
            {

                int getal = (int)gedeelte.Next(0, antwoord.Length);
                int getal2 = (int)gedeelte.Next(0, antwoord.Length);

                while (Convert.ToInt32(antwoord.Substring(getal, 1) + antwoord.Substring(getal2, 1)) < 33 || (Convert.ToInt32(antwoord.Substring(getal, 1) + antwoord.Substring(getal2, 1)) > 127))
                {

                    getal = gedeelte.Next(0, antwoord.Length);
                    getal2 = gedeelte.Next(0, antwoord.Length);

                }
                
                string test = antwoord.Substring(getal, 1) + antwoord.Substring(getal2, 1);

                password += Convert.ToChar(Convert.ToInt16(test));
            }

            //validation
            for (int check = 0; check < 8; check++)
                {

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
            catch (Exception)
            {


                return false;

            }

        }

        //Printing
//////////////////////////////////////////////////////////////////////////////////
        public void print(string fileP)
        {


            ProcessStartInfo info = new ProcessStartInfo();
            info.Verb = "print";
            info.FileName = fileP;
            info.CreateNoWindow = true;
            info.WindowStyle = ProcessWindowStyle.Hidden;

            Process p = new Process();
            p.StartInfo = info;
            p.Start();

            p.WaitForInputIdle();
            System.Threading.Thread.Sleep(3000);
            if (false == p.CloseMainWindow())
                p.Kill();

            }
//////////////////////////////////////////////////////////////////////////////////

        public bool checkAuthor(string username)
        {

            try
            {
                using (SqlConnection con = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                {
                    string cmdstring = "SELECT authLevel FROM Users WHERE userName = @user";

                    using (SqlCommand comm = new SqlCommand(cmdstring, con))
                    {
                        con.Open();
                        int level = 0;
                        comm.Parameters.AddWithValue("@user", username);
                        level = (Int16)comm.ExecuteScalar();

                        if (level == 10)
                            return true;
                        else
                            return false;
                    }
                }
            }
            catch (SqlException se)
            {

                if (se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection())
                        return checkAuthor(username);
                    else
                        MessageBox.Show("It appears that you have lost internet connection. Please verify your internet connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    return false;

            }
            catch (Exception)
            { }

            return false;
        }
        //////////////////////////////////////////////////////////////////////////////////////
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
            catch (WebException)
            {

                //MessageBox.Show("An error occurred during the " + we.TargetSite + " process. Please verify the entered information and try again. If the problem persists, please contact our support team: blahblahsuppot \r\n" + we.Message, "Error");
                return "";

            }

        }

        public string GetLocation(string ip)
        {

            int tel = 0;
            var res = "";

            WebRequest request = WebRequest.Create("http://www.ip2location.com/" + ip);
            using (WebResponse response = request.GetResponse())
            using (StreamReader stream = new StreamReader(response.GetResponseStream()))
            {
                string line;
                
                while ((line = stream.ReadLine()) != null)
                {
                    tel += 1;

                    if (tel == 334)
                    {
                        res = line.Substring(line.LastIndexOf(",") + 1, line.Length - 6 - line.LastIndexOf(","));
                        res = res.Trim();
                    }
                                  
                }
            }
            return res;
        }

        public void setLocation()
        {

            Properties.Settings.Default.Branch = GetLocation(getIP());
            Properties.Settings.Default.Save();

        }
        /////////////////////////////////////////////////////////////////////////////////////////////
        public bool isUser(string id)
        {
            try
            {
                using (SqlConnection conUser = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                {
                    string find = "";

                    if (id.Length == 13)
                        find = "id_num";
                    else if (id.Length == 10)
                        find = "employee_id";

                    string cmdstring = "SELECT is_user FROM Employees WHERE " + find + " = @find";
                    using (SqlCommand commUser = new SqlCommand(cmdstring, conUser))
                    {
                        conUser.Open();
                        commUser.Parameters.AddWithValue("@find", id);
                        using (var reader = commUser.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                bool user = reader.GetBoolean(0);
                                if (user)
                                    return true;
                                else
                                    return false;

                            }

                        }

                        conUser.Close();
                        return false;

                    }
                }
            }
            catch (SqlException se)
            {

                if (se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection())
                        return isUser(id);
                    else
                        MessageBox.Show("It appears that you have lost internet connection. Please verify your internet connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    return false;

            }
            catch (Exception)
            { }

            return false;

        }

        public string getUsername(string email)
        {
            try
            {
                using (SqlConnection conUser = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                {

                    string cmdstring = "SELECT userName FROM Users WHERE email_address = @email";
                    using (SqlCommand commUser = new SqlCommand(cmdstring, conUser))
                    {
                        conUser.Open();
                        commUser.Parameters.AddWithValue("@email", email);
                        using (var reader = commUser.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                string user = reader.GetString(0);
                                return user;

                            }

                        }

                        conUser.Close();
                        return "";

                    }
                }
            }
            catch (SqlException se)
            {

                if (se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection())
                        return getUsername(email);
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

        public string getEmail(string id)
        {

            try
            {
                using (SqlConnection conEmail = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                {
                    string cmdstring = "";
                    if (id.Length == 10)
                        cmdstring = "SELECT email_address FROM Employees WHERE employee_id = @id";
                    else if (id.Length == 13)
                        cmdstring = "SELECT email_address FROM Employees WHERE id_num = @id";

                    using (SqlCommand commEmail = new SqlCommand(cmdstring, conEmail))
                    {
                        conEmail.Open();
                        commEmail.Parameters.AddWithValue("@id", id);
                        using (var reader = commEmail.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                string empID = reader.GetString(0);
                                return empID;

                            }

                        }

                        conEmail.Close();
                        return "";

                    }
                }
            }
            catch (SqlException se)
            {

                if (se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection())
                        return getEmail(id);
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


        public string generateLuhn()
        {

            try
            {
                string id = "";

                Random nxt = new Random();

                for (int i = 1; i < 11; i++)
                {
                    id += nxt.Next(0, 9).ToString();
                }

                while (!validateId(id))
                {

                    for (int i = 1; i < 11; i++)
                    {
                        id += nxt.Next(0, 9).ToString();
                    }

                }

                if (id == "")
                    id = generateLuhn();

                if (!checkID(id))
                    return id;
                else
                    id = generateLuhn();

                return id;
            }
            catch (FormatException)
            { }
            catch (InvalidCastException)
            { }
            catch (Exception)
            { }

            return "";                  
                        
        }

        public bool validateId(string id)
        {
            try
            {
                int idLength = id.Length;
                int current;
                int sum = 0;
                int c = 0;

                for (int i = idLength - 1; i >= 0; i--)
                {

                    string idCurrentRightmostDigit = id.Substring(i, 1);

                    if (!int.TryParse(idCurrentRightmostDigit, out current))
                        return false;

                    if (c % 2 != 0)
                    {
                        if ((current *= 2) > 9)
                            current -= 9;
                    }
                    c++;

                    sum += current;
                }

                return (sum % 10 == 0);
            }
            catch(InvalidCastException)
            { }
            catch(FormatException)
            { }
            catch(Exception)
            { }

            return false;
        }

        //true if found else false
        private bool checkID(string id)
        {
            try
            {
                using (SqlConnection con = new SqlConnection("workstation id=StockIT.mssql.somee.com;packet size=4096;user id=GokusGString_SQLLogin_1;pwd=z32rpjumdw;data source=StockIT.mssql.somee.com;persist security info=False;initial catalog=StockIT"))
                {
                    con.Open();

                    string cmdstring = "SELECT COUNT(*) FROM Employees WHERE employee_id = @id";

                    using (SqlCommand comm = new SqlCommand(cmdstring, con))
                    {
                        comm.Parameters.AddWithValue("@id", id);
                        int recs = (int)comm.ExecuteScalar();
                        con.Close();

                        if (recs == 0)
                            return false;
                        else
                            return true;
                    }
                }
            }
            catch (SqlException se)
            {
                if (se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection())
                        checkID(id);
                    else
                        MessageBox.Show("It appears that you have lost internet connection. Please verify your internet connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    return false;

            }
            catch(Exception)
            { }

            return false;

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

            try
            {
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
            catch (SqlException se)
            {
                if (se.Number == 53)
                {
                    gebruik other = new gebruik();
                    if (other.CheckConnection())
                        sendOrders(items, supplier, supplier_email);
                    else
                        MessageBox.Show("It appears that you have lost internet connection. Please verify your internet connection and try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }

/// <summary>
/// Used to get location/branch of user
/// </summary>
/// <returns></returns>
        public bool CheckConnection()
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (var stream = client.OpenRead("http://www.google.com"))
                    {
                        return true;
                    }
                }
            }
            catch
            {
                return false;
            }
            }        

        public bool CheckDate(String date)
        {
            string t;
            try
            {

                if (Convert.ToInt16(date.Substring(0, 2)) > 20)
                    t = "19" + date.Substring(0, 2);
                else
                    t = "20" + date.Substring(0, 2);
                t += "/";
                t += date.Substring(2, 2) + "/" + date.Substring(4, 2);

                DateTime dt = DateTime.Parse(t);
                return true;
            }
            catch
            {
                return false;
            }
        }

        private bool invalid;
        public bool IsValidEmail(string strIn)
        {
            invalid = false;
            if (String.IsNullOrEmpty(strIn))
                return false;

            // Use IdnMapping class to convert Unicode domain names.
            try
            {
                strIn = Regex.Replace(strIn, @"(@)(.+)$", this.DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }

            if (invalid)
                return false;

            // Return true if strIn is in valid e-mail format.
            try
            {
                return Regex.IsMatch(strIn,
                      @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                      @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                      RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private string DomainMapper(Match match)
        {
            // IdnMapping class with default property values.
            IdnMapping idn = new IdnMapping();

            string domainName = match.Groups[2].Value;
            try
            {
                domainName = idn.GetAscii(domainName);
            }
            catch (ArgumentException)
            {
                invalid = true;
            }
            return match.Groups[1].Value + domainName;
        }

    }
}


