using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace av_Matrice
{
    class Program
    {
        static void Main(string[] args)
        {
            TextReader data = new StreamReader("../../data.in");
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

            int[,] b = new int[2 * n - 1, 2 * m - 1];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    b[i * 2, j * 2] = a[i, j];
                }

                for (int t = 1; t < b.GetLength(1); t += 2)
                {
                    b[i * 2, t] = (b[i * 2, t - 1] + b[i * 2, t + 1])/2;
                }
            }

            for (int i = 1; i < b.GetLength(0); i += 2)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    b[i, j] = (b[i - 1, j] + b[i + 1, j])/2;
                }
            }

            for (int i = 0; i < 2*n-1; i++)
            {
                for (int j = 0; j < 2*m-1; j++)
                {
                    Console.Write($"{b[i, j]} ");
                }
                Console.WriteLine("");
            }
        }
    }
}
