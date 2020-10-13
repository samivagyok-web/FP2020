using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1310
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti 3 numere care vor fi latura triunghului: ");
            double a, b, c;

            Console.Write("a: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("b: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("c: ");
            c = int.Parse(Console.ReadLine());

            if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                Console.WriteLine("SE POATE TRIUNGHI");
            }
            else Console.WriteLine("not good");
        }
    }
}
