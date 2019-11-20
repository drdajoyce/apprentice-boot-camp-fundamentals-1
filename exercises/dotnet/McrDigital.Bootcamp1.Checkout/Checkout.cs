using System.Collections.Generic;

namespace McrDigital.Bootcamp1.Checkout
{
    public class Checkout
    {
        private int total;
        public ProductList products = new ProductList();
        public OffersList offers = new OffersList();
        public Scanner scanner = new Scanner();
        private Basket basket = new Basket();
        private Receipt receipt = new Receipt();

        public Checkout()
        {
            receipt.offers = offers;
            receipt.products = products;
            scanner.basket = basket;
            scanner.productList = products;
        }

        public string Receipt
        {
            get => receipt.Text;
        }

        public int Total
        {
            get => total;
        }

        public void AddItemPriceToTotal(string sku)
        {
            foreach (var product in products)
            {
                if (product.sku.Equals(sku))
                {
                    total += product.price;
                }
            }
        }

        public void ApplyOffer(string sku)
        {
            foreach (var offer in offers)
            {
                if(offer.sku.Equals(sku) && basket.items[sku] % offer.multibuyQuantity == 0)
                {
                    offers.applyOffer = true;
                    total -= offer.discount;
                }
            }
        }

        public void Scan(string sku)
        {
            AddItemPriceToTotal(sku);
            foreach (var product in products)
            {
                if(product.sku.Equals(sku))
                {
                    scanner.AddItemToBasket(sku);
                    ApplyOffer(sku);
                    receipt.WriteToReceipt(sku);
                }
            }
            this.receipt.total = total;
        }
    }
}