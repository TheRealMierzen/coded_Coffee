﻿namespace _213
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
            this.cbLevel = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtCUser
            // 
            this.txtCUser.Location = new System.Drawing.Point(418, 130);
            this.txtCUser.Margin = new System.Windows.Forms.Padding(6);
            this.txtCUser.Name = "txtCUser";
            this.txtCUser.Size = new System.Drawing.Size(292, 38);
            this.txtCUser.TabIndex = 2;
            this.txtCUser.TextChanged += new System.EventHandler(this.txtCUser_TextChanged);
            // 
            // txtNUser
            // 
            this.txtNUser.Location = new System.Drawing.Point(418, 188);
            this.txtNUser.Margin = new System.Windows.Forms.Padding(6);
            this.txtNUser.Name = "txtNUser";
            this.txtNUser.Size = new System.Drawing.Size(292, 38);
            this.txtNUser.TabIndex = 3;
            this.txtNUser.TextChanged += new System.EventHandler(this.txtNUser_TextChanged);
            // 
            // lblCUser
            // 
            this.lblCUser.AutoSize = true;
            this.lblCUser.Location = new System.Drawing.Point(46, 136);
            this.lblCUser.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCUser.Name = "lblCUser";
            this.lblCUser.Size = new System.Drawing.Size(327, 32);
            this.lblCUser.TabIndex = 0;
            this.lblCUser.Text = "Current username/email:";
            // 
            // lblNUser
            // 
            this.lblNUser.AutoSize = true;
            this.lblNUser.Location = new System.Drawing.Point(46, 194);
            this.lblNUser.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNUser.Name = "lblNUser";
            this.lblNUser.Size = new System.Drawing.Size(212, 32);
            this.lblNUser.TabIndex = 0;
            this.lblNUser.Text = "New username:";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(46, 194);
            this.lblLevel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(258, 32);
            this.lblLevel.TabIndex = 0;
            this.lblLevel.Text = "Authorization level:";
            // 
            // lblNEmail
            // 
            this.lblNEmail.AutoSize = true;
            this.lblNEmail.Location = new System.Drawing.Point(46, 194);
            this.lblNEmail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNEmail.Name = "lblNEmail";
            this.lblNEmail.Size = new System.Drawing.Size(263, 32);
            this.lblNEmail.TabIndex = 0;
            this.lblNEmail.Text = "New email address:";
            // 
            // txtNEmail
            // 
            this.txtNEmail.Location = new System.Drawing.Point(418, 188);
            this.txtNEmail.Margin = new System.Windows.Forms.Padding(6);
            this.txtNEmail.Name = "txtNEmail";
            this.txtNEmail.Size = new System.Drawing.Size(292, 38);
            this.txtNEmail.TabIndex = 3;
            this.txtNEmail.TextChanged += new System.EventHandler(this.txtNEmail_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(198, 339);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(208, 70);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update user";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // uUserCancel
            // 
            this.uUserCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.uUserCancel.Location = new System.Drawing.Point(418, 339);
            this.uUserCancel.Margin = new System.Windows.Forms.Padding(6);
            this.uUserCancel.Name = "uUserCancel";
            this.uUserCancel.Size = new System.Drawing.Size(208, 70);
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
            this.cbUuser.Location = new System.Drawing.Point(418, 29);
            this.cbUuser.Margin = new System.Windows.Forms.Padding(6);
            this.cbUuser.Name = "cbUuser";
            this.cbUuser.Size = new System.Drawing.Size(292, 39);
            this.cbUuser.TabIndex = 1;
            this.cbUuser.SelectedIndexChanged += new System.EventHandler(this.cbUuser_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 35);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(380, 32);
            this.label8.TabIndex = 0;
            this.label8.Text = "Please select item to update:";
            // 
            // txtCNEmail
            // 
            this.txtCNEmail.Location = new System.Drawing.Point(418, 244);
            this.txtCNEmail.Margin = new System.Windows.Forms.Padding(6);
            this.txtCNEmail.Name = "txtCNEmail";
            this.txtCNEmail.Size = new System.Drawing.Size(292, 38);
            this.txtCNEmail.TabIndex = 4;
            this.txtCNEmail.TextChanged += new System.EventHandler(this.txtCNEmail_TextChanged);
            // 
            // lblCNEmail
            // 
            this.lblCNEmail.AutoSize = true;
            this.lblCNEmail.Location = new System.Drawing.Point(46, 250);
            this.lblCNEmail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCNEmail.Name = "lblCNEmail";
            this.lblCNEmail.Size = new System.Drawing.Size(365, 32);
            this.lblCNEmail.TabIndex = 0;
            this.lblCNEmail.Text = "Confirm new email address:";
            // 
            // lblCNUser
            // 
            this.lblCNUser.AutoSize = true;
            this.lblCNUser.Location = new System.Drawing.Point(46, 250);
            this.lblCNUser.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblCNUser.Name = "lblCNUser";
            this.lblCNUser.Size = new System.Drawing.Size(314, 32);
            this.lblCNUser.TabIndex = 0;
            this.lblCNUser.Text = "Confirm new username:";
            // 
            // txtCNUser
            // 
            this.txtCNUser.Location = new System.Drawing.Point(418, 244);
            this.txtCNUser.Margin = new System.Windows.Forms.Padding(6);
            this.txtCNUser.Name = "txtCNUser";
            this.txtCNUser.Size = new System.Drawing.Size(292, 38);
            this.txtCNUser.TabIndex = 4;
            this.txtCNUser.TextChanged += new System.EventHandler(this.txtCNUser_TextChanged);
            // 
            // lblLvlUser
            // 
            this.lblLvlUser.AutoSize = true;
            this.lblLvlUser.Location = new System.Drawing.Point(46, 136);
            this.lblLvlUser.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLvlUser.Name = "lblLvlUser";
            this.lblLvlUser.Size = new System.Drawing.Size(153, 32);
            this.lblLvlUser.TabIndex = 0;
            this.lblLvlUser.Text = "Username:";
            // 
            // txtLvlUser
            // 
            this.txtLvlUser.Location = new System.Drawing.Point(418, 130);
            this.txtLvlUser.Margin = new System.Windows.Forms.Padding(6);
            this.txtLvlUser.Name = "txtLvlUser";
            this.txtLvlUser.Size = new System.Drawing.Size(292, 38);
            this.txtLvlUser.TabIndex = 2;
            this.txtLvlUser.TextChanged += new System.EventHandler(this.txtLvlUser_TextChanged);
            // 
            // lblUserEmail
            // 
            this.lblUserEmail.AutoSize = true;
            this.lblUserEmail.Location = new System.Drawing.Point(46, 136);
            this.lblUserEmail.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUserEmail.Name = "lblUserEmail";
            this.lblUserEmail.Size = new System.Drawing.Size(153, 32);
            this.lblUserEmail.TabIndex = 7;
            this.lblUserEmail.Text = "Username:";
            // 
            // txtUserEmail
            // 
            this.txtUserEmail.Location = new System.Drawing.Point(418, 130);
            this.txtUserEmail.Margin = new System.Windows.Forms.Padding(6);
            this.txtUserEmail.Name = "txtUserEmail";
            this.txtUserEmail.Size = new System.Drawing.Size(292, 38);
            this.txtUserEmail.TabIndex = 2;
            this.txtUserEmail.TextChanged += new System.EventHandler(this.txtUserEmail_TextChanged);
            // 
            // cbLevel
            // 
            this.cbLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLevel.FormattingEnabled = true;
            this.cbLevel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbLevel.Location = new System.Drawing.Point(418, 188);
            this.cbLevel.Name = "cbLevel";
            this.cbLevel.Size = new System.Drawing.Size(292, 39);
            this.cbLevel.TabIndex = 8;
            // 
            // frmUpdateUser
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.uUserCancel;
            this.ClientSize = new System.Drawing.Size(758, 453);
            this.Controls.Add(this.cbLevel);
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
            this.Controls.Add(this.txtNUser);
            this.Controls.Add(this.txtCUser);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
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
        private System.Windows.Forms.ComboBox cbLevel;
    }
}