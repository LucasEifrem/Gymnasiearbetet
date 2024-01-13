using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymnasiearbete
{
    internal class Player
    {
        public int playerscore = 0;
        
        public Dictionary<int, Card> Playercards = new Dictionary<int, Card>();
        

        

        public Player() {

            
            for (int i = 1; i <= 5; i++){
                Playercards.Add(i,new Card(Card.Suit.None,Card.Color.None));
            }

        }
        public int CardsNeeded() {
            int amount = 0;
            foreach (var item in Playercards.Keys)
            {

                if (Playercards[item] == new Card(Card.Suit.None, Card.Color.None))
                {
                    amount++;
                }

            }
            return amount;
        }
        public void TakeCard(Card card) {

            if(CardsNeeded() == 0) {return; }

            foreach (var item in Playercards.Keys)
            {
                
                if(Playercards[item] == new Card(Card.Suit.None, Card.Color.None))
                {
                    Playercards[item] = card;
                    break;
                }
                
            }
        }
    }
}
