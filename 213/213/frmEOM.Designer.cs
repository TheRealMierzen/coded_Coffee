namespace _213
{
    partial class frmEOM
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
            this.dgEOM = new System.Windows.Forms.DataGridView();
            this.lblFor = new System.Windows.Forms.Label();
            this.lblCEOM = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgEOM)).BeginInit();
            this.SuspendLayout();
            // 
            // dgEOM
            // 
            this.dgEOM.AllowUserToAddRows = false;
            this.dgEOM.AllowUserToDeleteRows = false;
            this.dgEOM.AllowUserToOrderColumns = true;
            this.dgEOM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEOM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.surname});
            this.dgEOM.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgEOM.Location = new System.Drawing.Point(12, 96);
            this.dgEOM.Name = "dgEOM";
            this.dgEOM.ReadOnly = true;
            this.dgEOM.RowTemplate.Height = 24;
            this.dgEOM.Size = new System.Drawing.Size(377, 251);
            this.dgEOM.TabIndex = 0;
            // 
            // lblFor
            // 
            this.lblFor.AutoSize = true;
            this.lblFor.Location = new System.Drawing.Point(12, 73);
            this.lblFor.Name = "lblFor";
            this.lblFor.Size = new System.Drawing.Size(179, 17);
            this.lblFor.TabIndex = 1;
            this.lblFor.Text = "Employee performance for:";
            // 
            // lblCEOM
            // 
            this.lblCEOM.AutoSize = true;
            this.lblCEOM.Location = new System.Drawing.Point(13, 23);
            this.lblCEOM.Name = "lblCEOM";
            this.lblCEOM.Size = new System.Drawing.Size(90, 17);
            this.lblCEOM.TabIndex = 2;
            this.lblCEOM.Text = "Current EOM";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(133, 360);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(124, 39);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 115;
            // 
            // surname
            // 
            this.surname.HeaderText = "Surname";
            this.surname.Name = "surname";
            this.surname.ReadOnly = true;
            this.surname.Width = 115;
            // 
            // frmEOM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 411);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblCEOM);
            this.Controls.Add(this.lblFor);
            this.Controls.Add(this.dgEOM);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmEOM";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee of the month";
            this.Load += new System.EventHandler(this.frmEOM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgEOM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgEOM;
        private System.Windows.Forms.Label lblFor;
        private System.Windows.Forms.Label lblCEOM;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
    }
}