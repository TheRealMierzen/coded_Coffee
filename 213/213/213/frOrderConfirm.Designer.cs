namespace _213
{
    partial class frOrderConfirm
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
            this.txtDayOrders = new System.Windows.Forms.TextBox();
            this.btnConfirmO = new System.Windows.Forms.Button();
            this.btnEditO = new System.Windows.Forms.Button();
            this.btnCancelO = new System.Windows.Forms.Button();
            this.btnBackOC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDayOrders
            // 
            this.txtDayOrders.Location = new System.Drawing.Point(74, 54);
            this.txtDayOrders.Multiline = true;
            this.txtDayOrders.Name = "txtDayOrders";
            this.txtDayOrders.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDayOrders.Size = new System.Drawing.Size(310, 238);
            this.txtDayOrders.TabIndex = 0;
            // 
            // btnConfirmO
            // 
            this.btnConfirmO.Location = new System.Drawing.Point(415, 54);
            this.btnConfirmO.Name = "btnConfirmO";
            this.btnConfirmO.Size = new System.Drawing.Size(111, 42);
            this.btnConfirmO.TabIndex = 2;
            this.btnConfirmO.Text = "Confirm Order";
            this.btnConfirmO.UseVisualStyleBackColor = true;
            this.btnConfirmO.Click += new System.EventHandler(this.btnConfirmO_Click);
            // 
            // btnEditO
            // 
            this.btnEditO.Location = new System.Drawing.Point(415, 102);
            this.btnEditO.Name = "btnEditO";
            this.btnEditO.Size = new System.Drawing.Size(111, 42);
            this.btnEditO.TabIndex = 3;
            this.btnEditO.Text = "Edit Order";
            this.btnEditO.UseVisualStyleBackColor = true;
            // 
            // btnCancelO
            // 
            this.btnCancelO.Location = new System.Drawing.Point(415, 150);
            this.btnCancelO.Name = "btnCancelO";
            this.btnCancelO.Size = new System.Drawing.Size(111, 42);
            this.btnCancelO.TabIndex = 4;
            this.btnCancelO.Text = "Cancel Order";
            this.btnCancelO.UseVisualStyleBackColor = true;
            // 
            // btnBackOC
            // 
            this.btnBackOC.Location = new System.Drawing.Point(415, 198);
            this.btnBackOC.Name = "btnBackOC";
            this.btnBackOC.Size = new System.Drawing.Size(111, 42);
            this.btnBackOC.TabIndex = 5;
            this.btnBackOC.Text = "Close";
            this.btnBackOC.UseVisualStyleBackColor = true;
            // 
            // frOrderConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 421);
            this.Controls.Add(this.btnBackOC);
            this.Controls.Add(this.btnCancelO);
            this.Controls.Add(this.btnEditO);
            this.Controls.Add(this.btnConfirmO);
            this.Controls.Add(this.txtDayOrders);
            this.Name = "frOrderConfirm";
            this.Text = "frOrderConfirm";
            this.Load += new System.EventHandler(this.frOrderConfirm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDayOrders;
        private System.Windows.Forms.Button btnConfirmO;
        private System.Windows.Forms.Button btnEditO;
        private System.Windows.Forms.Button btnCancelO;
        private System.Windows.Forms.Button btnBackOC;
    }
}