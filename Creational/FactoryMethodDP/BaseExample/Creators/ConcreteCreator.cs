using DesignPatterns.Creational.FactoryMethodDP.BaseExample.Products;

namespace DesignPatterns.Creational.FactoryMethodDP.BaseExample.Creators;

public class ConcreteCreator : Creator
{
    public override Product CreateProduct()
    {
        Console.WriteLine("Creating Concrete Product in Concrete Creator");
        return new ConcreteProduct();
    }
}