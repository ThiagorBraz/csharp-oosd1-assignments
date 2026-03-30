using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA3_BlackJack_ThiagoBraz
{
    internal class Dealer
    {
        public Hand Hand { get; set; } // Properties

        // Constructor
        public Dealer()
        {
            Hand = new Hand();
        }

        // Dealer's logic to draw cards until reaching at least 17 points
        public void PlayTurn(Deck deck)
        {
            while (Hand.GetTotalValue() < 17)
            {
                Hand.AddCard(deck.DrawCard());
            }
        }

        // Method to display the dealer's hand - Created using ChatGPT
        public void ShowHand(bool revealAllCards = false)
        {
            if (revealAllCards)
            {
                Console.WriteLine($"Dealer's final hand: {Hand}");
                Console.WriteLine($"Dealer's total points: {Hand.GetTotalValue()}");
            }
            else
            {
                // Show only the first card, hide the rest
                Console.WriteLine($"Dealer's hand: {Hand.GetFirstCard()}, [Hidden]");
            }
        }
    }

}
