namespace _213
{
    partial class StockTakeForm
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
            this.dgvStockTake = new System.Windows.Forms.DataGridView();
            this.btnCompare = new System.Windows.Forms.Button();
            this.txtStockTakeItemID = new System.Windows.Forms.TextBox();
            this.lblStockTakeItemID = new System.Windows.Forms.Label();
            this.btnStockTakeBack = new System.Windows.Forms.Button();
            this.txbStockTakeReport = new System.Windows.Forms.TextBox();
            this.btnCompleteStockTake = new System.Windows.Forms.Button();
            this.txbStockTake = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockTake)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStockTake
            // 
            this.dgvStockTake.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockTake.Location = new System.Drawing.Point(1, 256);
            this.dgvStockTake.Name = "dgvStockTake";
            this.dgvStockTake.Size = new System.Drawing.Size(782, 150);
            this.dgvStockTake.TabIndex = 0;
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(182, 28);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(87, 23);
            this.btnCompare.TabIndex = 1;
            this.btnCompare.Text = "Compare/Add";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // txtStockTakeItemID
            // 
            this.txtStockTakeItemID.Location = new System.Drawing.Point(59, 30);
            this.txtStockTakeItemID.Name = "txtStockTakeItemID";
            this.txtStockTakeItemID.Size = new System.Drawing.Size(117, 20);
            this.txtStockTakeItemID.TabIndex = 2;
            // 
            // lblStockTakeItemID
            // 
            this.lblStockTakeItemID.AutoSize = true;
            this.lblStockTakeItemID.Location = new System.Drawing.Point(12, 33);
            this.lblStockTakeItemID.Name = "lblStockTakeItemID";
            this.lblStockTakeItemID.Size = new System.Drawing.Size(41, 13);
            this.lblStockTakeItemID.TabIndex = 4;
            this.lblStockTakeItemID.Text = "Item ID";
            // 
            // btnStockTakeBack
            // 
            this.btnStockTakeBack.Location = new System.Drawing.Point(93, 227);
            this.btnStockTakeBack.Name = "btnStockTakeBack";
            this.btnStockTakeBack.Size = new System.Drawing.Size(75, 23);
            this.btnStockTakeBack.TabIndex = 6;
            this.btnStockTakeBack.Text = "Back";
            this.btnStockTakeBack.UseVisualStyleBackColor = true;
            this.btnStockTakeBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // txbStockTakeReport
            // 
            this.txbStockTakeReport.Location = new System.Drawing.Point(533, 12);
            this.txbStockTakeReport.Multiline = true;
            this.txbStockTakeReport.Name = "txbStockTakeReport";
            this.txbStockTakeReport.Size = new System.Drawing.Size(250, 238);
            this.txbStockTakeReport.TabIndex = 7;
            // 
            // btnCompleteStockTake
            // 
            this.btnCompleteStockTake.Location = new System.Drawing.Point(12, 227);
            this.btnCompleteStockTake.Name = "btnCompleteStockTake";
            this.btnCompleteStockTake.Size = new System.Drawing.Size(75, 23);
            this.btnCompleteStockTake.TabIndex = 8;
            this.btnCompleteStockTake.Text = "Complete";
            this.btnCompleteStockTake.UseVisualStyleBackColor = true;
            this.btnCompleteStockTake.Click += new System.EventHandler(this.btnCompleteStockTake_Click);
            // 
            // txbStockTake
            // 
            this.txbStockTake.Location = new System.Drawing.Point(275, 12);
            this.txbStockTake.Multiline = true;
            this.txbStockTake.Name = "txbStockTake";
            this.txbStockTake.Size = new System.Drawing.Size(252, 238);
            this.txbStockTake.TabIndex = 9;
            // 
            // StockTakeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 408);
            this.Controls.Add(this.txbStockTake);
            this.Controls.Add(this.btnCompleteStockTake);
            this.Controls.Add(this.txbStockTakeReport);
            this.Controls.Add(this.btnStockTakeBack);
            this.Controls.Add(this.lblStockTakeItemID);
            this.Controls.Add(this.txtStockTakeItemID);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.dgvStockTake);
            this.Name = "StockTakeForm";
            this.Text = "Stock Take";
            this.Shown += new System.EventHandler(this.StockTakeForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockTake)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStockTake;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.TextBox txtStockTakeItemID;
        private System.Windows.Forms.Label lblStockTakeItemID;
        private System.Windows.Forms.Button btnStockTakeBack;
        private System.Windows.Forms.TextBox txbStockTakeReport;
        private System.Windows.Forms.Button btnCompleteStockTake;
        private System.Windows.Forms.TextBox txbStockTake;
    }
}