namespace DesignPatterns.Behavioral.IteratorDP.GenericExample;

public interface IAggregate<T>
{
    IIterator<T> CreateIterator();
    void Add(T item);
}