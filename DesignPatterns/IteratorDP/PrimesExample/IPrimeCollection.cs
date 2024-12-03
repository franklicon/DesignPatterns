namespace DesignPatterns.IteratorDP.PrimesExample;

public interface IPrimeCollection
{
    IPrimeIterator CreateIterator();
}