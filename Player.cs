using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymnasiearbete
{
    internal class Player
    {
        
        public List<Card> Playercards = new List<Card>();
            public void Addcard(Card card){

                Playercards.Add(card);

            }
        public int Amount => Playercards.Count();

        
        
        public Player() {

            for (int amount = Amount; amount < 5; amount++)
            {
                Addcard(new );
            }

        }

    }
}
