namespace ConsoleApp1.Core;

public class StudentException : Exception
{
    public StudentException(string dataName) : base($"Invalid {dataName}")
    {
    }
}