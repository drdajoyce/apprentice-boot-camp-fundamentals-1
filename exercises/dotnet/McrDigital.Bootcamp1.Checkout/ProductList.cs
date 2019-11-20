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
            this.products.Add(new Product("A", 50));
            this.products.Add(new Product("B", 30));
            this.products.Add(new Product("C", 20));
            this.products.Add(new Product("D", 15));
        }

        public Product LookUpProduct(string sku)
        {
            Product result = null;

            for (int i = 0; i < this.products.Count; i++)
            {

                if (this.products[i].sku.Equals(sku))
                {
                    result = new Product(this.products[i].sku, this.products[i].price);

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
