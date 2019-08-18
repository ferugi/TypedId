# TypedId
TypedId is a small library which provides flexible tools to tie IDs (in the form of Guids, strings etc) to the type of object that owns them. For example, look at the following common scenario:

```csharp
public class Person
{
	// Objects ID
    public string Id { get; }

	// Other fields etc
    public string Name { get; set; }
	// ...
}
```

Typed ID provides a way to ensure a situation like the following doesn't happen.
```csharp
Person personA = new Person() {
	Id = "123Id",
	Name = "Joe Bloggs"
}

Person personB = new Person() {
	Id = "456Id",
	Name = "John Doe"
}

if (personA.Id == personB.Name) {
	// Oops!
}
```

# Usage
Instead, you could do the following using interfaces and methods in this library:

```csharp
public class Person
{
	// Objects ID
    public IId<Person> Id { get; }

	// Other fields etc
    public string Name { get; set; }
	// ...
}
```

```csharp
Person personA = new Person() {
	Id = IdFor<Person>.Wrap("123Id"),
	Name = "Joe Bloggs"
}

Person personB = new Person() {
	Id = IdFor<Person>.Wrap("456Id"),
	Name = "John Doe"
}

// Then the following won't compile:
if (personA.Id == personB.Name) {
	// Oops!
}
```