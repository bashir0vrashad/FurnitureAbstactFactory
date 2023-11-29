using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture
{
    internal class ModernSofa : ISofa
    {
        public void hasLegs()
        {
            Console.WriteLine("Modern Sofa Has Legs");
        }

        public void LieOn()
        {
            Console.WriteLine("Modern Sofa Lie On");
        }

        public void SitOn()
        {
            Console.WriteLine("Modern Sofa Sit On");
        }
    }
}
