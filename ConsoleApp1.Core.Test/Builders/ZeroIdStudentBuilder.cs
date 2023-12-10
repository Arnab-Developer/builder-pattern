namespace ConsoleApp1.Core.Test.Builders;

public class ZeroIdStudentBuilder : BasicStudentBuilder
{
    public override void Build()
    {
        base.Build();
        Student.Id = 0;
    }
}