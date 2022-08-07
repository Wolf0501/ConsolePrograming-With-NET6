// See https://aka.ms/new-console-template for more information

// writing to tet mself on trying to have two lists one string onw int and have them match up on print

// declare lists for Names and Grades

List<string>  names = new List<string>();
string name = string.Empty;

List<int> grades = new List<int>();
int grade = 0;

// enter data into the list

Console.WriteLine("Please enter names and grades");
Console.WriteLine("when you have finished enter -1");
Console.WriteLine();

while (!name.Equals ("-1"))
{
    Console.Write("Enter Name: ");
    name = Console.ReadLine();
    if (!string.IsNullOrEmpty(name) && !name.Equals("-1"))
    {
        names.Add (name);
        Console.Write($"Enter grade for {name} :");
        grade = Convert.ToInt32(Console.ReadLine());
        if (grade > 0 && grade <101)
        {
            grades.Add(grade);
        }
        else
        {
            Console.WriteLine("Invalid Grade");
            Environment.Exit(0); // new command to exit the console
        }
    }
}


// displaying data
Console.WriteLine();
Console.WriteLine();

for (int i = 0; i < names.Count; i++)
{
    Console.WriteLine($"{names[i]} recieved a grade of {grades[i]}");
    System.Threading.Thread.Sleep(1000); // wait for 1 second
}