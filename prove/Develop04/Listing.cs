namespace Develope04;

class Listing : Activities
{
    private List<string> prompts = new List<string>{
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?};"};

    private void GetRandomPrompt(){
        Random rnd = new Random();
        int randomNum = rnd.Next(0,prompts.Count()+1);
            
        System.Console.WriteLine(prompts[randomNum]);
    }

    private int amountOfAnswers = 0;

    private void UserAnswers(){
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        while (DateTime.Now < futureTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            amountOfAnswers +=1;
        }

        System.Console.WriteLine($"You have entered {amountOfAnswers} answers!");
        
    }

    public void RunListing(){
        Countdown();
        System.Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        DisplayDuration();
        GetReady();
        GetRandomPrompt();
        UserAnswers();
        FinishMessage();
    }
    
}