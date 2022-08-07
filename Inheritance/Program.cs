// See https://aka.ms/new-console-template for more information
using System;


Console.Write("Enter Length: ");
int length = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Width: ");
int width = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Height: ");
int height = Convert.ToInt32(Console.ReadLine());


var cube = new Cube(width, height, length);

var triangle1 = new Triangle();
var triangle2 = new Triangle() { Height = height, Length = length, Hypotenuses = 10};
var triangle3 = new Triangle(10);
var triangle4 = new Triangle(10, height, length);

var rectangle = new Rectangle();

rectangle.Width = width;
rectangle.Length = length;

Console.WriteLine();
Console.WriteLine("Cube area is " + cube.GetArea());
Console.WriteLine("Cube volume is " + cube.GetVolume());
Console.WriteLine();
Console.WriteLine("Triangle area is " + triangle1.GetArea());
Console.WriteLine("Triangle area is " + triangle2.GetArea());
Console.WriteLine("Triangle area is " + triangle3.GetArea());
Console.WriteLine("Triangle area is " + triangle4.GetArea());
Console.WriteLine();
Console.WriteLine("Rectangle area is " + rectangle.GetArea());