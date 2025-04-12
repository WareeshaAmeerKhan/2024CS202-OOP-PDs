using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task3.BL;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option = 0;
            do
            {
                Console.WriteLine("Enter 1 to play the game.");
                Console.WriteLine("Enter 2 to exit the game.");
                option = int.Parse(Console.ReadLine());
                Console.Clear();

                if (option == 1)
                {
                    Deck deck = new Deck();
                    deck.Shuffle();

                    BlackjackHand player = new BlackjackHand();
                    BlackjackHand dealer = new BlackjackHand();

                    player.AddCard(deck.DealCard());
                    player.AddCard(deck.DealCard());
                    dealer.AddCard(deck.DealCard());
                    dealer.AddCard(deck.DealCard());

                    Console.WriteLine("Your cards:");
                    player.Display();

                    Console.WriteLine("Dealer shows:");
                    dealer.GetCard(0).Display();

                    bool playerBusted = false;

                    // Player's turn
                    while (true)
                    {
                        Console.WriteLine("Your total: " + player.GetBlackjackValue());
                        Console.Write("Hit or Stand? (h/s): ");
                        string choice = Console.ReadLine();

                        if (choice == "h")
                        {
                            player.AddCard(deck.DealCard());
                            Console.WriteLine("You drew:");
                            player.GetCard(player.GetCardCount() - 1).Display();

                            if (player.GetBlackjackValue() > 21)
                            {
                                Console.WriteLine("You busted! Dealer wins.");
                                playerBusted = true;
                                break;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }

                    // Dealer's turn
                    if (!playerBusted)
                    {
                        Console.WriteLine("\nDealer's turn...");
                        dealer.Display();

                        while (dealer.GetBlackjackValue() < 17)
                        {
                            dealer.AddCard(deck.DealCard());
                            Console.WriteLine("Dealer hits:");
                            dealer.GetCard(dealer.GetCardCount() - 1).Display();
                        }

                        int playerVal = player.GetBlackjackValue();
                        int dealerVal = dealer.GetBlackjackValue();

                        Console.WriteLine("\nYour total: "+playerVal+" Dealer total: "+dealerVal);

                        if (dealerVal > 21 || playerVal > dealerVal)
                            Console.WriteLine("You win!");
                        else if (playerVal < dealerVal)
                            Console.WriteLine("Dealer wins!");
                        else
                            Console.WriteLine("It's a tie!");
                    }

                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (option != 2);
        }

    }
}
