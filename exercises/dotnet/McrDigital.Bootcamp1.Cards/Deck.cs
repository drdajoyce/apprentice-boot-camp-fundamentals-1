using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace McrDigital.Bootcamp1.Cards
{
    public abstract class Deck : IEnumerable<GenericCard>
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

        public IEnumerator<GenericCard> GetEnumerator()
        {
            return Cards.GetEnumerator();

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
