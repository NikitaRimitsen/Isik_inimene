using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isik_inimene
{
    class Opilane : Isik
    {
        public string koolinimi;
        public string klass;
        public string spetsialiseerumine;

        public double tootasu;

        public Opilane(sugu_ Sugu, string nimi = "----", int synd = 0, string koolinimi = "----", string klass = "----", string spetsialiseerumine = "----", double tootasu = 0)
        {
            this.koolinimi = koolinimi;
            this.klass = klass;
            this.spetsialiseerumine = spetsialiseerumine;
            this.tootasu = tootasu;

        }
        /*public Opilane(Opilane.ob) : base(ob)
        {
            this.koolinimi = ob.koolinimi;
            this.klass = klass;
            this.spetsialiseerumine = spetsialiseerumine;

        }*/
        public override void print()
        {
            Console.Write($"Nimi: {nimi} Sugu: {Sugu, -10} Sünnipäev: {synd, -5}"/*,nimi, koolinimi, klass, spetsialiseerumine*/);
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
