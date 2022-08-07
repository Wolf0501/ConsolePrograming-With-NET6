// See https://aka.ms/new-console-template for more information

// declare variables
Person person1 = new(); //Person person1 = new Person();
string middleName = string.Empty;
DateTime now = DateTime.Now;

//request input from users
Console.Write("Enter First Name: ");
person1.FirstName = Console.ReadLine();

Console.Write("Enter Middle Name: ");
middleName = Console.ReadLine();

Console.Write("Enter Last Name: ");
person1.LastName = Console.ReadLine();

Console.Write("Enter Age: ");
person1.Age = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Salary: ");
int salary = Convert.ToInt32(Console.ReadLine());
person1.setSalary(salary);

// output entered data
Console.WriteLine();
if (string.IsNullOrEmpty(middleName))
{
    Console.WriteLine("Full Name is: " + person1.getFullName());
}
else
{
    Console.WriteLine("Full Name is: " + person1.getFullName(middleName));
}
Console.WriteLine("Age is: " + person1.Age);
Console.WriteLine("salary is: " + person1.getSalary());


// TEST - calculate year of birth by age provided

int YOB = now.Year - (person1.Age);
Console.WriteLine($"Your year of birth is: {YOB}");
Console.WriteLine($"Your year of birth is: {DateUtil.YearOfBirth(person1.Age)}"); // static class

