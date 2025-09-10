using Bai8;

class Program
{
    static void Main(string[] args)
    {
        // Su dung constructor khong tham so
        PhuongTrinhBac2 pt1 = new PhuongTrinhBac2();
        pt1.HienThi();
        pt1.TinhNghiem();

        Console.WriteLine("-------------------------");

        // Su dung constructor co tham so
        Console.Write("Nhap he so a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Nhap he so b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Nhap he so c: ");
        int c = int.Parse(Console.ReadLine());

        PhuongTrinhBac2 pt2 = new PhuongTrinhBac2(a, b, c);
        pt2.HienThi();
        pt2.TinhNghiem();

        Console.ReadLine();
    }
}
