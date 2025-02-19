﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace McrDigital.Bootcamp1.Checkout
{
    public class OffersList : IEnumerable<Offer>
    {
        public List<Offer> offers = new List<Offer>();
        public bool applyOffer = false;

        public OffersList()
        {
            offers.Add(new Offer(3, 20, "A"));
            offers.Add(new Offer(2, 15, "B"));
            offers.Add(new Offer(4, 10, "C"));
            offers.Add(new Offer(5, 15, "D"));
        }

        public IEnumerator<Offer> GetEnumerator()
        {
            return offers.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
