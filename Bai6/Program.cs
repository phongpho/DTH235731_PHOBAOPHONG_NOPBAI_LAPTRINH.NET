using Bai6;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Nhap luong co ban: ");
        Employee.BasicSalary = double.Parse(Console.ReadLine());

        Console.Write("Nhap so luong nhan vien: ");
        int n = int.Parse(Console.ReadLine());

        Employee[] employees = new Employee[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("\nNhap thong tin nhan vien thu {0}:", i + 1);
            employees[i] = new Employee();
            employees[i].Input();
        }

        Console.WriteLine("\nDanh sach nhan vien:");
        Console.WriteLine("{0,-10}{1,-20}{2,-15}{3,-15}{4,-15}",
            "ID", "Ten", "Nam sinh", "Luong co ban", "Thu nhap");

        for (int i = 0; i < n; i++)
        {
            employees[i].Display();
        }

        Console.ReadLine();
    }
}
