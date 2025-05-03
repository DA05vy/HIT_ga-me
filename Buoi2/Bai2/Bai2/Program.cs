using System;
namespace Bai2;

class Program
{
    static void Main(string[] args)
    {
        double vo = 20;
        double the = 30;
        double g = 9.8;
        double phi = the / 180;
        
        //a
        double vox = 20 * Math.Cos(phi * Math.PI);
        Console.WriteLine($" Van toc theo phuong ngang: {vox:F2} m/s");
        double voy = 20*Math.Sin(phi * Math.PI);
        Console.WriteLine($" Van toc theo phuong thang dung: {voy:F2} m/s");
        
        //b
        double t = voy / g;
        Console.WriteLine($" Thoi gian vat len diem cao nhat: {t:F2} s");
        
        //c
        double h = voy * t - 0.5 * g * t * t;
        Console.WriteLine($" Chieu cao cuc dai cua vat: {h:F2} m");
        
        //d
        double d = vox * 2 * t;
        Console.WriteLine($" Quang duong di cua vat: {d:F2} m");

    }
}