using System;

namespace Buoi5;

public class Animal
{
    public string name;
    public string color;

    public void Speak()
    {
        Console.WriteLine("M M");
    }

    public void SpeakWithHuman()
    {
        Console.WriteLine("D D");
    }

    public void SpeakWithHuman(string name)
    {
        Console.WriteLine($"{name}");
    }

    public void Eat()
    {
        Console.WriteLine("Candy");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Cat meocon = new Cat();
        meocon.Speak();
        meocon.Eat();
    }
}