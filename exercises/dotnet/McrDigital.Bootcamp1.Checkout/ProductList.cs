using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace McrDigital.Bootcamp1.Checkout
{
    public class ProductList : IEnumerable<Product>
    {
        public List<Product> products = new List<Product>();

        public ProductList()
        {
            products.Add(new Product("A", 50));
            products.Add(new Product("B", 30));
            products.Add(new Product("C", 20));
            products.Add(new Product("D", 15));
        }

        public Product LookUpProduct(string sku)
        {
            Product result = null;

            for (int i = 0; i < products.Count; i++)
            {

                if (products[i].sku.Equals(sku))
                {
                    result = new Product(products[i].sku, products[i].price);

                }
            }
            return result;
        }

        public IEnumerator<Product> GetEnumerator()
        {
            return products.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
