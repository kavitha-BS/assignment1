//See https://aka.ms/new-console-template for more information
int[] arr = new int[10];

for (int i = 1; ; i++)

{

    Console.WriteLine("enter the flight no:");

    arr[i] = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Do you want to continue?y/n");

    var s = Console.ReadLine();

    if (s == "n")

    {

        break;

    }

}
//var Name = "Kavitha B S";
//var Temp = Name.Split(' ');
////Console.WriteLine(string.Join(",", Temp));
////for (int i = Temp.Length - 1; i >= 0; i--)
////{
////    //Console.Write($"{Temp[i]} ");
////    Console.Write($"{Temp[i]} ");
////}
//Console.WriteLine(Temp[2] + Temp[1] + Temp[0]);

