
using System.ComponentModel;
using System.IO; 
namespace Develope02;

public class Journal
{
    public List<string> _entrys = new List<string>();

    public void Load()
    {
        System.Console.WriteLine("Please enter your file name.");
        System.Console.Write("> ");
        string filename = Console.ReadLine();

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            //string[] parts = line.Split(",");
            _entrys.Add(line);
        }
    }


    public void Display()
    {
        foreach (string line in _entrys)
        {
            System.Console.WriteLine($"{line}");
        }
    }

    public void Save()
    {
        System.Console.WriteLine("Please enter your file name.");
        System.Console.Write("> ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (string line in _entrys)
            {
                outputFile.WriteLine($"{line}");
            }
        }
    }


}