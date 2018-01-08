using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEventsDelegate.Models
{
    public class ProductArgs:EventArgs
    {
        private decimal _oldPrice;
        private decimal _newPrice;

        public decimal OldPrice {
            get { return _oldPrice; }
            set {

                _oldPrice = value;

                if (_oldPrice<_newPrice)
                    PriceState = string.Format("{0} lık bir zam yapıldı",(_newPrice-_oldPrice));
                else
                    PriceState = string.Format("{0} lık bir indirim yapıldı", (_oldPrice - _newPrice));
            }
        }
        public decimal NewPrice {
            get
            {
                return _newPrice;
            }
            set
            {
                _newPrice = value;

                if (_newPrice < _oldPrice)
                    PriceState = string.Format("{0} lık bir indirim yapıldı", (_oldPrice - _newPrice));
                else
                    PriceState = string.Format("{0} lık bir zam yapıldı", (_oldPrice - _newPrice));
            }
        }

        public string PriceState { get; private set; }


    }
}
