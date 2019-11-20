using System;
using System.Collections.Generic;
using System.Text;

namespace McrDigital.Bootcamp1.Checkout
{
    public class Offer
    {
        public int multibuyQuantity { get; set; }

        public int discount { get; set; }

        public string sku { get; set; }

        public Offer(int multibuyQuantity, int discount, string sku)
        {
            this.multibuyQuantity = multibuyQuantity;
            this.discount = discount;
            this.sku = sku;
        }
    }
}
