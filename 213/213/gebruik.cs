using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Mail;
using System.Data.SqlClient;

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
    }
}
