namespace _213
{
    partial class loginForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.passTT = new System.Windows.Forms.ToolTip(this.components);
            this.btnLForgotPass = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.notification = new System.Windows.Forms.NotifyIcon(this.components);
            this.txtLPass = new wmgCMS.WaterMarkTextBox();
            this.txtLEmail = new wmgCMS.WaterMarkTextBox();
            this.textbox1 = new wmgCMS.WaterMarkTextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(528, 268);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.MaximumSize = new System.Drawing.Size(196, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 27);
            this.button2.TabIndex = 5;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(412, 268);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.MaximumSize = new System.Drawing.Size(196, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 27);
            this.button1.TabIndex = 4;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreate.Enabled = false;
            this.btnCreate.Location = new System.Drawing.Point(412, 299);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(99, 27);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create User";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Visible = false;
            this.btnCreate.Click += new System.EventHandler(this.button3_Click);
            // 
            // passTT
            // 
            this.passTT.AutoPopDelay = 5000;
            this.passTT.InitialDelay = 100;
            this.passTT.IsBalloon = true;
            this.passTT.ReshowDelay = 100;
            this.passTT.Tag = "";
            this.passTT.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.passTT.ToolTipTitle = "Password Help";
            // 
            // btnLForgotPass
            // 
            this.btnLForgotPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLForgotPass.Location = new System.Drawing.Point(633, 188);
            this.btnLForgotPass.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLForgotPass.Name = "btnLForgotPass";
            this.btnLForgotPass.Size = new System.Drawing.Size(28, 28);
            this.btnLForgotPass.TabIndex = 2;
            this.btnLForgotPass.Text = "?";
            this.passTT.SetToolTip(this.btnLForgotPass, "Forgot your password?\r\n\r\nConsult an administrator for your password.\r\n\r\nLost the " +
        "password email?\r\n\r\nClick here to let an adminstrator generate a \r\nnew password f" +
        "or your account.");
            this.btnLForgotPass.UseVisualStyleBackColor = true;
            this.btnLForgotPass.Visible = false;
            this.btnLForgotPass.VisibleChanged += new System.EventHandler(this.btnLForgotPass_VisibleChanged);
            this.btnLForgotPass.Click += new System.EventHandler(this.btnLForgotPass_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(388, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcom to stockI.T";
            // 
            // notification
            // 
            this.notification.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notification.Visible = true;
            // 
            // txtLPass
            // 
            this.txtLPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txtLPass.Location = new System.Drawing.Point(412, 191);
            this.txtLPass.MaxLength = 100;
            this.txtLPass.Name = "txtLPass";
            this.txtLPass.PasswordChar = '*';
            this.txtLPass.Size = new System.Drawing.Size(215, 22);
            this.txtLPass.TabIndex = 2;
            this.txtLPass.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtLPass.WaterMarkText = "Password";
            this.txtLPass.TextChanged += new System.EventHandler(this.txtLPass_TextChanged);
            // 
            // txtLEmail
            // 
            this.txtLEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.txtLEmail.Location = new System.Drawing.Point(412, 234);
            this.txtLEmail.Name = "txtLEmail";
            this.txtLEmail.Size = new System.Drawing.Size(215, 22);
            this.txtLEmail.TabIndex = 3;
            this.txtLEmail.Visible = false;
            this.txtLEmail.WaterMarkColor = System.Drawing.Color.Gray;
            this.txtLEmail.WaterMarkText = "Email address";
            this.txtLEmail.TextChanged += new System.EventHandler(this.txtLEmail_TextChanged_1);
            // 
            // textbox1
            // 
            this.textbox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textbox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.textbox1.Location = new System.Drawing.Point(412, 146);
            this.textbox1.MaxLength = 100;
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(215, 22);
            this.textbox1.TabIndex = 1;
            this.textbox1.WaterMarkColor = System.Drawing.Color.Gray;
            this.textbox1.WaterMarkText = "Username";
            this.textbox1.TextChanged += new System.EventHandler(this.textbox1_TextChanged_1);
            // 
            // loginForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::_213.Properties.Resources._48992;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(953, 447);
            this.Controls.Add(this.txtLPass);
            this.Controls.Add(this.txtLEmail);
            this.Controls.Add(this.textbox1);
            this.Controls.Add(this.btnLForgotPass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "loginForm";
            this.Text = "stockI.T";
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ToolTip passTT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLForgotPass;
        private wmgCMS.WaterMarkTextBox textbox1;
        private wmgCMS.WaterMarkTextBox txtLEmail;
        private wmgCMS.WaterMarkTextBox txtLPass;
        private System.Windows.Forms.NotifyIcon notification;
    }
}