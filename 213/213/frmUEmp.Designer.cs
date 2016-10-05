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
            this.lblOID = new System.Windows.Forms.Label();
            this.lblOriBranch = new System.Windows.Forms.Label();
            this.cbID = new System.Windows.Forms.ComboBox();
            this.cbOID = new System.Windows.Forms.ComboBox();
            this.cbSurID = new System.Windows.Forms.ComboBox();
            this.cbPeriodID = new System.Windows.Forms.ComboBox();
            this.cbCellId = new System.Windows.Forms.ComboBox();
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
            this.cbUEmp.Location = new System.Drawing.Point(228, 20);
            this.cbUEmp.Name = "cbUEmp";
            this.cbUEmp.Size = new System.Drawing.Size(190, 24);
            this.cbUEmp.TabIndex = 1;
            this.cbUEmp.SelectedIndexChanged += new System.EventHandler(this.cbUEmp_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please select an item to update:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(23, 90);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(91, 17);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "Employee ID:";
            // 
            // lblCEmail
            // 
            this.lblCEmail.AutoSize = true;
            this.lblCEmail.Location = new System.Drawing.Point(23, 125);
            this.lblCEmail.Name = "lblCEmail";
            this.lblCEmail.Size = new System.Drawing.Size(151, 17);
            this.lblCEmail.TabIndex = 0;
            this.lblCEmail.Text = "Current email address:";
            // 
            // lblNEmail
            // 
            this.lblNEmail.AutoSize = true;
            this.lblNEmail.Location = new System.Drawing.Point(23, 156);
            this.lblNEmail.Name = "lblNEmail";
            this.lblNEmail.Size = new System.Drawing.Size(131, 17);
            this.lblNEmail.TabIndex = 0;
            this.lblNEmail.Text = "New email address:";
            // 
            // lblCNEmail
            // 
            this.lblCNEmail.AutoSize = true;
            this.lblCNEmail.Location = new System.Drawing.Point(23, 189);
            this.lblCNEmail.Name = "lblCNEmail";
            this.lblCNEmail.Size = new System.Drawing.Size(181, 17);
            this.lblCNEmail.TabIndex = 0;
            this.lblCNEmail.Text = "Confirm new email address:";
            // 
            // txtCEmail
            // 
            this.txtCEmail.Location = new System.Drawing.Point(256, 120);
            this.txtCEmail.Name = "txtCEmail";
            this.txtCEmail.Size = new System.Drawing.Size(162, 22);
            this.txtCEmail.TabIndex = 3;
            this.txtCEmail.TextChanged += new System.EventHandler(this.txtCEmail_TextChanged);
            // 
            // txtNEmail
            // 
            this.txtNEmail.Location = new System.Drawing.Point(256, 153);
            this.txtNEmail.Name = "txtNEmail";
            this.txtNEmail.Size = new System.Drawing.Size(162, 22);
            this.txtNEmail.TabIndex = 4;
            this.txtNEmail.TextChanged += new System.EventHandler(this.txtNEmail_TextChanged);
            // 
            // txtCNEmail
            // 
            this.txtCNEmail.Location = new System.Drawing.Point(256, 186);
            this.txtCNEmail.Name = "txtCNEmail";
            this.txtCNEmail.Size = new System.Drawing.Size(162, 22);
            this.txtCNEmail.TabIndex = 5;
            this.txtCNEmail.TextChanged += new System.EventHandler(this.txtCNEmail_TextChanged);
            // 
            // uEmpCancel
            // 
            this.uEmpCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.uEmpCancel.Location = new System.Drawing.Point(237, 236);
            this.uEmpCancel.Name = "uEmpCancel";
            this.uEmpCancel.Size = new System.Drawing.Size(130, 36);
            this.uEmpCancel.TabIndex = 8;
            this.uEmpCancel.Text = "Cancel";
            this.uEmpCancel.UseVisualStyleBackColor = true;
            // 
            // btnUpdateEmp
            // 
            this.btnUpdateEmp.Enabled = false;
            this.btnUpdateEmp.Location = new System.Drawing.Point(79, 236);
            this.btnUpdateEmp.Name = "btnUpdateEmp";
            this.btnUpdateEmp.Size = new System.Drawing.Size(134, 36);
            this.btnUpdateEmp.TabIndex = 7;
            this.btnUpdateEmp.Text = "Update employee";
            this.btnUpdateEmp.UseVisualStyleBackColor = true;
            this.btnUpdateEmp.Click += new System.EventHandler(this.btnUpdateEmp_Click);
            // 
            // dtUntil
            // 
            this.dtUntil.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtUntil.Location = new System.Drawing.Point(256, 120);
            this.dtUntil.Name = "dtUntil";
            this.dtUntil.Size = new System.Drawing.Size(162, 22);
            this.dtUntil.TabIndex = 3;
            this.dtUntil.ValueChanged += new System.EventHandler(this.dtUntil_ValueChanged);
            // 
            // lblPeriodId
            // 
            this.lblPeriodId.AutoSize = true;
            this.lblPeriodId.Location = new System.Drawing.Point(23, 90);
            this.lblPeriodId.Name = "lblPeriodId";
            this.lblPeriodId.Size = new System.Drawing.Size(91, 17);
            this.lblPeriodId.TabIndex = 0;
            this.lblPeriodId.Text = "Employee ID:";
            // 
            // lblUntil
            // 
            this.lblUntil.AutoSize = true;
            this.lblUntil.Location = new System.Drawing.Point(23, 125);
            this.lblUntil.Name = "lblUntil";
            this.lblUntil.Size = new System.Drawing.Size(104, 17);
            this.lblUntil.TabIndex = 0;
            this.lblUntil.Text = "Employed until:";
            // 
            // txtCCell
            // 
            this.txtCCell.Location = new System.Drawing.Point(256, 120);
            this.txtCCell.MaxLength = 10;
            this.txtCCell.Name = "txtCCell";
            this.txtCCell.Size = new System.Drawing.Size(162, 22);
            this.txtCCell.TabIndex = 3;
            this.txtCCell.TextChanged += new System.EventHandler(this.txtCCell_TextChanged);
            // 
            // txtNCell
            // 
            this.txtNCell.Location = new System.Drawing.Point(256, 153);
            this.txtNCell.MaxLength = 10;
            this.txtNCell.Name = "txtNCell";
            this.txtNCell.Size = new System.Drawing.Size(162, 22);
            this.txtNCell.TabIndex = 4;
            this.txtNCell.TextChanged += new System.EventHandler(this.txtNCell_TextChanged);
            // 
            // txtCNCell
            // 
            this.txtCNCell.Location = new System.Drawing.Point(256, 186);
            this.txtCNCell.MaxLength = 10;
            this.txtCNCell.Name = "txtCNCell";
            this.txtCNCell.Size = new System.Drawing.Size(162, 22);
            this.txtCNCell.TabIndex = 5;
            this.txtCNCell.TextChanged += new System.EventHandler(this.txtCNCell_TextChanged);
            // 
            // lblCellId
            // 
            this.lblCellId.AutoSize = true;
            this.lblCellId.Location = new System.Drawing.Point(23, 90);
            this.lblCellId.Name = "lblCellId";
            this.lblCellId.Size = new System.Drawing.Size(88, 17);
            this.lblCellId.TabIndex = 0;
            this.lblCellId.Text = "Empoyee ID:";
            // 
            // lblCCell
            // 
            this.lblCCell.AutoSize = true;
            this.lblCCell.Location = new System.Drawing.Point(23, 125);
            this.lblCCell.Name = "lblCCell";
            this.lblCCell.Size = new System.Drawing.Size(101, 17);
            this.lblCCell.TabIndex = 0;
            this.lblCCell.Text = "Current cell nr:";
            // 
            // lblNCell
            // 
            this.lblNCell.AutoSize = true;
            this.lblNCell.Location = new System.Drawing.Point(23, 156);
            this.lblNCell.Name = "lblNCell";
            this.lblNCell.Size = new System.Drawing.Size(81, 17);
            this.lblNCell.TabIndex = 0;
            this.lblNCell.Text = "New cell nr:";
            // 
            // lblCNCell
            // 
            this.lblCNCell.AutoSize = true;
            this.lblCNCell.Location = new System.Drawing.Point(23, 189);
            this.lblCNCell.Name = "lblCNCell";
            this.lblCNCell.Size = new System.Drawing.Size(131, 17);
            this.lblCNCell.TabIndex = 0;
            this.lblCNCell.Text = "Confirm new cell nr:";
            // 
            // txtNSur
            // 
            this.txtNSur.Location = new System.Drawing.Point(256, 153);
            this.txtNSur.Name = "txtNSur";
            this.txtNSur.Size = new System.Drawing.Size(162, 22);
            this.txtNSur.TabIndex = 4;
            this.txtNSur.TextChanged += new System.EventHandler(this.txtNSur_TextChanged);
            // 
            // txtCNSur
            // 
            this.txtCNSur.Location = new System.Drawing.Point(256, 186);
            this.txtCNSur.Name = "txtCNSur";
            this.txtCNSur.Size = new System.Drawing.Size(162, 22);
            this.txtCNSur.TabIndex = 5;
            this.txtCNSur.TextChanged += new System.EventHandler(this.txtCNSur_TextChanged);
            // 
            // txtCSur
            // 
            this.txtCSur.Location = new System.Drawing.Point(256, 120);
            this.txtCSur.Name = "txtCSur";
            this.txtCSur.Size = new System.Drawing.Size(162, 22);
            this.txtCSur.TabIndex = 3;
            this.txtCSur.TextChanged += new System.EventHandler(this.txtCSur_TextChanged);
            // 
            // lblCNSur
            // 
            this.lblCNSur.AutoSize = true;
            this.lblCNSur.Location = new System.Drawing.Point(23, 189);
            this.lblCNSur.Name = "lblCNSur";
            this.lblCNSur.Size = new System.Drawing.Size(148, 17);
            this.lblCNSur.TabIndex = 0;
            this.lblCNSur.Text = "Confirm new surname:";
            // 
            // lblNSur
            // 
            this.lblNSur.AutoSize = true;
            this.lblNSur.Location = new System.Drawing.Point(23, 156);
            this.lblNSur.Name = "lblNSur";
            this.lblNSur.Size = new System.Drawing.Size(98, 17);
            this.lblNSur.TabIndex = 0;
            this.lblNSur.Text = "New surname:";
            // 
            // lblCSur
            // 
            this.lblCSur.AutoSize = true;
            this.lblCSur.Location = new System.Drawing.Point(23, 125);
            this.lblCSur.Name = "lblCSur";
            this.lblCSur.Size = new System.Drawing.Size(118, 17);
            this.lblCSur.TabIndex = 0;
            this.lblCSur.Text = "Current surname:";
            // 
            // lblSID
            // 
            this.lblSID.AutoSize = true;
            this.lblSID.Location = new System.Drawing.Point(23, 90);
            this.lblSID.Name = "lblSID";
            this.lblSID.Size = new System.Drawing.Size(91, 17);
            this.lblSID.TabIndex = 0;
            this.lblSID.Text = "Employee ID:";
            // 
            // cbUser
            // 
            this.cbUser.AutoSize = true;
            this.cbUser.Location = new System.Drawing.Point(79, 189);
            this.cbUser.Name = "cbUser";
            this.cbUser.Size = new System.Drawing.Size(125, 21);
            this.cbUser.TabIndex = 5;
            this.cbUser.Text = "Is stockI.T user";
            this.cbUser.UseVisualStyleBackColor = true;
            // 
            // cbBranches
            // 
            this.cbBranches.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbBranches.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbBranches.FormattingEnabled = true;
            this.cbBranches.Items.AddRange(new object[] {
            "I don\'t want to move the employee"});
            this.cbBranches.Location = new System.Drawing.Point(256, 153);
            this.cbBranches.Name = "cbBranches";
            this.cbBranches.Size = new System.Drawing.Size(162, 24);
            this.cbBranches.Sorted = true;
            this.cbBranches.TabIndex = 4;
            this.TT.SetToolTip(this.cbBranches, "Please leave this field empty if you do not \r\nwish to move this employee to anoth" +
        "er branch.");
            // 
            // cbTemp
            // 
            this.cbTemp.AutoSize = true;
            this.cbTemp.Location = new System.Drawing.Point(237, 189);
            this.cbTemp.Name = "cbTemp";
            this.cbTemp.Size = new System.Drawing.Size(173, 21);
            this.cbTemp.TabIndex = 6;
            this.cbTemp.Text = "Is temporary employee";
            this.cbTemp.UseVisualStyleBackColor = true;
            // 
            // lblBranches
            // 
            this.lblBranches.AutoSize = true;
            this.lblBranches.Location = new System.Drawing.Point(23, 156);
            this.lblBranches.Name = "lblBranches";
            this.lblBranches.Size = new System.Drawing.Size(131, 17);
            this.lblBranches.TabIndex = 15;
            this.lblBranches.Text = "Destination branch:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(387, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "*Please be sure to fill all fields as appropriate per employee*";
            // 
            // TT
            // 
            this.TT.AutoPopDelay = 5000;
            this.TT.InitialDelay = 100;
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
            this.cbOriBranch.Location = new System.Drawing.Point(256, 120);
            this.cbOriBranch.Name = "cbOriBranch";
            this.cbOriBranch.Size = new System.Drawing.Size(162, 24);
            this.cbOriBranch.Sorted = true;
            this.cbOriBranch.TabIndex = 3;
            this.TT.SetToolTip(this.cbOriBranch, "If this field is disabled, you do not have permission to move employees from othe" +
        "r branches.");
            // 
            // lblOID
            // 
            this.lblOID.AutoSize = true;
            this.lblOID.Location = new System.Drawing.Point(23, 90);
            this.lblOID.Name = "lblOID";
            this.lblOID.Size = new System.Drawing.Size(91, 17);
            this.lblOID.TabIndex = 18;
            this.lblOID.Text = "Employee ID:";
            // 
            // lblOriBranch
            // 
            this.lblOriBranch.AutoSize = true;
            this.lblOriBranch.Location = new System.Drawing.Point(23, 125);
            this.lblOriBranch.Name = "lblOriBranch";
            this.lblOriBranch.Size = new System.Drawing.Size(126, 17);
            this.lblOriBranch.TabIndex = 20;
            this.lblOriBranch.Text = "Move from branch:";
            // 
            // cbID
            // 
            this.cbID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbID.FormattingEnabled = true;
            this.cbID.Location = new System.Drawing.Point(256, 87);
            this.cbID.Name = "cbID";
            this.cbID.Size = new System.Drawing.Size(162, 24);
            this.cbID.Sorted = true;
            this.cbID.TabIndex = 2;
            this.cbID.SelectedIndexChanged += new System.EventHandler(this.cbID_SelectedIndexChanged);
            // 
            // cbOID
            // 
            this.cbOID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbOID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbOID.FormattingEnabled = true;
            this.cbOID.Location = new System.Drawing.Point(256, 87);
            this.cbOID.Name = "cbOID";
            this.cbOID.Size = new System.Drawing.Size(162, 24);
            this.cbOID.Sorted = true;
            this.cbOID.TabIndex = 2;
            this.cbOID.SelectedIndexChanged += new System.EventHandler(this.cbOID_SelectedIndexChanged);
            // 
            // cbSurID
            // 
            this.cbSurID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSurID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSurID.FormattingEnabled = true;
            this.cbSurID.Location = new System.Drawing.Point(256, 87);
            this.cbSurID.Name = "cbSurID";
            this.cbSurID.Size = new System.Drawing.Size(162, 24);
            this.cbSurID.Sorted = true;
            this.cbSurID.TabIndex = 2;
            this.cbSurID.SelectedIndexChanged += new System.EventHandler(this.cbSurID_SelectedIndexChanged);
            // 
            // cbPeriodID
            // 
            this.cbPeriodID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPeriodID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbPeriodID.FormattingEnabled = true;
            this.cbPeriodID.Location = new System.Drawing.Point(256, 87);
            this.cbPeriodID.Name = "cbPeriodID";
            this.cbPeriodID.Size = new System.Drawing.Size(162, 24);
            this.cbPeriodID.Sorted = true;
            this.cbPeriodID.TabIndex = 2;
            this.cbPeriodID.SelectedIndexChanged += new System.EventHandler(this.cbPeriodID_SelectedIndexChanged);
            // 
            // cbCellId
            // 
            this.cbCellId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbCellId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbCellId.FormattingEnabled = true;
            this.cbCellId.Location = new System.Drawing.Point(256, 87);
            this.cbCellId.Name = "cbCellId";
            this.cbCellId.Size = new System.Drawing.Size(162, 24);
            this.cbCellId.Sorted = true;
            this.cbCellId.TabIndex = 2;
            this.cbCellId.SelectedIndexChanged += new System.EventHandler(this.cbCellId_SelectedIndexChanged);
            // 
            // frmUEmp
            // 
            this.AcceptButton = this.btnUpdateEmp;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.uEmpCancel;
            this.ClientSize = new System.Drawing.Size(455, 291);
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
    }
}