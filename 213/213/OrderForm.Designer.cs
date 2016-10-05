namespace _213
{
    partial class OrderForm
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
            this.POBackBtn9 = new System.Windows.Forms.Button();
            this.AddOrderBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPricofeachitem = new System.Windows.Forms.TextBox();
            this.txtMaker = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdditem = new System.Windows.Forms.Button();
            this.btnremovePrevouis = new System.Windows.Forms.Button();
            this.btnClearOrder = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuatity = new System.Windows.Forms.TextBox();
            this.cbxSpecialorder = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCust_email = new System.Windows.Forms.TextBox();
            this.gbxPayment = new System.Windows.Forms.GroupBox();
            this.gpxOrders = new System.Windows.Forms.GroupBox();
            this.lbxOutput = new System.Windows.Forms.ListBox();
            this.gpxSearch = new System.Windows.Forms.GroupBox();
            this.lblOrder = new System.Windows.Forms.Label();
            this.lbxsearchordelete = new System.Windows.Forms.ListBox();
            this.cbxOrder = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.passTT = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbxOrders = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.gbxPayment.SuspendLayout();
            this.gpxOrders.SuspendLayout();
            this.gpxSearch.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // POBackBtn9
            // 
            this.POBackBtn9.Location = new System.Drawing.Point(1240, 694);
            this.POBackBtn9.Name = "POBackBtn9";
            this.POBackBtn9.Size = new System.Drawing.Size(97, 44);
            this.POBackBtn9.TabIndex = 9;
            this.POBackBtn9.Text = "Back";
            this.POBackBtn9.UseVisualStyleBackColor = true;
            // 
            // AddOrderBtn
            // 
            this.AddOrderBtn.Location = new System.Drawing.Point(543, 309);
            this.AddOrderBtn.Name = "AddOrderBtn";
            this.AddOrderBtn.Size = new System.Drawing.Size(111, 35);
            this.AddOrderBtn.TabIndex = 8;
            this.AddOrderBtn.Text = "place order";
            this.passTT.SetToolTip(this.AddOrderBtn, "Place the order");
            this.AddOrderBtn.UseVisualStyleBackColor = true;
            this.AddOrderBtn.Click += new System.EventHandler(this.AddOrderBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "Item name";
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(9, 91);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(245, 20);
            this.txtItem.TabIndex = 1;
            this.passTT.SetToolTip(this.txtItem, "Please enter the name of the product.\r\nExample Insperion 3000.");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "prices of each item";
            // 
            // txtPricofeachitem
            // 
            this.txtPricofeachitem.Location = new System.Drawing.Point(9, 140);
            this.txtPricofeachitem.Name = "txtPricofeachitem";
            this.txtPricofeachitem.Size = new System.Drawing.Size(245, 20);
            this.txtPricofeachitem.TabIndex = 2;
            this.passTT.SetToolTip(this.txtPricofeachitem, "Please enter the price of the product. \r\nExample 5000.");
            // 
            // txtMaker
            // 
            this.txtMaker.Location = new System.Drawing.Point(6, 42);
            this.txtMaker.Name = "txtMaker";
            this.txtMaker.Size = new System.Drawing.Size(245, 20);
            this.txtMaker.TabIndex = 0;
            this.passTT.SetToolTip(this.txtMaker, "Please enter the manufacturer of the product. \r\nExample Dell.");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 66;
            this.label4.Text = "Make of the hardware";
            // 
            // btnAdditem
            // 
            this.btnAdditem.Location = new System.Drawing.Point(284, 53);
            this.btnAdditem.Name = "btnAdditem";
            this.btnAdditem.Size = new System.Drawing.Size(111, 35);
            this.btnAdditem.TabIndex = 5;
            this.btnAdditem.Text = "Add item";
            this.passTT.SetToolTip(this.btnAdditem, "Add item to order.");
            this.btnAdditem.UseVisualStyleBackColor = true;
            this.btnAdditem.Click += new System.EventHandler(this.btnAdditem_Click);
            // 
            // btnremovePrevouis
            // 
            this.btnremovePrevouis.Location = new System.Drawing.Point(284, 107);
            this.btnremovePrevouis.Name = "btnremovePrevouis";
            this.btnremovePrevouis.Size = new System.Drawing.Size(111, 35);
            this.btnremovePrevouis.TabIndex = 6;
            this.btnremovePrevouis.Text = "Remove item";
            this.passTT.SetToolTip(this.btnremovePrevouis, "Remove previous item form order.");
            this.btnremovePrevouis.UseVisualStyleBackColor = true;
            this.btnremovePrevouis.Click += new System.EventHandler(this.btnremovePrevouis_Click);
            // 
            // btnClearOrder
            // 
            this.btnClearOrder.Location = new System.Drawing.Point(284, 155);
            this.btnClearOrder.Name = "btnClearOrder";
            this.btnClearOrder.Size = new System.Drawing.Size(111, 35);
            this.btnClearOrder.TabIndex = 7;
            this.btnClearOrder.Text = "Cancel";
            this.passTT.SetToolTip(this.btnClearOrder, "Cancel current order.");
            this.btnClearOrder.UseVisualStyleBackColor = true;
            this.btnClearOrder.Click += new System.EventHandler(this.btnClearOrder_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "Number of this item";
            // 
            // txtQuatity
            // 
            this.txtQuatity.Location = new System.Drawing.Point(9, 194);
            this.txtQuatity.Name = "txtQuatity";
            this.txtQuatity.Size = new System.Drawing.Size(245, 20);
            this.txtQuatity.TabIndex = 3;
            this.passTT.SetToolTip(this.txtQuatity, "Please enter the quantity of the same product.");
            // 
            // cbxSpecialorder
            // 
            this.cbxSpecialorder.AutoSize = true;
            this.cbxSpecialorder.Location = new System.Drawing.Point(18, 219);
            this.cbxSpecialorder.Name = "cbxSpecialorder";
            this.cbxSpecialorder.Size = new System.Drawing.Size(88, 17);
            this.cbxSpecialorder.TabIndex = 4;
            this.cbxSpecialorder.Text = "Special order";
            this.passTT.SetToolTip(this.cbxSpecialorder, "This is for when you order something for a client. \r\nYou need to enter a valid em" +
        "ail address inorder to email the customer when the ordered product is in stock.");
            this.cbxSpecialorder.UseVisualStyleBackColor = true;
            this.cbxSpecialorder.CheckedChanged += new System.EventHandler(this.cbxSpecialorder_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Customer Email";
            // 
            // txtCust_email
            // 
            this.txtCust_email.Location = new System.Drawing.Point(9, 32);
            this.txtCust_email.Name = "txtCust_email";
            this.txtCust_email.Size = new System.Drawing.Size(172, 20);
            this.txtCust_email.TabIndex = 4;
            // 
            // gbxPayment
            // 
            this.gbxPayment.Controls.Add(this.label5);
            this.gbxPayment.Controls.Add(this.txtCust_email);
            this.gbxPayment.Location = new System.Drawing.Point(9, 250);
            this.gbxPayment.Name = "gbxPayment";
            this.gbxPayment.Size = new System.Drawing.Size(196, 67);
            this.gbxPayment.TabIndex = 74;
            this.gbxPayment.TabStop = false;
            this.gbxPayment.Text = "Special orders for customers";
            // 
            // gpxOrders
            // 
            this.gpxOrders.Controls.Add(this.lbxOutput);
            this.gpxOrders.Controls.Add(this.label1);
            this.gpxOrders.Controls.Add(this.gbxPayment);
            this.gpxOrders.Controls.Add(this.txtItem);
            this.gpxOrders.Controls.Add(this.btnClearOrder);
            this.gpxOrders.Controls.Add(this.cbxSpecialorder);
            this.gpxOrders.Controls.Add(this.btnremovePrevouis);
            this.gpxOrders.Controls.Add(this.label3);
            this.gpxOrders.Controls.Add(this.AddOrderBtn);
            this.gpxOrders.Controls.Add(this.btnAdditem);
            this.gpxOrders.Controls.Add(this.label2);
            this.gpxOrders.Controls.Add(this.txtPricofeachitem);
            this.gpxOrders.Controls.Add(this.txtQuatity);
            this.gpxOrders.Controls.Add(this.txtMaker);
            this.gpxOrders.Controls.Add(this.label4);
            this.gpxOrders.Location = new System.Drawing.Point(3, 3);
            this.gpxOrders.Name = "gpxOrders";
            this.gpxOrders.Size = new System.Drawing.Size(762, 361);
            this.gpxOrders.TabIndex = 75;
            this.gpxOrders.TabStop = false;
            this.gpxOrders.Text = "Orders";
            // 
            // lbxOutput
            // 
            this.lbxOutput.FormattingEnabled = true;
            this.lbxOutput.Items.AddRange(new object[] {
            ""});
            this.lbxOutput.Location = new System.Drawing.Point(427, 26);
            this.lbxOutput.Name = "lbxOutput";
            this.lbxOutput.Size = new System.Drawing.Size(311, 264);
            this.lbxOutput.TabIndex = 75;
            // 
            // gpxSearch
            // 
            this.gpxSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gpxSearch.Controls.Add(this.lblOrder);
            this.gpxSearch.Controls.Add(this.lbxsearchordelete);
            this.gpxSearch.Controls.Add(this.cbxOrder);
            this.gpxSearch.Controls.Add(this.btnCancel);
            this.gpxSearch.Controls.Add(this.label8);
            this.gpxSearch.Location = new System.Drawing.Point(179, 3);
            this.gpxSearch.Name = "gpxSearch";
            this.gpxSearch.Size = new System.Drawing.Size(419, 413);
            this.gpxSearch.TabIndex = 76;
            this.gpxSearch.TabStop = false;
            this.gpxSearch.Text = "Search for a order";
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Location = new System.Drawing.Point(12, 78);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(0, 13);
            this.lblOrder.TabIndex = 74;
            // 
            // lbxsearchordelete
            // 
            this.lbxsearchordelete.FormattingEnabled = true;
            this.lbxsearchordelete.Location = new System.Drawing.Point(15, 94);
            this.lbxsearchordelete.Name = "lbxsearchordelete";
            this.lbxsearchordelete.Size = new System.Drawing.Size(360, 199);
            this.lbxsearchordelete.TabIndex = 73;
            // 
            // cbxOrder
            // 
            this.cbxOrder.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxOrder.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxOrder.FormattingEnabled = true;
            this.cbxOrder.Location = new System.Drawing.Point(15, 49);
            this.cbxOrder.Name = "cbxOrder";
            this.cbxOrder.Size = new System.Drawing.Size(117, 21);
            this.cbxOrder.TabIndex = 72;
            this.passTT.SetToolTip(this.cbxOrder, "Select the order you are looking for. From the drop down menu.");
            this.cbxOrder.SelectedIndexChanged += new System.EventHandler(this.cbxOrder_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(149, 311);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 23);
            this.btnCancel.TabIndex = 71;
            this.btnCancel.Text = "Cancel Order";
            this.passTT.SetToolTip(this.btnCancel, "This cancel\'s the order you selected above in the dropdown menu.");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Please enter the order ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(698, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 77;
            this.button1.Text = "Back";
            this.passTT.SetToolTip(this.button1, "Go back to the home screen.");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // passTT
            // 
            this.passTT.AutoPopDelay = 5000;
            this.passTT.InitialDelay = 100;
            this.passTT.IsBalloon = true;
            this.passTT.ReshowDelay = 100;
            this.passTT.Tag = "";
            this.passTT.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.passTT.ToolTipTitle = "Order help";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 695F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel1.Controls.Add(this.cbxOrders, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(26, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 27);
            this.tableLayoutPanel1.TabIndex = 78;
            // 
            // cbxOrders
            // 
            this.cbxOrders.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxOrders.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxOrders.FormattingEnabled = true;
            this.cbxOrders.Items.AddRange(new object[] {
            "Order for this Matrix Branch/Special order",
            "Search order/Cancel order"});
            this.cbxOrders.Location = new System.Drawing.Point(3, 3);
            this.cbxOrders.Name = "cbxOrders";
            this.cbxOrders.Size = new System.Drawing.Size(325, 21);
            this.cbxOrders.TabIndex = 58;
            this.cbxOrders.Text = "Please choose what you want to do";
            this.cbxOrders.SelectedIndexChanged += new System.EventHandler(this.cbxOrders_SelectedIndexChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 784F));
            this.tableLayoutPanel2.Controls.Add(this.gpxOrders, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(26, 61);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(784, 416);
            this.tableLayoutPanel2.TabIndex = 79;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 778F));
            this.tableLayoutPanel3.Controls.Add(this.gpxSearch, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(32, 58);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(778, 419);
            this.tableLayoutPanel3.TabIndex = 79;
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 473);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.POBackBtn9);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Activated += new System.EventHandler(this.roundButton3);
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.Enter += new System.EventHandler(this.roundButton3);
            this.gbxPayment.ResumeLayout(false);
            this.gbxPayment.PerformLayout();
            this.gpxOrders.ResumeLayout(false);
            this.gpxOrders.PerformLayout();
            this.gpxSearch.ResumeLayout(false);
            this.gpxSearch.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button POBackBtn9;
        private System.Windows.Forms.Button AddOrderBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPricofeachitem;
        private System.Windows.Forms.TextBox txtMaker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdditem;
        private System.Windows.Forms.Button btnremovePrevouis;
        private System.Windows.Forms.Button btnClearOrder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuatity;
        private System.Windows.Forms.CheckBox cbxSpecialorder;
        private System.Windows.Forms.TextBox txtCust_email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbxPayment;
        private System.Windows.Forms.GroupBox gpxOrders;
        private System.Windows.Forms.GroupBox gpxSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbxOutput;
        private System.Windows.Forms.ComboBox cbxOrder;
        private System.Windows.Forms.ListBox lbxsearchordelete;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.ToolTip passTT;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cbxOrders;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    }
}