using DodajPutnikaKontrola;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadaca3RPR
{
    public partial class DodajPutnika : Form
    {
        private List<Putnik> putnici;
        private FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;


        public DodajPutnika()
        {
            InitializeComponent();
        }

        public DodajPutnika(List<Putnik> putnici, FlowLayoutPanel flowLayoutPanel1, System.Windows.Forms.ContextMenuStrip contextMenuStrip1)
        {
            InitializeComponent();
            this.putnici = putnici;
            this.flowLayoutPanel1 = flowLayoutPanel1;
            this.contextMenuStrip1 = contextMenuStrip1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Putnik putnik = userControl11.DajPutnika();
            if (putnik == null) return;
            int povecaj=1;
            foreach (Putnik pomocni in putnici)
            {
                if ((pomocni.Ime == putnik.Ime) && (pomocni.Prezime == putnik.Prezime))
                {
                    povecaj++;
                }
            }
            putnik.BrojPutovanja = povecaj;
            string tmpMjesto = userControl11.DajMjesto();
            string tmpDatum = userControl11.DajDatum();
            AutobusUnutra autobus = new AutobusUnutra(putnici, flowLayoutPanel1,putnik,tmpMjesto,tmpDatum,contextMenuStrip1);
            autobus.Show();
            this.Close();
        }
    }
}
