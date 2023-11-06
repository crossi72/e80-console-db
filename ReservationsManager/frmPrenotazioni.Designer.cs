namespace ReservationsManager
{
	partial class frmPrenotazioni
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
			System.Windows.Forms.Label cameraLabel;
			System.Windows.Forms.Label arrivoLabel;
			System.Windows.Forms.Label partenzaLabel;
			System.Windows.Forms.Label importoLabel;
			System.Windows.Forms.Label caparraLabel;
			System.Windows.Forms.Label tipo_strutturaLabel;
			System.Windows.Forms.Label giorni_permanenzaLabel;
			System.Windows.Forms.Label clienteLabel;
			System.Windows.Forms.Label costo_giornalieroLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrenotazioni));
			this.prenotazioniDataSet = new ReservationsManager.prenotazioniDataSet();
			this.prenotazioniBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.prenotazioniTableAdapter = new ReservationsManager.prenotazioniDataSetTableAdapters.prenotazioniTableAdapter();
			this.tableAdapterManager = new ReservationsManager.prenotazioniDataSetTableAdapters.TableAdapterManager();
			this.prenotazioniBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
			this.prenotazioniBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.cameraTextBox = new System.Windows.Forms.TextBox();
			this.arrivoDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.partenzaDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.importoNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.caparraNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.tipo_strutturaTextBox = new System.Windows.Forms.TextBox();
			this.giorni_permanenzaNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.clienteComboBox = new System.Windows.Forms.ComboBox();
			this.costo_giornalieroNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.clientiComboBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.clientiComboTableAdapter = new ReservationsManager.prenotazioniDataSetTableAdapters.clientiComboTableAdapter();
			this.btnCliente = new System.Windows.Forms.Button();
			cameraLabel = new System.Windows.Forms.Label();
			arrivoLabel = new System.Windows.Forms.Label();
			partenzaLabel = new System.Windows.Forms.Label();
			importoLabel = new System.Windows.Forms.Label();
			caparraLabel = new System.Windows.Forms.Label();
			tipo_strutturaLabel = new System.Windows.Forms.Label();
			giorni_permanenzaLabel = new System.Windows.Forms.Label();
			clienteLabel = new System.Windows.Forms.Label();
			costo_giornalieroLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.prenotazioniDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.prenotazioniBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.prenotazioniBindingNavigator)).BeginInit();
			this.prenotazioniBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.importoNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.caparraNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.giorni_permanenzaNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.costo_giornalieroNumericUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.clientiComboBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// cameraLabel
			// 
			cameraLabel.AutoSize = true;
			cameraLabel.Location = new System.Drawing.Point(48, 68);
			cameraLabel.Name = "cameraLabel";
			cameraLabel.Size = new System.Drawing.Size(89, 25);
			cameraLabel.TabIndex = 1;
			cameraLabel.Text = "camera:";
			// 
			// arrivoLabel
			// 
			arrivoLabel.AutoSize = true;
			arrivoLabel.Location = new System.Drawing.Point(456, 68);
			arrivoLabel.Name = "arrivoLabel";
			arrivoLabel.Size = new System.Drawing.Size(72, 25);
			arrivoLabel.TabIndex = 3;
			arrivoLabel.Text = "arrivo:";
			// 
			// partenzaLabel
			// 
			partenzaLabel.AutoSize = true;
			partenzaLabel.Location = new System.Drawing.Point(864, 68);
			partenzaLabel.Name = "partenzaLabel";
			partenzaLabel.Size = new System.Drawing.Size(102, 25);
			partenzaLabel.TabIndex = 5;
			partenzaLabel.Text = "partenza:";
			// 
			// importoLabel
			// 
			importoLabel.AutoSize = true;
			importoLabel.Location = new System.Drawing.Point(48, 281);
			importoLabel.Name = "importoLabel";
			importoLabel.Size = new System.Drawing.Size(89, 25);
			importoLabel.TabIndex = 7;
			importoLabel.Text = "importo:";
			// 
			// caparraLabel
			// 
			caparraLabel.AutoSize = true;
			caparraLabel.Location = new System.Drawing.Point(365, 281);
			caparraLabel.Name = "caparraLabel";
			caparraLabel.Size = new System.Drawing.Size(91, 25);
			caparraLabel.TabIndex = 9;
			caparraLabel.Text = "caparra:";
			// 
			// tipo_strutturaLabel
			// 
			tipo_strutturaLabel.AutoSize = true;
			tipo_strutturaLabel.Location = new System.Drawing.Point(864, 189);
			tipo_strutturaLabel.Name = "tipo_strutturaLabel";
			tipo_strutturaLabel.Size = new System.Drawing.Size(138, 25);
			tipo_strutturaLabel.TabIndex = 11;
			tipo_strutturaLabel.Text = "tipo struttura:";
			// 
			// giorni_permanenzaLabel
			// 
			giorni_permanenzaLabel.AutoSize = true;
			giorni_permanenzaLabel.Location = new System.Drawing.Point(892, 281);
			giorni_permanenzaLabel.Name = "giorni_permanenzaLabel";
			giorni_permanenzaLabel.Size = new System.Drawing.Size(196, 25);
			giorni_permanenzaLabel.TabIndex = 13;
			giorni_permanenzaLabel.Text = "giorni permanenza:";
			// 
			// clienteLabel
			// 
			clienteLabel.AutoSize = true;
			clienteLabel.Location = new System.Drawing.Point(48, 188);
			clienteLabel.Name = "clienteLabel";
			clienteLabel.Size = new System.Drawing.Size(81, 25);
			clienteLabel.TabIndex = 17;
			clienteLabel.Text = "cliente:";
			// 
			// costo_giornalieroLabel
			// 
			costo_giornalieroLabel.AutoSize = true;
			costo_giornalieroLabel.Location = new System.Drawing.Point(617, 281);
			costo_giornalieroLabel.Name = "costo_giornalieroLabel";
			costo_giornalieroLabel.Size = new System.Drawing.Size(177, 25);
			costo_giornalieroLabel.TabIndex = 18;
			costo_giornalieroLabel.Text = "costo giornaliero:";
			// 
			// prenotazioniDataSet
			// 
			this.prenotazioniDataSet.DataSetName = "prenotazioniDataSet";
			this.prenotazioniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// prenotazioniBindingSource
			// 
			this.prenotazioniBindingSource.DataMember = "prenotazioni";
			this.prenotazioniBindingSource.DataSource = this.prenotazioniDataSet;
			// 
			// prenotazioniTableAdapter
			// 
			this.prenotazioniTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.cittaTableAdapter = null;
			this.tableAdapterManager.clientiComboTableAdapter = null;
			this.tableAdapterManager.clientiTableAdapter = null;
			this.tableAdapterManager.prenotazioniTableAdapter = this.prenotazioniTableAdapter;
			this.tableAdapterManager.regioniTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = ReservationsManager.prenotazioniDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
			// 
			// prenotazioniBindingNavigator
			// 
			this.prenotazioniBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
			this.prenotazioniBindingNavigator.BindingSource = this.prenotazioniBindingSource;
			this.prenotazioniBindingNavigator.CountItem = this.bindingNavigatorCountItem;
			this.prenotazioniBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
			this.prenotazioniBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.prenotazioniBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.prenotazioniBindingNavigatorSaveItem});
			this.prenotazioniBindingNavigator.Location = new System.Drawing.Point(0, 0);
			this.prenotazioniBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
			this.prenotazioniBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
			this.prenotazioniBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
			this.prenotazioniBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
			this.prenotazioniBindingNavigator.Name = "prenotazioniBindingNavigator";
			this.prenotazioniBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
			this.prenotazioniBindingNavigator.Size = new System.Drawing.Size(1306, 42);
			this.prenotazioniBindingNavigator.TabIndex = 0;
			this.prenotazioniBindingNavigator.Text = "bindingNavigator1";
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
			// prenotazioniBindingNavigatorSaveItem
			// 
			this.prenotazioniBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.prenotazioniBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("prenotazioniBindingNavigatorSaveItem.Image")));
			this.prenotazioniBindingNavigatorSaveItem.Name = "prenotazioniBindingNavigatorSaveItem";
			this.prenotazioniBindingNavigatorSaveItem.Size = new System.Drawing.Size(46, 36);
			this.prenotazioniBindingNavigatorSaveItem.Text = "Save Data";
			this.prenotazioniBindingNavigatorSaveItem.Click += new System.EventHandler(this.prenotazioniBindingNavigatorSaveItem_Click);
			// 
			// cameraTextBox
			// 
			this.cameraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prenotazioniBindingSource, "camera", true));
			this.cameraTextBox.Location = new System.Drawing.Point(53, 109);
			this.cameraTextBox.Name = "cameraTextBox";
			this.cameraTextBox.Size = new System.Drawing.Size(368, 31);
			this.cameraTextBox.TabIndex = 0;
			// 
			// arrivoDateTimePicker
			// 
			this.arrivoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.prenotazioniBindingSource, "arrivo", true));
			this.arrivoDateTimePicker.Location = new System.Drawing.Point(461, 107);
			this.arrivoDateTimePicker.Name = "arrivoDateTimePicker";
			this.arrivoDateTimePicker.Size = new System.Drawing.Size(368, 31);
			this.arrivoDateTimePicker.TabIndex = 1;
			// 
			// partenzaDateTimePicker
			// 
			this.partenzaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.prenotazioniBindingSource, "partenza", true));
			this.partenzaDateTimePicker.Location = new System.Drawing.Point(869, 107);
			this.partenzaDateTimePicker.Name = "partenzaDateTimePicker";
			this.partenzaDateTimePicker.Size = new System.Drawing.Size(368, 31);
			this.partenzaDateTimePicker.TabIndex = 2;
			// 
			// importoNumericUpDown
			// 
			this.importoNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.prenotazioniBindingSource, "importo", true));
			this.importoNumericUpDown.DecimalPlaces = 2;
			this.importoNumericUpDown.Location = new System.Drawing.Point(53, 323);
			this.importoNumericUpDown.Name = "importoNumericUpDown";
			this.importoNumericUpDown.Size = new System.Drawing.Size(204, 31);
			this.importoNumericUpDown.TabIndex = 5;
			this.importoNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// caparraNumericUpDown
			// 
			this.caparraNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.prenotazioniBindingSource, "caparra", true));
			this.caparraNumericUpDown.DecimalPlaces = 2;
			this.caparraNumericUpDown.Location = new System.Drawing.Point(370, 323);
			this.caparraNumericUpDown.Name = "caparraNumericUpDown";
			this.caparraNumericUpDown.Size = new System.Drawing.Size(204, 31);
			this.caparraNumericUpDown.TabIndex = 6;
			this.caparraNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// tipo_strutturaTextBox
			// 
			this.tipo_strutturaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.prenotazioniBindingSource, "tipo_struttura", true));
			this.tipo_strutturaTextBox.Location = new System.Drawing.Point(869, 218);
			this.tipo_strutturaTextBox.Name = "tipo_strutturaTextBox";
			this.tipo_strutturaTextBox.Size = new System.Drawing.Size(368, 31);
			this.tipo_strutturaTextBox.TabIndex = 4;
			// 
			// giorni_permanenzaNumericUpDown
			// 
			this.giorni_permanenzaNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.prenotazioniBindingSource, "giorni_permanenza", true));
			this.giorni_permanenzaNumericUpDown.Location = new System.Drawing.Point(897, 323);
			this.giorni_permanenzaNumericUpDown.Name = "giorni_permanenzaNumericUpDown";
			this.giorni_permanenzaNumericUpDown.Size = new System.Drawing.Size(204, 31);
			this.giorni_permanenzaNumericUpDown.TabIndex = 8;
			this.giorni_permanenzaNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// clienteComboBox
			// 
			this.clienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.prenotazioniBindingSource, "cliente", true));
			this.clienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientiComboBindingSource, "nome", true));
			this.clienteComboBox.DataSource = this.clientiComboBindingSource;
			this.clienteComboBox.DisplayMember = "nome";
			this.clienteComboBox.FormattingEnabled = true;
			this.clienteComboBox.Location = new System.Drawing.Point(53, 216);
			this.clienteComboBox.Name = "clienteComboBox";
			this.clienteComboBox.Size = new System.Drawing.Size(368, 33);
			this.clienteComboBox.TabIndex = 3;
			this.clienteComboBox.ValueMember = "id_cliente";
			// 
			// costo_giornalieroNumericUpDown
			// 
			this.costo_giornalieroNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.prenotazioniBindingSource, "costo_giornaliero", true));
			this.costo_giornalieroNumericUpDown.DecimalPlaces = 2;
			this.costo_giornalieroNumericUpDown.Location = new System.Drawing.Point(622, 323);
			this.costo_giornalieroNumericUpDown.Name = "costo_giornalieroNumericUpDown";
			this.costo_giornalieroNumericUpDown.Size = new System.Drawing.Size(204, 31);
			this.costo_giornalieroNumericUpDown.TabIndex = 7;
			this.costo_giornalieroNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// clientiComboBindingSource
			// 
			this.clientiComboBindingSource.DataMember = "clientiCombo";
			this.clientiComboBindingSource.DataSource = this.prenotazioniDataSet;
			// 
			// clientiComboTableAdapter
			// 
			this.clientiComboTableAdapter.ClearBeforeFill = true;
			// 
			// btnCliente
			// 
			this.btnCliente.Location = new System.Drawing.Point(461, 218);
			this.btnCliente.Name = "btnCliente";
			this.btnCliente.Size = new System.Drawing.Size(52, 39);
			this.btnCliente.TabIndex = 19;
			this.btnCliente.Text = "...";
			this.btnCliente.UseVisualStyleBackColor = true;
			this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
			// 
			// frmPrenotazioni
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1306, 525);
			this.Controls.Add(this.btnCliente);
			this.Controls.Add(costo_giornalieroLabel);
			this.Controls.Add(this.costo_giornalieroNumericUpDown);
			this.Controls.Add(clienteLabel);
			this.Controls.Add(this.clienteComboBox);
			this.Controls.Add(giorni_permanenzaLabel);
			this.Controls.Add(this.giorni_permanenzaNumericUpDown);
			this.Controls.Add(tipo_strutturaLabel);
			this.Controls.Add(this.tipo_strutturaTextBox);
			this.Controls.Add(caparraLabel);
			this.Controls.Add(this.caparraNumericUpDown);
			this.Controls.Add(importoLabel);
			this.Controls.Add(this.importoNumericUpDown);
			this.Controls.Add(partenzaLabel);
			this.Controls.Add(this.partenzaDateTimePicker);
			this.Controls.Add(arrivoLabel);
			this.Controls.Add(this.arrivoDateTimePicker);
			this.Controls.Add(cameraLabel);
			this.Controls.Add(this.cameraTextBox);
			this.Controls.Add(this.prenotazioniBindingNavigator);
			this.Name = "frmPrenotazioni";
			this.Text = "frmPrenotazioni";
			this.Load += new System.EventHandler(this.frmPrenotazioni_Load);
			((System.ComponentModel.ISupportInitialize)(this.prenotazioniDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.prenotazioniBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.prenotazioniBindingNavigator)).EndInit();
			this.prenotazioniBindingNavigator.ResumeLayout(false);
			this.prenotazioniBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.importoNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.caparraNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.giorni_permanenzaNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.costo_giornalieroNumericUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.clientiComboBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private prenotazioniDataSet prenotazioniDataSet;
		private System.Windows.Forms.BindingSource prenotazioniBindingSource;
		private prenotazioniDataSetTableAdapters.prenotazioniTableAdapter prenotazioniTableAdapter;
		private prenotazioniDataSetTableAdapters.TableAdapterManager tableAdapterManager;
		private System.Windows.Forms.BindingNavigator prenotazioniBindingNavigator;
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
		private System.Windows.Forms.ToolStripButton prenotazioniBindingNavigatorSaveItem;
		private System.Windows.Forms.TextBox cameraTextBox;
		private System.Windows.Forms.DateTimePicker arrivoDateTimePicker;
		private System.Windows.Forms.DateTimePicker partenzaDateTimePicker;
		private System.Windows.Forms.NumericUpDown importoNumericUpDown;
		private System.Windows.Forms.NumericUpDown caparraNumericUpDown;
		private System.Windows.Forms.TextBox tipo_strutturaTextBox;
		private System.Windows.Forms.NumericUpDown giorni_permanenzaNumericUpDown;
		private System.Windows.Forms.ComboBox clienteComboBox;
		private System.Windows.Forms.NumericUpDown costo_giornalieroNumericUpDown;
		private System.Windows.Forms.BindingSource clientiComboBindingSource;
		private prenotazioniDataSetTableAdapters.clientiComboTableAdapter clientiComboTableAdapter;
		private System.Windows.Forms.Button btnCliente;
	}
}