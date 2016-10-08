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
            this.bgWID = new System.ComponentModel.BackgroundWorker();
            this.gbEmpDetails.SuspendLayout();
            this.gbContact.SuspendLayout();
            this.gbEmplDetails.SuspendLayout();
            this.gbEmpType.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(164, 55);
            this.txtEmpName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(110, 20);
            this.txtEmpName.TabIndex = 3;
            this.passTT.SetToolTip(this.txtEmpName, "Enter name of new employee");
            this.txtEmpName.TextChanged += new System.EventHandler(this.txtEmpName_TextChanged);
            // 
            // txtEmpSurname
            // 
            this.txtEmpSurname.Location = new System.Drawing.Point(164, 80);
            this.txtEmpSurname.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmpSurname.Name = "txtEmpSurname";
            this.txtEmpSurname.Size = new System.Drawing.Size(110, 20);
            this.txtEmpSurname.TabIndex = 4;
            this.passTT.SetToolTip(this.txtEmpSurname, "Enter surname of new employee");
            this.txtEmpSurname.TextChanged += new System.EventHandler(this.txtEmpSurname_TextChanged);
            // 
            // txtEmpRSAID
            // 
            this.txtEmpRSAID.Location = new System.Drawing.Point(164, 106);
            this.txtEmpRSAID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmpRSAID.MaxLength = 13;
            this.txtEmpRSAID.Name = "txtEmpRSAID";
            this.txtEmpRSAID.Size = new System.Drawing.Size(110, 20);
            this.txtEmpRSAID.TabIndex = 5;
            this.passTT.SetToolTip(this.txtEmpRSAID, "Enter government issued id nr");
            this.txtEmpRSAID.TextChanged += new System.EventHandler(this.txtEmpRSAID_TextChanged);
            this.txtEmpRSAID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpRSAID_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Surname:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
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
            this.gbEmpDetails.Location = new System.Drawing.Point(12, 10);
            this.gbEmpDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbEmpDetails.Name = "gbEmpDetails";
            this.gbEmpDetails.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbEmpDetails.Size = new System.Drawing.Size(298, 137);
            this.gbEmpDetails.TabIndex = 1;
            this.gbEmpDetails.TabStop = false;
            this.gbEmpDetails.Text = "New employee details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee ID:";
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(164, 28);
            this.txtEmpID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmpID.MaxLength = 10;
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(110, 20);
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
            this.gbContact.Location = new System.Drawing.Point(12, 152);
            this.gbContact.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbContact.Name = "gbContact";
            this.gbContact.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbContact.Size = new System.Drawing.Size(298, 89);
            this.gbContact.TabIndex = 6;
            this.gbContact.TabStop = false;
            this.gbContact.Text = "Contact details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email address:";
            // 
            // txtEmpCell
            // 
            this.txtEmpCell.Location = new System.Drawing.Point(164, 50);
            this.txtEmpCell.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmpCell.MaxLength = 10;
            this.txtEmpCell.Name = "txtEmpCell";
            this.txtEmpCell.Size = new System.Drawing.Size(110, 20);
            this.txtEmpCell.TabIndex = 8;
            this.passTT.SetToolTip(this.txtEmpCell, "Enter cellphone number of new employee");
            this.txtEmpCell.TextChanged += new System.EventHandler(this.txtEmpCell_TextChanged);
            this.txtEmpCell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpCell_KeyPress);
            // 
            // txtEmpEmail
            // 
            this.txtEmpEmail.Location = new System.Drawing.Point(164, 25);
            this.txtEmpEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmpEmail.Name = "txtEmpEmail";
            this.txtEmpEmail.Size = new System.Drawing.Size(110, 20);
            this.txtEmpEmail.TabIndex = 7;
            this.passTT.SetToolTip(this.txtEmpEmail, "Enter email address of new employee");
            this.txtEmpEmail.TextChanged += new System.EventHandler(this.txtEmpEmail_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 53);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
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
            this.gbEmplDetails.Location = new System.Drawing.Point(12, 245);
            this.gbEmplDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbEmplDetails.Name = "gbEmplDetails";
            this.gbEmplDetails.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbEmplDetails.Size = new System.Drawing.Size(298, 191);
            this.gbEmplDetails.TabIndex = 9;
            this.gbEmplDetails.TabStop = false;
            this.gbEmplDetails.Text = "Employment details:";
            // 
            // cbIsUser
            // 
            this.cbIsUser.AutoSize = true;
            this.cbIsUser.Location = new System.Drawing.Point(22, 161);
            this.cbIsUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbIsUser.Name = "cbIsUser";
            this.cbIsUser.Size = new System.Drawing.Size(109, 19);
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
            this.gbEmpType.Location = new System.Drawing.Point(22, 60);
            this.gbEmpType.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbEmpType.Name = "gbEmpType";
            this.gbEmpType.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbEmpType.Size = new System.Drawing.Size(137, 85);
            this.gbEmpType.TabIndex = 11;
            this.gbEmpType.TabStop = false;
            this.gbEmpType.Text = "Type of employee";
            // 
            // rbTemp
            // 
            this.rbTemp.AutoSize = true;
            this.rbTemp.Location = new System.Drawing.Point(4, 61);
            this.rbTemp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbTemp.Name = "rbTemp";
            this.rbTemp.Size = new System.Drawing.Size(148, 19);
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
            this.rbManager.Location = new System.Drawing.Point(4, 17);
            this.rbManager.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbManager.Name = "rbManager";
            this.rbManager.Size = new System.Drawing.Size(78, 19);
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
            this.rbFull.Location = new System.Drawing.Point(4, 39);
            this.rbFull.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rbFull.Name = "rbFull";
            this.rbFull.Size = new System.Drawing.Size(75, 19);
            this.rbFull.TabIndex = 13;
            this.rbFull.TabStop = true;
            this.rbFull.Text = "Full time";
            this.passTT.SetToolTip(this.rbFull, "Select if new employee is a full time employee");
            this.rbFull.UseVisualStyleBackColor = true;
            this.rbFull.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.rbFull_ControlAdded);
            // 
            // lblEndDate
            // 
            this.lblEndDate.Location = new System.Drawing.Point(162, 85);
            this.lblEndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(112, 31);
            this.lblEndDate.TabIndex = 0;
            this.lblEndDate.Text = "End date of employement:";
            this.lblEndDate.Visible = false;
            // 
            // dtEnd
            // 
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEnd.Location = new System.Drawing.Point(162, 122);
            this.dtEnd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(113, 20);
            this.dtEnd.TabIndex = 15;
            this.passTT.SetToolTip(this.dtEnd, "Select the date until which the new temporary\r\nemployee will be working at Matrix" +
        " Warehouse");
            this.dtEnd.Visible = false;
            this.dtEnd.ValueChanged += new System.EventHandler(this.dtEnd_ValueChanged);
            // 
            // dtStart
            // 
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStart.Location = new System.Drawing.Point(164, 28);
            this.dtStart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(110, 20);
            this.dtStart.TabIndex = 10;
            this.passTT.SetToolTip(this.dtStart, "Select the date the new employee will \r\nstart working at Matrix Warehouse");
            this.dtStart.ValueChanged += new System.EventHandler(this.dtStart_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 32);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Start date of employment:";
            // 
            // btnAddEmp
            // 
            this.btnAddEmp.Enabled = false;
            this.btnAddEmp.Location = new System.Drawing.Point(69, 453);
            this.btnAddEmp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddEmp.Name = "btnAddEmp";
            this.btnAddEmp.Size = new System.Drawing.Size(91, 29);
            this.btnAddEmp.TabIndex = 17;
            this.btnAddEmp.Text = "Add employee";
            this.passTT.SetToolTip(this.btnAddEmp, "Click to add new employee");
            this.btnAddEmp.UseVisualStyleBackColor = true;
            this.btnAddEmp.Click += new System.EventHandler(this.btnAddEmp_Click);
            // 
            // btnCancelEmp
            // 
            this.btnCancelEmp.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelEmp.Location = new System.Drawing.Point(176, 453);
            this.btnCancelEmp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancelEmp.Name = "btnCancelEmp";
            this.btnCancelEmp.Size = new System.Drawing.Size(91, 29);
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
            // bgWID
            // 
            this.bgWID.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWID_DoWork);
            this.bgWID.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWID_RunWorkerCompleted);
            // 
            // frmAddEmp
            // 
            this.AcceptButton = this.btnAddEmp;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelEmp;
            this.ClientSize = new System.Drawing.Size(322, 492);
            this.Controls.Add(this.btnCancelEmp);
            this.Controls.Add(this.btnAddEmp);
            this.Controls.Add(this.gbEmplDetails);
            this.Controls.Add(this.gbContact);
            this.Controls.Add(this.gbEmpDetails);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.ComponentModel.BackgroundWorker bgWID;
    }
}