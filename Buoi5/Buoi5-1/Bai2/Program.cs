namespace Bai2;
public class SinhVien
{
    public int msv { get; set; }
    public string hoten{ get; set; }
    public float lt{ get; set; }
    public float th{ get; set; }

    public SinhVien()
    {
        msv = 0;
        hoten = " ";
        lt = 0.0f;
        th = 0.0f;
    }
    public SinhVien(int msv, string hoten, float lt, float th)
    {
        this.msv = msv;
        this.hoten = hoten;
        this.lt = lt;
        this.th = th;
    }

    public float Tb()
    {
        return (lt + th) / 2;
    }

    public override string ToString()
    {
        return $"{msv}, {hoten}, {lt}, {th}, {Tb()}";
    }
}
class Program
{
    public static void Main(string[] args)
    {
        SinhVien sv1 = new SinhVien(); 
        Console.WriteLine(sv1);
        SinhVien sv2 = new SinhVien( msv:2001, hoten:"Nguyen Van A", lt: 8.0f, th: 10.0f  );
        Console.WriteLine(sv2);

        SinhVien[] sinhvien = new SinhVien[3];
        sinhvien[0] = new SinhVien(1,  "Nguyen Van B", 8.0f, 10.0f);
        sinhvien[1] = new SinhVien( 2,  "Nguyen Van C", 9.0f, 10.0f);
        sinhvien[2] = new SinhVien( 3,  "Nguyen Van D", 10.0f, 10.0f);
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(sinhvien[i]);
        }
    }
}
