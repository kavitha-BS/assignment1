// See https://aka.ms/new-console-template for more information
using System;
using System.Xml.Linq;

Console.WriteLine("enter the fare");
int[] fare = new int[5];
for(int i = 0;i < 5; i++)
{
    fare[i] = Convert.ToInt32(Console.ReadLine());
}
//for (int i = 0; i < fare.Length; i++)
//{
//    Console.WriteLine(fare[i]);
//}
Console.WriteLine(string.Join("->", fare));
while (true)
{
    Console.WriteLine("Enter 1 to sort, 2 to riverse, 3 to search,4 to minimum and maximum fare, 5 find duplicate fare");
    int Choice = Convert.ToInt32(Console.ReadLine());
    switch (Choice)
    {
        case 1:
            first(fare);
            break;
        case 2:
            second(fare);
            break;
        case 3:
            third(fare);
            break;
        case 4:
            fourth(fare);
            break;
        case 5:
            fifth(fare);
            break;
        default:
            return;
    }
}
static void first(int[] fare)
{
    for (int i = 0; i < 5; i++)
    {
        for (int j = i + 1; j < 5; j++)
        {
            if (fare[i] > fare[j])
            {
                int temp = fare[i];
                fare[i] = fare[j];
                fare[j] = temp;
            }
        }
    }
    Console.WriteLine(string.Join("->", fare));
}
static void second(int[] fare)
{
    for (int i = 0; i < 5; i++)
    {
        for (int j = i + 1; j < 5; j++)
        {
            if (fare[i] < fare[j])
            {
                int temp = fare[i];
                fare[i] = fare[j];
                fare[j] = temp;
            }
        }
    }
    Console.WriteLine(string.Join("->", fare));
}
static void third(int[] fare)
{
    Console.WriteLine("enter the element to be searched");
    int s = Convert.ToInt32(Console.ReadLine());
    int flag = 0;
    for (int i = 0; i < 5; i++)
    {
        if (fare[i] == s)
        {
            flag = 1;
        }
    }
    if (flag == 1)
    {
        Console.WriteLine("element present");
    }
    else
    {
        Console.WriteLine("element not present");
    }
}
static void fourth(int[] fare)
{
    //int GetLargestElementUsingFor(int[] fare)
    //{
    //    int maxElement = fare[0];
    //    for (int index = 1; index < fare.Length; index++)
    //    {
    //        if (fare[index] > maxElement)
    //            maxElement = fare[index];
    //    }
    //    return maxElement;
    //}
    int maxValue = fare.Max();
    Console.WriteLine("maximum value is:");
    Console.WriteLine(maxValue);
    int minValue = fare.Min();
    Console.WriteLine("minimum value is:");
    Console.WriteLine(minValue);
}
static void fifth(int[] fare)
{
    for (int i = 0; i < fare.Length; i++)
    {
        for (int j = i + 1; j < fare.Length; j++)
        {
            if (fare[i] == fare[j])
            {
                Console.WriteLine(fare[i]);
            }
        }
    }
}