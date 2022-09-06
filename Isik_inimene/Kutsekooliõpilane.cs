using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isik_inimene
{
    class Kutsekooliopilane : Isik
    {
        public string oppeasutus;
        public string eriala;
        public int kursus;
        public int toetus;
        public double tootasu;

        public Kutsekooliopilane(sugu_ Sugu, string nimi = "----", int synd = 0, string oppeasutus = "----", string eriala = "----", int kursus = 0, int toetus = 0, double tootasu = 0)
        {
            this.oppeasutus = oppeasutus;
            this.eriala = eriala;
            this.kursus = kursus;
            this.toetus = toetus;
            this.tootasu = tootasu;
        }
        public override void print()
        {
            Console.Write("{0,-25} {1, -25} {2} {3}",oppeasutus, eriala, kursus, toetus);
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
