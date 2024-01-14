using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a percentage grade: ");
        string grade = Console.ReadLine();
        int numGrade = int.Parse(grade);
        string letterGrade = "F";
        

        if (numGrade >= 90)
        {
            letterGrade = "A";
        }
        else if (numGrade >= 80)
        {
            letterGrade = "B";
        }
        else if (numGrade >= 70)
        {
            letterGrade = "C";
        }
        else if (numGrade >= 60)
        {
            letterGrade = "D";
        }
        System.Console.WriteLine($"You got the letter grade: {letterGrade}");
    }
}