using System;

namespace лаба_1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int size, p, number = 0, symbols;
            string TextLine = Console.ReadLine();
            for (int j = 0; j < TextLine.Length; j++)
            {
                //symbols++;
                if ((TextLine[j] >= '0') & (TextLine[j] <= '9'))
                {
                    number++;
                }
            }
            size = TextLine.Length;
            p = size - number;
            Console.WriteLine("Доля в % букв в предложении = " + ((100 * p) / size));

        }
    }
}
