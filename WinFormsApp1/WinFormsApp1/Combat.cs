using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Combat
    {
        
        public static Gladiator Souboj(Gladiator A, Gladiator B)
        {
            Gladiator c = null;
            if (A.Hp > 0)
            {
                c = A.Zautoc(B);
                Souboj(B, A);
            }
            return c;
        }
        public static void RegeneraceStaminy(Gladiator gladiator) {
            gladiator.Stamina += (int)(gladiator.Stamina / 4);
        }
        
    }
}
