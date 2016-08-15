namespace _213
{
    partial class EndOfDay
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
            this.btnFullView = new System.Windows.Forms.Button();
            this.cbTopic = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSelectedView = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFullView
            // 
            this.btnFullView.Location = new System.Drawing.Point(58, 25);
            this.btnFullView.Name = "btnFullView";
            this.btnFullView.Size = new System.Drawing.Size(175, 45);
            this.btnFullView.TabIndex = 0;
            this.btnFullView.Text = "View Full End Of Day Report";
            this.btnFullView.UseVisualStyleBackColor = true;
            this.btnFullView.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbTopic
            // 
            this.cbTopic.FormattingEnabled = true;
            this.cbTopic.Items.AddRange(new object[] {
            "Order",
            "Sales",
            "Stock"});
            this.cbTopic.Location = new System.Drawing.Point(82, 127);
            this.cbTopic.Name = "cbTopic";
            this.cbTopic.Size = new System.Drawing.Size(121, 21);
            this.cbTopic.TabIndex = 1;
            this.cbTopic.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select a Topic to View End of Day Report";
            // 
            // btnSelectedView
            // 
            this.btnSelectedView.Location = new System.Drawing.Point(58, 174);
            this.btnSelectedView.Name = "btnSelectedView";
            this.btnSelectedView.Size = new System.Drawing.Size(175, 43);
            this.btnSelectedView.TabIndex = 3;
            this.btnSelectedView.Text = "View Selected Topic Report";
            this.btnSelectedView.UseVisualStyleBackColor = true;
            this.btnSelectedView.Click += new System.EventHandler(this.btnSelectedView_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 4;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // EndOfDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSelectedView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTopic);
            this.Controls.Add(this.btnFullView);
            this.Name = "EndOfDay";
            this.Text = "EndOfDay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFullView;
        private System.Windows.Forms.ComboBox cbTopic;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectedView;
        private System.Windows.Forms.Button button1;
    }
}