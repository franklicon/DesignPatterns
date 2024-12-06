namespace DesignPatterns.Behavioral.IteratorDP.PrimesExample;

public interface IPrimeCollection
{
    IPrimeIterator CreateIterator();
}