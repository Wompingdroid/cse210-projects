using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
namespace Develope03;
class Program
{
    static void Main(string[] args)
    {
        //first call instances of refference and scripture
        Reference scriptureRefference = new Reference();
        Scripture scripture = new Scripture();

        //compile the list of words
        string scriptStringVar = scriptureRefference.GetScript();
        var listOfStringScripture = scriptStringVar.Split(" ");
        int i = 0; //i will end up being the word number cap
        foreach (string wordInScript in listOfStringScripture)
        {
            Word word = new Word(wordInScript);
            scripture.words.Add(word);
            i += 1;
        }
        

        //actual looping program
        while(true)
        {
            Console.Clear();

            //print words to console
            System.Console.Write(scriptureRefference.GetTitle()+" ");
            foreach (var item in scripture.words)
            { 
                System.Console.Write( item.GetWord() + " ");
            }

            System.Console.WriteLine($"\nPress enter to hide three words or type 'quit' to quit");
            string userInput = Console.ReadLine();
            
            if (userInput == "")
            {
                //hide three lines
                if (scripture.allWordsHidden == false){
                    for (int j = 0; j < 3; j++)
                    {
                        if (scripture.allWordsHidden == true)
                        {
                            break;
                        }
                        string changedWord = "";
                        
                        int randomNum = scripture.CheckIfHidden(i);
                        var wordToChange = scripture.words[randomNum];
                        
                        wordToChange.SetBool(true);
                        foreach(char letter in wordToChange.GetWord())
                        {
                            changedWord += "_";
                        }
                        wordToChange.SetWord(changedWord);
                        scripture.CheckIfAllHidden(i);
                        
                    }
                }
                else
                {
                    continue;
                }
            }
            else if (userInput == "quit")
            {
                break;
            }
            //break when all words are out
            if (scripture.allWordsHidden == true && userInput == "")
            {
            //have to re-print the current status of the words before quit
            Console.Clear();
            System.Console.Write(scriptureRefference.GetTitle()+" ");
            foreach (var item in scripture.words)
            { 
                System.Console.Write( item.GetWord() + " ");
            }
            break;
            }

        }





    }
}