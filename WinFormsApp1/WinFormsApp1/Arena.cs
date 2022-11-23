using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    internal class Arena
    {
        public static List<Gladiator> gladiatorList = new List<Gladiator>();
        static Random rnd = new Random();
        // [ARENA]
        //* List<Gladiator>
        //* traps? 💀
        private string jmeno;
        public Arena(string jmeno) {
            this.jmeno = jmeno;
            NagenerujGladiatory();
            ZahajSouboj();
        }

        public static bool SlaplDoTrapy(Gladiator gladiator)
        {
            return 35 - gladiator.Obratnost < rnd.Next(100);
        }
        public static Gladiator ZahajSouboj() {
            Gladiator C;
            if (Arena.gladiatorList.Count >= 2)
            {
                Gladiator A = Arena.gladiatorList[rnd.Next(0, Arena.gladiatorList.Count)];
                Gladiator B = Arena.gladiatorList[rnd.Next(0, Arena.gladiatorList.Count)];
                C = Combat.Souboj(A, B);
                Arena.gladiatorList.Add(C);
                //Arena.gladiatorList.Remove(A);
                //Arena.gladiatorList.Remove(B);
                
                //Console.WriteLine("Vyhrál {0}", C.Jmeno);
            }
            else {
                //Console.WriteLine("Vrátil jsem gladiátora {0}", Arena.gladiatorList[0].Jmeno);
                return Arena.gladiatorList[0];
            }
            return C;
        }
        void NagenerujGladiatory() {
            Gladiator g1 = new Gladiator("franta", 10, 10, 20, 50, 10);
            Gladiator g2 = new Gladiator("pepek", 20, 20, 40, 50, 10);
        }
    } 
}
