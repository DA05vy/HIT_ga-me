using System;
namespace Bai1;

class Program
{
    static void Main( string [] args )
    {
        //B1a
        double a = 9;
        double T = 2.0/5.0;
        double t1 = 2.125;
        int rT = (int)(t1 / T);
        double dT = t1 % T;
        double kc = rT * 4 * a + 2 * a * Math.Abs(Math.Sin(5 * Math.PI * dT));
        Console.WriteLine($"Quang duong vat A di duoc sau {t1} s: {kc} cm" );
        
        //B1b
        Console.Write("Nhap a:");
        double aB = double.Parse(Console.ReadLine());
        Console.Write("Nhap x:");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Nhap t:");
        double t = double.Parse(Console.ReadLine());
        Console.WriteLine($"{a} cos( {x}pi + pi/2 )");
        double TB = 2.0 / x;
        double rTB = t / TB;
        double dTB = t % TB;
        double kcb = rTB * 4 * aB + 2 * aB * Math.Abs(Math.Sin(x * Math.PI * dTB));
        Console.WriteLine($"Quang duong vat A di duoc sau {t} s: {kcb} cm" );
    }
}