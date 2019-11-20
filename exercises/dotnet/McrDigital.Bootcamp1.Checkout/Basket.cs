using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace McrDigital.Bootcamp1.Checkout
{
    public class Basket 
    {
        public SortedDictionary<string, int> items = new SortedDictionary<string, int>();

        public Basket()
        {
            items.Add("A", 0);
            items.Add("B", 0);
            items.Add("C", 0);
            items.Add("D", 0);
        }
    }
}
