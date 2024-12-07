using DesignPatterns.Creational.FactoryMethodDP.QuestExample.Enemies;

namespace DesignPatterns.Creational.FactoryMethodDP.QuestExample.Levels;

public class CaveLevel : Level
{
    public override IEnemy CreateEnemy()
    {
        Console.WriteLine("Cave Level");
        return new Goblin();
    }
}