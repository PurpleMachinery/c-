namespace CalculoDaMedia
{
    partial class frmMedia
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
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblAluno = new System.Windows.Forms.Label();
            this.txb1Bim = new System.Windows.Forms.TextBox();
            this.txb2Bim = new System.Windows.Forms.TextBox();
            this.txb3Bim = new System.Windows.Forms.TextBox();
            this.txb4Bim = new System.Windows.Forms.TextBox();
            this.lbl1Bim = new System.Windows.Forms.Label();
            this.lbl2Bim = new System.Windows.Forms.Label();
            this.lbl3Bim = new System.Windows.Forms.Label();
            this.lbl4Bim = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(26, 28);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(416, 20);
            this.txbNome.TabIndex = 0;
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.Location = new System.Drawing.Point(23, 12);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(35, 13);
            this.lblAluno.TabIndex = 1;
            this.lblAluno.Text = "Nome";
            // 
            // txb1Bim
            // 
            this.txb1Bim.Location = new System.Drawing.Point(61, 118);
            this.txb1Bim.Name = "txb1Bim";
            this.txb1Bim.Size = new System.Drawing.Size(120, 20);
            this.txb1Bim.TabIndex = 2;
            // 
            // txb2Bim
            // 
            this.txb2Bim.Location = new System.Drawing.Point(61, 144);
            this.txb2Bim.Name = "txb2Bim";
            this.txb2Bim.Size = new System.Drawing.Size(120, 20);
            this.txb2Bim.TabIndex = 3;
            // 
            // txb3Bim
            // 
            this.txb3Bim.Location = new System.Drawing.Point(297, 118);
            this.txb3Bim.Name = "txb3Bim";
            this.txb3Bim.Size = new System.Drawing.Size(100, 20);
            this.txb3Bim.TabIndex = 4;
            // 
            // txb4Bim
            // 
            this.txb4Bim.Location = new System.Drawing.Point(297, 144);
            this.txb4Bim.Name = "txb4Bim";
            this.txb4Bim.Size = new System.Drawing.Size(100, 20);
            this.txb4Bim.TabIndex = 5;
            // 
            // lbl1Bim
            // 
            this.lbl1Bim.AutoSize = true;
            this.lbl1Bim.Location = new System.Drawing.Point(20, 124);
            this.lbl1Bim.Name = "lbl1Bim";
            this.lbl1Bim.Size = new System.Drawing.Size(39, 13);
            this.lbl1Bim.TabIndex = 6;
            this.lbl1Bim.Text = "1º BIM";
            // 
            // lbl2Bim
            // 
            this.lbl2Bim.AutoSize = true;
            this.lbl2Bim.Location = new System.Drawing.Point(20, 150);
            this.lbl2Bim.Name = "lbl2Bim";
            this.lbl2Bim.Size = new System.Drawing.Size(39, 13);
            this.lbl2Bim.TabIndex = 7;
            this.lbl2Bim.Text = "2º BIM";
            // 
            // lbl3Bim
            // 
            this.lbl3Bim.AutoSize = true;
            this.lbl3Bim.Location = new System.Drawing.Point(256, 124);
            this.lbl3Bim.Name = "lbl3Bim";
            this.lbl3Bim.Size = new System.Drawing.Size(39, 13);
            this.lbl3Bim.TabIndex = 8;
            this.lbl3Bim.Text = "3º BIM";
            // 
            // lbl4Bim
            // 
            this.lbl4Bim.AutoSize = true;
            this.lbl4Bim.Location = new System.Drawing.Point(256, 150);
            this.lbl4Bim.Name = "lbl4Bim";
            this.lbl4Bim.Size = new System.Drawing.Size(39, 13);
            this.lbl4Bim.TabIndex = 9;
            this.lbl4Bim.Text = "4º BIM";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(211, 206);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(0, 13);
            this.lblNome.TabIndex = 10;
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Location = new System.Drawing.Point(211, 232);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(0, 13);
            this.lblMedia.TabIndex = 11;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(199, 68);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 12;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(211, 261);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(0, 13);
            this.lblEstado.TabIndex = 13;
            // 
            // frmMedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 283);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lbl4Bim);
            this.Controls.Add(this.lbl3Bim);
            this.Controls.Add(this.lbl2Bim);
            this.Controls.Add(this.lbl1Bim);
            this.Controls.Add(this.txb4Bim);
            this.Controls.Add(this.txb3Bim);
            this.Controls.Add(this.txb2Bim);
            this.Controls.Add(this.txb1Bim);
            this.Controls.Add(this.lblAluno);
            this.Controls.Add(this.txbNome);
            this.Name = "frmMedia";
            this.Text = "Cálculo da Média";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.TextBox txb1Bim;
        private System.Windows.Forms.TextBox txb2Bim;
        private System.Windows.Forms.TextBox txb3Bim;
        private System.Windows.Forms.TextBox txb4Bim;
        private System.Windows.Forms.Label lbl1Bim;
        private System.Windows.Forms.Label lbl2Bim;
        private System.Windows.Forms.Label lbl3Bim;
        private System.Windows.Forms.Label lbl4Bim;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblEstado;
    }
}

