using System;

namespace Bai8
{
    class PhuongTrinhBac2
    {
        private int _soa;
        private int _sob;
        private int _soc;

        // Properties
        public int Soa
        {
            get { return _soa; }
            set { _soa = value; }
        }

        public int Sob
        {
            get { return _sob; }
            set { _sob = value; }
        }

        public int Soc
        {
            get { return _soc; }
            set { _soc = value; }
        }

        // Constructor khong tham so
        public PhuongTrinhBac2()
        {
            Soa = 0;
            Sob = 0;
            Soc = 0;
        }

        // Constructor co tham so
        public PhuongTrinhBac2(int a, int b, int c)
        {
            Soa = a;
            Sob = b;
            Soc = c;
        }

        // Tinh nghiem
        public void TinhNghiem()
        {
            if (Soa == 0)
            {
                if (Sob == 0)
                {
                    if (Soc == 0)
                        Console.WriteLine("Phuong trinh vo so nghiem");
                    else
                        Console.WriteLine("Phuong trinh vo nghiem");
                }
                else
                {
                    double x = -(double)Soc / Sob;
                    Console.WriteLine("Phuong trinh bac nhat, nghiem x = {0}", x);
                }
            }
            else
            {
                double delta = Sob * Sob - 4 * Soa * Soc;
                if (delta < 0)
                {
                    Console.WriteLine("Phuong trinh vo nghiem");
                }
                else if (delta == 0)
                {
                    double x = -(double)Sob / (2 * Soa);
                    Console.WriteLine("Phuong trinh co nghiem kep x1 = x2 = {0}", x);
                }
                else
                {
                    double x1 = (-Sob + Math.Sqrt(delta)) / (2 * Soa);
                    double x2 = (-Sob - Math.Sqrt(delta)) / (2 * Soa);
                    Console.WriteLine("Phuong trinh co 2 nghiem phan biet: x1 = {0}, x2 = {1}", x1, x2);
                }
            }
        }

        // Hien thi phuong trinh
        public void HienThi()
        {
            Console.WriteLine($"Phuong trinh: {Soa}x^2 + {Sob}x + {Soc} = 0");
        }
    }
}