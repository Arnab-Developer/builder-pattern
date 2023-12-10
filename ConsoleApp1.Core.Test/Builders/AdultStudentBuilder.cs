namespace ConsoleApp1.Core.Test.Builders;

public class AdultStudentBuilder : BasicStudentBuilder
{
    public override void Build()
    {
        base.Build();
        Student.Age = 20;
    }
}