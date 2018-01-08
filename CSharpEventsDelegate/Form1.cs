using CSharpEventsDelegate.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpEventsDelegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Product p = new Product();
            p.PriceChanged += P_PriceChanged;
            p.StockChanged += P_StockChanged;
            p.Name = "Kazak";
            p.Price = 15;
            p.Stock = 15;

            p.Increase(15);


            ProductModel model = new ProductModel();
            model.ProductName = "Çorap";
            model.Stock = 10;
            model.Price = 5;

            model.PriceChanged += Model_PriceChanged;

            model.Increase(5);
            model.Decrease(10);

            Test t = new Test();

        }

        private void P_StockChanged(Product model, ProductArgs args)
        {
            
            throw new NotImplementedException();
        }

        private void Model_PriceChanged(object sender, EventArgs e)
        {
            ProductArgs a = (ProductArgs)e;

            MessageBox.Show(a.PriceState);
            MessageBox.Show(a.NewPrice.ToString());
            MessageBox.Show(a.OldPrice.ToString());
        }

        private void P_PriceChanged(object sender, EventArgs e)
        {
            Product p = sender as Product;
            MessageBox.Show("Ürünün Yeni Fiyatı " + p.Price);

        }
    }
}
