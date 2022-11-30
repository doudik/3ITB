namespace _01_Enum
{
    public partial class Form1 : Form
    {
        Clovek Karel;
        public Form1()
        {
            InitializeComponent();
            Karel = new Clovek("Karel", Pohlavi.Man, Levels.Hard);
            Karel.l = Levels.Easy;
            label1.Text = Karel.jmeno + " | " + Karel.p.ToString() + " | "  +
                Karel.l.ToString(); 

        }


    }
}