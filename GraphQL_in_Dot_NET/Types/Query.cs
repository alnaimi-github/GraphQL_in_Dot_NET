namespace GraphQL_in_Dot_NET.Types;

public class Query
{
    public Book GetBook() => new Book("C# in Depth", new Author("Jon Skeet"));

    public IEnumerable<IPet> GetPets() =>
    [
        new Dog("Buddy","Hook"),
        new Cat(true,"Sahra"),
        new Parrot(true,"Pilot")
    ];
}


public interface IPet
{
    string Name { get; }
}

public class Dog : IPet
{
    public Dog(string breed, string name)
    {
        Breed = breed;
        Name = name;
    }

    public string Breed { get; }
    public string Name { get; }
}

public class Cat : IPet
{
    public Cat(bool isEvil, string name)
    {
        IsEvil = isEvil;
        Name = name;
    }

    public bool IsEvil { get; }
    public string Name { get; }
}

public class Parrot : IPet
{
    public Parrot(bool canTalk, string name)
    {
        CanTalk = canTalk;
        Name = name;
    }

    public bool CanTalk { get; }
    public string Name { get; }
}
