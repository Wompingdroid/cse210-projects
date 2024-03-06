namespace Learning05;

class Square : Shape 
{
    private double side = 4;

    public override double GetArea(){
        return side*side;
    }

}