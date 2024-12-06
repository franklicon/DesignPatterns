namespace DesignPatterns.Behavioral.IteratorDP.GenericExample;

public class Aggregate<T> : IAggregate<T>
{
    private readonly List<T> _items = [];
    public int Count => _items.Count;

    public IIterator<T> CreateIterator() => new Iterator<T>(this);
    
    public void Add(T item) => _items.Add(item);

    public T GetItemAt(int index) => _items[index];
}