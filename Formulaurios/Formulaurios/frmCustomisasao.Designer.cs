namespace WindowsFormsApplication1
{
    partial class frmCustom
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
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblResidencial = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.txbCliente = new System.Windows.Forms.TextBox();
            this.mtbRG = new System.Windows.Forms.MaskedTextBox();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.mtbResidencial = new System.Windows.Forms.MaskedTextBox();
            this.mtbCelular = new System.Windows.Forms.MaskedTextBox();
            this.txbModelo = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.lblCorO = new System.Windows.Forms.Label();
            this.txbCorO = new System.Windows.Forms.TextBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.cbAno = new System.Windows.Forms.ComboBox();
            this.lblCambio = new System.Windows.Forms.Label();
            this.rbManual = new System.Windows.Forms.RadioButton();
            this.rbAuto = new System.Windows.Forms.RadioButton();
            this.lblServicos = new System.Windows.Forms.Label();
            this.cbServicos = new System.Windows.Forms.ComboBox();
            this.lblServicosEValores = new System.Windows.Forms.Label();
            this.ckbCarroceria = new System.Windows.Forms.CheckBox();
            this.ckbInterior = new System.Windows.Forms.CheckBox();
            this.ckbSuspencao = new System.Windows.Forms.CheckBox();
            this.ckbMotor = new System.Windows.Forms.CheckBox();
            this.lblApresentar = new System.Windows.Forms.Label();
            this.lblRetirar = new System.Windows.Forms.Label();
            this.mtbDataApre = new System.Windows.Forms.MaskedTextBox();
            this.mtbDataReti = new System.Windows.Forms.MaskedTextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.txbValorTotal = new System.Windows.Forms.TextBox();
            this.btnVerificarTotal = new System.Windows.Forms.Button();
            this.btnSolicitar = new System.Windows.Forms.Button();
            this.lblN = new System.Windows.Forms.Label();
            this.txbN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(13, 13);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(88, 13);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Nome do Cliente:";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(12, 53);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(26, 13);
            this.lblRG.TabIndex = 1;
            this.lblRG.Text = "RG:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(13, 93);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 2;
            this.lblCPF.Text = "CPF:";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(12, 133);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(56, 13);
            this.lblEndereco.TabIndex = 3;
            this.lblEndereco.Text = "Endereço:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(10, 183);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(52, 13);
            this.lblTelefone.TabIndex = 4;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblResidencial
            // 
            this.lblResidencial.AutoSize = true;
            this.lblResidencial.Location = new System.Drawing.Point(10, 208);
            this.lblResidencial.Name = "lblResidencial";
            this.lblResidencial.Size = new System.Drawing.Size(65, 13);
            this.lblResidencial.TabIndex = 5;
            this.lblResidencial.Text = "Residencial:";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(11, 235);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(42, 13);
            this.lblCelular.TabIndex = 6;
            this.lblCelular.Text = "Celular:";
            // 
            // txbCliente
            // 
            this.txbCliente.Location = new System.Drawing.Point(13, 30);
            this.txbCliente.Name = "txbCliente";
            this.txbCliente.Size = new System.Drawing.Size(115, 20);
            this.txbCliente.TabIndex = 7;
            // 
            // mtbRG
            // 
            this.mtbRG.Location = new System.Drawing.Point(13, 70);
            this.mtbRG.Name = "mtbRG";
            this.mtbRG.Size = new System.Drawing.Size(115, 20);
            this.mtbRG.TabIndex = 8;
            // 
            // mtbCPF
            // 
            this.mtbCPF.Location = new System.Drawing.Point(14, 110);
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(115, 20);
            this.mtbCPF.TabIndex = 9;
            // 
            // txbEndereco
            // 
            this.txbEndereco.Location = new System.Drawing.Point(13, 150);
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(115, 20);
            this.txbEndereco.TabIndex = 10;
            // 
            // mtbResidencial
            // 
            this.mtbResidencial.Location = new System.Drawing.Point(81, 208);
            this.mtbResidencial.Name = "mtbResidencial";
            this.mtbResidencial.Size = new System.Drawing.Size(100, 20);
            this.mtbResidencial.TabIndex = 11;
            // 
            // mtbCelular
            // 
            this.mtbCelular.Location = new System.Drawing.Point(81, 235);
            this.mtbCelular.Name = "mtbCelular";
            this.mtbCelular.Size = new System.Drawing.Size(100, 20);
            this.mtbCelular.TabIndex = 12;
            // 
            // txbModelo
            // 
            this.txbModelo.Location = new System.Drawing.Point(235, 29);
            this.txbModelo.Name = "txbModelo";
            this.txbModelo.Size = new System.Drawing.Size(115, 20);
            this.txbModelo.TabIndex = 13;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(235, 12);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(88, 13);
            this.lblModelo.TabIndex = 14;
            this.lblModelo.Text = "Modelo do Carro:";
            // 
            // lblCorO
            // 
            this.lblCorO.AutoSize = true;
            this.lblCorO.Location = new System.Drawing.Point(235, 76);
            this.lblCorO.Name = "lblCorO";
            this.lblCorO.Size = new System.Drawing.Size(64, 13);
            this.lblCorO.TabIndex = 15;
            this.lblCorO.Text = "Cor Original:";
            // 
            // txbCorO
            // 
            this.txbCorO.Location = new System.Drawing.Point(235, 90);
            this.txbCorO.Name = "txbCorO";
            this.txbCorO.Size = new System.Drawing.Size(115, 20);
            this.txbCorO.TabIndex = 16;
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(235, 133);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(97, 13);
            this.lblAno.TabIndex = 17;
            this.lblAno.Text = "Ano do Automóvel:";
            // 
            // cbAno
            // 
            this.cbAno.FormattingEnabled = true;
            this.cbAno.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018"});
            this.cbAno.Location = new System.Drawing.Point(235, 149);
            this.cbAno.Name = "cbAno";
            this.cbAno.Size = new System.Drawing.Size(121, 21);
            this.cbAno.TabIndex = 18;
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Location = new System.Drawing.Point(235, 208);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(45, 13);
            this.lblCambio.TabIndex = 19;
            this.lblCambio.Text = "Câmbio:";
            // 
            // rbManual
            // 
            this.rbManual.AutoSize = true;
            this.rbManual.Location = new System.Drawing.Point(238, 230);
            this.rbManual.Name = "rbManual";
            this.rbManual.Size = new System.Drawing.Size(60, 17);
            this.rbManual.TabIndex = 20;
            this.rbManual.TabStop = true;
            this.rbManual.Text = "Manual";
            this.rbManual.UseVisualStyleBackColor = true;
            // 
            // rbAuto
            // 
            this.rbAuto.AutoSize = true;
            this.rbAuto.Location = new System.Drawing.Point(238, 249);
            this.rbAuto.Name = "rbAuto";
            this.rbAuto.Size = new System.Drawing.Size(78, 17);
            this.rbAuto.TabIndex = 21;
            this.rbAuto.TabStop = true;
            this.rbAuto.Text = "Automático";
            this.rbAuto.UseVisualStyleBackColor = true;
            // 
            // lblServicos
            // 
            this.lblServicos.AutoSize = true;
            this.lblServicos.Location = new System.Drawing.Point(474, 12);
            this.lblServicos.Name = "lblServicos";
            this.lblServicos.Size = new System.Drawing.Size(48, 13);
            this.lblServicos.TabIndex = 22;
            this.lblServicos.Text = "Serviços";
            // 
            // cbServicos
            // 
            this.cbServicos.FormattingEnabled = true;
            this.cbServicos.Items.AddRange(new object[] {
            "Troca de Óleo - R$ 16",
            "Troca do Filtro - R$ 5",
            "Troca de Báteria - R$ 300"});
            this.cbServicos.Location = new System.Drawing.Point(477, 28);
            this.cbServicos.Name = "cbServicos";
            this.cbServicos.Size = new System.Drawing.Size(121, 21);
            this.cbServicos.TabIndex = 23;
            // 
            // lblServicosEValores
            // 
            this.lblServicosEValores.AutoSize = true;
            this.lblServicosEValores.Location = new System.Drawing.Point(477, 76);
            this.lblServicosEValores.Name = "lblServicosEValores";
            this.lblServicosEValores.Size = new System.Drawing.Size(98, 13);
            this.lblServicosEValores.TabIndex = 24;
            this.lblServicosEValores.Text = "Serviços e Valores:";
            // 
            // ckbCarroceria
            // 
            this.ckbCarroceria.AutoSize = true;
            this.ckbCarroceria.Location = new System.Drawing.Point(477, 93);
            this.ckbCarroceria.Name = "ckbCarroceria";
            this.ckbCarroceria.Size = new System.Drawing.Size(133, 17);
            this.ckbCarroceria.TabIndex = 25;
            this.ckbCarroceria.Text = "Carroceria - R$ 599.00";
            this.ckbCarroceria.UseVisualStyleBackColor = true;
            // 
            // ckbInterior
            // 
            this.ckbInterior.AutoSize = true;
            this.ckbInterior.Location = new System.Drawing.Point(477, 113);
            this.ckbInterior.Name = "ckbInterior";
            this.ckbInterior.Size = new System.Drawing.Size(187, 17);
            this.ckbInterior.TabIndex = 26;
            this.ckbInterior.Text = "Interior / Estofamento - R$ 850.00";
            this.ckbInterior.UseVisualStyleBackColor = true;
            // 
            // ckbSuspencao
            // 
            this.ckbSuspencao.AutoSize = true;
            this.ckbSuspencao.Location = new System.Drawing.Point(477, 132);
            this.ckbSuspencao.Name = "ckbSuspencao";
            this.ckbSuspencao.Size = new System.Drawing.Size(138, 17);
            this.ckbSuspencao.TabIndex = 27;
            this.ckbSuspencao.Text = "Suspensão - R$ 450.00";
            this.ckbSuspencao.UseVisualStyleBackColor = true;
            // 
            // ckbMotor
            // 
            this.ckbMotor.AutoSize = true;
            this.ckbMotor.Location = new System.Drawing.Point(477, 153);
            this.ckbMotor.Name = "ckbMotor";
            this.ckbMotor.Size = new System.Drawing.Size(150, 17);
            this.ckbMotor.TabIndex = 28;
            this.ckbMotor.Text = "Motor e outros - R$799.00";
            this.ckbMotor.UseVisualStyleBackColor = true;
            // 
            // lblApresentar
            // 
            this.lblApresentar.AutoSize = true;
            this.lblApresentar.Location = new System.Drawing.Point(459, 203);
            this.lblApresentar.Name = "lblApresentar";
            this.lblApresentar.Size = new System.Drawing.Size(99, 13);
            this.lblApresentar.TabIndex = 29;
            this.lblApresentar.Text = "Apresentar Veiculo:";
            // 
            // lblRetirar
            // 
            this.lblRetirar.AutoSize = true;
            this.lblRetirar.Location = new System.Drawing.Point(459, 222);
            this.lblRetirar.Name = "lblRetirar";
            this.lblRetirar.Size = new System.Drawing.Size(82, 13);
            this.lblRetirar.TabIndex = 30;
            this.lblRetirar.Text = "Retirar Veiculo: ";
            // 
            // mtbDataApre
            // 
            this.mtbDataApre.Location = new System.Drawing.Point(564, 200);
            this.mtbDataApre.Name = "mtbDataApre";
            this.mtbDataApre.Size = new System.Drawing.Size(100, 20);
            this.mtbDataApre.TabIndex = 31;
            // 
            // mtbDataReti
            // 
            this.mtbDataReti.Location = new System.Drawing.Point(564, 222);
            this.mtbDataReti.Name = "mtbDataReti";
            this.mtbDataReti.Size = new System.Drawing.Size(100, 20);
            this.mtbDataReti.TabIndex = 32;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(422, 277);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(101, 13);
            this.lblValorTotal.TabIndex = 33;
            this.lblValorTotal.Text = "Valor Total à Pagar:";
            // 
            // txbValorTotal
            // 
            this.txbValorTotal.Location = new System.Drawing.Point(422, 294);
            this.txbValorTotal.Name = "txbValorTotal";
            this.txbValorTotal.Size = new System.Drawing.Size(176, 20);
            this.txbValorTotal.TabIndex = 34;
            // 
            // btnVerificarTotal
            // 
            this.btnVerificarTotal.Location = new System.Drawing.Point(615, 292);
            this.btnVerificarTotal.Name = "btnVerificarTotal";
            this.btnVerificarTotal.Size = new System.Drawing.Size(100, 23);
            this.btnVerificarTotal.TabIndex = 35;
            this.btnVerificarTotal.Text = "Verificar Total";
            this.btnVerificarTotal.UseVisualStyleBackColor = true;
            this.btnVerificarTotal.Click += new System.EventHandler(this.btnVerificarTotal_Click);
            // 
            // btnSolicitar
            // 
            this.btnSolicitar.Location = new System.Drawing.Point(615, 322);
            this.btnSolicitar.Name = "btnSolicitar";
            this.btnSolicitar.Size = new System.Drawing.Size(100, 23);
            this.btnSolicitar.TabIndex = 36;
            this.btnSolicitar.Text = "Solicitar Serviços";
            this.btnSolicitar.UseVisualStyleBackColor = true;
            // 
            // lblN
            // 
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(142, 132);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(22, 13);
            this.lblN.TabIndex = 37;
            this.lblN.Text = "N°:";
            // 
            // txbN
            // 
            this.txbN.Location = new System.Drawing.Point(141, 149);
            this.txbN.Name = "txbN";
            this.txbN.Size = new System.Drawing.Size(57, 20);
            this.txbN.TabIndex = 38;
            // 
            // frmCustom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 357);
            this.Controls.Add(this.txbN);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.btnSolicitar);
            this.Controls.Add(this.btnVerificarTotal);
            this.Controls.Add(this.txbValorTotal);
            this.Controls.Add(this.lblValorTotal);
            this.Controls.Add(this.mtbDataReti);
            this.Controls.Add(this.mtbDataApre);
            this.Controls.Add(this.lblRetirar);
            this.Controls.Add(this.lblApresentar);
            this.Controls.Add(this.ckbMotor);
            this.Controls.Add(this.ckbSuspencao);
            this.Controls.Add(this.ckbInterior);
            this.Controls.Add(this.ckbCarroceria);
            this.Controls.Add(this.lblServicosEValores);
            this.Controls.Add(this.cbServicos);
            this.Controls.Add(this.lblServicos);
            this.Controls.Add(this.rbAuto);
            this.Controls.Add(this.rbManual);
            this.Controls.Add(this.lblCambio);
            this.Controls.Add(this.cbAno);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.txbCorO);
            this.Controls.Add(this.lblCorO);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.txbModelo);
            this.Controls.Add(this.mtbCelular);
            this.Controls.Add(this.mtbResidencial);
            this.Controls.Add(this.txbEndereco);
            this.Controls.Add(this.mtbCPF);
            this.Controls.Add(this.mtbRG);
            this.Controls.Add(this.txbCliente);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.lblResidencial);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblRG);
            this.Controls.Add(this.lblCliente);
            this.Name = "frmCustom";
            this.Text = "Customisação";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblResidencial;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.TextBox txbCliente;
        private System.Windows.Forms.MaskedTextBox mtbRG;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.MaskedTextBox mtbResidencial;
        private System.Windows.Forms.MaskedTextBox mtbCelular;
        private System.Windows.Forms.TextBox txbModelo;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.Label lblCorO;
        private System.Windows.Forms.TextBox txbCorO;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.ComboBox cbAno;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.RadioButton rbManual;
        private System.Windows.Forms.RadioButton rbAuto;
        private System.Windows.Forms.Label lblServicos;
        private System.Windows.Forms.ComboBox cbServicos;
        private System.Windows.Forms.Label lblServicosEValores;
        private System.Windows.Forms.CheckBox ckbCarroceria;
        private System.Windows.Forms.CheckBox ckbInterior;
        private System.Windows.Forms.CheckBox ckbSuspencao;
        private System.Windows.Forms.CheckBox ckbMotor;
        private System.Windows.Forms.Label lblApresentar;
        private System.Windows.Forms.Label lblRetirar;
        private System.Windows.Forms.MaskedTextBox mtbDataApre;
        private System.Windows.Forms.MaskedTextBox mtbDataReti;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.TextBox txbValorTotal;
        private System.Windows.Forms.Button btnVerificarTotal;
        private System.Windows.Forms.Button btnSolicitar;
        private System.Windows.Forms.Label lblN;
        private System.Windows.Forms.TextBox txbN;
    }
}