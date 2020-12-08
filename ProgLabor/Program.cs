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
            // another 5 random: 50 43 28 46 26 3

            // tableInmultire();

            // ariaPerimetru();

            // numerePrime();

            // numerePrimeCuSumaM();

            // nrCifre();

            int[] hardCodedArr = new int[] { 4, 7, 12, 14, 21, 23, 30, 32, 45 };
            // arrayPar(hardCodedArr2);

            // palindrom();

            // medieAritmPare(hardCodedArr);

            //   impartirePrimitiva();

            // ijkPutere();

            // numarPerfect();         // PRIMELE N NUMERE PERFECTE

            conversie();
        }

        private static void conversie()
        {
            int n = (int)getNumber();
            int p = (int)getNumber();
            int q = (int)getNumber();

            // p, q < 10

            int hatvany = 1;
            int ujSzam = 0;
            while (n > 0)     // din baza p -> baza 10
            {
                int utolsoSzamjegy = n % 10;
                n = n / 10;
                ujSzam = ujSzam + utolsoSzamjegy * hatvany;
                hatvany = hatvany * p;
            }
            Console.WriteLine(ujSzam);

            hatvany = 1;
            int vegsoSzam = 0;

            while (ujSzam != 0) // din baza 10 -> baza q
            {
                int utolsoSzamjegy = ujSzam % q;
                ujSzam = ujSzam / q;
                vegsoSzam = vegsoSzam + utolsoSzamjegy * hatvany;
                hatvany = hatvany * 10;
            }
            Console.WriteLine(vegsoSzam);
        }

        private static void numarPerfect()
        {
            int n = (int)getNumber();
            int counter = 0;
            int numar = 2;

            while (counter != n)
            {
                int divizor = 1;
                for (int i = 2; i <= Math.Sqrt(numar); i++)
                {
                    if (numar % i == 0)
                    {
                        divizor = divizor + i;

                        if (numar != numar/i)
                        {
                            divizor = divizor + numar / i;
                        }
                    }
                }

                if (divizor == numar)
                {
                    Console.WriteLine(numar);
                    counter++;
                }

                numar++;
            }
        }

        private static void ijkPutere()
        {
            Console.Write("i: ");
            int i = (int)getNumber();

            Console.Write("j: ");
            int j = (int)getNumber();

            Console.Write("k: ");
            double k = getNumber();

            Console.WriteLine($"{i} pe puterea {j} impartita cu {k} e egal cu {Math.Pow(i, j)/k}");
        }

        private static void impartirePrimitiva()
        {
            // forma e x / y
            Console.Write("x: ");
            int x = (int)getNumber();
            int copyx = x;

            Console.Write("y: ");
            int y = (int)getNumber();
           
            int counter = 0;
            while (x >= y)
            {
                x = x - y;
                counter++;
            }
            Console.WriteLine($"Partea intreaga {counter}");
            Console.WriteLine($"Restul e {copyx-(y*counter)}");
        }

        private static void medieAritmPare(int[] hardCodedArr)
        {
            int n = hardCodedArr.Length;
            int sum = 0;
            double counter = 0;

            for (int i = 0; i < n; i++)
            {
                if (hardCodedArr[i] % 2 == 0)
                {
                    sum = sum + hardCodedArr[i];
                    counter++;
                }
            }

            Console.WriteLine($"Media aritmetica a elementelor pare e {sum/counter}");
        }

        private static void palindrom()
        {
            int a = (int)getNumber();
            double lungime = (int)(Math.Floor(Math.Log10(a)) + 1);
            int sum = 0;
            int copya = a;

            for (int i = 0; i < lungime; i++)
            {
                int ultimCifra = a % 10;
                sum = sum + (ultimCifra * (int)(Math.Pow(10, lungime - i - 1)));
                a = a / 10;
            }
            Console.WriteLine($"{sum} {copya}");
            if (sum == copya)
                Console.WriteLine("Palindrom");
            else
                Console.WriteLine("Nu-i palindrom");

        }

        private static void arrayPar(int[] hardCodedArr)
        {
            bool par = true;
            int n = hardCodedArr.Length;

            for (int i = 0; i < n; i++)
            {
                if (hardCodedArr[i] % 2 != 0)
                {
                    par = false;
                    break;
                }
            }

            if (!par)
                Console.WriteLine("Exista si numar impar");
            else
                Console.WriteLine("Doar par");
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
