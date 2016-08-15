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
    public partial class StockTakeForm : Form
    {
        public StockTakeForm()
        {
            InitializeComponent();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StockMainFormCLN smf = new StockMainFormCLN();
            this.Hide();
            smf.Show();
        }
    }
}
