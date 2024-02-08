using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction defaultFraction = new Fraction();
        string testDefaultFraction = defaultFraction.GetFractionString();
        double testDefaultFractionInt = defaultFraction.GetDecimalValue();
        System.Console.WriteLine(testDefaultFraction);
        System.Console.WriteLine(testDefaultFractionInt);

        Fraction wholeFraction = new Fraction(6);
        string testWholeFraction = wholeFraction.GetFractionString();
        double testWholeFractionInt = wholeFraction.GetDecimalValue();
        System.Console.WriteLine(testWholeFraction);
        System.Console.WriteLine(testWholeFractionInt);

        Fraction bothFraction = new Fraction(6,7);
        string testBothFraction = bothFraction.GetFractionString();
        double testBothFractionInt = bothFraction.GetDecimalValue();
        System.Console.WriteLine(testBothFraction);
        System.Console.WriteLine(testBothFractionInt);

        System.Console.WriteLine("setting whole number Fraction to 10");
        wholeFraction.SetTopNum(10);
        System.Console.WriteLine("getting new whole number fraction top number");
        int testGetAndSet = wholeFraction.GetTopNum();
        System.Console.WriteLine(testGetAndSet);

    }
}