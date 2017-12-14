namespace ChatIHM
{
    partial class MainForm
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
            this.CreateTopicButton = new System.Windows.Forms.Button();
            this.CreateTopicTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.JoinTopicButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateTopicButton
            // 
            this.CreateTopicButton.Location = new System.Drawing.Point(95, 97);
            this.CreateTopicButton.Name = "CreateTopicButton";
            this.CreateTopicButton.Size = new System.Drawing.Size(85, 36);
            this.CreateTopicButton.TabIndex = 0;
            this.CreateTopicButton.Text = "Create Topic";
            this.CreateTopicButton.UseVisualStyleBackColor = true;
            this.CreateTopicButton.Click += new System.EventHandler(this.CreateTopicButton_Click);
            // 
            // CreateTopicTextBox
            // 
            this.CreateTopicTextBox.Location = new System.Drawing.Point(74, 71);
            this.CreateTopicTextBox.Name = "CreateTopicTextBox";
            this.CreateTopicTextBox.Size = new System.Drawing.Size(123, 20);
            this.CreateTopicTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // JoinTopicButton
            // 
            this.JoinTopicButton.Location = new System.Drawing.Point(197, 176);
            this.JoinTopicButton.Name = "JoinTopicButton";
            this.JoinTopicButton.Size = new System.Drawing.Size(75, 23);
            this.JoinTopicButton.TabIndex = 3;
            this.JoinTopicButton.Text = "JoinTopic";
            this.JoinTopicButton.UseVisualStyleBackColor = true;
            this.JoinTopicButton.Click += new System.EventHandler(this.JoinTopicButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.JoinTopicButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CreateTopicTextBox);
            this.Controls.Add(this.CreateTopicButton);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateTopicButton;
        private System.Windows.Forms.TextBox CreateTopicTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button JoinTopicButton;
    }
}