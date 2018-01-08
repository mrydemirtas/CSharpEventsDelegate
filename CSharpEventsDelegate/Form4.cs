using CSharpEventsDelegate.Generic;
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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            MyArray<string> strArr = new MyArray<string>(3);
            strArr.Add("Mehmet", 2);
            strArr.Add("Ali", 1);

            string[] items1 = strArr.Items;

            MyArray<int> myIntArr = new MyArray<int>(5);
            myIntArr.Add(5, 0);
            myIntArr.Add(10, 1);

            ProductRepo r = new ProductRepo();
            r.Ekle(new Product { Name = "Kazak", Price = 10, Stock = 15 });
            r.Ekle(new Product { Name = "T-Shirt", Price = 10, Stock = 15 });

            r.Guncelle(new Product { Name = "Kazak", Price = 20, Stock = 10 });

            r.Listele();

            IRepository<Product> rpp = new ProductRepo();

            int[] items = myIntArr.Items;

            //Generic Collections


            List<Product> plist = new List<Product>();
            plist.Add(new Product { Name = "şal" });
            plist.Remove(new Product());
            plist.RemoveAt(5);

            List<string> names = new List<string>();
            names.Add("afsfdsd");

            List<int> ints = new List<int>();
            ints.Add(5);
        }
    }
}
