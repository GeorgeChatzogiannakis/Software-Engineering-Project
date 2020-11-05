namespace Testing_with_GUI
{
    partial class CreateTemplate
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
            this.templateType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.createTemp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // templateType
            // 
            this.templateType.Location = new System.Drawing.Point(267, 169);
            this.templateType.Name = "templateType";
            this.templateType.Size = new System.Drawing.Size(276, 20);
            this.templateType.TabIndex = 0;
            this.templateType.TextChanged += new System.EventHandler(this.templateType_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "What is the template name? e.g. (CV, Interview, ...)";
            // 
            // createTemp
            // 
            this.createTemp.Location = new System.Drawing.Point(353, 250);
            this.createTemp.Name = "createTemp";
            this.createTemp.Size = new System.Drawing.Size(108, 40);
            this.createTemp.TabIndex = 2;
            this.createTemp.Text = "Create Template";
            this.createTemp.UseVisualStyleBackColor = true;
            this.createTemp.Click += new System.EventHandler(this.createTemp_Click);
            // 
            // CreateTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createTemp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.templateType);
            this.Name = "CreateTemplate";
            this.Text = "CreateTemplate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox templateType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createTemp;
    }
}