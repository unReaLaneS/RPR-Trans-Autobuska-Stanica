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
    public partial class AutobusUnutra : Form
    {
        private List<Putnik> putnici;
        private FlowLayoutPanel flowLayoutPanel1;
        private Putnik putnik;
        private string tmpMjesto;
        private string tmpDatum;
        private Trans RPRTrans = new Trans();
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

        public AutobusUnutra()
        {
            InitializeComponent();
        }

        public AutobusUnutra(List<Putnik> putnici, FlowLayoutPanel flowLayoutPanel1, Putnik putnik, string tmpMjesto, string tmpDatum, System.Windows.Forms.ContextMenuStrip contextMenuStrip1)
        {
            InitializeComponent();
            this.putnici = putnici;
            this.flowLayoutPanel1 = flowLayoutPanel1;
            this.putnik = putnik;
            this.tmpMjesto = tmpMjesto;
            this.tmpDatum = tmpDatum;
            this.contextMenuStrip1 = contextMenuStrip1;
        }

        private void AutobusUnutra_Load(object sender, EventArgs e)
        {
            RPRTrans.registrujLinije();
            /*List<int> zauzeta = new List<int>();
            List<Image> slike = new List<Image>();
            foreach (Putnik p in putnici)
            {
                for (int j = 0; j < p.Putovanja.Count(); j++)
                {
                    if (p.Putovanja[j].Mjes == tmpMjesto)
                    {
                        if(p.Putovanja[j].D == tmpDatum)
                        {
                            zauzeta.Add(p.Putovanja[j].Sjediste);
                            slike.Add(p.Slika);
                        }
                    }
                }
            }*/
            int test=0;
            int brojac = 0;
            Putnik pomocni=null;
            foreach (Linije l in RPRTrans.Linija)
            {
                if (tmpMjesto == l.dajMjesto())
                {
                    for (int i = 1; i <=l.dajBrojSjedista(); i++)
                    {
                        test = 0;
                        brojac = 0;
                        foreach (Putnik p in putnici)
                        {
                            for (int j = 0; j < p.Putovanja.Count(); j++)
                            {

                                if (p.Putovanja[j].Mjes == tmpMjesto)
                                {
                                    if (p.Putovanja[j].D == tmpDatum)
                                    {
                                        if (p.Putovanja[j].Sjediste == i)
                                        {
                                            brojac = 1;
                                            test = 1;
                                            pomocni = p;
                                            break;
                                        }
                                        /*zauzeta.Add(p.Putovanja[j].Sjediste);
                                        slike.Add(p.Slika);*/
                                    }
                                }
                            }
                            if (brojac == 1) 
                            {
                                break;
                            }
                        }
                        /*if (zauzeta.Count() == 0)
                        {
                            flowLayoutPanel2.Controls.Add(new Sjediste(i, putnici, flowLayoutPanel1, putnik, tmpMjesto, tmpDatum));
                            continue;
                        }
                        
                        test = 0;
                        /*for (int j = 0; j < zauzeta.Count(); j++)
                        {
                                if (test != 0)
                                {
                                    break;
                                }
                                if (zauzeta[j] != i) continue;
                                else { 
                                    test = 1;
                                    brojac = j;
                                     }
                            }*/
                            if (test == 0)
                            {
                                flowLayoutPanel2.Controls.Add(new Sjediste(i, putnici, flowLayoutPanel1, putnik, tmpMjesto, tmpDatum,l.dajCijenu(),contextMenuStrip1));
                            }
                            else flowLayoutPanel2.Controls.Add(new Sjediste(i, putnici, flowLayoutPanel1, putnik, tmpMjesto, tmpDatum,pomocni.Slika,l.dajCijenu(),contextMenuStrip1));
                    }
                }
            }
        }

        private void AutobusUnutra_Deactivate(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
