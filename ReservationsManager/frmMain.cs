﻿using System;
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
	public partial class frmMain : Form
	{

		#region  Menu Management 

		public frmMain()
		{
			InitializeComponent();
		}

		private void prenotazioniToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//create form
			frmPrenotazioni form = new frmPrenotazioni();

			//show form
			form.ShowDialog();
		}

		private void esciToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void clientiToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//create form
			frmClienti form = new frmClienti();

			//show form
			form.ShowDialog();
		}

		#endregion
	}
}
