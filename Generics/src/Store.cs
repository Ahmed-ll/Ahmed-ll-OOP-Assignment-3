namespace src;

public class Store<T> where T : IHasId
{
    private readonly Dictionary<int, T> _items = new();
    public void Add(T item)
    {
        if (!_items.TryAdd(item.Id, item))
            throw new InvalidOperationException($"An item with ID {item.Id} already exists.");
    }

    public T? GetById(int id)
        => _items.TryGetValue(id, out T? item) ? item : default;


    public IReadOnlyDictionary<int, T> GetAll() => _items;

    public void Remove(int id) => _items.Remove(id);
}