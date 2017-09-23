namespace WindowsFormsApplication1
{
    partial class frmFazendoPedidos
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
            this.lblNMesa = new System.Windows.Forms.Label();
            this.txbNMesa = new System.Windows.Forms.TextBox();
            this.lblPedidos = new System.Windows.Forms.Label();
            this.ckbChoop = new System.Windows.Forms.CheckBox();
            this.ckbPetiscos = new System.Windows.Forms.CheckBox();
            this.ckbRefeicao = new System.Windows.Forms.CheckBox();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txbQChoop = new System.Windows.Forms.TextBox();
            this.txbQPetisco = new System.Windows.Forms.TextBox();
            this.txbQRefeicao = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblTotalParcial = new System.Windows.Forms.Label();
            this.txbTotalParcial = new System.Windows.Forms.TextBox();
            this.txbTaxaServico = new System.Windows.Forms.TextBox();
            this.txbTotal = new System.Windows.Forms.TextBox();
            this.lblTaxaServico = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNMesa
            // 
            this.lblNMesa.AutoSize = true;
            this.lblNMesa.Location = new System.Drawing.Point(13, 13);
            this.lblNMesa.Name = "lblNMesa";
            this.lblNMesa.Size = new System.Drawing.Size(48, 13);
            this.lblNMesa.TabIndex = 0;
            this.lblNMesa.Text = "Nº Mesa";
            // 
            // txbNMesa
            // 
            this.txbNMesa.Location = new System.Drawing.Point(67, 13);
            this.txbNMesa.Name = "txbNMesa";
            this.txbNMesa.Size = new System.Drawing.Size(133, 20);
            this.txbNMesa.TabIndex = 1;
            this.txbNMesa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPedidos
            // 
            this.lblPedidos.AutoSize = true;
            this.lblPedidos.Location = new System.Drawing.Point(13, 40);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Size = new System.Drawing.Size(45, 13);
            this.lblPedidos.TabIndex = 2;
            this.lblPedidos.Text = "Pedidos";
            // 
            // ckbChoop
            // 
            this.ckbChoop.AutoSize = true;
            this.ckbChoop.Location = new System.Drawing.Point(16, 57);
            this.ckbChoop.Name = "ckbChoop";
            this.ckbChoop.Size = new System.Drawing.Size(98, 17);
            this.ckbChoop.TabIndex = 3;
            this.ckbChoop.Text = "Choop R$ 4,50";
            this.ckbChoop.UseVisualStyleBackColor = true;
            // 
            // ckbPetiscos
            // 
            this.ckbPetiscos.AutoSize = true;
            this.ckbPetiscos.Location = new System.Drawing.Point(16, 80);
            this.ckbPetiscos.Name = "ckbPetiscos";
            this.ckbPetiscos.Size = new System.Drawing.Size(107, 17);
            this.ckbPetiscos.TabIndex = 4;
            this.ckbPetiscos.Text = "Petiscos R$ 7,90";
            this.ckbPetiscos.UseVisualStyleBackColor = true;
            // 
            // ckbRefeicao
            // 
            this.ckbRefeicao.AutoSize = true;
            this.ckbRefeicao.Location = new System.Drawing.Point(16, 104);
            this.ckbRefeicao.Name = "ckbRefeicao";
            this.ckbRefeicao.Size = new System.Drawing.Size(116, 17);
            this.ckbRefeicao.TabIndex = 5;
            this.ckbRefeicao.Text = "Refeição R$ 15,90";
            this.ckbRefeicao.UseVisualStyleBackColor = true;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(138, 40);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(62, 13);
            this.lblQuantidade.TabIndex = 6;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // txbQChoop
            // 
            this.txbQChoop.Location = new System.Drawing.Point(136, 57);
            this.txbQChoop.Name = "txbQChoop";
            this.txbQChoop.Size = new System.Drawing.Size(64, 20);
            this.txbQChoop.TabIndex = 7;
            this.txbQChoop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbQPetisco
            // 
            this.txbQPetisco.Location = new System.Drawing.Point(136, 80);
            this.txbQPetisco.Name = "txbQPetisco";
            this.txbQPetisco.Size = new System.Drawing.Size(64, 20);
            this.txbQPetisco.TabIndex = 8;
            this.txbQPetisco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbQRefeicao
            // 
            this.txbQRefeicao.Location = new System.Drawing.Point(136, 104);
            this.txbQRefeicao.Name = "txbQRefeicao";
            this.txbQRefeicao.Size = new System.Drawing.Size(64, 20);
            this.txbQRefeicao.TabIndex = 9;
            this.txbQRefeicao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(67, 156);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(115, 56);
            this.btnVerificar.TabIndex = 10;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lblTotalParcial
            // 
            this.lblTotalParcial.AutoSize = true;
            this.lblTotalParcial.Location = new System.Drawing.Point(262, 41);
            this.lblTotalParcial.Name = "lblTotalParcial";
            this.lblTotalParcial.Size = new System.Drawing.Size(66, 13);
            this.lblTotalParcial.TabIndex = 11;
            this.lblTotalParcial.Text = "Total Parcial";
            // 
            // txbTotalParcial
            // 
            this.txbTotalParcial.Enabled = false;
            this.txbTotalParcial.Location = new System.Drawing.Point(262, 57);
            this.txbTotalParcial.Name = "txbTotalParcial";
            this.txbTotalParcial.Size = new System.Drawing.Size(100, 20);
            this.txbTotalParcial.TabIndex = 12;
            this.txbTotalParcial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbTaxaServico
            // 
            this.txbTaxaServico.Enabled = false;
            this.txbTaxaServico.Location = new System.Drawing.Point(262, 96);
            this.txbTaxaServico.Name = "txbTaxaServico";
            this.txbTaxaServico.Size = new System.Drawing.Size(100, 20);
            this.txbTaxaServico.TabIndex = 13;
            this.txbTaxaServico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbTotal
            // 
            this.txbTotal.Enabled = false;
            this.txbTotal.Location = new System.Drawing.Point(262, 135);
            this.txbTotal.Name = "txbTotal";
            this.txbTotal.Size = new System.Drawing.Size(100, 20);
            this.txbTotal.TabIndex = 14;
            this.txbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTaxaServico
            // 
            this.lblTaxaServico.AutoSize = true;
            this.lblTaxaServico.Location = new System.Drawing.Point(262, 80);
            this.lblTaxaServico.Name = "lblTaxaServico";
            this.lblTaxaServico.Size = new System.Drawing.Size(113, 13);
            this.lblTaxaServico.TabIndex = 15;
            this.lblTaxaServico.Text = "Taxa de Serviços (8%)";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(262, 119);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(71, 13);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "Total à Pagar";
            // 
            // frmFazendoPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 262);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTaxaServico);
            this.Controls.Add(this.txbTotal);
            this.Controls.Add(this.txbTaxaServico);
            this.Controls.Add(this.txbTotalParcial);
            this.Controls.Add(this.lblTotalParcial);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txbQRefeicao);
            this.Controls.Add(this.txbQPetisco);
            this.Controls.Add(this.txbQChoop);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.ckbRefeicao);
            this.Controls.Add(this.ckbPetiscos);
            this.Controls.Add(this.ckbChoop);
            this.Controls.Add(this.lblPedidos);
            this.Controls.Add(this.txbNMesa);
            this.Controls.Add(this.lblNMesa);
            this.Name = "frmFazendoPedidos";
            this.Text = "Fazendo Pedidos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNMesa;
        private System.Windows.Forms.TextBox txbNMesa;
        private System.Windows.Forms.Label lblPedidos;
        private System.Windows.Forms.CheckBox ckbChoop;
        private System.Windows.Forms.CheckBox ckbPetiscos;
        private System.Windows.Forms.CheckBox ckbRefeicao;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txbQChoop;
        private System.Windows.Forms.TextBox txbQPetisco;
        private System.Windows.Forms.TextBox txbQRefeicao;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lblTotalParcial;
        private System.Windows.Forms.TextBox txbTotalParcial;
        private System.Windows.Forms.TextBox txbTaxaServico;
        private System.Windows.Forms.TextBox txbTotal;
        private System.Windows.Forms.Label lblTaxaServico;
        private System.Windows.Forms.Label lblTotal;
    }
}

