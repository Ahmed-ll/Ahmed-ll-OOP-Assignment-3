namespace src;

public class CourseStore
{
    private readonly List<Course> _courses = new();

    public void Add(Course course) => _courses.Add(course);

    public Course? GetById(int id)
        => _courses.FirstOrDefault(course => course.Id == id);

    public List<Course> GetAll() => _courses;

    public void Remove(int id)
    {
        Course? course = GetById(id);

        if (course is not null)
            _courses.Remove(course);
    }
}