using System.Collections.Generic;

namespace McrDigital.Bootcamp1.Checkout
{
    public class Checkout
    {
        private int _total;
        public ProductList products = new ProductList();

        private int _numberOfA;
        private int _numberOfB;
        private int _numberOfC;
        private int _numberOfD;
        private Receipt _receipt = new Receipt();

        public string Receipt
        {
            get => this._receipt.Text;
        }

        public int Total
        {
            get => this._total;
        }

        public void AddItemPriceToTotal(string sku)
        {
            foreach (var product in products)
            {
                if (product.sku.Equals(sku))
                {
                    this._total += product.price;
                }
            }
        }

        public void Scan(string sku)
        {
            AddItemPriceToTotal(sku);
            if ("A".Equals(sku))
            {
                this._receipt.Scanned("A");
                this._numberOfA++;
                if (this._numberOfA % 3 == 0)
                {
                    this._total -= 20;
                }
            }
            else if ("B".Equals(sku))
            {
                this._receipt.ScannedB();
                this._numberOfB++;
                if (this._numberOfB % 2 == 0)
                {
                    this._total -= 15;
                }
            }
            else if ("C".Equals(sku))
            {
                this._receipt.ScannedC();
                this._numberOfC++;
                if (this._numberOfC % 4 == 0)
                {
                    this._total -= 10;
                }
            }
            else if ("D".Equals(sku))
            {
                this._receipt.ScannedD();
                this._numberOfD++;
                if (this._numberOfD % 5 == 0)
                {
                    this._total -= 15;
                }
            }
        }
    }
}