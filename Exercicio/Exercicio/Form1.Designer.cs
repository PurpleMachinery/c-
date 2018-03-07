namespace Exercicio
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label enderecoLabel;
            System.Windows.Forms.Label rgLabel;
            System.Windows.Forms.Label cpfLabel;
            System.Windows.Forms.Label cidadeLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label salarioLiquidoLabel;
            this.funcionariosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcDataSet = new Exercicio.funcDataSet();
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
            this.funcionariosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btnSB = new System.Windows.Forms.Button();
            this.txbSalarioBruto = new System.Windows.Forms.TextBox();
            this.funcionariosTableAdapter = new Exercicio.funcDataSetTableAdapters.funcionariosTableAdapter();
            this.tableAdapterManager = new Exercicio.funcDataSetTableAdapters.TableAdapterManager();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.rgMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cpfMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.cidadeTextBox = new System.Windows.Forms.TextBox();
            this.estadoTextBox = new System.Windows.Forms.TextBox();
            this.salarioLiquidoTextBox = new System.Windows.Forms.TextBox();
            idLabel = new System.Windows.Forms.Label();
            enderecoLabel = new System.Windows.Forms.Label();
            rgLabel = new System.Windows.Forms.Label();
            cpfLabel = new System.Windows.Forms.Label();
            cidadeLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            salarioLiquidoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingNavigator)).BeginInit();
            this.funcionariosBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // funcionariosBindingNavigator
            // 
            this.funcionariosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.funcionariosBindingNavigator.BindingSource = this.funcionariosBindingSource;
            this.funcionariosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.funcionariosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.funcionariosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.funcionariosBindingNavigatorSaveItem});
            this.funcionariosBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.funcionariosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.funcionariosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.funcionariosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.funcionariosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.funcionariosBindingNavigator.Name = "funcionariosBindingNavigator";
            this.funcionariosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.funcionariosBindingNavigator.Size = new System.Drawing.Size(284, 25);
            this.funcionariosBindingNavigator.TabIndex = 0;
            this.funcionariosBindingNavigator.Text = "bindingNavigator1";
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
            // funcionariosBindingSource
            // 
            this.funcionariosBindingSource.DataMember = "funcionarios";
            this.funcionariosBindingSource.DataSource = this.funcDataSet;
            // 
            // funcDataSet
            // 
            this.funcDataSet.DataSetName = "funcDataSet";
            this.funcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // funcionariosBindingNavigatorSaveItem
            // 
            this.funcionariosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.funcionariosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("funcionariosBindingNavigatorSaveItem.Image")));
            this.funcionariosBindingNavigatorSaveItem.Name = "funcionariosBindingNavigatorSaveItem";
            this.funcionariosBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.funcionariosBindingNavigatorSaveItem.Text = "Save Data";
            this.funcionariosBindingNavigatorSaveItem.Click += new System.EventHandler(this.funcionariosBindingNavigatorSaveItem_Click);
            // 
            // btnSB
            // 
            this.btnSB.Location = new System.Drawing.Point(25, 215);
            this.btnSB.Name = "btnSB";
            this.btnSB.Size = new System.Drawing.Size(75, 23);
            this.btnSB.TabIndex = 15;
            this.btnSB.Text = "Calcular SB";
            this.btnSB.UseVisualStyleBackColor = true;
            this.btnSB.Click += new System.EventHandler(this.btnSB_Click);
            // 
            // txbSalarioBruto
            // 
            this.txbSalarioBruto.Enabled = false;
            this.txbSalarioBruto.Location = new System.Drawing.Point(106, 218);
            this.txbSalarioBruto.Name = "txbSalarioBruto";
            this.txbSalarioBruto.Size = new System.Drawing.Size(100, 20);
            this.txbSalarioBruto.TabIndex = 16;
            // 
            // funcionariosTableAdapter
            // 
            this.funcionariosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.funcionariosTableAdapter = this.funcionariosTableAdapter;
            this.tableAdapterManager.UpdateOrder = Exercicio.funcDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(23, 40);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 16;
            idLabel.Text = "id:";
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionariosBindingSource, "id", true));
            this.idTextBox.Enabled = false;
            this.idTextBox.Location = new System.Drawing.Point(106, 37);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(100, 20);
            this.idTextBox.TabIndex = 17;
            // 
            // enderecoLabel
            // 
            enderecoLabel.AutoSize = true;
            enderecoLabel.Location = new System.Drawing.Point(23, 66);
            enderecoLabel.Name = "enderecoLabel";
            enderecoLabel.Size = new System.Drawing.Size(55, 13);
            enderecoLabel.TabIndex = 18;
            enderecoLabel.Text = "endereco:";
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionariosBindingSource, "endereco", true));
            this.enderecoTextBox.Location = new System.Drawing.Point(106, 63);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(100, 20);
            this.enderecoTextBox.TabIndex = 19;
            // 
            // rgLabel
            // 
            rgLabel.AutoSize = true;
            rgLabel.Location = new System.Drawing.Point(23, 92);
            rgLabel.Name = "rgLabel";
            rgLabel.Size = new System.Drawing.Size(19, 13);
            rgLabel.TabIndex = 20;
            rgLabel.Text = "rg:";
            // 
            // rgMaskedTextBox
            // 
            this.rgMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionariosBindingSource, "rg", true));
            this.rgMaskedTextBox.Location = new System.Drawing.Point(106, 89);
            this.rgMaskedTextBox.Mask = "00,000,000a-0";
            this.rgMaskedTextBox.Name = "rgMaskedTextBox";
            this.rgMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.rgMaskedTextBox.TabIndex = 21;
            // 
            // cpfLabel
            // 
            cpfLabel.AutoSize = true;
            cpfLabel.Location = new System.Drawing.Point(23, 118);
            cpfLabel.Name = "cpfLabel";
            cpfLabel.Size = new System.Drawing.Size(25, 13);
            cpfLabel.TabIndex = 22;
            cpfLabel.Text = "cpf:";
            // 
            // cpfMaskedTextBox
            // 
            this.cpfMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionariosBindingSource, "cpf", true));
            this.cpfMaskedTextBox.Location = new System.Drawing.Point(106, 115);
            this.cpfMaskedTextBox.Mask = "000,000,000-00";
            this.cpfMaskedTextBox.Name = "cpfMaskedTextBox";
            this.cpfMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.cpfMaskedTextBox.TabIndex = 23;
            // 
            // cidadeLabel
            // 
            cidadeLabel.AutoSize = true;
            cidadeLabel.Location = new System.Drawing.Point(23, 144);
            cidadeLabel.Name = "cidadeLabel";
            cidadeLabel.Size = new System.Drawing.Size(42, 13);
            cidadeLabel.TabIndex = 24;
            cidadeLabel.Text = "cidade:";
            // 
            // cidadeTextBox
            // 
            this.cidadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionariosBindingSource, "cidade", true));
            this.cidadeTextBox.Location = new System.Drawing.Point(106, 141);
            this.cidadeTextBox.Name = "cidadeTextBox";
            this.cidadeTextBox.Size = new System.Drawing.Size(100, 20);
            this.cidadeTextBox.TabIndex = 25;
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Location = new System.Drawing.Point(23, 170);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(42, 13);
            estadoLabel.TabIndex = 26;
            estadoLabel.Text = "estado:";
            // 
            // estadoTextBox
            // 
            this.estadoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionariosBindingSource, "estado", true));
            this.estadoTextBox.Location = new System.Drawing.Point(106, 167);
            this.estadoTextBox.Name = "estadoTextBox";
            this.estadoTextBox.Size = new System.Drawing.Size(100, 20);
            this.estadoTextBox.TabIndex = 27;
            // 
            // salarioLiquidoLabel
            // 
            salarioLiquidoLabel.AutoSize = true;
            salarioLiquidoLabel.Location = new System.Drawing.Point(23, 196);
            salarioLiquidoLabel.Name = "salarioLiquidoLabel";
            salarioLiquidoLabel.Size = new System.Drawing.Size(77, 13);
            salarioLiquidoLabel.TabIndex = 28;
            salarioLiquidoLabel.Text = "salario Liquido:";
            // 
            // salarioLiquidoTextBox
            // 
            this.salarioLiquidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.funcionariosBindingSource, "salarioLiquido", true));
            this.salarioLiquidoTextBox.Location = new System.Drawing.Point(106, 193);
            this.salarioLiquidoTextBox.Name = "salarioLiquidoTextBox";
            this.salarioLiquidoTextBox.Size = new System.Drawing.Size(100, 20);
            this.salarioLiquidoTextBox.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(enderecoLabel);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(rgLabel);
            this.Controls.Add(this.rgMaskedTextBox);
            this.Controls.Add(cpfLabel);
            this.Controls.Add(this.cpfMaskedTextBox);
            this.Controls.Add(cidadeLabel);
            this.Controls.Add(this.cidadeTextBox);
            this.Controls.Add(estadoLabel);
            this.Controls.Add(this.estadoTextBox);
            this.Controls.Add(salarioLiquidoLabel);
            this.Controls.Add(this.salarioLiquidoTextBox);
            this.Controls.Add(this.txbSalarioBruto);
            this.Controls.Add(this.btnSB);
            this.Controls.Add(this.funcionariosBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingNavigator)).EndInit();
            this.funcionariosBindingNavigator.ResumeLayout(false);
            this.funcionariosBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private funcDataSet funcDataSet;
        private System.Windows.Forms.BindingSource funcionariosBindingSource;
        private funcDataSetTableAdapters.funcionariosTableAdapter funcionariosTableAdapter;
        private funcDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator funcionariosBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton funcionariosBindingNavigatorSaveItem;
        private System.Windows.Forms.Button btnSB;
        private System.Windows.Forms.TextBox txbSalarioBruto;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox enderecoTextBox;
        private System.Windows.Forms.MaskedTextBox rgMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox cpfMaskedTextBox;
        private System.Windows.Forms.TextBox cidadeTextBox;
        private System.Windows.Forms.TextBox estadoTextBox;
        private System.Windows.Forms.TextBox salarioLiquidoTextBox;
    }
}

