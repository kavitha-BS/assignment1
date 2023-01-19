// See https://aka.ms/new-console-template for more information
Console.Write("Enter a month: ");
int month = int.Parse(Console.ReadLine());
Console.Write("Enter a day: ");
int day = int.Parse(Console.ReadLine());
Console.Write("Enter a year: ");
int year = int.Parse(Console.ReadLine());
DateTime inputtedDate = new DateTime(year, month, day);
Console.WriteLine(inputtedDate);

string CurrentYear = DateTime.Now.Year.ToString();
Console.WriteLine(CurrentYear);

int diff = Convert.ToInt32(CurrentYear) - year;
Console.WriteLine(diff);

switch (diff)
{
    case >= 0 and < 10:
        Console.WriteLine("the passenger is a kid");
        break;
    case >= 10 and < 30:
        Console.WriteLine("the passenger is youth");
        break;
    case >= 30 and < 60:
        Console.WriteLine("the passenger is adult");
        break;
    case >= 60:
        Console.WriteLine("the passenger is old");
        break;
}

