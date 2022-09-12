using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicijalnoPonavljanje3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 7;
            double c = 12.5;
            double d = 16.7;

            a = (int)Convert.ToDouble(a);
            b = (int)Convert.ToDouble(b);
            Console.WriteLine("Prosječna vrijednost: " + (a + b + c + d) / 4);
            Console.ReadKey();
        }
    }
}
