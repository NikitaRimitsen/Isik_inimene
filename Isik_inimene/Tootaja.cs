using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isik_inimene
{
    class Tootaja : Isik
    {
        private string asutus;
        public string amet;
        public int tootasu;

        public Tootaja(sugu_ Sugu, string nimi, int synd, string asutus, string amet, int tootasu) : base(nimi, synd, asutus, amet, tootasu)
        {
            this.asutus = asutus;
            this.amet = amet;  
            this.tootasu = tootasu;
        }
        public override void print()
        {
            Console.Write("{0,-25} {1, -25} {2}", asutus, amet, tootasu);
        }
        public override double arvutaSissetulek(double maksuvaba, double tulumaks)
        {
            double nalog = (tootasu - maksuvaba) * (tulumaks / 100);
            double neto = tootasu - nalog;
            return neto;
        }

        public virtual void vanus()
        {
            arvutaVanus();
        }
    }
}
