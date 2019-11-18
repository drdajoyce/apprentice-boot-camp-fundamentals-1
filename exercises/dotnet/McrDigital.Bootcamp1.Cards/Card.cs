using System;
using System.Collections.Generic;
using System.Text;

namespace McrDigital.Bootcamp1.Cards
{
     public class Card
    {
        public int suit { get; }
        public int value { get; }

        public Card( int suit, int value)
        {
            this.suit = suit;
            this.value = value;
        }

    }
}
