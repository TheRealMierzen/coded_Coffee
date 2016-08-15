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
            this.lblActionSelect = new System.Windows.Forms.Label();
            this.cmbSelectStockAction = new System.Windows.Forms.ComboBox();
            this.btnConfirmStockAction = new System.Windows.Forms.Button();
            this.btnBackMain = new System.Windows.Forms.Button();
            this.btnPrintStockReport = new System.Windows.Forms.Button();
            this.lblDateSelectReport = new System.Windows.Forms.Label();
            this.dtpStockReport = new System.Windows.Forms.DateTimePicker();
            this.btnCancelReport = new System.Windows.Forms.Button();
            this.btnConfirmReport = new System.Windows.Forms.Button();
            this.txbStockReport = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblActionSelect
            // 
            this.lblActionSelect.AutoSize = true;
            this.lblActionSelect.Location = new System.Drawing.Point(3, 0);
            this.lblActionSelect.Name = "lblActionSelect";
            this.lblActionSelect.Size = new System.Drawing.Size(70, 13);
            this.lblActionSelect.TabIndex = 0;
            this.lblActionSelect.Text = "Select Action";
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
            "Stock Take"});
            this.cmbSelectStockAction.Location = new System.Drawing.Point(80, 3);
            this.cmbSelectStockAction.Name = "cmbSelectStockAction";
            this.cmbSelectStockAction.Size = new System.Drawing.Size(121, 21);
            this.cmbSelectStockAction.TabIndex = 1;
            this.cmbSelectStockAction.SelectedIndexChanged += new System.EventHandler(this.cmbSelectStockAction_SelectedIndexChanged);
            this.cmbSelectStockAction.SelectionChangeCommitted += new System.EventHandler(this.cmbSelectStockAction_SelectionChangeCommitted);
            // 
            // btnConfirmStockAction
            // 
            this.btnConfirmStockAction.Location = new System.Drawing.Point(216, 3);
            this.btnConfirmStockAction.Name = "btnConfirmStockAction";
            this.btnConfirmStockAction.Size = new System.Drawing.Size(36, 21);
            this.btnConfirmStockAction.TabIndex = 2;
            this.btnConfirmStockAction.Text = "OK";
            this.btnConfirmStockAction.UseVisualStyleBackColor = true;
            this.btnConfirmStockAction.Click += new System.EventHandler(this.btnConfirmStockAction_Click);
            // 
            // btnBackMain
            // 
            this.btnBackMain.Location = new System.Drawing.Point(314, 3);
            this.btnBackMain.Name = "btnBackMain";
            this.btnBackMain.Size = new System.Drawing.Size(40, 23);
            this.btnBackMain.TabIndex = 4;
            this.btnBackMain.Text = "Back";
            this.btnBackMain.UseVisualStyleBackColor = true;
            this.btnBackMain.Click += new System.EventHandler(this.btnBackMain_Click);
            // 
            // btnPrintStockReport
            // 
            this.btnPrintStockReport.Location = new System.Drawing.Point(550, 415);
            this.btnPrintStockReport.Name = "btnPrintStockReport";
            this.btnPrintStockReport.Size = new System.Drawing.Size(75, 23);
            this.btnPrintStockReport.TabIndex = 11;
            this.btnPrintStockReport.Text = "Print";
            this.btnPrintStockReport.UseVisualStyleBackColor = true;
            this.btnPrintStockReport.Click += new System.EventHandler(this.btnPrintStockReport_Click);
            // 
            // lblDateSelectReport
            // 
            this.lblDateSelectReport.AutoSize = true;
            this.lblDateSelectReport.Location = new System.Drawing.Point(216, 362);
            this.lblDateSelectReport.Name = "lblDateSelectReport";
            this.lblDateSelectReport.Size = new System.Drawing.Size(88, 13);
            this.lblDateSelectReport.TabIndex = 10;
            this.lblDateSelectReport.Text = "Select Start Date";
            // 
            // dtpStockReport
            // 
            this.dtpStockReport.Location = new System.Drawing.Point(314, 365);
            this.dtpStockReport.Name = "dtpStockReport";
            this.dtpStockReport.Size = new System.Drawing.Size(200, 20);
            this.dtpStockReport.TabIndex = 9;
            // 
            // btnCancelReport
            // 
            this.btnCancelReport.Location = new System.Drawing.Point(314, 415);
            this.btnCancelReport.Name = "btnCancelReport";
            this.btnCancelReport.Size = new System.Drawing.Size(75, 23);
            this.btnCancelReport.TabIndex = 8;
            this.btnCancelReport.Text = "Cancel";
            this.btnCancelReport.UseVisualStyleBackColor = true;
            // 
            // btnConfirmReport
            // 
            this.btnConfirmReport.Location = new System.Drawing.Point(216, 415);
            this.btnConfirmReport.Name = "btnConfirmReport";
            this.btnConfirmReport.Size = new System.Drawing.Size(92, 23);
            this.btnConfirmReport.TabIndex = 7;
            this.btnConfirmReport.Text = "Generate Report";
            this.btnConfirmReport.UseVisualStyleBackColor = true;
            // 
            // txbStockReport
            // 
            this.txbStockReport.Location = new System.Drawing.Point(550, 3);
            this.txbStockReport.Multiline = true;
            this.txbStockReport.Name = "txbStockReport";
            this.txbStockReport.Size = new System.Drawing.Size(342, 356);
            this.txbStockReport.TabIndex = 6;
            this.txbStockReport.Text = "Die gaan n report gooi van al die stock add,remove, transfert ens.\nDIe gebruiker " +
    "gaan ook die begin datum kan kies sodat hy/sy al die inligting vanaf daai datum " +
    "kan kry\n\n\n\nEN die print button werk ;p\n";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.15023F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.84977F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 236F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 347F));
            this.tableLayoutPanel1.Controls.Add(this.lblActionSelect, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cmbSelectStockAction, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpStockReport, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnConfirmReport, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnConfirmStockAction, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnBackMain, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txbStockReport, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDateSelectReport, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnCancelReport, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnPrintStockReport, 4, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.86407F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.13592F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(895, 464);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // StockMainFormCLN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 464);
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

        private System.Windows.Forms.Label lblActionSelect;
        private System.Windows.Forms.ComboBox cmbSelectStockAction;
        private System.Windows.Forms.Button btnConfirmStockAction;
        private System.Windows.Forms.Button btnBackMain;
        private System.Windows.Forms.Button btnPrintStockReport;
        private System.Windows.Forms.Label lblDateSelectReport;
        private System.Windows.Forms.DateTimePicker dtpStockReport;
        private System.Windows.Forms.Button btnCancelReport;
        private System.Windows.Forms.Button btnConfirmReport;
        private System.Windows.Forms.TextBox txbStockReport;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}