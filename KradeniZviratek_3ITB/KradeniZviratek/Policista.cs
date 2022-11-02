using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace KradeniZviratek
{
    internal class Policista
    {
        public string jmeno { get; }
        string[] hodnosti = { "rotmistr", "praporčík", "generál", "velitel" };
        string hodnost;
        Random rnd = new Random();
        

        //TODO barva řidiče --> brutalita --> může rozsekat zvířátko 20%
        public Policista(string jmeno) {
            hodnost = hodnosti[rnd.Next(0, hodnosti.Length+1)];
            this.jmeno = jmeno;
        }

        public bool ZkontrolujKufr(Auto auto) {
            foreach (var item in auto.zviratkaVAute)
            {
                if (item.IsLegal == true || item.IsRozsekane != true)
                {
                    Console.WriteLine("Prošel si celnicí bez problému :)");
                    return true;
                }
                else
                {
                    //TODO seznam zabavených zvířátek
                    Console.WriteLine("Bylo ti zabaveno zvířátko {0}", item.Nazev);
                    Celnice.seznamZabavenychZviratek.Add(item);
                }
            }
            return false;
        }
    }
}
