namespace Testing_with_GUI
{
    partial class Form2
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
            this.createCheckBox = new System.Windows.Forms.CheckBox();
            this.editCheckBox = new System.Windows.Forms.CheckBox();
            this.deteleCheckBox = new System.Windows.Forms.CheckBox();
            this.sendCheckBox = new System.Windows.Forms.CheckBox();
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
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
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
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
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
            // createCheckBox
            // 
            this.createCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.createCheckBox.AutoSize = true;
            this.createCheckBox.Location = new System.Drawing.Point(327, 153);
            this.createCheckBox.Name = "createCheckBox";
            this.createCheckBox.Size = new System.Drawing.Size(135, 21);
            this.createCheckBox.TabIndex = 4;
            this.createCheckBox.Text = "Create Template";
            this.createCheckBox.UseVisualStyleBackColor = true;
            this.createCheckBox.CheckedChanged += new System.EventHandler(this.createCheckBox_CheckedChanged);
            // 
            // editCheckBox
            // 
            this.editCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.editCheckBox.AutoSize = true;
            this.editCheckBox.Location = new System.Drawing.Point(327, 203);
            this.editCheckBox.Name = "editCheckBox";
            this.editCheckBox.Size = new System.Drawing.Size(117, 21);
            this.editCheckBox.TabIndex = 5;
            this.editCheckBox.Text = "Edit Template";
            this.editCheckBox.UseVisualStyleBackColor = true;
            this.editCheckBox.CheckedChanged += new System.EventHandler(this.editCheckBox_CheckedChanged);
            // 
            // deteleCheckBox
            // 
            this.deteleCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.deteleCheckBox.AutoSize = true;
            this.deteleCheckBox.Location = new System.Drawing.Point(327, 252);
            this.deteleCheckBox.Name = "deteleCheckBox";
            this.deteleCheckBox.Size = new System.Drawing.Size(134, 21);
            this.deteleCheckBox.TabIndex = 6;
            this.deteleCheckBox.Text = "Delete Template";
            this.deteleCheckBox.UseVisualStyleBackColor = true;
            this.deteleCheckBox.CheckedChanged += new System.EventHandler(this.deteleCheckBox_CheckedChanged);
            // 
            // sendCheckBox
            // 
            this.sendCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sendCheckBox.AutoSize = true;
            this.sendCheckBox.Location = new System.Drawing.Point(327, 298);
            this.sendCheckBox.Name = "sendCheckBox";
            this.sendCheckBox.Size = new System.Drawing.Size(129, 21);
            this.sendCheckBox.TabIndex = 7;
            this.sendCheckBox.Text = "Send Feedback";
            this.sendCheckBox.UseVisualStyleBackColor = true;
            this.sendCheckBox.CheckedChanged += new System.EventHandler(this.sendCheckBox_CheckedChanged);
            // 
            // Form2
            // 
            this.AcceptButton = this.submitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.logoutButton;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.sendCheckBox);
            this.Controls.Add(this.deteleCheckBox);
            this.Controls.Add(this.editCheckBox);
            this.Controls.Add(this.createCheckBox);
            this.Controls.Add(this.optionLabel);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.welcomeLabel);
            this.MinimumSize = new System.Drawing.Size(500, 460);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label optionLabel;
        private System.Windows.Forms.CheckBox createCheckBox;
        private System.Windows.Forms.CheckBox editCheckBox;
        private System.Windows.Forms.CheckBox deteleCheckBox;
        private System.Windows.Forms.CheckBox sendCheckBox;
    }
}