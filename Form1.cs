using System.ComponentModel;

namespace Gymnasiearbete
{
    public partial class Form1 : Form
    {
        private Gamer RealGibber = new Gamer();
        private Player Player = new Player();




        public Form1()
        {
            InitializeComponent();
            Player.TakeCard(RealGibber.deck.PopCard());
            Player.TakeCard(RealGibber.deck.PopCard());
            Player.TakeCard(RealGibber.deck.PopCard());
            Player.TakeCard(RealGibber.deck.PopCard());
            Player.TakeCard(RealGibber.deck.PopCard());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RealGibber.GameLoop();

        }




        private void BtnReady_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            string text = "";
            foreach (Card i in Player.Playercards.Values)
            {
                text += i.ToString() + "\n";
            }
            lbltest.Text = text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Player.Playercards.Remove(1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Player.Playercards.Remove(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Player.Playercards.Remove(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Player.Playercards.Remove(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Player.Playercards.Remove(5);
        }
    }
}

