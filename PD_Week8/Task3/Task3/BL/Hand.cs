using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.BL
{
    public class Hand
    {
        protected List<Card> cards = new List<Card>();

        public void AddCard(Card card)
        {
            cards.Add(card);
        }

        public Card GetCard(int index)
        {
            return cards[index];
        }

        public int GetCardCount()
        {
            return cards.Count;
        }

        public void Display()
        {
            foreach (Card card in cards)
            {
                card.Display();
            }
        }
    }

}
