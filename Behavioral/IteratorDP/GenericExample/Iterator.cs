namespace DesignPatterns.Behavioral.IteratorDP.GenericExample;

public class Iterator<T>(Aggregate<T> aggregate) : IIterator<T>
{
    private int _currentIndex = -1;

    public bool HasNext() => _currentIndex < aggregate.Count - 1;
    
    public void Reset() => _currentIndex = -1;

    public T Next()
    {
        if(!HasNext())
            throw new InvalidOperationException("No more elements");
       
        _currentIndex++;
        return aggregate.GetItemAt(_currentIndex);
    }
}