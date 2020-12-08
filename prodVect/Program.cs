using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prodVect
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 2, 5, 2 };
            int n = 7;
            int [] b = in10(a, n);
            view(b);
        }

        static void view(int[] v)
        {
            for (int i = 0; i < v.Length; i++)
            {
                Console.Write($"{v[i]} ");
            }
        }

        static int[] in10(int[] v, int n)
        {
            int[] temp = new int[v.Length + n];

            for (int i = 0; i < v.Length; i++)
            {
                temp[i] = v[i];
            }
            return temp;
        }

        static int[] ins(int[] v, int n)
        {
            int[] nv = new int[v.Length];
            int produs = 0;
            int transport = 0;

            for (int i = 0; i < v.Length; i++)
            {
                nv[i] = 
            }
        }
    }
}
