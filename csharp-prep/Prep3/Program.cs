using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int majNum = randomGenerator.Next(1, 101);
        string guessNum = "";

        do{
            System.Console.Write("guess a number: ");
            guessNum = Console.ReadLine();

            if(int.Parse(guessNum) > majNum)
            {
                System.Console.WriteLine("Lower");
            }
            else if (int.Parse(guessNum) < majNum)
            {
                System.Console.WriteLine("Higher");
            }
            else
            {
                System.Console.WriteLine("Good Job!!");
            }
        } while (majNum != int.Parse(guessNum));

    }
}