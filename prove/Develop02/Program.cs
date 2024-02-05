using System;

namespace Develope02
{
class Program

{
    static void Main()
    {
        System.Console.WriteLine("Welcome to your journal");
        Journal journal = new Journal();
        while (true)
        {
            

            System.Console.WriteLine();
            System.Console.WriteLine("Please input what you would like to do");
            System.Console.WriteLine("1. write"); 
            System.Console.WriteLine("2. display");
            System.Console.WriteLine("3. load");
            System.Console.WriteLine("4. save");
            System.Console.WriteLine("5. quit");
            System.Console.Write("> ");
            string userInput = Console.ReadLine();
            if (userInput == "1") //write
            {
                
                Entry entry = new Entry();

                int questionNum = entry.GetRandom();
                string question = entry._questions[questionNum];
                System.Console.WriteLine(question);

                string response = entry.GetInput();

                string date = entry._dateText;

                journal._entrys.Add($"{date} {question} {response}");
                Console.Clear();
            }
            else if (userInput == "2") //display
            {
                foreach (string thing in journal._entrys)
                {
                    System.Console.WriteLine(thing);
                }
            }
            else if (userInput == "3") //load
            {
                journal.Load();
            }
            else if (userInput == "4") //save
            {
                journal.Save();
            }
            else if (userInput == "5") //quit
            {
                break;
            }
            else
            {
                Console.Clear();
                System.Console.WriteLine("This was an improper input");
            }
        }
    }
}
}