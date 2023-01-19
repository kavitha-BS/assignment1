// See https://aka.ms/new-console-template for more information

using System;

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

int tot_month = diff * 12;
Console.WriteLine(tot_month);

int week = tot_month * 5;
Console.WriteLine(week);

int tot_day = week * 7;
Console.WriteLine(tot_day);

int hours = tot_day * 24;
Console.WriteLine(hours);

if ((0 == year % 4) && (0 != year % 100) || (0 == year % 400))
{
    Console.WriteLine("leap year");
}
else
{
    Console.WriteLine("not a leap year");
}