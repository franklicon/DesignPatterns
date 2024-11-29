namespace DesignPatterns.IteratorDP.Primes;

public interface IPrimeIterator
{
    bool HasNext();
    int Next();
    void Reset();
}