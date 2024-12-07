using DesignPatterns.Creational.FactoryMethodDP.QuestExample.Enemies;

namespace DesignPatterns.Creational.FactoryMethodDP.QuestExample.Levels;

public abstract class Level
{
    public abstract IEnemy CreateEnemy();

    public void EncounterEnemy()
    {
        var enemy = CreateEnemy();
        enemy.Scream();
        enemy.Attack();
    }
}