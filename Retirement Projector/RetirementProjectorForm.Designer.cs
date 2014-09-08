namespace RetirementProjector
{
    partial class RetirementProjector
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
            this.RetirementProperties = new System.Windows.Forms.PropertyGrid();
            this.assumptionsButton = new System.Windows.Forms.Button();
            this.ProjectRetirement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RetirementProperties
            // 
            this.RetirementProperties.Location = new System.Drawing.Point(24, 21);
            this.RetirementProperties.Name = "RetirementProperties";
            this.RetirementProperties.Size = new System.Drawing.Size(343, 261);
            this.RetirementProperties.TabIndex = 1;
            this.RetirementProperties.Visible = false;
            // 
            // assumptionsButton
            // 
            this.assumptionsButton.Location = new System.Drawing.Point(373, 21);
            this.assumptionsButton.Name = "assumptionsButton";
            this.assumptionsButton.Size = new System.Drawing.Size(155, 23);
            this.assumptionsButton.TabIndex = 2;
            this.assumptionsButton.Text = "Edit Retirement Settings";
            this.assumptionsButton.UseVisualStyleBackColor = true;
            this.assumptionsButton.Click += new System.EventHandler(this.assumptionsButton_Click);
            // 
            // ProjectRetirement
            // 
            this.ProjectRetirement.Location = new System.Drawing.Point(291, 329);
            this.ProjectRetirement.Name = "ProjectRetirement";
            this.ProjectRetirement.Size = new System.Drawing.Size(220, 23);
            this.ProjectRetirement.TabIndex = 3;
            this.ProjectRetirement.Text = "Project Retirement";
            this.ProjectRetirement.UseVisualStyleBackColor = true;
            this.ProjectRetirement.Click += new System.EventHandler(this.ProjectRetirement_Click);
            // 
            // RetirementProjector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 456);
            this.Controls.Add(this.ProjectRetirement);
            this.Controls.Add(this.assumptionsButton);
            this.Controls.Add(this.RetirementProperties);
            this.Name = "RetirementProjector";
            this.Text = "Retirement Projector";
            this.Load += new System.EventHandler(this.RetirementProjector_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button assumptionsButton;
        public System.Windows.Forms.PropertyGrid RetirementProperties;
        private System.Windows.Forms.Button ProjectRetirement;
    }
}

