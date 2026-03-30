using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA3_BlackJack_ThiagoBraz
{
    internal class Card
    {
     //Card properties
        public string Value { get; set; } // card value
        public string Suit {  get; set; } // card suit


        // Constructor
        public Card(string value, string suit) 
        { 
            Value = value;
            Suit = suit;
        }

        // Methods
        public override string ToString()
        {
            return $"{Value} of {Suit}";
        }
    }
}
