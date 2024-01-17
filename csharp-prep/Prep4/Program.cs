using System;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();
        string num = "";
        double i = 0;
        int totalAdd = 0;
        double average = 0;
        int largest = 0;
        System.Console.WriteLine("Please input numbers. When you input 0 the program will end.");
        do
        {
            num = Console.ReadLine();
            numbers.Add(int.Parse(num));
            i++;
        }while (num != "0");
        i = i-1;
        foreach (var n in numbers)
        {
            totalAdd += n;

            if (n >= largest)
            {
                largest = n;
            }
        }
        average = totalAdd / i;

        System.Console.WriteLine($"The total addition of your inputs is {totalAdd}");
        System.Console.WriteLine($"The average of all your inputs = {average}");
        System.Console.WriteLine($"The largest number added was {largest}");

    }
}