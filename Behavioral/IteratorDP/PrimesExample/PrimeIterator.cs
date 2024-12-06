namespace DesignPatterns.Behavioral.IteratorDP.PrimesExample;

public class PrimeIterator(PrimeCollection primes) : IPrimeIterator
{
    private int _itemsReturned = 0;
    private int _current = 1;
    
    public bool HasNext() => _itemsReturned < primes.Count;

    public int Next()
    {
        if(!HasNext())
            throw new InvalidOperationException("No more elements");
        
        while (!IsPrime(++_current)) {}

        _itemsReturned++;
        return _current;
    }

    public void Reset()
    {
        _itemsReturned = 0;
        _current = 1;
    }

    private static bool IsPrime(int number)
    {
        if(number < 2) return false;
        if(number == 2) return true;
        if(number % 2 == 0) return false;
        var sqrt = (int)Math.Sqrt(number);
        for (var i = 3; i <= sqrt; i += 2)
        {
            if(number % i == 0) return false;
        }

        return true;
    }
}