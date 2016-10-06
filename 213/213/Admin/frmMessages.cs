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
    public partial class frmMessages : Form
    {
        public frmMessages()
        {
            InitializeComponent();
        }

        public frmMessages(string message, string type, MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            InitializeComponent();
            delay.Start();

            MessageBox.Show(message, type, buttons, icon);

        }
    }
}
