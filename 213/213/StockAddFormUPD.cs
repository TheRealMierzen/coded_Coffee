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
    public partial class StockAddFormUPD : Form
    {
        public StockAddFormUPD()
        {
            InitializeComponent();
        }

        private void txbQuantityAddUPD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txbQuantityAddUPD_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbListItemsAddUPD_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txbQuantityAddUPD.Enabled = true;
        }

        private void btnConfirmAddCLN_Click(object sender, EventArgs e)
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

        private void btnCancelAddCLN_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            StockMainFormCLN frmStockMain = new StockMainFormCLN();
            frmStockMain.Show();
        }
    }
}
