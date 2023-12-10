namespace ConsoleApp1.Core.Test;

public class StudentDirector
{
    private StudentBuilder? _builder;

    public void BuildStudent(StudentBuilder builder)
    {
        _builder = builder;
        _builder.Build();
    }

    public Student GetStudent()
    {
        if (_builder is null)
        {
            throw new ArgumentNullException();
        }

        return _builder.Student;
    }
}