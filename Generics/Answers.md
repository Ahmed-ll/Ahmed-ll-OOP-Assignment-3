# Step 2 — StudentStore vs CourseStore

- Both stores use a `List<T>` to store their objects.
- Both have the same four methods: `Add`, `GetById`, `GetAll`, and `Remove`.
- Both search for an item by its ID.
- Both return `null` when an item is not found.
- Both use almost identical logic to add, retrieve, list, and remove items.

The two stores have nearly identical implementations.
This creates duplicated code and suggests that a generic class could handle both types.


## Step 3 — Why GetById Does Not Compile

### Compiler error

`CS1061: 'T' does not contain a definition for 'Id' and no accessible extension method 'Id' accepting a first argument of type 'T' could be found (are you missing a using directive or an assembly reference?)`


`T` is a generic type parameter. At this stage, the compiler does not know which type will replace `T`, so it cannot guarantee that the type has an `Id` property.

Although both `Student` and `Course` have an `Id`, `Store<T>` must also be valid for other types that may not have one.

We need to constrain `T` to types that guarantee an `Id` property.


## Step 4 — The IHasId Constraint

`IHasId` defines a read-only `int Id` property.

Both `Student` and `Course` implement this interface, guaranteeing that they provide an `Id`.

The constraint `where T : IHasId` tells the compiler that every type used with `Store<T>` must implement `IHasId`. Therefore, `GetById` can access `item.Id` safely.

This removes the duplicated store classes while keeping the code type-safe.