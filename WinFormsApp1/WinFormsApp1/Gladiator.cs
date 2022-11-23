using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Gladiator
    {
        //[GLADIATOR]
        static int potrebnaStaminaNaUtok;
        bool jeHezkej;
        int sila, hp, zbroj, utok, stamina;
        public int Stamina { get; set; }
          
        public int Zbroj {get {return zbroj;} }
        public int Hp { get { return hp;  } set { hp = value; } }
        public int Utok { get { return utok; } }
        string jmeno;
        public string Jmeno { get; }
        int obratnost;
        public int Obratnost { get { return obratnost; } }

        public Gladiator(string jmeno, int sila, int hp, int zbroj, int stamina,  int obratnost)
        {
            this.jeHezkej = false;
            this.sila = sila;
            utok = sila * 10;
            this.hp = hp;
            this.zbroj = zbroj;
            this.stamina = stamina;
            this.jmeno = jmeno;
            this.obratnost = obratnost;
            Arena.gladiatorList.Add(this);
        }
        public Gladiator Zautoc(Gladiator souper) {
            Random rnd = new Random();
            if (this.Hp > 0 && souper.Hp > 0) 
            {
                if (!Arena.SlaplDoTrapy(this))
                {
                    if (this.stamina >= potrebnaStaminaNaUtok)
                    {
                        if (10 + souper.obratnost <= rnd.Next(0, 100))
                        {
                            //vyhnul sem se

                        }
                        else {
                            if (this.Utok - (int)(souper.Zbroj / 5) > 0) { //redukce dmg
                                this.stamina -= potrebnaStaminaNaUtok;
                                souper.Hp -= this.Utok - (int)(souper.Zbroj / 5);

                            }
                        }
                    }
                    else {
                        Combat.RegeneraceStaminy(this);
                    }
                }
                else
                {
                    this.Hp -= rnd.Next((int)(this.Hp / 20), (int)(this.Hp / 10));
                    //slapnul do trapky
                }
            }
            else {
                return this;
            }
            Combat.RegeneraceStaminy(this);
            return null;
        }
    }
}
