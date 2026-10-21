namespace src;

public class Store<T>
{
    private readonly List<T> _items = new();

    public void Add(T item) => _items.Add(item);
    public T? GetById(int id)
        => _items.FirstOrDefault(item => item.Id == id);

    public List<T> GetAll() => _items;

    public void Remove(int id)
    {
        T? item = GetById(id);

        if (item is not null)
            _items.Remove(item);
    }
}