using System;

namespace Задание_2._Лаба_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[] { 2, -16, 0, 4, -1 };
            int max_elem1 = 0, maximum = 0, minimum = 0, min_elem1 = 100, Indexmax1 = 0, Indexmax2 = 0;
            for (int j = 0; j < A.Length; j++)
            {
                if (A[j] > max_elem1)
                {
                    max_elem1 = A[j];
                    maximum = A[j];
                    Indexmax1 = j;
                }

                if (A[j] < min_elem1)
                {
                    min_elem1 = A[j];
                    minimum = A[j];
                    Indexmax2 = j;
                }
            }
            Console.WriteLine("Максимальный элемент 1 = " + maximum);
            Console.WriteLine("Минимальный элемент 1 = " + minimum);
            max_elem1 = -100;
            for (int j = 0; j < A.Length; j++)
            {
                if (j == Indexmax1)
                {
                    continue;
                }

                else if (A[j] > max_elem1)
                {
                    max_elem1 = A[j];
                    maximum = A[j];
                }
            }
            min_elem1 = 100;
            for (int j = 0; j < A.Length; j++)
            {
                if (j == Indexmax2)
                {
                    continue;
                }
                else if (A[j] < min_elem1)
                {
                    min_elem1 = A[j];
                    minimum = A[j];
                }
            }
            Console.WriteLine("Максимальный элемент 2 = " + maximum);
            Console.WriteLine("Минимальный элемент 2 = " + minimum);
//
        }
    }
}
