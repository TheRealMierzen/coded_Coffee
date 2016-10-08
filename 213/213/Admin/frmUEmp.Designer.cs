namespace _213
{
    partial class frmUEmp
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
            this.cbUEmp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblCEmail = new System.Windows.Forms.Label();
            this.lblNEmail = new System.Windows.Forms.Label();
            this.lblCNEmail = new System.Windows.Forms.Label();
            this.txtCEmail = new System.Windows.Forms.TextBox();
            this.txtNEmail = new System.Windows.Forms.TextBox();
            this.txtCNEmail = new System.Windows.Forms.TextBox();
            this.uEmpCancel = new System.Windows.Forms.Button();
            this.btnUpdateEmp = new System.Windows.Forms.Button();
            this.dtUntil = new System.Windows.Forms.DateTimePicker();
            this.lblPeriodId = new System.Windows.Forms.Label();
            this.lblUntil = new System.Windows.Forms.Label();
            this.txtCCell = new System.Windows.Forms.TextBox();
            this.txtNCell = new System.Windows.Forms.TextBox();
            this.txtCNCell = new System.Windows.Forms.TextBox();
            this.lblCellId = new System.Windows.Forms.Label();
            this.lblCCell = new System.Windows.Forms.Label();
            this.lblNCell = new System.Windows.Forms.Label();
            this.lblCNCell = new System.Windows.Forms.Label();
            this.txtNSur = new System.Windows.Forms.TextBox();
            this.txtCNSur = new System.Windows.Forms.TextBox();
            this.txtCSur = new System.Windows.Forms.TextBox();
            this.lblCNSur = new System.Windows.Forms.Label();
            this.lblNSur = new System.Windows.Forms.Label();
            this.lblCSur = new System.Windows.Forms.Label();
            this.lblSID = new System.Windows.Forms.Label();
            this.cbUser = new System.Windows.Forms.CheckBox();
            this.cbBranches = new System.Windows.Forms.ComboBox();
            this.cbTemp = new System.Windows.Forms.CheckBox();
            this.lblBranches = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TT = new System.Windows.Forms.ToolTip(this.components);
            this.cbOriBranch = new System.Windows.Forms.ComboBox();
            this.cbID = new System.Windows.Forms.ComboBox();
            this.cbOID = new System.Windows.Forms.ComboBox();
            this.cbSurID = new System.Windows.Forms.ComboBox();
            this.cbPeriodID = new System.Windows.Forms.ComboBox();
            this.cbCellId = new System.Windows.Forms.ComboBox();
            this.lblOID = new System.Windows.Forms.Label();
            this.lblOriBranch = new System.Windows.Forms.Label();
            this.bgWUE = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // cbUEmp
            // 
            this.cbUEmp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbUEmp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbUEmp.FormattingEnabled = true;
            this.cbUEmp.Items.AddRange(new object[] {
            "Email address",
            "Extend/shorten employment",
            "Cellphone nr",
            "Surname",
            "Other"});
            this.cbUEmp.Location = new System.Drawing.Point(171, 16);
            this.cbUEmp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbUEmp.Name = "cbUEmp";
            this.cbUEmp.Size = new System.Drawing.Size(144, 21);
            this.cbUEmp.TabIndex = 1;
            this.TT.SetToolTip(this.cbUEmp, "Select information you wish to update");
            this.cbUEmp.SelectedIndexChanged += new System.EventHandler(this.cbUEmp_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please select an item to update:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(17, 73);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(80, 15);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Employee ID:";
            // 
            // lblCEmail
            // 
            this.lblCEmail.AutoSize = true;
            this.lblCEmail.Location = new System.Drawing.Point(17, 102);
            this.lblCEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCEmail.Name = "lblCEmail";
            this.lblCEmail.Size = new System.Drawing.Size(131, 15);
            this.lblCEmail.TabIndex = 0;
            this.lblCEmail.Text = "Current email address:";
            // 
            // lblNEmail
            // 
            this.lblNEmail.AutoSize = true;
            this.lblNEmail.Location = new System.Drawing.Point(17, 127);
            this.lblNEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNEmail.Name = "lblNEmail";
            this.lblNEmail.Size = new System.Drawing.Size(116, 15);
            this.lblNEmail.TabIndex = 0;
            this.lblNEmail.Text = "New email address:";
            // 
            // lblCNEmail
            // 
            this.lblCNEmail.AutoSize = true;
            this.lblCNEmail.Location = new System.Drawing.Point(17, 154);
            this.lblCNEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCNEmail.Name = "lblCNEmail";
            this.lblCNEmail.Size = new System.Drawing.Size(160, 15);
            this.lblCNEmail.TabIndex = 0;
            this.lblCNEmail.Text = "Confirm new email address:";
            // 
            // txtCEmail
            // 
            this.txtCEmail.Location = new System.Drawing.Point(192, 98);
            this.txtCEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCEmail.Name = "txtCEmail";
            this.txtCEmail.Size = new System.Drawing.Size(122, 20);
            this.txtCEmail.TabIndex = 3;
            this.TT.SetToolTip(this.txtCEmail, "Enter current email address of employee \r\nyou wish to update");
            this.txtCEmail.TextChanged += new System.EventHandler(this.txtCEmail_TextChanged);
            // 
            // txtNEmail
            // 
            this.txtNEmail.Location = new System.Drawing.Point(192, 124);
            this.txtNEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNEmail.Name = "txtNEmail";
            this.txtNEmail.Size = new System.Drawing.Size(122, 20);
            this.txtNEmail.TabIndex = 4;
            this.TT.SetToolTip(this.txtNEmail, "Enter the new email address of the mployee");
            this.txtNEmail.TextChanged += new System.EventHandler(this.txtNEmail_TextChanged);
            // 
            // txtCNEmail
            // 
            this.txtCNEmail.Location = new System.Drawing.Point(192, 151);
            this.txtCNEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCNEmail.Name = "txtCNEmail";
            this.txtCNEmail.Size = new System.Drawing.Size(122, 20);
            this.txtCNEmail.TabIndex = 5;
            this.TT.SetToolTip(this.txtCNEmail, "Confirm new email address of employee");
            this.txtCNEmail.TextChanged += new System.EventHandler(this.txtCNEmail_TextChanged);
            // 
            // uEmpCancel
            // 
            this.uEmpCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.uEmpCancel.Location = new System.Drawing.Point(178, 192);
            this.uEmpCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.uEmpCancel.Name = "uEmpCancel";
            this.uEmpCancel.Size = new System.Drawing.Size(98, 29);
            this.uEmpCancel.TabIndex = 8;
            this.uEmpCancel.Text = "Cancel";
            this.TT.SetToolTip(this.uEmpCancel, "Click to close this window");
            this.uEmpCancel.UseVisualStyleBackColor = true;
            // 
            // btnUpdateEmp
            // 
            this.btnUpdateEmp.Enabled = false;
            this.btnUpdateEmp.Location = new System.Drawing.Point(59, 192);
            this.btnUpdateEmp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdateEmp.Name = "btnUpdateEmp";
            this.btnUpdateEmp.Size = new System.Drawing.Size(100, 29);
            this.btnUpdateEmp.TabIndex = 7;
            this.btnUpdateEmp.Text = "Update employee";
            this.TT.SetToolTip(this.btnUpdateEmp, "Click to update employee\'s information");
            this.btnUpdateEmp.UseVisualStyleBackColor = true;
            this.btnUpdateEmp.Click += new System.EventHandler(this.btnUpdateEmp_Click);
            // 
            // dtUntil
            // 
            this.dtUntil.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtUntil.Location = new System.Drawing.Point(192, 98);
            this.dtUntil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtUntil.Name = "dtUntil";
            this.dtUntil.Size = new System.Drawing.Size(122, 20);
            this.dtUntil.TabIndex = 3;
            this.TT.SetToolTip(this.dtUntil, "Select the new date until which this employee will be \r\nemployed");
            this.dtUntil.ValueChanged += new System.EventHandler(this.dtUntil_ValueChanged);
            // 
            // lblPeriodId
            // 
            this.lblPeriodId.AutoSize = true;
            this.lblPeriodId.Location = new System.Drawing.Point(17, 73);
            this.lblPeriodId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPeriodId.Name = "lblPeriodId";
            this.lblPeriodId.Size = new System.Drawing.Size(80, 15);
            this.lblPeriodId.TabIndex = 0;
            this.lblPeriodId.Text = "Employee ID:";
            // 
            // lblUntil
            // 
            this.lblUntil.AutoSize = true;
            this.lblUntil.Location = new System.Drawing.Point(17, 102);
            this.lblUntil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUntil.Name = "lblUntil";
            this.lblUntil.Size = new System.Drawing.Size(91, 15);
            this.lblUntil.TabIndex = 0;
            this.lblUntil.Text = "Employed until:";
            // 
            // txtCCell
            // 
            this.txtCCell.Location = new System.Drawing.Point(192, 98);
            this.txtCCell.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCCell.MaxLength = 10;
            this.txtCCell.Name = "txtCCell";
            this.txtCCell.Size = new System.Drawing.Size(122, 20);
            this.txtCCell.TabIndex = 3;
            this.TT.SetToolTip(this.txtCCell, "Enter current cellphone number of employee \r\nyou wish to update");
            this.txtCCell.TextChanged += new System.EventHandler(this.txtCCell_TextChanged);
            this.txtCCell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCCell_KeyPress);
            // 
            // txtNCell
            // 
            this.txtNCell.Location = new System.Drawing.Point(192, 124);
            this.txtNCell.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNCell.MaxLength = 10;
            this.txtNCell.Name = "txtNCell";
            this.txtNCell.Size = new System.Drawing.Size(122, 20);
            this.txtNCell.TabIndex = 4;
            this.TT.SetToolTip(this.txtNCell, "Enter new cellphone number of employee");
            this.txtNCell.TextChanged += new System.EventHandler(this.txtNCell_TextChanged);
            this.txtNCell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNCell_KeyPress);
            // 
            // txtCNCell
            // 
            this.txtCNCell.Location = new System.Drawing.Point(192, 151);
            this.txtCNCell.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCNCell.MaxLength = 10;
            this.txtCNCell.Name = "txtCNCell";
            this.txtCNCell.Size = new System.Drawing.Size(122, 20);
            this.txtCNCell.TabIndex = 5;
            this.TT.SetToolTip(this.txtCNCell, "Confirm new cellphone number of employee");
            this.txtCNCell.TextChanged += new System.EventHandler(this.txtCNCell_TextChanged);
            this.txtCNCell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCNCell_KeyPress);
            // 
            // lblCellId
            // 
            this.lblCellId.AutoSize = true;
            this.lblCellId.Location = new System.Drawing.Point(17, 73);
            this.lblCellId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCellId.Name = "lblCellId";
            this.lblCellId.Size = new System.Drawing.Size(77, 15);
            this.lblCellId.TabIndex = 0;
            this.lblCellId.Text = "Empoyee ID:";
            // 
            // lblCCell
            // 
            this.lblCCell.AutoSize = true;
            this.lblCCell.Location = new System.Drawing.Point(17, 102);
            this.lblCCell.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCCell.Name = "lblCCell";
            this.lblCCell.Size = new System.Drawing.Size(86, 15);
            this.lblCCell.TabIndex = 0;
            this.lblCCell.Text = "Current cell nr:";
            // 
            // lblNCell
            // 
            this.lblNCell.AutoSize = true;
            this.lblNCell.Location = new System.Drawing.Point(17, 127);
            this.lblNCell.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNCell.Name = "lblNCell";
            this.lblNCell.Size = new System.Drawing.Size(71, 15);
            this.lblNCell.TabIndex = 0;
            this.lblNCell.Text = "New cell nr:";
            // 
            // lblCNCell
            // 
            this.lblCNCell.AutoSize = true;
            this.lblCNCell.Location = new System.Drawing.Point(17, 154);
            this.lblCNCell.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCNCell.Name = "lblCNCell";
            this.lblCNCell.Size = new System.Drawing.Size(115, 15);
            this.lblCNCell.TabIndex = 0;
            this.lblCNCell.Text = "Confirm new cell nr:";
            // 
            // txtNSur
            // 
            this.txtNSur.Location = new System.Drawing.Point(192, 124);
            this.txtNSur.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNSur.Name = "txtNSur";
            this.txtNSur.Size = new System.Drawing.Size(122, 20);
            this.txtNSur.TabIndex = 4;
            this.TT.SetToolTip(this.txtNSur, "Enter new surname of employee");
            this.txtNSur.TextChanged += new System.EventHandler(this.txtNSur_TextChanged);
            // 
            // txtCNSur
            // 
            this.txtCNSur.Location = new System.Drawing.Point(192, 151);
            this.txtCNSur.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCNSur.Name = "txtCNSur";
            this.txtCNSur.Size = new System.Drawing.Size(122, 20);
            this.txtCNSur.TabIndex = 5;
            this.TT.SetToolTip(this.txtCNSur, "Confirm new surname of employee");
            this.txtCNSur.TextChanged += new System.EventHandler(this.txtCNSur_TextChanged);
            // 
            // txtCSur
            // 
            this.txtCSur.Location = new System.Drawing.Point(192, 98);
            this.txtCSur.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCSur.Name = "txtCSur";
            this.txtCSur.Size = new System.Drawing.Size(122, 20);
            this.txtCSur.TabIndex = 3;
            this.TT.SetToolTip(this.txtCSur, "Enter current surname of employee you wish to update");
            this.txtCSur.TextChanged += new System.EventHandler(this.txtCSur_TextChanged);
            // 
            // lblCNSur
            // 
            this.lblCNSur.AutoSize = true;
            this.lblCNSur.Location = new System.Drawing.Point(17, 154);
            this.lblCNSur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCNSur.Name = "lblCNSur";
            this.lblCNSur.Size = new System.Drawing.Size(131, 15);
            this.lblCNSur.TabIndex = 0;
            this.lblCNSur.Text = "Confirm new surname:";
            // 
            // lblNSur
            // 
            this.lblNSur.AutoSize = true;
            this.lblNSur.Location = new System.Drawing.Point(17, 127);
            this.lblNSur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNSur.Name = "lblNSur";
            this.lblNSur.Size = new System.Drawing.Size(87, 15);
            this.lblNSur.TabIndex = 0;
            this.lblNSur.Text = "New surname:";
            // 
            // lblCSur
            // 
            this.lblCSur.AutoSize = true;
            this.lblCSur.Location = new System.Drawing.Point(17, 102);
            this.lblCSur.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCSur.Name = "lblCSur";
            this.lblCSur.Size = new System.Drawing.Size(102, 15);
            this.lblCSur.TabIndex = 0;
            this.lblCSur.Text = "Current surname:";
            // 
            // lblSID
            // 
            this.lblSID.AutoSize = true;
            this.lblSID.Location = new System.Drawing.Point(17, 73);
            this.lblSID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSID.Name = "lblSID";
            this.lblSID.Size = new System.Drawing.Size(80, 15);
            this.lblSID.TabIndex = 0;
            this.lblSID.Text = "Employee ID:";
            // 
            // cbUser
            // 
            this.cbUser.AutoSize = true;
            this.cbUser.Location = new System.Drawing.Point(59, 154);
            this.cbUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(109, 19);
            this.cbUser.TabIndex = 5;
            this.cbUser.Text = "Is stockI.T user";
            this.TT.SetToolTip(this.cbUser, "Check if employee will be using stockI.T after this update");
            this.cbUser.UseVisualStyleBackColor = true;
            // 
            // cbBranches
            // 
            this.cbBranches.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBranches.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBranches.FormattingEnabled = true;
            this.cbBranches.Items.AddRange(new object[] {
            "I don\'t want to move the employee"});
            this.cbBranches.Location = new System.Drawing.Point(192, 124);
            this.cbBranches.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbBranches.Name = "cbBranches";
            this.cbBranches.Size = new System.Drawing.Size(122, 21);
            this.cbBranches.Sorted = true;
            this.cbBranches.TabIndex = 4;
            this.TT.SetToolTip(this.cbBranches, "Select the branch you wish to move this employee to\r\n\r\n*Please leave this field e" +
        "mpty if you do not wish to \r\nmove this employee to another branch.");
            // 
            // cbTemp
            // 
            this.cbTemp.AutoSize = true;
            this.cbTemp.Location = new System.Drawing.Point(178, 154);
            this.cbTemp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTemp.Name = "cbTemp";
            this.cbTemp.Size = new System.Drawing.Size(153, 19);
            this.cbTemp.TabIndex = 6;
            this.cbTemp.Text = "Is temporary employee";
            this.TT.SetToolTip(this.cbTemp, "Check if employee should be a temprary employee \r\nafter this update");
            this.cbTemp.UseVisualStyleBackColor = true;
            // 
            // lblBranches
            // 
            this.lblBranches.AutoSize = true;
            this.lblBranches.Location = new System.Drawing.Point(17, 127);
            this.lblBranches.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBranches.Name = "lblBranches";
            this.lblBranches.Size = new System.Drawing.Size(113, 15);
            this.lblBranches.TabIndex = 15;
            this.lblBranches.Text = "Destination branch:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(335, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "*Please be sure to fill all fields as appropriate per employee*";
            // 
            // TT
            // 
            this.TT.AutoPopDelay = 5000;
            this.TT.InitialDelay = 750;
            this.TT.IsBalloon = true;
            this.TT.ReshowDelay = 100;
            this.TT.Tag = "";
            this.TT.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.TT.ToolTipTitle = "Need help?";
            // 
            // cbOriBranch
            // 
            this.cbOriBranch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbOriBranch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbOriBranch.FormattingEnabled = true;
            this.cbOriBranch.Location = new System.Drawing.Point(192, 98);
            this.cbOriBranch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbOriBranch.Name = "cbOriBranch";
            this.cbOriBranch.Size = new System.Drawing.Size(122, 21);
            this.cbOriBranch.Sorted = true;
            this.cbOriBranch.TabIndex = 3;
            this.TT.SetToolTip(this.cbOriBranch, "Select the branch you wish to transfer employee from\r\n\r\n*If this field is disable" +
        "d, you do not have permission to \r\nmove employees from other branches.");
            // 
            // cbID
            // 
            this.cbID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbID.FormattingEnabled = true;
            this.cbID.Location = new System.Drawing.Point(192, 71);
            this.cbID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbID.Name = "cbID";
            this.cbID.Size = new System.Drawing.Size(122, 21);
            this.cbID.Sorted = true;
            this.cbID.TabIndex = 2;
            this.TT.SetToolTip(this.cbID, "Select employee id of employee you wish to update");
            this.cbID.SelectedIndexChanged += new System.EventHandler(this.cbID_SelectedIndexChanged);
            // 
            // cbOID
            // 
            this.cbOID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbOID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbOID.FormattingEnabled = true;
            this.cbOID.Location = new System.Drawing.Point(192, 71);
            this.cbOID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbOID.Name = "cbOID";
            this.cbOID.Size = new System.Drawing.Size(122, 21);
            this.cbOID.Sorted = true;
            this.cbOID.TabIndex = 2;
            this.TT.SetToolTip(this.cbOID, "Select employee id of employee you wish to update");
            this.cbOID.SelectedIndexChanged += new System.EventHandler(this.cbOID_SelectedIndexChanged);
            // 
            // cbSurID
            // 
            this.cbSurID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSurID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSurID.FormattingEnabled = true;
            this.cbSurID.Location = new System.Drawing.Point(192, 71);
            this.cbSurID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbSurID.Name = "cbSurID";
            this.cbSurID.Size = new System.Drawing.Size(122, 21);
            this.cbSurID.Sorted = true;
            this.cbSurID.TabIndex = 2;
            this.TT.SetToolTip(this.cbSurID, "Select employee id of employee you wish to update");
            this.cbSurID.SelectedIndexChanged += new System.EventHandler(this.cbSurID_SelectedIndexChanged);
            // 
            // cbPeriodID
            // 
            this.cbPeriodID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPeriodID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPeriodID.FormattingEnabled = true;
            this.cbPeriodID.Location = new System.Drawing.Point(192, 71);
            this.cbPeriodID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbPeriodID.Name = "cbPeriodID";
            this.cbPeriodID.Size = new System.Drawing.Size(122, 21);
            this.cbPeriodID.Sorted = true;
            this.cbPeriodID.TabIndex = 2;
            this.TT.SetToolTip(this.cbPeriodID, "Select employee id of employee you wish to update");
            this.cbPeriodID.SelectedIndexChanged += new System.EventHandler(this.cbPeriodID_SelectedIndexChanged);
            // 
            // cbCellId
            // 
            this.cbCellId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCellId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCellId.FormattingEnabled = true;
            this.cbCellId.Location = new System.Drawing.Point(192, 71);
            this.cbCellId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbCellId.Name = "cbCellId";
            this.cbCellId.Size = new System.Drawing.Size(122, 21);
            this.cbCellId.Sorted = true;
            this.cbCellId.TabIndex = 2;
            this.TT.SetToolTip(this.cbCellId, "Select employee id of employee you wish to update");
            this.cbCellId.SelectedIndexChanged += new System.EventHandler(this.cbCellId_SelectedIndexChanged);
            // 
            // lblOID
            // 
            this.lblOID.AutoSize = true;
            this.lblOID.Location = new System.Drawing.Point(17, 73);
            this.lblOID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOID.Name = "lblOID";
            this.lblOID.Size = new System.Drawing.Size(80, 15);
            this.lblOID.TabIndex = 18;
            this.lblOID.Text = "Employee ID:";
            // 
            // lblOriBranch
            // 
            this.lblOriBranch.AutoSize = true;
            this.lblOriBranch.Location = new System.Drawing.Point(17, 102);
            this.lblOriBranch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOriBranch.Name = "lblOriBranch";
            this.lblOriBranch.Size = new System.Drawing.Size(109, 15);
            this.lblOriBranch.TabIndex = 20;
            this.lblOriBranch.Text = "Move from branch:";
            // 
            // frmUEmp
            // 
            this.AcceptButton = this.btnUpdateEmp;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.uEmpCancel;
            this.ClientSize = new System.Drawing.Size(331, 236);
            this.Controls.Add(this.cbCellId);
            this.Controls.Add(this.cbPeriodID);
            this.Controls.Add(this.cbSurID);
            this.Controls.Add(this.cbOID);
            this.Controls.Add(this.cbID);
            this.Controls.Add(this.lblOriBranch);
            this.Controls.Add(this.cbOriBranch);
            this.Controls.Add(this.lblOID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBranches);
            this.Controls.Add(this.cbTemp);
            this.Controls.Add(this.cbBranches);
            this.Controls.Add(this.cbUser);
            this.Controls.Add(this.lblSID);
            this.Controls.Add(this.lblCSur);
            this.Controls.Add(this.lblNSur);
            this.Controls.Add(this.lblCNSur);
            this.Controls.Add(this.txtCSur);
            this.Controls.Add(this.txtCNSur);
            this.Controls.Add(this.txtNSur);
            this.Controls.Add(this.lblCNCell);
            this.Controls.Add(this.lblNCell);
            this.Controls.Add(this.lblCCell);
            this.Controls.Add(this.lblCellId);
            this.Controls.Add(this.txtCNCell);
            this.Controls.Add(this.txtNCell);
            this.Controls.Add(this.txtCCell);
            this.Controls.Add(this.lblUntil);
            this.Controls.Add(this.lblPeriodId);
            this.Controls.Add(this.dtUntil);
            this.Controls.Add(this.uEmpCancel);
            this.Controls.Add(this.btnUpdateEmp);
            this.Controls.Add(this.txtCNEmail);
            this.Controls.Add(this.txtNEmail);
            this.Controls.Add(this.txtCEmail);
            this.Controls.Add(this.lblCNEmail);
            this.Controls.Add(this.lblNEmail);
            this.Controls.Add(this.lblCEmail);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbUEmp);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmUEmp";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Employee";
            this.Load += new System.EventHandler(this.frmUEmp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbUEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCNEmail;
        private System.Windows.Forms.TextBox txtNEmail;
        private System.Windows.Forms.TextBox txtCEmail;
        private System.Windows.Forms.Label lblCNEmail;
        private System.Windows.Forms.Label lblNEmail;
        private System.Windows.Forms.Label lblCEmail;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button uEmpCancel;
        private System.Windows.Forms.Button btnUpdateEmp;
        private System.Windows.Forms.Label lblUntil;
        private System.Windows.Forms.Label lblPeriodId;
        private System.Windows.Forms.DateTimePicker dtUntil;
        private System.Windows.Forms.TextBox txtCCell;
        private System.Windows.Forms.TextBox txtNCell;
        private System.Windows.Forms.TextBox txtCNCell;
        private System.Windows.Forms.Label lblCellId;
        private System.Windows.Forms.Label lblCCell;
        private System.Windows.Forms.Label lblNCell;
        private System.Windows.Forms.Label lblCNCell;
        private System.Windows.Forms.TextBox txtNSur;
        private System.Windows.Forms.TextBox txtCNSur;
        private System.Windows.Forms.TextBox txtCSur;
        private System.Windows.Forms.Label lblCNSur;
        private System.Windows.Forms.Label lblNSur;
        private System.Windows.Forms.Label lblCSur;
        private System.Windows.Forms.Label lblSID;
        private System.Windows.Forms.CheckBox cbUser;
        private System.Windows.Forms.ComboBox cbBranches;
        private System.Windows.Forms.CheckBox cbTemp;
        private System.Windows.Forms.Label lblBranches;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip TT;
        private System.Windows.Forms.Label lblOID;
        private System.Windows.Forms.ComboBox cbOriBranch;
        private System.Windows.Forms.Label lblOriBranch;
        private System.Windows.Forms.ComboBox cbID;
        private System.Windows.Forms.ComboBox cbSurID;
        private System.Windows.Forms.ComboBox cbPeriodID;
        private System.Windows.Forms.ComboBox cbCellId;
        private System.Windows.Forms.ComboBox cbOID;
        private System.ComponentModel.BackgroundWorker bgWUE;
    }
}