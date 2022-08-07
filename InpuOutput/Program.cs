// See https://aka.ms/new-console-template for more information


//Decalre Variable - storage space in memory while application is runing
/*
    Data Types
    string - word/number (name, licence plate) - "Ralph", "Hello World"
    int - whhole numbers | double/float - decimals
    char - one character ('A', '7', '%')
*/
string FullName; //PascalCase

//Allow user input and store in variable
Console.WriteLine("Enter your full name: "); //WriteLine prints on the line then CR
FullName = Console.ReadLine();

//Print contents of variable/user's input
Console.Write("Your full name is: "); // Write is no CR
Console.WriteLine(FullName);