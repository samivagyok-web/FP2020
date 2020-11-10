using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1610_cus
{
    class Program
    {
        static Random rnd = new Random();



        // se da un vector de dimenziune n cu v[i] = [1,20]
        // cata apa poate retine vectorul?

        // ex. 1 4 5 3 2 4 3

        //  X
        // XX00X
        // XXX0XX
        // XXXXXX
        //XXXXXXX

        // NULLAK A VIZEK

        static void Main(string[] args)
        {
            int[] v = new int[] { 1, 6, 3, 1, 1, 2, 5, 1, 1, 4, 2};
            int n = v.Length;
            int nrapa = 0;

            int max = v[0];
            for (int i = 0; i < n; i++)
            {
                if (max < v[i])
                {
                    max = v[i];
                }
            }

            int[,] m = new int[max, n];
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < v[j]; j++)
                {
                    m[i, j] = 1;
                }
            }



            for (int i = 0; i < max; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine(m[i, j] + " ");
                }
                Console.WriteLine();
            }


        }
    }
}
