namespace DesignPatterns.Creational.FactoryMethodDP.QuestExample.Enemies;

public class Goblin : IEnemy
{
    public void Scream()
    {
        Console.WriteLine("Goblin is screaming");
    }

    public void Attack()
    {
        Console.WriteLine("Goblin is attacking");
    }
}