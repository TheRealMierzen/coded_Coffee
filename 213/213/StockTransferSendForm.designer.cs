namespace _213
{
    partial class StockTransferSendForm
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
            this.btnCancelSend = new System.Windows.Forms.Button();
            this.btnConfirmSend = new System.Windows.Forms.Button();
            this.cmbBranchSend = new System.Windows.Forms.ComboBox();
            this.lblBranchSend = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelSend
            // 
            this.btnCancelSend.Location = new System.Drawing.Point(138, 38);
            this.btnCancelSend.Name = "btnCancelSend";
            this.btnCancelSend.Size = new System.Drawing.Size(75, 23);
            this.btnCancelSend.TabIndex = 7;
            this.btnCancelSend.Text = "Cancel";
            this.btnCancelSend.UseVisualStyleBackColor = true;
            this.btnCancelSend.Click += new System.EventHandler(this.btnCancelSend_Click);
            // 
            // btnConfirmSend
            // 
            this.btnConfirmSend.Location = new System.Drawing.Point(11, 38);
            this.btnConfirmSend.Name = "btnConfirmSend";
            this.btnConfirmSend.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmSend.TabIndex = 6;
            this.btnConfirmSend.Text = "OK";
            this.btnConfirmSend.UseVisualStyleBackColor = true;
            this.btnConfirmSend.Click += new System.EventHandler(this.btnConfirmSend_Click);
            // 
            // cmbBranchSend
            // 
            this.cmbBranchSend.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBranchSend.FormattingEnabled = true;
            this.cmbBranchSend.Items.AddRange(new object[] {
            "Hier kom die lys van die ander branches"});
            this.cmbBranchSend.Location = new System.Drawing.Point(92, 6);
            this.cmbBranchSend.Name = "cmbBranchSend";
            this.cmbBranchSend.Size = new System.Drawing.Size(121, 21);
            this.cmbBranchSend.TabIndex = 5;
            // 
            // lblBranchSend
            // 
            this.lblBranchSend.AutoSize = true;
            this.lblBranchSend.Location = new System.Drawing.Point(12, 9);
            this.lblBranchSend.Name = "lblBranchSend";
            this.lblBranchSend.Size = new System.Drawing.Size(74, 13);
            this.lblBranchSend.TabIndex = 4;
            this.lblBranchSend.Text = "Select Branch";
            // 
            // StockTransferSend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 69);
            this.Controls.Add(this.btnCancelSend);
            this.Controls.Add(this.btnConfirmSend);
            this.Controls.Add(this.cmbBranchSend);
            this.Controls.Add(this.lblBranchSend);
            this.Name = "StockTransferSend";
            this.Text = "Send Stock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelSend;
        private System.Windows.Forms.Button btnConfirmSend;
        private System.Windows.Forms.ComboBox cmbBranchSend;
        private System.Windows.Forms.Label lblBranchSend;
    }
}