using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KradeniZviratek
{
    internal class Zviratko
    {
        string nazev;
        public string Nazev { get { return nazev; } }
        float vaha;
        public float Vaha { get { return vaha; } }
        bool strach;
        bool isLegal;
        public bool IsLegal { get { return isLegal; } }
        bool isRozsekane;
        public bool IsRozsekane { get { return isRozsekane; } }

        static List<Zviratko> mozneZviratka = new List<Zviratko>();

        public Zviratko(string nazev, float vaha, bool isLegal, bool strach = true, bool isRozsekane = false)
        {
            this.strach = strach;
            this.nazev = nazev;
            this.vaha = vaha > 0 ? vaha : 0;
            this.isLegal = isLegal;
            mozneZviratka.Add(this);
        }
       
    }
}
