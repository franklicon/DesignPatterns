using DesignPatterns.Creational.FactoryMethodDP.BaseExample.Creators;
using DesignPatterns.Creational.FactoryMethodDP.BaseExample.Products;
using DesignPatterns.Creational.FactoryMethodDP.QuestExample.Levels;

namespace DesignPatterns.Clients;

public static class CreationalClient
{
    public static void AddFactoryMethodClient()
    {
        // Base Factory Method client.
        Console.WriteLine("Base Factory Method Client");
        Creator creator = new ConcreteCreator();
        var product = creator.CreateProduct();
        
        // Quest Factory Method client.
        Console.WriteLine("Quest Factory Method Client");
        var level1 = LevelFactory.CreateLevel(levelNumber: 1);
        level1.EncounterEnemy();
        var level2 = LevelFactory.CreateLevel(levelNumber: 2);
        level2.EncounterEnemy();
    }
}