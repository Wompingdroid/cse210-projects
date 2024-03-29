using System.Reflection;
using System.Security.Cryptography;
using Microsoft.VisualBasic;

namespace Develope04;

class Reflection : Activities
{
private List<string> prompts = new List<string>  {
    "Think of a time when you stood up for someone else.", 
    "Think of a time when you did something really difficult.",
    "Think of a time when you helped someone in need.",
    "Think of a time when you did something truly selfless."
};

private List<string> reflectionQuestions = new List<string> {
"Why was this experience meaningful to you?",
"Have you ever done anything like this before?",
"How did you get started?",
"How did you feel when it was complete?",
"What made this time different than other times when you were not as successful?",
"What is your favorite thing about this experience?",
"What could you learn from this experience that applies to other situations?",
"What did you learn about yourself through this experience?",
"How can you keep this experience in mind in the future?"
};

private void GetRandomPrompt()
{
    Random rnd = new Random();
    int randomNum = rnd.Next(0,prompts.Count()+1);
        
    System.Console.WriteLine(prompts[randomNum]);
}

private void GetQuestions()
{
    DateTime startTime = DateTime.Now;
    DateTime futureTime = startTime.AddSeconds(duration);
    while (DateTime.Now < futureTime)
    {
    Random rnd = new Random();
    int randomNum = rnd.Next(0,reflectionQuestions.Count());
    System.Console.WriteLine(reflectionQuestions[randomNum]);
    Animation();
    }
}

public void RunReflection() 
{
    Countdown();
    System.Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    DisplayDuration();
    GetReady();
    GetRandomPrompt();
    Animation();
    GetQuestions();
    FinishMessage();
    
}

}