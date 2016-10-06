namespace _213
{
    partial class frmManual
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.wbManual = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // wbManual
            // 
            this.wbManual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbManual.Location = new System.Drawing.Point(0, 0);
            this.wbManual.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbManual.Name = "wbManual";
            this.wbManual.Size = new System.Drawing.Size(866, 528);
            this.wbManual.TabIndex = 0;
            // 
            // frmManual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 528);
            this.Controls.Add(this.wbManual);
            this.Name = "frmManual";
            this.Text = "frmManual";
            this.Load += new System.EventHandler(this.frmManual_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbManual;
    }
}