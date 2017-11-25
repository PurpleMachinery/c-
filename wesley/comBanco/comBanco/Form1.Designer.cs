namespace comBanco
{
    partial class frmComBanco
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComBanco));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.msCentral = new System.Windows.Forms.MenuStrip();
            this.msoOpcoes = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiFonecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsiSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsiSair = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnFornecedores = new System.Windows.Forms.ToolStripButton();
            this.btnProdutos = new System.Windows.Forms.ToolStripButton();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.statusData = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.msCentral.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusData,
            this.statusHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 485);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(982, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // msCentral
            // 
            this.msCentral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msoOpcoes});
            this.msCentral.Location = new System.Drawing.Point(0, 0);
            this.msCentral.Name = "msCentral";
            this.msCentral.Size = new System.Drawing.Size(982, 24);
            this.msCentral.TabIndex = 2;
            this.msCentral.Text = "menuStrip1";
            // 
            // msoOpcoes
            // 
            this.msoOpcoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsiFonecedores,
            this.tsiProdutos,
            this.tsiSobre,
            this.toolStripSeparator1,
            this.tsiSair});
            this.msoOpcoes.Name = "msoOpcoes";
            this.msoOpcoes.Size = new System.Drawing.Size(59, 20);
            this.msoOpcoes.Text = "Opções";
            // 
            // tsiFonecedores
            // 
            this.tsiFonecedores.Name = "tsiFonecedores";
            this.tsiFonecedores.Size = new System.Drawing.Size(152, 22);
            this.tsiFonecedores.Text = "Fornecedores";
            this.tsiFonecedores.Click += new System.EventHandler(this.tsiFonecedores_Click);
            // 
            // tsiProdutos
            // 
            this.tsiProdutos.Name = "tsiProdutos";
            this.tsiProdutos.Size = new System.Drawing.Size(152, 22);
            this.tsiProdutos.Text = "Produtos";
            this.tsiProdutos.Click += new System.EventHandler(this.tsiProdutos_Click);
            // 
            // tsiSobre
            // 
            this.tsiSobre.Name = "tsiSobre";
            this.tsiSobre.Size = new System.Drawing.Size(152, 22);
            this.tsiSobre.Text = "Sobre";
            this.tsiSobre.Click += new System.EventHandler(this.tsiSobre_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // tsiSair
            // 
            this.tsiSair.Name = "tsiSair";
            this.tsiSair.Size = new System.Drawing.Size(152, 22);
            this.tsiSair.Text = "Sair";
            this.tsiSair.Click += new System.EventHandler(this.tsiSair_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFornecedores,
            this.btnProdutos,
            this.btnSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(982, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnFornecedores
            // 
            this.btnFornecedores.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFornecedores.Image = ((System.Drawing.Image)(resources.GetObject("btnFornecedores.Image")));
            this.btnFornecedores.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFornecedores.Name = "btnFornecedores";
            this.btnFornecedores.Size = new System.Drawing.Size(23, 22);
            this.btnFornecedores.Text = "toolStripButton1";
            this.btnFornecedores.Click += new System.EventHandler(this.btnFornecedores_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnProdutos.Image = ((System.Drawing.Image)(resources.GetObject("btnProdutos.Image")));
            this.btnProdutos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(23, 22);
            this.btnProdutos.Text = "toolStripButton2";
            this.btnProdutos.Click += new System.EventHandler(this.btnProdutos_Click);
            // 
            // btnSair
            // 
            this.btnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(23, 22);
            this.btnSair.Text = "toolStripButton3";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // statusData
            // 
            this.statusData.Name = "statusData";
            this.statusData.Size = new System.Drawing.Size(37, 17);
            this.statusData.Text = "Data :";
            // 
            // statusHora
            // 
            this.statusHora.Name = "statusHora";
            this.statusHora.Size = new System.Drawing.Size(39, 17);
            this.statusHora.Text = "Hora: ";
            // 
            // frmComBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 507);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.msCentral);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msCentral;
            this.Name = "frmComBanco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmComBanco_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.msCentral.ResumeLayout(false);
            this.msCentral.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip msCentral;
        private System.Windows.Forms.ToolStripMenuItem msoOpcoes;
        private System.Windows.Forms.ToolStripMenuItem tsiFonecedores;
        private System.Windows.Forms.ToolStripMenuItem tsiProdutos;
        private System.Windows.Forms.ToolStripMenuItem tsiSobre;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsiSair;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnFornecedores;
        private System.Windows.Forms.ToolStripButton btnProdutos;
        private System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ToolStripStatusLabel statusData;
        private System.Windows.Forms.ToolStripStatusLabel statusHora;
    }
}

