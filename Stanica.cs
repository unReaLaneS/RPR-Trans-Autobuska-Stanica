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
    public partial class Stanica : Form
    {
        public Stanica()
        {
            InitializeComponent();
        }

        private void krajToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private List<Putnik> putnici = new List<Putnik>();
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DodajPutnika p = new DodajPutnika(putnici,flowLayoutPanel1,contextMenuStrip1);
            p.Show();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            toolStripTextBox1.SelectAll();
        }

        private void brisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem t = sender as ToolStripMenuItem;
            ContextMenuStrip c = t.Owner as ContextMenuStrip;
            PutnikKontrola k = c.SourceControl as PutnikKontrola;
            flowLayoutPanel1.Controls.Remove(k);
            foreach (Putnik p in putnici)
            {
                if ((p.Ime == k.dajIme()) && (p.Prezime == k.dajPrezime()) && (p.BrojPutovanja == k.dajBroj()))
                {
                    putnici.Remove(p);  
                    break;
                }
            }
        }
        delegate void Delegat(string rijec);
        Delegat del;

        private void PoImenu(string rijec)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (Putnik k in putnici)
            {
                if (k.Ime.Contains(rijec))
                {
                    PutnikKontrola m = new PutnikKontrola(k);
                    flowLayoutPanel1.Controls.Add(m);
                    m.ContextMenuStrip = contextMenuStrip1;
                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (del == null) return;
            if (putnici.Count() == 0) return;
            if (toolStripTextBox1.Text == "Search...") 
            {
                if (putnici.Count() != 0)
                {
                    flowLayoutPanel1.Controls.Clear();
                    foreach (Putnik p in putnici)
                    {
                        PutnikKontrola m = new PutnikKontrola(p);
                        flowLayoutPanel1.Controls.Add(m);
                        m.ContextMenuStrip = contextMenuStrip1;
                    }
                }
                else return; 
            }
            toolStripStatusLabel1.Text = "Hvala vam na vasem povjerenju!";
            toolStripStatusLabel1.ForeColor = SystemColors.ControlText;
            del(toolStripTextBox1.Text);
        }

        private void poImenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            del = new Delegat(PoImenu);
        }

        private void poPrezimenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            del = new Delegat(PoPrezimenu);
        }

        private void PoPrezimenu(string rijec)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (Putnik k in putnici)
            {
                if (k.Prezime.Contains(rijec))
                {
                    PutnikKontrola m = new PutnikKontrola(k);
                    flowLayoutPanel1.Controls.Add(m);
                    m.ContextMenuStrip = contextMenuStrip1;
                }
            }
        }

        private void poBrojuPutovanjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            del = new Delegat(PoBroju);
        }

        private void PoBroju(string rijec)
        {
            /*else if (toolStripTextBox1.Text.Contains("A")) 
            {
                return;
            }*/
            int broj;
            if (int.TryParse(rijec, out broj))
            {
                flowLayoutPanel1.Controls.Clear();
                foreach (Putnik k in putnici)
                {

                    if (k.BrojPutovanja == broj)
                    {
                        PutnikKontrola m = new PutnikKontrola(k);
                        flowLayoutPanel1.Controls.Add(m);
                        m.ContextMenuStrip = contextMenuStrip1;
                    }
                }
            }
            else 
            {
                flowLayoutPanel1.Controls.Clear();
                foreach (Putnik p in putnici)
                {
                    PutnikKontrola m = new PutnikKontrola(p);
                    flowLayoutPanel1.Controls.Add(m);
                    m.ContextMenuStrip = contextMenuStrip1;
                }
                toolStripStatusLabel1.Text = "Ne mozete pretrazivati po broju, a unositi slova!";
                toolStripStatusLabel1.ForeColor = System.Drawing.Color.Red;
                return;
            }


            }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem t = sender as ToolStripMenuItem;
            ContextMenuStrip c = t.Owner as ContextMenuStrip;
            PutnikKontrola k = c.SourceControl as PutnikKontrola;
            Uredi ured = new Uredi(k);
            ured.Show();

        }

        private void obrisiSveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            putnici.Clear();
        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DodajPutnika p = new DodajPutnika(putnici, flowLayoutPanel1, contextMenuStrip1);
            p.Show();
        }


       /* private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (Putnik k in putnici)
            {
                if (k.Ime.Contains(toolStripTextBox1.Text))
                {
                    PutnikKontrola m = new PutnikKontrola(k);
                    flowLayoutPanel1.Controls.Add(m);
                    m.ContextMenuStrip = contextMenuStrip1;
                }
            }

        }*/
    }
}
