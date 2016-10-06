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

namespace _213
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public Form1(string userName)
        {
            InitializeComponent();
            user = userName;
        }

        private string user;
        private string appPath;// = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments));
        private gebruik util = new gebruik();

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            /*this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;*/
        }

        //exit button
        private void button1_Click_1(object sender, EventArgs e)
        {
            DateTime local = DateTime.Now;
            gebruik.log(local, user, "logout", appPath + @"\stockI.T" + @"\Activity Log.txt");
  
            Application.Exit();
        }


        //UI Mouse
        //Determines which round button is the nearest to resize the button if close enough 
        private Object detNearest()
        {
            Point T = new Point(750,50);
            Point TL = new Point(500,250);
            Point TR = new Point(1000,250);
            Point BL = new Point(500,550);
            Point BR = new Point(1000,550);
            Point B = new Point(750,750);
            Point mousePoint = Cursor.Position;

            object nearest;
            double smallest;

            double dist1 = Math.Sqrt(Math.Pow(750 - mousePoint.X, 2) + Math.Pow(50 - mousePoint.Y, 2));
            double dist2 = Math.Sqrt(Math.Pow(500 - mousePoint.X, 2) + Math.Pow(250 - mousePoint.Y, 2));
            double dist3 = Math.Sqrt(Math.Pow(1000 - mousePoint.X, 2) + Math.Pow(250 - mousePoint.Y, 2));
            double dist4 = Math.Sqrt(Math.Pow(500 - mousePoint.X, 2) + Math.Pow(550 - mousePoint.Y, 2));
            double dist5 = Math.Sqrt(Math.Pow(1000 - mousePoint.X, 2) + Math.Pow(550 - mousePoint.Y, 2));
            double dist6 = Math.Sqrt(Math.Pow(750 - mousePoint.X, 2) + Math.Pow(750 - mousePoint.Y, 2));


            if (dist1 < dist2 && dist1 < dist3 && dist1 < dist4 && dist1 < dist5 && dist1 < dist6)
            {
                nearest = saleBtn;
                smallest = dist1;
            }
            else if (dist2 < dist1 && dist2 < dist3 && dist2 < dist4 && dist2 < dist5 && dist2 < dist6)
            {
                nearest = roundButton2;
                smallest = dist2;
            }
            else if (dist3 < dist2 && dist3 < dist1 && dist3 < dist4 && dist3 < dist5 && dist3 < dist6)
            {
                nearest = roundButton3;
                smallest = dist3;
            }
            else if (dist4 < dist2 && dist4 < dist1 && dist4 < dist3 && dist4 < dist5 && dist4 < dist6)
            {
                nearest = stockBtn;
                smallest = dist4;
            }
            else if (dist5 < dist2 && dist5 < dist3 && dist5 < dist4 && dist5 < dist1 && dist5 < dist6)
            {
                nearest = TechBtn;
                smallest = dist5;
            }
            else //(dist6 < dist2 && dist6 < dist3 && dist6 < dist4 && dist6 < dist5 && dist6 < dist1)
            {
                nearest = hqBtn;
                smallest = dist6;
            }

            if (smallest < 100)
                return nearest;
            else
                return null;


        }

        /*private void MouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            // Update the mouse path that is drawn onto the Panel.
            int mouseX = e.X;
            int mouseY = e.Y;

            if (detNearest() != null)
                label1.Text = detNearest().ToString();
        }*/

       /* private void roundButton1_MouseEnter(object sender, System.EventArgs e)
        {
            
        }*/

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            // Update the mouse event label to indicate the MouseEnter event occurred.
            
        }



        //////////////////////////////////////////////////////////////////////////////////////////////////////
        //Gebruik die vir die visual changes vir wanneer muis oor button gaan
        //////////////////////////////////////////////////////////////////////////////////////////////////////
        private void saleButton_MouseEnter(object sender, EventArgs e)
        {
            // Update the mouse event label to indicate the MouseEnter event occurred.
            saleBtn.BevelDepth = 4;
            saleBtn.BevelHeight = 2;
        }

        private void saleButton_MouseLeave(object sender, EventArgs e)
        {

            saleBtn.BevelDepth = 0;
            saleBtn.BevelHeight = 0;

        }
        //////////////////////////////////////////////////////////////////////////////////////////////

        //end of day button
        private void roundButton2_Click(object sender, EventArgs e)
        {
            

        }

        //sale button
        private void saleButton_Click(object sender, EventArgs e)
        {

        }

        //order button Zander Jagals
        private void roundButton3_Click(object sender, EventArgs e)
        {
            /* kode om die klient te email...asb moet my nie spam nie
            if (util.Mail("marcotaljaard@gmail.com", "Repair Complete", "Your repair has been completed"))
                MessageBox.Show("The client has successfully been emailed", "Info");
            else
                MessageBox.Show("The email failed to send", "Error");
            */
            OrderForm OF = new OrderForm();
            OF.Activate();
            OF.Show();
            Form1 f1 = new Form1();
            f1.Hide();
            
        }

        //technical button
        private void roundButton5_Click(object sender, EventArgs e)
        {
            FrmTechnical Tc = new FrmTechnical();
            Tc.Activate();
            Tc.Show();
            Form1 f1 = new Form1();
            f1.Hide();
            f1.Close();
        }

        //hq button
        private void roundButton6_Click(object sender, EventArgs e)
        {

        }

        //stock button
        private void roundButton4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            loginForm lf = new loginForm();
            lf.addUser(txtname.Text, txtpass.Text, txtlvl.Text, txtauth.Text, txtauthpass.Text);
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
