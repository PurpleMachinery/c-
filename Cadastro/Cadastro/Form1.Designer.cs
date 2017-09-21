namespace Cadastro
{
    partial class frmCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSobrenome = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.txbSobrenome = new System.Windows.Forms.TextBox();
            this.txbIdade = new System.Windows.Forms.TextBox();
            this.txbSálario = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(40, 19);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblSobrenome
            // 
            this.lblSobrenome.AutoSize = true;
            this.lblSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSobrenome.Location = new System.Drawing.Point(40, 45);
            this.lblSobrenome.Name = "lblSobrenome";
            this.lblSobrenome.Size = new System.Drawing.Size(61, 13);
            this.lblSobrenome.TabIndex = 1;
            this.lblSobrenome.Text = "Sobrenome";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdade.Location = new System.Drawing.Point(39, 71);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(34, 13);
            this.lblIdade.TabIndex = 2;
            this.lblIdade.Text = "Idade";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(39, 99);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(39, 13);
            this.lblSalario.TabIndex = 3;
            this.lblSalario.Text = "Sálario";
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVerificar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnVerificar.FlatAppearance.BorderSize = 10;
            this.btnVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.Location = new System.Drawing.Point(11, 226);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(498, 276);
            this.btnVerificar.TabIndex = 4;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // txbNome
            // 
            this.txbNome.BackColor = System.Drawing.Color.White;
            this.txbNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNome.Location = new System.Drawing.Point(117, 12);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(887, 20);
            this.txbNome.TabIndex = 5;
            this.txbNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbSobrenome
            // 
            this.txbSobrenome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbSobrenome.Location = new System.Drawing.Point(117, 41);
            this.txbSobrenome.Name = "txbSobrenome";
            this.txbSobrenome.Size = new System.Drawing.Size(887, 20);
            this.txbSobrenome.TabIndex = 6;
            this.txbSobrenome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbIdade
            // 
            this.txbIdade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbIdade.Location = new System.Drawing.Point(117, 68);
            this.txbIdade.Name = "txbIdade";
            this.txbIdade.Size = new System.Drawing.Size(887, 20);
            this.txbIdade.TabIndex = 7;
            this.txbIdade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbSálario
            // 
            this.txbSálario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbSálario.Location = new System.Drawing.Point(117, 95);
            this.txbSálario.Name = "txbSálario";
            this.txbSálario.Size = new System.Drawing.Size(887, 20);
            this.txbSálario.TabIndex = 8;
            this.txbSálario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpar.FlatAppearance.BorderSize = 10;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(515, 226);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(498, 276);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1025, 597);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txbSálario);
            this.Controls.Add(this.txbIdade);
            this.Controls.Add(this.txbSobrenome);
            this.Controls.Add(this.txbNome);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.lblSobrenome);
            this.Controls.Add(this.lblNome);
            this.Name = "frmCadastro";
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSobrenome;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.TextBox txbSobrenome;
        private System.Windows.Forms.TextBox txbIdade;
        private System.Windows.Forms.TextBox txbSálario;
        private System.Windows.Forms.Button btnLimpar;

    }
}

