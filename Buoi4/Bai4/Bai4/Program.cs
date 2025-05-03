using System;

namespace Bai4;

class Program
{
    static void Main(string[] args)
    {
        int t = int.Parse(Console.ReadLine()); 
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] val = input.Split();
                int first = int.Parse(val[0]);
                int second = int.Parse(val[1]);
                var pair = Tuple.Create(first, second);
                Console.WriteLine($"Pair: ({pair.Item1}, {pair.Item2})");
            }
        }
    }
}
    