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
            this.btnNewSale = new System.Windows.Forms.Button();
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
            this.btnSearch = new System.Windows.Forms.Button();
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
            this.pnlCustoms = new System.Windows.Forms.Panel();
            this.btnNewSalecms = new System.Windows.Forms.Button();
            this.btnAddLabour = new System.Windows.Forms.Button();
            this.txtLabour = new System.Windows.Forms.TextBox();
            this.lblLabour = new System.Windows.Forms.Label();
            this.txtCmsID = new System.Windows.Forms.TextBox();
            this.btnCancelCms = new System.Windows.Forms.Button();
            this.btnPrintCms = new System.Windows.Forms.Button();
            this.btnAddCustom = new System.Windows.Forms.Button();
            this.btnCompletecms = new System.Windows.Forms.Button();
            this.lbxCustomReceipt = new System.Windows.Forms.ListBox();
            this.lblCmID = new System.Windows.Forms.Label();
            this.pnlCompleteCustom = new System.Windows.Forms.Panel();
            this.btnCancelcmsSale = new System.Windows.Forms.Button();
            this.btnCompletecmsSale = new System.Windows.Forms.Button();
            this.lblcmsTotal = new System.Windows.Forms.Label();
            this.lblcmsPaid = new System.Windows.Forms.Label();
            this.txtTotalcmsPaid = new System.Windows.Forms.TextBox();
            this.cmbPaymentcms = new System.Windows.Forms.ComboBox();
            this.lblcmsPaidMeth = new System.Windows.Forms.Label();
            this.ttGeneral = new System.Windows.Forms.ToolTip(this.components);
            this.txtSaleReturn = new System.Windows.Forms.TextBox();
            this.txtProductReturn = new System.Windows.Forms.TextBox();
            this.pnlReturns = new System.Windows.Forms.Panel();
            this.lblSaleReturnID = new System.Windows.Forms.Label();
            this.btnRefund = new System.Windows.Forms.Button();
            this.lblIDReturn = new System.Windows.Forms.Label();
            this.btnRefreshSearch = new System.Windows.Forms.Button();
            this.txtSaleSearch = new System.Windows.Forms.TextBox();
            this.lblSaleIDSearch = new System.Windows.Forms.Label();
            this.rtxpdf = new System.Windows.Forms.RichTextBox();
            this.btnPrintSearch = new System.Windows.Forms.Button();
            this.pnlAddSale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._stockI_TDataSet)).BeginInit();
            this.pnlPrevSaleCancel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockITDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesBindingSource)).BeginInit();
            this.pnlCompleteSale.SuspendLayout();
            this.pnlCustoms.SuspendLayout();
            this.pnlCompleteCustom.SuspendLayout();
            this.pnlReturns.SuspendLayout();
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
            this.pnlAddSale.Controls.Add(this.btnNewSale);
            this.pnlAddSale.Controls.Add(this.txtProductID_Sale);
            this.pnlAddSale.Controls.Add(this.btnCancelSaleBusy);
            this.pnlAddSale.Controls.Add(this.btnRemoveSaleItem);
            this.pnlAddSale.Controls.Add(this.btnPrintReceipt_Sales);
            this.pnlAddSale.Controls.Add(this.btnAddToSale);
            this.pnlAddSale.Controls.Add(this.btnCompleteSale);
            this.pnlAddSale.Controls.Add(this.lbxSaleReceipt);
            this.pnlAddSale.Controls.Add(this.lblSaleItem);
            this.pnlAddSale.Location = new System.Drawing.Point(3, 38);
            this.pnlAddSale.Name = "pnlAddSale";
            this.pnlAddSale.Size = new System.Drawing.Size(642, 237);
            this.pnlAddSale.TabIndex = 6;
            this.pnlAddSale.Visible = false;
            this.pnlAddSale.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAddSale_Paint);
            // 
            // btnNewSale
            // 
            this.btnNewSale.Location = new System.Drawing.Point(213, 167);
            this.btnNewSale.Name = "btnNewSale";
            this.btnNewSale.Size = new System.Drawing.Size(160, 27);
            this.btnNewSale.TabIndex = 27;
            this.btnNewSale.Text = "New Sale";
            this.btnNewSale.UseVisualStyleBackColor = true;
            this.btnNewSale.Click += new System.EventHandler(this.btnNewSale_Click);
            // 
            // txtProductID_Sale
            // 
            this.txtProductID_Sale.Location = new System.Drawing.Point(7, 29);
            this.txtProductID_Sale.Name = "txtProductID_Sale";
            this.txtProductID_Sale.Size = new System.Drawing.Size(159, 20);
            this.txtProductID_Sale.TabIndex = 1;
            this.ttGeneral.SetToolTip(this.txtProductID_Sale, "Type in the barcode of the product.");
            // 
            // btnCancelSaleBusy
            // 
            this.btnCancelSaleBusy.Location = new System.Drawing.Point(212, 132);
            this.btnCancelSaleBusy.Name = "btnCancelSaleBusy";
            this.btnCancelSaleBusy.Size = new System.Drawing.Size(160, 27);
            this.btnCancelSaleBusy.TabIndex = 5;
            this.btnCancelSaleBusy.Text = "Cancel Sale";
            this.btnCancelSaleBusy.UseVisualStyleBackColor = true;
            this.btnCancelSaleBusy.Click += new System.EventHandler(this.btnCancelSaleBusy_Click);
            // 
            // btnRemoveSaleItem
            // 
            this.btnRemoveSaleItem.Location = new System.Drawing.Point(214, 65);
            this.btnRemoveSaleItem.Name = "btnRemoveSaleItem";
            this.btnRemoveSaleItem.Size = new System.Drawing.Size(159, 25);
            this.btnRemoveSaleItem.TabIndex = 3;
            this.btnRemoveSaleItem.Text = "Undo";
            this.btnRemoveSaleItem.UseVisualStyleBackColor = true;
            this.btnRemoveSaleItem.Click += new System.EventHandler(this.btnRemoveSaleItem_Click);
            // 
            // btnPrintReceipt_Sales
            // 
            this.btnPrintReceipt_Sales.Location = new System.Drawing.Point(212, 198);
            this.btnPrintReceipt_Sales.Name = "btnPrintReceipt_Sales";
            this.btnPrintReceipt_Sales.Size = new System.Drawing.Size(160, 31);
            this.btnPrintReceipt_Sales.TabIndex = 6;
            this.btnPrintReceipt_Sales.Text = "Print Receipt";
            this.btnPrintReceipt_Sales.UseVisualStyleBackColor = true;
            // 
            // btnAddToSale
            // 
            this.btnAddToSale.Location = new System.Drawing.Point(213, 33);
            this.btnAddToSale.Name = "btnAddToSale";
            this.btnAddToSale.Size = new System.Drawing.Size(159, 26);
            this.btnAddToSale.TabIndex = 2;
            this.btnAddToSale.Text = "Add Item";
            this.btnAddToSale.UseVisualStyleBackColor = true;
            this.btnAddToSale.Click += new System.EventHandler(this.btnAddToSale_Click);
            // 
            // btnCompleteSale
            // 
            this.btnCompleteSale.Location = new System.Drawing.Point(214, 96);
            this.btnCompleteSale.Name = "btnCompleteSale";
            this.btnCompleteSale.Size = new System.Drawing.Size(160, 30);
            this.btnCompleteSale.TabIndex = 4;
            this.btnCompleteSale.Text = "Complete Sale";
            this.btnCompleteSale.UseVisualStyleBackColor = true;
            this.btnCompleteSale.Click += new System.EventHandler(this.btnCompleteSale_Click);
            // 
            // lbxSaleReceipt
            // 
            this.lbxSaleReceipt.FormattingEnabled = true;
            this.lbxSaleReceipt.Location = new System.Drawing.Point(404, 7);
            this.lbxSaleReceipt.Name = "lbxSaleReceipt";
            this.lbxSaleReceipt.Size = new System.Drawing.Size(222, 225);
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
            this.cmbSalesMenu.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSalesMenu.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSalesMenu.FormattingEnabled = true;
            this.cmbSalesMenu.Items.AddRange(new object[] {
            "New Sale",
            "New Custom Sale",
            "Returns",
            "Search Previous Sale",
            "Search Stock",
            "Place Order"});
            this.cmbSalesMenu.Location = new System.Drawing.Point(12, 12);
            this.cmbSalesMenu.Name = "cmbSalesMenu";
            this.cmbSalesMenu.Size = new System.Drawing.Size(121, 21);
            this.cmbSalesMenu.TabIndex = 5;
            this.ttGeneral.SetToolTip(this.cmbSalesMenu, "Choose an action you want to perform.");
            this.cmbSalesMenu.SelectedIndexChanged += new System.EventHandler(this.cmbSalesMenu_SelectedIndexChanged);
            // 
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // pnlPrevSaleCancel
            // 
            this.pnlPrevSaleCancel.Controls.Add(this.btnPrintSearch);
            this.pnlPrevSaleCancel.Controls.Add(this.rtxpdf);
            this.pnlPrevSaleCancel.Controls.Add(this.lblSaleIDSearch);
            this.pnlPrevSaleCancel.Controls.Add(this.txtSaleSearch);
            this.pnlPrevSaleCancel.Controls.Add(this.btnRefreshSearch);
            this.pnlPrevSaleCancel.Controls.Add(this.btnSearch);
            this.pnlPrevSaleCancel.Location = new System.Drawing.Point(427, 513);
            this.pnlPrevSaleCancel.Name = "pnlPrevSaleCancel";
            this.pnlPrevSaleCancel.Size = new System.Drawing.Size(389, 217);
            this.pnlPrevSaleCancel.TabIndex = 9;
            this.pnlPrevSaleCancel.Visible = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(16, 71);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(147, 41);
            this.btnSearch.TabIndex = 42;
            this.btnSearch.Text = "Open Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.pnlCompleteSale.Location = new System.Drawing.Point(651, 38);
            this.pnlCompleteSale.Name = "pnlCompleteSale";
            this.pnlCompleteSale.Size = new System.Drawing.Size(286, 206);
            this.pnlCompleteSale.TabIndex = 10;
            this.pnlCompleteSale.Visible = false;
            this.pnlCompleteSale.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCompleteSale_Paint);
            // 
            // btnCancelSale
            // 
            this.btnCancelSale.Location = new System.Drawing.Point(148, 164);
            this.btnCancelSale.Name = "btnCancelSale";
            this.btnCancelSale.Size = new System.Drawing.Size(129, 28);
            this.btnCancelSale.TabIndex = 58;
            this.btnCancelSale.Text = "Cancel";
            this.btnCancelSale.UseVisualStyleBackColor = true;
            this.btnCancelSale.Click += new System.EventHandler(this.btnCancelSale_Click);
            // 
            // btnCompleteSalePaid
            // 
            this.btnCompleteSalePaid.Location = new System.Drawing.Point(16, 164);
            this.btnCompleteSalePaid.Name = "btnCompleteSalePaid";
            this.btnCompleteSalePaid.Size = new System.Drawing.Size(129, 28);
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
            this.ttGeneral.SetToolTip(this.cbxSpecialOrder, "Tick if it is a Special Order sale.");
            this.cbxSpecialOrder.UseVisualStyleBackColor = true;
            // 
            // txtPaid
            // 
            this.txtPaid.Location = new System.Drawing.Point(13, 69);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(159, 20);
            this.txtPaid.TabIndex = 53;
            this.ttGeneral.SetToolTip(this.txtPaid, "Type in the amount paid.\r\n*Must only be digits!");
            this.txtPaid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPaid_KeyDown);
            this.txtPaid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPaid_KeyPress);
            // 
            // cbxMethodOfPayment
            // 
            this.cbxMethodOfPayment.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxMethodOfPayment.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxMethodOfPayment.FormattingEnabled = true;
            this.cbxMethodOfPayment.Items.AddRange(new object[] {
            "Cash",
            "Credit",
            "Debit",
            "Cheque"});
            this.cbxMethodOfPayment.Location = new System.Drawing.Point(16, 110);
            this.cbxMethodOfPayment.Name = "cbxMethodOfPayment";
            this.cbxMethodOfPayment.Size = new System.Drawing.Size(158, 21);
            this.cbxMethodOfPayment.TabIndex = 52;
            this.ttGeneral.SetToolTip(this.cbxMethodOfPayment, "Choose method of payment.");
            this.cbxMethodOfPayment.SelectedIndexChanged += new System.EventHandler(this.cbxMethodOfPayment_SelectedIndexChanged);
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
            // pnlCustoms
            // 
            this.pnlCustoms.Controls.Add(this.btnNewSalecms);
            this.pnlCustoms.Controls.Add(this.btnAddLabour);
            this.pnlCustoms.Controls.Add(this.txtLabour);
            this.pnlCustoms.Controls.Add(this.lblLabour);
            this.pnlCustoms.Controls.Add(this.txtCmsID);
            this.pnlCustoms.Controls.Add(this.btnCancelCms);
            this.pnlCustoms.Controls.Add(this.btnPrintCms);
            this.pnlCustoms.Controls.Add(this.btnAddCustom);
            this.pnlCustoms.Controls.Add(this.btnCompletecms);
            this.pnlCustoms.Controls.Add(this.lbxCustomReceipt);
            this.pnlCustoms.Controls.Add(this.lblCmID);
            this.pnlCustoms.Location = new System.Drawing.Point(3, 281);
            this.pnlCustoms.Name = "pnlCustoms";
            this.pnlCustoms.Size = new System.Drawing.Size(418, 337);
            this.pnlCustoms.TabIndex = 11;
            this.pnlCustoms.Visible = false;
            // 
            // btnNewSalecms
            // 
            this.btnNewSalecms.Enabled = false;
            this.btnNewSalecms.Location = new System.Drawing.Point(17, 264);
            this.btnNewSalecms.Name = "btnNewSalecms";
            this.btnNewSalecms.Size = new System.Drawing.Size(160, 27);
            this.btnNewSalecms.TabIndex = 30;
            this.btnNewSalecms.Text = "New Sale";
            this.btnNewSalecms.UseVisualStyleBackColor = true;
            this.btnNewSalecms.Click += new System.EventHandler(this.btnNewSalecms_Click);
            // 
            // btnAddLabour
            // 
            this.btnAddLabour.Enabled = false;
            this.btnAddLabour.Location = new System.Drawing.Point(17, 134);
            this.btnAddLabour.Name = "btnAddLabour";
            this.btnAddLabour.Size = new System.Drawing.Size(160, 34);
            this.btnAddLabour.TabIndex = 29;
            this.btnAddLabour.Text = "Add Labour";
            this.btnAddLabour.UseVisualStyleBackColor = true;
            this.btnAddLabour.Click += new System.EventHandler(this.btnAddLabour_Click);
            // 
            // txtLabour
            // 
            this.txtLabour.Enabled = false;
            this.txtLabour.Location = new System.Drawing.Point(15, 108);
            this.txtLabour.Name = "txtLabour";
            this.txtLabour.Size = new System.Drawing.Size(159, 20);
            this.txtLabour.TabIndex = 27;
            this.ttGeneral.SetToolTip(this.txtLabour, "Put in price of labour for Custom Build.\r\n*This price is based on how much work i" +
        "t was!");
            this.txtLabour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLabour_KeyPress);
            // 
            // lblLabour
            // 
            this.lblLabour.AutoSize = true;
            this.lblLabour.Enabled = false;
            this.lblLabour.Location = new System.Drawing.Point(14, 90);
            this.lblLabour.Name = "lblLabour";
            this.lblLabour.Size = new System.Drawing.Size(70, 13);
            this.lblLabour.TabIndex = 28;
            this.lblLabour.Text = "Labour Price:";
            // 
            // txtCmsID
            // 
            this.txtCmsID.Location = new System.Drawing.Point(15, 27);
            this.txtCmsID.Name = "txtCmsID";
            this.txtCmsID.Size = new System.Drawing.Size(159, 20);
            this.txtCmsID.TabIndex = 1;
            this.ttGeneral.SetToolTip(this.txtCmsID, "Type in Custom Sale ID.\r\n*Provided in slip by customer!");
            // 
            // btnCancelCms
            // 
            this.btnCancelCms.Enabled = false;
            this.btnCancelCms.Location = new System.Drawing.Point(15, 213);
            this.btnCancelCms.Name = "btnCancelCms";
            this.btnCancelCms.Size = new System.Drawing.Size(160, 33);
            this.btnCancelCms.TabIndex = 5;
            this.btnCancelCms.Text = "Cancel Sale";
            this.btnCancelCms.UseVisualStyleBackColor = true;
            this.btnCancelCms.Click += new System.EventHandler(this.btnCancelCms_Click);
            // 
            // btnPrintCms
            // 
            this.btnPrintCms.Enabled = false;
            this.btnPrintCms.Location = new System.Drawing.Point(17, 293);
            this.btnPrintCms.Name = "btnPrintCms";
            this.btnPrintCms.Size = new System.Drawing.Size(160, 33);
            this.btnPrintCms.TabIndex = 6;
            this.btnPrintCms.Text = "Print Receipt";
            this.btnPrintCms.UseVisualStyleBackColor = true;
            // 
            // btnAddCustom
            // 
            this.btnAddCustom.Location = new System.Drawing.Point(15, 53);
            this.btnAddCustom.Name = "btnAddCustom";
            this.btnAddCustom.Size = new System.Drawing.Size(159, 32);
            this.btnAddCustom.TabIndex = 2;
            this.btnAddCustom.Text = "Add Custom Sale Items";
            this.btnAddCustom.UseVisualStyleBackColor = true;
            this.btnAddCustom.Click += new System.EventHandler(this.btnAddCustom_Click);
            // 
            // btnCompletecms
            // 
            this.btnCompletecms.Enabled = false;
            this.btnCompletecms.Location = new System.Drawing.Point(17, 178);
            this.btnCompletecms.Name = "btnCompletecms";
            this.btnCompletecms.Size = new System.Drawing.Size(160, 34);
            this.btnCompletecms.TabIndex = 4;
            this.btnCompletecms.Text = "Complete Custom Sale";
            this.btnCompletecms.UseVisualStyleBackColor = true;
            this.btnCompletecms.Click += new System.EventHandler(this.btnCompletecms_Click);
            // 
            // lbxCustomReceipt
            // 
            this.lbxCustomReceipt.FormattingEnabled = true;
            this.lbxCustomReceipt.Location = new System.Drawing.Point(183, 20);
            this.lbxCustomReceipt.Name = "lbxCustomReceipt";
            this.lbxCustomReceipt.Size = new System.Drawing.Size(222, 303);
            this.lbxCustomReceipt.TabIndex = 25;
            this.lbxCustomReceipt.SelectedIndexChanged += new System.EventHandler(this.lbxCustomReceipt_SelectedIndexChanged);
            // 
            // lblCmID
            // 
            this.lblCmID.AutoSize = true;
            this.lblCmID.Location = new System.Drawing.Point(14, 9);
            this.lblCmID.Name = "lblCmID";
            this.lblCmID.Size = new System.Drawing.Size(86, 13);
            this.lblCmID.TabIndex = 26;
            this.lblCmID.Text = "Custom Sale ID: ";
            // 
            // pnlCompleteCustom
            // 
            this.pnlCompleteCustom.Controls.Add(this.btnCancelcmsSale);
            this.pnlCompleteCustom.Controls.Add(this.btnCompletecmsSale);
            this.pnlCompleteCustom.Controls.Add(this.lblcmsTotal);
            this.pnlCompleteCustom.Controls.Add(this.lblcmsPaid);
            this.pnlCompleteCustom.Controls.Add(this.txtTotalcmsPaid);
            this.pnlCompleteCustom.Controls.Add(this.cmbPaymentcms);
            this.pnlCompleteCustom.Controls.Add(this.lblcmsPaidMeth);
            this.pnlCompleteCustom.Location = new System.Drawing.Point(427, 281);
            this.pnlCompleteCustom.Name = "pnlCompleteCustom";
            this.pnlCompleteCustom.Size = new System.Drawing.Size(286, 226);
            this.pnlCompleteCustom.TabIndex = 13;
            this.pnlCompleteCustom.Visible = false;
            this.pnlCompleteCustom.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCompleteCustom_Paint);
            // 
            // btnCancelcmsSale
            // 
            this.btnCancelcmsSale.Location = new System.Drawing.Point(148, 164);
            this.btnCancelcmsSale.Name = "btnCancelcmsSale";
            this.btnCancelcmsSale.Size = new System.Drawing.Size(129, 54);
            this.btnCancelcmsSale.TabIndex = 58;
            this.btnCancelcmsSale.Text = "Cancel";
            this.btnCancelcmsSale.UseVisualStyleBackColor = true;
            this.btnCancelcmsSale.Click += new System.EventHandler(this.btnCancelcmsSale_Click);
            // 
            // btnCompletecmsSale
            // 
            this.btnCompletecmsSale.Location = new System.Drawing.Point(16, 164);
            this.btnCompletecmsSale.Name = "btnCompletecmsSale";
            this.btnCompletecmsSale.Size = new System.Drawing.Size(129, 54);
            this.btnCompletecmsSale.TabIndex = 57;
            this.btnCompletecmsSale.Text = "Complete Sale";
            this.btnCompletecmsSale.UseVisualStyleBackColor = true;
            this.btnCompletecmsSale.Click += new System.EventHandler(this.btnCompletecmsSale_Click);
            // 
            // lblcmsTotal
            // 
            this.lblcmsTotal.AutoSize = true;
            this.lblcmsTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcmsTotal.Location = new System.Drawing.Point(10, 13);
            this.lblcmsTotal.Name = "lblcmsTotal";
            this.lblcmsTotal.Size = new System.Drawing.Size(171, 25);
            this.lblcmsTotal.TabIndex = 56;
            this.lblcmsTotal.Text = "Total Payable: ";
            // 
            // lblcmsPaid
            // 
            this.lblcmsPaid.AutoSize = true;
            this.lblcmsPaid.Location = new System.Drawing.Point(13, 53);
            this.lblcmsPaid.Name = "lblcmsPaid";
            this.lblcmsPaid.Size = new System.Drawing.Size(31, 13);
            this.lblcmsPaid.TabIndex = 55;
            this.lblcmsPaid.Text = "Paid:";
            // 
            // txtTotalcmsPaid
            // 
            this.txtTotalcmsPaid.Location = new System.Drawing.Point(13, 69);
            this.txtTotalcmsPaid.Name = "txtTotalcmsPaid";
            this.txtTotalcmsPaid.Size = new System.Drawing.Size(159, 20);
            this.txtTotalcmsPaid.TabIndex = 53;
            this.ttGeneral.SetToolTip(this.txtTotalcmsPaid, "Type in the amount paid.\r\n*Must only be digits!");
            this.txtTotalcmsPaid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalcmsPaid_KeyPress);
            // 
            // cmbPaymentcms
            // 
            this.cmbPaymentcms.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPaymentcms.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPaymentcms.FormattingEnabled = true;
            this.cmbPaymentcms.Items.AddRange(new object[] {
            "Cash",
            "Credit",
            "Debit",
            "Cheque"});
            this.cmbPaymentcms.Location = new System.Drawing.Point(16, 110);
            this.cmbPaymentcms.Name = "cmbPaymentcms";
            this.cmbPaymentcms.Size = new System.Drawing.Size(158, 21);
            this.cmbPaymentcms.TabIndex = 52;
            this.ttGeneral.SetToolTip(this.cmbPaymentcms, "Choose method of payment.\r\n*Should be one provided!");
            this.cmbPaymentcms.SelectedIndexChanged += new System.EventHandler(this.cmbPaymentcms_SelectedIndexChanged);
            this.cmbPaymentcms.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cmbPaymentcms_KeyDown);
            this.cmbPaymentcms.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbPaymentcms_KeyPress);
            // 
            // lblcmsPaidMeth
            // 
            this.lblcmsPaidMeth.AutoSize = true;
            this.lblcmsPaidMeth.Location = new System.Drawing.Point(13, 94);
            this.lblcmsPaidMeth.Name = "lblcmsPaidMeth";
            this.lblcmsPaidMeth.Size = new System.Drawing.Size(102, 13);
            this.lblcmsPaidMeth.TabIndex = 51;
            this.lblcmsPaidMeth.Text = "Method of Payment:";
            this.lblcmsPaidMeth.Click += new System.EventHandler(this.label3_Click);
            // 
            // ttGeneral
            // 
            this.ttGeneral.AutoPopDelay = 5000;
            this.ttGeneral.InitialDelay = 100;
            this.ttGeneral.IsBalloon = true;
            this.ttGeneral.ReshowDelay = 100;
            this.ttGeneral.Tag = "";
            this.ttGeneral.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ttGeneral.ToolTipTitle = "General Help";
            // 
            // txtSaleReturn
            // 
            this.txtSaleReturn.Location = new System.Drawing.Point(10, 48);
            this.txtSaleReturn.Name = "txtSaleReturn";
            this.txtSaleReturn.Size = new System.Drawing.Size(159, 20);
            this.txtSaleReturn.TabIndex = 52;
            this.ttGeneral.SetToolTip(this.txtSaleReturn, "Fill in the Sale ID of the item that was bought!");
            // 
            // txtProductReturn
            // 
            this.txtProductReturn.Location = new System.Drawing.Point(10, 89);
            this.txtProductReturn.Name = "txtProductReturn";
            this.txtProductReturn.Size = new System.Drawing.Size(159, 20);
            this.txtProductReturn.TabIndex = 49;
            this.ttGeneral.SetToolTip(this.txtProductReturn, "Fill in the Barcode of the product that is to be returned!");
            this.txtProductReturn.TextChanged += new System.EventHandler(this.txtProductReturn_TextChanged);
            // 
            // pnlReturns
            // 
            this.pnlReturns.Controls.Add(this.txtSaleReturn);
            this.pnlReturns.Controls.Add(this.lblSaleReturnID);
            this.pnlReturns.Controls.Add(this.btnRefund);
            this.pnlReturns.Controls.Add(this.txtProductReturn);
            this.pnlReturns.Controls.Add(this.lblIDReturn);
            this.pnlReturns.Location = new System.Drawing.Point(719, 288);
            this.pnlReturns.Name = "pnlReturns";
            this.pnlReturns.Size = new System.Drawing.Size(179, 219);
            this.pnlReturns.TabIndex = 14;
            this.pnlReturns.Visible = false;
            // 
            // lblSaleReturnID
            // 
            this.lblSaleReturnID.AutoSize = true;
            this.lblSaleReturnID.Location = new System.Drawing.Point(9, 30);
            this.lblSaleReturnID.Name = "lblSaleReturnID";
            this.lblSaleReturnID.Size = new System.Drawing.Size(48, 13);
            this.lblSaleReturnID.TabIndex = 53;
            this.lblSaleReturnID.Text = "Sale ID: ";
            // 
            // btnRefund
            // 
            this.btnRefund.Location = new System.Drawing.Point(10, 126);
            this.btnRefund.Name = "btnRefund";
            this.btnRefund.Size = new System.Drawing.Size(159, 63);
            this.btnRefund.TabIndex = 51;
            this.btnRefund.Text = "Get Refund";
            this.btnRefund.UseVisualStyleBackColor = true;
            this.btnRefund.Click += new System.EventHandler(this.btnRefund_Click_1);
            // 
            // lblIDReturn
            // 
            this.lblIDReturn.AutoSize = true;
            this.lblIDReturn.Location = new System.Drawing.Point(9, 71);
            this.lblIDReturn.Name = "lblIDReturn";
            this.lblIDReturn.Size = new System.Drawing.Size(64, 13);
            this.lblIDReturn.TabIndex = 50;
            this.lblIDReturn.Text = "Product ID: ";
            // 
            // btnRefreshSearch
            // 
            this.btnRefreshSearch.Location = new System.Drawing.Point(16, 118);
            this.btnRefreshSearch.Name = "btnRefreshSearch";
            this.btnRefreshSearch.Size = new System.Drawing.Size(147, 41);
            this.btnRefreshSearch.TabIndex = 44;
            this.btnRefreshSearch.Text = "Refresh Search";
            this.btnRefreshSearch.UseVisualStyleBackColor = true;
            // 
            // txtSaleSearch
            // 
            this.txtSaleSearch.Location = new System.Drawing.Point(20, 41);
            this.txtSaleSearch.Name = "txtSaleSearch";
            this.txtSaleSearch.Size = new System.Drawing.Size(143, 20);
            this.txtSaleSearch.TabIndex = 45;
            // 
            // lblSaleIDSearch
            // 
            this.lblSaleIDSearch.AutoSize = true;
            this.lblSaleIDSearch.Location = new System.Drawing.Point(17, 23);
            this.lblSaleIDSearch.Name = "lblSaleIDSearch";
            this.lblSaleIDSearch.Size = new System.Drawing.Size(94, 13);
            this.lblSaleIDSearch.TabIndex = 46;
            this.lblSaleIDSearch.Text = "Sale ID to Search:";
            // 
            // rtxpdf
            // 
            this.rtxpdf.Location = new System.Drawing.Point(180, 15);
            this.rtxpdf.Name = "rtxpdf";
            this.rtxpdf.Size = new System.Drawing.Size(159, 186);
            this.rtxpdf.TabIndex = 47;
            this.rtxpdf.Text = "";
            // 
            // btnPrintSearch
            // 
            this.btnPrintSearch.Enabled = false;
            this.btnPrintSearch.Location = new System.Drawing.Point(16, 165);
            this.btnPrintSearch.Name = "btnPrintSearch";
            this.btnPrintSearch.Size = new System.Drawing.Size(147, 36);
            this.btnPrintSearch.TabIndex = 48;
            this.btnPrintSearch.Text = "Print Search";
            this.btnPrintSearch.UseVisualStyleBackColor = true;
            // 
            // salesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 733);
            this.Controls.Add(this.pnlReturns);
            this.Controls.Add(this.pnlCompleteCustom);
            this.Controls.Add(this.pnlCustoms);
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
            this.pnlCustoms.ResumeLayout(false);
            this.pnlCustoms.PerformLayout();
            this.pnlCompleteCustom.ResumeLayout(false);
            this.pnlCompleteCustom.PerformLayout();
            this.pnlReturns.ResumeLayout(false);
            this.pnlReturns.PerformLayout();
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
        private System.Windows.Forms.BindingSource stockITDataSetBindingSource;
        private System.Windows.Forms.BindingSource salesBindingSource;
        private _stockI_TDataSetTableAdapters.SalesTableAdapter salesTableAdapter;
        private System.Windows.Forms.TextBox txtProductID_Sale;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel pnlCompleteSale;
        private System.Windows.Forms.Button btnCancelSale;
        private System.Windows.Forms.Button btnCompleteSalePaid;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.CheckBox cbxSpecialOrder;
        private System.Windows.Forms.TextBox txtPaid;
        private System.Windows.Forms.ComboBox cbxMethodOfPayment;
        private System.Windows.Forms.Label lblMethodOfPayment_Sales;
        private System.Windows.Forms.Panel pnlCustoms;
        private System.Windows.Forms.TextBox txtCmsID;
        private System.Windows.Forms.Button btnCancelCms;
        private System.Windows.Forms.Button btnPrintCms;
        private System.Windows.Forms.Button btnAddCustom;
        private System.Windows.Forms.Button btnCompletecms;
        private System.Windows.Forms.ListBox lbxCustomReceipt;
        private System.Windows.Forms.Label lblCmID;
        private System.Windows.Forms.TextBox txtLabour;
        private System.Windows.Forms.Label lblLabour;
        private System.Windows.Forms.Button btnAddLabour;
        private System.Windows.Forms.Panel pnlCompleteCustom;
        private System.Windows.Forms.Button btnCancelcmsSale;
        private System.Windows.Forms.Button btnCompletecmsSale;
        private System.Windows.Forms.Label lblcmsTotal;
        private System.Windows.Forms.Label lblcmsPaid;
        private System.Windows.Forms.TextBox txtTotalcmsPaid;
        private System.Windows.Forms.ComboBox cmbPaymentcms;
        private System.Windows.Forms.Label lblcmsPaidMeth;
        private System.Windows.Forms.Button btnNewSale;
        private System.Windows.Forms.Button btnNewSalecms;
        private System.Windows.Forms.ToolTip ttGeneral;
        private System.Windows.Forms.Panel pnlReturns;
        private System.Windows.Forms.TextBox txtSaleReturn;
        private System.Windows.Forms.Label lblSaleReturnID;
        private System.Windows.Forms.Button btnRefund;
        private System.Windows.Forms.TextBox txtProductReturn;
        private System.Windows.Forms.Label lblIDReturn;
        private System.Windows.Forms.Button btnRefreshSearch;
        private System.Windows.Forms.Label lblSaleIDSearch;
        private System.Windows.Forms.TextBox txtSaleSearch;
        private System.Windows.Forms.RichTextBox rtxpdf;
        private System.Windows.Forms.Button btnPrintSearch;
    }
}