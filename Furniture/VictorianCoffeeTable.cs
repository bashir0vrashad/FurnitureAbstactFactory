using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture
{
    internal class VictorianCoffeeTable : ICoffeeTable
    {
        public void hasLegs()
        {
            Console.WriteLine("Victorian Coffee Table Has Legs");
        }

        public void PutOn()
        {
            Console.WriteLine("Victorian Coffee Table Put on");
        }
    }
}
