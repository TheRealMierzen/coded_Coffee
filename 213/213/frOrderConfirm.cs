using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _213
{
    public partial class frOrderConfirm : Form
    {
        public frOrderConfirm()
        {
            InitializeComponent();
        }

        private void frOrderConfirm_Load(object sender, EventArgs e)
        {
            gebruik util = new gebruik();
            txtDayOrders.Text = util.getDayOrders(DateTime.Now.Date.ToString());
        }

        private void btnConfirmO_Click(object sender, EventArgs e)
        {

            gebruik util = new gebruik();
            //verander net die voor toets
            util.sendOrders(txtDayOrders.Text, "wiesupplieris", "supplier@gmail.com");


        }
    }
}
