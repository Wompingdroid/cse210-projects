using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {

    //define all functions
    static void Welcome()
    {
        System.Console.WriteLine("Welcome to the program!");
    }


    string GetName()
    {
       System.Console.Write("Please enter your name: ");
       string name = Console.ReadLine(); 
       return name;
    }


    int GetNum()
    {
       System.Console.Write("Please enter your favorite number: ");
       string num = Console.ReadLine(); 
       return int.Parse(num); 
    }


    int SquareNum(int number)
    {
        int finalNumber = number * number;
        return finalNumber;
    }

    //call all functions in the order of the assignment
    Welcome();
    string name = GetName();
    int num = GetNum();
    System.Console.WriteLine($"Your favorite number squared is {SquareNum(num)}");
    

    }
}