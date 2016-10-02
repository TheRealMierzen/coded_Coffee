namespace _213
{
    partial class frmForgotPass
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
            this.txtFPAdminU = new System.Windows.Forms.TextBox();
            this.txtFPAdminP = new System.Windows.Forms.TextBox();
            this.txtBlocked = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnFPRecover = new System.Windows.Forms.Button();
            this.btnFPCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFPAdminU
            // 
            this.txtFPAdminU.Location = new System.Drawing.Point(119, 128);
            this.txtFPAdminU.MaxLength = 50;
            this.txtFPAdminU.Name = "txtFPAdminU";
            this.txtFPAdminU.Size = new System.Drawing.Size(120, 22);
            this.txtFPAdminU.TabIndex = 2;
            this.txtFPAdminU.TextChanged += new System.EventHandler(this.txtFPAdminU_TextChanged);
            // 
            // txtFPAdminP
            // 
            this.txtFPAdminP.Location = new System.Drawing.Point(119, 160);
            this.txtFPAdminP.MaxLength = 50;
            this.txtFPAdminP.Name = "txtFPAdminP";
            this.txtFPAdminP.PasswordChar = '*';
            this.txtFPAdminP.Size = new System.Drawing.Size(120, 22);
            this.txtFPAdminP.TabIndex = 3;
            this.txtFPAdminP.TextChanged += new System.EventHandler(this.txtFPAdminP_TextChanged);
            // 
            // txtBlocked
            // 
            this.txtBlocked.Location = new System.Drawing.Point(119, 47);
            this.txtBlocked.Name = "txtBlocked";
            this.txtBlocked.Size = new System.Drawing.Size(120, 22);
            this.txtBlocked.TabIndex = 1;
            this.txtBlocked.TextChanged += new System.EventHandler(this.txtBlocked_TextChanged);
            this.txtBlocked.Leave += new System.EventHandler(this.txtBlocked_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Details of blocked account:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Administrative account\'s details:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Username:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Password:";
            // 
            // btnFPRecover
            // 
            this.btnFPRecover.Location = new System.Drawing.Point(28, 205);
            this.btnFPRecover.Name = "btnFPRecover";
            this.btnFPRecover.Size = new System.Drawing.Size(86, 36);
            this.btnFPRecover.TabIndex = 4;
            this.btnFPRecover.Text = "Recover";
            this.btnFPRecover.UseVisualStyleBackColor = true;
            this.btnFPRecover.Click += new System.EventHandler(this.btnFPRecover_Click);
            // 
            // btnFPCancel
            // 
            this.btnFPCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFPCancel.Location = new System.Drawing.Point(153, 205);
            this.btnFPCancel.Name = "btnFPCancel";
            this.btnFPCancel.Size = new System.Drawing.Size(86, 36);
            this.btnFPCancel.TabIndex = 5;
            this.btnFPCancel.Text = "Cancel";
            this.btnFPCancel.UseVisualStyleBackColor = true;
            this.btnFPCancel.Click += new System.EventHandler(this.btnFPCancel_Click);
            // 
            // frmForgotPass
            // 
            this.AcceptButton = this.btnFPRecover;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnFPCancel;
            this.ClientSize = new System.Drawing.Size(271, 253);
            this.Controls.Add(this.btnFPCancel);
            this.Controls.Add(this.btnFPRecover);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBlocked);
            this.Controls.Add(this.txtFPAdminP);
            this.Controls.Add(this.txtFPAdminU);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.Name = "frmForgotPass";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password recovery";
            this.Load += new System.EventHandler(this.frmForgotPass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFPAdminU;
        private System.Windows.Forms.TextBox txtFPAdminP;
        private System.Windows.Forms.TextBox txtBlocked;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFPRecover;
        private System.Windows.Forms.Button btnFPCancel;
    }
}