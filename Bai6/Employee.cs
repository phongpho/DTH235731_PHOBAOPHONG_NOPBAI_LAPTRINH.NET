using System;

namespace Bai6
{
    class Employee
    {
        private int _id;
        private string _name;
        private int _yearOfBirth;
        private double _salaryLevel;
        private static double _basicSalary; // dung chung cho tat ca nhan vien

        // Constructor khong tham so
        public Employee()
        {
            Id = 0;
            Name = "";
            YearOfBirth = 0;
            SalaryLevel = 0;
        }

        // Properties
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int YearOfBirth
        {
            get { return _yearOfBirth; }
            set { _yearOfBirth = value; }
        }

        public double SalaryLevel
        {
            get { return _salaryLevel; }
            set { _salaryLevel = value; }
        }

        public static double BasicSalary
        {
            get { return _basicSalary; }
            set { _basicSalary = value; }
        }

        public double Income
        {
            get { return SalaryLevel * BasicSalary; }
        }

        // Phuong thuc nhap
        public void Input()
        {
            Console.Write("Nhap id: ");
            Id = int.Parse(Console.ReadLine());

            Console.Write("Nhap ten: ");
            Name = Console.ReadLine();

            Console.Write("Nhap nam sinh: ");
            YearOfBirth = int.Parse(Console.ReadLine());

            Console.Write("Nhap bac luong: ");
            SalaryLevel = double.Parse(Console.ReadLine());
        }

        // Phuong thuc xuat
        public void Display()
        {
            Console.WriteLine("{0,-10}{1,-20}{2,-15}{3,-15}{4,-15}",
                Id, Name, YearOfBirth, BasicSalary, Income);
        }
    }
}