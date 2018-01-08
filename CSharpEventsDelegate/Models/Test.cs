using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEventsDelegate.Models
{
    //Method Tutucu => Metotlarımıza elçilik yapar.
    public delegate int TestHandler();
    public delegate int TestHandlerr(int a);

    public class Test
    {
        public Test()
        {
            Testedd += Test_Tested;
            Tested += Test_Tested1;
            Testedd.Invoke(2);
        }

        private int Test_Tested1()
        {
            throw new NotImplementedException();
        }

        private int Test_Tested(int a)
        {
            return 1;
            //throw new NotImplementedException();
        }

        public int Success()
        {
            return 1;
        }

        public int Fail()
        {
            return 0;
        }

        public int Fail(int a)
        {
            return 2;
        }

        public void Do()
        {

        }

        public event TestHandler Tested;
        public event TestHandlerr Testedd;
    }
}
