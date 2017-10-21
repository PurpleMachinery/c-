namespace Menus
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.tsmJogosVisuais = new System.Windows.Forms.ToolStripMenuItem();
            this.stsAmendoin = new System.Windows.Forms.ToolStripMenuItem();
            this.stsSuperNet = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmVideoJogos = new System.Windows.Forms.ToolStripMenuItem();
            this.stsComminSon = new System.Windows.Forms.ToolStripMenuItem();
            this.tsPrincipal = new System.Windows.Forms.ToolStrip();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tss1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbLike = new System.Windows.Forms.ToolStripButton();
            this.tss2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbSair = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblData = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.msPrincipal.SuspendLayout();
            this.tsPrincipal.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // msPrincipal
            // 
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmJogosVisuais,
            this.tsmVideoJogos});
            this.msPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Size = new System.Drawing.Size(810, 24);
            this.msPrincipal.TabIndex = 1;
            this.msPrincipal.Text = "menuStrip1";
            // 
            // tsmJogosVisuais
            // 
            this.tsmJogosVisuais.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsAmendoin,
            this.stsSuperNet});
            this.tsmJogosVisuais.Name = "tsmJogosVisuais";
            this.tsmJogosVisuais.Size = new System.Drawing.Size(89, 20);
            this.tsmJogosVisuais.Text = "Jogos-visuais";
            // 
            // stsAmendoin
            // 
            this.stsAmendoin.BackColor = System.Drawing.Color.White;
            this.stsAmendoin.Name = "stsAmendoin";
            this.stsAmendoin.Size = new System.Drawing.Size(130, 22);
            this.stsAmendoin.Text = "Amendoin";
            this.stsAmendoin.Click += new System.EventHandler(this.amendoinToolStripMenuItem_Click);
            // 
            // stsSuperNet
            // 
            this.stsSuperNet.Name = "stsSuperNet";
            this.stsSuperNet.Size = new System.Drawing.Size(130, 22);
            this.stsSuperNet.Text = "Super-net";
            this.stsSuperNet.Click += new System.EventHandler(this.stsSuperNet_Click);
            // 
            // tsmVideoJogos
            // 
            this.tsmVideoJogos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stsComminSon});
            this.tsmVideoJogos.Name = "tsmVideoJogos";
            this.tsmVideoJogos.Size = new System.Drawing.Size(83, 20);
            this.tsmVideoJogos.Text = "Video-jogos";
            // 
            // stsComminSon
            // 
            this.stsComminSon.Name = "stsComminSon";
            this.stsComminSon.Size = new System.Drawing.Size(143, 22);
            this.stsComminSon.Text = "commin-son";
            // 
            // tsPrincipal
            // 
            this.tsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNew,
            this.tss1,
            this.tsbLike,
            this.tss2,
            this.tsbSair});
            this.tsPrincipal.Location = new System.Drawing.Point(0, 24);
            this.tsPrincipal.Name = "tsPrincipal";
            this.tsPrincipal.Size = new System.Drawing.Size(810, 25);
            this.tsPrincipal.TabIndex = 3;
            this.tsPrincipal.Text = "toolStrip1";
            // 
            // tsbNew
            // 
            this.tsbNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNew.Image = ((System.Drawing.Image)(resources.GetObject("tsbNew.Image")));
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(23, 22);
            this.tsbNew.Text = "toolStripButton2";
            this.tsbNew.ToolTipText = "Novo Formulario";
            this.tsbNew.Click += new System.EventHandler(this.tsbNew_Click);
            // 
            // tss1
            // 
            this.tss1.Name = "tss1";
            this.tss1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbLike
            // 
            this.tsbLike.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbLike.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbLike.Image = ((System.Drawing.Image)(resources.GetObject("tsbLike.Image")));
            this.tsbLike.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLike.Name = "tsbLike";
            this.tsbLike.Size = new System.Drawing.Size(23, 22);
            this.tsbLike.Text = "toolStripButton1";
            this.tsbLike.ToolTipText = "Dá Like";
            // 
            // tss2
            // 
            this.tss2.Name = "tss2";
            this.tss2.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbSair
            // 
            this.tsbSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tsbSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSair.Image = ((System.Drawing.Image)(resources.GetObject("tsbSair.Image")));
            this.tsbSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSair.Name = "tsbSair";
            this.tsbSair.Size = new System.Drawing.Size(23, 22);
            this.tsbSair.Text = "toolStripButton3";
            this.tsbSair.ToolTipText = "Zaindo";
            this.tsbSair.Click += new System.EventHandler(this.tsbSair_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblData,
            this.lblHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 467);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(810, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblData
            // 
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(34, 17);
            this.lblData.Text = "Data:";
            // 
            // lblHora
            // 
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(36, 17);
            this.lblHora.Text = "Hora:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(810, 489);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tsPrincipal);
            this.Controls.Add(this.msPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msPrincipal;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menus";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.tsPrincipal.ResumeLayout(false);
            this.tsPrincipal.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmJogosVisuais;
        private System.Windows.Forms.ToolStripMenuItem stsAmendoin;
        private System.Windows.Forms.ToolStripMenuItem stsSuperNet;
        private System.Windows.Forms.ToolStripMenuItem tsmVideoJogos;
        private System.Windows.Forms.ToolStripMenuItem stsComminSon;
        private System.Windows.Forms.ToolStrip tsPrincipal;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripSeparator tss1;
        private System.Windows.Forms.ToolStripButton tsbLike;
        private System.Windows.Forms.ToolStripSeparator tss2;
        private System.Windows.Forms.ToolStripButton tsbSair;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblData;
        private System.Windows.Forms.ToolStripStatusLabel lblHora;
        private System.Windows.Forms.Timer timer1;
    }
}

