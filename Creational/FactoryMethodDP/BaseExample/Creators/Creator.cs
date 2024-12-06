using DesignPatterns.Creational.FactoryMethodDP.BaseExample.Products;

namespace DesignPatterns.Creational.FactoryMethodDP.BaseExample.Creators;

public abstract class Creator
{
    public abstract Product CreateProduct();
}