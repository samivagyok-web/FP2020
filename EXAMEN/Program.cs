using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[6] { 1, 2, 3, 4, 5, 6 };
           // Console.WriteLine(Problema1(219037));     //  ok
           // Problema2(arr, 6);                    // KINDA OK
           // Problema3();                          //  OK
          // Problema4();                            // OK
         //   Problema5(193);
            Problema6(6);
          //  Problema7();                      //  OK
        }

        private static double Problema1(int n)
        {
            double numLen = Math.Floor(Math.Log10(n)) + 1;
            return (Math.Pow(10, numLen) - 1) - n;
        }

        private static void Problema2(int[] arr, int t)
        {
            bool gotIt = false;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j <arr.Length; j++)
                {
                    if (i != j && arr[i] != arr[j] && arr[i] + arr[j] == t)
                    {
                        Console.WriteLine($"{arr[i]} si {arr[j]}");
                        gotIt = true;
                        break;
                    }    
                }
                if (gotIt)
                    break;
            }
        }
        private static void Problema3()
        {
            int n;
            int a = int.MinValue;
            int b = int.MinValue;
            int c = int.MinValue;
            do
            {
                Console.Write("n = ");
                n = int.Parse(Console.ReadLine());

                if ((n > a || n > b || n > c) && n != 0)
                {
                    if (a <= b && a <= c)
                        a = n;
                    else if (b <= a && b <= c)
                        b = n;
                    else if (c <= a && c <= b)
                        c = n;
                }

            } while (n != 0);
            Console.WriteLine($"{a} {b} {c}");
        }

        private static void Problema4()
        {
            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            int[,] matrice = new int[n, n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = n - 1; j > n - 1 - i; j--)
                {
                    if (prob4prim(matrice[i, j]))
                    {
                        sum = sum + matrice[i, j];
                    }
                }
            }

        }

        private static bool prob4prim(int n)
        {
            if (n % 2 == 0)
                return false;
            else
            {
                if (n <= 5)
                    return true;
                else
                {
                    if ((n - 1) % 6 != 0 && (n + 1) % 6 != 0)
                    {
                        return false;
                    }
                    else
                    {

                        for (int i = 3; i * i <= n; i++)
                        {
                            if (n % i == 0)
                                return false;
                        }
                    }
                }
            }
            return true;
        }

        private static bool Problema5(int cm)
        {
            // L = 2*pi*R + 1 --> L = 2*pi(R + (1/2pi)) --> dist(ec, p) = R + 1/(2pi) - R = 1/(2pi) = 0.15m = 15cm

            if (cm <= 15)
                return true;
            else
                return false;
            
        }

        private static void Problema6(int n)
        {
            int a;
            Console.Write("a = ");
            a = int.Parse(Console.ReadLine());

            for (int i = n; i > 0; i--)
            {
                for (int j = 1; j <= a; j++)
                {
                    for (int z = a; z > 0; z--)
                    {
                        Console.Write($"{j} ");
                        i--;
                        if (n == 0)
                            break;
                    }
                }
            }
        }

        private static void Problema7()
        {
            Console.Write("Numarul: ");
            int a = int.Parse(Console.ReadLine());
        }

        private static int prob7recursiv(int a)
        {
            if (a == 0)
                return 10;

            if (a%2 == 0 && (a%10)<prob7recursiv(a/10))
            {
                return a % 10;
            }
            return prob7recursiv(a / 10);
        }
    }
}
