# Step 2 — StudentStore vs CourseStore

- Both stores use a `List<T>` to store their objects.
- Both have the same four methods: `Add`, `GetById`, `GetAll`, and `Remove`.
- Both search for an item by its ID.
- Both return `null` when an item is not found.
- Both use almost identical logic to add, retrieve, list, and remove items.

The two stores have nearly identical implementations.
This creates duplicated code and suggests that a generic class could handle both types.