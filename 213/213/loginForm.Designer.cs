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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.passTT = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.bgWLogin = new System.ComponentModel.BackgroundWorker();
            this.loginProgress = new System.Windows.Forms.ProgressBar();
            this.bgWCreate = new System.ComponentModel.BackgroundWorker();
            this.lblWait = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(396, 219);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.MaximumSize = new System.Drawing.Size(147, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 22);
            this.button2.TabIndex = 4;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Location = new System.Drawing.Point(309, 219);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.MaximumSize = new System.Drawing.Size(147, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 22);
            this.button1.TabIndex = 3;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.Location = new System.Drawing.Point(309, 167);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.MaximumSize = new System.Drawing.Size(323, 52);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(162, 20);
            this.textBox2.TabIndex = 2;
            this.passTT.SetToolTip(this.textBox2, "Password may not:\r\n*Exceed a length of 8 characters.\r\n*May not contain a \",\" or a" +
        " \"#\" symbol.");
            this.textBox2.Click += new System.EventHandler(this.textBox2_Click);
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyUp);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.Location = new System.Drawing.Point(309, 119);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.MaximumSize = new System.Drawing.Size(323, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Username";
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreate.Location = new System.Drawing.Point(309, 219);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(74, 22);
            this.btnCreate.TabIndex = 3;
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(291, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Welcome to stockI.T";
            // 
            // bgWLogin
            // 
            this.bgWLogin.WorkerReportsProgress = true;
            this.bgWLogin.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWlogin_DoWork);
            this.bgWLogin.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWlogin_ProgressChanged);
            this.bgWLogin.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWlogin_RunWorkerCompleted);
            // 
            // loginProgress
            // 
            this.loginProgress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginProgress.Location = new System.Drawing.Point(309, 167);
            this.loginProgress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.loginProgress.Name = "loginProgress";
            this.loginProgress.Size = new System.Drawing.Size(161, 19);
            this.loginProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.loginProgress.TabIndex = 10;
            this.loginProgress.UseWaitCursor = true;
            this.loginProgress.Visible = false;
            // 
            // bgWCreate
            // 
            this.bgWCreate.WorkerReportsProgress = true;
            this.bgWCreate.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWCreate_DoWork);
            this.bgWCreate.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWCreate_ProgressChanged);
            this.bgWCreate.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWCreate_RunWorkerCompleted);
            // 
            // lblWait
            // 
            this.lblWait.AutoSize = true;
            this.lblWait.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblWait.Location = new System.Drawing.Point(344, 170);
            this.lblWait.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWait.Name = "lblWait";
            this.lblWait.Size = new System.Drawing.Size(97, 13);
            this.lblWait.TabIndex = 11;
            this.lblWait.Text = "Creating account...";
            this.lblWait.Visible = false;
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::_213.Properties.Resources._48992;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(765, 363);
            this.Controls.Add(this.lblWait);
            this.Controls.Add(this.loginProgress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "loginForm";
            this.Text = "loginForm";
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ToolTip passTT;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker bgWLogin;
        private System.Windows.Forms.ProgressBar loginProgress;
        private System.ComponentModel.BackgroundWorker bgWCreate;
        private System.Windows.Forms.Label lblWait;
    }
}