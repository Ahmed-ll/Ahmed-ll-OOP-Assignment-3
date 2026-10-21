namespace src;

public class StudentStore
{
    private readonly List<Student> _students = new();

    public void Add(Student student) => _students.Add(student);

    public Student? GetById(int id)
        => _students.FirstOrDefault(student => student.Id == id);

    public List<Student> GetAll() => _students;

    public void Remove(int id)
    {
        Student? student = GetById(id);

        if (student is not null)
            _students.Remove(student);
    }
}