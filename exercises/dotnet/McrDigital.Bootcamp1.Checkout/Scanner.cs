using System;
using System.Collections.Generic;
using System.Text;

namespace McrDigital.Bootcamp1.Checkout
{
    public class Scanner
    {
        ProductList productList = new ProductList();
        Basket basket = new Basket();

        public void AddItemToBasket(string sku)
        {
            foreach (var item in productList)
            {
                if (item.sku.Equals(sku))
                {
                    basket.items.Add(item);
                }
            }
        }

    }
}
