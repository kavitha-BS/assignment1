// See https://aka.ms/new-console-template for more information
using System;

string[] flight = new string[1];
Console.WriteLine("enter the flifht no albahabet('F','W','Q','N','A')");
for (int i = 0; i < flight.Length; i++)
{
    flight[i] = Console.ReadLine();
}
for (int i = 0; i < flight.Length; i++)
{
    if (flight[i] == "F")
    {
        for (int j = 100; j < 110; j++)
        {
            if(j % 2 != 0)
            {
                //Console.WriteLine(string.Join("F ", j));
                //Console.WriteLine("hh");
                Console.WriteLine("F" + j);
                
            }
        }
    }
}
for (int i = 0; i < flight.Length; i++)
{
    if (flight[i] == "W")
    {
        for (int j = 100; j < 112; j++)
        {
            if (j % 2 == 0)
            {
                //Console.WriteLine(string.Join("F ", j));
                //Console.WriteLine("hh");
                Console.WriteLine("W" + j);

            }
        }
    }
}
for (int i = 0; i < flight.Length; i++)
{
    if (flight[i] == "Q")
    {
        for (int K = 1; K <= 30; K++)
        {
            int counter = 0;
            for (int j = 2; j <= K / 2; j++)
            {
                if (K % j == 0)
                {
                    counter++;
                    break;
                }
            }

            if (counter == 0 && K != 1)
            {
                Console.Write("Q{0} ", K);
            }
        }
    }
}
for (int i = 0; i < flight.Length; i++)
{
    if (flight[i] == "N")
    {
        int val1 = 0, val2 = 1, val3, n;

        n = 10;

        //Console.WriteLine("1st ten Fibonacci numbers:");
        Console.Write("N" + val1 + " " + "N" + val2 + " ");

        for (int p = 2; p < n; ++p)
        {
            val3 = val1 + val2;
            Console.Write("N" + val3 + " ");
            val1 = val2;
            val2 = val3;
        }
    }
}
for (int i = 0; i < flight.Length; i++)
{
    if (flight[i] == "A")
    {
        for (int num = 100; num <= 1000; num++)
        {
           int temp = num;
           int sum = 0;

            while (temp != 0)
            {
               int r = temp % 10;
                temp = temp / 10;
                sum = sum + (r * r *r);
            }
            if (sum == num)
                Console.Write("A{0} ", num);
            
        }
        for (int num = 1000; num <= 9000; num++)
        {
            int temp = num;
            int sum = 0;

            while (temp != 0)
            {
                int r = temp % 10;
                temp = temp / 10;
                sum = sum + (r * r * r * r );
            }
            if (sum == num)
                Console.Write("A{0} ", num);

        }
        for (int num = 10000; num <= 90000; num++)
        {
            int temp = num;
            int sum = 0;

            while (temp != 0)
            {
                int r = temp % 10;
                temp = temp / 10;
                sum = sum + (r * r * r * r *r);
            }
            if (sum == num)
                Console.Write("A{0} ", num);

        }
        for (int num = 100000; num <= 900000; num++)
        {
            int temp = num;
            int sum = 0;

            while (temp != 0)
            {
                int r = temp % 10;
                temp = temp / 10;
                sum = sum + (r * r * r * r *r *r);
            }
            if (sum == num)
                Console.Write("A{0} ", num);

        }
    }
}