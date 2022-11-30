using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajdiCestu
{
    internal class Player
    {
        public string name { get; }
        public List<Moves> listOfMoves = new List<Moves>();

        public Player(string name, Form1 form) {
            this.name = name;
            Panel p = new Panel();
            p.Width = 50;
            p.Height = 50;
            p.BackColor = Color.Black;
            p.Location = new Point(form.Width / 2 - 50, form.Height / 2 - 50);
            form.Controls.Add(p); 
        }

    }
}
