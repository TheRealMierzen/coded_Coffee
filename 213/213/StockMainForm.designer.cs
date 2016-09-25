namespace _213
{
    partial class StockMainFormCLN
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
            this.btnPrintStockReport = new System.Windows.Forms.Button();
            this.txbStockReport = new System.Windows.Forms.TextBox();
            this.btnBackMain = new System.Windows.Forms.Button();
            this.cmbSelectStockAction = new System.Windows.Forms.ComboBox();
            this.lblActionSelect = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrintStockReport
            // 
            this.btnPrintStockReport.Location = new System.Drawing.Point(915, 671);
            this.btnPrintStockReport.Name = "btnPrintStockReport";
            this.btnPrintStockReport.Size = new System.Drawing.Size(75, 23);
            this.btnPrintStockReport.TabIndex = 11;
            this.btnPrintStockReport.Text = "Print";
            this.btnPrintStockReport.UseVisualStyleBackColor = true;
            this.btnPrintStockReport.Click += new System.EventHandler(this.btnPrintStockReport_Click);
            // 
            // txbStockReport
            // 
            this.txbStockReport.Location = new System.Drawing.Point(915, 31);
            this.txbStockReport.Multiline = true;
            this.txbStockReport.Name = "txbStockReport";
            this.txbStockReport.Size = new System.Drawing.Size(438, 634);
            this.txbStockReport.TabIndex = 6;
            this.txbStockReport.Text = "\r\n";
            // 
            // btnBackMain
            // 
            this.btnBackMain.Location = new System.Drawing.Point(179, 3);
            this.btnBackMain.Name = "btnBackMain";
            this.btnBackMain.Size = new System.Drawing.Size(40, 22);
            this.btnBackMain.TabIndex = 4;
            this.btnBackMain.Text = "Back";
            this.btnBackMain.UseVisualStyleBackColor = true;
            this.btnBackMain.Click += new System.EventHandler(this.btnBackMain_Click);
            // 
            // cmbSelectStockAction
            // 
            this.cmbSelectStockAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectStockAction.FormattingEnabled = true;
            this.cmbSelectStockAction.Items.AddRange(new object[] {
            "Add Stock",
            "Find Stock",
            "Update Stock",
            "Transfer Stock",
            "Stock Take",
            "Remove Stock"});
            this.cmbSelectStockAction.Location = new System.Drawing.Point(61, 3);
            this.cmbSelectStockAction.Name = "cmbSelectStockAction";
            this.cmbSelectStockAction.Size = new System.Drawing.Size(112, 21);
            this.cmbSelectStockAction.TabIndex = 1;
            this.cmbSelectStockAction.SelectedIndexChanged += new System.EventHandler(this.cmbSelectStockAction_SelectedIndexChanged);
            this.cmbSelectStockAction.SelectionChangeCommitted += new System.EventHandler(this.cmbSelectStockAction_SelectionChangeCommitted);
            // 
            // lblActionSelect
            // 
            this.lblActionSelect.AutoSize = true;
            this.lblActionSelect.Location = new System.Drawing.Point(3, 0);
            this.lblActionSelect.Name = "lblActionSelect";
            this.lblActionSelect.Size = new System.Drawing.Size(40, 26);
            this.lblActionSelect.TabIndex = 0;
            this.lblActionSelect.Text = "Select Action";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.62011F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 736F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.37989F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 270F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 236F));
            this.tableLayoutPanel1.Controls.Add(this.btnPrintStockReport, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblActionSelect, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbSelectStockAction, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBackMain, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txbStockReport, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.5862F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.41379F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1356, 873);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Location = new System.Drawing.Point(179, 31);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(730, 634);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // StockMainFormCLN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 873);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StockMainFormCLN";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.StockMainForm_Load);
            this.Shown += new System.EventHandler(this.StockMainForm_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrintStockReport;
        private System.Windows.Forms.TextBox txbStockReport;
        private System.Windows.Forms.Button btnBackMain;
        private System.Windows.Forms.ComboBox cmbSelectStockAction;
        private System.Windows.Forms.Label lblActionSelect;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}