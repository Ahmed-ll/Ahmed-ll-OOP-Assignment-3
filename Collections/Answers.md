# Task 2.1 — IReadOnlyDictionary & SortedDictionary

## 1. What is IReadOnlyDictionary<TKey, TValue>?

`IReadOnlyDictionary<TKey, TValue>` is an interface that represents a collection of key-value pairs that can be read but not modified through this interface.
It allows operations such as accessing a value by its key, checking whether a key exists, and iterating over the entries.

## 2. How is IReadOnlyDictionary different from Dictionary?

`Dictionary<TKey, TValue>` is a concrete class that supports adding, removing, updating, and reading entries. 
`IReadOnlyDictionary<TKey, TValue>` provides only read access through its interface.

A public method can return `IReadOnlyDictionary` instead of `Dictionary` to expose only the operations that callers need.
This reduces access to modification methods and gives the implementation more flexibility to change the underlying collection later.

## 3. How is SortedDictionary different from Dictionary?

`SortedDictionary<TKey, TValue>` stores entries ordered by their keys, while `Dictionary<TKey, TValue>` does not guarantee a particular key order.

Their lookup performance is also different. `Dictionary` provides average lookup time of O(1) because it uses a hash table.
`SortedDictionary` uses a binary search tree, so lookup takes O(log n).

## 4. When would you choose SortedDictionary?

I would choose `SortedDictionary` when I need to iterate over key-value pairs in sorted key order and still perform lookups, insertions, and removals efficiently.

For example, it can be useful for storing records indexed by dates or IDs when I need to process them in ascending order.
If ordering is not required and fast key lookups are the main priority, I would usually choose `Dictionary` instead.

___________________________________________________________________________________________________

## Task 2.2 — Pick the Collection

- **S1 — `Dictionary`:** it provides fast lookups with an average time complexity of O(1).

- **S2 — `HashSet`:** it stores unique tags and prevents duplicates.

- **S3 — `List`:** it preserves the order in which grades were entered and allows duplicate grades.

- **S4 — `IReadOnlyDictionary`:**  allow callers to read course prices without exposing methods for adding, removing, or updating entries through the returned interface.

- **S5 — `SortedDictionary`:** it keeps sessions ordered by their start-time keys, even when new sessions are added.

- **S6 — `IEnumerable`:** it allows the caller to iterate over results and stop early without requiring the entire collection to be materialized in advance.