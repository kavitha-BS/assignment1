// See https://aka.ms/new-console-template for more information
string[] name = new string[5];
int[] miles = new int[5];
Console.WriteLine("enter the names");
for (int i = 0; i < 5; i++)
{
    name[i] = Console.ReadLine();

}

Console.WriteLine("enter the distance travelled");
for (int i = 0; i < 5; i++)
{
    miles[i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < 5; i++)
{
    if (miles[i] > 10000 && miles[i] < 20000)
    {
        Console.WriteLine("you awarded 10 flyer ponts");
    }
    else if (miles[i] > 20000 && miles[i] < 50000)
    {
        Console.WriteLine("you awarded 20 flyer points");
    }
    else if (miles[i] > 50000 && miles[i] < 100000)
    {
        Console.WriteLine("you awarded 30 flyer points");
    }
    else if (miles[i] > 100000)
    {
        Console.WriteLine("you awarded 50 flyer points");
    }
    else
    {
        Console.WriteLine("try nxt time");
    }
    //Console.WriteLine(miles[i]);

}
Console.ReadKey();