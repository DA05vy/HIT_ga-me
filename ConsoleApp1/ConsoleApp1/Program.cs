using System;

namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        int a = Convert.ToInt32(Console.ReadLine());
        switch (a)
        {
            case 0:
                Console.WriteLine("case 0");
        }

        int b = 20;
        Console.WriteLine( (b>8)? "YES": "NO");
    }
}
