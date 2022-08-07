// See https://aka.ms/new-console-template for more information

string firstName = "Ralph";
string lastName = "Steele";
DateTime date = DateTime.Now;

//Print to screen
Console.WriteLine(firstName);

//Concatenation
Console.WriteLine(firstName + " " + lastName);
Console.WriteLine($"My full name is {lastName}, {firstName}");
Console.WriteLine("My full name is {0}, {1}", lastName, firstName);

//String length
int length = firstName.Length;
Console.WriteLine($"Your first name is {length} letters long");

//Replace string parts
string newName = firstName.Replace('a', 'o');
Console.WriteLine($"Your new name is {newName}");

string newName1 = firstName.Replace('h', ' ');
Console.WriteLine($"Your new name is {newName1}");

//Append to other string variable
string fullName = firstName + " " + lastName;
Console.WriteLine($"Your full name is {fullName}");

//Split string
string[] splitName = fullName.Split('l');
for (int i = 0; i < splitName.Length; i++)
{
    Console.WriteLine(splitName[i]);
}

string nullString = null;
string emptyString1 = "";
string whitespaceString = " ";

//Compare strings
if (string.IsNullOrEmpty(nullString))
{
    Console.WriteLine("String is null");
}

if(firstName == lastName)
{
    Console.WriteLine("Names are equal");
 }

if (firstName != lastName);
{
    Console.WriteLine("Names are not equal");
}

int comparisonResult = string.Compare(firstName, lastName);
if(comparisonResult == 0)
{
    Console.WriteLine("Names are equal");
}
else
{
    Console.WriteLine("Names are not equal");
}

//Convert to string
string convertedString = string.Empty;
int number = 123456789;

convertedString = number.ToString();
convertedString = 1234567890.ToString();

fullName = fullName.ToUpper();
fullName = fullName.ToLower();

Console.WriteLine(fullName);