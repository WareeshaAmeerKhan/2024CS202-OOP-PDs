using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3.BL
{
    public class Card
    {
        private int value;
        private string suit;

        public Card(int value, string suit)
        {
            this.value = value;
            this.suit = suit;
        }

        public int GetValue()
        {
            return value;
        }

        public bool IsAce()
        {
            if (value == 1)
                return true;
            else
                return false;
        }

        public void Display()
        {
            string name;
            switch (value)
            {
                case 1:
                    name = "Ace";
                    break;
                case 11:
                    name = "Jack";
                    break;
                case 12:
                    name = "Queen";
                    break;
                case 13:
                    name = "King";
                    break;
                default:
                    name = value.ToString();
                    break;
            }

            Console.WriteLine(name+" of "+suit);
        }
    }

}
