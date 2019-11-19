namespace McrDigital.Bootcamp1.Cards
{
    public abstract class GenericCard
    {
        public abstract string CardValue { get; }

        public bool Snap(GenericCard other)
        {
            return CardValue == other.CardValue;
        }
    }
}