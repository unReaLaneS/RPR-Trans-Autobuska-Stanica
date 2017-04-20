using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadaca3RPR
{
    public partial class Sjediste : UserControl
    {
        private List<DodajPutnikaKontrola.Putnik> putnici;
        private FlowLayoutPanel flowLayoutPanel1;
        private DodajPutnikaKontrola.Putnik putnik;
        private string tmpMjesto;
        private string tmpDatum;
        private bool mozeSeKliknuti;
        private double cijena;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

        public Sjediste(int i, List<DodajPutnikaKontrola.Putnik> putnici, FlowLayoutPanel flowLayoutPanel1, DodajPutnikaKontrola.Putnik putnik, string tmpMjesto, string tmpDatum, double p, System.Windows.Forms.ContextMenuStrip contextMenuStrip1)
        {
            InitializeComponent();
            this.label1.Text = Convert.ToString(i);
            this.putnici = putnici;
            this.flowLayoutPanel1 = flowLayoutPanel1;
            this.putnik = putnik;
            this.tmpMjesto = tmpMjesto;
            this.tmpDatum = tmpDatum;
            this.cijena = p;
            this.contextMenuStrip1 = contextMenuStrip1;
        }

        public Sjediste(int i, List<DodajPutnikaKontrola.Putnik> putnici, FlowLayoutPanel flowLayoutPanel1, DodajPutnikaKontrola.Putnik putnik, string tmpMjesto, string tmpDatum, Image image, double p, System.Windows.Forms.ContextMenuStrip contextMenuStrip1)
        {
            InitializeComponent();
            this.label1.Text = Convert.ToString(i);
            this.putnici = putnici;
            this.flowLayoutPanel1 = flowLayoutPanel1;
            this.putnik = putnik;
            this.tmpMjesto = tmpMjesto;
            this.tmpDatum = tmpDatum;
            this.pictureBox1.BackgroundImage = image;
            this.cijena = p;
            this.contextMenuStrip1 = contextMenuStrip1;
            this.mozeSeKliknuti = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (mozeSeKliknuti == true) return;
            int tmpBrojSjedista = Convert.ToInt16(this.label1.Text);
            Karta k = new Karta(putnici, flowLayoutPanel1, putnik, tmpMjesto, tmpDatum, tmpBrojSjedista,cijena,contextMenuStrip1);
            k.Show();
            k.Focus();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            if (mozeSeKliknuti == true) return;
           int tmpBrojSjedista = Convert.ToInt16(this.label1.Text);
            Karta k = new Karta(putnici, flowLayoutPanel1, putnik, tmpMjesto, tmpDatum, tmpBrojSjedista,cijena,contextMenuStrip1);
            k.Show();
            k.Focus();
        }
    }
}
