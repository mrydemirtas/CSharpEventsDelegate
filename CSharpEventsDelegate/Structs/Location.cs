using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEventsDelegate.Structs
{
    public struct Location
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Location GetLocation()
        {
            return this;
        }
    }
}
