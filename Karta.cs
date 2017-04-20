using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DodajPutnikaKontrola; 

namespace Zadaca3RPR
{
    public partial class Karta : Form
    {
        private List<DodajPutnikaKontrola.Putnik> putnici;
        private FlowLayoutPanel flowLayoutPanel1;
        private DodajPutnikaKontrola.Putnik putnik;
        private string tmpMjesto;
        private string tmpDatum;
        private int tmpBrojSjedista;
        private double cijena;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

        public Karta()
        {
            InitializeComponent();
        }

        public Karta(List<Putnik> putnici, FlowLayoutPanel flowLayoutPanel1, Putnik putnik, string tmpMjesto, string tmpDatum, int tmpBrojSjedista, double cijena, System.Windows.Forms.ContextMenuStrip contextMenuStrip1)
        {
            InitializeComponent();
            this.putnici = putnici;
            this.flowLayoutPanel1 = flowLayoutPanel1;
            this.putnik = putnik;
            this.tmpMjesto = tmpMjesto;
            this.tmpDatum = tmpDatum;
            this.tmpBrojSjedista = tmpBrojSjedista;
            this.cijena = cijena;
            this.contextMenuStrip1 = contextMenuStrip1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((putnik.BrojPutovanja >= 5) || (putnik.Popust=true)) 
            {
                cijena = cijena - (cijena * 0.1);
            }
            Datum dat =new Datum(tmpDatum,tmpMjesto,cijena,tmpBrojSjedista);
            putnik.Putovanja.Add(dat);
            putnici.Add(putnik);
            PutnikKontrola temp = new PutnikKontrola(putnik);
            temp.ContextMenuStrip = contextMenuStrip1;
            flowLayoutPanel1.Controls.Add(temp);
            this.Close();
            
        }
            
    }
}
