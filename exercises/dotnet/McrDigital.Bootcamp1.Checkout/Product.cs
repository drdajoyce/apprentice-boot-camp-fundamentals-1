using System;
using System.Collections.Generic;
using System.Text;

namespace McrDigital.Bootcamp1.Checkout
{
    public class Product
    {
        public string sku { get; set; }
        public int price { get; set; }

        public Product(string sku, int price)
        {
            this.sku = sku;
            this.price = price;
        }
    }
}
