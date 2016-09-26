using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _213
{
    public partial class FrmTechnical : Form
    {
        public FrmTechnical()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void FrmTechnical_Load(object sender, EventArgs e)
        {
            gpbClient.Hide();
            gpxtech.Hide();
            rtbQuote.Hide();
            btnQuote.Hide();
            btnPlaceorder.Hide();
            txtMis.Text = "Select...";
            cbxGpu.Text = "Select...";
            cbxMotherboard.Text = "Select...";
            cbxPowerSupply.Text = "Select...";
            cbxRam.Text = "Select...";
            cbxPrimary.Text = "Select...";
            cbxSecondary.Text = "Select...";

        }


        private void custombuilds()//Om die layout van die from te verander na die custombuilds
        {
            gpbClient.Show();
            gpxtech.Show();
            rtbQuote.Show();
            btnPlaceorder.Show();
            gpxtech.Text = "Custom builds";
            rtbQuote.Text = "Quote for custom builds ";
            btnQuote.Show();
           
        }

        private void repairs()//Om die layout van die from te verander na die repairs
        {
            gpbClient.Show();
            gpxtech.Text = "Repairs";
            gpxtech.Show();
            rtbQuote.Show();
            btnPlaceorder.Show();
            rtbQuote.Text = "Quote for repairs ";

        }

        private void cbxLayout_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxLayout.SelectedIndex == 0)
                custombuilds();

            if (cbxLayout.SelectedIndex == 1)
                repairs();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
        }

        private void btnQuote_Click(object sender, EventArgs e)
        {
            rtbQuote.Clear();
            rtbQuote.AppendText("\n");
            rtbQuote.AppendText("\n Client Info");
            rtbQuote.AppendText("\n " + txtName.Text);
            rtbQuote.AppendText(" \n " + txtMis.Text);
            rtbQuote.AppendText(" \n " + txtEmail.Text);

            rtbQuote.AppendText("\n");
            rtbQuote.AppendText("\n Components");
            rtbQuote.AppendText("\n " + txtMis.Text);
            rtbQuote.AppendText("\n " + cbxMotherboard.Text);
            rtbQuote.AppendText("\n " + cbxRam.Text);
            rtbQuote.AppendText("\n " + cbxGpu.Text);
            rtbQuote.AppendText("\n " + cbxPowerSupply.Text);
            rtbQuote.AppendText("\n " + cbxPrimary.Text);
            rtbQuote.AppendText("\n " + cbxSecondary.Text);
        }

        private void FrmTechnical_Activated(object sender, EventArgs e)
        {
            txtMis.Text = "Select * FR";
        }
        
    }
}
