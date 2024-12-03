using DesignPatterns.IteratorDP.GenericExample;
using DesignPatterns.IteratorDP.PrimesExample;
using DesignPatterns.ProxyDP.BaseExample;
using DesignPatterns.ProxyDP.VirtualExample;

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

// Base Proxy client
Proxy proxy = new Proxy();
proxy.Operation();

// Virtual Proxy Client
IImage image1 = new ProxyImage("image1");
IImage image2 = new ProxyImage("image2");
image1.Display();
image2.Display();
image1.Display();
image2.Display();