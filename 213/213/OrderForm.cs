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
    public partial class OrderForm : Form
    {
        private Action<object, EventArgs> roundButton3_Click;

        public OrderForm()
        {
            InitializeComponent();
            vScrollBar1.Minimum = 0;
            vScrollBar1.Maximum = dataGridView1Order.Height;
            hScrollBar1.Minimum = 0;
            hScrollBar1.Maximum = dataGridView1Order.Width;
        }

        public OrderForm(Action<object, EventArgs> roundButton3_Click)
        {
            this.roundButton3_Click = roundButton3_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Buttens
            POStockBtn7.Hide();
            POGOBtn8.Hide();
            SOBtn1.Show();
            POAOBtn11.Show();
            POROBtn12.Show();
            COBtn1.Hide();
            
            //Text box
            POTb2.Hide();
            POTb4.Hide();
            POTb5.Hide();
            POTb6.Hide();
            POTb7.Hide();
            POTb8.Hide();
            POTb9.Hide();
            POTb10.Hide();
            POTb12.Hide();
            POTb13.Hide();
            POTb14.Hide();
            POTb15.Hide();
            POTb16.Hide();
            POTb1.Show();
            POTb3.Show();
            POTbSn.Show();
            AmountTb1.Hide();
            POTbTel.Hide();
            
          
            //Lables
            POLb2.Hide();
            POLb4.Hide();
            POLb5.Hide();
            POLb6.Hide();
            POLb7.Hide();
            POLb8.Hide();
            POLb10.Hide();
            POLb11.Hide();
            POLb12.Hide();
            POLb13.Hide();
            POLb14.Hide();
            POLb1.Show();
            POLb3.Show();
            SNLb1.Show();
            AmountLb1.Hide();
            POLb15.Hide();
        }

        private void roundButton3(object sender, EventArgs e)
        {
            OrderForm OF2 = new OrderForm();
            
            
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }

        private void POBtn2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void POBtn1_Click(object sender, EventArgs e)
        {
            COBtn1.Hide();
            POStockBtn7.Show();
            POGOBtn8.Show();

            //Labels
            POLb1.Show();
            POLb2.Show();
            POLb3.Show();
            POLb4.Show();
            POLb5.Show();
            POLb6.Show();
            POLb7.Show();
            POLb8.Show();
            POLb9.Show();
            POLb10.Show();
            POLb11.Show();
            POLb12.Show();
            POLb13.Show();
            POLb14.Show();
            SNLb1.Show();
            AmountLb1.Show();
            POLb15.Show();

            //Text Boxes
            POTb1.Show();
            POTb2.Show();
            POTb3.Show();
            POTb4.Show();
            POTb5.Show();
            POTb6.Show();
            POTb7.Show();
            POTb8.Show();
            POTb9.Show();
            POTb10.Show();
            POTb11.Show();
            POTb12.Show();
            POTb13.Show();
            POTb14.Show();
            POTb15.Show();
            POTb16.Show();
            POTbSn.Show();
            AmountTb1.Show();
            POTbTel.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SOBtn1.Show();
            POTb1.Show();
            POTb3.Show();
            POTbSn.Show();
            POLb1.Show();
            POLb3.Show();
            SNLb1.Show();
            POAOBtn11.Hide();
            POROBtn12.Hide();
            COBtn1.Show();
            POLb15.Hide();
            POTbTel.Hide();

            // Toetsings proses
            POTb2.Hide();
            POTb4.Hide();
            POTb5.Hide();
            POTb6.Hide();
            POTb7.Hide();
            POTb8.Hide();
            POTb9.Hide();
            POTb10.Hide();
            POTb12.Hide();
            POTb13.Hide();
            POTb14.Hide();
            POTb15.Hide();
            POTb16.Hide();
            AmountTb1.Hide();

            POLb2.Hide();
            POLb4.Hide();
            POLb5.Hide();
            POLb6.Hide();
            POLb7.Hide();
            POLb8.Hide();
            POLb10.Hide();
            POLb11.Hide();
            POLb12.Hide();
            POLb13.Hide();
            POLb14.Hide();
            AmountLb1.Hide();


        }
    }
}
