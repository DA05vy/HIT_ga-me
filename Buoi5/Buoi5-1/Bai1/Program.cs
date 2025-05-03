// Bài 1. Viết chương trình tính diện tích, chu vi hình chữ nhật.
// - Hãy viết lớp HinhChuNhat gồm có:
//      Attributes : chiều dài, chiều rộng.
//      Phương thức thiết lập (set), và lấy (get) thông tin chiều dài, chiều rộng.
//      Phương thức tính diện tích, chu vi.
//      Phương thức toString gồm các thông tin dài, rộng, diện tích, chu vi.
// - Xây dựng lớp chứa hàm main cho phần kiểm nghiệm. Dài rộng có thể nhập từ bàn phím.
using System;
namespace Buoi5_1;


public class hcn
{
    public double r { get; set; }
    public double d { get; set; }

    public hcn(double r, double d)
    {
        this.r = r;
        this.d = d; 
    }

    public double area()
    {
        return r * d;
    }

    public double perimeter()
    {
        return (r + d) * 2;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        hcn HCN = new hcn(r:4.0, d:2.0);
        HCN.ToString(); 
        Console.WriteLine(HCN.r);
        Console.WriteLine(HCN.d); 
        Console.WriteLine(HCN.area());
        Console.WriteLine(HCN.perimeter());
    }
}
