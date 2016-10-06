namespace _213
{
    partial class frmAdminPromos
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
            this.cbItem = new System.Windows.Forms.ComboBox();
            this.txtOriginalPrice = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.dtPromoStart = new System.Windows.Forms.DateTimePicker();
            this.dtPromoEnd = new System.Windows.Forms.DateTimePicker();
            this.txtPromoId = new System.Windows.Forms.TextBox();
            this.txtDisPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbNItem = new System.Windows.Forms.GroupBox();
            this.txtAmount = new wmgCMS.WaterMarkTextBox();
            this.gbNPromo = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCancelPromo = new System.Windows.Forms.Button();
            this.btnAddPromo = new System.Windows.Forms.Button();
            this.cbAction = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gbEItem = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lblPromoID = new System.Windows.Forms.Label();
            this.txtEQ = new wmgCMS.WaterMarkTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEPromoItem = new System.Windows.Forms.TextBox();
            this.cbEID = new System.Windows.Forms.ComboBox();
            this.gbEPromo = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEDP = new System.Windows.Forms.TextBox();
            this.txtEOri = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtEDPP = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.dtEStart = new System.Windows.Forms.DateTimePicker();
            this.dtEEnd = new System.Windows.Forms.DateTimePicker();
            this.btnUPromo = new System.Windows.Forms.Button();
            this.passTT = new System.Windows.Forms.ToolTip(this.components);
            this.lblMax = new System.Windows.Forms.Label();
            this.gbNItem.SuspendLayout();
            this.gbNPromo.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbEItem.SuspendLayout();
            this.gbEPromo.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbItem
            // 
            this.cbItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbItem.FormattingEnabled = true;
            this.cbItem.Location = new System.Drawing.Point(208, 65);
            this.cbItem.Name = "cbItem";
            this.cbItem.Size = new System.Drawing.Size(200, 24);
            this.cbItem.Sorted = true;
            this.cbItem.TabIndex = 3;
            this.passTT.SetToolTip(this.cbItem, "Select the item you wish to place on promotion here.\r\n\r\n*Note only items that are" +
        " not currently listed in a promotion\r\nwill be listed here.");
            this.cbItem.SelectedIndexChanged += new System.EventHandler(this.cbItem_SelectedIndexChanged);
            // 
            // txtOriginalPrice
            // 
            this.txtOriginalPrice.Enabled = false;
            this.txtOriginalPrice.Location = new System.Drawing.Point(290, 28);
            this.txtOriginalPrice.Name = "txtOriginalPrice";
            this.txtOriginalPrice.Size = new System.Drawing.Size(100, 22);
            this.txtOriginalPrice.TabIndex = 7;
            this.passTT.SetToolTip(this.txtOriginalPrice, "Original price of item");
            // 
            // txtDiscount
            // 
            this.txtDiscount.Enabled = false;
            this.txtDiscount.Location = new System.Drawing.Point(290, 84);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(100, 22);
            this.txtDiscount.TabIndex = 9;
            this.passTT.SetToolTip(this.txtDiscount, "The percentage discount the item will have");
            // 
            // dtPromoStart
            // 
            this.dtPromoStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPromoStart.Location = new System.Drawing.Point(208, 29);
            this.dtPromoStart.Name = "dtPromoStart";
            this.dtPromoStart.Size = new System.Drawing.Size(200, 22);
            this.dtPromoStart.TabIndex = 5;
            this.passTT.SetToolTip(this.dtPromoStart, "Select the start date of the promotion");
            this.dtPromoStart.ValueChanged += new System.EventHandler(this.dtPromoStart_ValueChanged);
            // 
            // dtPromoEnd
            // 
            this.dtPromoEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPromoEnd.Location = new System.Drawing.Point(208, 58);
            this.dtPromoEnd.Name = "dtPromoEnd";
            this.dtPromoEnd.Size = new System.Drawing.Size(200, 22);
            this.dtPromoEnd.TabIndex = 6;
            this.passTT.SetToolTip(this.dtPromoEnd, "Select the end date of the promotion");
            // 
            // txtPromoId
            // 
            this.txtPromoId.Location = new System.Drawing.Point(208, 31);
            this.txtPromoId.MaxLength = 10;
            this.txtPromoId.Name = "txtPromoId";
            this.txtPromoId.Size = new System.Drawing.Size(200, 22);
            this.txtPromoId.TabIndex = 2;
            this.passTT.SetToolTip(this.txtPromoId, "Promotion id of new promotion");
            // 
            // txtDisPrice
            // 
            this.txtDisPrice.Location = new System.Drawing.Point(290, 56);
            this.txtDisPrice.Name = "txtDisPrice";
            this.txtDisPrice.Size = new System.Drawing.Size(100, 22);
            this.txtDisPrice.TabIndex = 8;
            this.passTT.SetToolTip(this.txtDisPrice, "Enter the price of the item whilst on promotion");
            this.txtDisPrice.TextChanged += new System.EventHandler(this.txtDisPrice_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Promotion ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Promotion item:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quantity on promotion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Original price:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Discounted price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Discount percentage:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Promotion start date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Promotion end date:";
            // 
            // gbNItem
            // 
            this.gbNItem.Controls.Add(this.label1);
            this.gbNItem.Controls.Add(this.cbItem);
            this.gbNItem.Controls.Add(this.txtAmount);
            this.gbNItem.Controls.Add(this.txtPromoId);
            this.gbNItem.Controls.Add(this.label2);
            this.gbNItem.Controls.Add(this.label3);
            this.gbNItem.Location = new System.Drawing.Point(12, 58);
            this.gbNItem.Name = "gbNItem";
            this.gbNItem.Size = new System.Drawing.Size(454, 147);
            this.gbNItem.TabIndex = 16;
            this.gbNItem.TabStop = false;
            this.gbNItem.Text = "Item details";
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txtAmount.Location = new System.Drawing.Point(208, 104);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(200, 22);
            this.txtAmount.TabIndex = 4;
            this.passTT.SetToolTip(this.txtAmount, "Enter the quantity of the item you wish to place on \r\npromotion (cannot be more t" +
        "han there are in stock)");
            this.txtAmount.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtAmount.WaterMarkText = "Max: ";
            this.txtAmount.TextChanged += new System.EventHandler(this.txtAmount_TextChanged);
            // 
            // gbNPromo
            // 
            this.gbNPromo.Controls.Add(this.groupBox3);
            this.gbNPromo.Controls.Add(this.label7);
            this.gbNPromo.Controls.Add(this.label8);
            this.gbNPromo.Controls.Add(this.dtPromoStart);
            this.gbNPromo.Controls.Add(this.dtPromoEnd);
            this.gbNPromo.Location = new System.Drawing.Point(12, 211);
            this.gbNPromo.Name = "gbNPromo";
            this.gbNPromo.Size = new System.Drawing.Size(454, 239);
            this.gbNPromo.TabIndex = 17;
            this.gbNPromo.TabStop = false;
            this.gbNPromo.Text = "Promotion details";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtDisPrice);
            this.groupBox3.Controls.Add(this.txtOriginalPrice);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtDiscount);
            this.groupBox3.Location = new System.Drawing.Point(6, 101);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(439, 119);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pricing details";
            // 
            // btnCancelPromo
            // 
            this.btnCancelPromo.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelPromo.Location = new System.Drawing.Point(240, 462);
            this.btnCancelPromo.Name = "btnCancelPromo";
            this.btnCancelPromo.Size = new System.Drawing.Size(149, 36);
            this.btnCancelPromo.TabIndex = 11;
            this.btnCancelPromo.Text = "Cancel";
            this.passTT.SetToolTip(this.btnCancelPromo, "Click to close this window");
            this.btnCancelPromo.UseVisualStyleBackColor = true;
            // 
            // btnAddPromo
            // 
            this.btnAddPromo.Enabled = false;
            this.btnAddPromo.Location = new System.Drawing.Point(72, 462);
            this.btnAddPromo.Name = "btnAddPromo";
            this.btnAddPromo.Size = new System.Drawing.Size(149, 36);
            this.btnAddPromo.TabIndex = 10;
            this.btnAddPromo.Text = "Add promotion";
            this.passTT.SetToolTip(this.btnAddPromo, "Click to add new promotion");
            this.btnAddPromo.UseVisualStyleBackColor = true;
            this.btnAddPromo.Click += new System.EventHandler(this.btnAddPromo_Click);
            // 
            // cbAction
            // 
            this.cbAction.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbAction.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbAction.FormattingEnabled = true;
            this.cbAction.Items.AddRange(new object[] {
            "Edit promotion",
            "New promotion"});
            this.cbAction.Location = new System.Drawing.Point(220, 22);
            this.cbAction.Name = "cbAction";
            this.cbAction.Size = new System.Drawing.Size(136, 24);
            this.cbAction.Sorted = true;
            this.cbAction.TabIndex = 1;
            this.passTT.SetToolTip(this.cbAction, "Select action you want to perform");
            this.cbAction.SelectedIndexChanged += new System.EventHandler(this.cbAction_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Please select an action:";
            // 
            // gbEItem
            // 
            this.gbEItem.Controls.Add(this.lblMax);
            this.gbEItem.Controls.Add(this.label17);
            this.gbEItem.Controls.Add(this.lblPromoID);
            this.gbEItem.Controls.Add(this.txtEQ);
            this.gbEItem.Controls.Add(this.label10);
            this.gbEItem.Controls.Add(this.txtEPromoItem);
            this.gbEItem.Controls.Add(this.cbEID);
            this.gbEItem.Location = new System.Drawing.Point(12, 58);
            this.gbEItem.Name = "gbEItem";
            this.gbEItem.Size = new System.Drawing.Size(454, 147);
            this.gbEItem.TabIndex = 16;
            this.gbEItem.TabStop = false;
            this.gbEItem.Text = "Item details";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(12, 67);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(106, 17);
            this.label17.TabIndex = 0;
            this.label17.Text = "Promotion item:";
            // 
            // lblPromoID
            // 
            this.lblPromoID.AutoSize = true;
            this.lblPromoID.Location = new System.Drawing.Point(12, 34);
            this.lblPromoID.Name = "lblPromoID";
            this.lblPromoID.Size = new System.Drawing.Size(93, 17);
            this.lblPromoID.TabIndex = 0;
            this.lblPromoID.Text = "Promotion ID:";
            // 
            // txtEQ
            // 
            this.txtEQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txtEQ.Location = new System.Drawing.Point(208, 104);
            this.txtEQ.Name = "txtEQ";
            this.txtEQ.Size = new System.Drawing.Size(200, 22);
            this.txtEQ.TabIndex = 5;
            this.passTT.SetToolTip(this.txtEQ, "Enter the quantity of the item you wish to place on ");
            this.txtEQ.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtEQ.WaterMarkText = "";
            this.txtEQ.TextChanged += new System.EventHandler(this.txtEQ_TextChanged);
            this.txtEQ.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEQ_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Quantity on promotion:";
            // 
            // txtEPromoItem
            // 
            this.txtEPromoItem.Enabled = false;
            this.txtEPromoItem.Location = new System.Drawing.Point(208, 69);
            this.txtEPromoItem.Name = "txtEPromoItem";
            this.txtEPromoItem.Size = new System.Drawing.Size(200, 22);
            this.txtEPromoItem.TabIndex = 1;
            this.passTT.SetToolTip(this.txtEPromoItem, "The item on promotion");
            // 
            // cbEID
            // 
            this.cbEID.FormattingEnabled = true;
            this.cbEID.Location = new System.Drawing.Point(208, 31);
            this.cbEID.Name = "cbEID";
            this.cbEID.Size = new System.Drawing.Size(200, 24);
            this.cbEID.TabIndex = 0;
            this.passTT.SetToolTip(this.cbEID, "Select the promotion you wish to update");
            this.cbEID.SelectedIndexChanged += new System.EventHandler(this.cbEID_SelectedIndexChanged);
            // 
            // gbEPromo
            // 
            this.gbEPromo.Controls.Add(this.groupBox6);
            this.gbEPromo.Controls.Add(this.label14);
            this.gbEPromo.Controls.Add(this.label15);
            this.gbEPromo.Controls.Add(this.dtEStart);
            this.gbEPromo.Controls.Add(this.dtEEnd);
            this.gbEPromo.Location = new System.Drawing.Point(12, 211);
            this.gbEPromo.Name = "gbEPromo";
            this.gbEPromo.Size = new System.Drawing.Size(454, 239);
            this.gbEPromo.TabIndex = 17;
            this.gbEPromo.TabStop = false;
            this.gbEPromo.Text = "Promotion details";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.txtEDP);
            this.groupBox6.Controls.Add(this.txtEOri);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.txtEDPP);
            this.groupBox6.Location = new System.Drawing.Point(6, 101);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(439, 119);
            this.groupBox6.TabIndex = 16;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Pricing details";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Original price:";
            // 
            // txtEDP
            // 
            this.txtEDP.Location = new System.Drawing.Point(290, 56);
            this.txtEDP.Name = "txtEDP";
            this.txtEDP.Size = new System.Drawing.Size(100, 22);
            this.txtEDP.TabIndex = 7;
            this.passTT.SetToolTip(this.txtEDP, "Enter the price of the item whilst on promotion");
            this.txtEDP.TextChanged += new System.EventHandler(this.txtEDP_TextChanged);
            this.txtEDP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEDP_KeyPress);
            // 
            // txtEOri
            // 
            this.txtEOri.Enabled = false;
            this.txtEOri.Location = new System.Drawing.Point(290, 28);
            this.txtEOri.Name = "txtEOri";
            this.txtEOri.Size = new System.Drawing.Size(100, 22);
            this.txtEOri.TabIndex = 6;
            this.passTT.SetToolTip(this.txtEOri, "Original price of item");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Discounted price:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(143, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Discount percentage:";
            // 
            // txtEDPP
            // 
            this.txtEDPP.Enabled = false;
            this.txtEDPP.Location = new System.Drawing.Point(290, 84);
            this.txtEDPP.Name = "txtEDPP";
            this.txtEDPP.Size = new System.Drawing.Size(100, 22);
            this.txtEDPP.TabIndex = 8;
            this.passTT.SetToolTip(this.txtEDPP, "The percentage discount the item will have");
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(140, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Promotion start date:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(136, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "Promotion end date:";
            // 
            // dtEStart
            // 
            this.dtEStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEStart.Location = new System.Drawing.Point(208, 29);
            this.dtEStart.Name = "dtEStart";
            this.dtEStart.Size = new System.Drawing.Size(200, 22);
            this.dtEStart.TabIndex = 4;
            this.passTT.SetToolTip(this.dtEStart, "Select the start date of the promotion");
            this.dtEStart.ValueChanged += new System.EventHandler(this.dtEStart_ValueChanged);
            // 
            // dtEEnd
            // 
            this.dtEEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEEnd.Location = new System.Drawing.Point(208, 58);
            this.dtEEnd.Name = "dtEEnd";
            this.dtEEnd.Size = new System.Drawing.Size(200, 22);
            this.dtEEnd.TabIndex = 5;
            this.passTT.SetToolTip(this.dtEEnd, "Select the end date of the promotion");
            // 
            // btnUPromo
            // 
            this.btnUPromo.Enabled = false;
            this.btnUPromo.Location = new System.Drawing.Point(72, 462);
            this.btnUPromo.Name = "btnUPromo";
            this.btnUPromo.Size = new System.Drawing.Size(149, 36);
            this.btnUPromo.TabIndex = 10;
            this.btnUPromo.Text = "Update promotion";
            this.passTT.SetToolTip(this.btnUPromo, "Click to update promotion");
            this.btnUPromo.UseVisualStyleBackColor = true;
            this.btnUPromo.Click += new System.EventHandler(this.btnUPromo_Click);
            // 
            // passTT
            // 
            this.passTT.AutoPopDelay = 5000;
            this.passTT.InitialDelay = 750;
            this.passTT.IsBalloon = true;
            this.passTT.ReshowDelay = 100;
            this.passTT.Tag = "";
            this.passTT.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.passTT.ToolTipTitle = "Need help?";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.BackColor = System.Drawing.SystemColors.Window;
            this.lblMax.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblMax.Location = new System.Drawing.Point(336, 107);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(65, 17);
            this.lblMax.TabIndex = 6;
            this.lblMax.Text = "Max: 200";
            // 
            // frmAdminPromos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 513);
            this.Controls.Add(this.btnUPromo);
            this.Controls.Add(this.gbEPromo);
            this.Controls.Add(this.gbEItem);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cbAction);
            this.Controls.Add(this.btnCancelPromo);
            this.Controls.Add(this.btnAddPromo);
            this.Controls.Add(this.gbNPromo);
            this.Controls.Add(this.gbNItem);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmAdminPromos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add promotion";
            this.Load += new System.EventHandler(this.frmAdminPromos_Load);
            this.gbNItem.ResumeLayout(false);
            this.gbNItem.PerformLayout();
            this.gbNPromo.ResumeLayout(false);
            this.gbNPromo.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbEItem.ResumeLayout(false);
            this.gbEItem.PerformLayout();
            this.gbEPromo.ResumeLayout(false);
            this.gbEPromo.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbItem;
        private wmgCMS.WaterMarkTextBox txtAmount;
        private System.Windows.Forms.TextBox txtOriginalPrice;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.DateTimePicker dtPromoStart;
        private System.Windows.Forms.DateTimePicker dtPromoEnd;
        private System.Windows.Forms.TextBox txtPromoId;
        private System.Windows.Forms.TextBox txtDisPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox gbNItem;
        private System.Windows.Forms.GroupBox gbNPromo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCancelPromo;
        private System.Windows.Forms.Button btnAddPromo;
        private System.Windows.Forms.ComboBox cbAction;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gbEItem;
        private wmgCMS.WaterMarkTextBox txtEQ;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEPromoItem;
        private System.Windows.Forms.ComboBox cbEID;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblPromoID;
        private System.Windows.Forms.GroupBox gbEPromo;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEDP;
        private System.Windows.Forms.TextBox txtEOri;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtEDPP;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtEStart;
        private System.Windows.Forms.DateTimePicker dtEEnd;
        private System.Windows.Forms.Button btnUPromo;
        private System.Windows.Forms.ToolTip passTT;
        private System.Windows.Forms.Label lblMax;
    }
}