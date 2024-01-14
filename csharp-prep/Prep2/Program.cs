using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a percentage grade: ");
        string grade = Console.ReadLine();
        int numGrade = int.Parse(grade);
        

        if (numGrade >= 90)
        {
            System.Console.WriteLine("You got an A");
            System.Console.WriteLine("Congrats you passed!");
        }
        else if (numGrade >= 80)
        {
            System.Console.WriteLine("You got a B");
            System.Console.WriteLine("Good job! you passed");
        }
        else if (numGrade >= 70)
        {
            System.Console.WriteLine("You got a C");
            System.Console.WriteLine("Good job, you passed!!");
        }
        else if (numGrade >= 60)
        {
            System.Console.WriteLine("You got a D");
            System.Console.WriteLine("You can do it for sure next time!!");
        }
        else 
        {
            System.Console.WriteLine("You fot an F");
            System.Console.WriteLine("A little more effort is needed for this class, you got this!");
        }
    }
}