public class Program
{
    public static void Main()
    {
        var students = new List<Student>
        {
            new Student("Ada", 92),
            new Student("Grace", 74),
            new Student("Alan", 45),
        };

        Console.WriteLine("All students:");
        foreach (var student in students)
        {
            // You can call GetGrade() directly because Student implements IGradable
            Console.WriteLine($"  {student.Name}: {student.GetGrade()}");
        }

        var passed = students.Where(s => s.Score >= 50).ToList();

        Console.WriteLine($"\n{passed.Count} student(s) passed:");
        foreach (var student in passed)
        {
            Console.WriteLine($"  {student.Name}");
        }

        var names = students.Select(s => s.Name).ToList();
        Console.WriteLine($"\nAll names: {string.Join(", ", names)}");

        Console.Write("\nEnter a new student's name: ");
        string? newName = Console.ReadLine();

        Console.Write("Enter their score: ");
        string? scoreInput = Console.ReadLine();

        if (int.TryParse(scoreInput, out int newScore))
        {
            var newStudent = new Student(newName ?? "Unknown", newScore);
            students.Add(newStudent);
            Console.WriteLine($"\nAdded {newStudent.Name} ({newStudent.GetGrade()}). Total students: {students.Count}");
        }
        else
        {
            Console.WriteLine("\nThat wasn't a valid number - student was not added.");
        }
    }
}
