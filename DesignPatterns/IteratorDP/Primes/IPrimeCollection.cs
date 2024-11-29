namespace DesignPatterns.IteratorDP.Primes;

public interface IPrimeCollection
{
    IPrimeIterator CreateIterator();
}