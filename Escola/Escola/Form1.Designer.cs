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
            this.msMenu.SuspendLayout();
            this.toolStrip1.SuspendLayout();
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
            this.alunosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.alunosToolStripMenuItem.Text = "Alunos";
            this.alunosToolStripMenuItem.Click += new System.EventHandler(this.alunosToolStripMenuItem_Click);
            // 
            // disciplinaToolStripMenuItem
            // 
            this.disciplinaToolStripMenuItem.Name = "disciplinaToolStripMenuItem";
            this.disciplinaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.disciplinaToolStripMenuItem.Text = "Disciplina";
            this.disciplinaToolStripMenuItem.Click += new System.EventHandler(this.disciplinaToolStripMenuItem_Click);
            // 
            // mençãoToolStripMenuItem
            // 
            this.mençãoToolStripMenuItem.Name = "mençãoToolStripMenuItem";
            this.mençãoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mençãoToolStripMenuItem.Text = "Menção";
            this.mençãoToolStripMenuItem.Click += new System.EventHandler(this.mençãoToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAlunos,
            this.tsbDisciplina,
            this.tsbMencoes});
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
            // frmEscola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 453);
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
    }
}

