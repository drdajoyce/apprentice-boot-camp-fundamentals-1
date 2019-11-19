namespace McrDigital.Bootcamp1.Cards {
  using System;
  using System.Collections.Generic;

  public class AnimalDeck : Deck {

    public AnimalDeck() {
      Cards = new List<GenericCard>();
      foreach (Animal animal in Enum.GetValues(typeof(Animal))) {
        this.Cards.Add(new AnimalCard(animal));
        this.Cards.Add(new AnimalCard(animal));
      }
    }

/*    public override AnimalCard Deal() {
      var card = this._cards[0];
      this._cards.RemoveAt(0);
      return card;
    }*/

    public override string[] GetCards() {
      var result = new String[this.Cards.Count];
      for (var index = 0; index < this.Cards.Count; index++) {
        var card = this.Cards[index]; result[index] = card.ToString();
      }
      return result;
    }

    public override void Shuffle() {
      this.Cards.KnuthShuffle();
    }
  }

  public static class ListExtensions {
    public static void KnuthShuffle<T>(this List<T> @this) {
      // Use the Knuth Shuffle (aka Fisher-Yates shuffle) to shuffle the list of cards.
      // https://en.wikipedia.org/wiki/Fisher–Yates_shuffle
      // https://stackoverflow.com/a/25943363
      var random = new Random();
      for (var index = (@this.Count - 1); index > 0; index--) {
        var next = random.Next(index + 1);
        var temp = @this[index];
        @this[index] = @this[next];
        @this[next] = temp;
      }
    }
  }
}