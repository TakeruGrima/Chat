namespace ChatIHM
{
    partial class AuthentificationForm
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
            this.labelTitre = new System.Windows.Forms.Label();
            this.panelConnexion = new System.Windows.Forms.Panel();
            this.ErrorLoginLabel = new System.Windows.Forms.Label();
            this.inscriptionButton = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.connexionButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.formPanel = new System.Windows.Forms.Panel();
            this.retryLabel = new System.Windows.Forms.Label();
            this.ErrorConnexionLabel = new System.Windows.Forms.Label();
            this.minButton = new ChatIHM.CustomComponent.ButtonZ();
            this.closeButton = new ChatIHM.CustomComponent.ButtonZ();
            this.panelConnexion.SuspendLayout();
            this.formPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitre
            // 
            this.labelTitre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.labelTitre.AutoSize = true;
            this.labelTitre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(187)))), ((int)(((byte)(146)))));
            this.labelTitre.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.Location = new System.Drawing.Point(48, 37);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(323, 22);
            this.labelTitre.TabIndex = 0;
            this.labelTitre.Text = "Welcome to the Tchat Application";
            // 
            // panelConnexion
            // 
            this.panelConnexion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panelConnexion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.panelConnexion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelConnexion.Controls.Add(this.ErrorConnexionLabel);
            this.panelConnexion.Controls.Add(this.retryLabel);
            this.panelConnexion.Controls.Add(this.ErrorLoginLabel);
            this.panelConnexion.Controls.Add(this.inscriptionButton);
            this.panelConnexion.Controls.Add(this.passwordLabel);
            this.panelConnexion.Controls.Add(this.loginLabel);
            this.panelConnexion.Controls.Add(this.loginTextBox);
            this.panelConnexion.Controls.Add(this.connexionButton);
            this.panelConnexion.Controls.Add(this.passwordTextBox);
            this.panelConnexion.Location = new System.Drawing.Point(52, 95);
            this.panelConnexion.Name = "panelConnexion";
            this.panelConnexion.Size = new System.Drawing.Size(308, 303);
            this.panelConnexion.TabIndex = 1;
            // 
            // ErrorLoginLabel
            // 
            this.ErrorLoginLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ErrorLoginLabel.AutoSize = true;
            this.ErrorLoginLabel.BackColor = System.Drawing.Color.Transparent;
            this.ErrorLoginLabel.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLoginLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorLoginLabel.Location = new System.Drawing.Point(35, 0);
            this.ErrorLoginLabel.Name = "ErrorLoginLabel";
            this.ErrorLoginLabel.Size = new System.Drawing.Size(236, 19);
            this.ErrorLoginLabel.TabIndex = 0;
            this.ErrorLoginLabel.Text = "Error: Wrong pseudo or Password!";
            this.ErrorLoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ErrorLoginLabel.Visible = false;
            // 
            // inscriptionButton
            // 
            this.inscriptionButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.inscriptionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(187)))), ((int)(((byte)(146)))));
            this.inscriptionButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.inscriptionButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inscriptionButton.ForeColor = System.Drawing.Color.Black;
            this.inscriptionButton.Location = new System.Drawing.Point(90, 247);
            this.inscriptionButton.Name = "inscriptionButton";
            this.inscriptionButton.Size = new System.Drawing.Size(127, 30);
            this.inscriptionButton.TabIndex = 7;
            this.inscriptionButton.Text = "Sign up";
            this.inscriptionButton.UseVisualStyleBackColor = false;
            this.inscriptionButton.Click += new System.EventHandler(this.inscriptionButton_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.passwordLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.White;
            this.passwordLabel.Location = new System.Drawing.Point(82, 124);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(143, 22);
            this.passwordLabel.TabIndex = 6;
            this.passwordLabel.Text = "Your password";
            // 
            // loginLabel
            // 
            this.loginLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.loginLabel.AutoSize = true;
            this.loginLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.loginLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.ForeColor = System.Drawing.Color.White;
            this.loginLabel.Location = new System.Drawing.Point(91, 38);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(125, 22);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "Your pseudo";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.loginTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.loginTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginTextBox.Location = new System.Drawing.Point(90, 84);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(127, 20);
            this.loginTextBox.TabIndex = 4;
            this.loginTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // connexionButton
            // 
            this.connexionButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.connexionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(187)))), ((int)(((byte)(146)))));
            this.connexionButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.connexionButton.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connexionButton.ForeColor = System.Drawing.Color.Black;
            this.connexionButton.Location = new System.Drawing.Point(90, 202);
            this.connexionButton.Name = "connexionButton";
            this.connexionButton.Size = new System.Drawing.Size(127, 30);
            this.connexionButton.TabIndex = 6;
            this.connexionButton.Text = "Sign on";
            this.connexionButton.UseVisualStyleBackColor = false;
            this.connexionButton.Click += new System.EventHandler(this.ConnexionButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(81)))), ((int)(((byte)(89)))));
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(90, 165);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(127, 20);
            this.passwordTextBox.TabIndex = 5;
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // formPanel
            // 
            this.formPanel.AutoSize = true;
            this.formPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.formPanel.Controls.Add(this.minButton);
            this.formPanel.Controls.Add(this.closeButton);
            this.formPanel.Controls.Add(this.panelConnexion);
            this.formPanel.Controls.Add(this.labelTitre);
            this.formPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.formPanel.Location = new System.Drawing.Point(0, 0);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(415, 434);
            this.formPanel.TabIndex = 8;
            this.formPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AuthentificationForm_MouseDown);
            this.formPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AuthentificationForm_MouseMove);
            this.formPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AuthentificationForm_MouseUp);
            // 
            // retryLabel
            // 
            this.retryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.retryLabel.AutoSize = true;
            this.retryLabel.BackColor = System.Drawing.Color.Transparent;
            this.retryLabel.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retryLabel.ForeColor = System.Drawing.Color.Red;
            this.retryLabel.Location = new System.Drawing.Point(105, 19);
            this.retryLabel.Name = "retryLabel";
            this.retryLabel.Size = new System.Drawing.Size(96, 19);
            this.retryLabel.TabIndex = 8;
            this.retryLabel.Text = "Please Retry.";
            this.retryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.retryLabel.Visible = false;
            // 
            // ErrorConnexionLabel
            // 
            this.ErrorConnexionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ErrorConnexionLabel.AutoSize = true;
            this.ErrorConnexionLabel.BackColor = System.Drawing.Color.Transparent;
            this.ErrorConnexionLabel.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorConnexionLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorConnexionLabel.Location = new System.Drawing.Point(35, 0);
            this.ErrorConnexionLabel.Name = "ErrorConnexionLabel";
            this.ErrorConnexionLabel.Size = new System.Drawing.Size(255, 19);
            this.ErrorConnexionLabel.TabIndex = 9;
            this.ErrorConnexionLabel.Text = "Error: This user is already connected!";
            this.ErrorConnexionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ErrorConnexionLabel.Visible = false;
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
            this.minButton.Location = new System.Drawing.Point(313, 1);
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
            this.closeButton.Location = new System.Drawing.Point(380, 1);
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
            // AuthentificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(415, 434);
            this.Controls.Add(this.formPanel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "AuthentificationForm";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AuthentificationForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AuthentificationForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.AuthentificationForm_MouseUp);
            this.panelConnexion.ResumeLayout(false);
            this.panelConnexion.PerformLayout();
            this.formPanel.ResumeLayout(false);
            this.formPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Button connexionButton;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.Panel panelConnexion;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label passwordLabel;
        private CustomComponent.ButtonZ closeButton;
        private CustomComponent.ButtonZ minButton;
        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.Button inscriptionButton;
        private System.Windows.Forms.Label ErrorLoginLabel;
        private System.Windows.Forms.Label ErrorConnexionLabel;
        private System.Windows.Forms.Label retryLabel;
    }
}

