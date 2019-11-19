using System;
using System.Collections.Generic;
using System.Text;

namespace McrDigital.Bootcamp1.Cards
{
    class PlayingCardDeck : Deck
    {
        public PlayingCardDeck()
        {
            Cards = new List<GenericCard>();



            PopulateDeck(Cards);
        }

        public override string[] GetCards()
        {
            var result = new String[52];

            var suits = new Suit[]{
                new Suit("clubs"),
                new Suit("diamonds"),
                new Suit("hearts"),
                new Suit("spades") };

            var faceValues = new FaceValue[]
            {
             new FaceValue("ace"),
             new FaceValue("2"),
             new FaceValue("3"),
             new FaceValue("4"),
             new FaceValue("5"),
             new FaceValue("6"),
             new FaceValue("7"),
             new FaceValue("8"),
             new FaceValue("9"),
             new FaceValue("10"),
             new FaceValue("jack"),
             new FaceValue("queen"),
             new FaceValue("king")

        };

            var deck = new List<Card>();

            foreach (var suit in suits)
            {
                foreach (var faceValue in faceValues)
                {
                    var card = new Card(suit, faceValue);
                    deck.Add(card);
                }
            }
            var cardNumber = 0;
            foreach (var card in deck)
            {
                result[cardNumber] = $"{card.value.valueName}";
                cardNumber++;
            }
            return result;
        }

        public override void Shuffle()
        {
            this.Cards.KnuthShuffle();
        }

        public static void PopulateDeck(List<GenericCard> deck)
        {
            var suits = new Suit[]{
                new Suit("clubs"),
                new Suit("diamonds"),
                new Suit("hearts"),
                new Suit("spades") };

            var faceValues = new FaceValue[]
            {
             new FaceValue("ace"),
             new FaceValue("2"),
             new FaceValue("3"),
             new FaceValue("4"),
             new FaceValue("5"),
             new FaceValue("6"),
             new FaceValue("7"),
             new FaceValue("8"),
             new FaceValue("9"),
             new FaceValue("10"),
             new FaceValue("jack"),
             new FaceValue("queen"),
             new FaceValue("king")

        };

            foreach (var suit in suits)
            {
                foreach (var faceValue in faceValues)
                {
                    var card = new Card(suit, faceValue);
                    deck.Add(card);
                }
            }
        }
    }

}