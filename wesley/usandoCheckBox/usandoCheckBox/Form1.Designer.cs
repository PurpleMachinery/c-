namespace usandoCheckBox
{
    partial class frmCheckBox
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
            this.lblQual = new System.Windows.Forms.Label();
            this.ckbC = new System.Windows.Forms.CheckBox();
            this.ckbPHP = new System.Windows.Forms.CheckBox();
            this.ckbJava = new System.Windows.Forms.CheckBox();
            this.ckbVisualB = new System.Windows.Forms.CheckBox();
            this.ckbOutras = new System.Windows.Forms.CheckBox();
            this.ckbEspecifique = new System.Windows.Forms.Label();
            this.txbEspecifique = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQual
            // 
            this.lblQual.AutoSize = true;
            this.lblQual.Location = new System.Drawing.Point(49, 37);
            this.lblQual.Name = "lblQual";
            this.lblQual.Size = new System.Drawing.Size(156, 13);
            this.lblQual.TabIndex = 0;
            this.lblQual.Text = "Qual a sua linguagem preferida:";
            // 
            // ckbC
            // 
            this.ckbC.AutoSize = true;
            this.ckbC.Location = new System.Drawing.Point(52, 67);
            this.ckbC.Name = "ckbC";
            this.ckbC.Size = new System.Drawing.Size(71, 17);
            this.ckbC.TabIndex = 1;
            this.ckbC.Text = "Visual C#";
            this.ckbC.UseVisualStyleBackColor = true;
            // 
            // ckbPHP
            // 
            this.ckbPHP.AutoSize = true;
            this.ckbPHP.Location = new System.Drawing.Point(52, 101);
            this.ckbPHP.Name = "ckbPHP";
            this.ckbPHP.Size = new System.Drawing.Size(48, 17);
            this.ckbPHP.TabIndex = 2;
            this.ckbPHP.Text = "PHP";
            this.ckbPHP.UseVisualStyleBackColor = true;
            // 
            // ckbJava
            // 
            this.ckbJava.AutoSize = true;
            this.ckbJava.Location = new System.Drawing.Point(173, 101);
            this.ckbJava.Name = "ckbJava";
            this.ckbJava.Size = new System.Drawing.Size(49, 17);
            this.ckbJava.TabIndex = 3;
            this.ckbJava.Text = "Java";
            this.ckbJava.UseVisualStyleBackColor = true;
            // 
            // ckbVisualB
            // 
            this.ckbVisualB.AutoSize = true;
            this.ckbVisualB.Location = new System.Drawing.Point(173, 67);
            this.ckbVisualB.Name = "ckbVisualB";
            this.ckbVisualB.Size = new System.Drawing.Size(111, 17);
            this.ckbVisualB.TabIndex = 4;
            this.ckbVisualB.Text = "Visual Basic .NET";
            this.ckbVisualB.UseVisualStyleBackColor = true;
            // 
            // ckbOutras
            // 
            this.ckbOutras.AutoSize = true;
            this.ckbOutras.Location = new System.Drawing.Point(52, 137);
            this.ckbOutras.Name = "ckbOutras";
            this.ckbOutras.Size = new System.Drawing.Size(57, 17);
            this.ckbOutras.TabIndex = 5;
            this.ckbOutras.Text = "Outras";
            this.ckbOutras.UseVisualStyleBackColor = true;
            this.ckbOutras.CheckedChanged += new System.EventHandler(this.ckbOutras_CheckedChanged);
            // 
            // ckbEspecifique
            // 
            this.ckbEspecifique.AutoSize = true;
            this.ckbEspecifique.Location = new System.Drawing.Point(49, 286);
            this.ckbEspecifique.Name = "ckbEspecifique";
            this.ckbEspecifique.Size = new System.Drawing.Size(185, 13);
            this.ckbEspecifique.TabIndex = 6;
            this.ckbEspecifique.Text = "Especifique as linguagens por virgula:";
            // 
            // txbEspecifique
            // 
            this.txbEspecifique.Enabled = false;
            this.txbEspecifique.Location = new System.Drawing.Point(52, 302);
            this.txbEspecifique.Name = "txbEspecifique";
            this.txbEspecifique.Size = new System.Drawing.Size(242, 20);
            this.txbEspecifique.TabIndex = 7;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(88, 359);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(165, 41);
            this.btnSalvar.TabIndex = 8;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 440);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txbEspecifique);
            this.Controls.Add(this.ckbEspecifique);
            this.Controls.Add(this.ckbOutras);
            this.Controls.Add(this.ckbVisualB);
            this.Controls.Add(this.ckbJava);
            this.Controls.Add(this.ckbPHP);
            this.Controls.Add(this.ckbC);
            this.Controls.Add(this.lblQual);
            this.Name = "frmCheckBox";
            this.Text = "Usando CheckBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQual;
        private System.Windows.Forms.CheckBox ckbC;
        private System.Windows.Forms.CheckBox ckbPHP;
        private System.Windows.Forms.CheckBox ckbJava;
        private System.Windows.Forms.CheckBox ckbVisualB;
        private System.Windows.Forms.CheckBox ckbOutras;
        private System.Windows.Forms.Label ckbEspecifique;
        private System.Windows.Forms.TextBox txbEspecifique;
        private System.Windows.Forms.Button btnSalvar;
    }
}

