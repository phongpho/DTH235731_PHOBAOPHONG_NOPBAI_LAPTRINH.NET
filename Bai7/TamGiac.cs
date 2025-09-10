using System;

namespace Bai7
{
    class TamGiac
    {
        private int _canh1;
        private int _canh2;
        private int _canh3;
        private float _dienTich;
        private int _chuVi;
        private string _loai;

        // Properties
        public int Canh1
        {
            get { return _canh1; }
            set { _canh1 = value; }
        }

        public int Canh2
        {
            get { return _canh2; }
            set { _canh2 = value; }
        }

        public int Canh3
        {
            get { return _canh3; }
            set { _canh3 = value; }
        }

        public int ChuVi
        {
            get { return _chuVi; }
        }

        public float DienTich
        {
            get { return _dienTich; }
        }

        public string Loai
        {
            get { return _loai; }
        }

        // Constructor khong tham so
        public TamGiac()
        {
            Canh1 = 2;
            Canh2 = 3;
            Canh3 = -5; 
            TinhToan();
        }

        // Constructor co 3 tham so
        public TamGiac(int a, int b, int c)
        {
            Canh1 = a;
            Canh2 = b;
            Canh3 = c;
            TinhToan();
        }

        // Kiem tra tam giac hop le
        private bool LaTamGiac()
        {
            return (Canh1 + Canh2 > Canh3 &&
                    Canh1 + Canh3 > Canh2 &&
                    Canh2 + Canh3 > Canh1 &&
                    Canh1 > 0 && Canh2 > 0 && Canh3 > 0);
        }

        // Tinh chu vi, dien tich, loai tam giac
        private void TinhToan()
        {
            if (LaTamGiac())
            {
                _chuVi = Canh1 + Canh2 + Canh3;
                float p = (float)_chuVi / 2;
                _dienTich = (float)Math.Sqrt(p * (p - Canh1) * (p - Canh2) * (p - Canh3));
                _loai = XacDinhLoai();
            }
            else
            {
                _chuVi = 0;
                _dienTich = 0;
                _loai = "Khong phai tam giac";
            }
        }

        // Xac dinh loai tam giac
        private string XacDinhLoai()
        {
            if (Canh1 == Canh2 && Canh2 == Canh3) return "Tam giac deu";
            else if (Canh1 == Canh2 || Canh1 == Canh3 || Canh2 == Canh3) return "Tam giac can";
            else return "Tam giac thuong";
        }

        // Hien thi thong tin
        public void HienThi()
        {
            Console.WriteLine("Canh1: {0}, Canh2: {1}, Canh3: {2}", Canh1, Canh2, Canh3);
            Console.WriteLine("Chu vi: {0}", ChuVi);
            Console.WriteLine("Dien tich: {0}", DienTich);
            Console.WriteLine("Loai: {0}", Loai);
            Console.WriteLine("------------------------------");
        }
    }
}