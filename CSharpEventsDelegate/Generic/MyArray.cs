using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEventsDelegate.Generic
{
    //Not kalıtım alınacak sınıfta T tipinde olmalıdır.
    //T - yerine istediğimizi yazabiliriz.
    // T değeri yerine int,string gibi tipler gelebilir.
    public class MyArray<T>
    {
        private T[] _list;

        public  T[] Items { get
            {
                return _list;

            }
        }

        public MyArray(int capacity)
        {
            _list = new T[capacity];
        }

        public void Add(T item,int index)
        {
            _list[index] = item;
        }

    }
}
