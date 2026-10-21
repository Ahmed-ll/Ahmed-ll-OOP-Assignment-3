namespace src;

public static class EnumerableExtensions
{
    public static IEnumerable<T> Page<T>(this IEnumerable<T> source, int pageNumber, int pageSize)
    {
        if (source is null)
            throw new ArgumentNullException(nameof(source));
        if (pageNumber < 1)
            throw new ArgumentOutOfRangeException(nameof(pageNumber), pageNumber, "Page number must be >= 1.");
        if (pageSize < 1)
            throw new ArgumentOutOfRangeException(nameof(pageSize), pageSize, "Page size must be >= 1.");

        return PageIterator(source, pageNumber, pageSize);
    }

    private static IEnumerable<T> PageIterator<T>(IEnumerable<T> source, int pageNumber, int pageSize)
    {
        long start = (pageNumber - 1) * pageSize;
        long end = start + pageSize;
        long index = 0;

        foreach (var item in source)
        {
            if (index >= end)
                yield break;          

            if (index >= start)
                yield return item;

            index++;
        }
    }

    public static T? FindById<T>(this IEnumerable<T> source, int id) where T : IHasId
    {
        if (source is null)
            throw new ArgumentNullException(nameof(source));

        foreach (var item in source)
        {
            if (item != null && item.Id == id)
                return item;
        }
        return default;
    }

    public static IReadOnlyDictionary<int, T> ToIdDictionary<T>(this IEnumerable<T> source) where T : IHasId
    {
        if (source is null)
            throw new ArgumentNullException(nameof(source));

        var dict = new Dictionary<int, T>();
        foreach (var item in source)
        {
            if (item is null)
                throw new ArgumentException("Source contains a null item.", nameof(source));

            if (!dict.TryAdd(item.Id, item))
                throw new ArgumentException($"Duplicate Id: {item.Id}.", nameof(source));
        }
        return dict;
    }
}