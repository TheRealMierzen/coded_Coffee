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
            this.cbxSale_Item = new System.Windows.Forms.ComboBox();
            this.btnAddToSale = new System.Windows.Forms.Button();
            this.btnCompleteSale = new System.Windows.Forms.Button();
            this.lblTotalProduct = new System.Windows.Forms.Label();
            this.lbxSaleReceipt = new System.Windows.Forms.ListBox();
            this.txtTotalProduct = new System.Windows.Forms.TextBox();
            this.lblSaleItem = new System.Windows.Forms.Label();
            this.cmbSalesMenu = new System.Windows.Forms.ComboBox();
            this.lblMethodOfPayment_Sales = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this._stockI_TDataSet = new _213._stockI_TDataSet();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stockTableAdapter = new _213._stockI_TDataSetTableAdapters.StockTableAdapter();
            this.btnPrintReceipt_Sales = new System.Windows.Forms.Button();
            this.btnRemoveSaleItem = new System.Windows.Forms.Button();
            this.btnCancelSaleBusy = new System.Windows.Forms.Button();
            this.pnlPrevSaleCancel = new System.Windows.Forms.Panel();
            this.lbxPrevSaleDisplay = new System.Windows.Forms.ListBox();
            this.btnSaleSearch = new System.Windows.Forms.Button();
            this.lblSaleToCancel = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.stockITDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salesTableAdapter = new _213._stockI_TDataSetTableAdapters.SalesTableAdapter();
            this.pnlAddSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._stockI_TDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            this.pnlPrevSaleCancel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockITDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
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
            this.pnlAddSale.Controls.Add(this.btnCancelSaleBusy);
            this.pnlAddSale.Controls.Add(this.btnRemoveSaleItem);
            this.pnlAddSale.Controls.Add(this.btnPrintReceipt_Sales);
            this.pnlAddSale.Controls.Add(this.comboBox1);
            this.pnlAddSale.Controls.Add(this.lblMethodOfPayment_Sales);
            this.pnlAddSale.Controls.Add(this.cbxSale_Item);
            this.pnlAddSale.Controls.Add(this.btnAddToSale);
            this.pnlAddSale.Controls.Add(this.btnCompleteSale);
            this.pnlAddSale.Controls.Add(this.lblTotalProduct);
            this.pnlAddSale.Controls.Add(this.lbxSaleReceipt);
            this.pnlAddSale.Controls.Add(this.txtTotalProduct);
            this.pnlAddSale.Controls.Add(this.lblSaleItem);
            this.pnlAddSale.Location = new System.Drawing.Point(12, 39);
            this.pnlAddSale.Name = "pnlAddSale";
            this.pnlAddSale.Size = new System.Drawing.Size(633, 366);
            this.pnlAddSale.TabIndex = 6;
            this.pnlAddSale.Visible = false;
            // 
            // cbxSale_Item
            // 
            this.cbxSale_Item.DataSource = this.stockBindingSource;
            this.cbxSale_Item.DisplayMember = "description";
            this.cbxSale_Item.FormattingEnabled = true;
            this.cbxSale_Item.Location = new System.Drawing.Point(18, 33);
            this.cbxSale_Item.Name = "cbxSale_Item";
            this.cbxSale_Item.Size = new System.Drawing.Size(158, 21);
            this.cbxSale_Item.TabIndex = 31;
            this.cbxSale_Item.ValueMember = "description";
            // 
            // btnAddToSale
            // 
            this.btnAddToSale.Location = new System.Drawing.Point(214, 33);
            this.btnAddToSale.Name = "btnAddToSale";
            this.btnAddToSale.Size = new System.Drawing.Size(159, 56);
            this.btnAddToSale.TabIndex = 24;
            this.btnAddToSale.Text = "Add Item";
            this.btnAddToSale.UseVisualStyleBackColor = true;
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
            // lblTotalProduct
            // 
            this.lblTotalProduct.AutoSize = true;
            this.lblTotalProduct.Location = new System.Drawing.Point(15, 60);
            this.lblTotalProduct.Name = "lblTotalProduct";
            this.lblTotalProduct.Size = new System.Drawing.Size(109, 13);
            this.lblTotalProduct.TabIndex = 29;
            this.lblTotalProduct.Text = "Enter total of product:";
            // 
            // lbxSaleReceipt
            // 
            this.lbxSaleReceipt.FormattingEnabled = true;
            this.lbxSaleReceipt.Items.AddRange(new object[] {
            "MATRIX WAREHOUSE",
            "==============================",
            "2x Product\tR45\tR90",
            "",
            "*********************************************",
            "Total: \t\t\tR90",
            "Paid: \t\t\tR100",
            "Change: \t\t\tR10",
            "*********************************************",
            "Thank you for your purchase!",
            ""});
            this.lbxSaleReceipt.Location = new System.Drawing.Point(404, 33);
            this.lbxSaleReceipt.Name = "lbxSaleReceipt";
            this.lbxSaleReceipt.Size = new System.Drawing.Size(208, 316);
            this.lbxSaleReceipt.TabIndex = 25;
            this.lbxSaleReceipt.SelectedIndexChanged += new System.EventHandler(this.lbxSaleReceipt_SelectedIndexChanged);
            // 
            // txtTotalProduct
            // 
            this.txtTotalProduct.Location = new System.Drawing.Point(18, 76);
            this.txtTotalProduct.Name = "txtTotalProduct";
            this.txtTotalProduct.Size = new System.Drawing.Size(159, 20);
            this.txtTotalProduct.TabIndex = 28;
            // 
            // lblSaleItem
            // 
            this.lblSaleItem.AutoSize = true;
            this.lblSaleItem.Location = new System.Drawing.Point(15, 17);
            this.lblSaleItem.Name = "lblSaleItem";
            this.lblSaleItem.Size = new System.Drawing.Size(89, 13);
            this.lblSaleItem.TabIndex = 26;
            this.lblSaleItem.Text = "Choose Product: ";
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
            // lblMethodOfPayment_Sales
            // 
            this.lblMethodOfPayment_Sales.AutoSize = true;
            this.lblMethodOfPayment_Sales.Location = new System.Drawing.Point(14, 99);
            this.lblMethodOfPayment_Sales.Name = "lblMethodOfPayment_Sales";
            this.lblMethodOfPayment_Sales.Size = new System.Drawing.Size(102, 13);
            this.lblMethodOfPayment_Sales.TabIndex = 32;
            this.lblMethodOfPayment_Sales.Text = "Method of Payment:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cash",
            "Credit",
            "Debit",
            "Tjek"});
            this.comboBox1.Location = new System.Drawing.Point(17, 115);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 21);
            this.comboBox1.TabIndex = 33;
            // 
            // _stockI_TDataSet
            // 
            this._stockI_TDataSet.DataSetName = "_stockI_TDataSet";
            this._stockI_TDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockBindingSource
            // 
            this.stockBindingSource.DataMember = "Stock";
            this.stockBindingSource.DataSource = this._stockI_TDataSet;
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // btnPrintReceipt_Sales
            // 
            this.btnPrintReceipt_Sales.Location = new System.Drawing.Point(214, 223);
            this.btnPrintReceipt_Sales.Name = "btnPrintReceipt_Sales";
            this.btnPrintReceipt_Sales.Size = new System.Drawing.Size(160, 60);
            this.btnPrintReceipt_Sales.TabIndex = 34;
            this.btnPrintReceipt_Sales.Text = "Print Receipt";
            this.btnPrintReceipt_Sales.UseVisualStyleBackColor = true;
            // 
            // btnRemoveSaleItem
            // 
            this.btnRemoveSaleItem.Location = new System.Drawing.Point(214, 95);
            this.btnRemoveSaleItem.Name = "btnRemoveSaleItem";
            this.btnRemoveSaleItem.Size = new System.Drawing.Size(159, 56);
            this.btnRemoveSaleItem.TabIndex = 35;
            this.btnRemoveSaleItem.Text = "Undo";
            this.btnRemoveSaleItem.UseVisualStyleBackColor = true;
            // 
            // btnCancelSaleBusy
            // 
            this.btnCancelSaleBusy.Location = new System.Drawing.Point(214, 289);
            this.btnCancelSaleBusy.Name = "btnCancelSaleBusy";
            this.btnCancelSaleBusy.Size = new System.Drawing.Size(160, 60);
            this.btnCancelSaleBusy.TabIndex = 37;
            this.btnCancelSaleBusy.Text = "Cancel Sale";
            this.btnCancelSaleBusy.UseVisualStyleBackColor = true;
            // 
            // pnlPrevSaleCancel
            // 
            this.pnlPrevSaleCancel.Controls.Add(this.comboBox2);
            this.pnlPrevSaleCancel.Controls.Add(this.lblSaleToCancel);
            this.pnlPrevSaleCancel.Controls.Add(this.btnSaleSearch);
            this.pnlPrevSaleCancel.Controls.Add(this.lbxPrevSaleDisplay);
            this.pnlPrevSaleCancel.Location = new System.Drawing.Point(651, 39);
            this.pnlPrevSaleCancel.Name = "pnlPrevSaleCancel";
            this.pnlPrevSaleCancel.Size = new System.Drawing.Size(391, 366);
            this.pnlPrevSaleCancel.TabIndex = 9;
            // 
            // lbxPrevSaleDisplay
            // 
            this.lbxPrevSaleDisplay.FormattingEnabled = true;
            this.lbxPrevSaleDisplay.Items.AddRange(new object[] {
            "MATRIX WAREHOUSE",
            "==============================",
            "2x Product\tR45\tR90",
            "",
            "*********************************************",
            "Total: \t\t\tR90",
            "Paid: \t\t\tR100",
            "Change: \t\t\tR10",
            "*********************************************",
            "Thank you for your purchase!",
            ""});
            this.lbxPrevSaleDisplay.Location = new System.Drawing.Point(169, 33);
            this.lbxPrevSaleDisplay.Name = "lbxPrevSaleDisplay";
            this.lbxPrevSaleDisplay.Size = new System.Drawing.Size(208, 316);
            this.lbxPrevSaleDisplay.TabIndex = 26;
            // 
            // btnSaleSearch
            // 
            this.btnSaleSearch.Location = new System.Drawing.Point(16, 79);
            this.btnSaleSearch.Name = "btnSaleSearch";
            this.btnSaleSearch.Size = new System.Drawing.Size(147, 60);
            this.btnSaleSearch.TabIndex = 38;
            this.btnSaleSearch.Text = "Search Sale";
            this.btnSaleSearch.UseVisualStyleBackColor = true;
            this.btnSaleSearch.Click += new System.EventHandler(this.btnSaleSearch_Click);
            // 
            // lblSaleToCancel
            // 
            this.lblSaleToCancel.AutoSize = true;
            this.lblSaleToCancel.Location = new System.Drawing.Point(13, 36);
            this.lblSaleToCancel.Name = "lblSaleToCancel";
            this.lblSaleToCancel.Size = new System.Drawing.Size(80, 13);
            this.lblSaleToCancel.TabIndex = 39;
            this.lblSaleToCancel.Text = "Sale to Search:";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.salesBindingSource;
            this.comboBox2.DisplayMember = "sale_id";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(16, 52);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(147, 21);
            this.comboBox2.TabIndex = 40;
            this.comboBox2.ValueMember = "sale_id";
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
            // salesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 729);
            this.Controls.Add(this.pnlPrevSaleCancel);
            this.Controls.Add(this.btnSalesBack);
            this.Controls.Add(this.pnlAddSale);
            this.Controls.Add(this.cmbSalesMenu);
            this.Name = "salesForm";
            this.Text = "salesForm";
            this.Load += new System.EventHandler(this.salesForm_Load_1);
            this.pnlAddSale.ResumeLayout(false);
            this.pnlAddSale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._stockI_TDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            this.pnlPrevSaleCancel.ResumeLayout(false);
            this.pnlPrevSaleCancel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockITDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSalesBack;
        private System.Windows.Forms.Panel pnlAddSale;
        private System.Windows.Forms.ComboBox cbxSale_Item;
        private System.Windows.Forms.Button btnAddToSale;
        private System.Windows.Forms.Button btnCompleteSale;
        private System.Windows.Forms.Label lblTotalProduct;
        private System.Windows.Forms.ListBox lbxSaleReceipt;
        private System.Windows.Forms.TextBox txtTotalProduct;
        private System.Windows.Forms.Label lblSaleItem;
        private System.Windows.Forms.ComboBox cmbSalesMenu;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblMethodOfPayment_Sales;
        private _stockI_TDataSet _stockI_TDataSet;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private _stockI_TDataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private System.Windows.Forms.Button btnPrintReceipt_Sales;
        private System.Windows.Forms.Button btnRemoveSaleItem;
        private System.Windows.Forms.Button btnCancelSaleBusy;
        private System.Windows.Forms.Panel pnlPrevSaleCancel;
        private System.Windows.Forms.Button btnSaleSearch;
        private System.Windows.Forms.ListBox lbxPrevSaleDisplay;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label lblSaleToCancel;
        private System.Windows.Forms.BindingSource stockITDataSetBindingSource;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private _stockI_TDataSetTableAdapters.SalesTableAdapter salesTableAdapter;
    }
}