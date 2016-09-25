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
    public partial class EndOfDay : Form
    {
        public EndOfDay()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("ORDERS REPORT\r\n");
            textBox1.AppendText("******************************\r\n");
            textBox1.AppendText("******************************\r\n");

            textBox1.AppendText("Total Orders Placed: \r\n");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("SALES REPORT\r\n");
            textBox1.AppendText("******************************\r\n");
            textBox1.AppendText("******************************\r\n");

            textBox1.AppendText("Total Sales Made: \r\n");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("STOCK REPORT\r\n");
            textBox1.AppendText("******************************\r\n");
            textBox1.AppendText("******************************\r\n");

            textBox1.AppendText("Total Stock Reduced: \r\n");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.AppendText("TRANSFERS REPORT\r\n");
            textBox1.AppendText("******************************\r\n");
            textBox1.AppendText("******************************\r\n");

            textBox1.AppendText("Total Transfers Pending: "+"To Branch: "+"\r\n");
            textBox1.AppendText("Total Transfers In-Tranzit: \r\n");
            textBox1.AppendText("Total Transfers Delivered: \r\n");
        }
    }
}
