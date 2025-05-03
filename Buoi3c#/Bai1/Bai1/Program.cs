using System;

class Program
{
    static void Main()
    {
        //bai1
        Console.WriteLine("Ve hinh chu nhat");
        Console.Write("Chieu dai: ");
        int d = int.Parse(Console.ReadLine());
        Console.Write("Chieu dong: ");
        int r = int.Parse(Console.ReadLine());
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < d; j++)
            {
                if (i == 0 || i == r - 1 || j == 0 || j == d - 1)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write(' ');
                }
            }
            Console.WriteLine();
        }
        
        //bai2
        Console.WriteLine("Ve hinh tam giac can");
        Console.Write("Nhap chieu cao:");
        int c = int.Parse(Console.ReadLine());
        for (int i = 0; i < c; i++)
        {
            for (int j = 0; j < c * 2 - 1; j++)
            {
                if (j == c - i - 1 || j == c + i - 1)
                {
                    Console.Write('*');
                }
                else if (i == c - 1)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write(' ');
                }
            }
            Console.WriteLine();
        }
    }
}