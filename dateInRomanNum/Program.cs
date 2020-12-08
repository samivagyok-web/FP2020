using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dateInRomanNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int an = 2900;
            int copyAn = an;
            string RomanNum = "";

            while (an >= 1000)
            {
                an = an - 1000;
                RomanNum = RomanNum + "M";
            }

            while (an >= 500)
            {
                an = an - 500;
                RomanNum = RomanNum + "D";
            }

            while (an >= 100)
            {
                an = an - 100;
                RomanNum = RomanNum + "C";
            }

            while (an >= 50)
            {
                an = an - 50;
                RomanNum = RomanNum + "L";
            }

            while (an >= 10)
            {
                an = an - 10;
                RomanNum = RomanNum + "X";
            }

            while (an >= 5)
            {
                an = an - 5;
                RomanNum = RomanNum + "V";
            }

            while (an >= 1)
            {
                an = an - 1;
                RomanNum = RomanNum + "I";
            }

            Console.WriteLine($"{copyAn} = {RomanNum}");
        }

    }
}
