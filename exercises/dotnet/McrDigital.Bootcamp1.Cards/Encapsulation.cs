namespace McrDigital.Bootcamp1.Cards {
  using System;

  public class Encapsulation {
    static void Main(string[] args) {
      var encapsulation = new Encapsulation();
      var deckInOrder = encapsulation.GetCards();
      foreach (var card in deckInOrder) {
        Console.WriteLine(card);
      }
    }

    public string[] GetCards() {
      var result = new String[52];

      var deck = new Card[52];

      for (var suit = 0; suit < 4; suit++) {
        for (var faceValue = 0; faceValue < 13; faceValue++) {
          deck[suit * 13 + faceValue] = new Card(suit, faceValue);
        }
      }

      var cardNumber = 0;
      foreach (var card in deck) {
        var faceValueName = String.Empty;
        switch(card.value) {
          case 0: faceValueName = "ace"; break;
          case 1:
          case 2:
          case 3:
          case 4:
          case 5:
          case 6:
          case 7:
          case 8:
          case 9: faceValueName = (card.value + 1).ToString(); break;
          case 10: faceValueName = "jack"; break;
          case 11: faceValueName = "queen"; break;
          case 12: faceValueName = "king"; break;
          default: throw new ArgumentException($"Something went wrong {card.value} is not a valid faceValue!");
        }

        var suitName = String.Empty;
        switch (card.suit) {
          case 0: suitName = "clubs"; break;
          case 1: suitName = "diamonds"; break;
          case 2: suitName = "hearts"; break;
          case 3: suitName = "spades"; break;
          default: throw new ArgumentException($"Something went wrong {card.suit} is not a valid suitName!");
        }

        result[cardNumber] = $"{faceValueName} of {suitName}";
        cardNumber++;
      }
      return result;
    }
  }
}