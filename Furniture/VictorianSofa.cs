using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture
{
    internal class VictorianSofa : ISofa
    {
        public void hasLegs()
        {
            Console.WriteLine("Victorian Sofa Has Legs");
        }

        public void LieOn()
        {
            Console.WriteLine("Victorian Sofa Lie On");
        }

        public void SitOn()
        {
            Console.WriteLine("Victorian Sofa Sit On");
        }
    }
}
