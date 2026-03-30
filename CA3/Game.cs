using System;

namespace CA3_BlackJack_ThiagoBraz
{
    internal class Game
    {
        public Deck deck;
        public Player player;
        public Dealer dealer;

        public Game()
        {
            Console.Write(" Please, enter your name: "); 
            string playerName = Console.ReadLine();
            player = new Player(playerName);
            deck = new Deck();
            dealer = new Dealer();
        }

        public void Start()
        {
            Console.WriteLine();

            Console.WriteLine($"Welcome to BlackJack, {player.Name}!");

            deck.Shuffle();

            // Deal initial cards
            player.Hand.AddCard(deck.DrawCard());
            player.Hand.AddCard(deck.DrawCard());
            dealer.Hand.AddCard(deck.DrawCard());
            dealer.Hand.AddCard(deck.DrawCard());

            // Player's turn
            while (true)
            {
                Console.WriteLine();

                player.ShowHand();

                dealer.ShowHand(false); // Show only the first card of the dealer

                Console.WriteLine("Do you want to (H)it or (S)tand?");
                string choice = Console.ReadLine().ToUpper();

                if (choice == "H")
                {
                    player.Hand.AddCard(deck.DrawCard());

                    if (player.Hand.GetTotalValue() > 21)
                    {
                        Console.WriteLine();
                        Console.WriteLine("<><><><><>BLACKJACK<><><><><>");
                        Console.WriteLine("Final Results:");
                        Console.WriteLine(player.Name + " went bust!");
                        player.ShowHand();
                        dealer.ShowHand(true); // Reveal all dealer's cards
                        Console.WriteLine("Dealer wins!");
                        Console.WriteLine("<><><><><>BLACKJACK<><><><><>");
                        return;
                        
                    }
                }
                else if (choice == "S")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter 'H' or 'S'.");
                }
            }

            // Dealer's turn
            dealer.PlayTurn(deck);

            Console.WriteLine();
            Console.WriteLine("<><><><><>BLACKJACK<><><><><>");
            Console.WriteLine("Final Results:");

            player.ShowHand();
            dealer.ShowHand(true); // Reveal all dealer's cards

            int playerPoints = player.Hand.GetTotalValue();
            int dealerPoints = dealer.Hand.GetTotalValue();

            if (dealerPoints > 21)
            {
                Console.WriteLine("Dealer went bust! " + player.Name + " wins!");
            }
            else if (playerPoints > dealerPoints)
            {
                Console.WriteLine(player.Name + " wins!");
            }
            else if (playerPoints < dealerPoints)
            {
                Console.WriteLine("Dealer wins!");
            }
            else
            {
                Console.WriteLine("It's a tie!");
            }
            Console.WriteLine("<><><><><>BLACKJACK<><><><><>");
        }
    }
}
