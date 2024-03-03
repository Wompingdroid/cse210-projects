namespace Develope04;

class Breathing : Activities
{
    private void BreathIn(){
        System.Console.WriteLine("Breath in...");
        Animation();
    }
    private void BreathOut(){
        System.Console.WriteLine("Breath out...");
        Animation();
    }

    public void RunBreathing(){
        Countdown();
        System.Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly every 5 seconds. Clear your mind and focus on your breathing.");
        DisplayDuration();
        GetReady();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(duration);
        while (DateTime.Now < futureTime)
        {
            BreathIn();
            BreathOut();
        }
        FinishMessage();

    }



}