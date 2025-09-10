using Bai5;

class Program
{
    public static void Main()
    {
        Console.Write("Nhap so luong sinh vien: ");
        int n = int.Parse(Console.ReadLine());

        Student[] arrStudent = new Student[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\n--- Nhap thong tin sinh vien thu {0} ---", i + 1);
            arrStudent[i] = new Student();
            arrStudent[i].Nhap();
        }

        Console.WriteLine("\nDanh sach sinh vien:");
        Console.WriteLine("{0,-15}{1,-10}{2,-10}{3,-10}{4,-10}", "Ho ten", "Tuoi", "Toan", "Van", "DTB");

        for (int i = 0; i < n; i++)
        {
            arrStudent[i].Xuat();
        }

        Console.ReadLine();
    }
}
