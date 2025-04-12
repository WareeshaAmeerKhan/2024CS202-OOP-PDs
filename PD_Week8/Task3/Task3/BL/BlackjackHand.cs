using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.BL
{
    public class BlackjackHand : Hand
    {
        public int GetBlackjackValue()
        {
            int val = 0;
            int aceCount = 0;

            for (int i = 0; i < GetCardCount(); i++)
            {
                Card card = GetCard(i);
                int cardValue = card.GetValue();

                if (card.IsAce())
                {
                    aceCount++;
                    val += 1; // Temporarily count Aces as 1
                }
                else if (cardValue > 10) // Jack, Queen, King
                {
                    val += 10;
                }
                else
                {
                    val += cardValue;
                }
            }

            // Adding 10 to Ace which becomes 11 if it doesn't bust
            if (aceCount > 0 && val + 10 <= 21)
            {
                val += 10;
            }

            return val;
        }
    }
}
