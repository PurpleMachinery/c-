namespace Escola
{
    partial class frmDiciplina
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
            System.Windows.Forms.Label cod_disciplinaLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label siglaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDiciplina));
            this.bd_EscolaDataSet = new Escola.Bd_EscolaDataSet();
            this.disciplinasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.disciplinasTableAdapter = new Escola.Bd_EscolaDataSetTableAdapters.DisciplinasTableAdapter();
            this.tableAdapterManager = new Escola.Bd_EscolaDataSetTableAdapters.TableAdapterManager();
            this.disciplinasBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.disciplinasBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.disciplinasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_disciplinaLabel1 = new System.Windows.Forms.Label();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.siglaTextBox = new System.Windows.Forms.TextBox();
            cod_disciplinaLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            siglaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bd_EscolaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinasBindingNavigator)).BeginInit();
            this.disciplinasBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cod_disciplinaLabel
            // 
            cod_disciplinaLabel.AutoSize = true;
            cod_disciplinaLabel.Location = new System.Drawing.Point(24, 51);
            cod_disciplinaLabel.Name = "cod_disciplinaLabel";
            cod_disciplinaLabel.Size = new System.Drawing.Size(74, 13);
            cod_disciplinaLabel.TabIndex = 2;
            cod_disciplinaLabel.Text = "cod disciplina:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(24, 80);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(56, 13);
            descricaoLabel.TabIndex = 4;
            descricaoLabel.Text = "descricao:";
            // 
            // siglaLabel
            // 
            siglaLabel.AutoSize = true;
            siglaLabel.Location = new System.Drawing.Point(24, 106);
            siglaLabel.Name = "siglaLabel";
            siglaLabel.Size = new System.Drawing.Size(31, 13);
            siglaLabel.TabIndex = 6;
            siglaLabel.Text = "sigla:";
            // 
            // bd_EscolaDataSet
            // 
            this.bd_EscolaDataSet.DataSetName = "Bd_EscolaDataSet";
            this.bd_EscolaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // disciplinasBindingSource
            // 
            this.disciplinasBindingSource.DataMember = "Disciplinas";
            this.disciplinasBindingSource.DataSource = this.bd_EscolaDataSet;
            // 
            // disciplinasTableAdapter
            // 
            this.disciplinasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlunosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DisciplinasTableAdapter = this.disciplinasTableAdapter;
            this.tableAdapterManager.MencaoTableAdapter = null;
            this.tableAdapterManager.Registro_MencoesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Escola.Bd_EscolaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // disciplinasBindingNavigator
            // 
            this.disciplinasBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.disciplinasBindingNavigator.BindingSource = this.disciplinasBindingSource;
            this.disciplinasBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.disciplinasBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.disciplinasBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.disciplinasBindingNavigatorSaveItem});
            this.disciplinasBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.disciplinasBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.disciplinasBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.disciplinasBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.disciplinasBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.disciplinasBindingNavigator.Name = "disciplinasBindingNavigator";
            this.disciplinasBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.disciplinasBindingNavigator.Size = new System.Drawing.Size(398, 25);
            this.disciplinasBindingNavigator.TabIndex = 0;
            this.disciplinasBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // disciplinasBindingNavigatorSaveItem
            // 
            this.disciplinasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.disciplinasBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("disciplinasBindingNavigatorSaveItem.Image")));
            this.disciplinasBindingNavigatorSaveItem.Name = "disciplinasBindingNavigatorSaveItem";
            this.disciplinasBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.disciplinasBindingNavigatorSaveItem.Text = "Save Data";
            this.disciplinasBindingNavigatorSaveItem.Click += new System.EventHandler(this.disciplinasBindingNavigatorSaveItem_Click);
            // 
            // disciplinasDataGridView
            // 
            this.disciplinasDataGridView.AutoGenerateColumns = false;
            this.disciplinasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.disciplinasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.disciplinasDataGridView.DataSource = this.disciplinasBindingSource;
            this.disciplinasDataGridView.Location = new System.Drawing.Point(27, 154);
            this.disciplinasDataGridView.Name = "disciplinasDataGridView";
            this.disciplinasDataGridView.Size = new System.Drawing.Size(345, 220);
            this.disciplinasDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "cod_disciplina";
            this.dataGridViewTextBoxColumn1.HeaderText = "cod_disciplina";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "descricao";
            this.dataGridViewTextBoxColumn2.HeaderText = "descricao";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "sigla";
            this.dataGridViewTextBoxColumn3.HeaderText = "sigla";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // cod_disciplinaLabel1
            // 
            this.cod_disciplinaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.disciplinasBindingSource, "cod_disciplina", true));
            this.cod_disciplinaLabel1.Location = new System.Drawing.Point(104, 51);
            this.cod_disciplinaLabel1.Name = "cod_disciplinaLabel1";
            this.cod_disciplinaLabel1.Size = new System.Drawing.Size(100, 23);
            this.cod_disciplinaLabel1.TabIndex = 3;
            this.cod_disciplinaLabel1.Text = "label1";
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.disciplinasBindingSource, "descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(104, 77);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(100, 20);
            this.descricaoTextBox.TabIndex = 5;
            // 
            // siglaTextBox
            // 
            this.siglaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.disciplinasBindingSource, "sigla", true));
            this.siglaTextBox.Location = new System.Drawing.Point(104, 103);
            this.siglaTextBox.Name = "siglaTextBox";
            this.siglaTextBox.Size = new System.Drawing.Size(100, 20);
            this.siglaTextBox.TabIndex = 7;
            // 
            // frmDiciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 405);
            this.Controls.Add(cod_disciplinaLabel);
            this.Controls.Add(this.cod_disciplinaLabel1);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(siglaLabel);
            this.Controls.Add(this.siglaTextBox);
            this.Controls.Add(this.disciplinasDataGridView);
            this.Controls.Add(this.disciplinasBindingNavigator);
            this.Name = "frmDiciplina";
            this.Text = "frmDiciplina";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDiciplina_FormClosing);
            this.Load += new System.EventHandler(this.frmDiciplina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bd_EscolaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinasBindingNavigator)).EndInit();
            this.disciplinasBindingNavigator.ResumeLayout(false);
            this.disciplinasBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disciplinasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bd_EscolaDataSet bd_EscolaDataSet;
        private System.Windows.Forms.BindingSource disciplinasBindingSource;
        private Bd_EscolaDataSetTableAdapters.DisciplinasTableAdapter disciplinasTableAdapter;
        private Bd_EscolaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator disciplinasBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton disciplinasBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView disciplinasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label cod_disciplinaLabel1;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.TextBox siglaTextBox;
    }
}