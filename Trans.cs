using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca3RPR
{
    public class Trans
    {
        private List<Linije> lin = new List<Linije>();

        public List<Linije> Linija
        {
            get { return lin; }
            set { lin = value; }
        }
        Autobus Isuzu = new Autobus(124854, 25, 11, "Dizalica,zimske gume");
        Autobus Man = new Autobus(328795, 30, 4, "Dizalica,sajla za vucu,sijalice");
        Autobus Mercedes = new Autobus(455855, 20, 35, "Nema");
        Autobus Ikarbus = new Autobus(825392, 40, 12, "Dizalica,zimske gume,sajla za vucu,lanci,rezervna guma");
        public void registrujLinije()
        {
            Linije Tuzla = new Linije(Isuzu, "Sarajevo - Tuzla", 90, 10);
            lin.Add(Tuzla);
            Linije Beograd = new Linije(Man, "Sarajevo - Beograd", 360, 25);
            lin.Add(Beograd);
            Linije Mostar = new Linije(Mercedes, "Sarajevo - Mostar", 180, 20);
            lin.Add(Mostar);
            Linije Neum = new Linije(Ikarbus, "Sarajevo - Neum", 480, 30);
            lin.Add(Neum);
        }
    }
}
