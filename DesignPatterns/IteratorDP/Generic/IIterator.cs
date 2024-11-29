namespace DesignPatterns.IteratorDP.Generic;

public interface IIterator<T>
{
    bool HasNext();
    T Next();
    void Reset();
}