using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEventsDelegate.Structs
{
    public struct Not
    {
        public int Vize1 { get; set; }
        public int Vize2 { get; set; }
        public int Final { get; set; }

        public double Ort()
        {
            return Vize1 + Vize2 + Final;
        }
    }
}
