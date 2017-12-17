namespace ChatIHM
{
    partial class TopicForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.topicsLabel = new System.Windows.Forms.Label();
            this.formPanel = new System.Windows.Forms.Panel();
            this.minButton = new ChatIHM.CustomComponent.ButtonZ();
            this.closeButton = new ChatIHM.CustomComponent.ButtonZ();
            this.panelCreateTopic = new System.Windows.Forms.Panel();
            this.addTopicButton = new System.Windows.Forms.Button();
            this.addTopicTextBox = new System.Windows.Forms.TextBox();
            this.panelTopics = new System.Windows.Forms.Panel();
            this.topicsListView = new System.Windows.Forms.ListView();
            this.nameTopic = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Chatters = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.errorTopicExistLabel = new System.Windows.Forms.Label();
            this.formPanel.SuspendLayout();
            this.panelCreateTopic.SuspendLayout();
            this.panelTopics.SuspendLayout();
            this.SuspendLayout();
            // 
            // topicsLabel
            // 
            this.topicsLabel.AutoSize = true;
            this.topicsLabel.Location = new System.Drawing.Point(3, 9);
            this.topicsLabel.Name = "topicsLabel";
            this.topicsLabel.Size = new System.Drawing.Size(65, 22);
            this.topicsLabel.TabIndex = 1;
            this.topicsLabel.Text = "Topics";
            // 
            // formPanel
            // 
            this.formPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.formPanel.Controls.Add(this.errorTopicExistLabel);
            this.formPanel.Controls.Add(this.minButton);
            this.formPanel.Controls.Add(this.closeButton);
            this.formPanel.Controls.Add(this.panelCreateTopic);
            this.formPanel.Controls.Add(this.panelTopics);
            this.formPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formPanel.Location = new System.Drawing.Point(0, 0);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(594, 488);
            this.formPanel.TabIndex = 2;
            this.formPanel.Enter += new System.EventHandler(this.formPanel_Enter);
            this.formPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopicForm_MouseDown);
            this.formPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopicForm_MouseMove);
            this.formPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopicForm_MouseUp);
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
            this.minButton.Location = new System.Drawing.Point(498, 3);
            this.minButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.minButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(97)))), ((int)(((byte)(118)))));
            this.minButton.Name = "minButton";
            this.minButton.Size = new System.Drawing.Size(31, 24);
            this.minButton.TabIndex = 8;
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
            this.closeButton.Location = new System.Drawing.Point(560, 3);
            this.closeButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.closeButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(31, 24);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "X";
            this.closeButton.TextLocation_X = 6;
            this.closeButton.TextLocation_Y = -1;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // panelCreateTopic
            // 
            this.panelCreateTopic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCreateTopic.Controls.Add(this.addTopicButton);
            this.panelCreateTopic.Controls.Add(this.addTopicTextBox);
            this.panelCreateTopic.Location = new System.Drawing.Point(12, 419);
            this.panelCreateTopic.Name = "panelCreateTopic";
            this.panelCreateTopic.Size = new System.Drawing.Size(568, 55);
            this.panelCreateTopic.TabIndex = 3;
            // 
            // addTopicButton
            // 
            this.addTopicButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(177)))), ((int)(((byte)(136)))));
            this.addTopicButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addTopicButton.Location = new System.Drawing.Point(413, 10);
            this.addTopicButton.Name = "addTopicButton";
            this.addTopicButton.Size = new System.Drawing.Size(154, 31);
            this.addTopicButton.TabIndex = 1;
            this.addTopicButton.Text = "Add Topic";
            this.addTopicButton.UseVisualStyleBackColor = false;
            this.addTopicButton.Click += new System.EventHandler(this.addTopicButton_Click);
            // 
            // addTopicTextBox
            // 
            this.addTopicTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.addTopicTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addTopicTextBox.Location = new System.Drawing.Point(0, 10);
            this.addTopicTextBox.Name = "addTopicTextBox";
            this.addTopicTextBox.Size = new System.Drawing.Size(407, 31);
            this.addTopicTextBox.TabIndex = 0;
            // 
            // panelTopics
            // 
            this.panelTopics.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTopics.Controls.Add(this.topicsListView);
            this.panelTopics.Controls.Add(this.topicsLabel);
            this.panelTopics.Location = new System.Drawing.Point(12, 85);
            this.panelTopics.Name = "panelTopics";
            this.panelTopics.Size = new System.Drawing.Size(568, 315);
            this.panelTopics.TabIndex = 2;
            // 
            // topicsListView
            // 
            this.topicsListView.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.topicsListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topicsListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.topicsListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topicsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameTopic,
            this.Chatters});
            this.topicsListView.FullRowSelect = true;
            this.topicsListView.Location = new System.Drawing.Point(-1, 44);
            this.topicsListView.MultiSelect = false;
            this.topicsListView.Name = "topicsListView";
            this.topicsListView.Scrollable = false;
            this.topicsListView.Size = new System.Drawing.Size(568, 268);
            this.topicsListView.TabIndex = 2;
            this.topicsListView.UseCompatibleStateImageBehavior = false;
            this.topicsListView.View = System.Windows.Forms.View.Details;
            this.topicsListView.ItemActivate += new System.EventHandler(this.topicsListView_ItemActivate);
            // 
            // nameTopic
            // 
            this.nameTopic.Text = "Name";
            this.nameTopic.Width = 474;
            // 
            // Chatters
            // 
            this.Chatters.Text = "Chatters";
            this.Chatters.Width = 442;
            // 
            // errorTopicExistLabel
            // 
            this.errorTopicExistLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.errorTopicExistLabel.AutoSize = true;
            this.errorTopicExistLabel.BackColor = System.Drawing.Color.Transparent;
            this.errorTopicExistLabel.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorTopicExistLabel.ForeColor = System.Drawing.Color.Red;
            this.errorTopicExistLabel.Location = new System.Drawing.Point(130, 400);
            this.errorTopicExistLabel.Name = "errorTopicExistLabel";
            this.errorTopicExistLabel.Size = new System.Drawing.Size(332, 19);
            this.errorTopicExistLabel.TabIndex = 10;
            this.errorTopicExistLabel.Text = "Error: This topic already exist! Try another name.";
            this.errorTopicExistLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.errorTopicExistLabel.Visible = false;
            // 
            // TopicForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(594, 488);
            this.Controls.Add(this.formPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "TopicForm";
            this.Text = "TopicForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopicForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopicForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopicForm_MouseUp);
            this.formPanel.ResumeLayout(false);
            this.formPanel.PerformLayout();
            this.panelCreateTopic.ResumeLayout(false);
            this.panelCreateTopic.PerformLayout();
            this.panelTopics.ResumeLayout(false);
            this.panelTopics.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label topicsLabel;
        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.Panel panelCreateTopic;
        private System.Windows.Forms.Panel panelTopics;
        private System.Windows.Forms.ListView topicsListView;
        private System.Windows.Forms.ColumnHeader nameTopic;
        private System.Windows.Forms.ColumnHeader Chatters;
        private CustomComponent.ButtonZ closeButton;
        private CustomComponent.ButtonZ minButton;
        private System.Windows.Forms.Button addTopicButton;
        private System.Windows.Forms.TextBox addTopicTextBox;
        private System.Windows.Forms.Label errorTopicExistLabel;
    }
}