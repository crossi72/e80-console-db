namespace ReservationsManager
{
	partial class frmClienti
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClienti));
			System.Windows.Forms.Label nomeLabel;
			System.Windows.Forms.Label cognomeLabel;
			System.Windows.Forms.Label dataNascitaLabel;
			System.Windows.Forms.Label cittaLabel1;
			this.prenotazioniDataSet = new ReservationsManager.prenotazioniDataSet();
			this.clientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.clientiTableAdapter = new ReservationsManager.prenotazioniDataSetTableAdapters.clientiTableAdapter();
			this.tableAdapterManager = new ReservationsManager.prenotazioniDataSetTableAdapters.TableAdapterManager();
			this.clientiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
			this.clientiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
			this.nomeTextBox = new System.Windows.Forms.TextBox();
			this.cognomeTextBox = new System.Windows.Forms.TextBox();
			this.dataNascitaDateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.cittaComboBox = new System.Windows.Forms.ComboBox();
			this.cittaBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.cittaTableAdapter = new ReservationsManager.prenotazioniDataSetTableAdapters.cittaTableAdapter();
			nomeLabel = new System.Windows.Forms.Label();
			cognomeLabel = new System.Windows.Forms.Label();
			dataNascitaLabel = new System.Windows.Forms.Label();
			cittaLabel1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.prenotazioniDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.clientiBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.clientiBindingNavigator)).BeginInit();
			this.clientiBindingNavigator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cittaBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// prenotazioniDataSet
			// 
			this.prenotazioniDataSet.DataSetName = "prenotazioniDataSet";
			this.prenotazioniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// clientiBindingSource
			// 
			this.clientiBindingSource.DataMember = "clienti";
			this.clientiBindingSource.DataSource = this.prenotazioniDataSet;
			// 
			// clientiTableAdapter
			// 
			this.clientiTableAdapter.ClearBeforeFill = true;
			// 
			// tableAdapterManager
			// 
			this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
			this.tableAdapterManager.cittaTableAdapter = this.cittaTableAdapter;
			this.tableAdapterManager.clienti_backupTableAdapter = null;
			this.tableAdapterManager.clientiTableAdapter = this.clientiTableAdapter;
			this.tableAdapterManager.prenotazioniTableAdapter = null;
			this.tableAdapterManager.regioniTableAdapter = null;
			this.tableAdapterManager.UpdateOrder = ReservationsManager.prenotazioniDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
			this.clientiBindingNavigator.Size = new System.Drawing.Size(1198, 42);
			this.clientiBindingNavigator.TabIndex = 0;
			this.clientiBindingNavigator.Text = "bindingNavigator1";
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
			// bindingNavigatorCountItem
			// 
			this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
			this.bindingNavigatorCountItem.Size = new System.Drawing.Size(70, 36);
			this.bindingNavigatorCountItem.Text = "of {0}";
			this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
			// 
			// bindingNavigatorSeparator1
			// 
			this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
			this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
			this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 42);
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
			// bindingNavigatorDeleteItem
			// 
			this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
			this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
			this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
			this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(46, 36);
			this.bindingNavigatorDeleteItem.Text = "Delete";
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
			// nomeLabel
			// 
			nomeLabel.AutoSize = true;
			nomeLabel.Location = new System.Drawing.Point(133, 106);
			nomeLabel.Name = "nomeLabel";
			nomeLabel.Size = new System.Drawing.Size(71, 25);
			nomeLabel.TabIndex = 1;
			nomeLabel.Text = "nome:";
			// 
			// nomeTextBox
			// 
			this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientiBindingSource, "nome", true));
			this.nomeTextBox.Location = new System.Drawing.Point(210, 103);
			this.nomeTextBox.Name = "nomeTextBox";
			this.nomeTextBox.Size = new System.Drawing.Size(365, 31);
			this.nomeTextBox.TabIndex = 2;
			// 
			// cognomeLabel
			// 
			cognomeLabel.AutoSize = true;
			cognomeLabel.Location = new System.Drawing.Point(604, 106);
			cognomeLabel.Name = "cognomeLabel";
			cognomeLabel.Size = new System.Drawing.Size(106, 25);
			cognomeLabel.TabIndex = 3;
			cognomeLabel.Text = "cognome:";
			// 
			// cognomeTextBox
			// 
			this.cognomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientiBindingSource, "cognome", true));
			this.cognomeTextBox.Location = new System.Drawing.Point(716, 103);
			this.cognomeTextBox.Name = "cognomeTextBox";
			this.cognomeTextBox.Size = new System.Drawing.Size(365, 31);
			this.cognomeTextBox.TabIndex = 4;
			// 
			// dataNascitaLabel
			// 
			dataNascitaLabel.AutoSize = true;
			dataNascitaLabel.Location = new System.Drawing.Point(60, 172);
			dataNascitaLabel.Name = "dataNascitaLabel";
			dataNascitaLabel.Size = new System.Drawing.Size(138, 25);
			dataNascitaLabel.TabIndex = 5;
			dataNascitaLabel.Text = "data Nascita:";
			// 
			// dataNascitaDateTimePicker
			// 
			this.dataNascitaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientiBindingSource, "dataNascita", true));
			this.dataNascitaDateTimePicker.Location = new System.Drawing.Point(204, 168);
			this.dataNascitaDateTimePicker.Name = "dataNascitaDateTimePicker";
			this.dataNascitaDateTimePicker.Size = new System.Drawing.Size(371, 31);
			this.dataNascitaDateTimePicker.TabIndex = 6;
			// 
			// cittaLabel1
			// 
			cittaLabel1.AutoSize = true;
			cittaLabel1.Location = new System.Drawing.Point(652, 168);
			cittaLabel1.Name = "cittaLabel1";
			cittaLabel1.Size = new System.Drawing.Size(58, 25);
			cittaLabel1.TabIndex = 9;
			cittaLabel1.Text = "citta:";
			// 
			// cittaComboBox
			// 
			this.cittaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cittaBindingSource, "citta", true));
			this.cittaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clientiBindingSource, "citta", true));
			this.cittaComboBox.DataSource = this.cittaBindingSource;
			this.cittaComboBox.DisplayMember = "citta";
			this.cittaComboBox.FormattingEnabled = true;
			this.cittaComboBox.Location = new System.Drawing.Point(716, 165);
			this.cittaComboBox.Name = "cittaComboBox";
			this.cittaComboBox.Size = new System.Drawing.Size(365, 33);
			this.cittaComboBox.TabIndex = 10;
			this.cittaComboBox.ValueMember = "ID_citta";
			// 
			// cittaBindingSource
			// 
			this.cittaBindingSource.DataMember = "citta";
			this.cittaBindingSource.DataSource = this.prenotazioniDataSet;
			// 
			// cittaTableAdapter
			// 
			this.cittaTableAdapter.ClearBeforeFill = true;
			// 
			// frmClienti
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1198, 450);
			this.Controls.Add(cittaLabel1);
			this.Controls.Add(this.cittaComboBox);
			this.Controls.Add(dataNascitaLabel);
			this.Controls.Add(this.dataNascitaDateTimePicker);
			this.Controls.Add(cognomeLabel);
			this.Controls.Add(this.cognomeTextBox);
			this.Controls.Add(nomeLabel);
			this.Controls.Add(this.nomeTextBox);
			this.Controls.Add(this.clientiBindingNavigator);
			this.Name = "frmClienti";
			this.Text = "Anagrafica clienti";
			this.Load += new System.EventHandler(this.frmClienti_Load);
			((System.ComponentModel.ISupportInitialize)(this.prenotazioniDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.clientiBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.clientiBindingNavigator)).EndInit();
			this.clientiBindingNavigator.ResumeLayout(false);
			this.clientiBindingNavigator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.cittaBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private prenotazioniDataSet prenotazioniDataSet;
		private System.Windows.Forms.BindingSource clientiBindingSource;
		private prenotazioniDataSetTableAdapters.clientiTableAdapter clientiTableAdapter;
		private prenotazioniDataSetTableAdapters.TableAdapterManager tableAdapterManager;
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
		private System.Windows.Forms.DateTimePicker dataNascitaDateTimePicker;
		private prenotazioniDataSetTableAdapters.cittaTableAdapter cittaTableAdapter;
		private System.Windows.Forms.ComboBox cittaComboBox;
		private System.Windows.Forms.BindingSource cittaBindingSource;
	}
}

