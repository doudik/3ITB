using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KradeniZviratek
{
    internal class Auto
    {
        int rychlost;
        float vzdalenost;
        float objemKufru;
        float spotreba;
        string nazev; 
        public List<Zviratko> zviratkaVAute = new List<Zviratko>();
        //TODO zatčení
        //TODO pokuta, peníze -> trest?
        //TODO výpis spotřeby --> metoda pro vzdálenost

        public Auto(string nazev, int rychlost, float objemKufru, float spotreba)
        {
            this.rychlost = rychlost;
            this.objemKufru = objemKufru;
            this.spotreba = spotreba;
            this.nazev = nazev;
        }

        public void PridejZvireDoKufru(Zviratko zvire) {
            //TODO přidat list zvířátek
            if (objemKufru >= zvire.Vaha)
            {
                zviratkaVAute.Add(zvire);
                objemKufru -= zvire.Vaha;
                Console.WriteLine("Přidal si zvíře {0}", zvire.Nazev);
            }
            else {
                //TODO rozsekat zvířátko --> hmotnost / 2
                Console.WriteLine("Nevejde se ti zvířátko do kufru");
            }
        }

        //TODO metoda pro rozsekani zviratka
    }
}
