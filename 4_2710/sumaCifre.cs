using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_2710
{
    class SumaCifre
    {
        static void Main(string[] args)
        {
            int n = GetIntFromConsole();

            // suma cifrelor numarului

            Console.WriteLine($"Suma cifrelor numarului {n} este {sumaCifrelor(n)} ");
            Console.WriteLine($"Suma cifrelor numarului {n} este {sumaCifrelorRecursiv(n)} ");
        }

        static int sumaCifrelorRecursiv(int n)
        {
            if (n == 0)
                return 0;
            else
                return n % 10 + sumaCifrelorRecursiv(n / 10);

            
        }

        static object sumaCifrelor(int k)
        {
            int sum = 0;
            while (k > 0)
            {
                int cifra = k % 10;
                sum += cifra;
                k /= 10;
            }
            return sum;
        }

        static int GetIntFromConsole()
        {
            int n = 0;
            bool flag;
            Console.Write("Introduceti un numar intreg: ");
            do
            {
                flag = true;
                try
                {
                    n = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    flag = false;
                    Console.WriteLine("Dont do funny things");
                }
            } while (!flag);
            return n;
        }
    }
}
