using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_1011
{
    static class ExtensionMethodsForInt
    {
        public static bool isPrime(this int n)
        {
            for (int d = 2; d*d <= n; d++)
            {
                if (n % d == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool isNegyzet(this int n)
        {
            for (int i = 1; i*i <= n; i++)
            {
                if (i*i == n)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
