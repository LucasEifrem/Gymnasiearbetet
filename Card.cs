using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Security;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Gymnasiearbete
{
    internal class Card
    {
        public enum Suit
        {
            None = 0,
            Ace = 1,
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Ten = 10,
            Knight = 11,
            Queen = 12,
            King = 13,
            
        }
        public enum Color{
            None = 0,
            Hearts = 1, 
            Spades = 2,
            Diamonds = 3,
            Clubs = 4,
        }

        public Suit suit { get; set; }
        public Color color { get; set; }

        public override string ToString() {
            return "Suit: "+ suit.ToString() + " Color"+ color.ToString();
            
        }
        public Card(Suit suit_, Color color_)
        {
            suit = suit_;
            color = color_;

            
            
            
        }
    }
}
