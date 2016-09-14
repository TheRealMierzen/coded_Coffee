namespace _213
{
    partial class CompleteSale
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
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPaid = new System.Windows.Forms.Label();
            this.cbxSpecialOrder = new System.Windows.Forms.CheckBox();
            this.txtPaid = new System.Windows.Forms.TextBox();
            this.cbxMethodOfPayment = new System.Windows.Forms.ComboBox();
            this.lblMethodOfPayment_Sales = new System.Windows.Forms.Label();
            this.btnCompleteSalePaid = new System.Windows.Forms.Button();
            this.btnCancelSale = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(9, 23);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(171, 25);
            this.lblTotal.TabIndex = 48;
            this.lblTotal.Text = "Total Payable: ";
            // 
            // lblPaid
            // 
            this.lblPaid.AutoSize = true;
            this.lblPaid.Location = new System.Drawing.Point(12, 63);
            this.lblPaid.Name = "lblPaid";
            this.lblPaid.Size = new System.Drawing.Size(31, 13);
            this.lblPaid.TabIndex = 47;
            this.lblPaid.Text = "Paid:";
            // 
            // cbxSpecialOrder
            // 
            this.cbxSpecialOrder.AutoSize = true;
            this.cbxSpecialOrder.Location = new System.Drawing.Point(15, 147);
            this.cbxSpecialOrder.Name = "cbxSpecialOrder";
            this.cbxSpecialOrder.Size = new System.Drawing.Size(90, 17);
            this.cbxSpecialOrder.TabIndex = 46;
            this.cbxSpecialOrder.Text = "Special Order";
            this.cbxSpecialOrder.UseVisualStyleBackColor = true;
            // 
            // txtPaid
            // 
            this.txtPaid.Location = new System.Drawing.Point(12, 79);
            this.txtPaid.Name = "txtPaid";
            this.txtPaid.Size = new System.Drawing.Size(159, 20);
            this.txtPaid.TabIndex = 45;
            // 
            // cbxMethodOfPayment
            // 
            this.cbxMethodOfPayment.FormattingEnabled = true;
            this.cbxMethodOfPayment.Items.AddRange(new object[] {
            "Cash",
            "Credit",
            "Debit",
            "Tjek"});
            this.cbxMethodOfPayment.Location = new System.Drawing.Point(15, 120);
            this.cbxMethodOfPayment.Name = "cbxMethodOfPayment";
            this.cbxMethodOfPayment.Size = new System.Drawing.Size(158, 21);
            this.cbxMethodOfPayment.TabIndex = 44;
            // 
            // lblMethodOfPayment_Sales
            // 
            this.lblMethodOfPayment_Sales.AutoSize = true;
            this.lblMethodOfPayment_Sales.Location = new System.Drawing.Point(12, 104);
            this.lblMethodOfPayment_Sales.Name = "lblMethodOfPayment_Sales";
            this.lblMethodOfPayment_Sales.Size = new System.Drawing.Size(102, 13);
            this.lblMethodOfPayment_Sales.TabIndex = 43;
            this.lblMethodOfPayment_Sales.Text = "Method of Payment:";
            // 
            // btnCompleteSalePaid
            // 
            this.btnCompleteSalePaid.Location = new System.Drawing.Point(15, 174);
            this.btnCompleteSalePaid.Name = "btnCompleteSalePaid";
            this.btnCompleteSalePaid.Size = new System.Drawing.Size(129, 54);
            this.btnCompleteSalePaid.TabIndex = 49;
            this.btnCompleteSalePaid.Text = "Complete Sale";
            this.btnCompleteSalePaid.UseVisualStyleBackColor = true;
            this.btnCompleteSalePaid.Click += new System.EventHandler(this.btnCompleteSalePaid_Click);
            // 
            // btnCancelSale
            // 
            this.btnCancelSale.Location = new System.Drawing.Point(147, 174);
            this.btnCancelSale.Name = "btnCancelSale";
            this.btnCancelSale.Size = new System.Drawing.Size(129, 54);
            this.btnCancelSale.TabIndex = 50;
            this.btnCancelSale.Text = "Cancel";
            this.btnCancelSale.UseVisualStyleBackColor = true;
            this.btnCancelSale.Click += new System.EventHandler(this.btnCancelSale_Click);
            // 
            // CompleteSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 261);
            this.Controls.Add(this.btnCancelSale);
            this.Controls.Add(this.btnCompleteSalePaid);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblPaid);
            this.Controls.Add(this.cbxSpecialOrder);
            this.Controls.Add(this.txtPaid);
            this.Controls.Add(this.cbxMethodOfPayment);
            this.Controls.Add(this.lblMethodOfPayment_Sales);
            this.Name = "CompleteSale";
            this.Text = "CompleteSale";
            this.Load += new System.EventHandler(this.CompleteSale_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPaid;
        private System.Windows.Forms.CheckBox cbxSpecialOrder;
        private System.Windows.Forms.TextBox txtPaid;
        private System.Windows.Forms.ComboBox cbxMethodOfPayment;
        private System.Windows.Forms.Label lblMethodOfPayment_Sales;
        private System.Windows.Forms.Button btnCompleteSalePaid;
        private System.Windows.Forms.Button btnCancelSale;
    }
}