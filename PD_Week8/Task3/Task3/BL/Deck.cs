using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.BL
{
    public class Deck
    {
        private List<Card> cards;
        private Random rand = new Random();

        public Deck()
        {
            cards = new List<Card>();
            string[] suits = { "Hearts", "Spades", "Clubs", "Diamonds" };

            for (int i = 1; i <= 13; i++) // 1 = Ace, 11 = Jack, etc.
            {
                foreach (string suit in suits)
                {
                    cards.Add(new Card(i, suit));
                }
            }
        }

        public void Shuffle()
        {
            for (int i = 0; i < cards.Count; i++)
            {
                int j = rand.Next(i, cards.Count);
                var temp = cards[i];
                cards[i] = cards[j];
                cards[j] = temp;
            }
        }

        public Card DealCard()
        {
            Card c = cards[0];
            cards.RemoveAt(0);
            return c;
        }
    }

}
