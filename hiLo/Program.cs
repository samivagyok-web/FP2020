using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hiLo
{
    class Program
    {
        public static int getNumber()
        {
            string line;
            bool valid;
            int numar = 0;
            do
            {
                valid = true;
                line = Console.ReadLine();
                try
                {
                    numar = int.Parse(line);
                }
                catch (Exception)
                {
                    valid = false;
                    Console.WriteLine("Please don't do 'funny' things");
                }
            } while (!valid);

            return numar;
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int x = rnd.Next(1024);

            int n;
            int s = 0;
            do
            {
                Console.Write("Introduceti un numar intre [1-1024]: ");
                n = getNumber();
                s++;
                if (n < x)
                    Console.WriteLine("Prea mic.");
                else if (n > x)
                    Console.WriteLine("Prea mare");
                else
                    Console.WriteLine($"Ai ghicit numarul din {s} incercari!");

            } while (n != x);
        }
    }
}
