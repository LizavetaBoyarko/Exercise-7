using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_7._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину ребра куба:");
            Console.Write("l=");
            int l = Convert.ToInt32(Console.ReadLine());
            double S, V;
            CalcParam(l, out S, out V);
            Console.WriteLine(S);
            Console.WriteLine(V);
            Console.ReadKey();
        }
        static void CalcParam(int l, out double S, out double V)
        {
            S = 6 * (Math.Pow(l, 2));
            V = Math.Pow(l, 3);
        }
    }
}
