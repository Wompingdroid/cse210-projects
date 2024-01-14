using System;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("What is your first name? ");
        string first = Console.ReadLine();
        System.Console.Write("What is your last name? ");
        string last = Console.ReadLine();
        System.Console.WriteLine();
        System.Console.WriteLine($"Your name is {last}, {first} {last}.");
    }
}