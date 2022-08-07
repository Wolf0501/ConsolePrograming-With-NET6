// See https://aka.ms/new-console-template for more information
// Shortcut to propertiesd is prop tab tab
// shortcut to constructor is ctor tab tab

class Cube : Shape, IShape
{
    public Cube(int width, int height, int length)
    {
        Width = width;
        Height = height;
        Length = length;
    }

    public int Width { get; set; }

    public double GetArea()
    {
        return Length * Width;
    }

    public double 
        GetVolume()
    {
        return Length * Height * Width;
    }
}
