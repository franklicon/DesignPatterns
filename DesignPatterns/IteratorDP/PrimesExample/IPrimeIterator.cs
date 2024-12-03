namespace DesignPatterns.IteratorDP.PrimesExample;

public interface IPrimeIterator
{
    bool HasNext();
    int Next();
    void Reset();
}