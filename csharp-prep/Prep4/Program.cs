using System;

class Program
{
    static void Main(string[] args)
    {
        // create lists and variables
        List<int> numbers = new List<int>();
        string num = "";
        double i = 0;
        int totalAdd = 0;
        double average = 0;
        int largest = 0;

        // set up context for user
        System.Console.WriteLine("Please input numbers. When you input 0 the program will end.");

        //begin while loop, get user input,  count about of inputs with i, add inputs to numbers list
        do
        {
            num = Console.ReadLine();
            numbers.Add(int.Parse(num));
            i++;
        }while (num != "0");

        // correction to i to not include 0 in list
        i = i-1;

        //calculate the total and find the largest number by going through list that was just made.
        foreach (var n in numbers)
        {
            totalAdd += n;

            if (n >= largest)
            {
                largest = n;
            }
        }

        //calculate average
        average = totalAdd / i;

        // print the total addition of numbers, the average, and the largest number.
        System.Console.WriteLine($"The total addition of your inputs is {totalAdd}");
        System.Console.WriteLine($"The average of all your inputs = {average}");
        System.Console.WriteLine($"The largest number added was {largest}");

    }
}