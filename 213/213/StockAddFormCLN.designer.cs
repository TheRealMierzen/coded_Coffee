namespace _213
{
    partial class StockAddFormCLN
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
            this.lblNameAddCLN = new System.Windows.Forms.Label();
            this.lblBrandAddCLN = new System.Windows.Forms.Label();
            this.lblPriceAddCLN = new System.Windows.Forms.Label();
            this.lblQuantityAddCLN = new System.Windows.Forms.Label();
            this.btnConfirmAddCLN = new System.Windows.Forms.Button();
            this.btnCancelAddCLN = new System.Windows.Forms.Button();
            this.txbNameAddCLN = new System.Windows.Forms.TextBox();
            this.txbBrandAddCLN = new System.Windows.Forms.TextBox();
            this.txbPriceAddCLN = new System.Windows.Forms.TextBox();
            this.txbQuantityAddCLN = new System.Windows.Forms.TextBox();
            this.tmrStockAddCLN = new System.Windows.Forms.Timer(this.components);
            this.prbStatusAddCLN = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // lblNameAddCLN
            // 
            this.lblNameAddCLN.AutoSize = true;
            this.lblNameAddCLN.Location = new System.Drawing.Point(12, 9);
            this.lblNameAddCLN.Name = "lblNameAddCLN";
            this.lblNameAddCLN.Size = new System.Drawing.Size(61, 13);
            this.lblNameAddCLN.TabIndex = 0;
            this.lblNameAddCLN.Text = "Item Name:";
            // 
            // lblBrandAddCLN
            // 
            this.lblBrandAddCLN.AutoSize = true;
            this.lblBrandAddCLN.Location = new System.Drawing.Point(12, 34);
            this.lblBrandAddCLN.Name = "lblBrandAddCLN";
            this.lblBrandAddCLN.Size = new System.Drawing.Size(61, 13);
            this.lblBrandAddCLN.TabIndex = 1;
            this.lblBrandAddCLN.Text = "Item Brand:";
            // 
            // lblPriceAddCLN
            // 
            this.lblPriceAddCLN.AutoSize = true;
            this.lblPriceAddCLN.Location = new System.Drawing.Point(12, 58);
            this.lblPriceAddCLN.Name = "lblPriceAddCLN";
            this.lblPriceAddCLN.Size = new System.Drawing.Size(57, 13);
            this.lblPriceAddCLN.TabIndex = 2;
            this.lblPriceAddCLN.Text = "Item Price:";
            // 
            // lblQuantityAddCLN
            // 
            this.lblQuantityAddCLN.AutoSize = true;
            this.lblQuantityAddCLN.Location = new System.Drawing.Point(12, 84);
            this.lblQuantityAddCLN.Name = "lblQuantityAddCLN";
            this.lblQuantityAddCLN.Size = new System.Drawing.Size(72, 13);
            this.lblQuantityAddCLN.TabIndex = 3;
            this.lblQuantityAddCLN.Text = "Item Quantity:";
            // 
            // btnConfirmAddCLN
            // 
            this.btnConfirmAddCLN.Location = new System.Drawing.Point(15, 126);
            this.btnConfirmAddCLN.Name = "btnConfirmAddCLN";
            this.btnConfirmAddCLN.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmAddCLN.TabIndex = 4;
            this.btnConfirmAddCLN.Text = "OK";
            this.btnConfirmAddCLN.UseVisualStyleBackColor = true;
            this.btnConfirmAddCLN.Click += new System.EventHandler(this.btnConfirmAddCLN_Click);
            // 
            // btnCancelAddCLN
            // 
            this.btnCancelAddCLN.Location = new System.Drawing.Point(151, 126);
            this.btnCancelAddCLN.Name = "btnCancelAddCLN";
            this.btnCancelAddCLN.Size = new System.Drawing.Size(75, 23);
            this.btnCancelAddCLN.TabIndex = 5;
            this.btnCancelAddCLN.Text = "Cancel";
            this.btnCancelAddCLN.UseVisualStyleBackColor = true;
            this.btnCancelAddCLN.Click += new System.EventHandler(this.btnCancelAddCLN_Click);
            // 
            // txbNameAddCLN
            // 
            this.txbNameAddCLN.Location = new System.Drawing.Point(126, 6);
            this.txbNameAddCLN.Name = "txbNameAddCLN";
            this.txbNameAddCLN.Size = new System.Drawing.Size(100, 20);
            this.txbNameAddCLN.TabIndex = 6;
            // 
            // txbBrandAddCLN
            // 
            this.txbBrandAddCLN.Location = new System.Drawing.Point(126, 31);
            this.txbBrandAddCLN.Name = "txbBrandAddCLN";
            this.txbBrandAddCLN.Size = new System.Drawing.Size(100, 20);
            this.txbBrandAddCLN.TabIndex = 7;
            // 
            // txbPriceAddCLN
            // 
            this.txbPriceAddCLN.Location = new System.Drawing.Point(126, 55);
            this.txbPriceAddCLN.Name = "txbPriceAddCLN";
            this.txbPriceAddCLN.Size = new System.Drawing.Size(100, 20);
            this.txbPriceAddCLN.TabIndex = 8;
            // 
            // txbQuantityAddCLN
            // 
            this.txbQuantityAddCLN.Location = new System.Drawing.Point(126, 81);
            this.txbQuantityAddCLN.Name = "txbQuantityAddCLN";
            this.txbQuantityAddCLN.Size = new System.Drawing.Size(100, 20);
            this.txbQuantityAddCLN.TabIndex = 9;
            this.txbQuantityAddCLN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbQuantityAddCLN_KeyPress);
            // 
            // tmrStockAddCLN
            // 
            this.tmrStockAddCLN.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // prbStatusAddCLN
            // 
            this.prbStatusAddCLN.Location = new System.Drawing.Point(12, 155);
            this.prbStatusAddCLN.Name = "prbStatusAddCLN";
            this.prbStatusAddCLN.Size = new System.Drawing.Size(214, 13);
            this.prbStatusAddCLN.TabIndex = 10;
            // 
            // StockAddFormCLN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 173);
            this.Controls.Add(this.prbStatusAddCLN);
            this.Controls.Add(this.txbQuantityAddCLN);
            this.Controls.Add(this.txbPriceAddCLN);
            this.Controls.Add(this.txbBrandAddCLN);
            this.Controls.Add(this.txbNameAddCLN);
            this.Controls.Add(this.btnCancelAddCLN);
            this.Controls.Add(this.btnConfirmAddCLN);
            this.Controls.Add(this.lblQuantityAddCLN);
            this.Controls.Add(this.lblPriceAddCLN);
            this.Controls.Add(this.lblBrandAddCLN);
            this.Controls.Add(this.lblNameAddCLN);
            this.Name = "StockAddFormCLN";
            this.Text = "New Item Entry";
            this.Shown += new System.EventHandler(this.StockAddFormCLN_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNameAddCLN;
        private System.Windows.Forms.Label lblBrandAddCLN;
        private System.Windows.Forms.Label lblPriceAddCLN;
        private System.Windows.Forms.Label lblQuantityAddCLN;
        private System.Windows.Forms.Button btnConfirmAddCLN;
        private System.Windows.Forms.Button btnCancelAddCLN;
        private System.Windows.Forms.TextBox txbNameAddCLN;
        private System.Windows.Forms.TextBox txbBrandAddCLN;
        private System.Windows.Forms.TextBox txbPriceAddCLN;
        private System.Windows.Forms.TextBox txbQuantityAddCLN;
        private System.Windows.Forms.Timer tmrStockAddCLN;
        private System.Windows.Forms.ProgressBar prbStatusAddCLN;
    }
}