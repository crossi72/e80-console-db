using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservationsManager
{
	public partial class frmClienti : Form
	{
		public frmClienti()
		{
			InitializeComponent();
		}

		private void clientiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.clientiBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.prenotazioniDataSet);

		}

		private void frmClienti_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'prenotazioniDataSet.prenotazioni' table. You can move, or remove it, as needed.
			this.prenotazioniTableAdapter.Fill(this.prenotazioniDataSet.prenotazioni);
			// TODO: This line of code loads data into the 'prenotazioniDataSet.citta' table. You can move, or remove it, as needed.
			this.cittaTableAdapter.Fill(this.prenotazioniDataSet.citta);
			// TODO: This line of code loads data into the 'prenotazioniDataSet.clienti' table. You can move, or remove it, as needed.
			this.clientiTableAdapter.Fill(this.prenotazioniDataSet.clienti);

		}

		private void btnCitta_Click(object sender, EventArgs e)
		{
			//open city menagement form
			frmCitta form = new frmCitta();
			form.ShowDialog();

			//update customers data
			this.cittaTableAdapter.Fill(this.prenotazioniDataSet.citta);
			//int customerID;
			DataRowView currentRow;

			currentRow = (DataRowView)this.clientiBindingSource.Current;

			this.prenotazioniDataSet.Tables["clienti"].DefaultView.RowFilter = " 1 = 2";
		}
	}
}
