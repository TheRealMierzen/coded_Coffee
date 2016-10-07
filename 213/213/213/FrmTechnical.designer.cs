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
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gpxtech = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMics = new System.Windows.Forms.TextBox();
            this.txtCpu = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPsu = new System.Windows.Forms.TextBox();
            this.txtGpu = new System.Windows.Forms.TextBox();
            this.txtRam = new System.Windows.Forms.TextBox();
            this.txtmobo = new System.Windows.Forms.TextBox();
            this.Cpu = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSec = new System.Windows.Forms.TextBox();
            this.txtPrim = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtXstras = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnQuote = new System.Windows.Forms.Button();
            this.btnPlaceorder = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lbxoutput = new System.Windows.Forms.ListBox();
            this.passTT = new System.Windows.Forms.ToolTip(this.components);
            this.gpbClient.SuspendLayout();
            this.gpxtech.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxLayout
            // 
            this.cbxLayout.FormattingEnabled = true;
            this.cbxLayout.Items.AddRange(new object[] {
            "Custom build",
            "Repairs"});
            this.cbxLayout.Location = new System.Drawing.Point(4, 4);
            this.cbxLayout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxLayout.Name = "cbxLayout";
            this.cbxLayout.Size = new System.Drawing.Size(372, 24);
            this.cbxLayout.TabIndex = 0;
            this.cbxLayout.SelectedIndexChanged += new System.EventHandler(this.cbxLayout_SelectedIndexChanged);
            // 
            // gpbClient
            // 
            this.gpbClient.Controls.Add(this.txtEmail);
            this.gpbClient.Controls.Add(this.txtName);
            this.gpbClient.Controls.Add(this.label6);
            this.gpbClient.Controls.Add(this.label2);
            this.gpbClient.Location = new System.Drawing.Point(4, 4);
            this.gpbClient.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbClient.Name = "gpbClient";
            this.gpbClient.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpbClient.Size = new System.Drawing.Size(389, 135);
            this.gpbClient.TabIndex = 2;
            this.gpbClient.TabStop = false;
            this.gpbClient.Text = "Client info";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(133, 89);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(229, 22);
            this.txtEmail.TabIndex = 9;
            this.passTT.SetToolTip(this.txtEmail, "Please enter the Client\'s E-Mail.");
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(135, 39);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(229, 22);
            this.txtName.TabIndex = 5;
            this.passTT.SetToolTip(this.txtName, "Please enter the Client\'s name.");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 97);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "E-Mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // gpxtech
            // 
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
            this.gpxtech.Location = new System.Drawing.Point(4, 186);
            this.gpxtech.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpxtech.Name = "gpxtech";
            this.gpxtech.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gpxtech.Size = new System.Drawing.Size(389, 443);
            this.gpxtech.TabIndex = 4;
            this.gpxtech.TabStop = false;
            this.gpxtech.Text = "Custom build";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 96);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ram";
            // 
            // txtMics
            // 
            this.txtMics.Location = new System.Drawing.Point(12, 400);
            this.txtMics.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMics.Name = "txtMics";
            this.txtMics.Size = new System.Drawing.Size(355, 22);
            this.txtMics.TabIndex = 17;
            this.passTT.SetToolTip(this.txtMics, "Please enter the product id for Miscellaneous items like a computer case . If you" +
        " dont want this item the the custom build.");
            this.txtMics.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMics_KeyPress);
            // 
            // txtCpu
            // 
            this.txtCpu.Location = new System.Drawing.Point(8, 331);
            this.txtCpu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCpu.Name = "txtCpu";
            this.txtCpu.Size = new System.Drawing.Size(355, 22);
            this.txtCpu.TabIndex = 18;
            this.passTT.SetToolTip(this.txtCpu, "Please enter the product id for the Central prsessing unit . If you dont want thi" +
        "s item the the custom build.");
            this.txtCpu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCpu_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 380);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Miscellaneous ";
            // 
            // txtPsu
            // 
            this.txtPsu.Location = new System.Drawing.Point(7, 268);
            this.txtPsu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPsu.Name = "txtPsu";
            this.txtPsu.Size = new System.Drawing.Size(355, 22);
            this.txtPsu.TabIndex = 17;
            this.passTT.SetToolTip(this.txtPsu, "Please enter the product id for the power Supply . If you dont want this item the" +
        " the custom build.");
            this.txtPsu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPsu_KeyPress);
            // 
            // txtGpu
            // 
            this.txtGpu.Location = new System.Drawing.Point(8, 180);
            this.txtGpu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGpu.Name = "txtGpu";
            this.txtGpu.Size = new System.Drawing.Size(355, 22);
            this.txtGpu.TabIndex = 16;
            this.passTT.SetToolTip(this.txtGpu, "Please enter the product id for the Graphics card. If you dont want this item the" +
        " the custom build.\r\nEnter a zero (0).");
            this.txtGpu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGpu_KeyPress);
            // 
            // txtRam
            // 
            this.txtRam.Location = new System.Drawing.Point(12, 116);
            this.txtRam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRam.Name = "txtRam";
            this.txtRam.Size = new System.Drawing.Size(355, 22);
            this.txtRam.TabIndex = 15;
            this.passTT.SetToolTip(this.txtRam, "Please enter the product id for the Ram . If you dont want this item the the cust" +
        "om build.\r\nEnter a zero (0).");
            this.txtRam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRam_KeyPress);
            // 
            // txtmobo
            // 
            this.txtmobo.Location = new System.Drawing.Point(12, 54);
            this.txtmobo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmobo.Name = "txtmobo";
            this.txtmobo.Size = new System.Drawing.Size(355, 22);
            this.txtmobo.TabIndex = 14;
            this.passTT.SetToolTip(this.txtmobo, "Please enter the product id for the . If you dont want this item the the custom b" +
        "uild.\r\nEnter a zero (0).");
            this.txtmobo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtmobo_KeyPress);
            // 
            // Cpu
            // 
            this.Cpu.AutoSize = true;
            this.Cpu.Location = new System.Drawing.Point(8, 311);
            this.Cpu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cpu.Name = "Cpu";
            this.Cpu.Size = new System.Drawing.Size(153, 17);
            this.Cpu.TabIndex = 13;
            this.Cpu.Text = "Central prosessing unit";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 236);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 17);
            this.label13.TabIndex = 8;
            this.label13.Text = "Power Supply";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 155);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 17);
            this.label12.TabIndex = 6;
            this.label12.Text = "Graphics card";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 191);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 17);
            this.label11.TabIndex = 4;
            this.label11.Text = "Ram";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 34);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 17);
            this.label10.TabIndex = 2;
            this.label10.Text = "Motherboard";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSec);
            this.groupBox1.Controls.Add(this.txtPrim);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Location = new System.Drawing.Point(401, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(461, 135);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hard drives";
            // 
            // txtSec
            // 
            this.txtSec.Location = new System.Drawing.Point(12, 89);
            this.txtSec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSec.Name = "txtSec";
            this.txtSec.Size = new System.Drawing.Size(355, 22);
            this.txtSec.TabIndex = 16;
            // 
            // txtPrim
            // 
            this.txtPrim.Location = new System.Drawing.Point(12, 39);
            this.txtPrim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrim.Name = "txtPrim";
            this.txtPrim.Size = new System.Drawing.Size(355, 22);
            this.txtPrim.TabIndex = 15;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 69);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 17);
            this.label16.TabIndex = 1;
            this.label16.Text = "Secondary";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 20);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "Primary";
            // 
            // txtXstras
            // 
            this.txtXstras.Location = new System.Drawing.Point(8, 59);
            this.txtXstras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtXstras.Multiline = true;
            this.txtXstras.Name = "txtXstras";
            this.txtXstras.Size = new System.Drawing.Size(412, 393);
            this.txtXstras.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 28);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(86, 17);
            this.label14.TabIndex = 10;
            this.label14.Text = "Extras/notes";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Location = new System.Drawing.Point(1313, 4);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 26);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnQuote
            // 
            this.btnQuote.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnQuote.Location = new System.Drawing.Point(660, 706);
            this.btnQuote.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuote.Name = "btnQuote";
            this.btnQuote.Size = new System.Drawing.Size(100, 30);
            this.btnQuote.TabIndex = 6;
            this.btnQuote.Text = "Get Quote";
            this.btnQuote.UseVisualStyleBackColor = true;
            this.btnQuote.Click += new System.EventHandler(this.btnQuote_Click);
            // 
            // btnPlaceorder
            // 
            this.btnPlaceorder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlaceorder.Location = new System.Drawing.Point(148, 707);
            this.btnPlaceorder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlaceorder.Name = "btnPlaceorder";
            this.btnPlaceorder.Size = new System.Drawing.Size(100, 28);
            this.btnPlaceorder.TabIndex = 8;
            this.btnPlaceorder.Text = "Place Order";
            this.btnPlaceorder.UseVisualStyleBackColor = true;
            this.btnPlaceorder.Click += new System.EventHandler(this.btnPlaceorder_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtXstras);
            this.groupBox2.Location = new System.Drawing.Point(401, 186);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(461, 482);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 516F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.cbxLayout, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBack, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(72, 15);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 151F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1417, 42);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.gpxtech, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.gpbClient, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnQuote, 1, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(72, 69);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.96567F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.03433F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1023, 741);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.btnPlaceorder, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbxoutput, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(1092, 69);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 702F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(397, 741);
            this.tableLayoutPanel3.TabIndex = 16;
            // 
            // lbxoutput
            // 
            this.lbxoutput.FormattingEnabled = true;
            this.lbxoutput.ItemHeight = 16;
            this.lbxoutput.Location = new System.Drawing.Point(4, 4);
            this.lbxoutput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbxoutput.Name = "lbxoutput";
            this.lbxoutput.Size = new System.Drawing.Size(159, 116);
            this.lbxoutput.TabIndex = 9;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1517, 847);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxLayout;
        private System.Windows.Forms.GroupBox gpbClient;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gpxtech;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtXstras;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnQuote;
        private System.Windows.Forms.Button btnPlaceorder;
        private System.Windows.Forms.Label Cpu;
        private System.Windows.Forms.TextBox txtCpu;
        private System.Windows.Forms.TextBox txtPsu;
        private System.Windows.Forms.TextBox txtGpu;
        private System.Windows.Forms.TextBox txtRam;
        private System.Windows.Forms.TextBox txtmobo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSec;
        private System.Windows.Forms.TextBox txtPrim;
        private System.Windows.Forms.TextBox txtMics;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ToolTip passTT;
        private System.Windows.Forms.ListBox lbxoutput;
    }
}