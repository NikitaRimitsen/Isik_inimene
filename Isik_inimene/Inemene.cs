using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isik_inimene
{
    class Inemene : Isik
    {
        public enum sugu_ { Mees, Naine};
        public sugu_ Sugu;
        public Inemene(sugu_ Sugu, string nimi, int synd/*, char sugu*/)
        {
            this.Sugu = Sugu;
        }
        
        public Inemene(Inemene inemene)
        {
            this.Sugu = inemene.Sugu;
            this.nimi = inemene.nimi;
            this.synd = inemene.synd;
        }
        public override double arvutaSissetulek(double maksuvaba, double tulumaks)
        {
            throw new NotImplementedException();
        }
        /*public override void print_Info()
        {
            Console.WriteLine($"Nimi: {nimi}\n Sugu: {Sugu}\n Sünnipäev: {synd}");
        }*/

    }
}
