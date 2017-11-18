namespace Escola
{
    partial class frmEscola
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEscola));
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disciplinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mençãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAlunos = new System.Windows.Forms.ToolStripButton();
            this.tsbDisciplina = new System.Windows.Forms.ToolStripButton();
            this.tsbMencoes = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.msMenu.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(1016, 24);
            this.msMenu.TabIndex = 1;
            this.msMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunosToolStripMenuItem,
            this.disciplinaToolStripMenuItem,
            this.mençãoToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // alunosToolStripMenuItem
            // 
            this.alunosToolStripMenuItem.Name = "alunosToolStripMenuItem";
            this.alunosToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.alunosToolStripMenuItem.Text = "Alunos";
            this.alunosToolStripMenuItem.Click += new System.EventHandler(this.alunosToolStripMenuItem_Click);
            // 
            // disciplinaToolStripMenuItem
            // 
            this.disciplinaToolStripMenuItem.Name = "disciplinaToolStripMenuItem";
            this.disciplinaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.disciplinaToolStripMenuItem.Text = "Disciplina";
            this.disciplinaToolStripMenuItem.Click += new System.EventHandler(this.disciplinaToolStripMenuItem_Click);
            // 
            // mençãoToolStripMenuItem
            // 
            this.mençãoToolStripMenuItem.Name = "mençãoToolStripMenuItem";
            this.mençãoToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.mençãoToolStripMenuItem.Text = "Menção";
            this.mençãoToolStripMenuItem.Click += new System.EventHandler(this.mençãoToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAlunos,
            this.tsbDisciplina,
            this.tsbMencoes,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1016, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAlunos
            // 
            this.tsbAlunos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAlunos.Image = ((System.Drawing.Image)(resources.GetObject("tsbAlunos.Image")));
            this.tsbAlunos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAlunos.Name = "tsbAlunos";
            this.tsbAlunos.Size = new System.Drawing.Size(23, 22);
            this.tsbAlunos.Text = "toolStripButton1";
            this.tsbAlunos.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsbDisciplina
            // 
            this.tsbDisciplina.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDisciplina.Image = ((System.Drawing.Image)(resources.GetObject("tsbDisciplina.Image")));
            this.tsbDisciplina.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDisciplina.Name = "tsbDisciplina";
            this.tsbDisciplina.Size = new System.Drawing.Size(23, 22);
            this.tsbDisciplina.Text = "toolStripButton2";
            this.tsbDisciplina.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // tsbMencoes
            // 
            this.tsbMencoes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbMencoes.Image = ((System.Drawing.Image)(resources.GetObject("tsbMencoes.Image")));
            this.tsbMencoes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMencoes.Name = "tsbMencoes";
            this.tsbMencoes.Size = new System.Drawing.Size(23, 22);
            this.tsbMencoes.Text = "toolStripButton3";
            this.tsbMencoes.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 431);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1016, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblHora
            // 
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(39, 17);
            this.lblHora.Text = "Hora: ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmEscola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 453);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.msMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMenu;
            this.Name = "frmEscola";
            this.Text = "Escola";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disciplinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mençãoToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAlunos;
        private System.Windows.Forms.ToolStripButton tsbDisciplina;
        private System.Windows.Forms.ToolStripButton tsbMencoes;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblHora;
        private System.Windows.Forms.Timer timer1;
    }
}

