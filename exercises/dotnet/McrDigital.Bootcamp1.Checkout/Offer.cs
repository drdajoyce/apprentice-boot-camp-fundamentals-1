using System;
using System.Collections.Generic;
using System.Text;

namespace McrDigital.Bootcamp1.Checkout
{
    public class Offer
    {
        public int itemQuantity { get; set; }

        public int discount { get; set; }

        public string sku { get; set; }

        public Offer(int itemQuantity, int discount, string sku)
        {
            this.itemQuantity = itemQuantity;
            this.discount = discount;
            this.sku = sku;
        }
    }
}
