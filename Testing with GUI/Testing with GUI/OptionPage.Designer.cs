namespace Testing_with_GUI
{
    partial class OptionPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.createFeedback = new System.Windows.Forms.Button();
            this.createTemplate = new System.Windows.Forms.Button();
            this.editTemplate = new System.Windows.Forms.Button();
            this.deleteTemplate = new System.Windows.Forms.Button();
            this.logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(330, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Option Page";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // createFeedback
            // 
            this.createFeedback.Location = new System.Drawing.Point(254, 130);
            this.createFeedback.Name = "createFeedback";
            this.createFeedback.Size = new System.Drawing.Size(129, 53);
            this.createFeedback.TabIndex = 1;
            this.createFeedback.Text = "Create Feedback";
            this.createFeedback.UseVisualStyleBackColor = true;
            // 
            // createTemplate
            // 
            this.createTemplate.Location = new System.Drawing.Point(408, 130);
            this.createTemplate.Name = "createTemplate";
            this.createTemplate.Size = new System.Drawing.Size(129, 53);
            this.createTemplate.TabIndex = 2;
            this.createTemplate.Text = "Create Template";
            this.createTemplate.UseVisualStyleBackColor = true;
            this.createTemplate.Click += new System.EventHandler(this.createTemplate_Click);
            // 
            // editTemplate
            // 
            this.editTemplate.Location = new System.Drawing.Point(254, 214);
            this.editTemplate.Name = "editTemplate";
            this.editTemplate.Size = new System.Drawing.Size(129, 53);
            this.editTemplate.TabIndex = 3;
            this.editTemplate.Text = "Edit Template";
            this.editTemplate.UseVisualStyleBackColor = true;
            this.editTemplate.Click += new System.EventHandler(this.editTemplate_Click);
            // 
            // deleteTemplate
            // 
            this.deleteTemplate.Location = new System.Drawing.Point(408, 214);
            this.deleteTemplate.Name = "deleteTemplate";
            this.deleteTemplate.Size = new System.Drawing.Size(129, 53);
            this.deleteTemplate.TabIndex = 4;
            this.deleteTemplate.Text = "Delete Template";
            this.deleteTemplate.UseVisualStyleBackColor = true;
            // 
            // logout
            // 
            this.logout.Location = new System.Drawing.Point(32, 375);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(129, 53);
            this.logout.TabIndex = 6;
            this.logout.Text = "Logout";
            this.logout.UseVisualStyleBackColor = true;
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // OptionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logout);
            this.Controls.Add(this.deleteTemplate);
            this.Controls.Add(this.editTemplate);
            this.Controls.Add(this.createTemplate);
            this.Controls.Add(this.createFeedback);
            this.Controls.Add(this.label1);
            this.Name = "OptionPage";
            this.Text = "OptionPage";
            this.Load += new System.EventHandler(this.OptionPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createFeedback;
        private System.Windows.Forms.Button createTemplate;
        private System.Windows.Forms.Button editTemplate;
        private System.Windows.Forms.Button deleteTemplate;
        private System.Windows.Forms.Button logout;
    }
}