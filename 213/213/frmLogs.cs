using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _213
{
    public partial class frmLogs : Form
    {
        public frmLogs()
        {
            InitializeComponent();
        }

        public frmLogs(string p)
        {
            InitializeComponent();

            path = p;
        }

        string path;
        private void frmLogs_Load(object sender, EventArgs e)
        {

            if (File.Exists(path))
            {

                txtLog.AppendText(File.ReadAllText(path));
                File.SetAttributes(path, File.GetAttributes(path) | FileAttributes.Hidden | FileAttributes.ReadOnly);

            }
            else
            {

                MessageBox.Show("Something went wrong and the activity log is missing.","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }

        }

    }
}
