using System;
using System.Collections.Generic;
using System.Text;

namespace McrDigital.Bootcamp1.Cards
{
    public abstract class Deck
    {
        public List<GenericCard> Cards { get; set; }

        public GenericCard Deal()
        {
            var card = this.Cards[0];
            this.Cards.RemoveAt(0);
            return card;
        }

        public abstract void Shuffle();
        public abstract string[] GetCards();
    }
}
