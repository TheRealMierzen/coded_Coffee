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
            this.components = new System.ComponentModel.Container();
            this.txbMPriceAddUPD = new System.Windows.Forms.TextBox();
            this.btnCancelAddCLN = new System.Windows.Forms.Button();
            this.btnConfirmAddCLN = new System.Windows.Forms.Button();
            this.lblMPriceAddUPD = new System.Windows.Forms.Label();
            this.lblBrandAddUPD = new System.Windows.Forms.Label();
            this.lblNameAddUPD = new System.Windows.Forms.Label();
            this.txbBrandAddUPD = new System.Windows.Forms.TextBox();
            this.txbRPriceUPD = new System.Windows.Forms.TextBox();
            this.lblRPriceUPD = new System.Windows.Forms.Label();
            this.txbNameUPD = new System.Windows.Forms.TextBox();
            this.txbIDUPD = new System.Windows.Forms.TextBox();
            this.lblIDUPD = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txbMPriceAddUPD
            // 
            this.txbMPriceAddUPD.Enabled = false;
            this.txbMPriceAddUPD.Location = new System.Drawing.Point(124, 84);
            this.txbMPriceAddUPD.Name = "txbMPriceAddUPD";
            this.txbMPriceAddUPD.ReadOnly = true;
            this.txbMPriceAddUPD.ShortcutsEnabled = false;
            this.txbMPriceAddUPD.Size = new System.Drawing.Size(100, 20);
            this.txbMPriceAddUPD.TabIndex = 4;
            // 
            // btnCancelAddCLN
            // 
            this.btnCancelAddCLN.Location = new System.Drawing.Point(150, 150);
            this.btnCancelAddCLN.Name = "btnCancelAddCLN";
            this.btnCancelAddCLN.Size = new System.Drawing.Size(75, 23);
            this.btnCancelAddCLN.TabIndex = 16;
            this.btnCancelAddCLN.Text = "Back";
            this.toolTip1.SetToolTip(this.btnCancelAddCLN, "Click to close this window");
            this.btnCancelAddCLN.UseVisualStyleBackColor = true;
            this.btnCancelAddCLN.Click += new System.EventHandler(this.btnCancelAddCLN_Click);
            // 
            // btnConfirmAddCLN
            // 
            this.btnConfirmAddCLN.Location = new System.Drawing.Point(12, 150);
            this.btnConfirmAddCLN.Name = "btnConfirmAddCLN";
            this.btnConfirmAddCLN.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmAddCLN.TabIndex = 15;
            this.btnConfirmAddCLN.Text = "OK";
            this.toolTip1.SetToolTip(this.btnConfirmAddCLN, "Click to confirm changes to Item");
            this.btnConfirmAddCLN.UseVisualStyleBackColor = true;
            this.btnConfirmAddCLN.Click += new System.EventHandler(this.btnConfirmAddCLN_Click);
            // 
            // lblMPriceAddUPD
            // 
            this.lblMPriceAddUPD.AutoSize = true;
            this.lblMPriceAddUPD.Location = new System.Drawing.Point(10, 87);
            this.lblMPriceAddUPD.Name = "lblMPriceAddUPD";
            this.lblMPriceAddUPD.Size = new System.Drawing.Size(100, 13);
            this.lblMPriceAddUPD.TabIndex = 13;
            this.lblMPriceAddUPD.Text = "Manufacturer Price:";
            // 
            // lblBrandAddUPD
            // 
            this.lblBrandAddUPD.AutoSize = true;
            this.lblBrandAddUPD.Location = new System.Drawing.Point(10, 61);
            this.lblBrandAddUPD.Name = "lblBrandAddUPD";
            this.lblBrandAddUPD.Size = new System.Drawing.Size(61, 13);
            this.lblBrandAddUPD.TabIndex = 12;
            this.lblBrandAddUPD.Text = "Item Brand:";
            // 
            // lblNameAddUPD
            // 
            this.lblNameAddUPD.AutoSize = true;
            this.lblNameAddUPD.Location = new System.Drawing.Point(9, 34);
            this.lblNameAddUPD.Name = "lblNameAddUPD";
            this.lblNameAddUPD.Size = new System.Drawing.Size(61, 13);
            this.lblNameAddUPD.TabIndex = 11;
            this.lblNameAddUPD.Text = "Item Name:";
            // 
            // txbBrandAddUPD
            // 
            this.txbBrandAddUPD.Enabled = false;
            this.txbBrandAddUPD.Location = new System.Drawing.Point(124, 58);
            this.txbBrandAddUPD.Name = "txbBrandAddUPD";
            this.txbBrandAddUPD.ReadOnly = true;
            this.txbBrandAddUPD.ShortcutsEnabled = false;
            this.txbBrandAddUPD.Size = new System.Drawing.Size(100, 20);
            this.txbBrandAddUPD.TabIndex = 3;
            // 
            // txbRPriceUPD
            // 
            this.txbRPriceUPD.Enabled = false;
            this.txbRPriceUPD.Location = new System.Drawing.Point(125, 110);
            this.txbRPriceUPD.MaxLength = 10;
            this.txbRPriceUPD.Name = "txbRPriceUPD";
            this.txbRPriceUPD.ShortcutsEnabled = false;
            this.txbRPriceUPD.Size = new System.Drawing.Size(100, 20);
            this.txbRPriceUPD.TabIndex = 5;
            this.toolTip1.SetToolTip(this.txbRPriceUPD, "Edit the retail price of the item you scanned in");
            // 
            // lblRPriceUPD
            // 
            this.lblRPriceUPD.AutoSize = true;
            this.lblRPriceUPD.Location = new System.Drawing.Point(11, 113);
            this.lblRPriceUPD.Name = "lblRPriceUPD";
            this.lblRPriceUPD.Size = new System.Drawing.Size(64, 13);
            this.lblRPriceUPD.TabIndex = 23;
            this.lblRPriceUPD.Text = "Retail Price:";
            // 
            // txbNameUPD
            // 
            this.txbNameUPD.Enabled = false;
            this.txbNameUPD.Location = new System.Drawing.Point(124, 31);
            this.txbNameUPD.Name = "txbNameUPD";
            this.txbNameUPD.ReadOnly = true;
            this.txbNameUPD.ShortcutsEnabled = false;
            this.txbNameUPD.Size = new System.Drawing.Size(100, 20);
            this.txbNameUPD.TabIndex = 2;
            // 
            // txbIDUPD
            // 
            this.txbIDUPD.Location = new System.Drawing.Point(124, 6);
            this.txbIDUPD.MaxLength = 25;
            this.txbIDUPD.Name = "txbIDUPD";
            this.txbIDUPD.ShortcutsEnabled = false;
            this.txbIDUPD.Size = new System.Drawing.Size(100, 20);
            this.txbIDUPD.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txbIDUPD, "Scan in the ID of the item");
            this.txbIDUPD.TextChanged += new System.EventHandler(this.txbIDUPD_TextChanged);
            this.txbIDUPD.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txbIDUPD_PreviewKeyDown);
            // 
            // lblIDUPD
            // 
            this.lblIDUPD.AutoSize = true;
            this.lblIDUPD.Location = new System.Drawing.Point(9, 9);
            this.lblIDUPD.Name = "lblIDUPD";
            this.lblIDUPD.Size = new System.Drawing.Size(44, 13);
            this.lblIDUPD.TabIndex = 25;
            this.lblIDUPD.Text = "Item ID:";
            // 
            // StockAddFormUPD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 183);
            this.Controls.Add(this.txbIDUPD);
            this.Controls.Add(this.lblIDUPD);
            this.Controls.Add(this.txbNameUPD);
            this.Controls.Add(this.txbRPriceUPD);
            this.Controls.Add(this.lblRPriceUPD);
            this.Controls.Add(this.txbMPriceAddUPD);
            this.Controls.Add(this.txbBrandAddUPD);
            this.Controls.Add(this.btnCancelAddCLN);
            this.Controls.Add(this.btnConfirmAddCLN);
            this.Controls.Add(this.lblMPriceAddUPD);
            this.Controls.Add(this.lblBrandAddUPD);
            this.Controls.Add(this.lblNameAddUPD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StockAddFormUPD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Stock";
            this.Load += new System.EventHandler(this.StockAddFormUPD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbMPriceAddUPD;
        private System.Windows.Forms.Button btnCancelAddCLN;
        private System.Windows.Forms.Button btnConfirmAddCLN;
        private System.Windows.Forms.Label lblMPriceAddUPD;
        private System.Windows.Forms.Label lblBrandAddUPD;
        private System.Windows.Forms.Label lblNameAddUPD;
        private System.Windows.Forms.TextBox txbBrandAddUPD;
        private System.Windows.Forms.TextBox txbRPriceUPD;
        private System.Windows.Forms.Label lblRPriceUPD;
        private System.Windows.Forms.TextBox txbNameUPD;
        private System.Windows.Forms.TextBox txbIDUPD;
        private System.Windows.Forms.Label lblIDUPD;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}