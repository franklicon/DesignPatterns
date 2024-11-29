using DesignPatterns.IteratorDP;
using DesignPatterns.IteratorDP.Generic;
using DesignPatterns.IteratorDP.Primes;

// Generic Iterator client
IAggregate<int> aggregate = new Aggregate<int>();

aggregate.Add(1);
aggregate.Add(2);
aggregate.Add(3);

IIterator<int> iterator = aggregate.CreateIterator();

while (iterator.HasNext())
{
    Console.WriteLine(iterator.Next());
}

// Primes Iterator Client
IPrimeCollection primes = new PrimeCollection(150);

IPrimeIterator primeIterator = primes.CreateIterator();

while (primeIterator.HasNext())
{
    Console.WriteLine(primeIterator.Next());
}