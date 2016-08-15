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
    public partial class StockFindForm : Form
    {
        public StockFindForm()
        {
            InitializeComponent();
        }

        private void txtFindName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelFind_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            StockMainFormCLN frmStockMain = new StockMainFormCLN();
            frmStockMain.Show();
        }

        private void btnConfirmFind_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to complete this action?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //as user ja se
                this.Hide();
                this.Close();
                StockMainFormCLN frmStockMain = new StockMainFormCLN();
                frmStockMain.Show();
            }
            else
            {
                //as user nee se

            }
        }

        private void tmrValidateFind_Tick(object sender, EventArgs e)
        {
            if (txtFindName.Text == "" & txtFindBrand.Text == "" & txtFindPrice.Text == "")
            {
                txtFindBrand.Enabled = true;
                txtFindName.Enabled = true;
                txtFindPrice.Enabled = true;
            }
            if (txtFindName.Text != "")
            {
                txtFindBrand.Enabled = false;
                txtFindPrice.Enabled = false;
            }
            if (txtFindBrand.Text != "")
            {
                txtFindName.Enabled = false;
                txtFindPrice.Enabled = false;
            }
            if (txtFindPrice.Text != "")
            {
                txtFindBrand.Enabled = false;
                txtFindName.Enabled = false;
            }
        }

        private void StockFindForm_Shown(object sender, EventArgs e)
        {
            tmrValidateFind.Enabled = true;
        }
    }
}
