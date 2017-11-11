namespace WindowsFormsApplication1
{
    partial class frmCinema
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
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.txbNomeCliente = new System.Windows.Forms.TextBox();
            this.lblFilme = new System.Windows.Forms.Label();
            this.ckb3d = new System.Windows.Forms.CheckBox();
            this.lblModo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rdbNormal = new System.Windows.Forms.RadioButton();
            this.rdbEstudante = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPedidos = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.txbQtdPipoca = new System.Windows.Forms.TextBox();
            this.txbQtdCoca = new System.Windows.Forms.TextBox();
            this.lblPrecoPipoca = new System.Windows.Forms.Label();
            this.lblPrecoCoca = new System.Windows.Forms.Label();
            this.ckbPipoca = new System.Windows.Forms.CheckBox();
            this.ckbCoca = new System.Windows.Forms.CheckBox();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.lblValorIngresso = new System.Windows.Forms.Label();
            this.txbValorIngresso = new System.Windows.Forms.TextBox();
            this.lblValorPedido = new System.Windows.Forms.Label();
            this.txbValorPedido = new System.Windows.Forms.TextBox();
            this.lblValorFilme = new System.Windows.Forms.Label();
            this.txbFilme = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txbTotal = new System.Windows.Forms.TextBox();
            this.cbFilme = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Location = new System.Drawing.Point(13, 24);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(88, 13);
            this.lblNomeCliente.TabIndex = 0;
            this.lblNomeCliente.Text = "Nome do Cliente:";
            // 
            // txbNomeCliente
            // 
            this.txbNomeCliente.Location = new System.Drawing.Point(107, 21);
            this.txbNomeCliente.Name = "txbNomeCliente";
            this.txbNomeCliente.Size = new System.Drawing.Size(100, 20);
            this.txbNomeCliente.TabIndex = 1;
            // 
            // lblFilme
            // 
            this.lblFilme.AutoSize = true;
            this.lblFilme.Location = new System.Drawing.Point(272, 24);
            this.lblFilme.Name = "lblFilme";
            this.lblFilme.Size = new System.Drawing.Size(34, 13);
            this.lblFilme.TabIndex = 2;
            this.lblFilme.Text = "Filme:";
            // 
            // ckb3d
            // 
            this.ckb3d.AutoSize = true;
            this.ckb3d.Location = new System.Drawing.Point(316, 48);
            this.ckb3d.Name = "ckb3d";
            this.ckb3d.Size = new System.Drawing.Size(87, 17);
            this.ckb3d.TabIndex = 4;
            this.ckb3d.Text = "3D (R$ 7,50)";
            this.ckb3d.UseVisualStyleBackColor = true;
            // 
            // lblModo
            // 
            this.lblModo.AutoSize = true;
            this.lblModo.Location = new System.Drawing.Point(35, 108);
            this.lblModo.Name = "lblModo";
            this.lblModo.Size = new System.Drawing.Size(34, 13);
            this.lblModo.TabIndex = 5;
            this.lblModo.Text = "Modo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Preço";
            // 
            // rdbNormal
            // 
            this.rdbNormal.AutoSize = true;
            this.rdbNormal.Location = new System.Drawing.Point(16, 133);
            this.rdbNormal.Name = "rdbNormal";
            this.rdbNormal.Size = new System.Drawing.Size(58, 17);
            this.rdbNormal.TabIndex = 7;
            this.rdbNormal.TabStop = true;
            this.rdbNormal.Text = "Normal";
            this.rdbNormal.UseVisualStyleBackColor = true;
            // 
            // rdbEstudante
            // 
            this.rdbEstudante.AutoSize = true;
            this.rdbEstudante.Location = new System.Drawing.Point(16, 166);
            this.rdbEstudante.Name = "rdbEstudante";
            this.rdbEstudante.Size = new System.Drawing.Size(73, 17);
            this.rdbEstudante.TabIndex = 8;
            this.rdbEstudante.TabStop = true;
            this.rdbEstudante.Text = "Estudante";
            this.rdbEstudante.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "R$ 17";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "R$ 8,50";
            // 
            // lblPedidos
            // 
            this.lblPedidos.AutoSize = true;
            this.lblPedidos.Location = new System.Drawing.Point(211, 108);
            this.lblPedidos.Name = "lblPedidos";
            this.lblPedidos.Size = new System.Drawing.Size(45, 13);
            this.lblPedidos.TabIndex = 11;
            this.lblPedidos.Text = "Pedidos";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(297, 108);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(35, 13);
            this.lblPreco.TabIndex = 12;
            this.lblPreco.Text = "Preço";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Location = new System.Drawing.Point(346, 108);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(62, 13);
            this.lblQuantidade.TabIndex = 13;
            this.lblQuantidade.Text = "Quantidade";
            // 
            // txbQtdPipoca
            // 
            this.txbQtdPipoca.Location = new System.Drawing.Point(349, 133);
            this.txbQtdPipoca.Name = "txbQtdPipoca";
            this.txbQtdPipoca.Size = new System.Drawing.Size(65, 20);
            this.txbQtdPipoca.TabIndex = 14;
            // 
            // txbQtdCoca
            // 
            this.txbQtdCoca.Location = new System.Drawing.Point(349, 168);
            this.txbQtdCoca.Name = "txbQtdCoca";
            this.txbQtdCoca.Size = new System.Drawing.Size(65, 20);
            this.txbQtdCoca.TabIndex = 15;
            // 
            // lblPrecoPipoca
            // 
            this.lblPrecoPipoca.AutoSize = true;
            this.lblPrecoPipoca.Location = new System.Drawing.Point(297, 139);
            this.lblPrecoPipoca.Name = "lblPrecoPipoca";
            this.lblPrecoPipoca.Size = new System.Drawing.Size(45, 13);
            this.lblPrecoPipoca.TabIndex = 16;
            this.lblPrecoPipoca.Text = "R$ 4,50";
            // 
            // lblPrecoCoca
            // 
            this.lblPrecoCoca.AutoSize = true;
            this.lblPrecoCoca.Location = new System.Drawing.Point(297, 170);
            this.lblPrecoCoca.Name = "lblPrecoCoca";
            this.lblPrecoCoca.Size = new System.Drawing.Size(45, 13);
            this.lblPrecoCoca.TabIndex = 17;
            this.lblPrecoCoca.Text = "R$ 4,25";
            // 
            // ckbPipoca
            // 
            this.ckbPipoca.AutoSize = true;
            this.ckbPipoca.Location = new System.Drawing.Point(211, 136);
            this.ckbPipoca.Name = "ckbPipoca";
            this.ckbPipoca.Size = new System.Drawing.Size(59, 17);
            this.ckbPipoca.TabIndex = 18;
            this.ckbPipoca.Text = "Pipoca";
            this.ckbPipoca.UseVisualStyleBackColor = true;
            // 
            // ckbCoca
            // 
            this.ckbCoca.AutoSize = true;
            this.ckbCoca.Location = new System.Drawing.Point(211, 168);
            this.ckbCoca.Name = "ckbCoca";
            this.ckbCoca.Size = new System.Drawing.Size(74, 17);
            this.ckbCoca.TabIndex = 19;
            this.ckbCoca.Text = "Coca-cola";
            this.ckbCoca.UseVisualStyleBackColor = true;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(144, 221);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(141, 23);
            this.btnFinalizar.TabIndex = 20;
            this.btnFinalizar.Text = "Finalizar Compra";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // lblValorIngresso
            // 
            this.lblValorIngresso.AutoSize = true;
            this.lblValorIngresso.Location = new System.Drawing.Point(88, 299);
            this.lblValorIngresso.Name = "lblValorIngresso";
            this.lblValorIngresso.Size = new System.Drawing.Size(92, 13);
            this.lblValorIngresso.TabIndex = 21;
            this.lblValorIngresso.Text = "Valor do Ingresso:";
            // 
            // txbValorIngresso
            // 
            this.txbValorIngresso.Enabled = false;
            this.txbValorIngresso.Location = new System.Drawing.Point(80, 315);
            this.txbValorIngresso.Name = "txbValorIngresso";
            this.txbValorIngresso.Size = new System.Drawing.Size(100, 20);
            this.txbValorIngresso.TabIndex = 22;
            // 
            // lblValorPedido
            // 
            this.lblValorPedido.AutoSize = true;
            this.lblValorPedido.Location = new System.Drawing.Point(238, 299);
            this.lblValorPedido.Name = "lblValorPedido";
            this.lblValorPedido.Size = new System.Drawing.Size(85, 13);
            this.lblValorPedido.TabIndex = 23;
            this.lblValorPedido.Text = "Valor do Pedido;";
            // 
            // txbValorPedido
            // 
            this.txbValorPedido.Enabled = false;
            this.txbValorPedido.Location = new System.Drawing.Point(232, 315);
            this.txbValorPedido.Name = "txbValorPedido";
            this.txbValorPedido.Size = new System.Drawing.Size(100, 20);
            this.txbValorPedido.TabIndex = 24;
            // 
            // lblValorFilme
            // 
            this.lblValorFilme.AutoSize = true;
            this.lblValorFilme.Location = new System.Drawing.Point(84, 362);
            this.lblValorFilme.Name = "lblValorFilme";
            this.lblValorFilme.Size = new System.Drawing.Size(96, 13);
            this.lblValorFilme.TabIndex = 25;
            this.lblValorFilme.Text = "Filme Selecionado:";
            // 
            // txbFilme
            // 
            this.txbFilme.Enabled = false;
            this.txbFilme.Location = new System.Drawing.Point(80, 378);
            this.txbFilme.Name = "txbFilme";
            this.txbFilme.Size = new System.Drawing.Size(100, 20);
            this.txbFilme.TabIndex = 26;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(238, 362);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(73, 13);
            this.lblTotal.TabIndex = 27;
            this.lblTotal.Text = "Total a pagar:";
            // 
            // txbTotal
            // 
            this.txbTotal.Enabled = false;
            this.txbTotal.Location = new System.Drawing.Point(232, 378);
            this.txbTotal.Name = "txbTotal";
            this.txbTotal.Size = new System.Drawing.Size(100, 20);
            this.txbTotal.TabIndex = 28;
            // 
            // cbFilme
            // 
            this.cbFilme.FormattingEnabled = true;
            this.cbFilme.Items.AddRange(new object[] {
            "IT: A Coisa - 16",
            "Rogério - 14",
            "Crepusculo - 12",
            "Thor - 12",
            "Sociedade dos poetas mortos - 16",
            "O Procurado - 16"});
            this.cbFilme.Location = new System.Drawing.Point(316, 21);
            this.cbFilme.Name = "cbFilme";
            this.cbFilme.Size = new System.Drawing.Size(121, 21);
            this.cbFilme.TabIndex = 29;
            // 
            // frmCinema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 453);
            this.Controls.Add(this.cbFilme);
            this.Controls.Add(this.txbTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txbFilme);
            this.Controls.Add(this.lblValorFilme);
            this.Controls.Add(this.txbValorPedido);
            this.Controls.Add(this.lblValorPedido);
            this.Controls.Add(this.txbValorIngresso);
            this.Controls.Add(this.lblValorIngresso);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.ckbCoca);
            this.Controls.Add(this.ckbPipoca);
            this.Controls.Add(this.lblPrecoCoca);
            this.Controls.Add(this.lblPrecoPipoca);
            this.Controls.Add(this.txbQtdCoca);
            this.Controls.Add(this.txbQtdPipoca);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblPedidos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rdbEstudante);
            this.Controls.Add(this.rdbNormal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblModo);
            this.Controls.Add(this.ckb3d);
            this.Controls.Add(this.lblFilme);
            this.Controls.Add(this.txbNomeCliente);
            this.Controls.Add(this.lblNomeCliente);
            this.Name = "frmCinema";
            this.Text = "frmCinema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.TextBox txbNomeCliente;
        private System.Windows.Forms.Label lblFilme;
        private System.Windows.Forms.CheckBox ckb3d;
        private System.Windows.Forms.Label lblModo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdbNormal;
        private System.Windows.Forms.RadioButton rdbEstudante;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPedidos;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.TextBox txbQtdPipoca;
        private System.Windows.Forms.TextBox txbQtdCoca;
        private System.Windows.Forms.Label lblPrecoPipoca;
        private System.Windows.Forms.Label lblPrecoCoca;
        private System.Windows.Forms.CheckBox ckbPipoca;
        private System.Windows.Forms.CheckBox ckbCoca;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Label lblValorIngresso;
        private System.Windows.Forms.TextBox txbValorIngresso;
        private System.Windows.Forms.Label lblValorPedido;
        private System.Windows.Forms.TextBox txbValorPedido;
        private System.Windows.Forms.Label lblValorFilme;
        private System.Windows.Forms.TextBox txbFilme;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txbTotal;
        private System.Windows.Forms.ComboBox cbFilme;
    }
}