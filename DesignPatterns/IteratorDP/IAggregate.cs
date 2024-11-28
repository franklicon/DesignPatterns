namespace DesignPatterns.IteratorDP;

public interface IAggregate<T>
{
    IIterator<T> CreateIterator();
    void Add(T item);
}