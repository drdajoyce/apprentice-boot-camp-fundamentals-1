namespace McrDigital.Bootcamp1.Checkout
{
    using System;

    public class Receipt
    {
        private string text = String.Empty;
        public ProductList products;
        public OffersList offers;
        public int total;

        public string Text
        {
            get => $"{text}Total: {total}";
        }      

        public void WriteToReceipt(string sku)
        {
            foreach (var product in products)
            {
                if (product.sku.Equals(sku))
                {
                    text = $"{text}{sku}: {product.price}";
                    foreach (var offer in offers)
                    {
                        if (offers.applyOffer && offer.sku.Equals(sku))
                        {
                            text = $"{text} - {offer.discount} ({offer.multibuyQuantity} for " +
                                $"{product.price * offer.multibuyQuantity - offer.discount})";
                        }
                    }
                    text = $"{text}\n";
                    offers.applyOffer = false;
                }
            }

        }
    }
}