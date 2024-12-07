using DesignPatterns.Creational.FactoryMethodDP.QuestExample.Enemies;

namespace DesignPatterns.Creational.FactoryMethodDP.QuestExample.Levels;

public class HauntedHouseLevel : Level
{
    public override IEnemy CreateEnemy()
    {
        Console.WriteLine("Haunted House Level");
        return new Ghost();
    }
}