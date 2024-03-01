using System.Runtime.CompilerServices;

namespace Develope04;

class Activities
{
    protected int duration;

    void GetReady(){
        System.Console.WriteLine("Get ready...");
        Animation();
    }

    void Countdown(){
        while (true){
            System.Console.WriteLine("How long would you like to do your activity?");
            string userNumberInput = Console.ReadLine();
            int i;
            bool success = int.TryParse(userNumberInput, out i);
            if (success == true){
                duration = i;
                break;
            }
            else{
                System.Console.WriteLine("Please only enter the number duration and try again. \n");
            }
        }
    }

    public void Animation(){
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(5);
        while (DateTime.Now < futureTime){
        Console.Write("+");

        Thread.Sleep(500);

        Console.Write("\b \b"); // Erase the + character
        Console.Write("-"); // Replace it with the - character
        }
    }

    void FinishMessage(){
        System.Console.WriteLine("Great job!");
        Thread.Sleep(4000);
        Console.Clear();
    }


}