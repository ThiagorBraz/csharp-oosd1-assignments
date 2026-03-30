using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA3_BlackJack_ThiagoBraz
{
    internal class Deck // CREATED USING CHAT GPT
    {
        // Properties
        public List<Card> cards;
        public static readonly string[] suits = { "Hearts", "Diamonds", "Spades", "Clubs" };
        public static readonly string[] values = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

        //Constructor
        public Deck()
        {
            cards = new List<Card>();

            foreach (var suit in suits)
            {
                foreach (var value in values)
                {
                    cards.Add(new Card(value, suit));

                }
            }
        }
        // Method to shuffle the deck
        public void Shuffle()
        {
            Random rng = new Random();
            int n = cards.Count;

            for (int i = n - 1; i >= 0; i--)
            {
                int j = rng.Next(i + 1);

                var temp = cards[i];
                cards[i] = cards[j];
                cards[j] = temp;
            }

        }
        // Method to draw a card from the top of the deck
        public Card DrawCard()
        {
            if (cards.Count == 0)
                throw new InvalidOperationException("The deck is empty!");

            Card drawnCard = cards[0];
            cards.RemoveAt(0);

            return drawnCard; 
        }
    }
}
