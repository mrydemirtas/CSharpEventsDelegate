using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEventsDelegate.Generic
{
    public class ProductRepo : IRepository<Product>
    {
        Product[] _productList;

        public ProductRepo()
        {
            _productList = new Product[0];
        }

        public void Ekle(Product eklenecekObj)
        {
            Array.Resize(ref _productList, _productList.Length + 1);
            _productList[_productList.Length - 1] = eklenecekObj;
            
        }

        public void Guncelle(Product guncellenecekObj)
        {
            for (int i = 0; i < _productList.Length; i++)
            {
                if (_productList[i].Name==guncellenecekObj.Name)
                {
                    _productList[i].Price = guncellenecekObj.Price;
                    _productList[i].Stock = guncellenecekObj.Stock;
                }
            }
        }

        public Product[] Listele()
        {
            return _productList;
        }

        public void Sil(int index)
        {
            var item = _productList[index];


        }
    }
}
