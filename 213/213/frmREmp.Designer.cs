namespace _213
{
    partial class frmREmp
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtCREmp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnREmpCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAuthPass = new System.Windows.Forms.TextBox();
            this.txtAuthUser = new System.Windows.Forms.TextBox();
            this.txtREmp = new System.Windows.Forms.TextBox();
            this.btnREmp = new System.Windows.Forms.Button();
            this.passTT = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Confirm ID:";
            // 
            // txtCREmp
            // 
            this.txtCREmp.Location = new System.Drawing.Point(154, 83);
            this.txtCREmp.MaxLength = 13;
            this.txtCREmp.Name = "txtCREmp";
            this.txtCREmp.Size = new System.Drawing.Size(121, 22);
            this.txtCREmp.TabIndex = 14;
            this.passTT.SetToolTip(this.txtCREmp, "Confirm employee id nr");
            this.txtCREmp.TextChanged += new System.EventHandler(this.txtCREmp_TextChanged);
            this.txtCREmp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCREmp_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Employee ID/ ID nr:";
            // 
            // btnREmpCancel
            // 
            this.btnREmpCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnREmpCancel.Location = new System.Drawing.Point(324, 131);
            this.btnREmpCancel.Name = "btnREmpCancel";
            this.btnREmpCancel.Size = new System.Drawing.Size(121, 36);
            this.btnREmpCancel.TabIndex = 17;
            this.btnREmpCancel.Text = "Cancel";
            this.passTT.SetToolTip(this.btnREmpCancel, "Click to close this window");
            this.btnREmpCancel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Authorization account details:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Remove account details:";
            // 
            // txtAuthPass
            // 
            this.txtAuthPass.Location = new System.Drawing.Point(385, 81);
            this.txtAuthPass.MaxLength = 8;
            this.txtAuthPass.Name = "txtAuthPass";
            this.txtAuthPass.PasswordChar = '*';
            this.txtAuthPass.Size = new System.Drawing.Size(121, 22);
            this.txtAuthPass.TabIndex = 15;
            this.passTT.SetToolTip(this.txtAuthPass, "Enter currently logged in administrator\'s password");
            this.txtAuthPass.TextChanged += new System.EventHandler(this.txtAuthPass_TextChanged);
            // 
            // txtAuthUser
            // 
            this.txtAuthUser.Location = new System.Drawing.Point(385, 53);
            this.txtAuthUser.Name = "txtAuthUser";
            this.txtAuthUser.Size = new System.Drawing.Size(121, 22);
            this.txtAuthUser.TabIndex = 12;
            this.passTT.SetToolTip(this.txtAuthUser, "Currently logged in adminstrator\'s username");
            // 
            // txtREmp
            // 
            this.txtREmp.Location = new System.Drawing.Point(154, 53);
            this.txtREmp.MaxLength = 13;
            this.txtREmp.Name = "txtREmp";
            this.txtREmp.Size = new System.Drawing.Size(121, 22);
            this.txtREmp.TabIndex = 13;
            this.passTT.SetToolTip(this.txtREmp, "Enter employee id of the employee you wish to remove");
            this.txtREmp.TextChanged += new System.EventHandler(this.txtREmp_TextChanged);
            this.txtREmp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtREmp_KeyPress);
            // 
            // btnREmp
            // 
            this.btnREmp.Enabled = false;
            this.btnREmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnREmp.Location = new System.Drawing.Point(149, 131);
            this.btnREmp.Name = "btnREmp";
            this.btnREmp.Size = new System.Drawing.Size(144, 36);
            this.btnREmp.TabIndex = 16;
            this.btnREmp.Text = "Remove Employee";
            this.passTT.SetToolTip(this.btnREmp, "Click to remove employee");
            this.btnREmp.UseVisualStyleBackColor = true;
            this.btnREmp.Click += new System.EventHandler(this.btnREmp_Click);
            // 
            // passTT
            // 
            this.passTT.AutoPopDelay = 5000;
            this.passTT.InitialDelay = 750;
            this.passTT.IsBalloon = true;
            this.passTT.ReshowDelay = 100;
            this.passTT.Tag = "";
            this.passTT.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.passTT.ToolTipTitle = "Need help?";
            // 
            // frmREmp
            // 
            this.AcceptButton = this.btnREmp;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnREmpCancel;
            this.ClientSize = new System.Drawing.Size(561, 183);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCREmp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnREmpCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAuthPass);
            this.Controls.Add(this.txtAuthUser);
            this.Controls.Add(this.txtREmp);
            this.Controls.Add(this.btnREmp);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmREmp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove employee";
            this.Load += new System.EventHandler(this.frmREmp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCREmp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnREmpCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAuthPass;
        private System.Windows.Forms.TextBox txtAuthUser;
        private System.Windows.Forms.TextBox txtREmp;
        private System.Windows.Forms.Button btnREmp;
        private System.Windows.Forms.ToolTip passTT;
    }
}