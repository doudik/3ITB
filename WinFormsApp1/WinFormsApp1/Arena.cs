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
        public static Dictionary<Gladiator, int> leaderboard = new Dictionary<Gladiator, int>();
        static Random rnd = new Random();
        // [ARENA]
        //* List<Gladiator>
        //* traps? 💀
        private string jmeno;
        public Arena(string jmeno) {
            this.jmeno = jmeno;
            NagenerujGladiatory(12);
            ZahajSouboj();
        }

        public static bool SlaplDoTrapy(Gladiator gladiator)
        {
            return 35 - gladiator.Obratnost < rnd.Next(100);
        }
        public static Gladiator ZahajSouboj() {
            Gladiator C = null;
            if (Arena.leaderboard.Count >= 2)
            {
                //TODO vybrat dva sousední gladiátory
                for (int i = 0; i < leaderboard.Count; i++)
                {
                    Gladiator A = Arena.leaderboard.ElementAt(i).Key;
                    Arena.leaderboard.Remove(A);
                    Gladiator B =Arena.leaderboard.ElementAt(i+1).Key;
                    Arena.leaderboard.Remove(B);
                    i++;
                    C = Combat.Souboj(A, B);
                    Arena.leaderboard.Add(C, 1);

                }
                //TODO zahájit souboj a přidat jim +1
                

                //Gladiator A = Arena.leaderboard[rnd.Next(0, Arena.gladiatorList.Count)];
                //Arena.gladiatorList.Remove(A);
                //Gladiator B = Arena.gladiatorList[rnd.Next(0, Arena.gladiatorList.Count)];
                //Arena.gladiatorList.Remove(B);
                //C = Combat.Souboj(A, B);
                //Arena.gladiatorList.Add(C);
                
                //Console.WriteLine("Vyhrál {0}", C.Jmeno);
            }
            else {
                //Console.WriteLine("Vrátil jsem gladiátora {0}", Arena.gladiatorList[0].Jmeno);
                return Arena.leaderboard.ElementAt(0).Key;
            }
            return C;
        }
        void NagenerujGladiatory(int pocet)
        {

            for (int i = 0; i < pocet; i++)
            {
                new Gladiator(GenerateName(rnd.Next(5, 20)), rnd.Next(10, 25), rnd.Next(50, 200), rnd.Next(20, 40), rnd.Next(10, 25), rnd.Next(10, 25));
            }
        }
        public static string GenerateName(int len)
        {
            Random r = new Random();
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
            string[] vowels = { "a", "e", "i", "o", "u", "ae", "y" };
            string Name = "";
            Name += consonants[r.Next(consonants.Length)].ToUpper();
            Name += vowels[r.Next(vowels.Length)];
            int b = 2; //b tells how many times a new letter has been added. It's 2 right now because the first two letters are already in the name.
            while (b < len)
            {
                Name += consonants[r.Next(consonants.Length)];
                b++;
                Name += vowels[r.Next(vowels.Length)];
                b++;
            }

            return Name;


        }
    } 
}
