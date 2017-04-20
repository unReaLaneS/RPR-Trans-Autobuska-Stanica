using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca3RPR
{
    public class Linije
    {
        private string mjesto;
        private DateTime vrijeme;
        private int trajanje;
        private double cijena;
        private Autobus auto;
        public Linije(Autobus a, string i, int j, double k)
        {
            mjesto = i;
            trajanje = j;
            cijena = k;
            vrijeme = DateTime.Now;
            auto = a;
        }
        public string dajMjesto()
        {
            return mjesto;
        }
        public int dajBrojSjedista()
        {
            return auto.dajSjedista();
        }
        public double dajCijenu() 
        {
            return cijena;
        }
    }
}
