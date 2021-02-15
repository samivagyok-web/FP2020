using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARIRE
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
          //  Problema4();      OKKKKK
          //  Problema5();      OKKKKK
            Problema6();
        }

        private static void Problema4()
        {
            Console.Write("Baza p: ");
            int p = int.Parse(Console.ReadLine());

            Console.Write("Baza q: ");
            int q = int.Parse(Console.ReadLine());

            Console.Write("Numarul maxim n: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = n; i >= 0; i--)
            {
                // convertim numarul din baza 10 in baza p si q
                int primNumConv = conversieDin10(i, p); 
                int secNumConv = conversieDin10(i, q);

                if (numMagic(primNumConv, secNumConv) && numMagic(secNumConv, primNumConv)) // in metoda mea acest functie nu este commutitiva, deci trebuie vazut si cand este schimbata pozitia
                    Console.Write($"{i} ");
            }
        }

        private static bool numMagic(int p, int q)
        {
            string primNum = p.ToString();  // convertim un numar in string

            while (q > 0)
            {
                int r = q % 10; 
                if (!primNum.Contains(r.ToString())) // inspectam cifrele unu cate unu de la capat, si daca nu gasim in numarul celalt atunci nu e magica
                    return false;

                q = q / 10;
            }

            return true;    // daca ajungem aici atunci toate cifrele existau in numarul celalalt
        }

        private static int conversieDin10(int n, int q)
        {
            // algoritm de convertire basic pentru bazele < 10
            int numarulNou = 0;
            int putere = 1;

            while (n != 0)
            {
                int r = n % q;
                n = n / q;
                numarulNou = numarulNou + r * putere;
                putere = putere * 10;
            }
            return numarulNou;
        }

        private static void Problema5()
        {
            Console.Write("Linii: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Coloane: ");
            int m = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = rnd.Next();
                    Console.Write($"{matrix[i,j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int up = 0;
            int down = n - 1;
            int left = 0;
            int right = m - 1;
            // in aceste 4 variabile vom salva limitele - deci daca up = 1 primul sir deja a fost traversat, si asa mai departe

            while (true)    // nu punem nici o conditie fiindca avem 4 if-uri care ies din loop daca am terminat
            {
                if (left > right)
                    break;

                for (int i = left; i <= right; i++)         // traversam de la stanga la dreapta
                    Console.Write($"{matrix[up,i]} ");
                up++;

                if (up > down)
                    break;

                for (int i = up; i <= down; i++)            // de sus in jos
                    Console.Write($"{matrix[i, right]} ");
                right--;

                if (left > right)
                    break;

                for (int i = right; i >= left; i--)         // de le dreapta la stanga
                    Console.Write($"{matrix[down, i]} ");
                down--;

                if (up > down)
                    break;

                for (int i = down; i >= up; i--)            // din jos in sus ------ intotdeauna asa traversam pana cand putem: right, down, left, up
                    Console.Write($"{matrix[i, left]} ");
                left++;
            }
        }


        private static void Problema6()
        {
            Console.Write("Cate numere: ");
            int n = int.Parse(Console.ReadLine());
            int[] numere = new int[n];

            int c = 0;
            do
            {
                numere[c] = int.Parse(Console.ReadLine());
                c++;
            } while (c < n);

            Console.Write("Numarul de interogari: ");
            int q = int.Parse(Console.ReadLine());

            int[] primElement = new int[q];
            int[] secElement = new int[q];

            c = 0;
            do
            {
                Console.Write("x: ");
                int x = int.Parse(Console.ReadLine());
                primElement[c] = x;

                Console.Write("s: ");
                int s = int.Parse(Console.ReadLine());
                secElement[c] = s;

                c++;
            } while (c < q);

            int[] sums = new int[] { };
            sums = sume(numere);    // salvam sumele intr-un array unde sums[i] = sums[0] + sums[1] + ... + sums[i]; fiindca avem doar numere naturale asta va fi crescator deci putem folosi binary search

            for (int i = 0; i < primElement.Length; i++)
            {
                // ca sa micsoram comparatiile prima data cautam pana la ce index este s mai mic decat sumele
                int upperBoundOfSumsIndex = binarySearch(sums, secElement[i]) + 1;                  

                // primim inapoi indexul; acest index poate fi outputul maxim fara a lua in considerare x
                int j = 0;
                while (j < upperBoundOfSumsIndex && j < numere.Length && primElement[i] >= numere[j])   // cautam prima valoare care va fii mai mare decat x - fiindca sirul este indexat de la 1 nu facem -1
                    j++;

                Console.WriteLine(j);
            }
        }

        private static int binarySearch(int[] sums, int s)
        {
            if (s < sums[0])
                return 0;
            if (s > sums[sums.Length - 1])
                return sums.Length;

            int left, right, mid;
            left = 0; right = sums.Length - 1;
            while (left <= right)
            {
                mid = left + (right - left) / 2;
                if (s < sums[mid])
                {
                    if (s > sums[mid - 1])
                        return mid - 1;
                    else
                        right = mid - 1;
                }
                else if (s > sums[mid])
                {
                    if (s < sums[mid + 1])
                        return mid;
                    else
                        left = mid + 1;
                }
                else
                    return mid;
            }
            return -1;

        }

        private static int[] sume(int[] numere)
        {
            int sum = 0;
            int[] nums = new int[numere.Length];
            for (int i = 0; i < numere.Length; i++)
            {
                sum = sum + numere[i];
                nums[i] = sum;
            }
            return nums;
        }
    }
}
