namespace PrjCliente_Assist
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.Label matriculaLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label nascLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label numeroLabel;
            System.Windows.Forms.Label cepLabel;
            this.bD_ClienteDataSet = new PrjCliente_Assist.BD_ClienteDataSet();
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesTableAdapter = new PrjCliente_Assist.BD_ClienteDataSetTableAdapters.ClientesTableAdapter();
            this.tableAdapterManager = new PrjCliente_Assist.BD_ClienteDataSetTableAdapters.TableAdapterManager();
            this.clientesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.clientesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.clientesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matriculaLabel1 = new System.Windows.Forms.Label();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.nascDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.cepMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            matriculaLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            nascLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            numeroLabel = new System.Windows.Forms.Label();
            cepLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bD_ClienteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingNavigator)).BeginInit();
            this.clientesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bD_ClienteDataSet
            // 
            this.bD_ClienteDataSet.DataSetName = "BD_ClienteDataSet";
            this.bD_ClienteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientesBindingSource
            // 
            this.clientesBindingSource.DataMember = "Clientes";
            this.clientesBindingSource.DataSource = this.bD_ClienteDataSet;
            // 
            // clientesTableAdapter
            // 
            this.clientesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientesTableAdapter = this.clientesTableAdapter;
            this.tableAdapterManager.UpdateOrder = PrjCliente_Assist.BD_ClienteDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clientesBindingNavigator
            // 
            this.clientesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.clientesBindingNavigator.BindingSource = this.clientesBindingSource;
            this.clientesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.clientesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.clientesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.clientesBindingNavigatorSaveItem});
            this.clientesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.clientesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clientesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clientesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clientesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clientesBindingNavigator.Name = "clientesBindingNavigator";
            this.clientesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clientesBindingNavigator.Size = new System.Drawing.Size(770, 25);
            this.clientesBindingNavigator.TabIndex = 0;
            this.clientesBindingNavigator.Text = "bindingNavigator1";
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
            // clientesBindingNavigatorSaveItem
            // 
            this.clientesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clientesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("clientesBindingNavigatorSaveItem.Image")));
            this.clientesBindingNavigatorSaveItem.Name = "clientesBindingNavigatorSaveItem";
            this.clientesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.clientesBindingNavigatorSaveItem.Text = "Save Data";
            this.clientesBindingNavigatorSaveItem.Click += new System.EventHandler(this.clientesBindingNavigatorSaveItem_Click_2);
            // 
            // clientesDataGridView
            // 
            this.clientesDataGridView.AutoGenerateColumns = false;
            this.clientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.clientesDataGridView.DataSource = this.clientesBindingSource;
            this.clientesDataGridView.Location = new System.Drawing.Point(15, 239);
            this.clientesDataGridView.Name = "clientesDataGridView";
            this.clientesDataGridView.Size = new System.Drawing.Size(643, 220);
            this.clientesDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Matricula";
            this.dataGridViewTextBoxColumn1.HeaderText = "Matricula";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nasc";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nasc";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Endereco";
            this.dataGridViewTextBoxColumn4.HeaderText = "Endereco";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "numero";
            this.dataGridViewTextBoxColumn5.HeaderText = "numero";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "cep";
            this.dataGridViewTextBoxColumn6.HeaderText = "cep";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // matriculaLabel
            // 
            matriculaLabel.AutoSize = true;
            matriculaLabel.Location = new System.Drawing.Point(36, 48);
            matriculaLabel.Name = "matriculaLabel";
            matriculaLabel.Size = new System.Drawing.Size(53, 13);
            matriculaLabel.TabIndex = 13;
            matriculaLabel.Text = "Matricula:";
            // 
            // matriculaLabel1
            // 
            this.matriculaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Matricula", true));
            this.matriculaLabel1.Location = new System.Drawing.Point(98, 48);
            this.matriculaLabel1.Name = "matriculaLabel1";
            this.matriculaLabel1.Size = new System.Drawing.Size(200, 23);
            this.matriculaLabel1.TabIndex = 14;
            this.matriculaLabel1.Text = "label1";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(36, 77);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(38, 13);
            nomeLabel.TabIndex = 15;
            nomeLabel.Text = "Nome:";
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(98, 74);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(200, 20);
            this.nomeTextBox.TabIndex = 16;
            // 
            // nascLabel
            // 
            nascLabel.AutoSize = true;
            nascLabel.Location = new System.Drawing.Point(36, 104);
            nascLabel.Name = "nascLabel";
            nascLabel.Size = new System.Drawing.Size(35, 13);
            nascLabel.TabIndex = 17;
            nascLabel.Text = "Nasc:";
            // 
            // nascDateTimePicker
            // 
            this.nascDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientesBindingSource, "Nasc", true));
            this.nascDateTimePicker.Location = new System.Drawing.Point(98, 100);
            this.nascDateTimePicker.Name = "nascDateTimePicker";
            this.nascDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.nascDateTimePicker.TabIndex = 18;
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(36, 129);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(56, 13);
            enderecoLabel.TabIndex = 19;
            enderecoLabel.Text = "Endereco:";
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "Endereco", true));
            this.enderecoTextBox.Location = new System.Drawing.Point(98, 126);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(200, 20);
            this.enderecoTextBox.TabIndex = 20;
            // 
            // numeroLabel
            // 
            numeroLabel.AutoSize = true;
            numeroLabel.Location = new System.Drawing.Point(36, 155);
            numeroLabel.Name = "numeroLabel";
            numeroLabel.Size = new System.Drawing.Size(45, 13);
            numeroLabel.TabIndex = 21;
            numeroLabel.Text = "numero:";
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "numero", true));
            this.numeroTextBox.Location = new System.Drawing.Point(98, 152);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.Size = new System.Drawing.Size(200, 20);
            this.numeroTextBox.TabIndex = 22;
            // 
            // cepLabel
            // 
            cepLabel.AutoSize = true;
            cepLabel.Location = new System.Drawing.Point(36, 181);
            cepLabel.Name = "cepLabel";
            cepLabel.Size = new System.Drawing.Size(28, 13);
            cepLabel.TabIndex = 23;
            cepLabel.Text = "cep:";
            // 
            // cepMaskedTextBox
            // 
            this.cepMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientesBindingSource, "cep", true));
            this.cepMaskedTextBox.Location = new System.Drawing.Point(98, 178);
            this.cepMaskedTextBox.Mask = "00000-999";
            this.cepMaskedTextBox.Name = "cepMaskedTextBox";
            this.cepMaskedTextBox.Size = new System.Drawing.Size(200, 20);
            this.cepMaskedTextBox.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 509);
            this.Controls.Add(matriculaLabel);
            this.Controls.Add(this.matriculaLabel1);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(nascLabel);
            this.Controls.Add(this.nascDateTimePicker);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(numeroLabel);
            this.Controls.Add(this.numeroTextBox);
            this.Controls.Add(cepLabel);
            this.Controls.Add(this.cepMaskedTextBox);
            this.Controls.Add(this.clientesDataGridView);
            this.Controls.Add(this.clientesBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_ClienteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingNavigator)).EndInit();
            this.clientesBindingNavigator.ResumeLayout(false);
            this.clientesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BD_ClienteDataSet bD_ClienteDataSet;
        private System.Windows.Forms.BindingSource clientesBindingSource;
        private BD_ClienteDataSetTableAdapters.ClientesTableAdapter clientesTableAdapter;
        private BD_ClienteDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator clientesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton clientesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView clientesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label matriculaLabel1;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.DateTimePicker nascDateTimePicker;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.TextBox numeroTextBox;
        private System.Windows.Forms.MaskedTextBox cepMaskedTextBox;


    }
}

