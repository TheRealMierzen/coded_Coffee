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
    public partial class EndOfDAy : Form
    {
        public EndOfDAy()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Sales option
            if(comboBox1.Items.Equals(1))
            {

            }
            //Orders option
            if(comboBox1.Items.Equals(2))
            {

            }
            //Stock option
            if(comboBox1.Items.Equals(3))
            {

            }
            else
            {
                MessageBox.Show("Incorect option!!! Please choose again");
            }
        }
    }
}
