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
    public partial class StockAddFormCLN : Form
    {
        public StockAddFormCLN()
        {
            InitializeComponent();
        }

        private void btnCancelAddCLN_Click(object sender, EventArgs e)
        {
            //Close die form en redirect terug na main Stock form
            this.Hide();
            this.Close();
            StockMainFormCLN frmStockMain = new StockMainFormCLN();
            frmStockMain.Show();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            if ((txbBrandAddCLN.Text == "") & (txbNameAddCLN.Text == "") & (txbPriceAddCLN.Text == "") & (txbQuantityAddCLN.Text == ""))
            {
                prbStatusAddCLN.Value = 0;
            }
            if ((txbBrandAddCLN.Text != "") & (txbNameAddCLN.Text != "") & (txbPriceAddCLN.Text != "") & (txbQuantityAddCLN.Text != ""))
            {
                prbStatusAddCLN.Value = 100;
            }
            if ((txbBrandAddCLN.Text != "") & (txbNameAddCLN.Text == "") & (txbPriceAddCLN.Text == "") & (txbQuantityAddCLN.Text == ""))
            {
                prbStatusAddCLN.Value = 25;
            }
            if ((txbBrandAddCLN.Text == "") & (txbNameAddCLN.Text != "") & (txbPriceAddCLN.Text == "") & (txbQuantityAddCLN.Text == ""))
            {
                prbStatusAddCLN.Value = 25;
            }
            if ((txbBrandAddCLN.Text == "") & (txbNameAddCLN.Text == "") & (txbPriceAddCLN.Text != "") & (txbQuantityAddCLN.Text == ""))
            {
                prbStatusAddCLN.Value = 25;
            }
            if ((txbBrandAddCLN.Text == "") & (txbNameAddCLN.Text == "") & (txbPriceAddCLN.Text == "") & (txbQuantityAddCLN.Text != ""))
            {
                prbStatusAddCLN.Value = 25;
            }
            if ((txbBrandAddCLN.Text != "") & (txbNameAddCLN.Text != "") & (txbPriceAddCLN.Text == "") & (txbQuantityAddCLN.Text == ""))
            {
                prbStatusAddCLN.Value = 50;
            }
            if ((txbBrandAddCLN.Text != "") & (txbNameAddCLN.Text == "") & (txbPriceAddCLN.Text != "") & (txbQuantityAddCLN.Text == ""))
            {
                prbStatusAddCLN.Value = 50;
            }
            if ((txbBrandAddCLN.Text != "") & (txbNameAddCLN.Text == "") & (txbPriceAddCLN.Text == "") & (txbQuantityAddCLN.Text != ""))
            {
                prbStatusAddCLN.Value = 50;
            }
            if ((txbBrandAddCLN.Text == "") & (txbNameAddCLN.Text != "") & (txbPriceAddCLN.Text != "") & (txbQuantityAddCLN.Text == ""))
            {
                prbStatusAddCLN.Value = 50;
            }
            if ((txbBrandAddCLN.Text == "") & (txbNameAddCLN.Text != "") & (txbPriceAddCLN.Text == "") & (txbQuantityAddCLN.Text != ""))
            {
                prbStatusAddCLN.Value = 50;
            }
            if ((txbBrandAddCLN.Text == "") & (txbNameAddCLN.Text == "") & (txbPriceAddCLN.Text != "") & (txbQuantityAddCLN.Text != ""))
            {
                prbStatusAddCLN.Value = 50;
            }
            if ((txbBrandAddCLN.Text != "") & (txbNameAddCLN.Text != "") & (txbPriceAddCLN.Text != "") & (txbQuantityAddCLN.Text == ""))
            {
                prbStatusAddCLN.Value = 75;
            }
            if ((txbBrandAddCLN.Text != "") & (txbNameAddCLN.Text != "") & (txbPriceAddCLN.Text == "") & (txbQuantityAddCLN.Text != ""))
            {
                prbStatusAddCLN.Value = 75;
            }
            if ((txbBrandAddCLN.Text != "") & (txbNameAddCLN.Text == "") & (txbPriceAddCLN.Text != "") & (txbQuantityAddCLN.Text != ""))
            {
                prbStatusAddCLN.Value = 75;
            }
            if ((txbBrandAddCLN.Text == "") & (txbNameAddCLN.Text != "") & (txbPriceAddCLN.Text != "") & (txbQuantityAddCLN.Text != ""))
            {
                prbStatusAddCLN.Value = 75;
            }
        }

        private void StockAddFormCLN_Shown(object sender, EventArgs e)
        {
            tmrStockAddCLN.Enabled = true;
        }

        private void txbQuantityAddCLN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
