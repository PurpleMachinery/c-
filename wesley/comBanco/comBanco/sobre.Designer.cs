namespace comBanco
{
    partial class sobre
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
            this.lblDados1 = new System.Windows.Forms.Label();
            this.lblDados2 = new System.Windows.Forms.Label();
            this.lblDados3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDados1
            // 
            this.lblDados1.AutoSize = true;
            this.lblDados1.Location = new System.Drawing.Point(37, 43);
            this.lblDados1.Name = "lblDados1";
            this.lblDados1.Size = new System.Drawing.Size(106, 13);
            this.lblDados1.TabIndex = 0;
            this.lblDados1.Text = "Wesley vieira de lima";
            // 
            // lblDados2
            // 
            this.lblDados2.AutoSize = true;
            this.lblDados2.Location = new System.Drawing.Point(40, 80);
            this.lblDados2.Name = "lblDados2";
            this.lblDados2.Size = new System.Drawing.Size(59, 13);
            this.lblDados2.TabIndex = 1;
            this.lblDados2.Text = "Informatica";
            // 
            // lblDados3
            // 
            this.lblDados3.AutoSize = true;
            this.lblDados3.Location = new System.Drawing.Point(40, 116);
            this.lblDados3.Name = "lblDados3";
            this.lblDados3.Size = new System.Drawing.Size(95, 13);
            this.lblDados3.TabIndex = 2;
            this.lblDados3.Text = "Etec da zona leste";
            // 
            // sobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblDados3);
            this.Controls.Add(this.lblDados2);
            this.Controls.Add(this.lblDados1);
            this.Name = "sobre";
            this.Text = "sobre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDados1;
        private System.Windows.Forms.Label lblDados2;
        private System.Windows.Forms.Label lblDados3;
    }
}