using System;
using System.Collections.Generic;
using System.Text;

namespace McrDigital.Bootcamp1.Cards
{
    class SuperDeck : Deck
    {
        public SuperDeck()
        {
            Cards = new List<GenericCard>();

            var animalDeck = new AnimalDeck();
            var playingCardDeck = new PlayingCardDeck();

            foreach (var animalCard in animalDeck)
            {
                Cards.Add(animalCard);
            }

            foreach (var playingCard in playingCardDeck)
            {
                Cards.Add(playingCard);
            }

        }

        public override string[] GetCards()
        {
            var result = new String[this.Cards.Count];
            for (var index = 0; index < this.Cards.Count; index++)
            {
                var card = this.Cards[index]; result[index] = card.CardValue;
            }
            return result;
        }

        public override void Shuffle()
        {
            this.Cards.KnuthShuffle();
        }
    }
}
