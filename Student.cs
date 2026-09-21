public class Student : IGradable
{
    public string Name { get; set; }
    public int Score { get; set; }

    public Student(string name, int score)
    {
        Name = name;
        Score = score;
    }

    // This fulfills the IGradable interface contract
    public string GetGrade()
    {
        if (Score >= 85) return "A";
        if (Score >= 70) return "B";
        if (Score >= 50) return "C";
        return "F";
    }
}