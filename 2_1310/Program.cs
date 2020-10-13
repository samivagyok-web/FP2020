using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1310
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduceti un numar sub 999: ");
            int n = int.Parse(Console.ReadLine());

            double lenghtOfInt = Math.Floor(Math.Log10(n)) + 1;

            switch (lenghtOfInt)
            {
                case 1:
                    Console.Write(n);
                    break;
                case 2:
                    Console.Write(n % 10);
                    Console.Write(n / 10);
                    break;
                case 3:
                    Console.Write(n % 10);
                    Console.Write((n / 10) % 10);
                    Console.Write(n / 100);
                    break;
                default:
                    Console.WriteLine("Nu ai dat numar sub 999.");
                    break;
            }




        }
    }
}
