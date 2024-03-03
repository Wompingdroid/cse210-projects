using System;
using System.ComponentModel.Design;
using System.Xml.Serialization;
namespace Develope04;
class Program
{
    static void Main()
    {
        string activityChoice = "5";
        activityChoice = "8";
        Activities activities = new Activities();
        Program program = new Program();
        

            while(activityChoice != "4"){
                System.Console.WriteLine("Menu Options:");
                System.Console.WriteLine("  1. Start breathing activity");
                System.Console.WriteLine("  2. Start reflection activity");
                System.Console.WriteLine("  3. Start listing activity");
                System.Console.WriteLine("  4. Quit");
                System.Console.Write("Select a choice from the menu: ");
                activityChoice = Console.ReadLine(); 
                
                // program.Menu();

                if(activityChoice == "1"){
                    Breathing breathing = new Breathing();
                    breathing.RunBreathing();

                }else if(activityChoice == "2"){
                    Reflection reflection = new Reflection();
                    reflection.RunReflection();

                }else if(activityChoice == "3"){
                    Listing listing = new Listing();
                    listing.RunListing();

                }else if(activityChoice == "4"){
                    break;

                }else{
                    System.Console.WriteLine(activityChoice);
                    System.Console.WriteLine("Something went wrong");
                }
            }
    }
}