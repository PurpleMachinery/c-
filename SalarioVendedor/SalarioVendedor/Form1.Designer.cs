namespace SalarioVendedor
{
    partial class frmSalarioVendedor
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
            this.txbSalarioBruto = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSalarioBruto = new System.Windows.Forms.Label();
            this.lblFuncao = new System.Windows.Forms.Label();
            this.rdbVendedor = new System.Windows.Forms.RadioButton();
            this.rdbOutros = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblValorVendas = new System.Windows.Forms.Label();
            this.lblSalarioReceber = new System.Windows.Forms.Label();
            this.txbValorVendas = new System.Windows.Forms.TextBox();
            this.txbSalarioReceber = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(85, 6);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(294, 20);
            this.txbNome.TabIndex = 0;
            // 
            // txbSalarioBruto
            // 
            this.txbSalarioBruto.Location = new System.Drawing.Point(85, 32);
            this.txbSalarioBruto.Name = "txbSalarioBruto";
            this.txbSalarioBruto.Size = new System.Drawing.Size(117, 20);
            this.txbSalarioBruto.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(10, 9);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // lblSalarioBruto
            // 
            this.lblSalarioBruto.AutoSize = true;
            this.lblSalarioBruto.Location = new System.Drawing.Point(6, 35);
            this.lblSalarioBruto.Name = "lblSalarioBruto";
            this.lblSalarioBruto.Size = new System.Drawing.Size(70, 13);
            this.lblSalarioBruto.TabIndex = 3;
            this.lblSalarioBruto.Text = " Salario Bruto";
            // 
            // lblFuncao
            // 
            this.lblFuncao.AutoSize = true;
            this.lblFuncao.Location = new System.Drawing.Point(10, 110);
            this.lblFuncao.Name = "lblFuncao";
            this.lblFuncao.Size = new System.Drawing.Size(43, 13);
            this.lblFuncao.TabIndex = 4;
            this.lblFuncao.Text = "Função";
            // 
            // rdbVendedor
            // 
            this.rdbVendedor.AutoSize = true;
            this.rdbVendedor.Location = new System.Drawing.Point(10, 127);
            this.rdbVendedor.Name = "rdbVendedor";
            this.rdbVendedor.Size = new System.Drawing.Size(71, 17);
            this.rdbVendedor.TabIndex = 5;
            this.rdbVendedor.TabStop = true;
            this.rdbVendedor.Text = "Vendedor";
            this.rdbVendedor.UseVisualStyleBackColor = true;
            // 
            // rdbOutros
            // 
            this.rdbOutros.AutoSize = true;
            this.rdbOutros.Location = new System.Drawing.Point(10, 151);
            this.rdbOutros.Name = "rdbOutros";
            this.rdbOutros.Size = new System.Drawing.Size(56, 17);
            this.rdbOutros.TabIndex = 6;
            this.rdbOutros.TabStop = true;
            this.rdbOutros.Text = "Outros";
            this.rdbOutros.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(13, 174);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(364, 36);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblValorVendas
            // 
            this.lblValorVendas.AutoSize = true;
            this.lblValorVendas.Location = new System.Drawing.Point(10, 60);
            this.lblValorVendas.Name = "lblValorVendas";
            this.lblValorVendas.Size = new System.Drawing.Size(69, 13);
            this.lblValorVendas.TabIndex = 8;
            this.lblValorVendas.Text = "Valor vendas";
            // 
            // lblSalarioReceber
            // 
            this.lblSalarioReceber.AutoSize = true;
            this.lblSalarioReceber.Location = new System.Drawing.Point(10, 84);
            this.lblSalarioReceber.Name = "lblSalarioReceber";
            this.lblSalarioReceber.Size = new System.Drawing.Size(92, 13);
            this.lblSalarioReceber.TabIndex = 9;
            this.lblSalarioReceber.Text = "Salario a Receber";
            // 
            // txbValorVendas
            // 
            this.txbValorVendas.Location = new System.Drawing.Point(105, 59);
            this.txbValorVendas.Name = "txbValorVendas";
            this.txbValorVendas.Size = new System.Drawing.Size(169, 20);
            this.txbValorVendas.TabIndex = 10;
            // 
            // txbSalarioReceber
            // 
            this.txbSalarioReceber.Enabled = false;
            this.txbSalarioReceber.Location = new System.Drawing.Point(105, 83);
            this.txbSalarioReceber.Name = "txbSalarioReceber";
            this.txbSalarioReceber.Size = new System.Drawing.Size(169, 20);
            this.txbSalarioReceber.TabIndex = 11;
            // 
            // frmSalarioVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 217);
            this.Controls.Add(this.txbSalarioReceber);
            this.Controls.Add(this.txbValorVendas);
            this.Controls.Add(this.lblSalarioReceber);
            this.Controls.Add(this.lblValorVendas);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.rdbOutros);
            this.Controls.Add(this.rdbVendedor);
            this.Controls.Add(this.lblFuncao);
            this.Controls.Add(this.lblSalarioBruto);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txbSalarioBruto);
            this.Controls.Add(this.txbNome);
            this.Name = "frmSalarioVendedor";
            this.Text = "Calculando Sálario Vendedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbSalarioBruto;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalarioBruto;
        private System.Windows.Forms.Label lblFuncao;
        private System.Windows.Forms.RadioButton rdbVendedor;
        private System.Windows.Forms.RadioButton rdbOutros;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblValorVendas;
        private System.Windows.Forms.Label lblSalarioReceber;
        private System.Windows.Forms.TextBox txbValorVendas;
        private System.Windows.Forms.TextBox txbSalarioReceber;
    }
}

