using System;

namespace Bai5
{
    class Student
    {
        private string _hoTen;
        private int _tuoi;
        private double _diemToan;
        private double _diemVan;
        private double _dtb;

        // ham khoi tao khong tham so
        public Student()
        {
            HoTen = "";
            Tuoi = 0;
            DiemToan = 0;
            DiemVan = 0;
            Dtb = 0;
        }

        // Properties
        public string HoTen
        {
            get { return _hoTen; }
            set { _hoTen = value; }
        }

        public int Tuoi
        {
            get { return _tuoi; }
            set { _tuoi = value; }
        }

        public double DiemToan
        {
            get { return _diemToan; }
            set { _diemToan = value; }
        }

        public double DiemVan
        {
            get { return _diemVan; }
            set { _diemVan = value; }
        }

        public double Dtb
        {
            get { return Math.Round(((DiemToan + DiemVan) / 2), 2); }
            set { _dtb = value; }
        }

        // phuong thuc nhap du lieu
        public void Nhap()
        {
            Console.Write(" - Nhap ho ten: ");
            HoTen = Console.ReadLine();

            Console.Write(" - Nhap tuoi: ");
            Tuoi = int.Parse(Console.ReadLine());

            Console.Write(" - Nhap diem Toan: ");
            double temp = double.Parse(Console.ReadLine());
            while (temp < 0 || temp > 10)
            {
                Console.WriteLine(" !!! Diem phai trong khoang 0 -> 10");
                Console.Write(" - Nhap lai diem Toan: ");
                temp = double.Parse(Console.ReadLine());
            }
            DiemToan = temp;

            Console.Write(" - Nhap diem Van: ");
            temp = double.Parse(Console.ReadLine());
            while (temp < 0 || temp > 10)
            {
                Console.WriteLine(" !!! Diem phai trong khoang 0 -> 10");
                Console.Write(" - Nhap lai diem Van: ");
                temp = double.Parse(Console.ReadLine());
            }
            DiemVan = temp;
        }

        // phuong thuc xuat du lieu
        public void Xuat()
        {
            Console.WriteLine("{0,-15}{1,-10}{2,-10}{3,-10}{4,-10}", HoTen, Tuoi, DiemToan, DiemVan, Dtb);
        }
    }
}