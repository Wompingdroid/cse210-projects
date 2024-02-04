namespace Develope02;
public class Entry
{
    public string _dateText =  DateTime.Now.ToShortDateString();

    public List<string> _questions = new List<string> 
    {
        "What made you laugh today?",
        "What made you smile today?",
        "When did you see the hand of the Lord in your life today?",
        "What was something you were excited for today?",
        "What insights did you get from your scripture study today?",
        "Whats something good you ate?",
        "Who did you interact with today in a special way?"
    };

    public int GetRandom()
    {
        Random rnd = new Random();
        int randomNum = rnd.Next(1,8);

        return randomNum;
    }
    
    public string GetInput()
    {
    string input = Console.ReadLine();
    return input;
    }
    
}