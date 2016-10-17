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
using System.Diagnostics;

namespace _213
{
    public partial class frmManual : Form
    {
        public frmManual()
        {
            InitializeComponent();

        }

        public frmManual(int p)
        {
            InitializeComponent();
            page = p;

        }
        int page;
        private void frmManual_Load(object sender, EventArgs e)
        {

            using (Stream file = File.Create(AppDomain.CurrentDomain.BaseDirectory + @"\Manual.pdf"))
            { }

            //File.WriteAllBytes(AppDomain.CurrentDomain.BaseDirectory + @"\Manual.pdf",/*Properties.Resources.Bewys_van_registrasie*/);
           
            RenderPdf(AppDomain.CurrentDomain.BaseDirectory + "Manual.pdf");
            
        }

        private void RenderPdf(string filePath, int page)
        {
            if (!string.IsNullOrWhiteSpace(filePath))
            {
                wbManual.Navigate(@filePath + "#page=" + page.ToString());
            }
        }

        private void RenderPdf(string filePath)
        {
            if (!string.IsNullOrWhiteSpace(filePath))
            {
                wbManual.Navigate(@filePath);
            }
        }
    }
}
