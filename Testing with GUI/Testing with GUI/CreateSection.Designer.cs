namespace Testing_with_GUI
{
    partial class CreateSection
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
            this.createSec = new System.Windows.Forms.Button();
            this.sectionName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createSec
            // 
            this.createSec.ForeColor = System.Drawing.SystemColors.ControlText;
            this.createSec.Location = new System.Drawing.Point(348, 246);
            this.createSec.Name = "createSec";
            this.createSec.Size = new System.Drawing.Size(108, 40);
            this.createSec.TabIndex = 4;
            this.createSec.Text = "Add Section";
            this.createSec.UseVisualStyleBackColor = true;
            this.createSec.Click += new System.EventHandler(this.createSec_Click);
            // 
            // sectionName
            // 
            this.sectionName.Location = new System.Drawing.Point(262, 165);
            this.sectionName.Name = "sectionName";
            this.sectionName.Size = new System.Drawing.Size(276, 20);
            this.sectionName.TabIndex = 3;
            this.sectionName.TextChanged += new System.EventHandler(this.sectionName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Section Name";
            // 
            // CreateSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.createSec);
            this.Controls.Add(this.sectionName);
            this.Name = "CreateSection";
            this.Text = "CreateSection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createSec;
        private System.Windows.Forms.TextBox sectionName;
        private System.Windows.Forms.Label label1;
    }
}