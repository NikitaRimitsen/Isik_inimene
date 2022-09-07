using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isik_inimene
{
    abstract class Isik
    {
        public string nimi;
        public int synd;
        public enum sugu_ { Mees, Naine };
        public sugu_ Sugu;
        private string asutus;
        private string amet;
        private int tootasu;

        public Isik(){}
        public Isik(sugu_ Sugu, string nimi ="----", int synd = 0)
        {
            this.Sugu = Sugu;
            this.nimi = nimi;
            this.synd = synd;
        }
        public Isik(Isik ob)
        {
            this.Sugu = ob.Sugu;
            this.nimi = ob.nimi;
            this.synd = ob.synd;
        }

        protected Isik(string nimi, int synd, string asutus, string amet, int tootasu)
        {
            this.nimi = nimi;
            this.synd = synd;
            this.asutus = asutus;
            this.amet = amet;
            this.tootasu = tootasu;
        }

        public virtual void print()
        {
            Console.Write("{0,-10} {1} {2,4}", nimi, Sugu, synd);
        }
        public int arvutaVanus()
        {
            int vanus = DateTime.Now.Year - synd;
            return vanus;
        }
        public abstract double arvutaSissetulek(double maksuvaba, double tulumaks);

        public void muudaNimi(string uusNimi) { nimi = uusNimi; }
        /*public void muudaSugu(bool uusSugu) { Sugu = uusSugu; }*/
        public void muudaSynd(int uusSynd) { synd = uusSynd; }
    }
}
