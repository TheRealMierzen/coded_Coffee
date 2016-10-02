namespace _213
{
    partial class frmRUser
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRUCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAuthPass = new System.Windows.Forms.TextBox();
            this.txtAuthUser = new System.Windows.Forms.TextBox();
            this.txtRUser = new System.Windows.Forms.TextBox();
            this.btnRAcc = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCRUser = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(285, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Username:";
            // 
            // btnRUCancel
            // 
            this.btnRUCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnRUCancel.Location = new System.Drawing.Point(303, 131);
            this.btnRUCancel.Name = "btnRUCancel";
            this.btnRUCancel.Size = new System.Drawing.Size(121, 36);
            this.btnRUCancel.TabIndex = 5;
            this.btnRUCancel.Text = "Cancel";
            this.btnRUCancel.UseVisualStyleBackColor = true;
            this.btnRUCancel.Click += new System.EventHandler(this.btnRUCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Authorization account details:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Remove account details:";
            // 
            // txtAuthPass
            // 
            this.txtAuthPass.Location = new System.Drawing.Point(364, 81);
            this.txtAuthPass.Name = "txtAuthPass";
            this.txtAuthPass.PasswordChar = '*';
            this.txtAuthPass.Size = new System.Drawing.Size(121, 22);
            this.txtAuthPass.TabIndex = 3;
            this.txtAuthPass.TextChanged += new System.EventHandler(this.txtAuthPass_TextChanged);
            // 
            // txtAuthUser
            // 
            this.txtAuthUser.Location = new System.Drawing.Point(364, 53);
            this.txtAuthUser.Name = "txtAuthUser";
            this.txtAuthUser.Size = new System.Drawing.Size(121, 22);
            this.txtAuthUser.TabIndex = 0;
            // 
            // txtRUser
            // 
            this.txtRUser.Location = new System.Drawing.Point(133, 53);
            this.txtRUser.Name = "txtRUser";
            this.txtRUser.Size = new System.Drawing.Size(121, 22);
            this.txtRUser.TabIndex = 1;
            this.txtRUser.TextChanged += new System.EventHandler(this.txtRUser_TextChanged);
            // 
            // btnRAcc
            // 
            this.btnRAcc.Enabled = false;
            this.btnRAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRAcc.Location = new System.Drawing.Point(128, 131);
            this.btnRAcc.Name = "btnRAcc";
            this.btnRAcc.Size = new System.Drawing.Size(134, 36);
            this.btnRAcc.TabIndex = 4;
            this.btnRAcc.Text = "Remove Account";
            this.btnRAcc.UseVisualStyleBackColor = true;
            this.btnRAcc.Click += new System.EventHandler(this.btnRAcc_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Confirm username:";
            // 
            // txtCRUser
            // 
            this.txtCRUser.Location = new System.Drawing.Point(133, 83);
            this.txtCRUser.Name = "txtCRUser";
            this.txtCRUser.Size = new System.Drawing.Size(121, 22);
            this.txtCRUser.TabIndex = 2;
            this.txtCRUser.TextChanged += new System.EventHandler(this.txtCRUser_TextChanged);
            // 
            // frmRUser
            // 
            this.AcceptButton = this.btnRAcc;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnRUCancel;
            this.ClientSize = new System.Drawing.Size(527, 186);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCRUser);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRUCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAuthPass);
            this.Controls.Add(this.txtAuthUser);
            this.Controls.Add(this.txtRUser);
            this.Controls.Add(this.btnRAcc);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRUser";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove User";
            this.Load += new System.EventHandler(this.frmRUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRUCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAuthPass;
        private System.Windows.Forms.TextBox txtAuthUser;
        private System.Windows.Forms.TextBox txtRUser;
        private System.Windows.Forms.Button btnRAcc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCRUser;
    }
}