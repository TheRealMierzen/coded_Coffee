namespace _213
{
    partial class frmUpdateUser
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
            this.txtCUser = new System.Windows.Forms.TextBox();
            this.txtNUser = new System.Windows.Forms.TextBox();
            this.txtAuthLevel = new System.Windows.Forms.TextBox();
            this.lblCUser = new System.Windows.Forms.Label();
            this.lblNUser = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblNEmail = new System.Windows.Forms.Label();
            this.txtNEmail = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.uUserCancel = new System.Windows.Forms.Button();
            this.cbUuser = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCNEmail = new System.Windows.Forms.TextBox();
            this.lblCNEmail = new System.Windows.Forms.Label();
            this.lblCNUser = new System.Windows.Forms.Label();
            this.txtCNUser = new System.Windows.Forms.TextBox();
            this.lblLvlUser = new System.Windows.Forms.Label();
            this.txtLvlUser = new System.Windows.Forms.TextBox();
            this.lblUserEmail = new System.Windows.Forms.Label();
            this.txtUserEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCUser
            // 
            this.txtCUser.Location = new System.Drawing.Point(209, 67);
            this.txtCUser.Name = "txtCUser";
            this.txtCUser.Size = new System.Drawing.Size(148, 22);
            this.txtCUser.TabIndex = 2;
            this.txtCUser.TextChanged += new System.EventHandler(this.txtCUser_TextChanged);
            // 
            // txtNUser
            // 
            this.txtNUser.Location = new System.Drawing.Point(209, 97);
            this.txtNUser.Name = "txtNUser";
            this.txtNUser.Size = new System.Drawing.Size(148, 22);
            this.txtNUser.TabIndex = 3;
            this.txtNUser.TextChanged += new System.EventHandler(this.txtNUser_TextChanged);
            // 
            // txtAuthLevel
            // 
            this.txtAuthLevel.Location = new System.Drawing.Point(209, 97);
            this.txtAuthLevel.Name = "txtAuthLevel";
            this.txtAuthLevel.Size = new System.Drawing.Size(148, 22);
            this.txtAuthLevel.TabIndex = 3;
            this.txtAuthLevel.TextChanged += new System.EventHandler(this.txtAuthLevel_TextChanged);
            // 
            // lblCUser
            // 
            this.lblCUser.AutoSize = true;
            this.lblCUser.Location = new System.Drawing.Point(23, 70);
            this.lblCUser.Name = "lblCUser";
            this.lblCUser.Size = new System.Drawing.Size(163, 17);
            this.lblCUser.TabIndex = 0;
            this.lblCUser.Text = "Current username/email:";
            // 
            // lblNUser
            // 
            this.lblNUser.AutoSize = true;
            this.lblNUser.Location = new System.Drawing.Point(23, 100);
            this.lblNUser.Name = "lblNUser";
            this.lblNUser.Size = new System.Drawing.Size(106, 17);
            this.lblNUser.TabIndex = 0;
            this.lblNUser.Text = "New username:";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(23, 100);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(171, 17);
            this.lblLevel.TabIndex = 0;
            this.lblLevel.Text = "Authorization level (1-10):";
            // 
            // lblNEmail
            // 
            this.lblNEmail.AutoSize = true;
            this.lblNEmail.Location = new System.Drawing.Point(23, 100);
            this.lblNEmail.Name = "lblNEmail";
            this.lblNEmail.Size = new System.Drawing.Size(131, 17);
            this.lblNEmail.TabIndex = 0;
            this.lblNEmail.Text = "New email address:";
            // 
            // txtNEmail
            // 
            this.txtNEmail.Location = new System.Drawing.Point(209, 97);
            this.txtNEmail.Name = "txtNEmail";
            this.txtNEmail.Size = new System.Drawing.Size(148, 22);
            this.txtNEmail.TabIndex = 3;
            this.txtNEmail.TextChanged += new System.EventHandler(this.txtNEmail_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(99, 175);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 33);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // uUserCancel
            // 
            this.uUserCancel.Location = new System.Drawing.Point(223, 175);
            this.uUserCancel.Name = "uUserCancel";
            this.uUserCancel.Size = new System.Drawing.Size(75, 33);
            this.uUserCancel.TabIndex = 6;
            this.uUserCancel.Text = "Cancel";
            this.uUserCancel.UseVisualStyleBackColor = true;
            this.uUserCancel.Click += new System.EventHandler(this.uUserCancel_Click);
            // 
            // cbUuser
            // 
            this.cbUuser.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbUuser.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbUuser.FormattingEnabled = true;
            this.cbUuser.Items.AddRange(new object[] {
            "Account level",
            "Email address",
            "Username"});
            this.cbUuser.Location = new System.Drawing.Point(209, 15);
            this.cbUuser.Name = "cbUuser";
            this.cbUuser.Size = new System.Drawing.Size(148, 24);
            this.cbUuser.TabIndex = 1;
            this.cbUuser.SelectedIndexChanged += new System.EventHandler(this.cbUuser_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Please select item to update:";
            // 
            // txtCNEmail
            // 
            this.txtCNEmail.Location = new System.Drawing.Point(209, 126);
            this.txtCNEmail.Name = "txtCNEmail";
            this.txtCNEmail.Size = new System.Drawing.Size(148, 22);
            this.txtCNEmail.TabIndex = 4;
            this.txtCNEmail.TextChanged += new System.EventHandler(this.txtCNEmail_TextChanged);
            // 
            // lblCNEmail
            // 
            this.lblCNEmail.AutoSize = true;
            this.lblCNEmail.Location = new System.Drawing.Point(23, 129);
            this.lblCNEmail.Name = "lblCNEmail";
            this.lblCNEmail.Size = new System.Drawing.Size(181, 17);
            this.lblCNEmail.TabIndex = 0;
            this.lblCNEmail.Text = "Confirm new email address:";
            // 
            // lblCNUser
            // 
            this.lblCNUser.AutoSize = true;
            this.lblCNUser.Location = new System.Drawing.Point(23, 129);
            this.lblCNUser.Name = "lblCNUser";
            this.lblCNUser.Size = new System.Drawing.Size(156, 17);
            this.lblCNUser.TabIndex = 0;
            this.lblCNUser.Text = "Confirm new username:";
            // 
            // txtCNUser
            // 
            this.txtCNUser.Location = new System.Drawing.Point(209, 126);
            this.txtCNUser.Name = "txtCNUser";
            this.txtCNUser.Size = new System.Drawing.Size(148, 22);
            this.txtCNUser.TabIndex = 4;
            this.txtCNUser.TextChanged += new System.EventHandler(this.txtCNUser_TextChanged);
            // 
            // lblLvlUser
            // 
            this.lblLvlUser.AutoSize = true;
            this.lblLvlUser.Location = new System.Drawing.Point(23, 70);
            this.lblLvlUser.Name = "lblLvlUser";
            this.lblLvlUser.Size = new System.Drawing.Size(77, 17);
            this.lblLvlUser.TabIndex = 0;
            this.lblLvlUser.Text = "Username:";
            // 
            // txtLvlUser
            // 
            this.txtLvlUser.Location = new System.Drawing.Point(209, 67);
            this.txtLvlUser.Name = "txtLvlUser";
            this.txtLvlUser.Size = new System.Drawing.Size(148, 22);
            this.txtLvlUser.TabIndex = 2;
            this.txtLvlUser.TextChanged += new System.EventHandler(this.txtLvlUser_TextChanged);
            // 
            // lblUserEmail
            // 
            this.lblUserEmail.AutoSize = true;
            this.lblUserEmail.Location = new System.Drawing.Point(23, 70);
            this.lblUserEmail.Name = "lblUserEmail";
            this.lblUserEmail.Size = new System.Drawing.Size(77, 17);
            this.lblUserEmail.TabIndex = 7;
            this.lblUserEmail.Text = "Username:";
            // 
            // txtUserEmail
            // 
            this.txtUserEmail.Location = new System.Drawing.Point(209, 67);
            this.txtUserEmail.Name = "txtUserEmail";
            this.txtUserEmail.Size = new System.Drawing.Size(148, 22);
            this.txtUserEmail.TabIndex = 2;
            this.txtUserEmail.TextChanged += new System.EventHandler(this.txtUserEmail_TextChanged);
            // 
            // frmUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 221);
            this.Controls.Add(this.txtUserEmail);
            this.Controls.Add(this.lblUserEmail);
            this.Controls.Add(this.lblLvlUser);
            this.Controls.Add(this.txtLvlUser);
            this.Controls.Add(this.lblCNUser);
            this.Controls.Add(this.txtCNUser);
            this.Controls.Add(this.txtCNEmail);
            this.Controls.Add(this.lblCNEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbUuser);
            this.Controls.Add(this.uUserCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtNEmail);
            this.Controls.Add(this.lblNEmail);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblNUser);
            this.Controls.Add(this.lblCUser);
            this.Controls.Add(this.txtAuthLevel);
            this.Controls.Add(this.txtNUser);
            this.Controls.Add(this.txtCUser);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmUpdateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update User";
            this.Load += new System.EventHandler(this.frmUpdateUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCUser;
        private System.Windows.Forms.TextBox txtNUser;
        private System.Windows.Forms.TextBox txtAuthLevel;
        private System.Windows.Forms.Label lblCUser;
        private System.Windows.Forms.Label lblNUser;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblNEmail;
        private System.Windows.Forms.TextBox txtNEmail;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button uUserCancel;
        private System.Windows.Forms.ComboBox cbUuser;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCNEmail;
        private System.Windows.Forms.Label lblCNEmail;
        private System.Windows.Forms.Label lblCNUser;
        private System.Windows.Forms.TextBox txtCNUser;
        private System.Windows.Forms.Label lblLvlUser;
        private System.Windows.Forms.TextBox txtLvlUser;
        private System.Windows.Forms.Label lblUserEmail;
        private System.Windows.Forms.TextBox txtUserEmail;
    }
}