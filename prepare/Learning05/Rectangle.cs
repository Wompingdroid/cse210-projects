namespace Learning05;

class Rectangle : Shape
{
    private double side = 4;
    private double length = 2;

    public override double GetArea()
    {
        return side*length;
    }


}