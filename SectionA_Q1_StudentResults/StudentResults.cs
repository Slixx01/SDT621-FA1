using System;

class StudentResults
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Student name");
        string Name = Console.ReadLine()!;
        if (Name == null)
        {
            Console.WriteLine("Please enter a name");
        }


        List<int> StudentMarks = new List<int>();


        for (int i = 1; i < 4; i++)
        {
            Console.WriteLine($"Enter mark for Subject {i} :");
            StudentMarks.Add(int.Parse(Console.ReadLine()));
        }

        int SumMarks = StudentMarks.Sum();
        double AverageMarks = Math.Round(StudentMarks.Average(), 2);
        string StudentResult = (AverageMarks >= 50) ? "Pass" : "Fail";


        Console.WriteLine(
            $"""
            ==== STUDENT RESULTS ====
            Student Name: {Name}
            Total Marks: {SumMarks} 
            Average Makrs: {AverageMarks}
            Result: {StudentResult}
            Results Issued At: {DateTime.Now}
            """);

        Console.WriteLine("Press Any key to exit....");
        Console.ReadKey();


    }

}





