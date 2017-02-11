using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamologep
{
    class Calculator
    {
        // +
        public static int Osszead(int egyikszam, int masikszam)
        {
            return egyikszam + masikszam;
        }
        // -
        public static int Kivon(int egyikszam, int masikszam)
        {
            return egyikszam - masikszam;
        }
        // *
        public static int Szorzas(int egyikszam, int masikszam)
        {
            return egyikszam * masikszam;
        }
        // /
        public static int Osztas(int egyikszam, int masikszam)
        {
            return egyikszam / masikszam;
        }

        // C
        public static int Torol(int egyikszam, int masikszam)
        {
            return 0;
        }

        // CE
        public static int FullTorol(int egyikszam, int masikszam)
        {
            return 0; ;
        }
    }
}
