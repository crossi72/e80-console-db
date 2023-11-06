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
	public partial class frmPrenotazioni : Form
	{
		public frmPrenotazioni()
		{
			InitializeComponent();
		}

		private void prenotazioniBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.prenotazioniBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.prenotazioniDataSet);

		}

		private void frmPrenotazioni_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'prenotazioniDataSet.clientiCombo' table. You can move, or remove it, as needed.
			this.clientiComboTableAdapter.Fill(this.prenotazioniDataSet.clientiCombo);
			// TODO: This line of code loads data into the 'prenotazioniDataSet.prenotazioni' table. You can move, or remove it, as needed.
			this.prenotazioniTableAdapter.Fill(this.prenotazioniDataSet.prenotazioni);

		}

		private void btnCliente_Click(object sender, EventArgs e)
		{
			int customerID;
			DataRowView currentRow;

			//get customer's ID
			currentRow = (DataRowView)this.prenotazioniBindingSource.Current;

			customerID = (int)currentRow["cliente"];

			//create customers form
			frmClienti form = new frmClienti(customerID);

			//show customers form
			form.ShowDialog();

			//refresh customers data
			this.clientiComboTableAdapter.Fill(this.prenotazioniDataSet.clientiCombo);
		}
	}
}
