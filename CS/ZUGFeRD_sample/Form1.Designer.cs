namespace ZUGFeRD_sample {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ButtonExportZugferd = new System.Windows.Forms.Button();
            this.ButtonExportFacturX = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonExportZugferd
            // 
            this.ButtonExportZugferd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonExportZugferd.Location = new System.Drawing.Point(13, 14);
            this.ButtonExportZugferd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonExportZugferd.Name = "ButtonExportZugferd";
            this.ButtonExportZugferd.Size = new System.Drawing.Size(412, 100);
            this.ButtonExportZugferd.TabIndex = 0;
            this.ButtonExportZugferd.Text = "German Specific";
            this.ButtonExportZugferd.UseVisualStyleBackColor = true;
            this.ButtonExportZugferd.Click += new System.EventHandler(this.ButtonExportGermany_Click);
            // 
            // ButtonExportFacturX
            // 
            this.ButtonExportFacturX.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonExportFacturX.Location = new System.Drawing.Point(13, 124);
            this.ButtonExportFacturX.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonExportFacturX.Name = "ButtonExportFacturX";
            this.ButtonExportFacturX.Size = new System.Drawing.Size(412, 100);
            this.ButtonExportFacturX.TabIndex = 1;
            this.ButtonExportFacturX.Text = "French Specific";
            this.ButtonExportFacturX.UseVisualStyleBackColor = true;
            this.ButtonExportFacturX.Click += new System.EventHandler(this.ButtonExportFrance_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 236);
            this.Controls.Add(this.ButtonExportFacturX);
            this.Controls.Add(this.ButtonExportZugferd);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "ZUGFeRD Report Example";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonExportZugferd;
        private System.Windows.Forms.Button ButtonExportFacturX;
    }
}

