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
    public partial class StockTransferRecieveForm : Form
    {
        public StockTransferRecieveForm()
        {
            InitializeComponent();
        }

        private void btnConfirmRecieve_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to complete this action?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //as user ja se
                //Hier kom die code om die nuwe Stock listing te add
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

        private void cmbBranchRecieve_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelRecieve_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to complete this action?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //as user ja se
                //Hier kom die code om die nuwe Stock listing te add
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

        private void lblBranchRecieve_Click(object sender, EventArgs e)
        {

        }
    }
}
