using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA3_BlackJack_ThiagoBraz
{
    internal class Player

        // Properties
    {
        public string Name { get; set; }
        public Hand Hand { get; set; }

        // Constructor
        public Player(string name)
        {
            Name = name;
            Hand = new Hand();
        }

        // Method to display the player's hand
        public void ShowHand()
        {
            Console.WriteLine($"{Name}'s hand: {Hand}");
            Console.WriteLine($"Total points: {Hand.GetTotalValue()}");
        }
    
    } 
}
