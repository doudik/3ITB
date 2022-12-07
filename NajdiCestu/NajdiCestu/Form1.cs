namespace NajdiCestu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            new EndPoint(this);
            new Player("Gandalf", this);
            Enemy.VygenerujEnemy(30, this);
        }
    }
}