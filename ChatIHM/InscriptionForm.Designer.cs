namespace ChatIHM
{
    partial class InscriptionForm
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
            this.pseudoLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.mailLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.pseudoTextBox = new System.Windows.Forms.TextBox();
            this.formPanel = new System.Windows.Forms.Panel();
            this.minButton = new ChatIHM.CustomComponent.ButtonZ();
            this.closeButton = new ChatIHM.CustomComponent.ButtonZ();
            this.ErrorUserExistLabel = new System.Windows.Forms.Label();
            this.InscriptionButton = new System.Windows.Forms.Button();
            this.retryLabel = new System.Windows.Forms.Label();
            this.formPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pseudoLabel
            // 
            this.pseudoLabel.AutoSize = true;
            this.pseudoLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pseudoLabel.ForeColor = System.Drawing.Color.White;
            this.pseudoLabel.Location = new System.Drawing.Point(95, 164);
            this.pseudoLabel.Name = "pseudoLabel";
            this.pseudoLabel.Size = new System.Drawing.Size(125, 22);
            this.pseudoLabel.TabIndex = 0;
            this.pseudoLabel.Text = "Your pseudo";
            this.pseudoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.White;
            this.passwordLabel.Location = new System.Drawing.Point(86, 342);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(143, 22);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Your password";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mailTextBox
            // 
            this.mailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.mailTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mailTextBox.Location = new System.Drawing.Point(107, 114);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(100, 21);
            this.mailTextBox.TabIndex = 2;
            // 
            // ageTextBox
            // 
            this.ageTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.ageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ageTextBox.Location = new System.Drawing.Point(107, 294);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(100, 21);
            this.ageTextBox.TabIndex = 3;
            // 
            // mailLabel
            // 
            this.mailLabel.AutoSize = true;
            this.mailLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mailLabel.ForeColor = System.Drawing.Color.White;
            this.mailLabel.Location = new System.Drawing.Point(74, 74);
            this.mailLabel.Name = "mailLabel";
            this.mailLabel.Size = new System.Drawing.Size(167, 22);
            this.mailLabel.TabIndex = 5;
            this.mailLabel.Text = "Your email adress";
            this.mailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.Location = new System.Drawing.Point(107, 382);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(100, 21);
            this.passwordTextBox.TabIndex = 6;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLabel.ForeColor = System.Drawing.Color.White;
            this.ageLabel.Location = new System.Drawing.Point(110, 256);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(94, 22);
            this.ageLabel.TabIndex = 7;
            this.ageLabel.Text = "Your age";
            this.ageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pseudoTextBox
            // 
            this.pseudoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.pseudoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pseudoTextBox.Location = new System.Drawing.Point(107, 207);
            this.pseudoTextBox.Name = "pseudoTextBox";
            this.pseudoTextBox.Size = new System.Drawing.Size(100, 21);
            this.pseudoTextBox.TabIndex = 8;
            // 
            // formPanel
            // 
            this.formPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.formPanel.Controls.Add(this.retryLabel);
            this.formPanel.Controls.Add(this.InscriptionButton);
            this.formPanel.Controls.Add(this.ErrorUserExistLabel);
            this.formPanel.Controls.Add(this.minButton);
            this.formPanel.Controls.Add(this.closeButton);
            this.formPanel.Controls.Add(this.pseudoTextBox);
            this.formPanel.Controls.Add(this.ageLabel);
            this.formPanel.Controls.Add(this.passwordTextBox);
            this.formPanel.Controls.Add(this.mailLabel);
            this.formPanel.Controls.Add(this.ageTextBox);
            this.formPanel.Controls.Add(this.mailTextBox);
            this.formPanel.Controls.Add(this.passwordLabel);
            this.formPanel.Controls.Add(this.pseudoLabel);
            this.formPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formPanel.Location = new System.Drawing.Point(0, 0);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(331, 503);
            this.formPanel.TabIndex = 9;
            this.formPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.InscriptionForm_MouseDown);
            this.formPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.InscriptionForm_MouseMove);
            this.formPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.InscriptionForm_MouseUp);
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
            this.minButton.Location = new System.Drawing.Point(239, -1);
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
            this.closeButton.Location = new System.Drawing.Point(297, 0);
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
            // ErrorUserExistLabel
            // 
            this.ErrorUserExistLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ErrorUserExistLabel.AutoSize = true;
            this.ErrorUserExistLabel.BackColor = System.Drawing.Color.Transparent;
            this.ErrorUserExistLabel.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorUserExistLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorUserExistLabel.Location = new System.Drawing.Point(52, 38);
            this.ErrorUserExistLabel.Name = "ErrorUserExistLabel";
            this.ErrorUserExistLabel.Size = new System.Drawing.Size(225, 19);
            this.ErrorUserExistLabel.TabIndex = 10;
            this.ErrorUserExistLabel.Text = "Error: This pseudo is already use!";
            this.ErrorUserExistLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ErrorUserExistLabel.Visible = false;
            // 
            // InscriptionButton
            // 
            this.InscriptionButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.InscriptionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(187)))), ((int)(((byte)(146)))));
            this.InscriptionButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.InscriptionButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InscriptionButton.ForeColor = System.Drawing.Color.Black;
            this.InscriptionButton.Location = new System.Drawing.Point(94, 439);
            this.InscriptionButton.Name = "InscriptionButton";
            this.InscriptionButton.Size = new System.Drawing.Size(127, 30);
            this.InscriptionButton.TabIndex = 11;
            this.InscriptionButton.Text = "Sign up";
            this.InscriptionButton.UseVisualStyleBackColor = false;
            this.InscriptionButton.Click += new System.EventHandler(this.InscriptionButton_Click);
            // 
            // retryLabel
            // 
            this.retryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.retryLabel.AutoSize = true;
            this.retryLabel.BackColor = System.Drawing.Color.Transparent;
            this.retryLabel.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retryLabel.ForeColor = System.Drawing.Color.Red;
            this.retryLabel.Location = new System.Drawing.Point(116, 55);
            this.retryLabel.Name = "retryLabel";
            this.retryLabel.Size = new System.Drawing.Size(96, 19);
            this.retryLabel.TabIndex = 12;
            this.retryLabel.Text = "Please Retry.";
            this.retryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.retryLabel.Visible = false;
            // 
            // InscriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(331, 503);
            this.Controls.Add(this.formPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "InscriptionForm";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.formPanel.ResumeLayout(false);
            this.formPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label pseudoLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.Label mailLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.TextBox pseudoTextBox;
        private System.Windows.Forms.Panel formPanel;
        private CustomComponent.ButtonZ closeButton;
        private CustomComponent.ButtonZ minButton;
        private System.Windows.Forms.Label ErrorUserExistLabel;
        private System.Windows.Forms.Button InscriptionButton;
        private System.Windows.Forms.Label retryLabel;
    }
}