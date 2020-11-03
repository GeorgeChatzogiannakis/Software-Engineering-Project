namespace Testing_with_GUI
{
    partial class MenuForm
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.optionLabel = new System.Windows.Forms.Label();
            this.createButton = new System.Windows.Forms.RadioButton();
            this.editButton = new System.Windows.Forms.RadioButton();
            this.deleteButton = new System.Windows.Forms.RadioButton();
            this.sendButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(466, 54);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(104, 17);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Wecome back !";
            // 
            // submitButton
            // 
            this.submitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.submitButton.Location = new System.Drawing.Point(941, 503);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(102, 33);
            this.submitButton.TabIndex = 1;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.SendButton_CheckedChanged);
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.logoutButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.logoutButton.Location = new System.Drawing.Point(28, 507);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(93, 28);
            this.logoutButton.TabIndex = 2;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // optionLabel
            // 
            this.optionLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.optionLabel.AutoSize = true;
            this.optionLabel.Location = new System.Drawing.Point(435, 88);
            this.optionLabel.Name = "optionLabel";
            this.optionLabel.Size = new System.Drawing.Size(165, 17);
            this.optionLabel.TabIndex = 3;
            this.optionLabel.Text = "Please make a selection:";
            // 
            // createButton
            // 
            this.createButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.createButton.AutoSize = true;
            this.createButton.Location = new System.Drawing.Point(326, 165);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(134, 21);
            this.createButton.TabIndex = 8;
            this.createButton.TabStop = true;
            this.createButton.Text = "Create Template";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.CheckedChanged += new System.EventHandler(this.CreateButton_CheckedChanged);
            // 
            // editButton
            // 
            this.editButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.editButton.AutoSize = true;
            this.editButton.Location = new System.Drawing.Point(327, 212);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(116, 21);
            this.editButton.TabIndex = 9;
            this.editButton.TabStop = true;
            this.editButton.Text = "Edit Template";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.CheckedChanged += new System.EventHandler(this.EditButton_CheckedChanged);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.deleteButton.AutoSize = true;
            this.deleteButton.Location = new System.Drawing.Point(327, 263);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(133, 21);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.TabStop = true;
            this.deleteButton.Text = "Delete Template";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.CheckedChanged += new System.EventHandler(this.DeleteButton_CheckedChanged);
            // 
            // sendButton
            // 
            this.sendButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sendButton.AutoSize = true;
            this.sendButton.Location = new System.Drawing.Point(327, 311);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(128, 21);
            this.sendButton.TabIndex = 11;
            this.sendButton.TabStop = true;
            this.sendButton.Text = "Send Feedback";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.CheckedChanged += new System.EventHandler(this.SendButton_CheckedChanged);
            // 
            // MenuForm
            // 
            this.AcceptButton = this.submitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.logoutButton;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.optionLabel);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.welcomeLabel);
            this.MinimumSize = new System.Drawing.Size(500, 460);
            this.Name = "MenuForm";
            this.Text = "Feedback Application";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label optionLabel;
        private System.Windows.Forms.RadioButton createButton;
        private System.Windows.Forms.RadioButton editButton;
        private System.Windows.Forms.RadioButton deleteButton;
        private System.Windows.Forms.RadioButton sendButton;
    }
}