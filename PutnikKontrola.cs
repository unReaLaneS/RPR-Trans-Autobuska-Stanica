using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DodajPutnikaKontrola;

namespace Zadaca3RPR
{
    public partial class PutnikKontrola : UserControl
    {
        private string imenica;

        public string Imenica
        {
            get { return imenica; }
            set { imenica = value; }
        }
        private string prezimenica;

        public string Prezimenica
        {
            get { return prezimenica; }
            set { prezimenica = value; }
        }
        private int brojanica;
        Datum pomocni;

        public Datum Pomocni
        {
            get { return pomocni; }
            set { pomocni = value; }
        }
        public PutnikKontrola(Putnik p)
        {
            InitializeComponent();
            pictureBox1.BackgroundImage = p.Slika;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            label1.Text = p.Ime + " " + p.Prezime;
            imenica = p.Ime;
            prezimenica = p.Prezime;
            brojanica = p.BrojPutovanja;
            pomocni = p.Putovanja[0];
        }
        public string dajIme() 
        {
            return imenica;
        }
        public string dajPrezime() 
        { 
            return prezimenica;
        }
        public int dajBroj()
        {
            return brojanica;
        }
        public void izmijeni()
        {
            label1.Text = Imenica + " " + Prezimenica;
        }

    }
}
