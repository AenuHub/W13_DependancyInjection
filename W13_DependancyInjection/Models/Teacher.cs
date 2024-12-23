namespace W13_DependancyInjection;

public class Teacher : ITeacher
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;

    // returns full name
    public string GetInfo()
    {
        return $"{FirstName} {LastName}";
    }
}