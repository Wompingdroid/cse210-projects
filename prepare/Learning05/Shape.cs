namespace Learning05;
abstract class Shape
{
protected string _color = "white";

public string GetColor()
{
    return _color;
}

public void SetColor(string newColor)
{
    _color = newColor;
}

public abstract double GetArea();

}