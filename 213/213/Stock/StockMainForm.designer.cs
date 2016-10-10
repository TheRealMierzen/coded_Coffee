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
            this.components = new System.ComponentModel.Container();
            this.cmbSelectStockAction = new System.Windows.Forms.ComboBox();
            this.btnBackMain = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txbStockTakeReport = new System.Windows.Forms.TextBox();
            this.txbStockTake = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCompare = new System.Windows.Forms.Button();
            this.lblStockTakeItemID = new System.Windows.Forms.Label();
            this.txtStockTakeItemID = new System.Windows.Forms.TextBox();
            this.btnCompleteStockTake = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lblActionSelect = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bgWDetails = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbSelectStockAction
            // 
            this.cmbSelectStockAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbSelectStockAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSelectStockAction.FormattingEnabled = true;
            this.cmbSelectStockAction.Items.AddRange(new object[] {
            "Add Stock",
            "Find Stock",
            "Update Stock",
            "Transfer Stock",
            "Remove Stock"});
            this.cmbSelectStockAction.Location = new System.Drawing.Point(59, 3);
            this.cmbSelectStockAction.Name = "cmbSelectStockAction";
            this.cmbSelectStockAction.Size = new System.Drawing.Size(189, 21);
            this.cmbSelectStockAction.TabIndex = 1;
            this.toolTip1.SetToolTip(this.cmbSelectStockAction, "Select an action to visit that window");
            this.cmbSelectStockAction.SelectedIndexChanged += new System.EventHandler(this.cmbSelectStockAction_SelectedIndexChanged);
            this.cmbSelectStockAction.SelectionChangeCommitted += new System.EventHandler(this.cmbSelectStockAction_SelectionChangeCommitted);
            // 
            // btnBackMain
            // 
            this.btnBackMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBackMain.Location = new System.Drawing.Point(254, 3);
            this.btnBackMain.Name = "btnBackMain";
            this.btnBackMain.Size = new System.Drawing.Size(97, 47);
            this.btnBackMain.TabIndex = 4;
            this.btnBackMain.Text = "Back";
            this.toolTip1.SetToolTip(this.btnBackMain, "Click to close this form and go back to main form");
            this.btnBackMain.UseVisualStyleBackColor = true;
            this.btnBackMain.Click += new System.EventHandler(this.btnBackMain_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.250631F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.58312F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.58312F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.58312F));
            this.tableLayoutPanel1.Controls.Add(this.txbStockTakeReport, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txbStockTake, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1143, 596);
            this.tableLayoutPanel1.TabIndex = 12;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(423, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Stock Status from Today";
            // 
            // txbStockTakeReport
            // 
            this.txbStockTakeReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbStockTakeReport.Location = new System.Drawing.Point(423, 150);
            this.txbStockTakeReport.Multiline = true;
            this.txbStockTakeReport.Name = "txbStockTakeReport";
            this.txbStockTakeReport.ReadOnly = true;
            this.txbStockTakeReport.Size = new System.Drawing.Size(354, 443);
            this.txbStockTakeReport.TabIndex = 19;
            this.toolTip1.SetToolTip(this.txbStockTakeReport, "Here is a report on what happend to the stock today");
            // 
            // txbStockTake
            // 
            this.txbStockTake.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txbStockTake.Location = new System.Drawing.Point(63, 150);
            this.txbStockTake.Multiline = true;
            this.txbStockTake.Name = "txbStockTake";
            this.txbStockTake.ReadOnly = true;
            this.txbStockTake.Size = new System.Drawing.Size(354, 443);
            this.txbStockTake.TabIndex = 18;
            this.toolTip1.SetToolTip(this.txbStockTake, "Here are a list of all the items that are missing from the stock take");
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.47191F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.52809F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnCompare, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblStockTakeItemID, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtStockTakeItemID, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCompleteStockTake, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(63, 91);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(354, 53);
            this.tableLayoutPanel2.TabIndex = 22;
            // 
            // btnCompare
            // 
            this.btnCompare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCompare.Location = new System.Drawing.Point(256, 3);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(95, 20);
            this.btnCompare.TabIndex = 16;
            this.btnCompare.Text = "Compare/Add";
            this.toolTip1.SetToolTip(this.btnCompare, "Click to add item to check list");
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click_1);
            // 
            // lblStockTakeItemID
            // 
            this.lblStockTakeItemID.AutoSize = true;
            this.lblStockTakeItemID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStockTakeItemID.Location = new System.Drawing.Point(3, 0);
            this.lblStockTakeItemID.Name = "lblStockTakeItemID";
            this.lblStockTakeItemID.Size = new System.Drawing.Size(51, 26);
            this.lblStockTakeItemID.TabIndex = 14;
            this.lblStockTakeItemID.Text = "Item ID";
            // 
            // txtStockTakeItemID
            // 
            this.txtStockTakeItemID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtStockTakeItemID.Location = new System.Drawing.Point(60, 3);
            this.txtStockTakeItemID.MaxLength = 25;
            this.txtStockTakeItemID.Name = "txtStockTakeItemID";
            this.txtStockTakeItemID.ShortcutsEnabled = false;
            this.txtStockTakeItemID.Size = new System.Drawing.Size(190, 20);
            this.txtStockTakeItemID.TabIndex = 15;
            this.toolTip1.SetToolTip(this.txtStockTakeItemID, "Scan in the ID you have to let the system know you have that item");
            // 
            // btnCompleteStockTake
            // 
            this.btnCompleteStockTake.Location = new System.Drawing.Point(256, 29);
            this.btnCompleteStockTake.Name = "btnCompleteStockTake";
            this.btnCompleteStockTake.Size = new System.Drawing.Size(95, 21);
            this.btnCompleteStockTake.TabIndex = 20;
            this.btnCompleteStockTake.Text = "Complete";
            this.toolTip1.SetToolTip(this.btnCompleteStockTake, "Click to complete stock take");
            this.btnCompleteStockTake.UseVisualStyleBackColor = true;
            this.btnCompleteStockTake.Click += new System.EventHandler(this.btnCompleteStockTake_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 27);
            this.label1.TabIndex = 21;
            this.label1.Text = "Stock Items Recorded";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.26415F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.73585F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel3.Controls.Add(this.lblActionSelect, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnBackMain, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.cmbSelectStockAction, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(63, 32);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(354, 53);
            this.tableLayoutPanel3.TabIndex = 23;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
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
            // bgWDetails
            // 
            this.bgWDetails.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWDetails_DoWork);
            this.bgWDetails.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWDetails_RunWorkerCompleted);
            // 
            // StockMainFormCLN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 596);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "StockMainFormCLN";
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.StockMainForm_Load);
            this.Shown += new System.EventHandler(this.StockMainForm_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSelectStockAction;
        private System.Windows.Forms.Button btnBackMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblActionSelect;
        private System.Windows.Forms.Label lblStockTakeItemID;
        private System.Windows.Forms.TextBox txtStockTakeItemID;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.TextBox txbStockTake;
        private System.Windows.Forms.Button btnCompleteStockTake;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbStockTakeReport;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.ComponentModel.BackgroundWorker bgWDetails;
    }
}