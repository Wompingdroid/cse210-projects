namespace Develope03;
public class Word
{
    private bool hidden = false;

    private string actualWord;

    public bool GetBool()
    {
        return hidden;
    }

    public void SetBool(bool change)
    {
        hidden = change;
    }

    public string GetWord()
    {
        return actualWord;
    }

    public void SetWord(string wordChange)
    {
        actualWord = wordChange;
    }

    public Word (string theWord)
    {
        actualWord = theWord;
        hidden = false;
    }
}