// See https://aka.ms/new-console-template for more information
int[] arr = new int[10];

for (int i = 0; i < 5; i++)

{
    Console.WriteLine("enter weight");

    arr[i] = Convert.ToInt32(Console.ReadLine());

    if (arr[i] > 23)
    {
        var total = (arr[i] - 23) * 15;
        Console.WriteLine($"overweight fare total={total}");

    }
    else
    {
        Console.WriteLine("no overwheight");
    }
}
Console.WriteLine("sorted order :");
for (int i = 0; i < 5; i++)
{
    for (int j = i + 1; j < 5; j++)
    {
        if (arr[i] < arr[j])
        {
             int temp = arr[i];
             arr[i] = arr[j];
             arr[j] = temp;
        }
    }
}
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"{arr[i]}");
}
