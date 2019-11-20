using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace McrDigital.Bootcamp1.Checkout
{
    public class Basket : IEnumerable<Product>
    {
        public List<Product> items = new List<Product>();
        public int numberOfA = 0;
        public int numberOfB = 0;
        public int numberOfC = 0;
        public int numberOfD = 0;

    public IEnumerator<Product> GetEnumerator()
        {
            return items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
