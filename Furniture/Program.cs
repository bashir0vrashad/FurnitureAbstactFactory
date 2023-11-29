using Furniture;

IFurnitureFactory victorianFactory1 = new VictorianFurnitureFactory();
Client client1 = new Client(victorianFactory1);
client1.SomeOperation();