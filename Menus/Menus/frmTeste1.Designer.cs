namespace Menus
{
    partial class frmTeste1
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
            this.lblAmendoins = new System.Windows.Forms.Label();
            this.btnGA = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.lblX = new System.Windows.Forms.Label();
            this.lblCusto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAmendoins
            // 
            this.lblAmendoins.AutoSize = true;
            this.lblAmendoins.Location = new System.Drawing.Point(44, 26);
            this.lblAmendoins.Name = "lblAmendoins";
            this.lblAmendoins.Size = new System.Drawing.Size(65, 13);
            this.lblAmendoins.TabIndex = 0;
            this.lblAmendoins.Text = "Amendoins: ";
            // 
            // btnGA
            // 
            this.btnGA.Location = new System.Drawing.Point(47, 63);
            this.btnGA.Name = "btnGA";
            this.btnGA.Size = new System.Drawing.Size(99, 23);
            this.btnGA.TabIndex = 1;
            this.btnGA.Text = "Gerar Amendoin";
            this.btnGA.UseVisualStyleBackColor = true;
            this.btnGA.Click += new System.EventHandler(this.btnGA_Click);
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(47, 103);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(99, 23);
            this.btnUp.TabIndex = 2;
            this.btnUp.Text = "Upgradear";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(172, 68);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(43, 13);
            this.lblX.TabIndex = 3;
            this.lblX.Text = "Valor: 1";
            // 
            // lblCusto
            // 
            this.lblCusto.AutoSize = true;
            this.lblCusto.Location = new System.Drawing.Point(172, 108);
            this.lblCusto.Name = "lblCusto";
            this.lblCusto.Size = new System.Drawing.Size(46, 13);
            this.lblCusto.TabIndex = 4;
            this.lblCusto.Text = "Custo: ?";
            // 
            // frmTeste1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 410);
            this.Controls.Add(this.lblCusto);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnGA);
            this.Controls.Add(this.lblAmendoins);
            this.Name = "frmTeste1";
            this.Text = "frmTeste1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAmendoins;
        private System.Windows.Forms.Button btnGA;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblCusto;
    }
}