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
            this.cmbListItemsAddUPD = new System.Windows.Forms.ComboBox();
            this.stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._stockI_TDataSet = new _213._stockI_TDataSet();
            this.stockTableAdapter = new _213._stockI_TDataSetTableAdapters.StockTableAdapter();
            this.txbRPriceUPD = new System.Windows.Forms.TextBox();
            this.lblRPriceUPD = new System.Windows.Forms.Label();
            this.tmrCheckSelectedItemUPD = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._stockI_TDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txbMPriceAddUPD
            // 
            this.txbMPriceAddUPD.Enabled = false;
            this.txbMPriceAddUPD.Location = new System.Drawing.Point(125, 62);
            this.txbMPriceAddUPD.Name = "txbMPriceAddUPD";
            this.txbMPriceAddUPD.ShortcutsEnabled = false;
            this.txbMPriceAddUPD.Size = new System.Drawing.Size(100, 20);
            this.txbMPriceAddUPD.TabIndex = 19;
            // 
            // btnCancelAddCLN
            // 
            this.btnCancelAddCLN.Location = new System.Drawing.Point(150, 150);
            this.btnCancelAddCLN.Name = "btnCancelAddCLN";
            this.btnCancelAddCLN.Size = new System.Drawing.Size(75, 23);
            this.btnCancelAddCLN.TabIndex = 16;
            this.btnCancelAddCLN.Text = "Cancel";
            this.btnCancelAddCLN.UseVisualStyleBackColor = true;
            this.btnCancelAddCLN.Click += new System.EventHandler(this.btnCancelAddCLN_Click);
            // 
            // btnConfirmAddCLN
            // 
            this.btnConfirmAddCLN.Location = new System.Drawing.Point(15, 150);
            this.btnConfirmAddCLN.Name = "btnConfirmAddCLN";
            this.btnConfirmAddCLN.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmAddCLN.TabIndex = 15;
            this.btnConfirmAddCLN.Text = "OK";
            this.btnConfirmAddCLN.UseVisualStyleBackColor = true;
            this.btnConfirmAddCLN.Click += new System.EventHandler(this.btnConfirmAddCLN_Click);
            // 
            // lblMPriceAddUPD
            // 
            this.lblMPriceAddUPD.AutoSize = true;
            this.lblMPriceAddUPD.Location = new System.Drawing.Point(11, 65);
            this.lblMPriceAddUPD.Name = "lblMPriceAddUPD";
            this.lblMPriceAddUPD.Size = new System.Drawing.Size(100, 13);
            this.lblMPriceAddUPD.TabIndex = 13;
            this.lblMPriceAddUPD.Text = "Manufacturer Price:";
            // 
            // lblBrandAddUPD
            // 
            this.lblBrandAddUPD.AutoSize = true;
            this.lblBrandAddUPD.Location = new System.Drawing.Point(11, 39);
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
            this.txbBrandAddUPD.Location = new System.Drawing.Point(125, 36);
            this.txbBrandAddUPD.Name = "txbBrandAddUPD";
            this.txbBrandAddUPD.ShortcutsEnabled = false;
            this.txbBrandAddUPD.Size = new System.Drawing.Size(100, 20);
            this.txbBrandAddUPD.TabIndex = 18;
            // 
            // cmbListItemsAddUPD
            // 
            this.cmbListItemsAddUPD.DataSource = this.stockBindingSource;
            this.cmbListItemsAddUPD.DisplayMember = "description";
            this.cmbListItemsAddUPD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListItemsAddUPD.FormattingEnabled = true;
            this.cmbListItemsAddUPD.Location = new System.Drawing.Point(126, 9);
            this.cmbListItemsAddUPD.Name = "cmbListItemsAddUPD";
            this.cmbListItemsAddUPD.Size = new System.Drawing.Size(100, 21);
            this.cmbListItemsAddUPD.TabIndex = 22;
            this.cmbListItemsAddUPD.ValueMember = "description";
            this.cmbListItemsAddUPD.SelectedIndexChanged += new System.EventHandler(this.cmbListItemsAddUPD_SelectedIndexChanged);
            this.cmbListItemsAddUPD.SelectionChangeCommitted += new System.EventHandler(this.cmbListItemsAddUPD_SelectionChangeCommitted);
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
            // stockTableAdapter
            // 
            this.stockTableAdapter.ClearBeforeFill = true;
            // 
            // txbRPriceUPD
            // 
            this.txbRPriceUPD.Enabled = false;
            this.txbRPriceUPD.Location = new System.Drawing.Point(126, 88);
            this.txbRPriceUPD.Name = "txbRPriceUPD";
            this.txbRPriceUPD.ShortcutsEnabled = false;
            this.txbRPriceUPD.Size = new System.Drawing.Size(100, 20);
            this.txbRPriceUPD.TabIndex = 24;
            // 
            // lblRPriceUPD
            // 
            this.lblRPriceUPD.AutoSize = true;
            this.lblRPriceUPD.Location = new System.Drawing.Point(12, 91);
            this.lblRPriceUPD.Name = "lblRPriceUPD";
            this.lblRPriceUPD.Size = new System.Drawing.Size(64, 13);
            this.lblRPriceUPD.TabIndex = 23;
            this.lblRPriceUPD.Text = "Retail Price:";
            // 
            // tmrCheckSelectedItemUPD
            // 
            this.tmrCheckSelectedItemUPD.Enabled = true;
            this.tmrCheckSelectedItemUPD.Tick += new System.EventHandler(this.tmrCheckSelectedItemUPD_Tick);
            // 
            // StockAddFormUPD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(237, 183);
            this.Controls.Add(this.txbRPriceUPD);
            this.Controls.Add(this.lblRPriceUPD);
            this.Controls.Add(this.cmbListItemsAddUPD);
            this.Controls.Add(this.txbMPriceAddUPD);
            this.Controls.Add(this.txbBrandAddUPD);
            this.Controls.Add(this.btnCancelAddCLN);
            this.Controls.Add(this.btnConfirmAddCLN);
            this.Controls.Add(this.lblMPriceAddUPD);
            this.Controls.Add(this.lblBrandAddUPD);
            this.Controls.Add(this.lblNameAddUPD);
            this.Name = "StockAddFormUPD";
            this.Text = "Add Stock";
            this.Load += new System.EventHandler(this.StockAddFormUPD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._stockI_TDataSet)).EndInit();
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
        private System.Windows.Forms.ComboBox cmbListItemsAddUPD;
        private _stockI_TDataSet _stockI_TDataSet;
        private System.Windows.Forms.BindingSource stockBindingSource;
        private _stockI_TDataSetTableAdapters.StockTableAdapter stockTableAdapter;
        private System.Windows.Forms.TextBox txbRPriceUPD;
        private System.Windows.Forms.Label lblRPriceUPD;
        private System.Windows.Forms.Timer tmrCheckSelectedItemUPD;
    }
}