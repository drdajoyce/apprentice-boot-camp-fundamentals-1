using System;
using System.Collections.Generic;
using System.Text;

namespace McrDigital.Bootcamp1.Checkout
{
    public class Scanner
    {
        public ProductList productList;
        public Basket basket;

        public void AddItemToBasket(string sku)
        {
            foreach (var item in productList)
            {
                if (item.sku.Equals(sku))
                {
                    basket.items[sku]++;
                }
            }
        }

    }
}
