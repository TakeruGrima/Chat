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
            this.ChatTextBox = new System.Windows.Forms.RichTextBox();
            this.formPanel = new System.Windows.Forms.Panel();
            this.topicNameLabel = new System.Windows.Forms.Label();
            this.minButton = new ChatIHM.CustomComponent.ButtonZ();
            this.closeButton = new ChatIHM.CustomComponent.ButtonZ();
            this.formPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // UserChatBox
            // 
            this.UserChatBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.UserChatBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserChatBox.ForeColor = System.Drawing.SystemColors.Window;
            this.UserChatBox.Location = new System.Drawing.Point(14, 282);
            this.UserChatBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.UserChatBox.Multiline = true;
            this.UserChatBox.Name = "UserChatBox";
            this.UserChatBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.UserChatBox.Size = new System.Drawing.Size(208, 27);
            this.UserChatBox.TabIndex = 0;
            // 
            // SendMessageButton
            // 
            this.SendMessageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.SendMessageButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SendMessageButton.Location = new System.Drawing.Point(230, 282);
            this.SendMessageButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SendMessageButton.Name = "SendMessageButton";
            this.SendMessageButton.Size = new System.Drawing.Size(87, 28);
            this.SendMessageButton.TabIndex = 1;
            this.SendMessageButton.Text = "Send";
            this.SendMessageButton.UseVisualStyleBackColor = false;
            this.SendMessageButton.Click += new System.EventHandler(this.SendMessageButton_Click);
            // 
            // ChatTextBox
            // 
            this.ChatTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.ChatTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ChatTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.ChatTextBox.Location = new System.Drawing.Point(14, 32);
            this.ChatTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChatTextBox.Name = "ChatTextBox";
            this.ChatTextBox.ReadOnly = true;
            this.ChatTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.ChatTextBox.Size = new System.Drawing.Size(303, 242);
            this.ChatTextBox.TabIndex = 2;
            this.ChatTextBox.Text = "";
            // 
            // formPanel
            // 
            this.formPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.formPanel.Controls.Add(this.topicNameLabel);
            this.formPanel.Controls.Add(this.minButton);
            this.formPanel.Controls.Add(this.closeButton);
            this.formPanel.Controls.Add(this.ChatTextBox);
            this.formPanel.Controls.Add(this.SendMessageButton);
            this.formPanel.Controls.Add(this.UserChatBox);
            this.formPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formPanel.Location = new System.Drawing.Point(0, 0);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(331, 321);
            this.formPanel.TabIndex = 4;
            this.formPanel.Enter += new System.EventHandler(this.formPanel_Enter);
            this.formPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChatroomIHM_MouseDown);
            this.formPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChatroomIHM_MouseMove);
            this.formPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ChatroomIHM_MouseUp);
            // 
            // topicNameLabel
            // 
            this.topicNameLabel.AutoSize = true;
            this.topicNameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topicNameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.topicNameLabel.Location = new System.Drawing.Point(12, 8);
            this.topicNameLabel.Name = "topicNameLabel";
            this.topicNameLabel.Size = new System.Drawing.Size(0, 21);
            this.topicNameLabel.TabIndex = 8;
            this.topicNameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ChatroomIHM_MouseDown);
            this.topicNameLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChatroomIHM_MouseMove);
            this.topicNameLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ChatroomIHM_MouseUp);
            // 
            // minButton
            // 
            this.minButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minButton.BackColor = System.Drawing.Color.Transparent;
            this.minButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.minButton.DisplayText = "_";
            this.minButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold);
            this.minButton.ForeColor = System.Drawing.Color.White;
            this.minButton.Location = new System.Drawing.Point(244, 1);
            this.minButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.minButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(97)))), ((int)(((byte)(118)))));
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(31, 24);
            this.minButton.TabIndex = 7;
            this.minButton.Text = "_";
            this.minButton.TextLocation_X = 6;
            this.minButton.TextLocation_Y = -12;
            this.minButton.UseVisualStyleBackColor = false;
            this.minButton.Click += new System.EventHandler(this.MinButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.closeButton.DisplayText = "X";
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold);
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(298, 1);
            this.closeButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.closeButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(31, 24);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "X";
            this.closeButton.TextLocation_X = 6;
            this.closeButton.TextLocation_Y = -1;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ChatroomIHM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(331, 321);
            this.ControlBox = false;
            this.Controls.Add(this.formPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ChatroomIHM";
            this.Text = "ChatroomIHM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatroomIHM_FormClosing);
            this.formPanel.ResumeLayout(false);
            this.formPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox UserChatBox;
        private System.Windows.Forms.Button SendMessageButton;
        private System.Windows.Forms.RichTextBox ChatTextBox;
        private CustomComponent.ButtonZ closeButton;
        private System.Windows.Forms.Panel formPanel;
        private CustomComponent.ButtonZ minButton;
        private System.Windows.Forms.Label topicNameLabel;
    }
}