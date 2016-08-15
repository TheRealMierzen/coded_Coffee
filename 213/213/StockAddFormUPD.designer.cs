namespace _213
{
    partial class StockAddFormUPD
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
            this.txbQuantityAddUPD = new System.Windows.Forms.TextBox();
            this.txbPriceAddUPD = new System.Windows.Forms.TextBox();
            this.btnCancelAddCLN = new System.Windows.Forms.Button();
            this.btnConfirmAddCLN = new System.Windows.Forms.Button();
            this.lblQuantityAddUPD = new System.Windows.Forms.Label();
            this.lblPriceAddUPD = new System.Windows.Forms.Label();
            this.lblBrandAddUPD = new System.Windows.Forms.Label();
            this.lblNameAddUPD = new System.Windows.Forms.Label();
            this.txbBrandAddUPD = new System.Windows.Forms.TextBox();
            this.cmbListItemsAddUPD = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txbQuantityAddUPD
            // 
            this.txbQuantityAddUPD.Enabled = false;
            this.txbQuantityAddUPD.Location = new System.Drawing.Point(126, 81);
            this.txbQuantityAddUPD.Name = "txbQuantityAddUPD";
            this.txbQuantityAddUPD.ShortcutsEnabled = false;
            this.txbQuantityAddUPD.Size = new System.Drawing.Size(100, 20);
            this.txbQuantityAddUPD.TabIndex = 20;
            this.txbQuantityAddUPD.TextChanged += new System.EventHandler(this.txbQuantityAddUPD_TextChanged);
            this.txbQuantityAddUPD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbQuantityAddUPD_KeyPress);
            // 
            // txbPriceAddUPD
            // 
            this.txbPriceAddUPD.Enabled = false;
            this.txbPriceAddUPD.Location = new System.Drawing.Point(126, 55);
            this.txbPriceAddUPD.Name = "txbPriceAddUPD";
            this.txbPriceAddUPD.ShortcutsEnabled = false;
            this.txbPriceAddUPD.Size = new System.Drawing.Size(100, 20);
            this.txbPriceAddUPD.TabIndex = 19;
            // 
            // btnCancelAddCLN
            // 
            this.btnCancelAddCLN.Location = new System.Drawing.Point(151, 126);
            this.btnCancelAddCLN.Name = "btnCancelAddCLN";
            this.btnCancelAddCLN.Size = new System.Drawing.Size(75, 23);
            this.btnCancelAddCLN.TabIndex = 16;
            this.btnCancelAddCLN.Text = "Cancel";
            this.btnCancelAddCLN.UseVisualStyleBackColor = true;
            this.btnCancelAddCLN.Click += new System.EventHandler(this.btnCancelAddCLN_Click);
            // 
            // btnConfirmAddCLN
            // 
            this.btnConfirmAddCLN.Location = new System.Drawing.Point(15, 126);
            this.btnConfirmAddCLN.Name = "btnConfirmAddCLN";
            this.btnConfirmAddCLN.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmAddCLN.TabIndex = 15;
            this.btnConfirmAddCLN.Text = "OK";
            this.btnConfirmAddCLN.UseVisualStyleBackColor = true;
            this.btnConfirmAddCLN.Click += new System.EventHandler(this.btnConfirmAddCLN_Click);
            // 
            // lblQuantityAddUPD
            // 
            this.lblQuantityAddUPD.AutoSize = true;
            this.lblQuantityAddUPD.Location = new System.Drawing.Point(12, 84);
            this.lblQuantityAddUPD.Name = "lblQuantityAddUPD";
            this.lblQuantityAddUPD.Size = new System.Drawing.Size(72, 13);
            this.lblQuantityAddUPD.TabIndex = 14;
            this.lblQuantityAddUPD.Text = "Item Quantity:";
            // 
            // lblPriceAddUPD
            // 
            this.lblPriceAddUPD.AutoSize = true;
            this.lblPriceAddUPD.Location = new System.Drawing.Point(12, 58);
            this.lblPriceAddUPD.Name = "lblPriceAddUPD";
            this.lblPriceAddUPD.Size = new System.Drawing.Size(57, 13);
            this.lblPriceAddUPD.TabIndex = 13;
            this.lblPriceAddUPD.Text = "Item Price:";
            // 
            // lblBrandAddUPD
            // 
            this.lblBrandAddUPD.AutoSize = true;
            this.lblBrandAddUPD.Location = new System.Drawing.Point(12, 34);
            this.lblBrandAddUPD.Name = "lblBrandAddUPD";
            this.lblBrandAddUPD.Size = new System.Drawing.Size(61, 13);
            this.lblBrandAddUPD.TabIndex = 12;
            this.lblBrandAddUPD.Text = "Item Brand:";
            // 
            // lblNameAddUPD
            // 
            this.lblNameAddUPD.AutoSize = true;
            this.lblNameAddUPD.Location = new System.Drawing.Point(12, 9);
            this.lblNameAddUPD.Name = "lblNameAddUPD";
            this.lblNameAddUPD.Size = new System.Drawing.Size(61, 13);
            this.lblNameAddUPD.TabIndex = 11;
            this.lblNameAddUPD.Text = "Item Name:";
            // 
            // txbBrandAddUPD
            // 
            this.txbBrandAddUPD.Enabled = false;
            this.txbBrandAddUPD.Location = new System.Drawing.Point(126, 31);
            this.txbBrandAddUPD.Name = "txbBrandAddUPD";
            this.txbBrandAddUPD.ShortcutsEnabled = false;
            this.txbBrandAddUPD.Size = new System.Drawing.Size(100, 20);
            this.txbBrandAddUPD.TabIndex = 18;
            // 
            // cmbListItemsAddUPD
            // 
            this.cmbListItemsAddUPD.FormattingEnabled = true;
            this.cmbListItemsAddUPD.Items.AddRange(new object[] {
            "Kry lys van name van databasis af en lees dan die brand en price van daai item af" +
                ", quantity word displayed en dan kan die user net die quantity verander"});
            this.cmbListItemsAddUPD.Location = new System.Drawing.Point(126, 9);
            this.cmbListItemsAddUPD.Name = "cmbListItemsAddUPD";
            this.cmbListItemsAddUPD.Size = new System.Drawing.Size(100, 21);
            this.cmbListItemsAddUPD.TabIndex = 22;
            this.cmbListItemsAddUPD.SelectionChangeCommitted += new System.EventHandler(this.cmbListItemsAddUPD_SelectionChangeCommitted);
            // 
            // StockAddFormUPD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 177);
            this.Controls.Add(this.cmbListItemsAddUPD);
            this.Controls.Add(this.txbQuantityAddUPD);
            this.Controls.Add(this.txbPriceAddUPD);
            this.Controls.Add(this.txbBrandAddUPD);
            this.Controls.Add(this.btnCancelAddCLN);
            this.Controls.Add(this.btnConfirmAddCLN);
            this.Controls.Add(this.lblQuantityAddUPD);
            this.Controls.Add(this.lblPriceAddUPD);
            this.Controls.Add(this.lblBrandAddUPD);
            this.Controls.Add(this.lblNameAddUPD);
            this.Name = "StockAddFormUPD";
            this.Text = "Add Stock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbQuantityAddUPD;
        private System.Windows.Forms.TextBox txbPriceAddUPD;
        private System.Windows.Forms.Button btnCancelAddCLN;
        private System.Windows.Forms.Button btnConfirmAddCLN;
        private System.Windows.Forms.Label lblQuantityAddUPD;
        private System.Windows.Forms.Label lblPriceAddUPD;
        private System.Windows.Forms.Label lblBrandAddUPD;
        private System.Windows.Forms.Label lblNameAddUPD;
        private System.Windows.Forms.TextBox txbBrandAddUPD;
        private System.Windows.Forms.ComboBox cmbListItemsAddUPD;
    }
}