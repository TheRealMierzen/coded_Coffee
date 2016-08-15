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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dit werk");
        }

        private void btnSelectedView_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dit werk");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
