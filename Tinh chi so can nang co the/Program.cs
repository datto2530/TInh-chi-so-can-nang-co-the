using System;

namespace baitap
{
    class Program
    {
        static void Main(string[] args)
        {
            double chieuCao;
            double canNang;
            Console.WriteLine("Nhap chieu cao:");
            chieuCao = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap can nang cua ban:");
            canNang = float.Parse(Console.ReadLine());
            double bmi = canNang / Math.Pow(chieuCao, 2);
            bmi = Math.Round(bmi, 1);
            Console.WriteLine("Chi so BMI cua ban la:" + bmi);
            if (bmi < 18)
                Console.WriteLine("Thieu can");
            else if (bmi < 25.0)
                Console.WriteLine("Binh thuong");
            else if (bmi < 30.0)
                Console.WriteLine("Thua can");
            else
                Console.WriteLine("Beo phi");
            Console.ReadKey();
        }
    }
}