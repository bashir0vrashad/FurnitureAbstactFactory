using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture
{
    internal class ModernChair : IChair
    {
        public void hasLegs()
        {
            Console.WriteLine("Modern Chair Has Legs");
        }

        public void SitOn()
        {
            Console.WriteLine("Modern Chair Sit on");
        }
    }
}
