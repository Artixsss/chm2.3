using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chm2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b, eps, x;
            Console.WriteLine("Введите a, b, eps: ");
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            eps = float.Parse(Console.ReadLine());

            do
            {
                float c = (a + b) / 2;
                if (f(a) * f(c) < 0)
                    b = c;
                else
                    a = c;
            }
            while (Math.Abs(b - a) > eps);

            x = (a + b) / 2;
            Console.WriteLine("x = " + x.ToString("F6"));
            Console.ReadKey();
        }

        static float f(float x)
        {
            return (float)Math.Sin(2 * x) - (float)Math.Log(x);
        }
    }
 }

