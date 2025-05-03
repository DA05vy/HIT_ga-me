using System;
using System.Collections;

namespace Bai2;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhap chuoi: ");
        string input = Console.ReadLine();
        if (val(input))
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }

    static bool val(string input)
    {
        Stack stack = new Stack();
        foreach (char c in input)
        {
            if (c == '(' || c == '[' || c == '{')
            {
                stack.Push(c);
            }
            else if (c == ')' || c == ']' || c == '}')
            {
                if (stack.Count == 0)
                {
                    return false;
                }

                char lastOpen = (char)stack.Pop();

                if ((c == ')' && lastOpen != '(') ||
                    (c == ']' && lastOpen != '[') ||
                    (c == '}' && lastOpen != '{'))
                {
                    return false;
                }
            }
        }
        return stack.Count == 0;
    }
}