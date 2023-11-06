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
		private int id_cliente;

		/// <summary>
		/// Constructor used to show all customers
		/// </summary>
		public frmClienti()
		{
			this.Init(0);
		}

		/// <summary>
		/// Constructor used to show only one customer
		/// </summary>
		/// <param name="customer">The ID of the customer</param>
		public frmClienti(int customer)
		{
			this.Init(customer);
		}

		private void Init(int customer){
			InitializeComponent();

			this.id_cliente = customer;
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

			if (this.id_cliente != 0){
				//filter customers table
				this.prenotazioniDataSet.Tables["clienti"].DefaultView.RowFilter = "ID_cliente = " + this.id_cliente;
			}
		}

		private void btnCitta_Click(object sender, EventArgs e)
		{
			//open city menagement form
			frmCitta form = new frmCitta();
			form.ShowDialog();

			//update customers data
			this.cittaTableAdapter.Fill(this.prenotazioniDataSet.citta);
		}
	}
}
