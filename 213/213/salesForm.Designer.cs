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
            this.pnlCancelSale = new System.Windows.Forms.Panel();
            this.txtCancel_Sale_Nr = new System.Windows.Forms.TextBox();
            this.lblCancel_SaleNr = new System.Windows.Forms.Label();
            this.btnCancelSale = new System.Windows.Forms.Button();
            this.lbxCancel_Sale = new System.Windows.Forms.ListBox();
            this.lblCAncel_Sale = new System.Windows.Forms.Label();
            this.pnlEditSale = new System.Windows.Forms.Panel();
            this.cbxEdit_Item = new System.Windows.Forms.ComboBox();
            this.btnEditRemoveFromSale = new System.Windows.Forms.Button();
            this.txtEditSale_NR = new System.Windows.Forms.TextBox();
            this.lblEditSale_Nr = new System.Windows.Forms.Label();
            this.btnEditAddToSale = new System.Windows.Forms.Button();
            this.btnEditSaveSale = new System.Windows.Forms.Button();
            this.lblEditTotalPRoduct = new System.Windows.Forms.Label();
            this.lbx_Sale_Edit = new System.Windows.Forms.ListBox();
            this.txtEditTotalProduct = new System.Windows.Forms.TextBox();
            this.lblEditBarcode = new System.Windows.Forms.Label();
            this.lblSale_Edit = new System.Windows.Forms.Label();
            this.btnSalesBack = new System.Windows.Forms.Button();
            this.pnlAddSale = new System.Windows.Forms.Panel();
            this.cbxSale_Item = new System.Windows.Forms.ComboBox();
            this.btnAddToSale = new System.Windows.Forms.Button();
            this.btnCompleteSale = new System.Windows.Forms.Button();
            this.lblTotalProduct = new System.Windows.Forms.Label();
            this.lbxSaleReceipt = new System.Windows.Forms.ListBox();
            this.txtTotalProduct = new System.Windows.Forms.TextBox();
            this.lblSaleItem = new System.Windows.Forms.Label();
            this.lblSale = new System.Windows.Forms.Label();
            this.cmbSalesMenu = new System.Windows.Forms.ComboBox();
            this.pnlCancelSale.SuspendLayout();
            this.pnlEditSale.SuspendLayout();
            this.pnlAddSale.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCancelSale
            // 
            this.pnlCancelSale.Controls.Add(this.txtCancel_Sale_Nr);
            this.pnlCancelSale.Controls.Add(this.lblCancel_SaleNr);
            this.pnlCancelSale.Controls.Add(this.btnCancelSale);
            this.pnlCancelSale.Controls.Add(this.lbxCancel_Sale);
            this.pnlCancelSale.Controls.Add(this.lblCAncel_Sale);
            this.pnlCancelSale.Location = new System.Drawing.Point(442, 39);
            this.pnlCancelSale.Name = "pnlCancelSale";
            this.pnlCancelSale.Size = new System.Drawing.Size(405, 336);
            this.pnlCancelSale.TabIndex = 9;
            this.pnlCancelSale.Visible = false;
            // 
            // txtCancel_Sale_Nr
            // 
            this.txtCancel_Sale_Nr.Location = new System.Drawing.Point(6, 26);
            this.txtCancel_Sale_Nr.Name = "txtCancel_Sale_Nr";
            this.txtCancel_Sale_Nr.Size = new System.Drawing.Size(159, 20);
            this.txtCancel_Sale_Nr.TabIndex = 28;
            // 
            // lblCancel_SaleNr
            // 
            this.lblCancel_SaleNr.AutoSize = true;
            this.lblCancel_SaleNr.Location = new System.Drawing.Point(3, 10);
            this.lblCancel_SaleNr.Name = "lblCancel_SaleNr";
            this.lblCancel_SaleNr.Size = new System.Drawing.Size(105, 13);
            this.lblCancel_SaleNr.TabIndex = 29;
            this.lblCancel_SaleNr.Text = "Enter Sale_Number: ";
            // 
            // btnCancelSale
            // 
            this.btnCancelSale.Location = new System.Drawing.Point(182, 264);
            this.btnCancelSale.Name = "btnCancelSale";
            this.btnCancelSale.Size = new System.Drawing.Size(208, 62);
            this.btnCancelSale.TabIndex = 27;
            this.btnCancelSale.Text = "Cancel Sale";
            this.btnCancelSale.UseVisualStyleBackColor = true;
            // 
            // lbxCancel_Sale
            // 
            this.lbxCancel_Sale.FormattingEnabled = true;
            this.lbxCancel_Sale.Items.AddRange(new object[] {
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
            this.lbxCancel_Sale.Location = new System.Drawing.Point(182, 29);
            this.lbxCancel_Sale.Name = "lbxCancel_Sale";
            this.lbxCancel_Sale.Size = new System.Drawing.Size(208, 225);
            this.lbxCancel_Sale.TabIndex = 25;
            // 
            // lblCAncel_Sale
            // 
            this.lblCAncel_Sale.AutoSize = true;
            this.lblCAncel_Sale.Location = new System.Drawing.Point(183, 10);
            this.lblCAncel_Sale.Name = "lblCAncel_Sale";
            this.lblCAncel_Sale.Size = new System.Drawing.Size(108, 13);
            this.lblCAncel_Sale.TabIndex = 26;
            this.lblCAncel_Sale.Text = "Sale to be Cancelled:";
            // 
            // pnlEditSale
            // 
            this.pnlEditSale.Controls.Add(this.cbxEdit_Item);
            this.pnlEditSale.Controls.Add(this.btnEditRemoveFromSale);
            this.pnlEditSale.Controls.Add(this.txtEditSale_NR);
            this.pnlEditSale.Controls.Add(this.lblEditSale_Nr);
            this.pnlEditSale.Controls.Add(this.btnEditAddToSale);
            this.pnlEditSale.Controls.Add(this.btnEditSaveSale);
            this.pnlEditSale.Controls.Add(this.lblEditTotalPRoduct);
            this.pnlEditSale.Controls.Add(this.lbx_Sale_Edit);
            this.pnlEditSale.Controls.Add(this.txtEditTotalProduct);
            this.pnlEditSale.Controls.Add(this.lblEditBarcode);
            this.pnlEditSale.Controls.Add(this.lblSale_Edit);
            this.pnlEditSale.Location = new System.Drawing.Point(12, 381);
            this.pnlEditSale.Name = "pnlEditSale";
            this.pnlEditSale.Size = new System.Drawing.Size(405, 336);
            this.pnlEditSale.TabIndex = 8;
            this.pnlEditSale.Visible = false;
            // 
            // cbxEdit_Item
            // 
            this.cbxEdit_Item.FormattingEnabled = true;
            this.cbxEdit_Item.Location = new System.Drawing.Point(17, 74);
            this.cbxEdit_Item.Name = "cbxEdit_Item";
            this.cbxEdit_Item.Size = new System.Drawing.Size(121, 21);
            this.cbxEdit_Item.TabIndex = 37;
            // 
            // btnEditRemoveFromSale
            // 
            this.btnEditRemoveFromSale.Location = new System.Drawing.Point(17, 264);
            this.btnEditRemoveFromSale.Name = "btnEditRemoveFromSale";
            this.btnEditRemoveFromSale.Size = new System.Drawing.Size(159, 62);
            this.btnEditRemoveFromSale.TabIndex = 36;
            this.btnEditRemoveFromSale.Text = "Remove from Sale";
            this.btnEditRemoveFromSale.UseVisualStyleBackColor = true;
            // 
            // txtEditSale_NR
            // 
            this.txtEditSale_NR.Location = new System.Drawing.Point(17, 26);
            this.txtEditSale_NR.Name = "txtEditSale_NR";
            this.txtEditSale_NR.Size = new System.Drawing.Size(159, 20);
            this.txtEditSale_NR.TabIndex = 34;
            // 
            // lblEditSale_Nr
            // 
            this.lblEditSale_Nr.AutoSize = true;
            this.lblEditSale_Nr.Location = new System.Drawing.Point(14, 10);
            this.lblEditSale_Nr.Name = "lblEditSale_Nr";
            this.lblEditSale_Nr.Size = new System.Drawing.Size(105, 13);
            this.lblEditSale_Nr.TabIndex = 35;
            this.lblEditSale_Nr.Text = "Enter Sale_Number: ";
            // 
            // btnEditAddToSale
            // 
            this.btnEditAddToSale.Location = new System.Drawing.Point(18, 195);
            this.btnEditAddToSale.Name = "btnEditAddToSale";
            this.btnEditAddToSale.Size = new System.Drawing.Size(159, 59);
            this.btnEditAddToSale.TabIndex = 27;
            this.btnEditAddToSale.Text = "Add to Sale";
            this.btnEditAddToSale.UseVisualStyleBackColor = true;
            // 
            // btnEditSaveSale
            // 
            this.btnEditSaveSale.Location = new System.Drawing.Point(183, 264);
            this.btnEditSaveSale.Name = "btnEditSaveSale";
            this.btnEditSaveSale.Size = new System.Drawing.Size(208, 62);
            this.btnEditSaveSale.TabIndex = 33;
            this.btnEditSaveSale.Text = "Complete/Save Sale";
            this.btnEditSaveSale.UseVisualStyleBackColor = true;
            // 
            // lblEditTotalPRoduct
            // 
            this.lblEditTotalPRoduct.AutoSize = true;
            this.lblEditTotalPRoduct.Location = new System.Drawing.Point(14, 103);
            this.lblEditTotalPRoduct.Name = "lblEditTotalPRoduct";
            this.lblEditTotalPRoduct.Size = new System.Drawing.Size(109, 13);
            this.lblEditTotalPRoduct.TabIndex = 32;
            this.lblEditTotalPRoduct.Text = "Enter total of product:";
            // 
            // lbx_Sale_Edit
            // 
            this.lbx_Sale_Edit.FormattingEnabled = true;
            this.lbx_Sale_Edit.Items.AddRange(new object[] {
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
            this.lbx_Sale_Edit.Location = new System.Drawing.Point(183, 26);
            this.lbx_Sale_Edit.Name = "lbx_Sale_Edit";
            this.lbx_Sale_Edit.Size = new System.Drawing.Size(208, 225);
            this.lbx_Sale_Edit.TabIndex = 28;
            // 
            // txtEditTotalProduct
            // 
            this.txtEditTotalProduct.Location = new System.Drawing.Point(17, 119);
            this.txtEditTotalProduct.Name = "txtEditTotalProduct";
            this.txtEditTotalProduct.Size = new System.Drawing.Size(159, 20);
            this.txtEditTotalProduct.TabIndex = 31;
            // 
            // lblEditBarcode
            // 
            this.lblEditBarcode.AutoSize = true;
            this.lblEditBarcode.Location = new System.Drawing.Point(14, 53);
            this.lblEditBarcode.Name = "lblEditBarcode";
            this.lblEditBarcode.Size = new System.Drawing.Size(72, 13);
            this.lblEditBarcode.TabIndex = 29;
            this.lblEditBarcode.Text = "Choose Item: ";
            // 
            // lblSale_Edit
            // 
            this.lblSale_Edit.AutoSize = true;
            this.lblSale_Edit.Location = new System.Drawing.Point(180, 10);
            this.lblSale_Edit.Name = "lblSale_Edit";
            this.lblSale_Edit.Size = new System.Drawing.Size(64, 13);
            this.lblSale_Edit.TabIndex = 30;
            this.lblSale_Edit.Text = "Edited Sale:";
            // 
            // btnSalesBack
            // 
            this.btnSalesBack.Location = new System.Drawing.Point(139, 10);
            this.btnSalesBack.Name = "btnSalesBack";
            this.btnSalesBack.Size = new System.Drawing.Size(75, 23);
            this.btnSalesBack.TabIndex = 7;
            this.btnSalesBack.Text = "Back";
            this.btnSalesBack.UseVisualStyleBackColor = true;
            // 
            // pnlAddSale
            // 
            this.pnlAddSale.Controls.Add(this.cbxSale_Item);
            this.pnlAddSale.Controls.Add(this.btnAddToSale);
            this.pnlAddSale.Controls.Add(this.btnCompleteSale);
            this.pnlAddSale.Controls.Add(this.lblTotalProduct);
            this.pnlAddSale.Controls.Add(this.lbxSaleReceipt);
            this.pnlAddSale.Controls.Add(this.txtTotalProduct);
            this.pnlAddSale.Controls.Add(this.lblSaleItem);
            this.pnlAddSale.Controls.Add(this.lblSale);
            this.pnlAddSale.Location = new System.Drawing.Point(12, 39);
            this.pnlAddSale.Name = "pnlAddSale";
            this.pnlAddSale.Size = new System.Drawing.Size(424, 336);
            this.pnlAddSale.TabIndex = 6;
            this.pnlAddSale.Visible = false;
            // 
            // cbxSale_Item
            // 
            this.cbxSale_Item.FormattingEnabled = true;
            this.cbxSale_Item.Location = new System.Drawing.Point(18, 33);
            this.cbxSale_Item.Name = "cbxSale_Item";
            this.cbxSale_Item.Size = new System.Drawing.Size(121, 21);
            this.cbxSale_Item.TabIndex = 31;
            // 
            // btnAddToSale
            // 
            this.btnAddToSale.Location = new System.Drawing.Point(18, 195);
            this.btnAddToSale.Name = "btnAddToSale";
            this.btnAddToSale.Size = new System.Drawing.Size(159, 56);
            this.btnAddToSale.TabIndex = 24;
            this.btnAddToSale.Text = "Add to Sale";
            this.btnAddToSale.UseVisualStyleBackColor = true;
            // 
            // btnCompleteSale
            // 
            this.btnCompleteSale.Location = new System.Drawing.Point(186, 266);
            this.btnCompleteSale.Name = "btnCompleteSale";
            this.btnCompleteSale.Size = new System.Drawing.Size(208, 60);
            this.btnCompleteSale.TabIndex = 30;
            this.btnCompleteSale.Text = "Complete Sale";
            this.btnCompleteSale.UseVisualStyleBackColor = true;
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
            this.lbxSaleReceipt.Location = new System.Drawing.Point(186, 39);
            this.lbxSaleReceipt.Name = "lbxSaleReceipt";
            this.lbxSaleReceipt.Size = new System.Drawing.Size(208, 212);
            this.lbxSaleReceipt.TabIndex = 25;
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
            this.lblSaleItem.Location = new System.Drawing.Point(15, 10);
            this.lblSaleItem.Name = "lblSaleItem";
            this.lblSaleItem.Size = new System.Drawing.Size(89, 13);
            this.lblSaleItem.TabIndex = 26;
            this.lblSaleItem.Text = "Choose Product: ";
            // 
            // lblSale
            // 
            this.lblSale.AutoSize = true;
            this.lblSale.Location = new System.Drawing.Point(183, 10);
            this.lblSale.Name = "lblSale";
            this.lblSale.Size = new System.Drawing.Size(31, 13);
            this.lblSale.TabIndex = 27;
            this.lblSale.Text = "Sale:";
            // 
            // cmbSalesMenu
            // 
            this.cmbSalesMenu.FormattingEnabled = true;
            this.cmbSalesMenu.Items.AddRange(new object[] {
            "New Sale",
            "Edit Sale",
            "Cancel Sale",
            "Search Stock",
            "Back",
            "Exit"});
            this.cmbSalesMenu.Location = new System.Drawing.Point(12, 12);
            this.cmbSalesMenu.Name = "cmbSalesMenu";
            this.cmbSalesMenu.Size = new System.Drawing.Size(121, 21);
            this.cmbSalesMenu.TabIndex = 5;
            this.cmbSalesMenu.SelectedIndexChanged += new System.EventHandler(this.cmbSalesMenu_SelectedIndexChanged);
            // 
            // salesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 729);
            this.Controls.Add(this.pnlCancelSale);
            this.Controls.Add(this.pnlEditSale);
            this.Controls.Add(this.btnSalesBack);
            this.Controls.Add(this.pnlAddSale);
            this.Controls.Add(this.cmbSalesMenu);
            this.Name = "salesForm";
            this.Text = "salesForm";
            this.pnlCancelSale.ResumeLayout(false);
            this.pnlCancelSale.PerformLayout();
            this.pnlEditSale.ResumeLayout(false);
            this.pnlEditSale.PerformLayout();
            this.pnlAddSale.ResumeLayout(false);
            this.pnlAddSale.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCancelSale;
        private System.Windows.Forms.TextBox txtCancel_Sale_Nr;
        private System.Windows.Forms.Label lblCancel_SaleNr;
        private System.Windows.Forms.Button btnCancelSale;
        private System.Windows.Forms.ListBox lbxCancel_Sale;
        private System.Windows.Forms.Label lblCAncel_Sale;
        private System.Windows.Forms.Panel pnlEditSale;
        private System.Windows.Forms.ComboBox cbxEdit_Item;
        private System.Windows.Forms.Button btnEditRemoveFromSale;
        private System.Windows.Forms.TextBox txtEditSale_NR;
        private System.Windows.Forms.Label lblEditSale_Nr;
        private System.Windows.Forms.Button btnEditAddToSale;
        private System.Windows.Forms.Button btnEditSaveSale;
        private System.Windows.Forms.Label lblEditTotalPRoduct;
        private System.Windows.Forms.ListBox lbx_Sale_Edit;
        private System.Windows.Forms.TextBox txtEditTotalProduct;
        private System.Windows.Forms.Label lblEditBarcode;
        private System.Windows.Forms.Label lblSale_Edit;
        private System.Windows.Forms.Button btnSalesBack;
        private System.Windows.Forms.Panel pnlAddSale;
        private System.Windows.Forms.ComboBox cbxSale_Item;
        private System.Windows.Forms.Button btnAddToSale;
        private System.Windows.Forms.Button btnCompleteSale;
        private System.Windows.Forms.Label lblTotalProduct;
        private System.Windows.Forms.ListBox lbxSaleReceipt;
        private System.Windows.Forms.TextBox txtTotalProduct;
        private System.Windows.Forms.Label lblSaleItem;
        private System.Windows.Forms.Label lblSale;
        private System.Windows.Forms.ComboBox cmbSalesMenu;
    }
}