using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        //Primitive tyeprs
        int i;
        long l;
        float f;
        double d;
        char c;
        string s;
        byte b;


        //Variables
        int myNum = 23;
        int anotherInt = 12;
        string myName = "Andrew Nelson";


        //var
        var myLastName = "Nelson";
        var myNumCount = 6;


        //Printing Variables
        Console.WriteLine("A Name: " + myName);
        Console.WriteLine($"A Name: {myName}");
        Console.WriteLine("Bob");


        //ReadLine
        Console.WriteLine();
        //try cw-tab-
        var ageString = Console.ReadLine();


        //Converting Variables
        var age = int.Parse(ageString):


        //Condisionals
        if (age < 18){
            System.Console.WriteLine("Your a minor");
        }
        else
            System.Console.WriteLine("Your old"); //conditionals dont need curly braces if they are one line


        //Operators


        










    }
}