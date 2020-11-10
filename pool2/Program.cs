using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool2
{
    class Program
    {
        static void Main(string[] args)
        {
            // did: 1 2 3 4 5 6 7 8 9 10 11 12

            //  pareNegPozZero();
            // numberSum();
            // numberPos();
            // secvCrescator();
            // minMax();

            //  int x = 0; int y = 1; int z = 1; int counter = 2; int n = 7;
            //  fiboRecursiv(x, y, z, counter, n);

            // inversSecv();
            // ordinCresc();
            // monotonSecv();
            // consecutivEgal();
            // grupConsDifZero();

        }

        private static void grupConsDifZero()
        {
            Console.Write("Primul element: ");
            int x = (int)getNumber();
            Console.Write("Cate elemente sa aiba sirul: ");
            int n = (int)getNumber();
            int grupCounter = 0;
            int helper = 0;

            for (int i = 0; i < n+1; i++)
            {
                Console.Write($"{x} ");
                if (x != 0)
                    helper++;

                if (x == 0 && helper > 0)
                {
                    grupCounter++;
                    helper = 0;
                }

                if (x % 2 == 0)
                    x = x / 2;
                else
                    x = 3 * x + 1;

                if (i == n-1 && x != 0)
                    grupCounter++;
                      
            }
            Console.WriteLine("");
            Console.WriteLine($"Sunt in total {grupCounter} grupuri.");

        }

        private static void consecutivEgal()
        {
            Console.Write("Primul element: ");
            double x = (int)getNumber();
            double a = int.MaxValue;
            double b = int.MinValue;
            int consecutivCounter = 0;
            int maxCons = 0;

            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                    a = x;
                else
                    b = x;

                if (a == b)
                {
                    consecutivCounter++;
                    if (consecutivCounter > maxCons)
                    {
                        maxCons = consecutivCounter;
                    }
                }
                else
                {
                    consecutivCounter = 0;
                }
                Console.Write($"{x} ");
                x = Math.Pow(-1, i) * Math.Round((x / 3) * 2);
            }

            Console.WriteLine($"Cel mai lung cifra consecutive: {maxCons+1}");

        }

        private static void monotonSecv()
        {
            Console.Write("Primul element: ");
            int x = (int)getNumber();
            bool valid = true;
            bool cresc = true;
            int a = int.MinValue;
            int b = int.MinValue;

            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                    a = x;
                if (i == 1)
                    b = x;

                if (x % 2 == 0)
                    x = x / 2;
                else
                    x = 3 * x + 1;


                if (a < b)
                    cresc = true;
                else
                    cresc = false;

            }

            for (int i = 0; i < 10; i++)
            {
                if (cresc)
                {
                    if (i % 2 == 0)
                    {
                        a = x;
                        if (a < b)
                        {
                            valid = false;
                        }
                    }
                    else
                    {
                        b = x;
                        if (b < a)
                        {
                            valid = false;
                        }
                    }

                    if (x % 2 == 0)
                        x = x / 2;
                    else
                        x = 3 * x + 1;
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        a = x;
                        if (a > b)
                        {
                            valid = false;
                        }
                    }
                    else
                    {
                        b = x;
                        if (b > a)
                        {
                            valid = false;
                        }
                    }

                    if (x % 2 == 0)
                        x = x / 2;
                    else
                        x = 3 * x + 1;
                }
            }

            Console.WriteLine($"Monoton: {valid}");
        }

        private static void ordinCresc()
        {
            Console.Write("Primul element: ");
            int x = (int)getNumber();
            bool valid = true;
            int a = int.MinValue;
            int b = int.MinValue;

            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    a = x;
                    if (a < b)
                    {
                        valid = false;
                    }
                }
                else
                {
                    b = x;
                    if (b < a)
                    {
                        valid = false;
                    }
                }

                if (x % 2 == 0)
                    x = x / 2;
                else
                    x = 3 * x + 1;
            }

            Console.WriteLine($"Ordin crecscator: {valid}");
        }



        private static void inversSecv()
        {
            Console.Write("Primul element: ");
            double x = getNumber();
            double invers = 0;
            double sumaInv = 0;

            for (int i = 0; i < 10; i++)
            {
                invers = 1 / x;
                sumaInv = sumaInv + invers;

                if (x % 2 == 0)
                    x = x / 2;
                else
                    x = 3 * x + 1;
            }
            Console.WriteLine($"Suma inverselor este: {sumaInv}");
        }

        private static int fiboRecursiv(int a, int b, int c, int counter, int n)
        {
            if (counter == n)
            {
                Console.WriteLine(c);
                return c;
            }

            if (n == 0)
                return a;
            if (n == 1)
                return b;

            counter++;
            c = a + b;
            a = b;
            b = c;

            return fiboRecursiv(a, b, c, counter, n);
        }

        private static void numberSum()
        {
            Console.Write("Primele cate numere vreti: ");
            int n = (int)getNumber();
            int sum = 0;

            for (int i = 1; i <= n; i++)
            {
                sum = sum + i;
            }

            Console.WriteLine($"Suma primelor n numere e: {sum}");
        }

        private static void pareNegPozZero()
        {
            Console.Write("Primul element: ");
            double x = (int)getNumber();
            int par = 0, pozitiv = 0, negativ = 0, zero = 0;


            while (Math.Abs(x) != 1)
            {
                if (x % 2 == 0)
                    x = x / 2;
                else
                    x = -3 * x + 1;

                Console.Write($"{x} ");

                if (x % 2 == 0)
                    par++;
                if (x > 0)
                    pozitiv++;
                if (x < 0)
                    negativ++;
                if (x == 0)
                    zero++;
            }
            Console.WriteLine("");
            Console.WriteLine($"par: {par}, pozitiv: {pozitiv}, negativ: {negativ}, zero: {zero}");
        }

        private static double nrPare(double a)
        {
            int sum = 0;
            if (a % 2 == 0)
                sum++;

            return sum;
        }

        public static double getNumber()
        {
            string line;
            bool valid;
            double numar = 0;
            do
            {
                valid = true;
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

        private static void numberPos()
        {
            Console.Write("Primul element: ");
            int x = (int)getNumber();
            Console.Write("Care element cautati: ");
            int a = (int)getNumber();
            int pozitie = 0;
            int counter = 0;
            int pozCounter = 0;

            while (Math.Abs(x) != 1)
            {
                if (a == x)
                {
                    Console.WriteLine($"{x} se afla pe pozitie {pozitie}");
                    counter++;
                }

                if (a == pozitie)
                    pozCounter++;

                if (x % 2 == 0)
                    x = x / 2;
                else
                    x = 3 * x + 1;
                pozitie++;
            }
            Console.WriteLine("");

            if (counter == 0)
                Console.WriteLine("-1");

            Console.WriteLine($"{pozCounter} numere sunt egale cu pozitia lor");
        }

        private static void secvCrescator()
        {
            Console.Write("Primul element din secventa: ");
            int x = (int)getNumber();
            int loopCounter = 0;
           // int creste = 0;

            while (x < 500)
            {
                x = x + 17;



                Console.WriteLine(x);
                loopCounter++;
            }
        }

        private static void minMax()
        {
            Console.Write("Primul element: ");
            int x = (int)getNumber();
            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 0; i < 10; i++)
            {
                if (x % 2 == 0)
                    x = x / 2;
                else
                    x = 3 * x + 1;

                if (x > max)
                    max = x;
                if (x < min)
                    min = x;


                Console.Write($"{x} ");
            }

            Console.WriteLine("");
            Console.WriteLine($"min: {min}, max: {max}");
        }

        private static void fibo()
        {
            int a = 0;
            int b = 1;
            int c = 0;

            Console.Write("Catelea element vreti din fibo: ");
            int n = (int)getNumber();

            for (int i = 1; i < n/3+2; i++)
            {
                c = a + b;
                Console.Write($"{a}, {b}, {c}, ");
                a = b + c;
                b = c + a;

            }
        }


    }
}
