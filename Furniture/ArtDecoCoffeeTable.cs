using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture
{
    internal class ArtDecoCoffeeTable : ICoffeeTable
    {
        public void hasLegs()
        {
            Console.WriteLine("Art Deco Coffee Table Has Legs");
        }

        public void PutOn()
        {
            Console.WriteLine("Art Deco Coffee Table Put on");
        }
    }
    
}
