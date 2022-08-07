// See https://aka.ms/new-console-template for more information

//Variable Declaration and Types
string FullName = string.Empty;
int age = 0;
double salary = 0;
char gender = char.MinValue;
bool working = false;

//Prompt user for input
Console.Write("Please enter your name: ");
FullName = Console.ReadLine();

Console.Write("Please enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter your yearly salary: ");
salary = Convert.ToDouble(Console.ReadLine());

Console.Write("Please enter your Gender (M or F): ");
gender = Convert.ToChar(Console.ReadLine());

Console.Write("Are you working (true or false): ");
working = Convert.ToBoolean(Console.ReadLine());

//Print Information

//concatinate
Console.WriteLine("Your Name is: " + FullName);

// {0}, {1} ect are placeholders and will take the variables at the end in order for example.. {0} {1} with var of age, FullName {0} is age {1} is FullName
Console.WriteLine("Your age is: {0}", age);

//interpolation
Console.WriteLine($"Your salary is: {salary}");
Console.WriteLine($"Your gender is: {gender}");
Console.WriteLine($"You are employed: {working}");