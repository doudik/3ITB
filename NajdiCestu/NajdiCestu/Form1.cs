namespace NajdiCestu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Height = 700;
            this.Width = 700;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Player p1 = new Player("Gandalf", this);
            Enemy.VygenerujEnemy(10, this);
        }
    }
}