using System.Net.NetworkInformation;

namespace Learning05;


class Circle : Shape
{
    private double radius = 4;

    private double pi = 3.1415926;

    public override double GetArea()
    {
        return pi*radius*radius;
    }
}