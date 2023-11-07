public class Shape
{
    //public string Color { get; set; }
    private string _color;

    public string GetColor()
    {
        return _color;
    }

    public Shape(string color)
    {
        _color = color;
    }

    public virtual double GetArea()
    {
        return 0.0;
    }


}