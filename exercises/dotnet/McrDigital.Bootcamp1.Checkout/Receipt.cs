namespace McrDigital.Bootcamp1.Checkout {
  using System;

  public class Receipt {
    private string _text = String.Empty;
    public ProductList products = new ProductList();
    public OffersList offers = new OffersList();
    private int _aCountdown = 3;
    private int _total;
    private int _bCountdown = 2;
    private int _cCountdown = 4;
    private int _dCountdown = 5;

        public string Text {
      get => $"{this._text}Total: {this._total}";
    }

        public void ScannedA() {
      this._text = $"{this._text}A: 50";
      if (--this._aCountdown == 0) {
        this._text = $"{this._text} - 20 (3 for 130)";
        this._total += 30;
      } else {
        this._total += 50;
      }
      this._text = $"{this._text}\n";
    }

    public void ScannedB() {
      this._text = $"{this._text}B: 30";
      if (--this._bCountdown == 0) {
        this._text = $"{this._text} - 15 (2 for 45)";
        this._total += 15;
      } else {
        this._total += 30;
      }
      this._text = $"{this._text}\n";
    }

    public void ScannedC() {
      this._text = $"{this._text}C: 20";
            if (--this._cCountdown == 0)
            {
                this._text = $"{this._text} - 10 (4 for 70)";
                this._total += 10;
            }
            else
            {
                this._total += 20;
            }
            this._text = $"{this._text}\n";
        }

    public void ScannedD() {
      this._text = $"{this._text}D: 15";
            if (--this._dCountdown == 0)
            {
                this._text = $"{this._text} - 15 (5 for 60)";
                this._total += 0;
            }
            else
            {
                this._total += 15;
            }
            this._text = $"{this._text}\n";
        }

        public void Scanned(string sku)
        {
            foreach (var product in products)
            {
                if (product.sku.Equals(sku))
                {
                    this._text = $"{this._text}{sku}: {product.price}";
                    foreach (var offer in offers)
                    {
                        if (--offer.itemQuantity == 0)
                        {
                            this._text = $"{this._text} - {offer.discount} ({offer.itemQuantity} for " +
                                $"{product.price * offer.itemQuantity - offer.discount}";
                            this._total += product.price - offer.discount;
                        }
                        else
                        {
                            this._total += product.price;
                        }                     
                    }
                    this._text = $"{this._text}\n";
                }
            }
            
        }
    }
}