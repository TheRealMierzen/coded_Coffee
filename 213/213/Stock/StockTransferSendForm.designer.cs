namespace _213
{
    partial class StockTransferSendForm
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
            this.btnAddToTransferList = new System.Windows.Forms.Button();
            this.txbItemIDTransfer = new System.Windows.Forms.TextBox();
            this.txbStockTransferReport = new System.Windows.Forms.TextBox();
            this.lblSelectItem = new System.Windows.Forms.Label();
            this.btnCancelSend = new System.Windows.Forms.Button();
            this.btnConfirmSend = new System.Windows.Forms.Button();
            this.cmbBranchSend = new System.Windows.Forms.ComboBox();
            this.branchesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblBranchSend = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.branchesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddToTransferList
            // 
            this.btnAddToTransferList.Location = new System.Drawing.Point(4, 86);
            this.btnAddToTransferList.Name = "btnAddToTransferList";
            this.btnAddToTransferList.Size = new System.Drawing.Size(79, 23);
            this.btnAddToTransferList.TabIndex = 21;
            this.btnAddToTransferList.Text = "Add to List";
            this.toolTip1.SetToolTip(this.btnAddToTransferList, "Click to add item to list");
            this.btnAddToTransferList.UseVisualStyleBackColor = true;
            this.btnAddToTransferList.Click += new System.EventHandler(this.btnAddToTransferList_Click);
            // 
            // txbItemIDTransfer
            // 
            this.txbItemIDTransfer.Location = new System.Drawing.Point(89, 39);
            this.txbItemIDTransfer.MaxLength = 25;
            this.txbItemIDTransfer.Name = "txbItemIDTransfer";
            this.txbItemIDTransfer.Size = new System.Drawing.Size(121, 20);
            this.txbItemIDTransfer.TabIndex = 20;
            this.toolTip1.SetToolTip(this.txbItemIDTransfer, "Scan in the ID of the item you want to transfer");
            // 
            // txbStockTransferReport
            // 
            this.txbStockTransferReport.Location = new System.Drawing.Point(227, 12);
            this.txbStockTransferReport.Multiline = true;
            this.txbStockTransferReport.Name = "txbStockTransferReport";
            this.txbStockTransferReport.ReadOnly = true;
            this.txbStockTransferReport.Size = new System.Drawing.Size(286, 247);
            this.txbStockTransferReport.TabIndex = 19;
            this.toolTip1.SetToolTip(this.txbStockTransferReport, "Here is a manifest of the items ready for transfer");
            // 
            // lblSelectItem
            // 
            this.lblSelectItem.AutoSize = true;
            this.lblSelectItem.Location = new System.Drawing.Point(9, 42);
            this.lblSelectItem.Name = "lblSelectItem";
            this.lblSelectItem.Size = new System.Drawing.Size(70, 13);
            this.lblSelectItem.TabIndex = 18;
            this.lblSelectItem.Text = "Insert Item ID";
            // 
            // btnCancelSend
            // 
            this.btnCancelSend.Location = new System.Drawing.Point(135, 236);
            this.btnCancelSend.Name = "btnCancelSend";
            this.btnCancelSend.Size = new System.Drawing.Size(75, 23);
            this.btnCancelSend.TabIndex = 17;
            this.btnCancelSend.Text = "Back";
            this.toolTip1.SetToolTip(this.btnCancelSend, "Click to close this window");
            this.btnCancelSend.UseVisualStyleBackColor = true;
            this.btnCancelSend.Click += new System.EventHandler(this.btnCancelSend_Click_1);
            // 
            // btnConfirmSend
            // 
            this.btnConfirmSend.Location = new System.Drawing.Point(12, 236);
            this.btnConfirmSend.Name = "btnConfirmSend";
            this.btnConfirmSend.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmSend.TabIndex = 16;
            this.btnConfirmSend.Text = "OK";
            this.toolTip1.SetToolTip(this.btnConfirmSend, "Click to confirm transfer");
            this.btnConfirmSend.UseVisualStyleBackColor = true;
            this.btnConfirmSend.Click += new System.EventHandler(this.btnConfirmSend_Click_1);
            // 
            // cmbBranchSend
            // 
            this.cmbBranchSend.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBranchSend.FormattingEnabled = true;
            this.cmbBranchSend.Location = new System.Drawing.Point(89, 15);
            this.cmbBranchSend.Name = "cmbBranchSend";
            this.cmbBranchSend.Size = new System.Drawing.Size(121, 21);
            this.cmbBranchSend.TabIndex = 15;
            this.toolTip1.SetToolTip(this.cmbBranchSend, "Select a branch you would like to send stock too");
            // 
            // branchesBindingSource
            // 
            this.branchesBindingSource.DataMember = "Branches";
            // 
            // lblBranchSend
            // 
            this.lblBranchSend.AutoSize = true;
            this.lblBranchSend.Location = new System.Drawing.Point(9, 15);
            this.lblBranchSend.Name = "lblBranchSend";
            this.lblBranchSend.Size = new System.Drawing.Size(74, 13);
            this.lblBranchSend.TabIndex = 14;
            this.lblBranchSend.Text = "Select Branch";
            // 
            // StockTransferSendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 265);
            this.Controls.Add(this.btnAddToTransferList);
            this.Controls.Add(this.txbItemIDTransfer);
            this.Controls.Add(this.txbStockTransferReport);
            this.Controls.Add(this.lblSelectItem);
            this.Controls.Add(this.btnCancelSend);
            this.Controls.Add(this.btnConfirmSend);
            this.Controls.Add(this.cmbBranchSend);
            this.Controls.Add(this.lblBranchSend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StockTransferSendForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockTransferSendForm";
            this.Load += new System.EventHandler(this.StockTransferSendForm_Load_1);
            this.Shown += new System.EventHandler(this.StockTransferSendForm_Shown_1);
            ((System.ComponentModel.ISupportInitialize)(this.branchesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddToTransferList;
        private System.Windows.Forms.TextBox txbItemIDTransfer;
        private System.Windows.Forms.TextBox txbStockTransferReport;
        private System.Windows.Forms.Label lblSelectItem;
        private System.Windows.Forms.Button btnCancelSend;
        private System.Windows.Forms.Button btnConfirmSend;
        private System.Windows.Forms.ComboBox cmbBranchSend;
        private System.Windows.Forms.Label lblBranchSend;
        private System.Windows.Forms.BindingSource branchesBindingSource;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}