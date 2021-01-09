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
            // POOL 2 DONE

            //   Problema1si2();
            //   Problema3();
            //   Problema4si5();
            //   Problema6();
            //  Problema7();
            //  Problema8();
            //  Problema9();
            // Problema10();
            // Problema11();
            // Problema12();
            // Problema13();
            // Problema14();
            // Problema15();
            // Problema16();
            // Problema17();
        }

        private static void Problema16()
        {
            Console.Write("Primul num: ");
            int x = (int)getNumber();

            Console.Write("Al doilea num: ");
            int y = (int)getNumber();

            Console.Write("Cate numere: ");
            int n = (int)getNumber();

            bool cresc = true;
            if (x <= y)
                cresc = true;
            else
                cresc = false;

            bool correct = false;
            int a = 0;
            while (true)
            {
                a = int.Parse(Console.ReadLine());

                if (a >= y)
                    y = a;
                else
                {
                    y = a;
                    while (n != 0)
                    {
                        a = int.Parse(Console.ReadLine());

                        if (a <= y)
                            y = a;
                        else
                            break;

                        n--;
                    }

                    if (n == 0)
                        correct = true;

                    break;
                }
                n--;
            }

            if (correct)
            {
                if (cresc && y >= x)
                {
                    Console.WriteLine("Secv e rotita bitonica");
                }
                else if (!cresc && y >= x)
                {
                    Console.WriteLine("Nu e secv bitonica dar se poate prin rotire");
                }
                else
                {
                    Console.WriteLine("nu e nimic");
                }
            }
            else
            {
                Console.WriteLine("nu e bine");
            }
        }

        private static void Problema15()
        {
            Console.Write("Primul num: ");
            int x = (int)getNumber();
            Console.Write("Cate numere: ");
            int n = (int)getNumber();

            bool correct = false;
            int a = 0;
            while (true)
            {
                a = int.Parse(Console.ReadLine());

                if (a >= x)
                    x = a;
                else
                {
                    x = a;
                    while (n != 0)
                    {
                        a = int.Parse(Console.ReadLine());

                        if (a <= x)
                            x = a;
                        else
                            break;
                        
                        n--;
                    }

                    if (n == 0)
                        correct = true;

                    break;
                }
                n--;
            }

            if (correct)
                Console.WriteLine("E bine");
            else
                Console.WriteLine("Nu e bine");
        }

        private static void Problema14()
        {
            Console.Write("Primul numar: ");
            int x = (int)getNumber();
            Console.Write("Al doilea numar: ");
            int y = (int)getNumber();

            Console.Write("Al treilea numar: ");
            int a = int.Parse(Console.ReadLine());

            if (a > y)
                Problema13();
            else
                monRotitDesc(x);
                
        }

        private static void monRotitDesc(int x)
        {
            int y = int.Parse(Console.ReadLine());
            int a = 0;
            bool desc = true;

            for (int i = 0; i < 5; i++)
            {
                a = int.Parse(Console.ReadLine());

                if (a < y)
                    y = a;
                else
                {
                    desc = false;
                    break;
                }
            }

            if (!desc)
                Console.WriteLine("Secv nu e mon desc rotita");
            else
            {
                if (x < y)
                    Console.WriteLine("Secv e mon desc rotit");
            }
        }

        private static void monRotitCresc(int x)
        {
            throw new NotImplementedException();
        }

        private static void Problema13()
        {
            Console.Write("Primul numar: ");
            int x = (int)getNumber();
            Console.Write("Al doilea numar: ");
            int y = (int)getNumber();
            bool cresc = true;

            if (x > y)
                cresc = false;

            bool correct = true;
            for (int i = 0; i < 10; i++)
            {
                int a = int.Parse(Console.ReadLine());

                if (a >= y)
                    y = a;
                else
                {
                    correct = false;
                    Console.WriteLine("Nu e o secventa crescatoara. ");
                    break;
                }
            }

            if (!correct)
                Console.WriteLine("Secventa nu e crescatoara.");
            else
            {
                if (x >= y)
                {
                    Console.WriteLine("Secventa e crescatoara rotita.");
                }
                else
                {
                    if (!cresc)
                        Console.WriteLine("Secventa nu este crescatoara.");
                    else
                        Console.WriteLine("Secventa este crescatoara, dar nu cresc. rotita.");
                }
            }

        }

        private static void Problema17()
        {
            int x = 5;
            int counter = 0;
            int maxincuib = 0;

            bool correct = true;
            for (int i = 0; i < 10; i++)
            {
                x = int.Parse(Console.ReadLine());

                if (x == 0)
                {
                    counter++;
                }
                else if (x == 1)
                {
                    counter--;
                }
                
                if (counter < 0)
                {
                    correct = false;
                    break;
                }
                if (x == 2)
                {
                    if (counter != 0)
                        correct = false;
                    break;
                }
                if (maxincuib < counter)
                    maxincuib = counter;
            }

            if (correct)
            {
                Console.WriteLine($"Corect - max incuibare: {maxincuib}");
            }
            else
            {
                Console.WriteLine($"Nu-i corect :(");
            }

        }

        private static void Problema12()
        {
            Console.Write("Primul element: ");
            int x = (int)getNumber();
            Console.Write("Cate elemente sa aiba sirul: ");
            int n = (int)getNumber();
            int grupCounter = 0;
            int helper = 0;

            for (int i = 0; i < n+1; i++)
            {
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

        private static void Problema10()
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

        private static void Problema9()
        {
            Console.Write("Primul element: ");
            int x = (int)getNumber();
            int primEm = x;

            while (primEm == x)
            {
                if (x % 2 == 0)
                    x = x / 2;
                else
                    x = 3 * x + 1;
            }
            if (x > primEm)
                monCrescCheck(x);
            else
                monDescCheck(x);
            
        }

        private static void monCrescCheck (int x)
        {
            bool cresc = true;
            int y = x;
            for (int i = 0; i < 10; i++)
            {
                if (x % 2 == 0)
                    x = x / 2;
                else
                    x = 3 * x + 1;

                if (y > x)
                    y = x;
                else
                {
                    Console.WriteLine("Nu-i monoton crescator. ");
                    cresc = false;
                    break;
                }
            }
            if (cresc)
                Console.WriteLine("Monoton crescator");
        }


        private static void monDescCheck(int x)
        {
            int y = x;
            bool desc = true;
            for (int i = 0; i < 10; i++)
            {
                if (x % 2 == 0)
                    x = x / 2;
                else
                    x = 3 * x + 1;

                if (y < x)
                    y = x;
                else
                {
                    Console.WriteLine("Nu-i monoton descrescator. ");
                    desc = false;
                    break;
                }
            }

            if (desc)
                Console.WriteLine("Monoton crescator");
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



        private static void Problema11()
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

        private static void Problema3()
        {
            Console.Write("Primele cate numere vreti: ");
            int n = (int)getNumber();
            int sum = 0;
            int produs = 1;

            for (int i = 1; i <= n; i++)
            {
                sum = sum + i;
                produs = produs * i;
            }

            Console.WriteLine($"Suma primelor n numere e: {sum}, produsul e {produs}");
        }

        private static void Problema1si2()
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
                else if (x < 0)
                    negativ++;
                else
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

        private static void Problema4si5()
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

        private static void Problema6()
        {
            Console.Write("Primul element din secventa: ");
            int x = (int)getNumber();
            int y = x;
            bool cresc = true;

            for (int i = 0; i < 10; i++)
            {
                x = x + 17;

                if (x >= y)
                    y = x;
                else
                {
                    Console.WriteLine("Secventa nu e crescatoare.");
                    cresc = false;
                    break;
                }

            }

            if (cresc)
                Console.WriteLine("Secventa e crescatoare.");
        }

        private static void Problema7()
        {
            Console.Write("Primul element: ");
            int x = (int)getNumber();
            int max = x;
            int min = x;

            for (int i = 0; i < 10; i++)
            {
                if (x % 2 == 0)
                    x = x / 2;
                else
                    x = 3 * x + 1;

                if (x > max)
                    max = x;
                else if (x < min)
                    min = x;

                Console.WriteLine(x);
            }

            Console.WriteLine("");
            Console.WriteLine($"min: {min}, max: {max}");
        }

        private static void Problema8()
        {
            int a = 0;
            int b = 1;
            int c = 0;

            Console.Write("Catelea element vreti din fibo: ");
            int n = (int)getNumber();

            if (n == 1)
                Console.WriteLine(a);
            else
            {
                if (n == 2)
                    Console.WriteLine(b);
                else
                {
                    for (int i = 0; i < n-1; i++)
                    {
                        a = b;
                        b = c;
                        c = a + b;
                    }
                }
                Console.Write($"{c} ");
            }
        }
    }
}
