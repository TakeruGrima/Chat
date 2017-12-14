namespace ChatIHM
{
    partial class ChatroomIHM
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
            this.UserChatBox = new System.Windows.Forms.TextBox();
            this.SendMessageButton = new System.Windows.Forms.Button();
            this.ChatTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UserChatBox
            // 
            this.UserChatBox.Location = new System.Drawing.Point(12, 229);
            this.UserChatBox.Multiline = true;
            this.UserChatBox.Name = "UserChatBox";
            this.UserChatBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UserChatBox.Size = new System.Drawing.Size(179, 23);
            this.UserChatBox.TabIndex = 0;
            // 
            // SendMessageButton
            // 
            this.SendMessageButton.Location = new System.Drawing.Point(197, 229);
            this.SendMessageButton.Name = "SendMessageButton";
            this.SendMessageButton.Size = new System.Drawing.Size(75, 23);
            this.SendMessageButton.TabIndex = 1;
            this.SendMessageButton.Text = "Send";
            this.SendMessageButton.UseVisualStyleBackColor = true;
            this.SendMessageButton.Click += new System.EventHandler(this.SendMessageButton_Click);
            // 
            // ChatTextBox
            // 
            this.ChatTextBox.Location = new System.Drawing.Point(12, 17);
            this.ChatTextBox.Multiline = true;
            this.ChatTextBox.Name = "ChatTextBox";
            this.ChatTextBox.ReadOnly = true;
            this.ChatTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ChatTextBox.Size = new System.Drawing.Size(260, 206);
            this.ChatTextBox.TabIndex = 2;
            // 
            // ChatroomIHM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ChatTextBox);
            this.Controls.Add(this.SendMessageButton);
            this.Controls.Add(this.UserChatBox);
            this.Name = "ChatroomIHM";
            this.Text = "ChatroomIHM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserChatBox;
        private System.Windows.Forms.Button SendMessageButton;
        private System.Windows.Forms.TextBox ChatTextBox;
    }
}