namespace ConsoleApp1.Core.Test.Builders;

public class ZeroAgeStudentBuilder : BasicStudentBuilder
{
    public override void Build()
    {
        base.Build();
        Student.Age = 0;
    }
}