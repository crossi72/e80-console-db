namespace ReservationsManager
{
	partial class frmMain
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolStrip2 = new System.Windows.Forms.ToolStrip();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.prenotazioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clientiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
			this.esciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cittàToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.regioniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton1});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1285, 42);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolStrip2
			// 
			this.toolStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
			this.toolStrip2.Location = new System.Drawing.Point(0, 42);
			this.toolStrip2.Name = "toolStrip2";
			this.toolStrip2.Size = new System.Drawing.Size(1285, 25);
			this.toolStrip2.TabIndex = 1;
			this.toolStrip2.Text = "toolStrip2";
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prenotazioniToolStripMenuItem,
            this.clientiToolStripMenuItem,
            this.cittàToolStripMenuItem,
            this.regioniToolStripMenuItem});
			this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(163, 36);
			this.toolStripDropDownButton1.Text = "&Anagrafiche";
			// 
			// prenotazioniToolStripMenuItem
			// 
			this.prenotazioniToolStripMenuItem.Name = "prenotazioniToolStripMenuItem";
			this.prenotazioniToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
			this.prenotazioniToolStripMenuItem.Text = "&Prenotazioni";
			this.prenotazioniToolStripMenuItem.Click += new System.EventHandler(this.prenotazioniToolStripMenuItem_Click);
			// 
			// clientiToolStripMenuItem
			// 
			this.clientiToolStripMenuItem.Name = "clientiToolStripMenuItem";
			this.clientiToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
			this.clientiToolStripMenuItem.Text = "&Clienti";
			this.clientiToolStripMenuItem.Click += new System.EventHandler(this.clientiToolStripMenuItem_Click);
			// 
			// toolStripDropDownButton2
			// 
			this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.esciToolStripMenuItem});
			this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
			this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
			this.toolStripDropDownButton2.Size = new System.Drawing.Size(73, 36);
			this.toolStripDropDownButton2.Text = "&File";
			// 
			// esciToolStripMenuItem
			// 
			this.esciToolStripMenuItem.Name = "esciToolStripMenuItem";
			this.esciToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
			this.esciToolStripMenuItem.Text = "&Esci";
			this.esciToolStripMenuItem.Click += new System.EventHandler(this.esciToolStripMenuItem_Click);
			// 
			// cittàToolStripMenuItem
			// 
			this.cittàToolStripMenuItem.Name = "cittàToolStripMenuItem";
			this.cittàToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
			this.cittàToolStripMenuItem.Text = "C&ittà";
			this.cittàToolStripMenuItem.Click += new System.EventHandler(this.cittàToolStripMenuItem_Click);
			// 
			// regioniToolStripMenuItem
			// 
			this.regioniToolStripMenuItem.Name = "regioniToolStripMenuItem";
			this.regioniToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
			this.regioniToolStripMenuItem.Text = "Regioni";
			this.regioniToolStripMenuItem.Click += new System.EventHandler(this.regioniToolStripMenuItem_Click);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1285, 660);
			this.Controls.Add(this.toolStrip2);
			this.Controls.Add(this.toolStrip1);
			this.Name = "frmMain";
			this.Text = "Gestione Prenotazioni Alberghiere";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStrip toolStrip2;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
		private System.Windows.Forms.ToolStripMenuItem prenotazioniToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clientiToolStripMenuItem;
		private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
		private System.Windows.Forms.ToolStripMenuItem esciToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cittàToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem regioniToolStripMenuItem;
	}
}