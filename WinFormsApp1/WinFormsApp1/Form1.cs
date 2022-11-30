namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Arena a = new Arena("asd");
            //VypisViteze();
        }
        
        //penis
        //public void VypisViteze()
        //{
        //   label1.Text = Arena.ZahajSouboj().Jmenao.ToString();
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            //VypisViteze()
            VypisLeaderboard();
        }
        void VypisLeaderboard() {
            int X = 100;
            int Y = 1;

            for (int i = 0; i < Arena.leaderboard.Count; i++)
            {
                Arena.leaderboard.Add(Arena.leaderboard.ElementAt(i).Key, 0);
                Label p = new Label();
                p.Location = new Point(X, Y + (50 * i));
                p.BackColor = Color.LightBlue;
                p.Width = (Arena.leaderboard.ElementAt(i).Key.Jmeno).Length * 5;
                p.Text = Arena.leaderboard.ElementAt(i).Key.Jmeno;
                p.Height = 50;
                this.Controls.Add(p);
                Y += 40;
            }
        }
        
    }
}

































































































































































































































//��