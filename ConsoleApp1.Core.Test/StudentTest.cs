namespace ConsoleApp1.Core.Test;

public class StudentTest
{
    private readonly StudentDirector _studentDirector;

    public StudentTest()
    {
        _studentDirector = new StudentDirector();
    }

    [Fact]
    public void Can_ReturnBasicData()
    {
        // Arrange
        var studentBuilder = new BasicStudentBuilder();

        // Act
        _studentDirector.BuildStudent(studentBuilder);

        // Assert
        var student = _studentDirector.GetStudent();

        Assert.NotNull(student);
        Assert.Equal(1, student.Id);
        Assert.Equal("Jon Doe", student.Name);
        Assert.Equal("jondoe@gmail.com", student.Email);
        Assert.Equal(1, student.Age);
    }

    [Fact]
    public void Can_ReturnAdultAgeData()
    {
        // Arrange
        var studentBuilder = new AdultStudentBuilder();

        // Act
        _studentDirector.BuildStudent(studentBuilder);

        // Assert
        var student = _studentDirector.GetStudent();

        Assert.NotNull(student);
        Assert.Equal(1, student.Id);
        Assert.Equal("Jon Doe", student.Name);
        Assert.Equal("jondoe@gmail.com", student.Email);
        Assert.Equal(20, student.Age);
    }

    [Fact]
    public void Can_ThrowException_WithEmptyEmailData()
    {
        // Arrange
        var studentBuilder = new EmptyEmailStudentBuilder();

        // Act
        void testCode() => _studentDirector.BuildStudent(studentBuilder);

        // Assert
        var exception = Assert.Throws<StudentException>(testCode);
        var student = _studentDirector.GetStudent();

        Assert.Equal("Invalid Email", exception.Message);
        Assert.NotNull(student);
        Assert.Equal(1, student.Id);
        Assert.Equal("Jon Doe", student.Name);
        Assert.Equal("jondoe@gmail.com", student.Email);
        Assert.Equal(1, student.Age);
    }

    [Fact]
    public void Can_ThrowException_WithEmptyNameData()
    {
        // Arrange
        var studentBuilder = new EmptyNameStudentBuilder();

        // Act
        void testCode() => _studentDirector.BuildStudent(studentBuilder);

        // Assert
        var exception = Assert.Throws<StudentException>(testCode);
        var student = _studentDirector.GetStudent();

        Assert.Equal("Invalid Name", exception.Message);
        Assert.NotNull(student);
        Assert.Equal(1, student.Id);
        Assert.Equal("Jon Doe", student.Name);
        Assert.Equal("jondoe@gmail.com", student.Email);
        Assert.Equal(1, student.Age);
    }

    [Fact]
    public void Can_ThrowException_WithZeroAgeData()
    {
        // Arrange
        var studentBuilder = new ZeroAgeStudentBuilder();

        // Act
        void testCode() => _studentDirector.BuildStudent(studentBuilder);

        // Assert
        var exception = Assert.Throws<StudentException>(testCode);
        var student = _studentDirector.GetStudent();

        Assert.Equal("Invalid Age", exception.Message);
        Assert.NotNull(student);
        Assert.Equal(1, student.Id);
        Assert.Equal("Jon Doe", student.Name);
        Assert.Equal("jondoe@gmail.com", student.Email);
        Assert.Equal(1, student.Age);
    }

    [Fact]
    public void Can_ThrowException_WithZeroIdData()
    {
        // Arrange
        var studentBuilder = new ZeroIdStudentBuilder();

        // Act
        void testCode() => _studentDirector.BuildStudent(studentBuilder);

        // Assert
        var exception = Assert.Throws<StudentException>(testCode);
        var student = _studentDirector.GetStudent();

        Assert.Equal("Invalid Id", exception.Message);
        Assert.NotNull(student);
        Assert.Equal(1, student.Id);
        Assert.Equal("Jon Doe", student.Name);
        Assert.Equal("jondoe@gmail.com", student.Email);
        Assert.Equal(1, student.Age);
    }
}