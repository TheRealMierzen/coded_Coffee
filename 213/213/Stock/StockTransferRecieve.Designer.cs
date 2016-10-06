namespace _213
{
    partial class StockTransferRecieve
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
            this.txbRPriceUPD = new System.Windows.Forms.TextBox();
            this.lblRPriceUPD = new System.Windows.Forms.Label();
            this.txbMPriceAddUPD = new System.Windows.Forms.TextBox();
            this.txbBrandAddUPD = new System.Windows.Forms.TextBox();
            this.btnCancelAddCLN = new System.Windows.Forms.Button();
            this.btnConfirmAddCLN = new System.Windows.Forms.Button();
            this.lblMPriceAddUPD = new System.Windows.Forms.Label();
            this.lblBrandAddUPD = new System.Windows.Forms.Label();
            this.lblNameAddUPD = new System.Windows.Forms.Label();
            this.txbItemName = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // txbRPriceUPD
            // 
            this.txbRPriceUPD.Enabled = false;
            this.txbRPriceUPD.Location = new System.Drawing.Point(141, 88);
            this.txbRPriceUPD.Name = "txbRPriceUPD";
            this.txbRPriceUPD.ReadOnly = true;
            this.txbRPriceUPD.ShortcutsEnabled = false;
            this.txbRPriceUPD.Size = new System.Drawing.Size(100, 20);
            this.txbRPriceUPD.TabIndex = 34;
            this.toolTip1.SetToolTip(this.txbRPriceUPD, "Change the current retail price if needed from the transfer for this branch");
            // 
            // lblRPriceUPD
            // 
            this.lblRPriceUPD.AutoSize = true;
            this.lblRPriceUPD.Location = new System.Drawing.Point(12, 91);
            this.lblRPriceUPD.Name = "lblRPriceUPD";
            this.lblRPriceUPD.Size = new System.Drawing.Size(64, 13);
            this.lblRPriceUPD.TabIndex = 33;
            this.lblRPriceUPD.Text = "Retail Price:";
            // 
            // txbMPriceAddUPD
            // 
            this.txbMPriceAddUPD.Enabled = false;
            this.txbMPriceAddUPD.Location = new System.Drawing.Point(140, 62);
            this.txbMPriceAddUPD.Name = "txbMPriceAddUPD";
            this.txbMPriceAddUPD.ReadOnly = true;
            this.txbMPriceAddUPD.ShortcutsEnabled = false;
            this.txbMPriceAddUPD.Size = new System.Drawing.Size(100, 20);
            this.txbMPriceAddUPD.TabIndex = 31;
            this.toolTip1.SetToolTip(this.txbMPriceAddUPD, "Here is the manufacturer price from the transfer for this branch");
            // 
            // txbBrandAddUPD
            // 
            this.txbBrandAddUPD.Enabled = false;
            this.txbBrandAddUPD.Location = new System.Drawing.Point(140, 36);
            this.txbBrandAddUPD.Name = "txbBrandAddUPD";
            this.txbBrandAddUPD.ReadOnly = true;
            this.txbBrandAddUPD.ShortcutsEnabled = false;
            this.txbBrandAddUPD.Size = new System.Drawing.Size(100, 20);
            this.txbBrandAddUPD.TabIndex = 30;
            this.toolTip1.SetToolTip(this.txbBrandAddUPD, "Here is the item brand from the transfer for this branch");
            // 
            // btnCancelAddCLN
            // 
            this.btnCancelAddCLN.Enabled = false;
            this.btnCancelAddCLN.Location = new System.Drawing.Point(140, 118);
            this.btnCancelAddCLN.Name = "btnCancelAddCLN";
            this.btnCancelAddCLN.Size = new System.Drawing.Size(100, 23);
            this.btnCancelAddCLN.TabIndex = 29;
            this.btnCancelAddCLN.Text = "Complete";
            this.toolTip1.SetToolTip(this.btnCancelAddCLN, "Click to complete transfer");
            this.btnCancelAddCLN.UseVisualStyleBackColor = true;
            this.btnCancelAddCLN.Click += new System.EventHandler(this.btnCancelAddCLN_Click);
            // 
            // btnConfirmAddCLN
            // 
            this.btnConfirmAddCLN.Location = new System.Drawing.Point(12, 118);
            this.btnConfirmAddCLN.Name = "btnConfirmAddCLN";
            this.btnConfirmAddCLN.Size = new System.Drawing.Size(99, 23);
            this.btnConfirmAddCLN.TabIndex = 28;
            this.btnConfirmAddCLN.Text = "OK";
            this.toolTip1.SetToolTip(this.btnConfirmAddCLN, "Click to confirm changes");
            this.btnConfirmAddCLN.UseVisualStyleBackColor = true;
            this.btnConfirmAddCLN.Click += new System.EventHandler(this.btnConfirmAddCLN_Click);
            // 
            // lblMPriceAddUPD
            // 
            this.lblMPriceAddUPD.AutoSize = true;
            this.lblMPriceAddUPD.Location = new System.Drawing.Point(11, 65);
            this.lblMPriceAddUPD.Name = "lblMPriceAddUPD";
            this.lblMPriceAddUPD.Size = new System.Drawing.Size(100, 13);
            this.lblMPriceAddUPD.TabIndex = 27;
            this.lblMPriceAddUPD.Text = "Manufacturer Price:";
            // 
            // lblBrandAddUPD
            // 
            this.lblBrandAddUPD.AutoSize = true;
            this.lblBrandAddUPD.Location = new System.Drawing.Point(11, 39);
            this.lblBrandAddUPD.Name = "lblBrandAddUPD";
            this.lblBrandAddUPD.Size = new System.Drawing.Size(61, 13);
            this.lblBrandAddUPD.TabIndex = 26;
            this.lblBrandAddUPD.Text = "Item Brand:";
            // 
            // lblNameAddUPD
            // 
            this.lblNameAddUPD.AutoSize = true;
            this.lblNameAddUPD.Location = new System.Drawing.Point(12, 9);
            this.lblNameAddUPD.Name = "lblNameAddUPD";
            this.lblNameAddUPD.Size = new System.Drawing.Size(61, 13);
            this.lblNameAddUPD.TabIndex = 25;
            this.lblNameAddUPD.Text = "Item Name:";
            // 
            // txbItemName
            // 
            this.txbItemName.Location = new System.Drawing.Point(140, 6);
            this.txbItemName.Name = "txbItemName";
            this.txbItemName.ReadOnly = true;
            this.txbItemName.ShortcutsEnabled = false;
            this.txbItemName.Size = new System.Drawing.Size(100, 20);
            this.txbItemName.TabIndex = 35;
            this.toolTip1.SetToolTip(this.txbItemName, "Here is the item name from the transfer for this branch");
            // 
            // StockTransferRecieve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 154);
            this.Controls.Add(this.txbItemName);
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
            this.Name = "StockTransferRecieve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Transfer Recieve";
            this.Shown += new System.EventHandler(this.StockTransferRecieve_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbRPriceUPD;
        private System.Windows.Forms.Label lblRPriceUPD;
        private System.Windows.Forms.TextBox txbMPriceAddUPD;
        private System.Windows.Forms.TextBox txbBrandAddUPD;
        private System.Windows.Forms.Button btnCancelAddCLN;
        private System.Windows.Forms.Button btnConfirmAddCLN;
        private System.Windows.Forms.Label lblMPriceAddUPD;
        private System.Windows.Forms.Label lblBrandAddUPD;
        private System.Windows.Forms.Label lblNameAddUPD;
        private System.Windows.Forms.TextBox txbItemName;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}