namespace ConsoleApp1.Core.Test.Builders;

public class EmptyNameStudentBuilder : BasicStudentBuilder
{
    public override void Build()
    {
        base.Build();
        Student.Name = string.Empty;
    }
}