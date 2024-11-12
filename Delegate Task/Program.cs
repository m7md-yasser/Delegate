using Delegate_Task;
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<Student> students = new List<Student>
        {
            new Student("Ali Omar", 85), new Student("Sara Hany", 92),
            new Student("Omar Ali", 65), new Student("Laila Ahmed", 55),
            new Student("Kareem ALi", 77),new Student("Yousef Ashraf", 45),
            new Student("Ahmed Hany", 85),new Student("Mostafa Mohamed", 56),
        };
        ScoreProcessor processor = new ScoreProcessor();
        ScoreCriteria passCriteria = s => s.Score >= 60;
        ScoreCriteria failCriteria = s => s.Score < 60;
        Console.WriteLine("----------- Passing Students: -----------\n");
        processor.FilterStudents(students, passCriteria).PrintStudents();

        Console.WriteLine("\n----------- Failing Students: -----------\n");
        processor.FilterStudents(students, failCriteria).PrintStudents();

        Console.WriteLine($"\n----------- Average Score: -----------\n{processor.CalculateAverage(students)}");

        Console.WriteLine($"\n----------- Top Scorer: -----------\n\n{students.TopScorer()?.Name} with Score {students.TopScorer()?.Score}");
        Console.ReadKey();
    }
}
