using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajdiCestu
{
    internal class Enemy : Square
    {
        Random rnd = new Random();
        List<Panel> enemies = new List<Panel>();

        public Enemy(Form1 form) : base (form){
            p.BackColor = Color.Red;
            enemies.Add(base.p);
        }

        public static void VygenerujEnemy(int pocet, Form1 form) {
            for (int i = 0; i < pocet; i++)
            {
                new Enemy(form);
            }
        }
    }
}
