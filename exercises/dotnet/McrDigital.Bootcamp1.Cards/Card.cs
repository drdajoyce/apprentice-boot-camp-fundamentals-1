using System;
using System.Collections.Generic;
using System.Text;

namespace McrDigital.Bootcamp1.Cards
{
     public class Card
    {
        public Suit suit { get; }
        public FaceValue value { get; }

        public Card( Suit suit, FaceValue value)
        {
            this.suit = suit;
            this.value = value;
        }

    }
}
