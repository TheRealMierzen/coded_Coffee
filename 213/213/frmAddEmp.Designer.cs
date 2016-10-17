namespace _213
{
    partial class frmAddEmp
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
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtEmpSurname = new System.Windows.Forms.TextBox();
            this.txtEmpRSAID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gbEmpDetails = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.gbContact = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmpCell = new System.Windows.Forms.TextBox();
            this.txtEmpEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbEmplDetails = new System.Windows.Forms.GroupBox();
            this.cbIsUser = new System.Windows.Forms.CheckBox();
            this.gbEmpType = new System.Windows.Forms.GroupBox();
            this.rbTemp = new System.Windows.Forms.RadioButton();
            this.rbManager = new System.Windows.Forms.RadioButton();
            this.rbFull = new System.Windows.Forms.RadioButton();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddEmp = new System.Windows.Forms.Button();
            this.btnCancelEmp = new System.Windows.Forms.Button();
            this.passTT = new System.Windows.Forms.ToolTip(this.components);
            this.gbEmpDetails.SuspendLayout();
            this.gbContact.SuspendLayout();
            this.gbEmplDetails.SuspendLayout();
            this.gbEmpType.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(219, 68);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(146, 22);
            this.txtEmpName.TabIndex = 3;
            this.passTT.SetToolTip(this.txtEmpName, "Enter name of new employee");
            this.txtEmpName.TextChanged += new System.EventHandler(this.txtEmpName_TextChanged);
            // 
            // txtEmpSurname
            // 
            this.txtEmpSurname.Location = new System.Drawing.Point(219, 99);
            this.txtEmpSurname.Name = "txtEmpSurname";
            this.txtEmpSurname.Size = new System.Drawing.Size(146, 22);
            this.txtEmpSurname.TabIndex = 4;
            this.passTT.SetToolTip(this.txtEmpSurname, "Enter surname of new employee");
            this.txtEmpSurname.TextChanged += new System.EventHandler(this.txtEmpSurname_TextChanged);
            // 
            // txtEmpRSAID
            // 
            this.txtEmpRSAID.Location = new System.Drawing.Point(219, 131);
            this.txtEmpRSAID.MaxLength = 13;
            this.txtEmpRSAID.Name = "txtEmpRSAID";
            this.txtEmpRSAID.Size = new System.Drawing.Size(146, 22);
            this.txtEmpRSAID.TabIndex = 5;
            this.passTT.SetToolTip(this.txtEmpRSAID, "Enter government issued id nr");
            this.txtEmpRSAID.TextChanged += new System.EventHandler(this.txtEmpRSAID_TextChanged);
            this.txtEmpRSAID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpRSAID_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Surname:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "RSA ID nr:";
            // 
            // gbEmpDetails
            // 
            this.gbEmpDetails.Controls.Add(this.label3);
            this.gbEmpDetails.Controls.Add(this.label2);
            this.gbEmpDetails.Controls.Add(this.label1);
            this.gbEmpDetails.Controls.Add(this.txtEmpSurname);
            this.gbEmpDetails.Controls.Add(this.txtEmpName);
            this.gbEmpDetails.Controls.Add(this.txtEmpID);
            this.gbEmpDetails.Controls.Add(this.label4);
            this.gbEmpDetails.Controls.Add(this.txtEmpRSAID);
            this.gbEmpDetails.Location = new System.Drawing.Point(16, 12);
            this.gbEmpDetails.Name = "gbEmpDetails";
            this.gbEmpDetails.Size = new System.Drawing.Size(397, 169);
            this.gbEmpDetails.TabIndex = 1;
            this.gbEmpDetails.TabStop = false;
            this.gbEmpDetails.Text = "New employee details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID:";
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(219, 35);
            this.txtEmpID.MaxLength = 10;
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(146, 22);
            this.txtEmpID.TabIndex = 2;
            this.passTT.SetToolTip(this.txtEmpID, "New employee\'s employee id");
            this.txtEmpID.TextChanged += new System.EventHandler(this.txtEmpID_TextChanged);
            // 
            // gbContact
            // 
            this.gbContact.Controls.Add(this.label5);
            this.gbContact.Controls.Add(this.txtEmpCell);
            this.gbContact.Controls.Add(this.txtEmpEmail);
            this.gbContact.Controls.Add(this.label6);
            this.gbContact.Location = new System.Drawing.Point(16, 187);
            this.gbContact.Name = "gbContact";
            this.gbContact.Size = new System.Drawing.Size(397, 109);
            this.gbContact.TabIndex = 6;
            this.gbContact.TabStop = false;
            this.gbContact.Text = "Contact details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email address:";
            // 
            // txtEmpCell
            // 
            this.txtEmpCell.Location = new System.Drawing.Point(219, 62);
            this.txtEmpCell.MaxLength = 10;
            this.txtEmpCell.Name = "txtEmpCell";
            this.txtEmpCell.Size = new System.Drawing.Size(146, 22);
            this.txtEmpCell.TabIndex = 8;
            this.passTT.SetToolTip(this.txtEmpCell, "Enter cellphone number of new employee");
            this.txtEmpCell.TextChanged += new System.EventHandler(this.txtEmpCell_TextChanged);
            this.txtEmpCell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpCell_KeyPress);
            // 
            // txtEmpEmail
            // 
            this.txtEmpEmail.Location = new System.Drawing.Point(219, 31);
            this.txtEmpEmail.Name = "txtEmpEmail";
            this.txtEmpEmail.Size = new System.Drawing.Size(146, 22);
            this.txtEmpEmail.TabIndex = 7;
            this.passTT.SetToolTip(this.txtEmpEmail, "Enter email address of new employee");
            this.txtEmpEmail.TextChanged += new System.EventHandler(this.txtEmpEmail_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Cell nr:";
            // 
            // gbEmplDetails
            // 
            this.gbEmplDetails.Controls.Add(this.cbIsUser);
            this.gbEmplDetails.Controls.Add(this.gbEmpType);
            this.gbEmplDetails.Controls.Add(this.lblEndDate);
            this.gbEmplDetails.Controls.Add(this.dtEnd);
            this.gbEmplDetails.Controls.Add(this.dtStart);
            this.gbEmplDetails.Controls.Add(this.label9);
            this.gbEmplDetails.Location = new System.Drawing.Point(16, 302);
            this.gbEmplDetails.Name = "gbEmplDetails";
            this.gbEmplDetails.Size = new System.Drawing.Size(397, 235);
            this.gbEmplDetails.TabIndex = 9;
            this.gbEmplDetails.TabStop = false;
            this.gbEmplDetails.Text = "Employment details:";
            // 
            // cbIsUser
            // 
            this.cbIsUser.AutoSize = true;
            this.cbIsUser.Location = new System.Drawing.Point(30, 198);
            this.cbIsUser.Name = "cbIsUser";
            this.cbIsUser.Size = new System.Drawing.Size(125, 21);
            this.cbIsUser.TabIndex = 16;
            this.cbIsUser.Text = "Is stockI.T user";
            this.passTT.SetToolTip(this.cbIsUser, "Check if new employee will use stockI.T");
            this.cbIsUser.UseVisualStyleBackColor = true;
            this.cbIsUser.CheckedChanged += new System.EventHandler(this.cbIsUser_CheckedChanged);
            // 
            // gbEmpType
            // 
            this.gbEmpType.Controls.Add(this.rbTemp);
            this.gbEmpType.Controls.Add(this.rbManager);
            this.gbEmpType.Controls.Add(this.rbFull);
            this.gbEmpType.Location = new System.Drawing.Point(30, 74);
            this.gbEmpType.Name = "gbEmpType";
            this.gbEmpType.Size = new System.Drawing.Size(183, 105);
            this.gbEmpType.TabIndex = 11;
            this.gbEmpType.TabStop = false;
            this.gbEmpType.Text = "Type of employee";
            // 
            // rbTemp
            // 
            this.rbTemp.AutoSize = true;
            this.rbTemp.Location = new System.Drawing.Point(6, 75);
            this.rbTemp.Name = "rbTemp";
            this.rbTemp.Size = new System.Drawing.Size(168, 21);
            this.rbTemp.TabIndex = 14;
            this.rbTemp.TabStop = true;
            this.rbTemp.Text = "Termporary employee";
            this.passTT.SetToolTip(this.rbTemp, "Select if employee is only a temporary employee");
            this.rbTemp.UseVisualStyleBackColor = true;
            this.rbTemp.CheckedChanged += new System.EventHandler(this.rbTemp_CheckedChanged);
            // 
            // rbManager
            // 
            this.rbManager.AutoSize = true;
            this.rbManager.Location = new System.Drawing.Point(6, 21);
            this.rbManager.Name = "rbManager";
            this.rbManager.Size = new System.Drawing.Size(85, 21);
            this.rbManager.TabIndex = 12;
            this.rbManager.TabStop = true;
            this.rbManager.Text = "Manager";
            this.passTT.SetToolTip(this.rbManager, "Select if new employee is a manager at this branch");
            this.rbManager.UseVisualStyleBackColor = true;
            this.rbManager.TextChanged += new System.EventHandler(this.rbManager_TextChanged);
            // 
            // rbFull
            // 
            this.rbFull.AutoSize = true;
            this.rbFull.Checked = true;
            this.rbFull.Location = new System.Drawing.Point(6, 48);
            this.rbFull.Name = "rbFull";
            this.rbFull.Size = new System.Drawing.Size(81, 21);
            this.rbFull.TabIndex = 13;
            this.rbFull.TabStop = true;
            this.rbFull.Text = "Full time";
            this.passTT.SetToolTip(this.rbFull, "Select if new employee is a full time employee");
            this.rbFull.UseVisualStyleBackColor = true;
            this.rbFull.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.rbFull_ControlAdded);
            // 
            // lblEndDate
            // 
            this.lblEndDate.Location = new System.Drawing.Point(216, 105);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(149, 38);
            this.lblEndDate.TabIndex = 0;
            this.lblEndDate.Text = "End date of employement:";
            this.lblEndDate.Visible = false;
            // 
            // dtEnd
            // 
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEnd.Location = new System.Drawing.Point(216, 150);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(149, 22);
            this.dtEnd.TabIndex = 15;
            this.passTT.SetToolTip(this.dtEnd, "Select the date until which the new temporary\r\nemployee will be working at Matrix" +
        " Warehouse");
            this.dtEnd.Visible = false;
            this.dtEnd.ValueChanged += new System.EventHandler(this.dtEnd_ValueChanged);
            // 
            // dtStart
            // 
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStart.Location = new System.Drawing.Point(219, 34);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(146, 22);
            this.dtStart.TabIndex = 10;
            this.passTT.SetToolTip(this.dtStart, "Select the date the new employee will \r\nstart working at Matrix Warehouse");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(170, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Start date of employment:";
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.Enabled = false;
            this.btnAddEmp.Location = new System.Drawing.Point(92, 558);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(121, 36);
            this.btnAddEmp.TabIndex = 17;
            this.btnAddEmp.Text = "Add employee";
            this.passTT.SetToolTip(this.btnAddEmp, "Click to add new employee");
            this.btnAddEmp.UseVisualStyleBackColor = true;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // btnCancelEmp
            // 
            this.btnCancelEmp.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelEmp.Location = new System.Drawing.Point(235, 558);
            this.btnCancelEmp.Name = "btnCancelEmp";
            this.btnCancelEmp.Size = new System.Drawing.Size(121, 36);
            this.btnCancelEmp.TabIndex = 18;
            this.btnCancelEmp.Text = "Cancel";
            this.passTT.SetToolTip(this.btnCancelEmp, "Click to close this window");
            this.btnCancelEmp.UseVisualStyleBackColor = true;
            this.btnCancelEmp.Click += new System.EventHandler(this.btnCancelEmp_Click);
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
            // frmAddEmp
            // 
            this.AcceptButton = this.btnAddEmp;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelEmp;
            this.ClientSize = new System.Drawing.Size(429, 606);
            this.Controls.Add(this.btnCancelEmp);
            this.Controls.Add(this.btnAddEmp);
            this.Controls.Add(this.gbEmplDetails);
            this.Controls.Add(this.gbContact);
            this.Controls.Add(this.gbEmpDetails);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddEmp";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add  Employee";
            this.Load += new System.EventHandler(this.frmAddEmp_Load);
            this.gbEmpDetails.ResumeLayout(false);
            this.gbEmpDetails.PerformLayout();
            this.gbContact.ResumeLayout(false);
            this.gbContact.PerformLayout();
            this.gbEmplDetails.ResumeLayout(false);
            this.gbEmplDetails.PerformLayout();
            this.gbEmpType.ResumeLayout(false);
            this.gbEmpType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtEmpSurname;
        private System.Windows.Forms.TextBox txtEmpRSAID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbEmpDetails;
        private System.Windows.Forms.GroupBox gbContact;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmpCell;
        private System.Windows.Forms.TextBox txtEmpEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbEmplDetails;
        private System.Windows.Forms.GroupBox gbEmpType;
        private System.Windows.Forms.RadioButton rbTemp;
        private System.Windows.Forms.RadioButton rbManager;
        private System.Windows.Forms.RadioButton rbFull;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbIsUser;
        private System.Windows.Forms.Button btnAddEmp;
        private System.Windows.Forms.Button btnCancelEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.ToolTip passTT;
    }
}