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
	public partial class frmRegioni : Form
	{
		public frmRegioni()
		{
			InitializeComponent();
		}

		private void regioniBindingNavigatorSaveItem_Click(object sender, EventArgs e)
		{
            this.Validate();
            this.regioniBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.prenotazioniDataSet);

        }

		private void frmRegioni_Load(object sender, EventArgs e)
		{
            // TODO: This line of code loads data into the 'prenotazioniDataSet.areeGeograficheCombo' table. You can move, or remove it, as needed.
            this.areeGeograficheComboTableAdapter.Fill(this.prenotazioniDataSet.areeGeograficheCombo);
            // TODO: This line of code loads data into the 'prenotazioniDataSet.citta' table. You can move, or remove it, as needed.
            this.cittaTableAdapter.Fill(this.prenotazioniDataSet.citta);
            // TODO: This line of code loads data into the 'prenotazioniDataSet.regioni' table. You can move, or remove it, as needed.
            this.regioniTableAdapter.Fill(this.prenotazioniDataSet.regioni);

        }
    }
}
