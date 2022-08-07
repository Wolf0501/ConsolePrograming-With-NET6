// See https://aka.ms/new-console-template for more information

/*
    try - a try block attempts an operation
    catch - catch any fata error or exception
    finally - whether the try or catch was sucessful, do this
    throw - end program execution with an error
 */

Console.Write("Enter first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

try
{
    int quotient = num1 / num2;
    Console.WriteLine("Result is: " + quotient.ToString());
}
catch(DivideByZeroException ex)
{
    Console.WriteLine($"Illegal Operation: {ex.Message}");
}
catch(Exception ex)
{
    throw ex;
}
finally
{
    Console.WriteLine("This is the end of the program");
}