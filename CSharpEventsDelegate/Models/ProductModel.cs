using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEventsDelegate.Models
{
    public class ProductModel
    {
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public short Stock { get; set; }

        public event EventHandler PriceChanged;
        public event EventHandler StockChanged;

        public void Increase(decimal increase)
        {
            decimal oldPrice = Price;
            Price = Price + increase;

            ProductArgs args = new ProductArgs();
            args.NewPrice = Price;
            args.OldPrice = oldPrice;

            PriceChanged.Invoke(this, args);
        }

        public void Decrease(decimal decrease)
        {
            decimal oldPrice = Price;
            Price = Price - decrease;

            ProductArgs args = new ProductArgs();
            args.NewPrice = Price;
            args.OldPrice = oldPrice;

            PriceChanged.Invoke(this, args);
        }


    }
}
