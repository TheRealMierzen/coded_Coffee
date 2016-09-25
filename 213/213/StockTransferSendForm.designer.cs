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
            this.btnUndoLastTransfer = new System.Windows.Forms.Button();
            this.btnAddToTransferList = new System.Windows.Forms.Button();
            this.txbItemIDTransfer = new System.Windows.Forms.TextBox();
            this.txbStockTransferReport = new System.Windows.Forms.TextBox();
            this.lblSelectItem = new System.Windows.Forms.Label();
            this.btnCancelSend = new System.Windows.Forms.Button();
            this.btnConfirmSend = new System.Windows.Forms.Button();
            this.cmbBranchSend = new System.Windows.Forms.ComboBox();
            this.lblBranchSend = new System.Windows.Forms.Label();
            this._stockI_TDataSet = new _213._stockI_TDataSet();
            this.branchesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.branchesTableAdapter = new _213._stockI_TDataSetTableAdapters.BranchesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this._stockI_TDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUndoLastTransfer
            // 
            this.btnUndoLastTransfer.Location = new System.Drawing.Point(89, 86);
            this.btnUndoLastTransfer.Name = "btnUndoLastTransfer";
            this.btnUndoLastTransfer.Size = new System.Drawing.Size(121, 23);
            this.btnUndoLastTransfer.TabIndex = 22;
            this.btnUndoLastTransfer.Text = "Undo Last Add";
            this.btnUndoLastTransfer.UseVisualStyleBackColor = true;
            // 
            // btnAddToTransferList
            // 
            this.btnAddToTransferList.Location = new System.Drawing.Point(4, 86);
            this.btnAddToTransferList.Name = "btnAddToTransferList";
            this.btnAddToTransferList.Size = new System.Drawing.Size(79, 23);
            this.btnAddToTransferList.TabIndex = 21;
            this.btnAddToTransferList.Text = "Add to List";
            this.btnAddToTransferList.UseVisualStyleBackColor = true;
            this.btnAddToTransferList.Click += new System.EventHandler(this.btnAddToTransferList_Click);
            // 
            // txbItemIDTransfer
            // 
            this.txbItemIDTransfer.Location = new System.Drawing.Point(89, 39);
            this.txbItemIDTransfer.Name = "txbItemIDTransfer";
            this.txbItemIDTransfer.Size = new System.Drawing.Size(121, 20);
            this.txbItemIDTransfer.TabIndex = 20;
            // 
            // txbStockTransferReport
            // 
            this.txbStockTransferReport.Location = new System.Drawing.Point(227, 12);
            this.txbStockTransferReport.Multiline = true;
            this.txbStockTransferReport.Name = "txbStockTransferReport";
            this.txbStockTransferReport.Size = new System.Drawing.Size(286, 247);
            this.txbStockTransferReport.TabIndex = 19;
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
            this.btnCancelSend.Text = "Cancel";
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
            this.btnConfirmSend.UseVisualStyleBackColor = true;
            this.btnConfirmSend.Click += new System.EventHandler(this.btnConfirmSend_Click_1);
            // 
            // cmbBranchSend
            // 
            this.cmbBranchSend.DataSource = this.branchesBindingSource;
            this.cmbBranchSend.DisplayMember = "branch_location";
            this.cmbBranchSend.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBranchSend.FormattingEnabled = true;
            this.cmbBranchSend.Location = new System.Drawing.Point(89, 15);
            this.cmbBranchSend.Name = "cmbBranchSend";
            this.cmbBranchSend.Size = new System.Drawing.Size(121, 21);
            this.cmbBranchSend.TabIndex = 15;
            this.cmbBranchSend.ValueMember = "branch_location";
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
            // _stockI_TDataSet
            // 
            this._stockI_TDataSet.DataSetName = "_stockI_TDataSet";
            this._stockI_TDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // branchesBindingSource
            // 
            this.branchesBindingSource.DataMember = "Branches";
            this.branchesBindingSource.DataSource = this._stockI_TDataSet;
            // 
            // branchesTableAdapter
            // 
            this.branchesTableAdapter.ClearBeforeFill = true;
            // 
            // StockTransferSendForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 265);
            this.Controls.Add(this.btnUndoLastTransfer);
            this.Controls.Add(this.btnAddToTransferList);
            this.Controls.Add(this.txbItemIDTransfer);
            this.Controls.Add(this.txbStockTransferReport);
            this.Controls.Add(this.lblSelectItem);
            this.Controls.Add(this.btnCancelSend);
            this.Controls.Add(this.btnConfirmSend);
            this.Controls.Add(this.cmbBranchSend);
            this.Controls.Add(this.lblBranchSend);
            this.Name = "StockTransferSendForm";
            this.Text = "StockTransferSendForm";
            this.Load += new System.EventHandler(this.StockTransferSendForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this._stockI_TDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.branchesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUndoLastTransfer;
        private System.Windows.Forms.Button btnAddToTransferList;
        private System.Windows.Forms.TextBox txbItemIDTransfer;
        private System.Windows.Forms.TextBox txbStockTransferReport;
        private System.Windows.Forms.Label lblSelectItem;
        private System.Windows.Forms.Button btnCancelSend;
        private System.Windows.Forms.Button btnConfirmSend;
        private System.Windows.Forms.ComboBox cmbBranchSend;
        private System.Windows.Forms.Label lblBranchSend;
        private _stockI_TDataSet _stockI_TDataSet;
        private System.Windows.Forms.BindingSource branchesBindingSource;
        private _stockI_TDataSetTableAdapters.BranchesTableAdapter branchesTableAdapter;
    }
}