using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEventsDelegate.Generic
{
    public class CategoryRepo : IRepository<Category>
    {
        public void Ekle(Category eklenecekObj)
        {
            throw new NotImplementedException();
        }

        public void Guncelle(Category guncellenecekObj)
        {
            throw new NotImplementedException();
        }

        public Category[] Listele()
        {
            throw new NotImplementedException();
        }

        public void Sil(int index)
        {
            throw new NotImplementedException();
        }
    }
}
