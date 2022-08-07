// See https://aka.ms/new-console-template for more information
// Shortcut to propertiesd is prop tab tab
// shortcut to constructor is ctor tab tab
class Rectangle : Shape, IShape
{
    public double Width { get; set; }
    public double GetArea()
    {
        return Length * Width;
    }
}