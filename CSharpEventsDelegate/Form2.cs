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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Test t = new Test();

            //TestHandler üzerinden method çağırma 
            TestHandler handler1 = new TestHandler(t.Success);
            handler1.Invoke();

            TestHandlerr handler2 = new TestHandlerr(t.Fail);
            handler2.Invoke(5);

            //handler = new TestHandler(t.Do);

            //2 tane method atamış olduk

            TestHandler t1, t2, mh;

            t1 = t.Success;
            t2 = t.Fail;
            mh = t1 + t2; //birden fazla methodun handler a atanması.

            //mh.Invoke();
            //mh.Invoke();

            //sıralı çalışması gereken methodlar var ise delagate sayesinde GetInvocationList üzerinden çalışma zamanında
            //DynamicInvoke method tetiklenerek gerekli methodlar çalıştırılır.

            foreach (var item in mh.GetInvocationList())
            {
                item.DynamicInvoke();
            }

           
        }

        private int T_Tested()
        {
            throw new NotImplementedException();
        }
    }
}
