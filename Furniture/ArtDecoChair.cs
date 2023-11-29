using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture
{
    internal class ArtDecoChair : IChair
    {
        public void hasLegs()
        {
            Console.WriteLine("Art Deco Chair Has Legs");
        }

        public void SitOn()
        {
            Console.WriteLine("Art Deco Chair Sit on");
        }
    }
}
