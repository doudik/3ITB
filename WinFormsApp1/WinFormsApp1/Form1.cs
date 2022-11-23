namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Arena a = new Arena("asd");
            VypisViteze();
        }
        /*
         * TODO
         * [GLADIATOR]
         * bool jeHezkej;
         * int sila, hp, zbroj, stamina
         * string jmeno;
         * int obratnost;
         * [ARENA]
         * List<Gladiator>
         * traps?           Náhodná šance na dmg?
         * [COMBAT]
         * Utok(Gladiator A, Gladiator B)
         * RegeneraceStaminy()
         * Obrana()
         * VyhnutiUtoku()
         * [LEADERBOARD]
         * List<Gladiator>
         * int rank;
         */

        public void VypisViteze()
        {
            label1.Text = Arena.gladiatorList.ElementAt(0).Jmeno;
           // label1.Text = Arena.ZahajSouboj().Jmeno.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //VypisViteze();
        }
    }
}

































































































































































































































//��