namespace src;

public class Student : IHasId
{
    public int Id { get; }
    public string Name { get; set; }

    public Student(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public override string ToString()
        => $"Student Id: {Id}, Name: {Name}";
}
