using DesignPatterns.Behavioral.IteratorDP.GenericExample;
using DesignPatterns.Behavioral.IteratorDP.PrimesExample;

namespace DesignPatterns.Clients;

public static class BehavioralClient
{
    public static void AddIteratorClient()
    {
        // Generic Iterator client
        Console.WriteLine("Generic Iterator Client");
        IAggregate<int> aggregate = new Aggregate<int>();
        aggregate.Add(1);
        aggregate.Add(2);
        aggregate.Add(3);
        var iterator = aggregate.CreateIterator();
        while (iterator.HasNext())
        {
            Console.WriteLine(iterator.Next());
        }

        // Primes Iterator client
        Console.WriteLine("Primes Iterator Client");
        IPrimeCollection primes = new PrimeCollection(150);
        var primeIterator = primes.CreateIterator();
        while (primeIterator.HasNext())
        {
            Console.WriteLine(primeIterator.Next());
        }
    }
}