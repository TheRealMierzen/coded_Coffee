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
            this.txtStockTakeItemName = new System.Windows.Forms.TextBox();
            this.lblStockTakeItemID = new System.Windows.Forms.Label();
            this.lblStockTakeItemName = new System.Windows.Forms.Label();
            this.btnStockTakeBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockTake)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStockTake
            // 
            this.dgvStockTake.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStockTake.Location = new System.Drawing.Point(1, 256);
            this.dgvStockTake.Name = "dgvStockTake";
            this.dgvStockTake.Size = new System.Drawing.Size(748, 150);
            this.dgvStockTake.TabIndex = 0;
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(211, 28);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(75, 23);
            this.btnCompare.TabIndex = 1;
            this.btnCompare.Text = "Compare";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // txtStockTakeItemID
            // 
            this.txtStockTakeItemID.Location = new System.Drawing.Point(89, 12);
            this.txtStockTakeItemID.Name = "txtStockTakeItemID";
            this.txtStockTakeItemID.Size = new System.Drawing.Size(100, 20);
            this.txtStockTakeItemID.TabIndex = 2;
            // 
            // txtStockTakeItemName
            // 
            this.txtStockTakeItemName.Location = new System.Drawing.Point(89, 45);
            this.txtStockTakeItemName.Name = "txtStockTakeItemName";
            this.txtStockTakeItemName.Size = new System.Drawing.Size(100, 20);
            this.txtStockTakeItemName.TabIndex = 3;
            // 
            // lblStockTakeItemID
            // 
            this.lblStockTakeItemID.AutoSize = true;
            this.lblStockTakeItemID.Location = new System.Drawing.Point(10, 15);
            this.lblStockTakeItemID.Name = "lblStockTakeItemID";
            this.lblStockTakeItemID.Size = new System.Drawing.Size(41, 13);
            this.lblStockTakeItemID.TabIndex = 4;
            this.lblStockTakeItemID.Text = "Item ID";
            // 
            // lblStockTakeItemName
            // 
            this.lblStockTakeItemName.AutoSize = true;
            this.lblStockTakeItemName.Location = new System.Drawing.Point(12, 48);
            this.lblStockTakeItemName.Name = "lblStockTakeItemName";
            this.lblStockTakeItemName.Size = new System.Drawing.Size(58, 13);
            this.lblStockTakeItemName.TabIndex = 5;
            this.lblStockTakeItemName.Text = "Item Name";
            // 
            // btnStockTakeBack
            // 
            this.btnStockTakeBack.Location = new System.Drawing.Point(292, 28);
            this.btnStockTakeBack.Name = "btnStockTakeBack";
            this.btnStockTakeBack.Size = new System.Drawing.Size(75, 23);
            this.btnStockTakeBack.TabIndex = 6;
            this.btnStockTakeBack.Text = "Back";
            this.btnStockTakeBack.UseVisualStyleBackColor = true;
            this.btnStockTakeBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // StockTakeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 408);
            this.Controls.Add(this.btnStockTakeBack);
            this.Controls.Add(this.lblStockTakeItemName);
            this.Controls.Add(this.lblStockTakeItemID);
            this.Controls.Add(this.txtStockTakeItemName);
            this.Controls.Add(this.txtStockTakeItemID);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.dgvStockTake);
            this.Name = "StockTakeForm";
            this.Text = "Stock Take";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStockTake)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStockTake;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.TextBox txtStockTakeItemID;
        private System.Windows.Forms.TextBox txtStockTakeItemName;
        private System.Windows.Forms.Label lblStockTakeItemID;
        private System.Windows.Forms.Label lblStockTakeItemName;
        private System.Windows.Forms.Button btnStockTakeBack;
    }
}