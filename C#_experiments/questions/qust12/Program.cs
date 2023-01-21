// See https://aka.ms/new-console-template for more information
using System.Xml.Linq;

Console.WriteLine("enter the passenger names");
string[] name = new string[5];
for (int i = 0; i < 5; i++)
{
    name[i] = Console.ReadLine();
}
Console.WriteLine("enter the destinations");
string[] dest = new string[5];
for (int i = 0; i < 5; i++)
{
    dest[i] = Console.ReadLine();
}
Console.WriteLine("merged array is");
string[] merge_array = new string[name.Length + dest.Length];

int j = 0;
for (int i = 0; i < name.Length; i++)
{
    merge_array[j] = name[i];
    merge_array[j + 1] = dest[i];
    j = j + 2;

}
    //int j = 0;
    //for(int i =0; i < name.Length; i++)
    //{
    //    merge_array[i] = name[i];
    //    j++;
    //}
    //int k = 0;
    //for (int l = 0; l < dest.Length; l++)
    //{
    //    merge_array[k] = dest[l];
    //    k++;
    //}

 for (int i = 0; i < merge_array.Length; i++)
 {
    Console.WriteLine(merge_array[i]);
 }