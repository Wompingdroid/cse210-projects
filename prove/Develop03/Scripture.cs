using System.ComponentModel.Design;
using System.Net.Quic;
using Microsoft.VisualBasic;

namespace Develope03;
public class Scripture
{
    public List<Word> words = new List<Word>();

    public bool allWordsHidden = false;
    public int CheckIfHidden(int i)
    {
        while(true){
            Random rnd = new Random();
            int randomNum = rnd.Next(0,i);
            var wordToChange = words[randomNum];
            
            if (wordToChange.GetBool() == false)
            {
                return randomNum;
            }
            else 
            {
                continue;
            }
        }
    }
    public void CheckIfAllHidden(int i)
    {
        for (int k = 0; k < i; k++)
            {
                var wordToCheck = words[k];
                var lastWord = words[i-1];
                if (wordToCheck == lastWord && lastWord.GetBool() == true)
                {
                    allWordsHidden = true;
                }
                else if (wordToCheck.GetBool() == false)
                {
                    break;
                }
            }
    }
}