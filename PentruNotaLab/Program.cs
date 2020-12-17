using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PentruNotaLab
{
    class Program
    {
        // Matrice magica - O matrice patrata este magica daca suma diagonalelor, liniilor, si coloanelor este egala.

        static void Main(string[] args)
        {
            TextReader data = new StreamReader(@"..\..\data.in");
            string buffer = data.ReadLine();

            int n = int.Parse(buffer.Split(' ')[0]);
            int m = int.Parse(buffer.Split(' ')[1]);
            int[,] a = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                buffer = data.ReadLine();
                string[] local = buffer.Split(' ');

                for (int j = 0; j < m; j++)
                {
                    a[i, j] = int.Parse(local[j]);
                }
            }
            data.Close();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{a[i,j]} ");
                }
                Console.WriteLine();
            }

            int sum = 0;    
            int sumB = 0;
            bool magic = true;

            for (int i = 0; i < n; i++)
            {
                sum = sum + a[i, i];    // suma diagonalei principale
                sumB = sumB + a[n - 1 - i, i];
            }

            if (sum == sumB)
                magic = true;
            else
                magic = false;

            if (magic)
            {
                int i = 0;
                int j = 0;

                while (magic && i < n)
                {
                    sumB = 0;
                    for (int t = 0; t < m; t++)
                    {
                        sumB = sumB + a[i, t];      // fiindca daca ajungem aici sum = sumB, refolosim sumB pentru operatiile pe linii si coloane
                    }

                    if (sumB != sum)
                        magic = false;

                    i++;
                }

                while (magic && j < m)
                {
                    sumB = 0;
                    for (int t = 0; t < n; t++)
                    {
                        sumB = sumB + a[t, j];
                    }

                    if (sumB != sum)
                        magic = false;

                    j++;
                }

                if (magic)
                    Console.WriteLine("Matrice magica!");
                else
                    Console.WriteLine("Nu e o matrice magica :(");
            }
            else
            {
                Console.WriteLine("Nu e o matrice magica :(");
            }
        }
    }
}
