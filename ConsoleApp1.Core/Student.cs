using System.Text;

namespace ConsoleApp1.Core;

public class Student
{
    private int _id;
    private string _name;
    private string _email;
    private int _age;

    public int Id
    {
        get
        {
            return _id;
        }
        set
        {
            if (value <= 0)
            {
                throw new StudentException(nameof(Id));
            }

            _id = value;
        }
    }

    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new StudentException(nameof(Name));
            }

            _name = value;
        }
    }

    public string Email
    {
        get
        {
            return _email;
        }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new StudentException(nameof(Email));
            }

            _email = value;
        }
    }

    public int Age
    {
        get
        {
            return _age;
        }
        set
        {
            if (value <= 0)
            {
                throw new StudentException(nameof(Age));
            }

            _age = value;
        }
    }

    public Student()
    {
        _id = 0;
        _name = string.Empty;
        _email = string.Empty;
        _age = 0;
    }

    public Student(int id, string name, string email, int age)
    {
        _id = 0;
        _name = string.Empty;
        _email = string.Empty;
        _age = 0;

        Id = id;
        Name = name;
        Email = email;
        Age = age;
    }

    public override string ToString()
    {
        var stringBuilder = new StringBuilder();

        stringBuilder.Append("Id: ");
        stringBuilder.AppendLine(Id.ToString());

        stringBuilder.Append("Name: ");
        stringBuilder.AppendLine(Name);

        stringBuilder.Append("Email: ");
        stringBuilder.AppendLine(Email);

        stringBuilder.Append("Age: ");
        stringBuilder.AppendLine(Age.ToString());

        return stringBuilder.ToString();
    }
}