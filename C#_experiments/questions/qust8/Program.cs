// See https://aka.ms/new-console-template for more information
Console.WriteLine("enter the fare");
int[] fare = new int[5];
for (int i = 0; i < 5; i++)
{
    fare[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(string.Join(", ", fare));

Console.WriteLine("enter the destinations");
string[] desti = new string[5];
for (int i = 0; i < 5; i++)
{
    desti[i] = Console.ReadLine();
}
Console.WriteLine(string.Join(", ",desti));
Console.WriteLine("enter a no between 0 and 5");
int item = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(fare[item]);
Console.WriteLine(desti[item]);
