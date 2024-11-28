using DesignPatterns.IteratorDP;

// Iterator client
IAggregate<int> aggregate = new Aggregate<int>();

aggregate.Add(1);
aggregate.Add(2);
aggregate.Add(3);

IIterator<int> iterator = aggregate.CreateIterator();

while (iterator.HasNext())
{
    Console.WriteLine(iterator.Next());
}