using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Enum
{
    internal class Clovek
    {
        public string jmeno { get; private set; }
        public Pohlavi p;
        public Levels l;

        public Clovek(string jmeno, Pohlavi p, Levels l) {
            this.p = p;
            this.jmeno = jmeno;
            this.l = l;
        }
    }
}
