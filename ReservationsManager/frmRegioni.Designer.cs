namespace ReservationsManager
{
	partial class frmRegioni
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
			System.Windows.Forms.Label regioneLabel;
			System.Windows.Forms.Label area_geograficaLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegioni));
			this.regioniBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
			this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
			this.regioniBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.prenotazioniDataSet = new ReservationsManager.prenotazioniDataSet();
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
			this.regioniBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.regioneTextBox = new System.Windows.Forms.TextBox();
			this.cittaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cittaDataGridView = new System.Windows.Forms.DataGridView();
			this.regioniTableAdapter = new ReservationsManager.prenotazioniDataSetTableAdapters.regioniTableAdapter();
			this.tableAdapterManager = new ReservationsManager.prenotazioniDataSetTableAdapters.TableAdapterManager();
			this.cittaTableAdapter = new ReservationsManager.prenotazioniDataSetTableAdapters.cittaTableAdapter();
			this.area_geograficaComboBox = new System.Windows.Forms.ComboBox();
			this.areeGeograficheComboBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.areeGeograficheComboTableAdapter = new ReservationsManager.prenotazioniDataSetTableAdapters.areeGeograficheComboTableAdapter();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.provincia_sigla = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.provincia_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
			regioneLabel = new System.Windows.Forms.Label();
			area_geograficaLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.regioniBindingNavigator)).BeginInit();
			this.regioniBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.regioniBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.prenotazioniDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cittaBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cittaDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.areeGeograficheComboBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// regioneLabel
			// 
			regioneLabel.AutoSize = true;
			regioneLabel.Location = new System.Drawing.Point(45, 77);
			regioneLabel.Name = "regioneLabel";
			regioneLabel.Size = new System.Drawing.Size(90, 25);
			regioneLabel.TabIndex = 1;
			regioneLabel.Text = "regione:";
			// 
			// area_geograficaLabel
			// 
			area_geograficaLabel.AutoSize = true;
			area_geograficaLabel.Location = new System.Drawing.Point(371, 70);
			area_geograficaLabel.Name = "area_geograficaLabel";
			area_geograficaLabel.Size = new System.Drawing.Size(168, 25);
			area_geograficaLabel.TabIndex = 3;
			area_geograficaLabel.Text = "area geografica:";
			// 
			// regioniBindingNavigator
			// 
			this.regioniBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.regioniBindingNavigator.BindingSource = this.regioniBindingSource;
			this.regioniBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.regioniBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.regioniBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.regioniBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.regioniBindingNavigatorSaveItem});
			this.regioniBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.regioniBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.regioniBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.regioniBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.regioniBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.regioniBindingNavigator.Name = "regioniBindingNavigator";
			this.regioniBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.regioniBindingNavigator.Size = new System.Drawing.Size(1014, 42);
			this.regioniBindingNavigator.TabIndex = 0;
			this.regioniBindingNavigator.Text = "bindingNavigator1";
			// 
			// bindingNavigatorAddNewItem
			// 
			this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
			this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
			this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(46, 36);
			this.bindingNavigatorAddNewItem.Text = "Add new";
			// 
			// regioniBindingSource
			// 
			this.regioniBindingSource.DataMember = "regioni";
			this.regioniBindingSource.DataSource = this.prenotazioniDataSet;
			// 
			// prenotazioniDataSet
			// 
			this.prenotazioniDataSet.DataSetName = "prenotazioniDataSet";
			this.prenotazioniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(70, 36);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(46, 36);
			this.bindingNavigatorDeleteItem.Text = "Delete";
			// 
			// bindingNavigatorMoveFirstItem
			// 
			this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
			this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
			this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(46, 36);
			this.bindingNavigatorMoveFirstItem.Text = "Move first";
			// 
			// bindingNavigatorMovePreviousItem
			// 
			this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
			this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
			this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(46, 36);
			this.bindingNavigatorMovePreviousItem.Text = "Move previous";
			// 
			// bindingNavigatorSeparator
			// 
			this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 42);
			// 
			// bindingNavigatorPositionItem
			// 
			this.bindingNavigatorPositionItem.AccessibleName = "Position";
			this.bindingNavigatorPositionItem.AutoSize = false;
			this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
			this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 39);
			this.bindingNavigatorPositionItem.Text = "0";
			this.bindingNavigatorPositionItem.ToolTipText = "Current position";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
			this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 42);
			// 
			// bindingNavigatorMoveNextItem
			// 
			this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
			this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
			this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(46, 36);
			this.bindingNavigatorMoveNextItem.Text = "Move next";
			// 
			// bindingNavigatorMoveLastItem
			// 
			this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
			this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
			this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(46, 36);
			this.bindingNavigatorMoveLastItem.Text = "Move last";
			// 
			// bindingNavigatorSeparator2
			// 
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 42);
			// 
			// regioniBindingNavigatorSaveItem
			// 
			this.regioniBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.regioniBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("regioniBindingNavigatorSaveItem.Image")));
			this.regioniBindingNavigatorSaveItem.Name = "regioniBindingNavigatorSaveItem";
			this.regioniBindingNavigatorSaveItem.Size = new System.Drawing.Size(46, 36);
			this.regioniBindingNavigatorSaveItem.Text = "Save Data";
			this.regioniBindingNavigatorSaveItem.Click += new System.EventHandler(this.regioniBindingNavigatorSaveItem_Click);
			// 
			// regioneTextBox
			// 
			this.regioneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.regioniBindingSource, "regione", true));
			this.regioneTextBox.Location = new System.Drawing.Point(50, 119);
			this.regioneTextBox.Name = "regioneTextBox";
			this.regioneTextBox.Size = new System.Drawing.Size(275, 31);
			this.regioneTextBox.TabIndex = 2;
			// 
			// cittaBindingSource
			// 
			this.cittaBindingSource.DataMember = "FK_citta_regioni";
			this.cittaBindingSource.DataSource = this.regioniBindingSource;
			// 
			// cittaDataGridView
			// 
			this.cittaDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cittaDataGridView.AutoGenerateColumns = false;
			this.cittaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.cittaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.provincia_sigla,
            this.provincia_nome});
			this.cittaDataGridView.DataSource = this.cittaBindingSource;
			this.cittaDataGridView.Location = new System.Drawing.Point(50, 197);
			this.cittaDataGridView.Name = "cittaDataGridView";
			this.cittaDataGridView.RowHeadersWidth = 82;
			this.cittaDataGridView.RowTemplate.Height = 33;
			this.cittaDataGridView.Size = new System.Drawing.Size(915, 276);
			this.cittaDataGridView.TabIndex = 5;
			// 
			// regioniTableAdapter
			// 
			this.regioniTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.cittaTableAdapter = this.cittaTableAdapter;
			this.tableAdapterManager.clientiComboTableAdapter = null;
			this.tableAdapterManager.clientiTableAdapter = null;
			this.tableAdapterManager.prenotazioniTableAdapter = null;
			this.tableAdapterManager.regioniTableAdapter = this.regioniTableAdapter;
			this.tableAdapterManager.UpdateOrder = ReservationsManager.prenotazioniDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// cittaTableAdapter
			// 
			this.cittaTableAdapter.ClearBeforeFill = true;
			// 
			// area_geograficaComboBox
			// 
			this.area_geograficaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.regioniBindingSource, "area_geografica", true));
			this.area_geograficaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.areeGeograficheComboBindingSource, "area_geografica", true));
			this.area_geograficaComboBox.DataSource = this.areeGeograficheComboBindingSource;
			this.area_geograficaComboBox.DisplayMember = "area_geografica";
			this.area_geograficaComboBox.FormattingEnabled = true;
			this.area_geograficaComboBox.Location = new System.Drawing.Point(364, 119);
			this.area_geograficaComboBox.Name = "area_geograficaComboBox";
			this.area_geograficaComboBox.Size = new System.Drawing.Size(275, 33);
			this.area_geograficaComboBox.TabIndex = 7;
			this.area_geograficaComboBox.ValueMember = "area_geografica";
			// 
			// areeGeograficheComboBindingSource
			// 
			this.areeGeograficheComboBindingSource.DataMember = "areeGeograficheCombo";
			this.areeGeograficheComboBindingSource.DataSource = this.prenotazioniDataSet;
			// 
			// areeGeograficheComboTableAdapter
			// 
			this.areeGeograficheComboTableAdapter.ClearBeforeFill = true;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "citta";
			this.dataGridViewTextBoxColumn2.HeaderText = "citta";
			this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.Width = 400;
			// 
			// provincia_sigla
			// 
			this.provincia_sigla.DataPropertyName = "provincia_sigla";
			this.provincia_sigla.HeaderText = "sigla provincia";
			this.provincia_sigla.MinimumWidth = 10;
			this.provincia_sigla.Name = "provincia_sigla";
			// 
			// provincia_nome
			// 
			this.provincia_nome.DataPropertyName = "provincia_nome";
			this.provincia_nome.HeaderText = "nome provincia";
			this.provincia_nome.MinimumWidth = 10;
			this.provincia_nome.Name = "provincia_nome";
			this.provincia_nome.Width = 300;
			// 
			// frmRegioni
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1014, 485);
			this.Controls.Add(this.area_geograficaComboBox);
			this.Controls.Add(this.cittaDataGridView);
			this.Controls.Add(area_geograficaLabel);
			this.Controls.Add(regioneLabel);
			this.Controls.Add(this.regioneTextBox);
			this.Controls.Add(this.regioniBindingNavigator);
			this.Name = "frmRegioni";
			this.Text = "frmRegioni";
			this.Load += new System.EventHandler(this.frmRegioni_Load);
			((System.ComponentModel.ISupportInitialize)(this.regioniBindingNavigator)).EndInit();
			this.regioniBindingNavigator.ResumeLayout(false);
			this.regioniBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.regioniBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.prenotazioniDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cittaBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cittaDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.areeGeograficheComboBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private prenotazioniDataSet prenotazioniDataSet;
		private System.Windows.Forms.BindingSource regioniBindingSource;
		private prenotazioniDataSetTableAdapters.regioniTableAdapter regioniTableAdapter;
		private prenotazioniDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator regioniBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton regioniBindingNavigatorSaveItem;
		private System.Windows.Forms.TextBox regioneTextBox;
		private prenotazioniDataSetTableAdapters.cittaTableAdapter cittaTableAdapter;
		private System.Windows.Forms.BindingSource cittaBindingSource;
		private System.Windows.Forms.DataGridView cittaDataGridView;
		private System.Windows.Forms.ComboBox area_geograficaComboBox;
		private System.Windows.Forms.BindingSource areeGeograficheComboBindingSource;
		private prenotazioniDataSetTableAdapters.areeGeograficheComboTableAdapter areeGeograficheComboTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn provincia_sigla;
		private System.Windows.Forms.DataGridViewTextBoxColumn provincia_nome;
	}
}