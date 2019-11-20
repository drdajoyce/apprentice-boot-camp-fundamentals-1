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
