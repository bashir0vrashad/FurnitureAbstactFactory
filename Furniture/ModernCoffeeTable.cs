using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture
{
    internal class ModernCoffeeTable : ICoffeeTable
    {
        public void hasLegs()
        {
            Console.WriteLine("Modern Coffee Table Has Legs");
        }

        public void PutOn()
        {
            Console.WriteLine("Modern Coffee Table Put on");
        }
    }
}
