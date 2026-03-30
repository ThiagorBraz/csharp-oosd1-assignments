using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA3_BlackJack_ThiagoBraz
{
    internal class Hand
    {
        //cards in the hand
        public List<Card> Cards;

        public Hand()
        {
            Cards = new List<Card>();
        }

        //add a card to the hand
        public void AddCard(Card card)
        {
            Cards.Add(card);

        }
        //method to calculate the total value of the hand - Created using ChatGPT

        public Card GetFirstCard()
        {
            if (Cards.Count > 0)
            {
                return Cards[0];
            }
            else
            {
                throw new InvalidOperationException("The hand is empty!");
            }
        }
        public int GetTotalValue()
        {
            int total = 0;
            int aceValue = 0;

            foreach (var card in Cards)
            {
                if (int.TryParse(card.Value, out int numericValue))
                {
                    total += numericValue;
                }

                else if (card.Value == "A")
                {
                    aceValue++;
                    total += 11;
                }

                else
                {
                    total += 10;
                }

                // adjust the ace value if the total exceeds 21
                while (total > 21 && aceValue > 0)
                {
                    total -= 10; // Treat ace as 1 instead of 11 as set initally
                    aceValue --;
                }
            }

            return total;
        }
        //Method to display the cards in the hand
        public override string ToString()
        {
            return string.Join(", ", Cards.Select(card => card.ToString()));
        }
    }
}
