namespace _213
{
    partial class EndOfDay
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
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnSales = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btnTransfers = new System.Windows.Forms.Button();
            this.btnCompleteReport = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnOrderReport = new System.Windows.Forms.Button();
            this.btnSalesReport = new System.Windows.Forms.Button();
            this.btnStockReport = new System.Windows.Forms.Button();
            this.btnTransfersReport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCompleteDay = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(40, 34);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(121, 40);
            this.btnOrders.TabIndex = 1;
            this.btnOrders.Text = "Orders Report";
            this.toolTip1.SetToolTip(this.btnOrders, "Orders Tabel View");
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnSales
            // 
            this.btnSales.Location = new System.Drawing.Point(197, 34);
            this.btnSales.Name = "btnSales";
            this.btnSales.Size = new System.Drawing.Size(115, 40);
            this.btnSales.TabIndex = 2;
            this.btnSales.Text = "Sales Report";
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            // 
            // btnStock
            // 
            this.btnStock.Location = new System.Drawing.Point(362, 34);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(139, 40);
            this.btnStock.TabIndex = 3;
            this.btnStock.Text = "Stock Report";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnTransfers
            // 
            this.btnTransfers.Location = new System.Drawing.Point(549, 34);
            this.btnTransfers.Name = "btnTransfers";
            this.btnTransfers.Size = new System.Drawing.Size(124, 40);
            this.btnTransfers.TabIndex = 4;
            this.btnTransfers.Text = "Transfer Report";
            this.btnTransfers.UseVisualStyleBackColor = true;
            this.btnTransfers.Click += new System.EventHandler(this.btnTransfers_Click);
            // 
            // btnCompleteReport
            // 
            this.btnCompleteReport.Location = new System.Drawing.Point(785, 34);
            this.btnCompleteReport.Name = "btnCompleteReport";
            this.btnCompleteReport.Size = new System.Drawing.Size(129, 40);
            this.btnCompleteReport.TabIndex = 6;
            this.btnCompleteReport.Text = "View Complete Summarized Report";
            this.btnCompleteReport.UseVisualStyleBackColor = true;
            this.btnCompleteReport.Click += new System.EventHandler(this.btnCompleteReport_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(692, 148);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(333, 321);
            this.textBox1.TabIndex = 7;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(1277, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(646, 462);
            this.dataGridView1.TabIndex = 10;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnOrderReport
            // 
            this.btnOrderReport.Location = new System.Drawing.Point(692, 119);
            this.btnOrderReport.Name = "btnOrderReport";
            this.btnOrderReport.Size = new System.Drawing.Size(75, 23);
            this.btnOrderReport.TabIndex = 21;
            this.btnOrderReport.Text = "Orders";
            this.btnOrderReport.UseVisualStyleBackColor = true;
            this.btnOrderReport.Click += new System.EventHandler(this.btnOrderReport_Click);
            // 
            // btnSalesReport
            // 
            this.btnSalesReport.Location = new System.Drawing.Point(773, 119);
            this.btnSalesReport.Name = "btnSalesReport";
            this.btnSalesReport.Size = new System.Drawing.Size(75, 23);
            this.btnSalesReport.TabIndex = 22;
            this.btnSalesReport.Text = "Sales";
            this.btnSalesReport.UseVisualStyleBackColor = true;
            this.btnSalesReport.Click += new System.EventHandler(this.btnSalesReport_Click);
            // 
            // btnStockReport
            // 
            this.btnStockReport.Location = new System.Drawing.Point(854, 119);
            this.btnStockReport.Name = "btnStockReport";
            this.btnStockReport.Size = new System.Drawing.Size(75, 23);
            this.btnStockReport.TabIndex = 23;
            this.btnStockReport.Text = "Stock";
            this.btnStockReport.UseVisualStyleBackColor = true;
            this.btnStockReport.Click += new System.EventHandler(this.btnStockReport_Click);
            // 
            // btnTransfersReport
            // 
            this.btnTransfersReport.Location = new System.Drawing.Point(935, 119);
            this.btnTransfersReport.Name = "btnTransfersReport";
            this.btnTransfersReport.Size = new System.Drawing.Size(75, 23);
            this.btnTransfersReport.TabIndex = 24;
            this.btnTransfersReport.Text = "Transfers";
            this.btnTransfersReport.UseVisualStyleBackColor = true;
            this.btnTransfersReport.Click += new System.EventHandler(this.btnTransferReport_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(707, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Use these Buttons below for Individual Summarized Reports";
            // 
            // btnCompleteDay
            // 
            this.btnCompleteDay.Location = new System.Drawing.Point(1154, 93);
            this.btnCompleteDay.Name = "btnCompleteDay";
            this.btnCompleteDay.Size = new System.Drawing.Size(146, 40);
            this.btnCompleteDay.TabIndex = 26;
            this.btnCompleteDay.Text = "Complete Day";
            this.btnCompleteDay.UseVisualStyleBackColor = true;
            this.btnCompleteDay.Click += new System.EventHandler(this.btnCompleteDay_Click);
            // 
            // EndOfDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 586);
            this.Controls.Add(this.btnCompleteDay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTransfersReport);
            this.Controls.Add(this.btnStockReport);
            this.Controls.Add(this.btnSalesReport);
            this.Controls.Add(this.btnOrderReport);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCompleteReport);
            this.Controls.Add(this.btnTransfers);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.btnSales);
            this.Controls.Add(this.btnOrders);
            this.Name = "EndOfDay";
            this.Text = "EndOfDay";
            this.Load += new System.EventHandler(this.EndOfDay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnSales;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btnTransfers;
        private System.Windows.Forms.Button btnCompleteReport;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnOrderReport;
        private System.Windows.Forms.Button btnSalesReport;
        private System.Windows.Forms.Button btnStockReport;
        private System.Windows.Forms.Button btnTransfersReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCompleteDay;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}