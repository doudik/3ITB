using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NajdiCestu
{
    internal class Square
    {
        protected Random rnd = new Random();
        protected Panel p;

        public Square(Form1 form) {
            p = new Panel();
            p.Height = 50;
            p.Width = 50;
            //MessageBox.Show(form.Width.ToString());
            int X = rnd.Next(0, form.Width);
            X -= X % 50;
            int Y = rnd.Next(0, form.Height);
            Y -= Y % 50;
            p.Location = new Point(X, Y);
            form.Controls.Add(p);
            
        }
    }
}
