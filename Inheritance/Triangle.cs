// See https://aka.ms/new-console-template for more information
// Shortcut to propertiesd is prop tab tab
// shortcut to constructor is ctor tab tab
class Triangle : Shape, IShape
{
    public Triangle()
    {

    }

    public Triangle(int hyp)
    {
        Hypotenuses = hyp;
    }

    public Triangle(int hyp, int height, int length)
    {
        Hypotenuses = hyp;
        Height = height;
        Length = length;
    }

    public double Hypotenuses { get; set; }

    public double GetArea()
    {
        return .5 * Length * Height;
    }
}