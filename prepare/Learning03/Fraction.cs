class Fraction{
    private int topNumber;
    private int bottomNumber;

    public Fraction()
    {
        topNumber = 1;
        bottomNumber = 1;
    }
    public Fraction(int wholeNumber)
    {
        topNumber = wholeNumber;
        bottomNumber = 1;
    }
    public Fraction(int topNum, int bottomNum)
    {
        topNumber = topNum;
        bottomNumber = bottomNum;
    }

    public int GetTopNum()
    {
        return topNumber;
    }
    public void SetTopNum(int newNum)
    {
        topNumber = newNum;
    }

    public int GetBottomNum()
    {
        return bottomNumber;
    }
    public void SetBottomNum(int newNum)
    {
        bottomNumber = newNum;
    }

    public string GetFractionString()
    {
        string stringFraction = topNumber + "/" + bottomNumber;
        return stringFraction;
    }

    public double GetDecimalValue()
    {
        double topNumberFloat = topNumber;
        double bottomNumberFloat = bottomNumber;
        double dec = topNumberFloat/bottomNumberFloat;
        return dec;
    }
}