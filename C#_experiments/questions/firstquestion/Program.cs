// See https://aka.ms/new-console-template for more information

using System;

    string[] name = new string[10];
    Console.WriteLine("enter the names");
    for (int i = 0; i < name.Length; i++)
    {
        name[i] = Console.ReadLine();

    }
    //foreach (var item in name)
    //{
    Console.WriteLine(string.Join("->", name));
//}
while (true)
{
    Console.WriteLine("Enter 1 to sort, 2 to riverse, 3 to search,4 to find length, 5 to split spaces and 6 to find duplicate");
    int Choice = Convert.ToInt32(Console.ReadLine());
    switch (Choice)
    {
        case 1:
            first(name);
            break;
        case 2:
            second(name);
            break;
        case 3:
            third(name);
            break;
        case 4:
            fourth(name);
            break;
        case 5:
            fifth(name);
            break;
        case 6:
            sixth(name);
            break;
        default:
            return;
    }
}
static void first(string[] name)
{
    Array.Sort(name);
    Console.WriteLine(string.Join("->", name));
}
static void second(string[] name)
{
    Array.Reverse(name);
    Console.WriteLine(string.Join("->", name));
}
static void third(string[] name)
{
    Console.WriteLine("enter the element to be searched");
    string s = Console.ReadLine();
    int flag = 0;
    for (int i = 0; i < name.Length; i++)
    {
        if (name[i] == s)
        {
            //Console.WriteLine("element present");
            flag = 1;
        }
        //else
        //{
        //    Console.WriteLine("element not present");
        //}
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
static void fourth(string[] name)
{
    for (int i = 0; i < name.Length; i++)
    {
        int l = name[i].Length;
        Console.WriteLine(l);
    }
}
static void fifth(string[] name)
{
    foreach (var item in name)
    {
        if (item.Contains(' '))
        {
            string[] nme = item.Split(' ');

            //foreach (var it in nme)
            //{
            Console.WriteLine(string.Join("->", nme));
            //}
        }
    }
}
static void sixth(string[] name)
{
    for (int i = 0; i < name.Length; i++)
    {
        for (int j = i + 1; j < name.Length; j++)
        {
            if (name[i] == name[j])
            {
                Console.WriteLine(name[i]);
            }
        }
    }
}