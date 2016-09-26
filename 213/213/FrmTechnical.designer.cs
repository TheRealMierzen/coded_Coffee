namespace _213
{
    partial class FrmTechnical
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
            this.cbxLayout = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbClient = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gpxtech = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbnHard4 = new System.Windows.Forms.RadioButton();
            this.rbnHard3 = new System.Windows.Forms.RadioButton();
            this.rbnHard2 = new System.Windows.Forms.RadioButton();
            this.cbxPrimary = new System.Windows.Forms.ComboBox();
            this.cbxSecondary = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtXstras = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbxPowerSupply = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbxGpu = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbxRam = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxMotherboard = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMis = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnQuote = new System.Windows.Forms.Button();
            this.rtbQuote = new System.Windows.Forms.RichTextBox();
            this.btnPlaceorder = new System.Windows.Forms.Button();
            this.gpbClient.SuspendLayout();
            this.gpxtech.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxLayout
            // 
            this.cbxLayout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxLayout.FormattingEnabled = true;
            this.cbxLayout.Items.AddRange(new object[] {
            "Custom build",
            "Repairs"});
            this.cbxLayout.Location = new System.Drawing.Point(550, 14);
            this.cbxLayout.Name = "cbxLayout";
            this.cbxLayout.Size = new System.Drawing.Size(160, 21);
            this.cbxLayout.TabIndex = 0;
            this.cbxLayout.SelectedIndexChanged += new System.EventHandler(this.cbxLayout_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please choose what you want to do.";
            // 
            // gpbClient
            // 
            this.gpbClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gpbClient.Controls.Add(this.txtEmail);
            this.gpbClient.Controls.Add(this.txtName);
            this.gpbClient.Controls.Add(this.label6);
            this.gpbClient.Controls.Add(this.label2);
            this.gpbClient.Location = new System.Drawing.Point(11, 66);
            this.gpbClient.Name = "gpbClient";
            this.gpbClient.Size = new System.Drawing.Size(247, 90);
            this.gpbClient.TabIndex = 2;
            this.gpbClient.TabStop = false;
            this.gpbClient.Text = "Client info";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(100, 54);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(100, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "E-Mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // gpxtech
            // 
            this.gpxtech.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gpxtech.Controls.Add(this.groupBox1);
            this.gpxtech.Controls.Add(this.txtXstras);
            this.gpxtech.Controls.Add(this.label14);
            this.gpxtech.Controls.Add(this.cbxPowerSupply);
            this.gpxtech.Controls.Add(this.label13);
            this.gpxtech.Controls.Add(this.cbxGpu);
            this.gpxtech.Controls.Add(this.label12);
            this.gpxtech.Controls.Add(this.cbxRam);
            this.gpxtech.Controls.Add(this.label11);
            this.gpxtech.Controls.Add(this.cbxMotherboard);
            this.gpxtech.Controls.Add(this.label10);
            this.gpxtech.Controls.Add(this.txtMis);
            this.gpxtech.Controls.Add(this.label9);
            this.gpxtech.Location = new System.Drawing.Point(311, 66);
            this.gpxtech.Name = "gpxtech";
            this.gpxtech.Size = new System.Drawing.Size(406, 503);
            this.gpxtech.TabIndex = 4;
            this.gpxtech.TabStop = false;
            this.gpxtech.Text = "Custom build";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnHard4);
            this.groupBox1.Controls.Add(this.rbnHard3);
            this.groupBox1.Controls.Add(this.rbnHard2);
            this.groupBox1.Controls.Add(this.cbxPrimary);
            this.groupBox1.Controls.Add(this.cbxSecondary);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Location = new System.Drawing.Point(0, 312);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 185);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hard drives";
            // 
            // rbnHard4
            // 
            this.rbnHard4.AutoSize = true;
            this.rbnHard4.Location = new System.Drawing.Point(9, 147);
            this.rbnHard4.Name = "rbnHard4";
            this.rbnHard4.Size = new System.Drawing.Size(142, 17);
            this.rbnHard4.TabIndex = 17;
            this.rbnHard4.TabStop = true;
            this.rbnHard4.Text = "4 Secondary Hard drives";
            this.rbnHard4.UseVisualStyleBackColor = true;
            // 
            // rbnHard3
            // 
            this.rbnHard3.AutoSize = true;
            this.rbnHard3.Location = new System.Drawing.Point(9, 124);
            this.rbnHard3.Name = "rbnHard3";
            this.rbnHard3.Size = new System.Drawing.Size(142, 17);
            this.rbnHard3.TabIndex = 16;
            this.rbnHard3.TabStop = true;
            this.rbnHard3.Text = "3 Secondary Hard drives";
            this.rbnHard3.UseVisualStyleBackColor = true;
            // 
            // rbnHard2
            // 
            this.rbnHard2.AutoSize = true;
            this.rbnHard2.Location = new System.Drawing.Point(9, 100);
            this.rbnHard2.Name = "rbnHard2";
            this.rbnHard2.Size = new System.Drawing.Size(142, 17);
            this.rbnHard2.TabIndex = 15;
            this.rbnHard2.TabStop = true;
            this.rbnHard2.Text = "2 Secondary Hard drives";
            this.rbnHard2.UseVisualStyleBackColor = true;
            // 
            // cbxPrimary
            // 
            this.cbxPrimary.FormattingEnabled = true;
            this.cbxPrimary.Location = new System.Drawing.Point(6, 32);
            this.cbxPrimary.Name = "cbxPrimary";
            this.cbxPrimary.Size = new System.Drawing.Size(393, 21);
            this.cbxPrimary.TabIndex = 13;
            // 
            // cbxSecondary
            // 
            this.cbxSecondary.FormattingEnabled = true;
            this.cbxSecondary.Location = new System.Drawing.Point(6, 72);
            this.cbxSecondary.Name = "cbxSecondary";
            this.cbxSecondary.Size = new System.Drawing.Size(393, 21);
            this.cbxSecondary.TabIndex = 14;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 56);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 13);
            this.label16.TabIndex = 1;
            this.label16.Text = "Secondary";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 16);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Primary";
            // 
            // txtXstras
            // 
            this.txtXstras.Location = new System.Drawing.Point(7, 250);
            this.txtXstras.Multiline = true;
            this.txtXstras.Name = "txtXstras";
            this.txtXstras.Size = new System.Drawing.Size(393, 56);
            this.txtXstras.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 226);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Extras/notes";
            // 
            // cbxPowerSupply
            // 
            this.cbxPowerSupply.FormattingEnabled = true;
            this.cbxPowerSupply.Location = new System.Drawing.Point(7, 202);
            this.cbxPowerSupply.Name = "cbxPowerSupply";
            this.cbxPowerSupply.Size = new System.Drawing.Size(393, 21);
            this.cbxPowerSupply.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 185);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Power Supply";
            // 
            // cbxGpu
            // 
            this.cbxGpu.FormattingEnabled = true;
            this.cbxGpu.Location = new System.Drawing.Point(7, 161);
            this.cbxGpu.Name = "cbxGpu";
            this.cbxGpu.Size = new System.Drawing.Size(393, 21);
            this.cbxGpu.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Graphics card";
            // 
            // cbxRam
            // 
            this.cbxRam.FormattingEnabled = true;
            this.cbxRam.Location = new System.Drawing.Point(7, 120);
            this.cbxRam.Name = "cbxRam";
            this.cbxRam.Size = new System.Drawing.Size(393, 21);
            this.cbxRam.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Ram";
            // 
            // cbxMotherboard
            // 
            this.cbxMotherboard.FormattingEnabled = true;
            this.cbxMotherboard.Location = new System.Drawing.Point(7, 78);
            this.cbxMotherboard.Name = "cbxMotherboard";
            this.cbxMotherboard.Size = new System.Drawing.Size(393, 21);
            this.cbxMotherboard.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Motherboard";
            // 
            // txtMis
            // 
            this.txtMis.FormattingEnabled = true;
            this.txtMis.Location = new System.Drawing.Point(7, 37);
            this.txtMis.Name = "txtMis";
            this.txtMis.Size = new System.Drawing.Size(393, 21);
            this.txtMis.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Computer Case";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(11, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnQuote
            // 
            this.btnQuote.Location = new System.Drawing.Point(452, 575);
            this.btnQuote.Name = "btnQuote";
            this.btnQuote.Size = new System.Drawing.Size(75, 23);
            this.btnQuote.TabIndex = 6;
            this.btnQuote.Text = "Get Quote";
            this.btnQuote.UseVisualStyleBackColor = true;
            this.btnQuote.Click += new System.EventHandler(this.btnQuote_Click);
            // 
            // rtbQuote
            // 
            this.rtbQuote.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtbQuote.Location = new System.Drawing.Point(741, 69);
            this.rtbQuote.Name = "rtbQuote";
            this.rtbQuote.ReadOnly = true;
            this.rtbQuote.Size = new System.Drawing.Size(268, 500);
            this.rtbQuote.TabIndex = 7;
            this.rtbQuote.Text = "Quote for custom build ";
            // 
            // btnPlaceorder
            // 
            this.btnPlaceorder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlaceorder.Location = new System.Drawing.Point(848, 575);
            this.btnPlaceorder.Name = "btnPlaceorder";
            this.btnPlaceorder.Size = new System.Drawing.Size(75, 23);
            this.btnPlaceorder.TabIndex = 8;
            this.btnPlaceorder.Text = "Place Order";
            this.btnPlaceorder.UseVisualStyleBackColor = true;
            // 
            // FrmTechnical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 604);
            this.Controls.Add(this.btnPlaceorder);
            this.Controls.Add(this.rtbQuote);
            this.Controls.Add(this.btnQuote);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gpxtech);
            this.Controls.Add(this.gpbClient);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxLayout);
            this.Name = "FrmTechnical";
            this.Text = "FrmTechnical";
            this.Activated += new System.EventHandler(this.FrmTechnical_Activated);
            this.Load += new System.EventHandler(this.FrmTechnical_Load);
            this.gpbClient.ResumeLayout(false);
            this.gpbClient.PerformLayout();
            this.gpxtech.ResumeLayout(false);
            this.gpxtech.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxLayout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbClient;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gpxtech;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbxPowerSupply;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbxGpu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbxRam;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbxMotherboard;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox txtMis;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtXstras;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cbxPrimary;
        private System.Windows.Forms.ComboBox cbxSecondary;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RadioButton rbnHard4;
        private System.Windows.Forms.RadioButton rbnHard3;
        private System.Windows.Forms.RadioButton rbnHard2;
        private System.Windows.Forms.Button btnQuote;
        private System.Windows.Forms.RichTextBox rtbQuote;
        private System.Windows.Forms.Button btnPlaceorder;
    }
}