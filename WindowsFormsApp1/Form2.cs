using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		private void clientiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
			this.Validate();
			this.clientiBindingSource.EndEdit();
			this.tableAdapterManager.UpdateAll(this.dSPrenotazioni);

		}

		private void Form2_Load(object sender, EventArgs e)
		{
			// TODO: This line of code loads data into the 'dSPrenotazioni.citta' table. You can move, or remove it, as needed.
			this.cittaTableAdapter.Fill(this.dSPrenotazioni.citta);
			// TODO: This line of code loads data into the 'dSPrenotazioni.prenotazioni' table. You can move, or remove it, as needed.
			this.prenotazioniTableAdapter.Fill(this.dSPrenotazioni.prenotazioni);
			// TODO: This line of code loads data into the 'dSPrenotazioni.clienti' table. You can move, or remove it, as needed.
			this.clientiTableAdapter.Fill(this.dSPrenotazioni.clienti);

		}

		private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
		{
			this.FilterGrid();
		}

		private void FilterGrid(){
			int customerID;
			DataRowView currentRow;

			currentRow = (DataRowView)this.clientiBindingSource.Current;
			customerID = (int)currentRow["id_cliente"];

			this.prenotazioniBindingSource.Filter = "cliente = " + customerID;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form1 CityForm= new Form1();

			CityForm.ShowDialog();

			this.cittaTableAdapter.Fill(this.dSPrenotazioni.citta);
		}
	}
}
