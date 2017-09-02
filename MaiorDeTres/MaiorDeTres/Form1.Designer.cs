namespace MaiorDeTres
{
    partial class frmMaiorValorDeTres
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
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblValorA = new System.Windows.Forms.Label();
            this.lblValorB = new System.Windows.Forms.Label();
            this.lblValorC = new System.Windows.Forms.Label();
            this.lblResposta = new System.Windows.Forms.Label();
            this.txbValorA = new System.Windows.Forms.TextBox();
            this.txbValorB = new System.Windows.Forms.TextBox();
            this.txbValorC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(28, 200);
            this.btnVerificar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnVerificar.Size = new System.Drawing.Size(227, 50);
            this.btnVerificar.TabIndex = 0;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lblValorA
            // 
            this.lblValorA.AutoSize = true;
            this.lblValorA.Location = new System.Drawing.Point(25, 9);
            this.lblValorA.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorA.Name = "lblValorA";
            this.lblValorA.Size = new System.Drawing.Size(41, 13);
            this.lblValorA.TabIndex = 1;
            this.lblValorA.Text = "Valor A";
            // 
            // lblValorB
            // 
            this.lblValorB.AutoSize = true;
            this.lblValorB.Location = new System.Drawing.Point(25, 48);
            this.lblValorB.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorB.Name = "lblValorB";
            this.lblValorB.Size = new System.Drawing.Size(41, 13);
            this.lblValorB.TabIndex = 2;
            this.lblValorB.Text = "Valor B";
            // 
            // lblValorC
            // 
            this.lblValorC.AutoSize = true;
            this.lblValorC.Location = new System.Drawing.Point(25, 89);
            this.lblValorC.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorC.Name = "lblValorC";
            this.lblValorC.Size = new System.Drawing.Size(41, 13);
            this.lblValorC.TabIndex = 3;
            this.lblValorC.Text = "Valor C";
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Location = new System.Drawing.Point(36, 135);
            this.lblResposta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(0, 13);
            this.lblResposta.TabIndex = 4;
            // 
            // txbValorA
            // 
            this.txbValorA.Location = new System.Drawing.Point(28, 26);
            this.txbValorA.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbValorA.Name = "txbValorA";
            this.txbValorA.Size = new System.Drawing.Size(227, 20);
            this.txbValorA.TabIndex = 5;
            // 
            // txbValorB
            // 
            this.txbValorB.Location = new System.Drawing.Point(28, 66);
            this.txbValorB.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbValorB.Name = "txbValorB";
            this.txbValorB.Size = new System.Drawing.Size(227, 20);
            this.txbValorB.TabIndex = 6;
            // 
            // txbValorC
            // 
            this.txbValorC.Location = new System.Drawing.Point(28, 107);
            this.txbValorC.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbValorC.Name = "txbValorC";
            this.txbValorC.Size = new System.Drawing.Size(227, 20);
            this.txbValorC.TabIndex = 7;
            // 
            // frmMaiorValorDeTres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txbValorC);
            this.Controls.Add(this.txbValorB);
            this.Controls.Add(this.txbValorA);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.lblValorC);
            this.Controls.Add(this.lblValorB);
            this.Controls.Add(this.lblValorA);
            this.Controls.Add(this.btnVerificar);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmMaiorValorDeTres";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = " Maior Valor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lblValorA;
        private System.Windows.Forms.Label lblValorB;
        private System.Windows.Forms.Label lblValorC;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.TextBox txbValorA;
        private System.Windows.Forms.TextBox txbValorB;
        private System.Windows.Forms.TextBox txbValorC;
    }
}

