using System;
using System.ComponentModel.Design;
using System.Xml.Serialization;
namespace Develope04;
class Program
{
    static void Main(string[] args)
    {
        private string activityChoice;
        

        public void Menu()
        {
            while (true){
                System.Console.WriteLine("Menu Options:");
                System.Console.WriteLine("  1. Start breathing activity");
                System.Console.WriteLine("  2. Start reflection activity");
                System.Console.WriteLine("  3. Start listing activity");
                System.Console.WriteLine("  4. Quit");
                System.Console.Write("Select a choice from the menu: ");
                string choice = Console.ReadLine(); 
                if (choice == "1" || choice == "2" || choice == "3" ||choice == "4"){
                    activityChoice = choice;
                    break;
                }else{
                    System.Console.WriteLine("Please only enter only a number");
                }

            }
        }

        public void Run(){
            if(activityChoice == "1"){

            }else if(activityChoice == "2"){

            }else if(activityChoice == "3"){

            }else if(activityChoice == "4"){

            }else{
                System.Console.WriteLine("Something went wrong");
            }
        }

    }
}