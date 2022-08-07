// See https://aka.ms/new-console-template for more information

// Declare Fixed Size Array
int[] grades = new int[5]; // 5 space addresses will be reserved in memory for this array - 0, 1, 2, 3, 4

// Add values to Fixed Size Array
grades[0] = 1;
grades[1] = 25;
grades[2] = 38;
grades[3] = 44;
grades[4] = 59;

grades = new int[] { 1, 25, 38, 45, 54 };

for (int i = 0; i < grades.Length; i++)
{
    Console.Write($"Enter Grade for student {i + 1}: ");
    grades[i] = Convert.ToInt32(Console.ReadLine());
}

// Print values in Fixed Size Array
Console.WriteLine();
for (int i = 0; i < grades.Length; i++)
{
    Console.WriteLine($"Grade for student {i + 1}: {grades[i]}");
}

// Declare Variable Sized Array
String[] studentNames = new string[] {"Ralph", "Jack", "etc..."};

// Add values to Variable Size Array - Test
Console.WriteLine();
Console.WriteLine("Enter all names");
for (int i = 0; i < studentNames.Length; i++)
{
    Console.Write($"Enter Name for student {i + 1}: ");
    studentNames[i] = Console.ReadLine();
}

// Print values in Variable Size Array - Test
Console.WriteLine();
for (int i = 0; i < studentNames.Length; i++)
{
    Console.WriteLine($"Student name is: {studentNames[i]}");
}

