namespace _213
{
    partial class frmAddUser
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
            this.btnCreateAcc = new System.Windows.Forms.Button();
            this.txtNUser = new System.Windows.Forms.TextBox();
            this.txtNLvl = new System.Windows.Forms.TextBox();
            this.txtAuthUser = new System.Windows.Forms.TextBox();
            this.txtAuthPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAduCancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCreateAcc
            // 
            this.btnCreateAcc.Location = new System.Drawing.Point(107, 184);
            this.btnCreateAcc.Name = "btnCreateAcc";
            this.btnCreateAcc.Size = new System.Drawing.Size(121, 36);
            this.btnCreateAcc.TabIndex = 0;
            this.btnCreateAcc.Text = "Create Account";
            this.btnCreateAcc.UseVisualStyleBackColor = true;
            this.btnCreateAcc.Click += new System.EventHandler(this.btnCreateAcc_Click);
            // 
            // txtNUser
            // 
            this.txtNUser.Location = new System.Drawing.Point(107, 41);
            this.txtNUser.Name = "txtNUser";
            this.txtNUser.Size = new System.Drawing.Size(121, 22);
            this.txtNUser.TabIndex = 1;
            // 
            // txtNLvl
            // 
            this.txtNLvl.Location = new System.Drawing.Point(107, 70);
            this.txtNLvl.Name = "txtNLvl";
            this.txtNLvl.Size = new System.Drawing.Size(121, 22);
            this.txtNLvl.TabIndex = 2;
            // 
            // txtAuthUser
            // 
            this.txtAuthUser.Location = new System.Drawing.Point(338, 41);
            this.txtAuthUser.Name = "txtAuthUser";
            this.txtAuthUser.Size = new System.Drawing.Size(121, 22);
            this.txtAuthUser.TabIndex = 3;
            // 
            // txtAuthPass
            // 
            this.txtAuthPass.Location = new System.Drawing.Point(338, 69);
            this.txtAuthPass.Name = "txtAuthPass";
            this.txtAuthPass.PasswordChar = '*';
            this.txtAuthPass.Size = new System.Drawing.Size(121, 22);
            this.txtAuthPass.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "New account details:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Authorization account details:";
            // 
            // btnAduCancel
            // 
            this.btnAduCancel.Location = new System.Drawing.Point(277, 184);
            this.btnAduCancel.Name = "btnAduCancel";
            this.btnAduCancel.Size = new System.Drawing.Size(121, 36);
            this.btnAduCancel.TabIndex = 7;
            this.btnAduCancel.Text = "Cancel";
            this.btnAduCancel.UseVisualStyleBackColor = true;
            this.btnAduCancel.Click += new System.EventHandler(this.btnAduCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Username:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Account level:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(259, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Username:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Password:";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(446, 39);
            this.label7.TabIndex = 12;
            this.label7.Text = "*The newly created account\'s password will be sent to the authorization account\'s" +
    " email address.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Email address:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(107, 99);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(121, 22);
            this.txtEmail.TabIndex = 14;
            // 
            // frmAddUser
            // 
            this.AcceptButton = this.btnCreateAcc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnAduCancel;
            this.ClientSize = new System.Drawing.Size(496, 232);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAduCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAuthPass);
            this.Controls.Add(this.txtAuthUser);
            this.Controls.Add(this.txtNLvl);
            this.Controls.Add(this.txtNUser);
            this.Controls.Add(this.btnCreateAcc);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmAddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create User";
            this.Load += new System.EventHandler(this.frmAddUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateAcc;
        private System.Windows.Forms.TextBox txtNUser;
        private System.Windows.Forms.TextBox txtNLvl;
        private System.Windows.Forms.TextBox txtAuthUser;
        private System.Windows.Forms.TextBox txtAuthPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAduCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
    }
}