using System;

namespace Bai3;

class Program
{
    static void Main(string[] args)
    {
        var data = new Dictionary<string, Dictionary<string, int>>();
        add("John", "Laptop", 5);
        add("John", "Phone", 3);
        add("Alice", "Tablet", 8);
        add("Alice", "Phone", 4);
        add("Bob", "Laptop", 2);
        add("Bob", "Tablet", 6);
    }

    static void add( string name, string thing, int value)
    {
        data[name] = new Dictionary<string, int>();
        
    }

    static string beste()
    {
        
    }

    static string bestp()
    {
        
    }
}