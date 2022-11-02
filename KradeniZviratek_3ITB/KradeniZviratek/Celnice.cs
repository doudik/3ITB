using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KradeniZviratek
{
    internal class Celnice
    {
        string nazev, stat;
        // int pocetMistProZviratka = 5; TODO věznice pro zvířátka
        //bool večeře?
        List<Policista> policistiNaCelnici = new List<Policista>();
        public static List<Zviratko> seznamZabavenychZviratek = new List<Zviratko>();
        //list aut na celnici?

        public Celnice(string nazev, string stat) {
            this.nazev = nazev;
            this.stat = stat;
        }
        public void PridejPolicistu(Policista policista)
        {
            policistiNaCelnici.Add(policista);
        }

    }
}
