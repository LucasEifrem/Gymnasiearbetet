namespace Gymnasiearbete
{
    public partial class Form1 : Form
    {
        private Deck Testdeck;



        public Form1()
        {
            InitializeComponent();
            Testdeck = new Deck();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string combinedString = "";
            foreach (Card card in Testdeck.Deckcard)
            {
                combinedString += card.ToString();
            }
            label1.Text = combinedString;
            //label1.Text = new Card(Card.Suit.King,Card.Color.Hearts).ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}

