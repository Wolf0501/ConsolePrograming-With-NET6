// See https://aka.ms/new-console-template for more information

// Empty DateTime
using System.Globalization;

DateTime date = new DateTime();

// Create a DateTime from date and time
DateTime dateOfBirth = new DateTime(1973, 04, 24);
Console.WriteLine("My DOB is: " + dateOfBirth);
Console.WriteLine("My DOB is: " + dateOfBirth.Date);

Console.WriteLine("Day of week:{0}", dateOfBirth.DayOfWeek);
Console.WriteLine("Day of year:{0}", dateOfBirth.DayOfYear);
Console.WriteLine("Time of day: " + dateOfBirth.TimeOfDay);
Console.WriteLine("Tick: " + dateOfBirth.Ticks);
Console.WriteLine("Kind: " + dateOfBirth.Kind);

// Create a DateTime from current timestamp
DateTime now = DateTime.Now;
Console.WriteLine("The time now is: " + now);

// Create a DateTime from a String
DateTime dateFromString = DateTime.Parse("1/31/2022", CultureInfo.InvariantCulture);
Console.WriteLine("The Date from string is: " + dateFromString);

// Add Additional Time
Console.WriteLine("One hour from now is: " + now.AddHours(1));
Console.WriteLine("One day from now is: " + now.AddDays(1));

// Ticks from DateTime
Console.WriteLine("Time as a numeral: " + now.Ticks);

// Date Only
DateOnly dateOnlyOfBirth = DateOnly.FromDateTime(dateOfBirth);
Console.WriteLine("Date only: " + dateOnlyOfBirth);

// Time Only
TimeOnly timeOnlyOfBirth = TimeOnly.FromDateTime(now);
Console.WriteLine("Time only: " + timeOnlyOfBirth);

