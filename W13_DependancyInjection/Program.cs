using W13_DependancyInjection;

public class Program
{
    public static void Main(string[] args)
    {
        var classroom = new Classroom(
            new Teacher { FirstName = "John", LastName = "Keating" }
            );
        
        Console.WriteLine(classroom.GetTeacherInfo());
        
        Console.ReadKey();
    }
}
  