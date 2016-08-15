namespace _213
{
    partial class StockTransferRecieveForm
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
            this.lblBranchRecieve = new System.Windows.Forms.Label();
            this.cmbBranchRecieve = new System.Windows.Forms.ComboBox();
            this.btnConfirmRecieve = new System.Windows.Forms.Button();
            this.btnCancelRecieve = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBranchRecieve
            // 
            this.lblBranchRecieve.AutoSize = true;
            this.lblBranchRecieve.Location = new System.Drawing.Point(12, 9);
            this.lblBranchRecieve.Name = "lblBranchRecieve";
            this.lblBranchRecieve.Size = new System.Drawing.Size(74, 13);
            this.lblBranchRecieve.TabIndex = 0;
            this.lblBranchRecieve.Text = "Select Branch";
            this.lblBranchRecieve.Click += new System.EventHandler(this.lblBranchRecieve_Click);
            // 
            // cmbBranchRecieve
            // 
            this.cmbBranchRecieve.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBranchRecieve.FormattingEnabled = true;
            this.cmbBranchRecieve.Items.AddRange(new object[] {
            "Hier kom die lys van die ander branches"});
            this.cmbBranchRecieve.Location = new System.Drawing.Point(92, 6);
            this.cmbBranchRecieve.Name = "cmbBranchRecieve";
            this.cmbBranchRecieve.Size = new System.Drawing.Size(121, 21);
            this.cmbBranchRecieve.TabIndex = 1;
            this.cmbBranchRecieve.SelectedIndexChanged += new System.EventHandler(this.cmbBranchRecieve_SelectedIndexChanged);
            // 
            // btnConfirmRecieve
            // 
            this.btnConfirmRecieve.Location = new System.Drawing.Point(11, 38);
            this.btnConfirmRecieve.Name = "btnConfirmRecieve";
            this.btnConfirmRecieve.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmRecieve.TabIndex = 2;
            this.btnConfirmRecieve.Text = "OK";
            this.btnConfirmRecieve.UseVisualStyleBackColor = true;
            this.btnConfirmRecieve.Click += new System.EventHandler(this.btnConfirmRecieve_Click);
            // 
            // btnCancelRecieve
            // 
            this.btnCancelRecieve.Location = new System.Drawing.Point(138, 38);
            this.btnCancelRecieve.Name = "btnCancelRecieve";
            this.btnCancelRecieve.Size = new System.Drawing.Size(75, 23);
            this.btnCancelRecieve.TabIndex = 3;
            this.btnCancelRecieve.Text = "Cancel";
            this.btnCancelRecieve.UseVisualStyleBackColor = true;
            this.btnCancelRecieve.Click += new System.EventHandler(this.btnCancelRecieve_Click);
            // 
            // StockTransferRecieve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 67);
            this.Controls.Add(this.btnCancelRecieve);
            this.Controls.Add(this.btnConfirmRecieve);
            this.Controls.Add(this.cmbBranchRecieve);
            this.Controls.Add(this.lblBranchRecieve);
            this.Name = "StockTransferRecieve";
            this.Text = "Recieve Stock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBranchRecieve;
        private System.Windows.Forms.ComboBox cmbBranchRecieve;
        private System.Windows.Forms.Button btnConfirmRecieve;
        private System.Windows.Forms.Button btnCancelRecieve;
    }
}