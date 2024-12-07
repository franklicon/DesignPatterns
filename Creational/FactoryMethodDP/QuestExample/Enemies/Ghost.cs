namespace DesignPatterns.Creational.FactoryMethodDP.QuestExample.Enemies;

public class Ghost : IEnemy
{
    public void Scream()
    {
        Console.WriteLine("Ghost is screaming");
    }

    public void Attack()
    {
        Console.WriteLine("Ghost is attacking");
    }
}