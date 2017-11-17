namespace Escola
{
    partial class frmMencoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMencoes));
            System.Windows.Forms.Label matriculaLabel;
            System.Windows.Forms.Label cod_disciplinaLabel;
            System.Windows.Forms.Label mencaoLabel;
            this.bd_EscolaDataSet = new Escola.Bd_EscolaDataSet();
            this.registro_MencoesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.registro_MencoesTableAdapter = new Escola.Bd_EscolaDataSetTableAdapters.Registro_MencoesTableAdapter();
            this.tableAdapterManager = new Escola.Bd_EscolaDataSetTableAdapters.TableAdapterManager();
            this.registro_MencoesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.registro_MencoesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.registro_MencoesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriculaLabel1 = new System.Windows.Forms.Label();
            this.cod_disciplinaTextBox = new System.Windows.Forms.TextBox();
            this.mencaoTextBox = new System.Windows.Forms.TextBox();
            matriculaLabel = new System.Windows.Forms.Label();
            cod_disciplinaLabel = new System.Windows.Forms.Label();
            mencaoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bd_EscolaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registro_MencoesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registro_MencoesBindingNavigator)).BeginInit();
            this.registro_MencoesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registro_MencoesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bd_EscolaDataSet
            // 
            this.bd_EscolaDataSet.DataSetName = "Bd_EscolaDataSet";
            this.bd_EscolaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registro_MencoesBindingSource
            // 
            this.registro_MencoesBindingSource.DataMember = "Registro_Mencoes";
            this.registro_MencoesBindingSource.DataSource = this.bd_EscolaDataSet;
            // 
            // registro_MencoesTableAdapter
            // 
            this.registro_MencoesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AlunosTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DisciplinasTableAdapter = null;
            this.tableAdapterManager.MencaoTableAdapter = null;
            this.tableAdapterManager.Registro_MencoesTableAdapter = this.registro_MencoesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Escola.Bd_EscolaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // registro_MencoesBindingNavigator
            // 
            this.registro_MencoesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.registro_MencoesBindingNavigator.BindingSource = this.registro_MencoesBindingSource;
            this.registro_MencoesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.registro_MencoesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.registro_MencoesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.registro_MencoesBindingNavigatorSaveItem});
            this.registro_MencoesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.registro_MencoesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.registro_MencoesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.registro_MencoesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.registro_MencoesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.registro_MencoesBindingNavigator.Name = "registro_MencoesBindingNavigator";
            this.registro_MencoesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.registro_MencoesBindingNavigator.Size = new System.Drawing.Size(372, 25);
            this.registro_MencoesBindingNavigator.TabIndex = 0;
            this.registro_MencoesBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // registro_MencoesBindingNavigatorSaveItem
            // 
            this.registro_MencoesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.registro_MencoesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("registro_MencoesBindingNavigatorSaveItem.Image")));
            this.registro_MencoesBindingNavigatorSaveItem.Name = "registro_MencoesBindingNavigatorSaveItem";
            this.registro_MencoesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.registro_MencoesBindingNavigatorSaveItem.Text = "Save Data";
            this.registro_MencoesBindingNavigatorSaveItem.Click += new System.EventHandler(this.registro_MencoesBindingNavigatorSaveItem_Click);
            // 
            // registro_MencoesDataGridView
            // 
            this.registro_MencoesDataGridView.AutoGenerateColumns = false;
            this.registro_MencoesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.registro_MencoesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.registro_MencoesDataGridView.DataSource = this.registro_MencoesBindingSource;
            this.registro_MencoesDataGridView.Location = new System.Drawing.Point(12, 129);
            this.registro_MencoesDataGridView.Name = "registro_MencoesDataGridView";
            this.registro_MencoesDataGridView.Size = new System.Drawing.Size(345, 218);
            this.registro_MencoesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "matricula";
            this.dataGridViewTextBoxColumn1.HeaderText = "matricula";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "cod_disciplina";
            this.dataGridViewTextBoxColumn2.HeaderText = "cod_disciplina";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "mencao";
            this.dataGridViewTextBoxColumn3.HeaderText = "mencao";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // matriculaLabel
            // 
            matriculaLabel.AutoSize = true;
            matriculaLabel.Location = new System.Drawing.Point(12, 41);
            matriculaLabel.Name = "matriculaLabel";
            matriculaLabel.Size = new System.Drawing.Size(52, 13);
            matriculaLabel.TabIndex = 2;
            matriculaLabel.Text = "matricula:";
            // 
            // matriculaLabel1
            // 
            this.matriculaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registro_MencoesBindingSource, "matricula", true));
            this.matriculaLabel1.Location = new System.Drawing.Point(92, 41);
            this.matriculaLabel1.Name = "matriculaLabel1";
            this.matriculaLabel1.Size = new System.Drawing.Size(100, 23);
            this.matriculaLabel1.TabIndex = 3;
            this.matriculaLabel1.Text = "label1";
            // 
            // cod_disciplinaLabel
            // 
            cod_disciplinaLabel.AutoSize = true;
            cod_disciplinaLabel.Location = new System.Drawing.Point(12, 70);
            cod_disciplinaLabel.Name = "cod_disciplinaLabel";
            cod_disciplinaLabel.Size = new System.Drawing.Size(74, 13);
            cod_disciplinaLabel.TabIndex = 4;
            cod_disciplinaLabel.Text = "cod disciplina:";
            // 
            // cod_disciplinaTextBox
            // 
            this.cod_disciplinaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registro_MencoesBindingSource, "cod_disciplina", true));
            this.cod_disciplinaTextBox.Location = new System.Drawing.Point(92, 67);
            this.cod_disciplinaTextBox.Name = "cod_disciplinaTextBox";
            this.cod_disciplinaTextBox.Size = new System.Drawing.Size(100, 20);
            this.cod_disciplinaTextBox.TabIndex = 5;
            // 
            // mencaoLabel
            // 
            mencaoLabel.AutoSize = true;
            mencaoLabel.Location = new System.Drawing.Point(12, 96);
            mencaoLabel.Name = "mencaoLabel";
            mencaoLabel.Size = new System.Drawing.Size(48, 13);
            mencaoLabel.TabIndex = 6;
            mencaoLabel.Text = "mencao:";
            // 
            // mencaoTextBox
            // 
            this.mencaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registro_MencoesBindingSource, "mencao", true));
            this.mencaoTextBox.Location = new System.Drawing.Point(92, 93);
            this.mencaoTextBox.Name = "mencaoTextBox";
            this.mencaoTextBox.Size = new System.Drawing.Size(100, 20);
            this.mencaoTextBox.TabIndex = 7;
            // 
            // frmMencoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 351);
            this.Controls.Add(matriculaLabel);
            this.Controls.Add(this.matriculaLabel1);
            this.Controls.Add(cod_disciplinaLabel);
            this.Controls.Add(this.cod_disciplinaTextBox);
            this.Controls.Add(mencaoLabel);
            this.Controls.Add(this.mencaoTextBox);
            this.Controls.Add(this.registro_MencoesDataGridView);
            this.Controls.Add(this.registro_MencoesBindingNavigator);
            this.Name = "frmMencoes";
            this.Text = "frmMencoes";
            this.Load += new System.EventHandler(this.frmMencoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bd_EscolaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registro_MencoesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registro_MencoesBindingNavigator)).EndInit();
            this.registro_MencoesBindingNavigator.ResumeLayout(false);
            this.registro_MencoesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registro_MencoesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bd_EscolaDataSet bd_EscolaDataSet;
        private System.Windows.Forms.BindingSource registro_MencoesBindingSource;
        private Bd_EscolaDataSetTableAdapters.Registro_MencoesTableAdapter registro_MencoesTableAdapter;
        private Bd_EscolaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator registro_MencoesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton registro_MencoesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView registro_MencoesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label matriculaLabel1;
        private System.Windows.Forms.TextBox cod_disciplinaTextBox;
        private System.Windows.Forms.TextBox mencaoTextBox;
    }
}