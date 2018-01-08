using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEventsDelegate.Models
{
    //metot imzasını atıp geçiyoruz.
    //Productİle ilgili eventler tetiklendiğinde void tipinde aşağıdaki argümanlara sahip bir iş yapsın.
    public delegate void ProductHandler(Product model, ProductArgs args);

    //ebent genelde bir metot çalıştığında metot sonucunda bir bilgilendirme yapmak için tercih edilir veya bir durum değişikliğini göstermek için property setlerin de kullanılabilir. 

    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public short Stock { get; set; }

        //public decimal A {
        //    get {
        //        return 1;
        //    }

        //    set {
        //        Price = value;
        //        PriceChanged.Invoke(this,new EventArgs());
        //    }
        //}

        //event tanımlaması
        public event ProductHandler StockChanged;
        public event EventHandler PriceChanged;

        public void IncreaseStock(int quantity)
        {
            //event çalışınca değişen ve elde etmek istediğimiz argümanlar.
            ProductArgs args = new ProductArgs();
            //invoke ile event tetiklenir
            StockChanged.Invoke(this, args);
        }

        
        public void Increase(decimal increaseAmount)
        {
            Price = Price + increaseAmount;
            //tetikleme sonucunda argüman olarak kullanıcıya gönderilecek değerler.
            EventArgs args = new EventArgs();
            PriceChanged.Invoke(this, args);
        }

        public void Decrease(decimal decreaseAmount)
        {
            Price = Price - decreaseAmount;
            EventArgs args = new EventArgs();
            PriceChanged.Invoke(this, args);
        }



    }
}
