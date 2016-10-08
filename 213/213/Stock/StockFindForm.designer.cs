namespace _213
{
    partial class StockFindForm
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
            this.dgvFindStock = new System.Windows.Forms.DataGridView();
            this.txtFindName = new System.Windows.Forms.TextBox();
            this.txtFindBrand = new System.Windows.Forms.TextBox();
            this.txtFindPrice = new System.Windows.Forms.TextBox();
            this.lblFindName = new System.Windows.Forms.Label();
            this.lblFindBrand = new System.Windows.Forms.Label();
            this.lblFindPrice = new System.Windows.Forms.Label();
            this.btnConfirmFind = new System.Windows.Forms.Button();
            this.btnCancelFind = new System.Windows.Forms.Button();
            this.tmrValidateFind = new System.Windows.Forms.Timer(this.components);
            this.cmbTypeSearch = new System.Windows.Forms.ComboBox();
            this.lblSearchByType = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindStock)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFindStock
            // 
            this.dgvFindStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFindStock.Location = new System.Drawing.Point(12, 165);
            this.dgvFindStock.Name = "dgvFindStock";
            this.dgvFindStock.ReadOnly = true;
            this.dgvFindStock.Size = new System.Drawing.Size(268, 150);
            this.dgvFindStock.TabIndex = 0;
            // 
            // txtFindName
            // 
            this.txtFindName.Location = new System.Drawing.Point(180, 12);
            this.txtFindName.Name = "txtFindName";
            this.txtFindName.ShortcutsEnabled = false;
            this.txtFindName.Size = new System.Drawing.Size(100, 20);
            this.txtFindName.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtFindName, "Enter a part of the full name of a item\r\nyou would like to search");
            this.txtFindName.TextChanged += new System.EventHandler(this.txtFindName_TextChanged);
            // 
            // txtFindBrand
            // 
            this.txtFindBrand.Location = new System.Drawing.Point(180, 38);
            this.txtFindBrand.Name = "txtFindBrand";
            this.txtFindBrand.ShortcutsEnabled = false;
            this.txtFindBrand.Size = new System.Drawing.Size(100, 20);
            this.txtFindBrand.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtFindBrand, "Enter a part or full brand name to search for the item\r\nby brand");
            // 
            // txtFindPrice
            // 
            this.txtFindPrice.Location = new System.Drawing.Point(180, 64);
            this.txtFindPrice.MaxLength = 10;
            this.txtFindPrice.Name = "txtFindPrice";
            this.txtFindPrice.ShortcutsEnabled = false;
            this.txtFindPrice.Size = new System.Drawing.Size(100, 20);
            this.txtFindPrice.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtFindPrice, "Enter the price to view all the items with that price");
            this.txtFindPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFindPrice_KeyPress);
            // 
            // lblFindName
            // 
            this.lblFindName.AutoSize = true;
            this.lblFindName.Location = new System.Drawing.Point(12, 15);
            this.lblFindName.Name = "lblFindName";
            this.lblFindName.Size = new System.Drawing.Size(86, 13);
            this.lblFindName.TabIndex = 4;
            this.lblFindName.Text = "Search by Name";
            this.lblFindName.Click += new System.EventHandler(this.lblFindName_Click);
            // 
            // lblFindBrand
            // 
            this.lblFindBrand.AutoSize = true;
            this.lblFindBrand.Location = new System.Drawing.Point(12, 41);
            this.lblFindBrand.Name = "lblFindBrand";
            this.lblFindBrand.Size = new System.Drawing.Size(86, 13);
            this.lblFindBrand.TabIndex = 5;
            this.lblFindBrand.Text = "Search by Brand";
            // 
            // lblFindPrice
            // 
            this.lblFindPrice.AutoSize = true;
            this.lblFindPrice.Location = new System.Drawing.Point(12, 67);
            this.lblFindPrice.Name = "lblFindPrice";
            this.lblFindPrice.Size = new System.Drawing.Size(82, 13);
            this.lblFindPrice.TabIndex = 6;
            this.lblFindPrice.Text = "Search by Price";
            // 
            // btnConfirmFind
            // 
            this.btnConfirmFind.Location = new System.Drawing.Point(12, 136);
            this.btnConfirmFind.Name = "btnConfirmFind";
            this.btnConfirmFind.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmFind.TabIndex = 7;
            this.btnConfirmFind.Text = "OK";
            this.toolTip1.SetToolTip(this.btnConfirmFind, "Click to confirm search");
            this.btnConfirmFind.UseVisualStyleBackColor = true;
            this.btnConfirmFind.Click += new System.EventHandler(this.btnConfirmFind_Click);
            // 
            // btnCancelFind
            // 
            this.btnCancelFind.Location = new System.Drawing.Point(205, 136);
            this.btnCancelFind.Name = "btnCancelFind";
            this.btnCancelFind.Size = new System.Drawing.Size(75, 23);
            this.btnCancelFind.TabIndex = 8;
            this.btnCancelFind.Text = "Back";
            this.toolTip1.SetToolTip(this.btnCancelFind, "Click to close this window");
            this.btnCancelFind.UseVisualStyleBackColor = true;
            this.btnCancelFind.Click += new System.EventHandler(this.btnCancelFind_Click);
            // 
            // tmrValidateFind
            // 
            this.tmrValidateFind.Tick += new System.EventHandler(this.tmrValidateFind_Tick);
            // 
            // cmbTypeSearch
            // 
            this.cmbTypeSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTypeSearch.FormattingEnabled = true;
            this.cmbTypeSearch.Items.AddRange(new object[] {
            "RAM",
            "CPU",
            "PSU",
            "GPU",
            "HDD",
            "Mobo",
            "Periperals",
            "Misc"});
            this.cmbTypeSearch.Location = new System.Drawing.Point(180, 90);
            this.cmbTypeSearch.Name = "cmbTypeSearch";
            this.cmbTypeSearch.Size = new System.Drawing.Size(100, 21);
            this.cmbTypeSearch.TabIndex = 14;
            this.toolTip1.SetToolTip(this.cmbTypeSearch, "Select a type to show all the types of items");
            // 
            // lblSearchByType
            // 
            this.lblSearchByType.AutoSize = true;
            this.lblSearchByType.Location = new System.Drawing.Point(12, 90);
            this.lblSearchByType.Name = "lblSearchByType";
            this.lblSearchByType.Size = new System.Drawing.Size(82, 13);
            this.lblSearchByType.TabIndex = 15;
            this.lblSearchByType.Text = "Search by Type";
            // 
            // StockFindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 327);
            this.Controls.Add(this.lblSearchByType);
            this.Controls.Add(this.cmbTypeSearch);
            this.Controls.Add(this.btnCancelFind);
            this.Controls.Add(this.btnConfirmFind);
            this.Controls.Add(this.lblFindPrice);
            this.Controls.Add(this.lblFindBrand);
            this.Controls.Add(this.lblFindName);
            this.Controls.Add(this.txtFindPrice);
            this.Controls.Add(this.txtFindBrand);
            this.Controls.Add(this.txtFindName);
            this.Controls.Add(this.dgvFindStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StockFindForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.Shown += new System.EventHandler(this.StockFindForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFindStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFindStock;
        private System.Windows.Forms.TextBox txtFindName;
        private System.Windows.Forms.TextBox txtFindBrand;
        private System.Windows.Forms.TextBox txtFindPrice;
        private System.Windows.Forms.Label lblFindName;
        private System.Windows.Forms.Label lblFindBrand;
        private System.Windows.Forms.Label lblFindPrice;
        private System.Windows.Forms.Button btnConfirmFind;
        private System.Windows.Forms.Button btnCancelFind;
        private System.Windows.Forms.Timer tmrValidateFind;
        private System.Windows.Forms.ComboBox cmbTypeSearch;
        private System.Windows.Forms.Label lblSearchByType;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}