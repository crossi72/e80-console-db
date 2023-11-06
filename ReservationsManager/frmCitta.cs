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
	public partial class frmCitta : Form
	{
		public frmCitta()
		{
			InitializeComponent();
		}

		private void cittaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
            this.Validate();
            this.cittaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.prenotazioniDataSet);

        }

		private void frmCitta_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'prenotazioniDataSet.regioni' table. You can move, or remove it, as needed.
            this.regioniTableAdapter.Fill(this.prenotazioniDataSet.regioni);
            // TODO: This line of code loads data into the 'prenotazioniDataSet.citta' table. You can move, or remove it, as needed.
            this.cittaTableAdapter.Fill(this.prenotazioniDataSet.citta);

        }
    }
}
