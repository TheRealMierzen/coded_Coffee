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
            this.components = new System.ComponentModel.Container();
            this.cbxLayout = new System.Windows.Forms.ComboBox();
            this.gpbClient = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gpxtech = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrim = new System.Windows.Forms.ComboBox();
            this.txbID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMics = new System.Windows.Forms.TextBox();
            this.txtCpu = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPsu = new System.Windows.Forms.ComboBox();
            this.txtGpu = new System.Windows.Forms.ComboBox();
            this.txtRam = new System.Windows.Forms.ComboBox();
            this.txtmobo = new System.Windows.Forms.ComboBox();
            this.Cpu = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnQuote = new System.Windows.Forms.Button();
            this.btnPlaceorder = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.passTT = new System.Windows.Forms.ToolTip(this.components);
            this.gpbClient.SuspendLayout();
            this.gpxtech.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxLayout
            // 
            this.cbxLayout.FormattingEnabled = true;
            this.cbxLayout.Items.AddRange(new object[] {
            "Custom build",
            "Repairs"});
            this.cbxLayout.Location = new System.Drawing.Point(3, 3);
            this.cbxLayout.Name = "cbxLayout";
            this.cbxLayout.Size = new System.Drawing.Size(280, 21);
            this.cbxLayout.TabIndex = 0;
            this.cbxLayout.SelectedIndexChanged += new System.EventHandler(this.cbxLayout_SelectedIndexChanged);
            // 
            // gpbClient
            // 
            this.gpbClient.Controls.Add(this.txtEmail);
            this.gpbClient.Controls.Add(this.label6);
            this.gpbClient.Location = new System.Drawing.Point(3, 3);
            this.gpbClient.Name = "gpbClient";
            this.gpbClient.Size = new System.Drawing.Size(292, 110);
            this.gpbClient.TabIndex = 2;
            this.gpbClient.TabStop = false;
            this.gpbClient.Text = "Client info";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(62, 39);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(173, 20);
            this.txtEmail.TabIndex = 9;
            this.passTT.SetToolTip(this.txtEmail, "Please enter the Client\'s E-Mail.");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "E-Mail";
            // 
            // gpxtech
            // 
            this.gpxtech.Controls.Add(this.label3);
            this.gpxtech.Controls.Add(this.txtPrim);
            this.gpxtech.Controls.Add(this.txbID);
            this.gpxtech.Controls.Add(this.label15);
            this.gpxtech.Controls.Add(this.label1);
            this.gpxtech.Controls.Add(this.txtMics);
            this.gpxtech.Controls.Add(this.txtCpu);
            this.gpxtech.Controls.Add(this.label9);
            this.gpxtech.Controls.Add(this.txtPsu);
            this.gpxtech.Controls.Add(this.txtGpu);
            this.gpxtech.Controls.Add(this.txtRam);
            this.gpxtech.Controls.Add(this.txtmobo);
            this.gpxtech.Controls.Add(this.Cpu);
            this.gpxtech.Controls.Add(this.label13);
            this.gpxtech.Controls.Add(this.label12);
            this.gpxtech.Controls.Add(this.label11);
            this.gpxtech.Controls.Add(this.label10);
            this.gpxtech.Location = new System.Drawing.Point(3, 151);
            this.gpxtech.Name = "gpxtech";
            this.gpxtech.Size = new System.Drawing.Size(292, 417);
            this.gpxtech.TabIndex = 4;
            this.gpxtech.TabStop = false;
            this.gpxtech.Text = "Custom build";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Product ID/Barcode";
            // 
            // txtPrim
            // 
            this.txtPrim.Location = new System.Drawing.Point(9, 226);
            this.txtPrim.Name = "txtPrim";
            this.txtPrim.Size = new System.Drawing.Size(267, 21);
            this.txtPrim.TabIndex = 15;
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(9, 34);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(271, 20);
            this.txbID.TabIndex = 20;
            this.txbID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txbID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbID_KeyPress);
            this.txbID.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txbID_PreviewKeyDown);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 210);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Primary";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ram";
            // 
            // txtMics
            // 
            this.txtMics.Location = new System.Drawing.Point(9, 376);
            this.txtMics.Name = "txtMics";
            this.txtMics.Size = new System.Drawing.Size(267, 20);
            this.txtMics.TabIndex = 17;
            this.passTT.SetToolTip(this.txtMics, "Please enter the product id for Miscellaneous items like a computer case . If you" +
        " dont want this item the the custom build.");
            this.txtMics.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMics_KeyPress);
            // 
            // txtCpu
            // 
            this.txtCpu.Location = new System.Drawing.Point(6, 320);
            this.txtCpu.Name = "txtCpu";
            this.txtCpu.Size = new System.Drawing.Size(267, 21);
            this.txtCpu.TabIndex = 18;
            this.passTT.SetToolTip(this.txtCpu, "Please enter the product id for the Central prsessing unit . If you dont want thi" +
        "s item the the custom build.");
            this.txtCpu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCpu_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 360);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Miscellaneous ";
            // 
            // txtPsu
            // 
            this.txtPsu.Location = new System.Drawing.Point(5, 269);
            this.txtPsu.Name = "txtPsu";
            this.txtPsu.Size = new System.Drawing.Size(267, 21);
            this.txtPsu.TabIndex = 17;
            this.passTT.SetToolTip(this.txtPsu, "Please enter the product id for the power Supply . If you dont want this item the" +
        " the custom build.");
            this.txtPsu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPsu_KeyPress);
            // 
            // txtGpu
            // 
            this.txtGpu.Location = new System.Drawing.Point(6, 174);
            this.txtGpu.Name = "txtGpu";
            this.txtGpu.Size = new System.Drawing.Size(267, 21);
            this.txtGpu.TabIndex = 16;
            this.passTT.SetToolTip(this.txtGpu, "Please enter the product id for the Graphics card. If you dont want this item the" +
        " the custom build.\r\nEnter a zero (0).");
            this.txtGpu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGpu_KeyPress);
            // 
            // txtRam
            // 
            this.txtRam.Location = new System.Drawing.Point(9, 122);
            this.txtRam.Name = "txtRam";
            this.txtRam.Size = new System.Drawing.Size(267, 21);
            this.txtRam.TabIndex = 15;
            this.passTT.SetToolTip(this.txtRam, "Please enter the product id for the Ram . If you dont want this item the the cust" +
        "om build.\r\nEnter a zero (0).");
            this.txtRam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRam_KeyPress);
            // 
            // txtmobo
            // 
            this.txtmobo.Location = new System.Drawing.Point(9, 80);
            this.txtmobo.Name = "txtmobo";
            this.txtmobo.Size = new System.Drawing.Size(267, 21);
            this.txtmobo.TabIndex = 14;
            this.passTT.SetToolTip(this.txtmobo, "Please enter the product id for the . If you dont want this item the the custom b" +
        "uild.\r\nEnter a zero (0).");
            this.txtmobo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmobo_KeyPress);
            // 
            // Cpu
            // 
            this.Cpu.AutoSize = true;
            this.Cpu.Location = new System.Drawing.Point(6, 304);
            this.Cpu.Name = "Cpu";
            this.Cpu.Size = new System.Drawing.Size(113, 13);
            this.Cpu.TabIndex = 13;
            this.Cpu.Text = "Central prosessing unit";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 253);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Power Supply";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Graphics card";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Ram";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Motherboard";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Location = new System.Drawing.Point(430, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 21);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnQuote
            // 
            this.btnQuote.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnQuote.Location = new System.Drawing.Point(365, 151);
            this.btnQuote.Name = "btnQuote";
            this.btnQuote.Size = new System.Drawing.Size(75, 24);
            this.btnQuote.TabIndex = 6;
            this.btnQuote.Text = "Get Quote";
            this.btnQuote.UseVisualStyleBackColor = true;
            this.btnQuote.Click += new System.EventHandler(this.btnQuote_Click);
            // 
            // btnPlaceorder
            // 
            this.btnPlaceorder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlaceorder.Location = new System.Drawing.Point(365, 575);
            this.btnPlaceorder.Name = "btnPlaceorder";
            this.btnPlaceorder.Size = new System.Drawing.Size(75, 23);
            this.btnPlaceorder.TabIndex = 8;
            this.btnPlaceorder.Text = "Place Order";
            this.btnPlaceorder.UseVisualStyleBackColor = true;
            this.btnPlaceorder.Click += new System.EventHandler(this.btnPlaceorder_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtCost);
            this.groupBox2.Location = new System.Drawing.Point(301, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(194, 142);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cost of labour";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(28, 48);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(100, 20);
            this.txtCost.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 387F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cbxLayout, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBack, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(54, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(508, 34);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.gpxtech, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.gpbClient, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnQuote, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnPlaceorder, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(54, 56);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.96567F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.03433F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(508, 602);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // passTT
            // 
            this.passTT.AutoPopDelay = 5000;
            this.passTT.InitialDelay = 100;
            this.passTT.IsBalloon = true;
            this.passTT.ReshowDelay = 100;
            this.passTT.Tag = "";
            this.passTT.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.passTT.ToolTipTitle = "Custombuild help";
            // 
            // FrmTechnical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 688);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmTechnical";
            this.Text = "FrmTechnical";
            this.Load += new System.EventHandler(this.FrmTechnical_Load);
            this.gpbClient.ResumeLayout(false);
            this.gpbClient.PerformLayout();
            this.gpxtech.ResumeLayout(false);
            this.gpxtech.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxLayout;
        private System.Windows.Forms.GroupBox gpbClient;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gpxtech;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnQuote;
        private System.Windows.Forms.Button btnPlaceorder;
        private System.Windows.Forms.Label Cpu;
        private System.Windows.Forms.ComboBox txtCpu;
        private System.Windows.Forms.ComboBox txtPsu;
        private System.Windows.Forms.ComboBox txtGpu;
        private System.Windows.Forms.ComboBox txtRam;
        private System.Windows.Forms.ComboBox txtmobo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox txtPrim;
        private System.Windows.Forms.TextBox txtMics;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip passTT;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCost;
    }
}