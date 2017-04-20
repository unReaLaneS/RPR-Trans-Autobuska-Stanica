using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca3RPR
{
    public class Autobus
    {
        private int tablice;
        private int brojSjedista;
        private int brojSasije;
        private string dodatnaOprema;

        public Autobus(int i = 0, int j = 20, int k = 0, string s = "<oprema>")
        {
            tablice = i; brojSjedista = j; brojSasije = k; dodatnaOprema = s;
        }
        public int dajSjedista()
        {
            return this.brojSjedista;
        }
    }
}
