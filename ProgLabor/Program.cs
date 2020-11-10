using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgLabor
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5 exercitii ales de random.org: 41 22 11 30 27

            // tableInmultire();

            // ariaPerimetru();

            // numerePrime();

            // numerePrimeCuSumaM();

            nrCifre();
        }

        private static void nrCifre()
        {
            int a = (int)getNumber();
            int counter = 0;
            while (a > 0)
            {
                a = a / 10;
                counter++;
            }
            Console.WriteLine($"Numarul contine {counter} cifr(a/e)");
        }

        private static void numerePrimeCuSumaM()
        {
            int n = (int)getNumber();
            int m = (int)getNumber();

            int sumaCifre = 0;
            int primCounter = 0;
            int s = 0;
            int i = 2;

            while (true)
            {
                for (int j = 2; j < (int)Math.Sqrt(i) + 1; j++)
                {
                    if (i % j == 0)
                    {
                        s++;
                    }
                }

                if (s == 0)
                {
                    int numar = i;
                    while (numar > 0)
                    {
                        int intreg = numar % 10;
                        sumaCifre += intreg;
                        numar /= 10;
                    }

                    if (sumaCifre >= m)
                    {
                        primCounter++;
                        Console.WriteLine(i);
                    }
                }

                i++;
                s = 0;
                sumaCifre = 0;

                if (primCounter == n)
                    break;
            }
        }

        private static void numerePrime()
        {
            int n = (int)getNumber();
            int primCounter = 0;
            int s = 0;
            int i = 2;

            while (true)
            {
                for (int j = 2; j < (int)Math.Sqrt(i) + 1; j++)
                {
                    if (i % j == 0)
                    {
                        s++;
                    }
                }

                if (s == 0)
                {
                    Console.WriteLine(i);
                    primCounter++;
                }

                i++;
                s = 0;

                if (primCounter == n)
                    break;
            }
            
        }

        private static void ariaPerimetru()
        {
            double a = getNumber();
            double b = getNumber();
            double c = getNumber();

            if (a + b > c && a + c > b && b + c > a)
            {
                Console.Write("Aria sau perimetrul doriti sa calculam? (aria = 0, perimetru = 1): ");
                string line = Console.ReadLine();

                switch (line)
                {
                    case "0":
                        double cos = (a * a + b * b - c * c) / (2 * a * b); // nu a avut rost sa folosesc Math.Pow
                        double sin = Math.Sqrt(1 - (cos * cos));
                        double h = sin * b;
                        Console.WriteLine($"Aria este: {(a * h) / 2}");
                        break;
                    case "1":
                        Console.WriteLine($"Perimetrul este: {a + b + c}");
                        break;
                    default:
                        Console.WriteLine("0 SAU 1");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Nu se poate forma triunghi");
            }
            
        }

        public static double getNumber()
        {
            string line;
            bool valid;
            double numar = 0;
            do
            {
                valid = true;
                Console.Write("Introduceti un numar: ");
                line = Console.ReadLine();
                try
                {
                    numar = double.Parse(line);
                }
                catch (Exception)
                {
                    valid = false;
                    Console.WriteLine("Please don't do 'funny' things");
                }
            } while (!valid);

            return numar;
        }

        private static void tableInmultire()
        {
            double numar = getNumber();

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{numar} * {i} = {numar*i}");
            }
        }
    }
}
