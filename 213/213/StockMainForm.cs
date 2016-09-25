using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace _213
{
   
    public partial class StockMainFormCLN : Form
    {
        private string userNme;
        public StockMainFormCLN()
        {
            InitializeComponent();
        }
        public StockMainFormCLN(string user)
        {
            InitializeComponent();
            userNme = user;
        }

        private void cmbSelectStockAction_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void StockMainForm_Shown(object sender, EventArgs e)
        {
            txbStockReport.AppendText(userNme);
        }

        private void cmbSelectStockAction_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Add Stock Selected and Confirmed
            if (cmbSelectStockAction.SelectedIndex == 0)
            {

                //Vra of user nuwe listing will maak of net stock by sit
                if (MessageBox.Show("Do you want to create a new listing?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //as user ja se
                   this.Hide();
                   this.Close();
                    StockAddFormCLN frmStockAddCLN = new StockAddFormCLN(userNme);
                    frmStockAddCLN.Show();
                }
                else
                {
                    //as user nee se
                   this.Hide();
                    this.Close();
                    StockAddFormUPD frmStockAddUPD = new StockAddFormUPD(userNme);
                    frmStockAddUPD.Show();
                }

            }
            if (cmbSelectStockAction.SelectedIndex == 1)
            {
                this.Hide();
                this.Close();
                StockFindForm frmStockFind = new StockFindForm(userNme);
                frmStockFind.Show();
            }
            if (cmbSelectStockAction.SelectedIndex == 2)
            { 
              this.Hide();
               this.Close();
                StockAddFormUPD frmStockAddUPD = new StockAddFormUPD(userNme);
                frmStockAddUPD.Show();
            }
            if (cmbSelectStockAction.SelectedIndex == 3)
            {
                StockTransferSendForm frmSendStock = new StockTransferSendForm(userNme);
                this.Hide();
                this.Close();
                
                frmSendStock.Show();
            }
            if (cmbSelectStockAction.SelectedIndex == 4)
            {
                StockTakeForm stf = new StockTakeForm(userNme);
                this.Hide();
                stf.Show();
            }
            if (cmbSelectStockAction.SelectedIndex == 5)
            {
                StockRemoveForm stf = new StockRemoveForm(userNme);
                   this.Hide();
                stf.Show();
            }
        }

        private void btnConfirmStockAction_Click(object sender, EventArgs e)
        {

        }

        private void StockMainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnBackMain_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.Show();
        }

        private void btnPrintStockReport_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            PrintDocument printDoc = new PrintDocument();

            //PrintPage event to draw the textbox contents on page
            printDoc.PrintPage += new PrintPageEventHandler(printDoc_PrintPage);

           // printDoc.DocumentName = ("Stock Report " + dtpStockReport.Value.ToString());

            printDialog.Document = printDoc;
            printDialog.AllowSelection = true;

            printDialog.AllowSomePages = true;

            if (printDialog.ShowDialog() == DialogResult.OK)
                printDoc.Print();
        }

         private void printDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            //Font
            Font f = new System.Drawing.Font("Arial", 10, FontStyle.Bold);

            //Brush
            Brush b = new SolidBrush(Color.Black);

            //Where to draw the string
            PointF p = new PointF(10, 10);

            //Draw some strings into the graphics
            e.Graphics.DrawString  (txbStockReport.Text, f, b, p);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
