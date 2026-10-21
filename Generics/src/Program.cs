namespace src;

public class Program
{
    static void Main(string[] args)
    {
        var studentStore = new StudentStore();
        var student1 = new Student(1, "Ahmed");
        var student2 = new Student(2, "Mohamed");

        studentStore.Add(student1);
        studentStore.Add(student2);

        Console.WriteLine(studentStore.GetById(1));
        Console.WriteLine(studentStore.GetById(2));

        studentStore.Remove(1);
        studentStore.Remove(2);

        studentStore.GetAll().ForEach(st => Console.WriteLine(st)); // no output since the list is empty
    }
}