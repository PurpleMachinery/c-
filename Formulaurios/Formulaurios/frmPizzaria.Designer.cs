namespace WindowsFormsApplication1
{
    partial class frmPizzaria
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
            this.cbSabor = new System.Windows.Forms.ComboBox();
            this.lblSabor = new System.Windows.Forms.Label();
            this.lblBorda = new System.Windows.Forms.Label();
            this.rdbSem = new System.Windows.Forms.RadioButton();
            this.rdbCatupiri = new System.Windows.Forms.RadioButton();
            this.rdbCheddar = new System.Windows.Forms.RadioButton();
            this.txbEndereco = new System.Windows.Forms.TextBox();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblExtra = new System.Windows.Forms.Label();
            this.ckbMRecheio = new System.Windows.Forms.CheckBox();
            this.ckbBacon = new System.Windows.Forms.CheckBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblMR = new System.Windows.Forms.Label();
            this.lblMB = new System.Windows.Forms.Label();
            this.mtxbResult = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // cbSabor
            // 
            this.cbSabor.FormattingEnabled = true;
            this.cbSabor.Items.AddRange(new object[] {
            "Peperoni (R$ 21)",
            "Mussarela (R$ 19)",
            "Portuguesa (R$ 23)"});
            this.cbSabor.Location = new System.Drawing.Point(53, 43);
            this.cbSabor.Name = "cbSabor";
            this.cbSabor.Size = new System.Drawing.Size(240, 21);
            this.cbSabor.TabIndex = 0;
            // 
            // lblSabor
            // 
            this.lblSabor.AutoSize = true;
            this.lblSabor.Location = new System.Drawing.Point(12, 46);
            this.lblSabor.Name = "lblSabor";
            this.lblSabor.Size = new System.Drawing.Size(35, 13);
            this.lblSabor.TabIndex = 1;
            this.lblSabor.Text = "Sabor";
            // 
            // lblBorda
            // 
            this.lblBorda.AutoSize = true;
            this.lblBorda.Location = new System.Drawing.Point(11, 101);
            this.lblBorda.Name = "lblBorda";
            this.lblBorda.Size = new System.Drawing.Size(35, 13);
            this.lblBorda.TabIndex = 2;
            this.lblBorda.Text = "Borda";
            // 
            // rdbSem
            // 
            this.rdbSem.AutoSize = true;
            this.rdbSem.Location = new System.Drawing.Point(62, 99);
            this.rdbSem.Name = "rdbSem";
            this.rdbSem.Size = new System.Drawing.Size(71, 17);
            this.rdbSem.TabIndex = 3;
            this.rdbSem.TabStop = true;
            this.rdbSem.Text = "Nenhuma";
            this.rdbSem.UseVisualStyleBackColor = true;
            // 
            // rdbCatupiri
            // 
            this.rdbCatupiri.AutoSize = true;
            this.rdbCatupiri.Location = new System.Drawing.Point(140, 99);
            this.rdbCatupiri.Name = "rdbCatupiri";
            this.rdbCatupiri.Size = new System.Drawing.Size(60, 17);
            this.rdbCatupiri.TabIndex = 4;
            this.rdbCatupiri.TabStop = true;
            this.rdbCatupiri.Text = "Catupiri";
            this.rdbCatupiri.UseVisualStyleBackColor = true;
            // 
            // rdbCheddar
            // 
            this.rdbCheddar.AutoSize = true;
            this.rdbCheddar.Location = new System.Drawing.Point(207, 99);
            this.rdbCheddar.Name = "rdbCheddar";
            this.rdbCheddar.Size = new System.Drawing.Size(65, 17);
            this.rdbCheddar.TabIndex = 5;
            this.rdbCheddar.TabStop = true;
            this.rdbCheddar.Text = "Cheddar";
            this.rdbCheddar.UseVisualStyleBackColor = true;
            // 
            // txbEndereco
            // 
            this.txbEndereco.Location = new System.Drawing.Point(75, 204);
            this.txbEndereco.Multiline = true;
            this.txbEndereco.Name = "txbEndereco";
            this.txbEndereco.Size = new System.Drawing.Size(222, 77);
            this.txbEndereco.TabIndex = 6;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Location = new System.Drawing.Point(15, 236);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(53, 13);
            this.lblEndereco.TabIndex = 7;
            this.lblEndereco.Text = "Endereço";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "(R$ 3)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "(R$ 4)";
            // 
            // lblExtra
            // 
            this.lblExtra.AutoSize = true;
            this.lblExtra.Location = new System.Drawing.Point(15, 160);
            this.lblExtra.Name = "lblExtra";
            this.lblExtra.Size = new System.Drawing.Size(31, 13);
            this.lblExtra.TabIndex = 10;
            this.lblExtra.Text = "Extra";
            // 
            // ckbMRecheio
            // 
            this.ckbMRecheio.AutoSize = true;
            this.ckbMRecheio.Location = new System.Drawing.Point(62, 160);
            this.ckbMRecheio.Name = "ckbMRecheio";
            this.ckbMRecheio.Size = new System.Drawing.Size(72, 17);
            this.ckbMRecheio.TabIndex = 11;
            this.ckbMRecheio.Text = "+Recheio";
            this.ckbMRecheio.UseVisualStyleBackColor = true;
            // 
            // ckbBacon
            // 
            this.ckbBacon.AutoSize = true;
            this.ckbBacon.Location = new System.Drawing.Point(140, 160);
            this.ckbBacon.Name = "ckbBacon";
            this.ckbBacon.Size = new System.Drawing.Size(57, 17);
            this.ckbBacon.TabIndex = 12;
            this.ckbBacon.Text = "Bacon";
            this.ckbBacon.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(88, 302);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(129, 35);
            this.btnCalcular.TabIndex = 13;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblMR
            // 
            this.lblMR.AutoSize = true;
            this.lblMR.Location = new System.Drawing.Point(85, 180);
            this.lblMR.Name = "lblMR";
            this.lblMR.Size = new System.Drawing.Size(36, 13);
            this.lblMR.TabIndex = 14;
            this.lblMR.Text = "(R$ 6)";
            // 
            // lblMB
            // 
            this.lblMB.AutoSize = true;
            this.lblMB.Location = new System.Drawing.Point(158, 181);
            this.lblMB.Name = "lblMB";
            this.lblMB.Size = new System.Drawing.Size(36, 13);
            this.lblMB.TabIndex = 15;
            this.lblMB.Text = "(R$ 7)";
            // 
            // mtxbResult
            // 
            this.mtxbResult.Enabled = false;
            this.mtxbResult.Location = new System.Drawing.Point(88, 380);
            this.mtxbResult.Mask = "$ 00000";
            this.mtxbResult.Name = "mtxbResult";
            this.mtxbResult.Size = new System.Drawing.Size(100, 20);
            this.mtxbResult.TabIndex = 16;
            // 
            // frmPizzaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 455);
            this.Controls.Add(this.mtxbResult);
            this.Controls.Add(this.lblMB);
            this.Controls.Add(this.lblMR);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.ckbBacon);
            this.Controls.Add(this.ckbMRecheio);
            this.Controls.Add(this.lblExtra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.txbEndereco);
            this.Controls.Add(this.rdbCheddar);
            this.Controls.Add(this.rdbCatupiri);
            this.Controls.Add(this.rdbSem);
            this.Controls.Add(this.lblBorda);
            this.Controls.Add(this.lblSabor);
            this.Controls.Add(this.cbSabor);
            this.Name = "frmPizzaria";
            this.Text = "Pizza";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSabor;
        private System.Windows.Forms.Label lblSabor;
        private System.Windows.Forms.Label lblBorda;
        private System.Windows.Forms.RadioButton rdbSem;
        private System.Windows.Forms.RadioButton rdbCatupiri;
        private System.Windows.Forms.RadioButton rdbCheddar;
        private System.Windows.Forms.TextBox txbEndereco;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblExtra;
        private System.Windows.Forms.CheckBox ckbMRecheio;
        private System.Windows.Forms.CheckBox ckbBacon;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblMR;
        private System.Windows.Forms.Label lblMB;
        private System.Windows.Forms.MaskedTextBox mtxbResult;
    }
}