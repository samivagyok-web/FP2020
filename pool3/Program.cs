using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] hardCodedArr = new int[] { 39, 42, 24, 88, 62, 38, 100, 29 };

            // sumaElement();
            // kSearch(hardCodedArr);
            // minMaxPos(hardCodedArr);         // GOTTA COME BACK HERE
            minMax(hardCodedArr);
        }

        private static void minMax(int[] hardCodedArr)
        {
            int max = int.MinValue;
            int min = int.MaxValue;

            for (int i = 0; i < hardCodedArr.Length; i++)
            {
                if (max < hardCodedArr[i])
                    max = hardCodedArr[i];
                if (min > hardCodedArr[i])
                    min = hardCodedArr[i];
            }
        }

        private static void minMaxPos(int[] hardCodedArr)
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            int maxPos = 0;
            int minPos = 0;

            for (int i = 0; i < hardCodedArr.Length; i++)
            {
                if (max < hardCodedArr[i])
                {
                    max = hardCodedArr[i];
                    maxPos = i;
                }

                if (min > hardCodedArr[i])
                {
                    min = hardCodedArr[i];
                    minPos = i;
                }
            }
            Console.WriteLine(minPos + " " + maxPos);
        }

        private static void kSearch(int[] hardCodedArr)
        {
            Console.Write("Numarul pe care cautati: ");
            int k = (int)getNumber();
            int sum = 0;

            for (int i = 0; i < hardCodedArr.Length; i++)
            {
                if (hardCodedArr[i] == k)
                {
                    Console.WriteLine($"{k} se afla pe pozitia {i}");
                    sum++;
                    break;
                }
            }

            if (sum == 0)
                Console.WriteLine("-1");
        }

        private static void sumaElement()
        {
            Console.Write("Cate numere sa aiba arrayul: ");
            int n = (int)getNumber();
            int[] arr = new int[n];
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Introduceti {i+1}. numar: ");
                int k = (int)getNumber();
                arr[i] = k;
                sum = sum + k;
            }

            Console.WriteLine($"Suma numerelor din array: {sum}");
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
    }
}
