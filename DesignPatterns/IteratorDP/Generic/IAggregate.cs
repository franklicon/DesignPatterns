namespace DesignPatterns.IteratorDP.Generic;

public interface IAggregate<T>
{
    IIterator<T> CreateIterator();
    void Add(T item);
}