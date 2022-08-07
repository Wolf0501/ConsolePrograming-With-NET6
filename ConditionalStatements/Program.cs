// See https://aka.ms/new-console-template for more information

Console.WriteLine("Enter number of apples: ");
int NumberOfApples = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter number of oranges: ");
int NumberOfOranges = Convert.ToInt32(Console.ReadLine());

// If Statements ( ==, <, >, >=, <=, != )
if(NumberOfApples > NumberOfOranges)
{
    Console.WriteLine("You have more Apples");
}
else if(NumberOfApples < NumberOfOranges)
{
    Console.WriteLine("You have more Oranges");
}
else if(NumberOfApples == NumberOfOranges)
{
    Console.WriteLine("You have the same number of Apples and Oranges");
}


Console.WriteLine("Enter final grade: ");
int grade = Convert.ToInt32(Console.ReadLine());
// Switch Statements
switch(grade)
{
    case int n when n >= 0 && n <= 59: //between 0 and 59
        Console.WriteLine("You Failed");
        break;
    case int n when n >= 60 && n <= 100: //between 60 and (&&) 100 -- or is ||
        Console.WriteLine("You passed");
        break;
    case 101:
        Console.WriteLine("Single Case Example");
        break;
    default:
        Console.WriteLine("Invalid Grade");
        break;
}

// Ternary Operators
var message = NumberOfApples > NumberOfOranges ? "you have more Apples" : "You have more Oranges";
Console.WriteLine(message);