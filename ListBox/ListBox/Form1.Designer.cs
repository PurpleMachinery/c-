namespace ListBox
{
    partial class frmList
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
            this.lbLivros = new System.Windows.Forms.ListBox();
            this.lblN1 = new System.Windows.Forms.Label();
            this.lblN2 = new System.Windows.Forms.Label();
            this.lblN3 = new System.Windows.Forms.Label();
            this.lblN4 = new System.Windows.Forms.Label();
            this.mtxbCpf = new System.Windows.Forms.MaskedTextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.lblIdade = new System.Windows.Forms.Label();
            this.nudIdade = new System.Windows.Forms.NumericUpDown();
            this.btnComprar = new System.Windows.Forms.Button();
            this.txbTotal = new System.Windows.Forms.TextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudIdade)).BeginInit();
            this.SuspendLayout();
            // 
            // lbLivros
            // 
            this.lbLivros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLivros.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLivros.FormattingEnabled = true;
            this.lbLivros.ItemHeight = 16;
            this.lbLivros.Items.AddRange(new object[] {
            "Contos de Imaginação e Mistério – Edgar Allan Poe – R$ 55,00",
            "A Senhora do Lago – Andrzej Sapkowski – R$ 47,00",
            "O Sono Eterno – Philip Marlowe – Raymond Chandler – R$ 23,00",
            "No Sufoco – Chuck Palahniuk – R$ 35,00",
            "Os Crimes da Rua Morgue e Outras Histórias – Edgar Allan Poe – R$ 55,00",
            "Agentes do Destino – Philip K. Dick – R$ 55,00",
            "Bruxaria – Wicked Vol 01 – Nancy Holder – R$ 35,00",
            "A Redenção do Anjo Caído – Fabio Baptista – R$ 45,00",
            "Psicopatas do Cotidiano – Katia Mecler – R$ 25,00"});
            this.lbLivros.Location = new System.Drawing.Point(41, 103);
            this.lbLivros.Name = "lbLivros";
            this.lbLivros.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbLivros.Size = new System.Drawing.Size(442, 116);
            this.lbLivros.TabIndex = 0;
            // 
            // lblN1
            // 
            this.lblN1.AutoSize = true;
            this.lblN1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN1.Location = new System.Drawing.Point(132, 80);
            this.lblN1.Name = "lblN1";
            this.lblN1.Size = new System.Drawing.Size(258, 20);
            this.lblN1.TabIndex = 2;
            this.lblN1.Text = "Selecione Três Livros (70% de desconto)";
            // 
            // lblN2
            // 
            this.lblN2.AutoSize = true;
            this.lblN2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN2.Location = new System.Drawing.Point(82, 252);
            this.lblN2.Name = "lblN2";
            this.lblN2.Size = new System.Drawing.Size(93, 20);
            this.lblN2.TabIndex = 3;
            this.lblN2.Text = "Digite seu Cpf";
            // 
            // lblN3
            // 
            this.lblN3.AutoSize = true;
            this.lblN3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN3.Location = new System.Drawing.Point(82, 274);
            this.lblN3.Name = "lblN3";
            this.lblN3.Size = new System.Drawing.Size(109, 20);
            this.lblN3.TabIndex = 4;
            this.lblN3.Text = "Digite seu Nome";
            // 
            // lblN4
            // 
            this.lblN4.AutoSize = true;
            this.lblN4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN4.Location = new System.Drawing.Point(82, 297);
            this.lblN4.Name = "lblN4";
            this.lblN4.Size = new System.Drawing.Size(132, 20);
            this.lblN4.TabIndex = 5;
            this.lblN4.Text = "Digite seu Endereço";
            // 
            // mtxbCpf
            // 
            this.mtxbCpf.Location = new System.Drawing.Point(225, 253);
            this.mtxbCpf.Mask = "000,000,000-00";
            this.mtxbCpf.Name = "mtxbCpf";
            this.mtxbCpf.Size = new System.Drawing.Size(106, 20);
            this.mtxbCpf.TabIndex = 6;
            this.mtxbCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(225, 276);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(106, 20);
            this.txbNome.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(225, 299);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 37);
            this.textBox1.TabIndex = 8;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(73, 420);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(152, 42);
            this.btnVerificar.TabIndex = 9;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdade.Location = new System.Drawing.Point(82, 231);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(106, 20);
            this.lblIdade.TabIndex = 10;
            this.lblIdade.Text = "Digite sua Idade";
            // 
            // nudIdade
            // 
            this.nudIdade.Location = new System.Drawing.Point(225, 231);
            this.nudIdade.Name = "nudIdade";
            this.nudIdade.Size = new System.Drawing.Size(49, 20);
            this.nudIdade.TabIndex = 11;
            this.nudIdade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(283, 420);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(151, 42);
            this.btnComprar.TabIndex = 12;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            // 
            // txbTotal
            // 
            this.txbTotal.Location = new System.Drawing.Point(225, 342);
            this.txbTotal.Name = "txbTotal";
            this.txbTotal.Size = new System.Drawing.Size(106, 20);
            this.txbTotal.TabIndex = 13;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.Location = new System.Drawing.Point(82, 340);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(72, 20);
            this.lblValorTotal.TabIndex = 14;
            this.lblValorTotal.Text = "Valor Total";
            // 
            // frmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 518);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.txbTotal);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.nudIdade);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.mtxbCpf);
            this.Controls.Add(this.lblN4);
            this.Controls.Add(this.lblN3);
            this.Controls.Add(this.lblN2);
            this.Controls.Add(this.lblN1);
            this.Controls.Add(this.lbLivros);
            this.Name = "frmList";
            this.Text = "INDEX";
            ((System.ComponentModel.ISupportInitialize)(this.nudIdade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbLivros;
        private System.Windows.Forms.Label lblN1;
        private System.Windows.Forms.Label lblN2;
        private System.Windows.Forms.Label lblN3;
        private System.Windows.Forms.Label lblN4;
        private System.Windows.Forms.MaskedTextBox mtxbCpf;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.NumericUpDown nudIdade;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.TextBox txbTotal;
        private System.Windows.Forms.Label lblValorTotal;
    }
}

