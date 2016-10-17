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
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace _213
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        public Form1(string user)
        {
            InitializeComponent();

        }

        public Form1(string userName, loginForm lf)
        {
            InitializeComponent();
            user = userName;
            login = lf;
            login.Hide();
            login.ShowInTaskbar = false;
        }

        public Form1(string userName, loginForm lf, bool first, string em)
        {
            InitializeComponent();
            user = userName;
            login = lf;
            login.Hide();
            login.ShowInTaskbar = false;
            FR = first;
            email = em;
        }

        private loginForm login;
        private bool FR;
        private string email;

        private string user;
        //private string appPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDoc‌​uments));
        private gebruik util = new gebruik();

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            /////////////////////////////////////////////////////
            //this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            /////////////////////////////////////////////////////

            //////VISUALS
            ///ADMIN STUFF
            btnAdminShow.Location = new Point(13,(this.Height)/2 - 20);
            btnAdminHide.Location = new Point(133, (this.Height) / 2 - 20);

            btnAddUser.Size = new Size(62, 62);
            btnUUser.Size = new Size(62, 62);
            btnRUser.Size = new Size(62, 62);

            btnAddEmp.Size = new Size(62, 62);
            btnUEmp.Size = new Size(62, 62);
            btnREmp.Size = new Size(62, 62);

            btnEoM.Size = new Size(62, 62);
            btnVLogs.Size = new Size(62, 62);
            btnMPromo.Size = new Size(62,62);

            btnAdmLogout.Size = new Size(62, 62);
            btnExit.Size = new Size(62, 62);
            /////////Display admin panel
            if (util.checkAuthor(user))
                btnAdminShow.Visible = true;
            else
                btnAdminShow.Visible = false;

            btnAdminHide.BringToFront();

            if(FR)
            {

                MessageBox.Show("The system has detected that this is a new branch. Please enter the branch manager's information on the next form.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmAddEmp f1 = new frmAddEmp(user, email);
                f1.ShowDialog();

            }

        }

        //exit button
        private void button1_Click_1(object sender, EventArgs e)
        {
            DateTime local = DateTime.Now;

            gebruik.log(local, user, "logout");
            gebruik.log(local, user, "exited application");
  
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
                nearest = btnEOD;
                smallest = dist2;
            }
            else if (dist3 < dist2 && dist3 < dist1 && dist3 < dist4 && dist3 < dist5 && dist3 < dist6)
            {
                nearest = btnOrders;
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
            salesForm f1 = new salesForm();
            f1.Show();
            this.Hide();
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
            /*OrderForm OF = new OrderForm();
            OF.Activate();
            OF.Show();
            Form1 f1 = new Form1();
            f1.Hide();*/
            
        }

        //technical button
        private void roundButton5_Click(object sender, EventArgs e)
        {

        }

        //hq button
        private void roundButton6_Click(object sender, EventArgs e)
        {
            frmHQ hq = new frmHQ(user);
            hq.Show();
            this.Hide();
        }

        //stock button
        private void roundButton4_Click(object sender, EventArgs e)
        {
            StockMainFormCLN stockMainForm = new StockMainFormCLN(user);
            this.Hide();
            stockMainForm.Show();

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void btnAdminHide_Click(object sender, EventArgs e)
        {

            for (int pos = 0; pos > -233; pos--)
                pnlAdmin.Location = new Point(pos, 0);

            btnAdminHide.Visible = false;
            btnAdminShow.Visible = true;
            
        }

        private void btnAdminShow_Click(object sender, EventArgs e)
        {
            

            for (int pos = -233; pos < 0; pos++)
                pnlAdmin.Location = new Point(pos, 0);

            btnAdminShow.Visible = false;
            btnAdminHide.Visible = true;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {            
            frmAddUser adU = new frmAddUser(user);
            this.TopMost = false;
            adU.ShowDialog();
            
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            btnAdminShow.Location = new Point(180, (this.Height) / 2 - 20);
            btnAdminHide.Location = new Point(130, (this.Height) / 2 - 20);
        }

        private void btnRUser_Click(object sender, EventArgs e)
        {
            frmRUser rUser = new frmRUser(user);
            rUser.ShowDialog();
        }

        private void btnUUser_Click(object sender, EventArgs e)
        {
            frmUpdateUser uUser = new frmUpdateUser(user);
            uUser.ShowDialog();
        }

        private void btnAddEmp_Click(object sender, EventArgs e)
        {
            frmAddEmp aEmp = new frmAddEmp(user);
            aEmp.ShowDialog();

        }

        private void btnAdmLogout_Click(object sender, EventArgs e)
        {
            DateTime local = DateTime.Now;

            gebruik.log(local, user, "logout");

   
            login.Show();
            this.Close();
            login.TopMost = true;
        }

        private void btnUEmp_Click(object sender, EventArgs e)
        {
            frmUEmp uEmp = new frmUEmp(user);
            uEmp.ShowDialog();
        }

        private void btnREmp_Click(object sender, EventArgs e)
        {
            frmREmp rEmp = new frmREmp(user);
            rEmp.ShowDialog();
        }

        private void btnMPromo_Click(object sender, EventArgs e)
        {

            frmAdminPromos f1 = new frmAdminPromos(user);
            f1.ShowDialog();

        }

        private void btnVLogs_Click(object sender, EventArgs e)
        {

            frmLogs fl = new frmLogs(AppDomain.CurrentDomain.BaseDirectory + @"\Activity log.txt");
            fl.ShowDialog();

        }

        private void btnEoM_Click(object sender, EventArgs e)
        {

            frmEOM  f1 = new frmEOM();
            f1.ShowDialog();

        }

    }
}
