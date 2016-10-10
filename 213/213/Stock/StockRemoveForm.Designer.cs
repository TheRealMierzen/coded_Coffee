namespace _213
{
    partial class StockRemoveForm
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
            this.btnCancelFind = new System.Windows.Forms.Button();
            this.btnConfirmFind = new System.Windows.Forms.Button();
            this.lblFindName = new System.Windows.Forms.Label();
            this.txtDeleteID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbDisposal = new System.Windows.Forms.RadioButton();
            this.gbReasonsDelete = new System.Windows.Forms.GroupBox();
            this.rbFaulty = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.gbReasonsDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelFind
            // 
            this.btnCancelFind.Location = new System.Drawing.Point(170, 108);
            this.btnCancelFind.Name = "btnCancelFind";
            this.btnCancelFind.Size = new System.Drawing.Size(83, 23);
            this.btnCancelFind.TabIndex = 12;
            this.btnCancelFind.Text = "Back";
            this.toolTip1.SetToolTip(this.btnCancelFind, "Click to close this window");
            this.btnCancelFind.UseVisualStyleBackColor = true;
            this.btnCancelFind.Click += new System.EventHandler(this.btnCancelFind_Click);
            // 
            // btnConfirmFind
            // 
            this.btnConfirmFind.Location = new System.Drawing.Point(12, 108);
            this.btnConfirmFind.Name = "btnConfirmFind";
            this.btnConfirmFind.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmFind.TabIndex = 11;
            this.btnConfirmFind.Text = "OK";
            this.toolTip1.SetToolTip(this.btnConfirmFind, "Click to confirm removal of stock");
            this.btnConfirmFind.UseVisualStyleBackColor = true;
            this.btnConfirmFind.Click += new System.EventHandler(this.btnConfirmFind_Click);
            // 
            // lblFindName
            // 
            this.lblFindName.AutoSize = true;
            this.lblFindName.Location = new System.Drawing.Point(12, 9);
            this.lblFindName.Name = "lblFindName";
            this.lblFindName.Size = new System.Drawing.Size(75, 13);
            this.lblFindName.TabIndex = 10;
            this.lblFindName.Text = "Remove by ID";
            // 
            // txtDeleteID
            // 
            this.txtDeleteID.Location = new System.Drawing.Point(153, 6);
            this.txtDeleteID.MaxLength = 25;
            this.txtDeleteID.Name = "txtDeleteID";
            this.txtDeleteID.Size = new System.Drawing.Size(100, 20);
            this.txtDeleteID.TabIndex = 9;
            this.toolTip1.SetToolTip(this.txtDeleteID, "Scan in the ID of the item you want to remove");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Reason:";
            // 
            // rbDisposal
            // 
            this.rbDisposal.AutoSize = true;
            this.rbDisposal.Location = new System.Drawing.Point(6, 19);
            this.rbDisposal.Name = "rbDisposal";
            this.rbDisposal.Size = new System.Drawing.Size(65, 17);
            this.rbDisposal.TabIndex = 14;
            this.rbDisposal.TabStop = true;
            this.rbDisposal.Text = "Disposal";
            this.toolTip1.SetToolTip(this.rbDisposal, "Select if the item is removed because of \"Disposal\"");
            this.rbDisposal.UseVisualStyleBackColor = true;
            this.rbDisposal.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // gbReasonsDelete
            // 
            this.gbReasonsDelete.Controls.Add(this.rbFaulty);
            this.gbReasonsDelete.Controls.Add(this.rbDisposal);
            this.gbReasonsDelete.Location = new System.Drawing.Point(144, 32);
            this.gbReasonsDelete.Name = "gbReasonsDelete";
            this.gbReasonsDelete.Size = new System.Drawing.Size(109, 70);
            this.gbReasonsDelete.TabIndex = 15;
            this.gbReasonsDelete.TabStop = false;
            this.gbReasonsDelete.Text = "Reasons";
            // 
            // rbFaulty
            // 
            this.rbFaulty.AutoSize = true;
            this.rbFaulty.Location = new System.Drawing.Point(6, 42);
            this.rbFaulty.Name = "rbFaulty";
            this.rbFaulty.Size = new System.Drawing.Size(53, 17);
            this.rbFaulty.TabIndex = 15;
            this.rbFaulty.TabStop = true;
            this.rbFaulty.Text = "Faulty";
            this.toolTip1.SetToolTip(this.rbFaulty, "Select if the item is removed because of \"Faulty\"");
            this.rbFaulty.UseVisualStyleBackColor = true;
            // 
            // StockRemoveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 139);
            this.Controls.Add(this.gbReasonsDelete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelFind);
            this.Controls.Add(this.btnConfirmFind);
            this.Controls.Add(this.lblFindName);
            this.Controls.Add(this.txtDeleteID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StockRemoveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove Stock";
            this.gbReasonsDelete.ResumeLayout(false);
            this.gbReasonsDelete.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelFind;
        private System.Windows.Forms.Button btnConfirmFind;
        private System.Windows.Forms.Label lblFindName;
        private System.Windows.Forms.TextBox txtDeleteID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbDisposal;
        private System.Windows.Forms.GroupBox gbReasonsDelete;
        private System.Windows.Forms.RadioButton rbFaulty;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}