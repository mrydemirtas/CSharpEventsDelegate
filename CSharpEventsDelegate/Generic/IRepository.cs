using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEventsDelegate.Generic
{
    interface IRepository<T>
    {
        T[] Listele();
        void Guncelle(T guncellenecekObj);
        void Sil(int index);
        void Ekle(T eklenecekObj);
    }
}
