using Bai7;

class Program
{
    static void Main(string[] args)
    {
        // Dung constructor khong tham so
        TamGiac tg1 = new TamGiac();
        Console.WriteLine("Thong tin tam giac 1 (constructor mac dinh):");
        tg1.HienThi();

        // Dung constructor co tham so
        TamGiac tg2 = new TamGiac(3, 4, 5);
        Console.WriteLine("Thong tin tam giac 2 (3,4,5):");
        tg2.HienThi();

        Console.ReadLine();
    }
}
