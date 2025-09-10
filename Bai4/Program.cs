using System.Text;

namespace Bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            MangSoNguyen msn = new MangSoNguyen();
            int n;
            Console.Write("Nhap vao so phan tu trong mang: ");
            n = msn.NhapSoDuong();
            int[] a = new int[n];
            msn.NhapMang(a);
            Console.WriteLine("Mang vua nhap: ");
            msn.InMang(a);
            Console.WriteLine("\nSo lon nhat trong mang: ", msn.TimMax(a));
            Console.WriteLine("\nSo be nhat trong mang: ", msn.TimMin(a));
            Console.WriteLine("\nTong cac phan tu trong mang: ", msn.TinhTong(a));
            Console.WriteLine("\nMang sau khi sap xep tang dan: ");
            msn.SapXepTangDan(a);
            msn.InMang(a);
            Console.ReadLine();
        }
    }
}