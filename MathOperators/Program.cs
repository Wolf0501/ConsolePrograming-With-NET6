// See https://aka.ms/new-console-template for more information

//Basic Assignment Operator
int num = 5;

//Arithmetic Operators
int num1 = 11;
int num2 = 12;

Console.WriteLine($"Addition: {num1 + num2}");
Console.WriteLine($"Subtraction: {num1 - num2}");
Console.WriteLine($"Multiplication: {num1 * num2}");
Console.WriteLine($"Division: {num1 / num2}");
Console.WriteLine($"Modulus: {num1 % num2}"); // returns only the remainder of the division

num1 = num1 + 4; //15
Console.WriteLine($"New Value of num1: {num1}");
Console.WriteLine($"Addition: {num1 + num2}");
Console.WriteLine($"Subtraction: {num1 - num2}");
Console.WriteLine($"Multiplication: {num1 * num2}");
Console.WriteLine($"Division: {num1 / num2}");
Console.WriteLine($"Modulus: {num1 % num2}"); // returns only the remainder of the division

//Compound Assignment Operators

num1 += 4; //same as num1 = num1 + 4; 15+4 = 19
Console.WriteLine(num1);
num1 -= 4; //same as num1 = num1 - 4; 19-4 = 15
Console.WriteLine(num1);
num1 *= 4; //same as num1 = num1 * 4; 15*4 = 60
Console.WriteLine(num1);
num1 /= 4; //same as num1 = num1 / 4; 60/4 = 15
Console.WriteLine(num1);
num1 %= 4; //same as num1 = num1 % 4; 15%4 = 3
Console.WriteLine(num1);