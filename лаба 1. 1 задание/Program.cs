using System;

namespace лаба_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Составить программу нахождения произведения двух наименьших из трех различных чисел
            int a, b, c, max;
            Console.WriteLine("Введите a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите b");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите c");
            b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                max = a;
            }
            else
            {
                max = b; ;
            }
            if (c>max)
            {
                max=c;
            }
            if (a == b || b ==c || a==c)
            {
                Console.WriteLine("Были введены одинаковые значения! Вычисление произведения не возможно");
            }
            else
            {
                Console.WriteLine("Произведениe двух наименьших из трех чисел = " + a * b * c / max);
            }

        }
    }
}
