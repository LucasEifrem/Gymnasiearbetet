using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gymnasiearbete
{
    internal class Gamer
    {
        List<Player> players = new List<Player>();
        public  Deck deck = new Deck();
        public bool PlayerIsReady = false;
        public bool CardsDealt = false;
        
        
        public bool WinScore() {
        foreach (Player player in players) { 
            if (player.playerscore >= 52) {
                return true;
                }
            }
        return false;
        }
        public void GameLoop() {
        while (WinScore() == false) {
                foreach (Player player in players)
                {
                    if (CardsDealt == false)
                    {
                        for (int i = 0; i <= player.CardsNeeded(); i++)
                        {
                            Card tempcard = deck.PopCard();
                            player.TakeCard(tempcard);
                        }
                    }
                    if (PlayerIsReady) {

                    }
                    }
                
                return;
            }



        }


    }
}
