using System;
namespace Learning04;
class Program
{
    static void Main(string[] args)
    {
        Assignment one = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(one.GetSummary());

        MathAssignment two = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(two.GetHomeworkList());

        EnglishAssignment three = new EnglishAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(three.GetWritingInformation());
    }
}