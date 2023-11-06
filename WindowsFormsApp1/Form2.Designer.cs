namespace WindowsFormsApp1
{
	partial class Form2
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
			System.Windows.Forms.Label nomeLabel;
			System.Windows.Forms.Label cognomeLabel;
			System.Windows.Forms.Label cittaLabel;
			System.Windows.Forms.Label dataNascitaLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.dSPrenotazioni = new WindowsFormsApp1.DSPrenotazioni();
			this.clientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.clientiTableAdapter = new WindowsFormsApp1.DSPrenotazioniTableAdapters.clientiTableAdapter();
			this.tableAdapterManager = new WindowsFormsApp1.DSPrenotazioniTableAdapters.TableAdapterManager();
			this.prenotazioniTableAdapter = new WindowsFormsApp1.DSPrenotazioniTableAdapters.prenotazioniTableAdapter();
			this.clientiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
			this.clientiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.nomeTextBox = new System.Windows.Forms.TextBox();
			this.cognomeTextBox = new System.Windows.Forms.TextBox();
			this.prenotazioniBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.prenotazioniDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.cittaComboBox = new System.Windows.Forms.ComboBox();
			this.cittaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cittaTableAdapter = new WindowsFormsApp1.DSPrenotazioniTableAdapters.cittaTableAdapter();
			this.dataNascitaDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.prenotazioniBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.prenotazioniDataGridView1 = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button1 = new System.Windows.Forms.Button();
			nomeLabel = new System.Windows.Forms.Label();
			cognomeLabel = new System.Windows.Forms.Label();
			cittaLabel = new System.Windows.Forms.Label();
			dataNascitaLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dSPrenotazioni)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.clientiBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.clientiBindingNavigator)).BeginInit();
			this.clientiBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.prenotazioniBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.prenotazioniDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cittaBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.prenotazioniBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.prenotazioniDataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// nomeLabel
			// 
			nomeLabel.AutoSize = true;
			nomeLabel.Location = new System.Drawing.Point(35, 75);
			nomeLabel.Name = "nomeLabel";
			nomeLabel.Size = new System.Drawing.Size(71, 25);
			nomeLabel.TabIndex = 1;
			nomeLabel.Text = "nome:";
			// 
			// cognomeLabel
			// 
			cognomeLabel.AutoSize = true;
			cognomeLabel.Location = new System.Drawing.Point(245, 78);
			cognomeLabel.Name = "cognomeLabel";
			cognomeLabel.Size = new System.Drawing.Size(106, 25);
			cognomeLabel.TabIndex = 3;
			cognomeLabel.Text = "cognome:";
			// 
			// cittaLabel
			// 
			cittaLabel.AutoSize = true;
			cittaLabel.Location = new System.Drawing.Point(503, 75);
			cittaLabel.Name = "cittaLabel";
			cittaLabel.Size = new System.Drawing.Size(58, 25);
			cittaLabel.TabIndex = 8;
			cittaLabel.Text = "citta:";
			// 
			// dataNascitaLabel
			// 
			dataNascitaLabel.AutoSize = true;
			dataNascitaLabel.Location = new System.Drawing.Point(753, 73);
			dataNascitaLabel.Name = "dataNascitaLabel";
			dataNascitaLabel.Size = new System.Drawing.Size(138, 25);
			dataNascitaLabel.TabIndex = 9;
			dataNascitaLabel.Text = "data Nascita:";
			// 
			// dSPrenotazioni
			// 
			this.dSPrenotazioni.DataSetName = "DSPrenotazioni";
			this.dSPrenotazioni.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// clientiBindingSource
			// 
			this.clientiBindingSource.DataMember = "clienti";
			this.clientiBindingSource.DataSource = this.dSPrenotazioni;
			// 
			// clientiTableAdapter
			// 
			this.clientiTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.cittaTableAdapter = null;
			this.tableAdapterManager.clientiTableAdapter = this.clientiTableAdapter;
			this.tableAdapterManager.prenotazioniTableAdapter = this.prenotazioniTableAdapter;
			this.tableAdapterManager.regioniTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.DSPrenotazioniTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// prenotazioniTableAdapter
			// 
			this.prenotazioniTableAdapter.ClearBeforeFill = true;
			// 
			// clientiBindingNavigator
			// 
			this.clientiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.clientiBindingNavigator.BindingSource = this.clientiBindingSource;
			this.clientiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.clientiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.clientiBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.clientiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.clientiBindingNavigatorSaveItem});
			this.clientiBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.clientiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.clientiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.clientiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.clientiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.clientiBindingNavigator.Name = "clientiBindingNavigator";
			this.clientiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.clientiBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.clientiBindingNavigator.Size = new System.Drawing.Size(1564, 42);
			this.clientiBindingNavigator.TabIndex = 0;
			this.clientiBindingNavigator.Text = "bindingNavigator1";
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
			this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
			this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
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
			// clientiBindingNavigatorSaveItem
			// 
			this.clientiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.clientiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("clientiBindingNavigatorSaveItem.Image")));
			this.clientiBindingNavigatorSaveItem.Name = "clientiBindingNavigatorSaveItem";
			this.clientiBindingNavigatorSaveItem.Size = new System.Drawing.Size(46, 36);
			this.clientiBindingNavigatorSaveItem.Text = "Save Data";
			this.clientiBindingNavigatorSaveItem.Click += new System.EventHandler(this.clientiBindingNavigatorSaveItem_Click);
			// 
			// nomeTextBox
			// 
			this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientiBindingSource, "nome", true));
			this.nomeTextBox.Location = new System.Drawing.Point(112, 72);
			this.nomeTextBox.Name = "nomeTextBox";
			this.nomeTextBox.Size = new System.Drawing.Size(100, 31);
			this.nomeTextBox.TabIndex = 2;
			// 
			// cognomeTextBox
			// 
			this.cognomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientiBindingSource, "cognome", true));
			this.cognomeTextBox.Location = new System.Drawing.Point(357, 75);
			this.cognomeTextBox.Name = "cognomeTextBox";
			this.cognomeTextBox.Size = new System.Drawing.Size(100, 31);
			this.cognomeTextBox.TabIndex = 4;
			// 
			// prenotazioniBindingSource
			// 
			this.prenotazioniBindingSource.DataMember = "prenotazioni";
			this.prenotazioniBindingSource.DataSource = this.dSPrenotazioni;
			// 
			// prenotazioniDataGridView
			// 
			this.prenotazioniDataGridView.AutoGenerateColumns = false;
			this.prenotazioniDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.prenotazioniDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
			this.prenotazioniDataGridView.DataSource = this.prenotazioniBindingSource;
			this.prenotazioniDataGridView.Location = new System.Drawing.Point(23, 213);
			this.prenotazioniDataGridView.Name = "prenotazioniDataGridView";
			this.prenotazioniDataGridView.RowHeadersWidth = 82;
			this.prenotazioniDataGridView.RowTemplate.Height = 33;
			this.prenotazioniDataGridView.Size = new System.Drawing.Size(1106, 336);
			this.prenotazioniDataGridView.TabIndex = 5;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_prenotazione";
			this.dataGridViewTextBoxColumn1.HeaderText = "ID_prenotazione";
			this.dataGridViewTextBoxColumn1.MinimumWidth = 10;
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Width = 200;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "camera";
			this.dataGridViewTextBoxColumn2.HeaderText = "camera";
			this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.Width = 200;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "arrivo";
			this.dataGridViewTextBoxColumn3.HeaderText = "arrivo";
			this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.Width = 200;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "partenza";
			this.dataGridViewTextBoxColumn4.HeaderText = "partenza";
			this.dataGridViewTextBoxColumn4.MinimumWidth = 10;
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.Width = 200;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "importo";
			this.dataGridViewTextBoxColumn5.HeaderText = "importo";
			this.dataGridViewTextBoxColumn5.MinimumWidth = 10;
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.Width = 200;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "caparra";
			this.dataGridViewTextBoxColumn6.HeaderText = "caparra";
			this.dataGridViewTextBoxColumn6.MinimumWidth = 10;
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.Width = 200;
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.DataPropertyName = "tipo_struttura";
			this.dataGridViewTextBoxColumn7.HeaderText = "tipo_struttura";
			this.dataGridViewTextBoxColumn7.MinimumWidth = 10;
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.Width = 200;
			// 
			// dataGridViewTextBoxColumn8
			// 
			this.dataGridViewTextBoxColumn8.DataPropertyName = "giorni_permanenza";
			this.dataGridViewTextBoxColumn8.HeaderText = "giorni_permanenza";
			this.dataGridViewTextBoxColumn8.MinimumWidth = 10;
			this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
			this.dataGridViewTextBoxColumn8.Width = 200;
			// 
			// dataGridViewTextBoxColumn9
			// 
			this.dataGridViewTextBoxColumn9.DataPropertyName = "costo_giornaliero";
			this.dataGridViewTextBoxColumn9.HeaderText = "costo_giornaliero";
			this.dataGridViewTextBoxColumn9.MinimumWidth = 10;
			this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
			this.dataGridViewTextBoxColumn9.Width = 200;
			// 
			// dataGridViewTextBoxColumn10
			// 
			this.dataGridViewTextBoxColumn10.DataPropertyName = "cliente";
			this.dataGridViewTextBoxColumn10.HeaderText = "cliente";
			this.dataGridViewTextBoxColumn10.MinimumWidth = 10;
			this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
			this.dataGridViewTextBoxColumn10.Width = 200;
			// 
			// cittaComboBox
			// 
			this.cittaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clientiBindingSource, "citta", true));
			this.cittaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cittaBindingSource, "citta", true));
			this.cittaComboBox.DataSource = this.cittaBindingSource;
			this.cittaComboBox.DisplayMember = "citta";
			this.cittaComboBox.FormattingEnabled = true;
			this.cittaComboBox.Location = new System.Drawing.Point(567, 72);
			this.cittaComboBox.Name = "cittaComboBox";
			this.cittaComboBox.Size = new System.Drawing.Size(121, 33);
			this.cittaComboBox.TabIndex = 9;
			this.cittaComboBox.ValueMember = "ID_citta";
			// 
			// cittaBindingSource
			// 
			this.cittaBindingSource.DataMember = "citta";
			this.cittaBindingSource.DataSource = this.dSPrenotazioni;
			// 
			// cittaTableAdapter
			// 
			this.cittaTableAdapter.ClearBeforeFill = true;
			// 
			// dataNascitaDateTimePicker
			// 
			this.dataNascitaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientiBindingSource, "dataNascita", true));
			this.dataNascitaDateTimePicker.Location = new System.Drawing.Point(897, 69);
			this.dataNascitaDateTimePicker.Name = "dataNascitaDateTimePicker";
			this.dataNascitaDateTimePicker.Size = new System.Drawing.Size(348, 31);
			this.dataNascitaDateTimePicker.TabIndex = 10;
			// 
			// prenotazioniBindingSource1
			// 
			this.prenotazioniBindingSource1.DataMember = "FK_prenotazioni_clienti";
			this.prenotazioniBindingSource1.DataSource = this.clientiBindingSource;
			// 
			// prenotazioniDataGridView1
			// 
			this.prenotazioniDataGridView1.AutoGenerateColumns = false;
			this.prenotazioniDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.prenotazioniDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20});
			this.prenotazioniDataGridView1.DataSource = this.prenotazioniBindingSource1;
			this.prenotazioniDataGridView1.Location = new System.Drawing.Point(23, 134);
			this.prenotazioniDataGridView1.Name = "prenotazioniDataGridView1";
			this.prenotazioniDataGridView1.RowHeadersWidth = 82;
			this.prenotazioniDataGridView1.RowTemplate.Height = 33;
			this.prenotazioniDataGridView1.Size = new System.Drawing.Size(1106, 264);
			this.prenotazioniDataGridView1.TabIndex = 10;
			// 
			// dataGridViewTextBoxColumn11
			// 
			this.dataGridViewTextBoxColumn11.DataPropertyName = "ID_prenotazione";
			this.dataGridViewTextBoxColumn11.HeaderText = "ID_prenotazione";
			this.dataGridViewTextBoxColumn11.MinimumWidth = 10;
			this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
			this.dataGridViewTextBoxColumn11.ReadOnly = true;
			this.dataGridViewTextBoxColumn11.Width = 200;
			// 
			// dataGridViewTextBoxColumn12
			// 
			this.dataGridViewTextBoxColumn12.DataPropertyName = "camera";
			this.dataGridViewTextBoxColumn12.HeaderText = "camera";
			this.dataGridViewTextBoxColumn12.MinimumWidth = 10;
			this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
			this.dataGridViewTextBoxColumn12.Width = 200;
			// 
			// dataGridViewTextBoxColumn13
			// 
			this.dataGridViewTextBoxColumn13.DataPropertyName = "arrivo";
			this.dataGridViewTextBoxColumn13.HeaderText = "arrivo";
			this.dataGridViewTextBoxColumn13.MinimumWidth = 10;
			this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
			this.dataGridViewTextBoxColumn13.Width = 200;
			// 
			// dataGridViewTextBoxColumn14
			// 
			this.dataGridViewTextBoxColumn14.DataPropertyName = "partenza";
			this.dataGridViewTextBoxColumn14.HeaderText = "partenza";
			this.dataGridViewTextBoxColumn14.MinimumWidth = 10;
			this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
			this.dataGridViewTextBoxColumn14.Width = 200;
			// 
			// dataGridViewTextBoxColumn15
			// 
			this.dataGridViewTextBoxColumn15.DataPropertyName = "importo";
			this.dataGridViewTextBoxColumn15.HeaderText = "importo";
			this.dataGridViewTextBoxColumn15.MinimumWidth = 10;
			this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
			this.dataGridViewTextBoxColumn15.Width = 200;
			// 
			// dataGridViewTextBoxColumn16
			// 
			this.dataGridViewTextBoxColumn16.DataPropertyName = "caparra";
			this.dataGridViewTextBoxColumn16.HeaderText = "caparra";
			this.dataGridViewTextBoxColumn16.MinimumWidth = 10;
			this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
			this.dataGridViewTextBoxColumn16.Width = 200;
			// 
			// dataGridViewTextBoxColumn17
			// 
			this.dataGridViewTextBoxColumn17.DataPropertyName = "tipo_struttura";
			this.dataGridViewTextBoxColumn17.HeaderText = "tipo_struttura";
			this.dataGridViewTextBoxColumn17.MinimumWidth = 10;
			this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
			this.dataGridViewTextBoxColumn17.Width = 200;
			// 
			// dataGridViewTextBoxColumn18
			// 
			this.dataGridViewTextBoxColumn18.DataPropertyName = "giorni_permanenza";
			this.dataGridViewTextBoxColumn18.HeaderText = "giorni_permanenza";
			this.dataGridViewTextBoxColumn18.MinimumWidth = 10;
			this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
			this.dataGridViewTextBoxColumn18.Width = 200;
			// 
			// dataGridViewTextBoxColumn19
			// 
			this.dataGridViewTextBoxColumn19.DataPropertyName = "costo_giornaliero";
			this.dataGridViewTextBoxColumn19.HeaderText = "costo_giornaliero";
			this.dataGridViewTextBoxColumn19.MinimumWidth = 10;
			this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
			this.dataGridViewTextBoxColumn19.Width = 200;
			// 
			// dataGridViewTextBoxColumn20
			// 
			this.dataGridViewTextBoxColumn20.DataPropertyName = "cliente";
			this.dataGridViewTextBoxColumn20.HeaderText = "cliente";
			this.dataGridViewTextBoxColumn20.MinimumWidth = 10;
			this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
			this.dataGridViewTextBoxColumn20.Width = 200;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(1286, 65);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(103, 35);
			this.button1.TabIndex = 11;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1564, 561);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.prenotazioniDataGridView1);
			this.Controls.Add(dataNascitaLabel);
			this.Controls.Add(this.dataNascitaDateTimePicker);
			this.Controls.Add(cittaLabel);
			this.Controls.Add(this.cittaComboBox);
			this.Controls.Add(this.prenotazioniDataGridView);
			this.Controls.Add(cognomeLabel);
			this.Controls.Add(this.cognomeTextBox);
			this.Controls.Add(nomeLabel);
			this.Controls.Add(this.nomeTextBox);
			this.Controls.Add(this.clientiBindingNavigator);
			this.Name = "Form2";
			this.Text = "Form2";
			this.Load += new System.EventHandler(this.Form2_Load);
			((System.ComponentModel.ISupportInitialize)(this.dSPrenotazioni)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.clientiBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.clientiBindingNavigator)).EndInit();
			this.clientiBindingNavigator.ResumeLayout(false);
			this.clientiBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.prenotazioniBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.prenotazioniDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cittaBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.prenotazioniBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.prenotazioniDataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DSPrenotazioni dSPrenotazioni;
		private System.Windows.Forms.BindingSource clientiBindingSource;
		private DSPrenotazioniTableAdapters.clientiTableAdapter clientiTableAdapter;
		private DSPrenotazioniTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator clientiBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton clientiBindingNavigatorSaveItem;
		private System.Windows.Forms.TextBox nomeTextBox;
		private System.Windows.Forms.TextBox cognomeTextBox;
		private DSPrenotazioniTableAdapters.prenotazioniTableAdapter prenotazioniTableAdapter;
		private System.Windows.Forms.BindingSource prenotazioniBindingSource;
		private System.Windows.Forms.DataGridView prenotazioniDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
		private System.Windows.Forms.ComboBox cittaComboBox;
		private System.Windows.Forms.BindingSource cittaBindingSource;
		private DSPrenotazioniTableAdapters.cittaTableAdapter cittaTableAdapter;
		private System.Windows.Forms.DateTimePicker dataNascitaDateTimePicker;
		private System.Windows.Forms.BindingSource prenotazioniBindingSource1;
		private System.Windows.Forms.DataGridView prenotazioniDataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
		private System.Windows.Forms.Button button1;
	}
}