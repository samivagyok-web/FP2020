using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Globalization;

namespace _6_1011
{
    class Program
    {
        static void Main(string[] args)
        {
            // countPrimes();

            dateDiff();
        }

        private static void dateDiff()
        {
            DateTime azi = DateTime.Now;
            Console.WriteLine(azi);

            CultureInfo.CurrentCulture = new CultureInfo("en-US");
            Console.WriteLine(azi.ToString("d yyyy MMMM dd, HH:mm:ss"));

            DateTime d = new DateTime(2020, 3, 13);
            Console.WriteLine( azi.Subtract(d).Days);

        }

        private static void countPrimes()
        {
            int a, b;
            a = int.Parse( Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            Stopwatch sw = new Stopwatch();
            sw.Start();
            int primCounter = 0;
            int negyzCounter = 0;
            for (int nr = a; nr <= b; nr++)
            {
                if (nr.isPrime())
                {
                    primCounter++;
                }

                if (nr.isNegyzet())
                {
                    negyzCounter++;
                }
            }
            sw.Stop();
            Console.WriteLine($"A trecut {sw.ElapsedMilliseconds}");
            Console.WriteLine(primCounter + " " + negyzCounter);
        }
    }
}
