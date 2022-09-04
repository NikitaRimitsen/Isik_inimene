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
        //public char sugu;
        /*protected enum Sugu { mees, naine};
        protected Sugu sugu;*/

        public Isik() {}
        public Isik(/*char sugu = 'x'/*Sugu sugu*//*,*/ string nimi ="----", int synd = 0)
        {
            this.nimi = nimi;
            this.synd = synd;
            //this.sugu = sugu;
        }
        public Isik(Isik ob)
        {
            this.nimi = ob.nimi;
            this.synd = ob.synd;
            //this.sugu = ob.sugu;
        }

        public virtual void print()
        {
            Console.Write("{0,-10} {1} {2,4}", nimi, /*sugu,*/ synd);
        }
        public int arvutaVanus()
        {
            int vanus = DateTime.Now.Year - synd;
            return vanus;
        }
        public abstract double arvutaSissetulek(double maksuvaba, double tulumaks);
        public abstract void print_Info();
    }
}
