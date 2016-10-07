namespace _213
{
    partial class salesForm
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
            this.btnSalesBack = new System.Windows.Forms.Button();
            this.pnlAddSale = new System.Windows.Forms.Panel();
            this.txtProductID_Sale = new System.Windows.Forms.TextBox();
            this.btnCancelSaleBusy = new System.Windows.Forms.Button();
            this.btnRemoveSaleItem = new System.Windows.Forms.Button();
            this.btnPrintReceipt_Sales = new System.Windows.Forms.Button();
            this.btnAddToSale = new System.Windows.Forms.Button();
            this.btnCompleteSale = new System.Windows.Forms.Button();
            this.lbxSaleReceipt = new System.Windows.Forms.ListBox();
            this.lblSaleItem = new System.Windows.Forms.Label();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._stockI_TDataSet = new _213._stockI_TDataSet();
            this.cmbSalesMenu = new System.Windows.Forms.ComboBox();
            this.stockTableAdapter = new _213._stockI_TDataSetTableAdapters.StockTableAdapter();
            this.pnlPrevSaleCancel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.lbxDisplayReceipt = new System.Windows.Forms.ListBox();
            this.dtpSaleDateSearch = new System.Windows.Forms.DateTimePicker();
            this.lblSaleToSearch = new System.Windows.Forms.Label();
            this.btnSaleSearch = new System.Windows.Forms.Button();
            this.stockITDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesTableAdapter = new _213._stockI_TDataSetTableAdapters.SalesTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnlCompleteSale = new System.Windows.Forms.Panel();
            this.btnCancelSale = new System.Windows.Forms.Button();
            this.btnCompleteSalePaid = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPaid = new System.Windows.Forms.Label();
            this.cbxSpecialOrder = new System.Windows.Forms.CheckBox();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.cbxMethodOfPayment = new System.Windows.Forms.ComboBox();
            this.lblMethodOfPayment_Sales = new System.Windows.Forms.Label();
            this.pnlAddSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._stockI_TDataSet)).BeginInit();
            this.pnlPrevSaleCancel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockITDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            this.pnlCompleteSale.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalesBack
            // 
            this.btnSalesBack.Location = new System.Drawing.Point(139, 10);
            this.btnSalesBack.Name = "btnSalesBack";
            this.btnSalesBack.Size = new System.Drawing.Size(75, 23);
            this.btnSalesBack.TabIndex = 7;
            this.btnSalesBack.Text = "Back";
            this.btnSalesBack.UseVisualStyleBackColor = true;
            this.btnSalesBack.Click += new System.EventHandler(this.btnSalesBack_Click);
            // 
            // pnlAddSale
            // 
            this.pnlAddSale.Controls.Add(this.txtProductID_Sale);
            this.pnlAddSale.Controls.Add(this.btnCancelSaleBusy);
            this.pnlAddSale.Controls.Add(this.btnRemoveSaleItem);
            this.pnlAddSale.Controls.Add(this.btnPrintReceipt_Sales);
            this.pnlAddSale.Controls.Add(this.btnAddToSale);
            this.pnlAddSale.Controls.Add(this.btnCompleteSale);
            this.pnlAddSale.Controls.Add(this.lbxSaleReceipt);
            this.pnlAddSale.Controls.Add(this.lblSaleItem);
            this.pnlAddSale.Location = new System.Drawing.Point(3, 39);
            this.pnlAddSale.Name = "pnlAddSale";
            this.pnlAddSale.Size = new System.Drawing.Size(642, 366);
            this.pnlAddSale.TabIndex = 6;
            this.pnlAddSale.Visible = false;
            this.pnlAddSale.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAddSale_Paint);
            // 
            // txtProductID_Sale
            // 
            this.txtProductID_Sale.Location = new System.Drawing.Point(7, 29);
            this.txtProductID_Sale.Name = "txtProductID_Sale";
            this.txtProductID_Sale.Size = new System.Drawing.Size(159, 20);
            this.txtProductID_Sale.TabIndex = 38;
            // 
            // btnCancelSaleBusy
            // 
            this.btnCancelSaleBusy.Location = new System.Drawing.Point(213, 223);
            this.btnCancelSaleBusy.Name = "btnCancelSaleBusy";
            this.btnCancelSaleBusy.Size = new System.Drawing.Size(160, 60);
            this.btnCancelSaleBusy.TabIndex = 37;
            this.btnCancelSaleBusy.Text = "Cancel Sale";
            this.btnCancelSaleBusy.UseVisualStyleBackColor = true;
            this.btnCancelSaleBusy.Click += new System.EventHandler(this.btnCancelSaleBusy_Click);
            // 
            // btnRemoveSaleItem
            // 
            this.btnRemoveSaleItem.Location = new System.Drawing.Point(214, 95);
            this.btnRemoveSaleItem.Name = "btnRemoveSaleItem";
            this.btnRemoveSaleItem.Size = new System.Drawing.Size(159, 56);
            this.btnRemoveSaleItem.TabIndex = 35;
            this.btnRemoveSaleItem.Text = "Undo";
            this.btnRemoveSaleItem.UseVisualStyleBackColor = true;
            this.btnRemoveSaleItem.Click += new System.EventHandler(this.btnRemoveSaleItem_Click);
            // 
            // btnPrintReceipt_Sales
            // 
            this.btnPrintReceipt_Sales.Location = new System.Drawing.Point(214, 289);
            this.btnPrintReceipt_Sales.Name = "btnPrintReceipt_Sales";
            this.btnPrintReceipt_Sales.Size = new System.Drawing.Size(160, 60);
            this.btnPrintReceipt_Sales.TabIndex = 34;
            this.btnPrintReceipt_Sales.Text = "Print Receipt";
            this.btnPrintReceipt_Sales.UseVisualStyleBackColor = true;
            // 
            // btnAddToSale
            // 
            this.btnAddToSale.Location = new System.Drawing.Point(213, 33);
            this.btnAddToSale.Name = "btnAddToSale";
            this.btnAddToSale.Size = new System.Drawing.Size(159, 56);
            this.btnAddToSale.TabIndex = 24;
            this.btnAddToSale.Text = "Add Item";
            this.btnAddToSale.UseVisualStyleBackColor = true;
            this.btnAddToSale.Click += new System.EventHandler(this.btnAddToSale_Click);
            // 
            // btnCompleteSale
            // 
            this.btnCompleteSale.Location = new System.Drawing.Point(214, 157);
            this.btnCompleteSale.Name = "btnCompleteSale";
            this.btnCompleteSale.Size = new System.Drawing.Size(160, 60);
            this.btnCompleteSale.TabIndex = 30;
            this.btnCompleteSale.Text = "Complete Sale";
            this.btnCompleteSale.UseVisualStyleBackColor = true;
            this.btnCompleteSale.Click += new System.EventHandler(this.btnCompleteSale_Click);
            // 
            // lbxSaleReceipt
            // 
            this.lbxSaleReceipt.FormattingEnabled = true;
            this.lbxSaleReceipt.Location = new System.Drawing.Point(404, 33);
            this.lbxSaleReceipt.Name = "lbxSaleReceipt";
            this.lbxSaleReceipt.Size = new System.Drawing.Size(222, 290);
            this.lbxSaleReceipt.TabIndex = 25;
            this.lbxSaleReceipt.SelectedIndexChanged += new System.EventHandler(this.lbxSaleReceipt_SelectedIndexChanged);
            // 
            // lblSaleItem
            // 
            this.lblSaleItem.AutoSize = true;
            this.lblSaleItem.Location = new System.Drawing.Point(6, 11);
            this.lblSaleItem.Name = "lblSaleItem";
            this.lblSaleItem.Size = new System.Drawing.Size(64, 13);
            this.lblSaleItem.TabIndex = 26;
            this.lblSaleItem.Text = "Product ID: ";
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this._stockI_TDataSet;
            // 
            // _stockI_TDataSet
            // 
            this._stockI_TDataSet.DataSetName = "_stockI_TDataSet";
            this._stockI_TDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbSalesMenu
            // 
            this.cmbSalesMenu.FormattingEnabled = true;
            this.cmbSalesMenu.Items.AddRange(new object[] {
            "New Sale",
            "Search Previous Sale",
            "Search Stock",
            "Back",
            "Exit"});
            this.cmbSalesMenu.Location = new System.Drawing.Point(12, 12);
            this.cmbSalesMenu.Name = "cmbSalesMenu";
            this.cmbSalesMenu.Size = new System.Drawing.Size(121, 21);
            this.cmbSalesMenu.TabIndex = 5;
            this.cmbSalesMenu.SelectedIndexChanged += new System.EventHandler(this.cmbSalesMenu_SelectedIndexChanged);
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // pnlPrevSaleCancel
            // 
            this.pnlPrevSaleCancel.Controls.Add(this.button1);
            this.pnlPrevSaleCancel.Controls.Add(this.lbxDisplayReceipt);
            this.pnlPrevSaleCancel.Controls.Add(this.dtpSaleDateSearch);
            this.pnlPrevSaleCancel.Controls.Add(this.lblSaleToSearch);
            this.pnlPrevSaleCancel.Controls.Add(this.btnSaleSearch);
            this.pnlPrevSaleCancel.Location = new System.Drawing.Point(665, 39);
            this.pnlPrevSaleCancel.Name = "pnlPrevSaleCancel";
            this.pnlPrevSaleCancel.Size = new System.Drawing.Size(389, 366);
            this.pnlPrevSaleCancel.TabIndex = 9;
            this.pnlPrevSaleCancel.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 60);
            this.button1.TabIndex = 42;
            this.button1.Text = "Cancel Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbxDisplayReceipt
            // 
            this.lbxDisplayReceipt.FormattingEnabled = true;
            this.lbxDisplayReceipt.Location = new System.Drawing.Point(173, 33);
            this.lbxDisplayReceipt.Name = "lbxDisplayReceipt";
            this.lbxDisplayReceipt.Size = new System.Drawing.Size(208, 316);
            this.lbxDisplayReceipt.TabIndex = 41;
            // 
            // dtpSaleDateSearch
            // 
            this.dtpSaleDateSearch.Location = new System.Drawing.Point(16, 54);
            this.dtpSaleDateSearch.Name = "dtpSaleDateSearch";
            this.dtpSaleDateSearch.Size = new System.Drawing.Size(147, 20);
            this.dtpSaleDateSearch.TabIndex = 40;
            this.dtpSaleDateSearch.Value = new System.DateTime(2016, 9, 10, 16, 41, 21, 0);
            // 
            // lblSaleToSearch
            // 
            this.lblSaleToSearch.AutoSize = true;
            this.lblSaleToSearch.Location = new System.Drawing.Point(13, 36);
            this.lblSaleToSearch.Name = "lblSaleToSearch";
            this.lblSaleToSearch.Size = new System.Drawing.Size(82, 13);
            this.lblSaleToSearch.TabIndex = 39;
            this.lblSaleToSearch.Text = "Date to Search:";
            // 
            // btnSaleSearch
            // 
            this.btnSaleSearch.Location = new System.Drawing.Point(16, 91);
            this.btnSaleSearch.Name = "btnSaleSearch";
            this.btnSaleSearch.Size = new System.Drawing.Size(147, 60);
            this.btnSaleSearch.TabIndex = 38;
            this.btnSaleSearch.Text = "Search Sales";
            this.btnSaleSearch.UseVisualStyleBackColor = true;
            this.btnSaleSearch.Click += new System.EventHandler(this.btnSaleSearch_Click);
            // 
            // stockITDataSetBindingSource
            // 
            this.stockITDataSetBindingSource.DataSource = this._stockI_TDataSet;
            this.stockITDataSetBindingSource.Position = 0;
            // 
            // salesBindingSource
            // 
            this.salesBindingSource.DataMember = "Sales";
            this.salesBindingSource.DataSource = this._stockI_TDataSet;
            // 
            // salesTableAdapter
            // 
            this.salesTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pnlCompleteSale
            // 
            this.pnlCompleteSale.Controls.Add(this.btnCancelSale);
            this.pnlCompleteSale.Controls.Add(this.btnCompleteSalePaid);
            this.pnlCompleteSale.Controls.Add(this.lblTotal);
            this.pnlCompleteSale.Controls.Add(this.lblPaid);
            this.pnlCompleteSale.Controls.Add(this.cbxSpecialOrder);
            this.pnlCompleteSale.Controls.Add(this.txtPaid);
            this.pnlCompleteSale.Controls.Add(this.cbxMethodOfPayment);
            this.pnlCompleteSale.Controls.Add(this.lblMethodOfPayment_Sales);
            this.pnlCompleteSale.Location = new System.Drawing.Point(3, 411);
            this.pnlCompleteSale.Name = "pnlCompleteSale";
            this.pnlCompleteSale.Size = new System.Drawing.Size(286, 226);
            this.pnlCompleteSale.TabIndex = 10;
            this.pnlCompleteSale.Visible = false;
            // 
            // btnCancelSale
            // 
            this.btnCancelSale.Location = new System.Drawing.Point(148, 164);
            this.btnCancelSale.Name = "btnCancelSale";
            this.btnCancelSale.Size = new System.Drawing.Size(129, 54);
            this.btnCancelSale.TabIndex = 58;
            this.btnCancelSale.Text = "Cancel";
            this.btnCancelSale.UseVisualStyleBackColor = true;
            this.btnCancelSale.Click += new System.EventHandler(this.btnCancelSale_Click);
            // 
            // btnCompleteSalePaid
            // 
            this.btnCompleteSalePaid.Location = new System.Drawing.Point(16, 164);
            this.btnCompleteSalePaid.Name = "btnCompleteSalePaid";
            this.btnCompleteSalePaid.Size = new System.Drawing.Size(129, 54);
            this.btnCompleteSalePaid.TabIndex = 57;
            this.btnCompleteSalePaid.Text = "Complete Sale";
            this.btnCompleteSalePaid.UseVisualStyleBackColor = true;
            this.btnCompleteSalePaid.Click += new System.EventHandler(this.btnCompleteSalePaid_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(10, 13);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(171, 25);
            this.lblTotal.TabIndex = 56;
            this.lblTotal.Text = "Total Payable: ";
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Location = new System.Drawing.Point(13, 53);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(31, 13);
            this.lblPaid.TabIndex = 55;
            this.lblPaid.Text = "Paid:";
            // 
            // cbxSpecialOrder
            // 
            this.cbxSpecialOrder.AutoSize = true;
            this.cbxSpecialOrder.Location = new System.Drawing.Point(16, 137);
            this.cbxSpecialOrder.Name = "cbxSpecialOrder";
            this.cbxSpecialOrder.Size = new System.Drawing.Size(90, 17);
            this.cbxSpecialOrder.TabIndex = 54;
            this.cbxSpecialOrder.Text = "Special Order";
            this.cbxSpecialOrder.UseVisualStyleBackColor = true;
            // 
            // txtPaid
            // 
            this.txtPaid.Location = new System.Drawing.Point(13, 69);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(159, 20);
            this.txtPaid.TabIndex = 53;
            // 
            // cbxMethodOfPayment
            // 
            this.cbxMethodOfPayment.FormattingEnabled = true;
            this.cbxMethodOfPayment.Items.AddRange(new object[] {
            "Cash",
            "Credit",
            "Debit",
            "Tjek"});
            this.cbxMethodOfPayment.Location = new System.Drawing.Point(16, 110);
            this.cbxMethodOfPayment.Name = "cbxMethodOfPayment";
            this.cbxMethodOfPayment.Size = new System.Drawing.Size(158, 21);
            this.cbxMethodOfPayment.TabIndex = 52;
            // 
            // lblMethodOfPayment_Sales
            // 
            this.lblMethodOfPayment_Sales.AutoSize = true;
            this.lblMethodOfPayment_Sales.Location = new System.Drawing.Point(13, 94);
            this.lblMethodOfPayment_Sales.Name = "lblMethodOfPayment_Sales";
            this.lblMethodOfPayment_Sales.Size = new System.Drawing.Size(102, 13);
            this.lblMethodOfPayment_Sales.TabIndex = 51;
            this.lblMethodOfPayment_Sales.Text = "Method of Payment:";
            // 
            // salesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 729);
            this.Controls.Add(this.pnlCompleteSale);
            this.Controls.Add(this.pnlPrevSaleCancel);
            this.Controls.Add(this.btnSalesBack);
            this.Controls.Add(this.pnlAddSale);
            this.Controls.Add(this.cmbSalesMenu);
            this.Name = "salesForm";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.salesForm_Load_1);
            this.pnlAddSale.ResumeLayout(false);
            this.pnlAddSale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._stockI_TDataSet)).EndInit();
            this.pnlPrevSaleCancel.ResumeLayout(false);
            this.pnlPrevSaleCancel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockITDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            this.pnlCompleteSale.ResumeLayout(false);
            this.pnlCompleteSale.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSalesBack;
        private System.Windows.Forms.Panel pnlAddSale;
        private System.Windows.Forms.Button btnAddToSale;
        private System.Windows.Forms.Button btnCompleteSale;
        private System.Windows.Forms.ListBox lbxSaleReceipt;
        private System.Windows.Forms.Label lblSaleItem;
        private System.Windows.Forms.ComboBox cmbSalesMenu;
        private _stockI_TDataSet _stockI_TDataSet;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private _stockI_TDataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private System.Windows.Forms.Button btnPrintReceipt_Sales;
        private System.Windows.Forms.Button btnRemoveSaleItem;
        private System.Windows.Forms.Button btnCancelSaleBusy;
        private System.Windows.Forms.Panel pnlPrevSaleCancel;
        private System.Windows.Forms.Button btnSaleSearch;
        private System.Windows.Forms.Label lblSaleToSearch;
        private System.Windows.Forms.BindingSource stockITDataSetBindingSource;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private _stockI_TDataSetTableAdapters.SalesTableAdapter salesTableAdapter;
        private System.Windows.Forms.TextBox txtProductID_Sale;
        private System.Windows.Forms.DateTimePicker dtpSaleDateSearch;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox lbxDisplayReceipt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlCompleteSale;
        private System.Windows.Forms.Button btnCancelSale;
        private System.Windows.Forms.Button btnCompleteSalePaid;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.CheckBox cbxSpecialOrder;
        private System.Windows.Forms.TextBox txtPaid;
        private System.Windows.Forms.ComboBox cbxMethodOfPayment;
        private System.Windows.Forms.Label lblMethodOfPayment_Sales;
    }
}