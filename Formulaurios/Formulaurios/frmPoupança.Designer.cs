namespace WindowsFormsApplication1
{
    partial class frmPoupança
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
            this.txbValor = new System.Windows.Forms.TextBox();
            this.lblValorPoupança = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.txbTaxa = new System.Windows.Forms.TextBox();
            this.lblMeses = new System.Windows.Forms.Label();
            this.txbMeses = new System.Windows.Forms.TextBox();
            this.txbResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbValor
            // 
            this.txbValor.Location = new System.Drawing.Point(111, 42);
            this.txbValor.Name = "txbValor";
            this.txbValor.Size = new System.Drawing.Size(134, 20);
            this.txbValor.TabIndex = 0;
            // 
            // lblValorPoupança
            // 
            this.lblValorPoupança.AutoSize = true;
            this.lblValorPoupança.Location = new System.Drawing.Point(12, 45);
            this.lblValorPoupança.Name = "lblValorPoupança";
            this.lblValorPoupança.Size = new System.Drawing.Size(82, 13);
            this.lblValorPoupança.TabIndex = 1;
            this.lblValorPoupança.Text = "Valor Constante";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(20, 72);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(68, 13);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "Taxa(%/100)";
            // 
            // txbTaxa
            // 
            this.txbTaxa.Location = new System.Drawing.Point(111, 69);
            this.txbTaxa.Name = "txbTaxa";
            this.txbTaxa.Size = new System.Drawing.Size(134, 20);
            this.txbTaxa.TabIndex = 3;
            // 
            // lblMeses
            // 
            this.lblMeses.AutoSize = true;
            this.lblMeses.Location = new System.Drawing.Point(38, 99);
            this.lblMeses.Name = "lblMeses";
            this.lblMeses.Size = new System.Drawing.Size(38, 13);
            this.lblMeses.TabIndex = 4;
            this.lblMeses.Text = "Meses";
            // 
            // txbMeses
            // 
            this.txbMeses.Location = new System.Drawing.Point(111, 96);
            this.txbMeses.Name = "txbMeses";
            this.txbMeses.Size = new System.Drawing.Size(134, 20);
            this.txbMeses.TabIndex = 5;
            // 
            // txbResult
            // 
            this.txbResult.Enabled = false;
            this.txbResult.Location = new System.Drawing.Point(41, 327);
            this.txbResult.Name = "txbResult";
            this.txbResult.Size = new System.Drawing.Size(204, 20);
            this.txbResult.TabIndex = 6;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(59, 293);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(170, 25);
            this.lblResult.TabIndex = 7;
            this.lblResult.Text = "Valor Programado";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(16, 148);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(125, 102);
            this.btnCalc.TabIndex = 8;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(145, 148);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(125, 102);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // frmPoupança
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 379);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txbResult);
            this.Controls.Add(this.txbMeses);
            this.Controls.Add(this.lblMeses);
            this.Controls.Add(this.txbTaxa);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblValorPoupança);
            this.Controls.Add(this.txbValor);
            this.Name = "frmPoupança";
            this.Text = "frmPoupança";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbValor;
        private System.Windows.Forms.Label lblValorPoupança;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txbTaxa;
        private System.Windows.Forms.Label lblMeses;
        private System.Windows.Forms.TextBox txbMeses;
        private System.Windows.Forms.TextBox txbResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
    }
}