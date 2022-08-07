// See https://aka.ms/new-console-template for more information


// For Loop (Counter Controlled)
for (int i = 0; i < 5; i++) // ++ is an accumulator (i = i+1) -- to increase by 2 'i+=2'
{
    Console.WriteLine("I am in a loop");
    Console.WriteLine($"Counter Value: {i}");
}

Console.WriteLine();
Console.WriteLine("FOOR LOOP FINISHED");

// While Loop (Condition Controlled - Pre Check)
int n = 0;
while (n < 5)
{
    Console.WriteLine("Input a number: ");
    n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"You entered {n}");
}

Console.WriteLine();
Console.WriteLine("While loop finished");

// Do..While Loop (Condition Controlled - Post Check)
int n = 0;
do
{
    Console.WriteLine("Input a number: ");
    n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"You entered {n}");
}
while (n < 5);

Console.WriteLine();
Console.WriteLine("Do While loop finished");

// Foreach - Honorable Mention