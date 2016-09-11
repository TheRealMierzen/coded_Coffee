namespace _213
{
    partial class StockAddFormCLN
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
            this.lblDescAddCLN = new System.Windows.Forms.Label();
            this.lblBrandAddCLN = new System.Windows.Forms.Label();
            this.lblPriceRetailAddCLN = new System.Windows.Forms.Label();
            this.btnConfirmAddCLN = new System.Windows.Forms.Button();
            this.btnCancelAddCLN = new System.Windows.Forms.Button();
            this.txbDescAddCLN = new System.Windows.Forms.TextBox();
            this.txbBrandAddCLN = new System.Windows.Forms.TextBox();
            this.txbPriceRetailAddCLN = new System.Windows.Forms.TextBox();
            this.tmrStockAddCLN = new System.Windows.Forms.Timer(this.components);
            this.txtManfacturerPriceCLN = new System.Windows.Forms.TextBox();
            this.lblManufacturerPriceCLN = new System.Windows.Forms.Label();
            this.lblBranchAddCLN = new System.Windows.Forms.Label();
            this.cmbBranchAddCLN = new System.Windows.Forms.ComboBox();
            this.txbWarrantyAddCLN = new System.Windows.Forms.TextBox();
            this.lblWarrantyAddCLN = new System.Windows.Forms.Label();
            this._stockI_TDataSet = new _213._stockI_TDataSet();
            this.stockITDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.branchesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.branchesTableAdapter = new _213._stockI_TDataSetTableAdapters.BranchesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this._stockI_TDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockITDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescAddCLN
            // 
            this.lblDescAddCLN.AutoSize = true;
            this.lblDescAddCLN.Location = new System.Drawing.Point(13, 27);
            this.lblDescAddCLN.Name = "lblDescAddCLN";
            this.lblDescAddCLN.Size = new System.Drawing.Size(86, 13);
            this.lblDescAddCLN.TabIndex = 0;
            this.lblDescAddCLN.Text = "Item Description:";
            // 
            // lblBrandAddCLN
            // 
            this.lblBrandAddCLN.AutoSize = true;
            this.lblBrandAddCLN.Location = new System.Drawing.Point(13, 53);
            this.lblBrandAddCLN.Name = "lblBrandAddCLN";
            this.lblBrandAddCLN.Size = new System.Drawing.Size(96, 13);
            this.lblBrandAddCLN.TabIndex = 1;
            this.lblBrandAddCLN.Text = "Item Manufacturer:";
            // 
            // lblPriceRetailAddCLN
            // 
            this.lblPriceRetailAddCLN.AutoSize = true;
            this.lblPriceRetailAddCLN.Location = new System.Drawing.Point(13, 79);
            this.lblPriceRetailAddCLN.Name = "lblPriceRetailAddCLN";
            this.lblPriceRetailAddCLN.Size = new System.Drawing.Size(87, 13);
            this.lblPriceRetailAddCLN.TabIndex = 2;
            this.lblPriceRetailAddCLN.Text = "Item Retail Price:";
            this.lblPriceRetailAddCLN.Click += new System.EventHandler(this.lblPriceRetailAddCLN_Click);
            // 
            // btnConfirmAddCLN
            // 
            this.btnConfirmAddCLN.Location = new System.Drawing.Point(17, 185);
            this.btnConfirmAddCLN.Name = "btnConfirmAddCLN";
            this.btnConfirmAddCLN.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmAddCLN.TabIndex = 4;
            this.btnConfirmAddCLN.Text = "OK";
            this.btnConfirmAddCLN.UseVisualStyleBackColor = true;
            this.btnConfirmAddCLN.Click += new System.EventHandler(this.btnConfirmAddCLN_Click);
            // 
            // btnCancelAddCLN
            // 
            this.btnCancelAddCLN.Location = new System.Drawing.Point(167, 185);
            this.btnCancelAddCLN.Name = "btnCancelAddCLN";
            this.btnCancelAddCLN.Size = new System.Drawing.Size(75, 23);
            this.btnCancelAddCLN.TabIndex = 5;
            this.btnCancelAddCLN.Text = "Cancel";
            this.btnCancelAddCLN.UseVisualStyleBackColor = true;
            this.btnCancelAddCLN.Click += new System.EventHandler(this.btnCancelAddCLN_Click);
            // 
            // txbDescAddCLN
            // 
            this.txbDescAddCLN.Location = new System.Drawing.Point(142, 24);
            this.txbDescAddCLN.Name = "txbDescAddCLN";
            this.txbDescAddCLN.Size = new System.Drawing.Size(100, 20);
            this.txbDescAddCLN.TabIndex = 6;
            // 
            // txbBrandAddCLN
            // 
            this.txbBrandAddCLN.Location = new System.Drawing.Point(142, 50);
            this.txbBrandAddCLN.Name = "txbBrandAddCLN";
            this.txbBrandAddCLN.Size = new System.Drawing.Size(100, 20);
            this.txbBrandAddCLN.TabIndex = 7;
            // 
            // txbPriceRetailAddCLN
            // 
            this.txbPriceRetailAddCLN.Location = new System.Drawing.Point(142, 76);
            this.txbPriceRetailAddCLN.Name = "txbPriceRetailAddCLN";
            this.txbPriceRetailAddCLN.Size = new System.Drawing.Size(100, 20);
            this.txbPriceRetailAddCLN.TabIndex = 8;
            // 
            // txtManfacturerPriceCLN
            // 
            this.txtManfacturerPriceCLN.Location = new System.Drawing.Point(142, 102);
            this.txtManfacturerPriceCLN.Name = "txtManfacturerPriceCLN";
            this.txtManfacturerPriceCLN.Size = new System.Drawing.Size(100, 20);
            this.txtManfacturerPriceCLN.TabIndex = 11;
            // 
            // lblManufacturerPriceCLN
            // 
            this.lblManufacturerPriceCLN.AutoSize = true;
            this.lblManufacturerPriceCLN.Location = new System.Drawing.Point(13, 105);
            this.lblManufacturerPriceCLN.Name = "lblManufacturerPriceCLN";
            this.lblManufacturerPriceCLN.Size = new System.Drawing.Size(123, 13);
            this.lblManufacturerPriceCLN.TabIndex = 10;
            this.lblManufacturerPriceCLN.Text = "Item Manufacturer Price:";
            // 
            // lblBranchAddCLN
            // 
            this.lblBranchAddCLN.AutoSize = true;
            this.lblBranchAddCLN.Location = new System.Drawing.Point(14, 157);
            this.lblBranchAddCLN.Name = "lblBranchAddCLN";
            this.lblBranchAddCLN.Size = new System.Drawing.Size(67, 13);
            this.lblBranchAddCLN.TabIndex = 12;
            this.lblBranchAddCLN.Text = "Item Branch:";
            // 
            // cmbBranchAddCLN
            // 
            this.cmbBranchAddCLN.DataSource = this.branchesBindingSource;
            this.cmbBranchAddCLN.DisplayMember = "branch_location";
            this.cmbBranchAddCLN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBranchAddCLN.FormattingEnabled = true;
            this.cmbBranchAddCLN.Location = new System.Drawing.Point(142, 154);
            this.cmbBranchAddCLN.Name = "cmbBranchAddCLN";
            this.cmbBranchAddCLN.Size = new System.Drawing.Size(100, 21);
            this.cmbBranchAddCLN.TabIndex = 13;
            this.cmbBranchAddCLN.ValueMember = "branch_location";
            // 
            // txbWarrantyAddCLN
            // 
            this.txbWarrantyAddCLN.Location = new System.Drawing.Point(142, 128);
            this.txbWarrantyAddCLN.Name = "txbWarrantyAddCLN";
            this.txbWarrantyAddCLN.Size = new System.Drawing.Size(100, 20);
            this.txbWarrantyAddCLN.TabIndex = 15;
            // 
            // lblWarrantyAddCLN
            // 
            this.lblWarrantyAddCLN.AutoSize = true;
            this.lblWarrantyAddCLN.Location = new System.Drawing.Point(14, 131);
            this.lblWarrantyAddCLN.Name = "lblWarrantyAddCLN";
            this.lblWarrantyAddCLN.Size = new System.Drawing.Size(76, 13);
            this.lblWarrantyAddCLN.TabIndex = 14;
            this.lblWarrantyAddCLN.Text = "Item Warranty:";
            // 
            // _stockI_TDataSet
            // 
            this._stockI_TDataSet.DataSetName = "_stockI_TDataSet";
            this._stockI_TDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stockITDataSetBindingSource
            // 
            this.stockITDataSetBindingSource.DataSource = this._stockI_TDataSet;
            this.stockITDataSetBindingSource.Position = 0;
            // 
            // branchesBindingSource
            // 
            this.branchesBindingSource.DataMember = "Branches";
            this.branchesBindingSource.DataSource = this.stockITDataSetBindingSource;
            // 
            // branchesTableAdapter
            // 
            this.branchesTableAdapter.ClearBeforeFill = true;
            // 
            // StockAddFormCLN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 222);
            this.Controls.Add(this.txbWarrantyAddCLN);
            this.Controls.Add(this.lblWarrantyAddCLN);
            this.Controls.Add(this.cmbBranchAddCLN);
            this.Controls.Add(this.lblBranchAddCLN);
            this.Controls.Add(this.txtManfacturerPriceCLN);
            this.Controls.Add(this.lblManufacturerPriceCLN);
            this.Controls.Add(this.txbPriceRetailAddCLN);
            this.Controls.Add(this.txbBrandAddCLN);
            this.Controls.Add(this.txbDescAddCLN);
            this.Controls.Add(this.btnCancelAddCLN);
            this.Controls.Add(this.btnConfirmAddCLN);
            this.Controls.Add(this.lblPriceRetailAddCLN);
            this.Controls.Add(this.lblBrandAddCLN);
            this.Controls.Add(this.lblDescAddCLN);
            this.Name = "StockAddFormCLN";
            this.Text = "New Item Entry";
            this.Load += new System.EventHandler(this.StockAddFormCLN_Load);
            this.Shown += new System.EventHandler(this.StockAddFormCLN_Shown);
            ((System.ComponentModel.ISupportInitialize)(this._stockI_TDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockITDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescAddCLN;
        private System.Windows.Forms.Label lblBrandAddCLN;
        private System.Windows.Forms.Label lblPriceRetailAddCLN;
        private System.Windows.Forms.Button btnConfirmAddCLN;
        private System.Windows.Forms.Button btnCancelAddCLN;
        private System.Windows.Forms.TextBox txbDescAddCLN;
        private System.Windows.Forms.TextBox txbBrandAddCLN;
        private System.Windows.Forms.TextBox txbPriceRetailAddCLN;
        private System.Windows.Forms.Timer tmrStockAddCLN;
        private System.Windows.Forms.TextBox txtManfacturerPriceCLN;
        private System.Windows.Forms.Label lblManufacturerPriceCLN;
        private System.Windows.Forms.Label lblBranchAddCLN;
        private System.Windows.Forms.ComboBox cmbBranchAddCLN;
        private System.Windows.Forms.TextBox txbWarrantyAddCLN;
        private System.Windows.Forms.Label lblWarrantyAddCLN;
        private System.Windows.Forms.BindingSource stockITDataSetBindingSource;
        private _stockI_TDataSet _stockI_TDataSet;
        private System.Windows.Forms.BindingSource branchesBindingSource;
        private _stockI_TDataSetTableAdapters.BranchesTableAdapter branchesTableAdapter;
    }
}