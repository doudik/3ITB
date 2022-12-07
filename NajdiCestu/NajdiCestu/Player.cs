using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajdiCestu
{
    internal class Player : Square
    {
        public string name { get; }
        public List<Moves> listOfMoves = new List<Moves>();

        public Player(string name, Form1 form) : base(form){
            this.name = name;
            p.BackColor = Color.Black;
            p.Location = new Point(form.panel_gamePanel.Width / 2 - 50, form.panel_gamePanel.Height / 2 - 50);
            form.panel_gamePanel.Controls.Add(p); 
        }

    }
}
