namespace src;

public class Course
{
    public int Id { get; }
    public string Title { get; set; }
    public decimal Price { get; set; }

    public Course(int id, string title, decimal price)
    {
        Id = id;
        Title = title;
        Price = price;
    }

    override public string ToString()
        => $"Course Id: {Id}, Title: {Title}, Price: {Price}";
}