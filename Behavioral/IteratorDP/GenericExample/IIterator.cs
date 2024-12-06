namespace DesignPatterns.Behavioral.IteratorDP.GenericExample;

public interface IIterator<T>
{
    bool HasNext();
    T Next();
    void Reset();
}