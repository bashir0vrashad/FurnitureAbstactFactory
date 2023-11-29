using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture
{
    internal class ArtDecoSofa : ISofa
    {
        public void hasLegs()
        {
            Console.WriteLine("Art Deco Sofa Has Legs");
        }

        public void LieOn()
        {
            Console.WriteLine("Art Deco Sofa Lie On");
        }

        public void SitOn()
        {
            Console.WriteLine("Art Deco Sofa Sit On");
        }
    }
}
