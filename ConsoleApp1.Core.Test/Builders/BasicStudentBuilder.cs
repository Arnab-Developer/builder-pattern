namespace ConsoleApp1.Core.Test.Builders;

public class BasicStudentBuilder : StudentBuilder
{
    private readonly Student _student;

    public override Student Student
    {
        get
        {
            return _student;
        }
    }

    public BasicStudentBuilder()
    {
        _student = new Student();
    }

    public override void Build()
    {
        _student.Id = 1;
        _student.Name = "Jon Doe";
        _student.Email = "jondoe@gmail.com";
        _student.Age = 1;
    }
}