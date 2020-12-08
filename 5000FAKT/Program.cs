using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5000FAKT
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[] { 1, 2, 2, 3, 4, 5, 6, 3, 4, 5 };
            Console.WriteLine("vector");
            view(vector);
            int[] rez = in10(vector, 3);
            //view(rez);
            //view(ins(vector, 2));
            int[] test = new int[] { 1, 2, 3, 4 };
            Console.WriteLine("vector test");
            view(test);
            //view(inv(vector, test));
            Console.WriteLine("suma");
            view(addition(vector, test));
            Console.WriteLine("inmult");
            view(inv(vector, test));
            Console.WriteLine("factorial de 5000");
            factorial();
        }


            static int[] in10(int[] v, int n)
            {
                int[] temp = new int[v.Length + n];
                for (int i = 0; i < v.Length; i++)
                    temp[i] = v[i];
                return temp;
            }
            static int[] ins(int[] v, int n)
            {
                int[] result;
                int[] nv = new int[v.Length + 1];
                int produs = 0, transport = 0;
                for (int i = v.Length - 1; i >= 0; i--)
                {
                    produs = v[i] * n + transport;
                    nv[i] = produs % 10;
                    if (produs > 9)
                        transport = produs / 10;
                    else
                        transport = 0;
                }
                if (transport != 0)
                {
                    result = nv;
                    result[nv.Length - 1] = transport;
                }
                else
                {
                    result = new int[v.Length];
                    for (int i = 0; i < result.Length; i++)
                        result[i] = nv[i];
                }
                return result;
            }
            static int[] inv(int[] v, int[] vf)
            {
                int[] rez = new int[1];
                rez[0] = 0;
                int vfl = vf.Length;
                for (int i = vf.Length - 1; i >= 0; i--)
                {
                    rez = addition(rez, in10(ins(v, vf[i]), vf.Length - 1 - i));
                }
                return rez;
            }
         
            static int[] transform(int n)
            {
                int k = 0, nCopy = n, i = 0;
                while (nCopy != 0)
                {
                    k++;
                    nCopy /= 10;
                }
                int[] vector = new int[k];
                while (n != 0)
                {
                    vector[i] = n % 10;
                    i++;
                    n /= 10;
                }
                Array.Reverse(vector);
                return vector;
            }
            static void factorial()
            {
                int[] v1 = new int[1];
                v1[0] = 1;
                for (int i = 1; i < 15; i++)
                {
                    v1 = inv(v1, transform(i));
                    view(v1);
                }
            }
            static void view(int[] v)
            {
                for (int i = 0; i < v.Length; i++)
                    Console.Write($"{v[i]} ");
                Console.WriteLine();
            }
        private static int[] sumCalc(int newArrLength, int[] newArr, int[] one, int[] sum)
        {
            int next = 0;
            for (int i = newArrLength - 1; i >= 0; i--)
            {
                sum[i] = one[i] + newArr[i] + next;

                next = 0;
                if (sum[i] > 9 && i > 0)
                {
                    next = sum[i] / 10;
                    sum[i] = sum[i] % 10;
                }
            }
            return sum;
        }

        // RETURNS TRUE IF FIRST NUMBER IS BIGGER, FALSE IF SECOND IS BIGGER; QUITE USEFUL IF OPERATION IS NOT COMMUNTATIVE
        private static bool biggerNum(int[] one, int[] two)
        {
            if (one.Length > two.Length)
            {
                return true;
            }
            else if (two.Length > one.Length)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < one.Length; i++)
                {
                    if (one[i] > two[i])
                        return true;

                    if (two[i] > one[i])
                        return false;
                }
            }
            return true;
        }

        // TAKES THE NUMBER WITH LESS DIGITS, AND ADDS ZERO TO THE START UNTIL IT IS EQUAL WITH THE NUMBER WITH MORE DIGITS THIS PROGRAM MAKES ME WANNA DIE
        private static int[] newArrayLoadUp(int oneLength, int diff, int twoLen, int[] newArr, int[] two)
        {
            for (int i = oneLength - 1; i >= diff; i--, twoLen--)
            {
                newArr[i] = two[twoLen];
            }
            return newArr;
        }

        private static int[] addition(int[] one, int[] two)
        {
            int[] newArr = new int[] { };
            int[] sum = new int[] { };

            if (biggerNum(one, two))
            {
                newArr = new int[one.Length];
                sum = new int[one.Length];

                int diff = one.Length - two.Length;
                int twoLen = two.Length - 1;

                newArrayLoadUp(one.Length, diff, twoLen, newArr, two);
                sumCalc(newArr.Length, newArr, one, sum);
            }
            else
            {
                newArr = new int[two.Length];
                sum = new int[two.Length];

                int diff = two.Length - one.Length;
                int oneLen = one.Length - 1;

                newArrayLoadUp(two.Length, diff, oneLen, newArr, one);
                sumCalc(newArr.Length, newArr, two, sum);
            }

            return sum;
        }
    } 

}
