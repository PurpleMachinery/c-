namespace semBanco
{
    partial class frmCalcularFrete
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblLocalizacao = new System.Windows.Forms.Label();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.cbLocal = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblValorCompra = new System.Windows.Forms.Label();
            this.lblFrete = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblValorF = new System.Windows.Forms.Label();
            this.lblFreteF = new System.Windows.Forms.Label();
            this.lblTotalF = new System.Windows.Forms.Label();
            this.txbValor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(13, 13);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(13, 39);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(34, 13);
            this.lblValor.TabIndex = 1;
            this.lblValor.Text = "Valor:";
            // 
            // lblLocalizacao
            // 
            this.lblLocalizacao.AutoSize = true;
            this.lblLocalizacao.Location = new System.Drawing.Point(13, 65);
            this.lblLocalizacao.Name = "lblLocalizacao";
            this.lblLocalizacao.Size = new System.Drawing.Size(64, 13);
            this.lblLocalizacao.TabIndex = 2;
            this.lblLocalizacao.Text = "Localização";
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(54, 10);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(100, 20);
            this.txbNome.TabIndex = 3;
            // 
            // cbLocal
            // 
            this.cbLocal.FormattingEnabled = true;
            this.cbLocal.Items.AddRange(new object[] {
            "Sul",
            "Sudeste",
            "Nordeste",
            "Norte",
            "Centro-Oeste"});
            this.cbLocal.Location = new System.Drawing.Point(80, 62);
            this.cbLocal.Name = "cbLocal";
            this.cbLocal.Size = new System.Drawing.Size(74, 21);
            this.cbLocal.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(173, 62);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(101, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblValorCompra
            // 
            this.lblValorCompra.AutoSize = true;
            this.lblValorCompra.Location = new System.Drawing.Point(12, 143);
            this.lblValorCompra.Name = "lblValorCompra";
            this.lblValorCompra.Size = new System.Drawing.Size(88, 13);
            this.lblValorCompra.TabIndex = 7;
            this.lblValorCompra.Text = "Valor da Compra:";
            // 
            // lblFrete
            // 
            this.lblFrete.AutoSize = true;
            this.lblFrete.Location = new System.Drawing.Point(118, 143);
            this.lblFrete.Name = "lblFrete";
            this.lblFrete.Size = new System.Drawing.Size(34, 13);
            this.lblFrete.TabIndex = 8;
            this.lblFrete.Text = "Frete:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(206, 143);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Total:";
            // 
            // lblValorF
            // 
            this.lblValorF.AutoSize = true;
            this.lblValorF.Location = new System.Drawing.Point(37, 180);
            this.lblValorF.Name = "lblValorF";
            this.lblValorF.Size = new System.Drawing.Size(0, 13);
            this.lblValorF.TabIndex = 10;
            // 
            // lblFreteF
            // 
            this.lblFreteF.AutoSize = true;
            this.lblFreteF.Location = new System.Drawing.Point(121, 180);
            this.lblFreteF.Name = "lblFreteF";
            this.lblFreteF.Size = new System.Drawing.Size(0, 13);
            this.lblFreteF.TabIndex = 11;
            // 
            // lblTotalF
            // 
            this.lblTotalF.AutoSize = true;
            this.lblTotalF.Location = new System.Drawing.Point(206, 180);
            this.lblTotalF.Name = "lblTotalF";
            this.lblTotalF.Size = new System.Drawing.Size(0, 13);
            this.lblTotalF.TabIndex = 12;
            // 
            // txbValor
            // 
            this.txbValor.Location = new System.Drawing.Point(54, 37);
            this.txbValor.Name = "txbValor";
            this.txbValor.Size = new System.Drawing.Size(100, 20);
            this.txbValor.TabIndex = 13;
            // 
            // frmCalcularFrete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 234);
            this.Controls.Add(this.txbValor);
            this.Controls.Add(this.lblTotalF);
            this.Controls.Add(this.lblFreteF);
            this.Controls.Add(this.lblValorF);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblFrete);
            this.Controls.Add(this.lblValorCompra);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cbLocal);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.lblLocalizacao);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.lblNome);
            this.Name = "frmCalcularFrete";
            this.Text = "Calcular Frete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblLocalizacao;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.ComboBox cbLocal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblValorCompra;
        private System.Windows.Forms.Label lblFrete;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblValorF;
        private System.Windows.Forms.Label lblFreteF;
        private System.Windows.Forms.Label lblTotalF;
        private System.Windows.Forms.TextBox txbValor;
    }
}

