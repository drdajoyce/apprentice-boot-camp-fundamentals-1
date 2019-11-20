namespace McrDigital.Bootcamp1.Checkout
{
    using System;

    public class Receipt
    {
        private string _text = String.Empty;
        public ProductList products = new ProductList();
        public OffersList offers = new OffersList();
        public int _total;
        public bool applyDiscount = false;

        public string Text
        {
            get => $"{this._text}Total: {this._total}";
        }      

        public void WriteToReceipt(string sku)
        {
            foreach (var product in products)
            {
                if (product.sku.Equals(sku))
                {
                    this._text = $"{this._text}{sku}: {product.price}";
                    foreach (var offer in offers)
                    {
                        if (this.applyDiscount && offer.sku.Equals(sku))
                        {
                            this._text = $"{this._text} - {offer.discount} ({offer.itemQuantity} for " +
                                $"{product.price * offer.itemQuantity - offer.discount})";
                        }
                    }
                    this._text = $"{this._text}\n";
                    this.applyDiscount = false;
                }
            }

        }
    }
}