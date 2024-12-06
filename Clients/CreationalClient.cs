using DesignPatterns.Creational.FactoryMethodDP.BaseExample.Creators;
using DesignPatterns.Creational.FactoryMethodDP.BaseExample.Products;

namespace DesignPatterns.Clients;

public static class CreationalClient
{
    public static void AddFactoryMethodClient()
    {
        // Base Factory Method client.
        Console.WriteLine("Base Factory Method Client");
        Creator creator = new ConcreteCreator();
        var product = creator.CreateProduct();
    }
}