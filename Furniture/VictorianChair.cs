using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture
{
    internal class VictorianChair : IChair
    {
        public void hasLegs()
        {
            Console.WriteLine("Victorian Chair Has Legs");
        }

        public void SitOn()
        {
            Console.WriteLine("Victorian Chair Sit on");
        }
    }
}
