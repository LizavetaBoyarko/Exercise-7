using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длины сторон первого треугольника:");
            Console.Write("a=");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b=");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c=");
            int c = Convert.ToInt32(Console.ReadLine());
            double P, S;
            CalcParam (a, b, c, out P, out S);
            Console.Write(S);
            Console.ReadLine();
            double S1 = S;
            Console.WriteLine("Введите длины сторон второго треугольника:");
            Console.Write("a=");
            int a1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("b=");
            int b1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("c=");
            int c1= Convert.ToInt32(Console.ReadLine());
            CalcParam(a1, b1, c1, out P, out S);
            Console.WriteLine(S);
            double S2 = S;
            if (S1 > S2)
            {
                Console.Write("Площадь первого треугольника больше");
            }
            else
            {
                Console.Write("Площадь второго треугольника больше");
            }
            Console.ReadKey();
        }
        static void CalcParam(int a, int b, int c, out double P, out double S)
        {
            P = (a + b + c) / 2;
            S = Math.Sqrt(P * (P - a) * (P - b) * (P - c));
        }

    }
}
