using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Gymnasiearbete
{
    internal class Deck
    {

        public Stack<Card>  Deckcard = new Stack<Card>();
        public Random Rnd = new Random();

        public Deck() {
            Rnd = new Random();
            for (int i = 1; i < 5; i++) {
            for (int j = 1; j < 14; j++) {
                    Deckcard.Push(new Card((Card.Suit)j, (Card.Color)i));

                }
            }
        }

        public  void Shuffle( List<Card> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                int num = Rnd.Next(list.Count);
                Card temp = list[i];
                list[i] = list[num];
                list[num] = temp;
            }
        }
        public void Shuffle(Stack<Card> stack)
        {
            List<Card> list = stack.ToList();
            Shuffle(list);
            stack = ToStack(list);
        }
        public static Stack<Card> ToStack(List<Card> list)
        {
            Stack<Card> stack = new Stack<Card>();
            foreach (Card t in list)
                stack.Push(t);

            return stack;
        }

        public Card PopCard ()
        {
            return Deckcard.Pop();
        }

    }
}
