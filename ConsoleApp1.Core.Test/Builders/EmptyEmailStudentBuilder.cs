namespace ConsoleApp1.Core.Test.Builders;

public class EmptyEmailStudentBuilder : BasicStudentBuilder
{
    public override void Build()
    {
        base.Build();
        Student.Email = string.Empty;
    }
}