namespace src;

public class Program
{
    static void Main(string[] args)
    {
        //var studentStore = new Store<Student>();
        //var student1 = new Student(1, "Ahmed");
        //var student2 = new Student(2, "Mohamed");

        //studentStore.Add(student1);
        //studentStore.Add(student2);

        //Console.WriteLine(studentStore.GetById(1));
        //Console.WriteLine(studentStore.GetById(2));

        //studentStore.Remove(1);
        //studentStore.Remove(2);

        //studentStore.GetAll().ForEach(st => Console.WriteLine(st)); // no output since the list is empty

        //// ____________________________________________________________________________

        //var courseStore = new Store<Course>();
        //var course1 = new Course(1, "Python", 100m);
        //var course2 = new Course(2, "Java", 100m);

        //courseStore.Add(course1);
        //courseStore.Add(course2);

        //Console.WriteLine(courseStore.GetById(1));
        //Console.WriteLine(courseStore.GetById(2));

        //courseStore.Remove(1);
        //courseStore.Remove(2);

        //courseStore.GetAll().ForEach(st => Console.WriteLine(st)); // no output since the list is empty

        Console.WriteLine("____________________________________________________");

        Store<Student> students = new();

        students.Add(new Student(1, "Ahmed"));
        students.Add(new Student(2, "Mohamed"));

        Student? student = students.GetById(1);

        Console.WriteLine(student?.Name ?? "Student not found");

        Console.WriteLine($"Students count: {students.GetAll().Count}");

        students.Remove(2);

        Console.WriteLine($"Students count after removal: {students.GetAll().Count}");

        Store<Course> courses = new();

        courses.Add(new Course(1, "Python", 100m));
        courses.Add(new Course(2, "Java", 100m));

        Course? course = courses.GetById(2);

        Console.WriteLine(course?.Title ?? "Course not found");

        try
        {
            courses.Add(new Course(2, "Another Course", 1000m));
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
    
    
    }
}
