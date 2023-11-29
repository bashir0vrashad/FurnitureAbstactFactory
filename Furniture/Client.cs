using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Furniture
{
    internal class Client
    {
        private IFurnitureFactory factory;
        public Client(IFurnitureFactory Factory)
        {
           factory = Factory;
        }

        public void SomeOperation()
        {
            factory.CreateChair().hasLegs();
            factory.CreateChair().SitOn();
            factory.CreateSofa().hasLegs();
            factory.CreateSofa().SitOn();
            factory.CreateSofa().LieOn();
            factory.CreateCoffeeTable().PutOn();
        }

    }
}
