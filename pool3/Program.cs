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
            int[] hardCodedArr = new int[] { 39, 2, 47, 12, 24, 38, 100, 29, 4 };
          //  int[] hardCodedArr = new int[] { 3,1,2,3,4,5,6,7,8 };
            int[] hardCodedArr2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            List<int> hardCodedList = new List<int>() { 39, 47, 2, 12, 24, 38, 100, 29 };

            // did : 1 2 3 4 5 6 7 (8 9) 11 12 13 14 15 16 17 18 19 21 (22 25) 

            // sumaElement();
            // kSearch(hardCodedArr);
            // minMaxPos(hardCodedArr);         
            // minMax(hardCodedArr);
            // insertValue(hardCodedList);
            // deleteValue(hardCodedArr);
            // inversareElemente(hardCodedArr);
            // rotireElemente(hardCodedArr2);     

            /*
                        int k = int.Parse(Console.ReadLine());
                         int startIndex = 0;
                         int n = hardCodedArr.Length;
                         int poz = binarySearch(hardCodedArr, k, startIndex, n);
                        Console.WriteLine($"{k} se afla pe poz {poz}");                 // WILL COME BACK HERE
            */


            // erastotene();

            // SelectionSort(hardCodedArr);

            // InsertionSort(hardCodedArr);

            // interschimbZero();

            // repeatingElements();

            // cmmdc();

            // convertire();

            // polinom();

            // subArray();          // probably can be optimized

            // multimi();

            // lexico();

           // multimiCresc();
        }

        private static void multimiCresc()
        {
            int[] A = new int[] { 1, 3, 4, 6, 8 };
            int[] B = new int[] { 2, 4, 5, 8 };
            int[] C = new int[A.Length + B.Length];


        }

        private static void lexico()
        {
            int[] one = new int[] { 1, 2, 2, 3 };
            int[] two = new int[] { 1, 3, 2, 1 };
            int counter = 0;


            int min = Math.Min(one.Length, two.Length);

            for (int i = 0; i < min; i++)
            {
                if (one[i] < two[i])
                {
                    Console.WriteLine($"One se gaseste mai in fata in lex");
                    counter++;
                    break;
                }

                if (two[i] < one[i])
                {
                    counter++;
                    Console.WriteLine($"Two se gaseste mai in fata in lex");
                    break;
                }
            }
            if (counter == 0)
            {
                if (one.Length > two.Length)
                    Console.WriteLine($"Two se gaseste mai in fata in lex");
                else
                    Console.WriteLine($"One se gaseste mai in fata in lex");
            }
        }

        private static void multimi()
        {
            int[] v1 = new int[] { 1, 3, 4, 6, 8 };
            int[] v2 = new int[] { 2, 4, 5, 8 };
            int n = v1.Length + v2.Length;
            int[] v3 = new int[n];

            // intersectie
            int c = 0;
            for (int i = 0; i < v1.Length; i++)
            {
                for (int j = 0; j < v2.Length; j++)
                {
                    if (v1[i] == v2[j])
                    {
                        v3[c] = v1[i];
                        c++;
                    }
                }
            }

            for (int i = 0; i < c; i++)
            {
                Console.Write($"{v3[i]} ");
            }
            Console.WriteLine("");

            // reuniune
            c = 0;
            bool valid = true;
            for (int i = 0; i < v1.Length; i++)
            {
                v3[c] = v1[i];
                c++;
            }

            for (int i = 0; i < v2.Length; i++)
            {
                valid = true;
                for (int j = 0; j < c; j++)
                {
                    if (v3[j] == v2[i])
                    {
                        valid = false;
                        break;
                    }
                }

                if (valid)
                {
                    v3[c] = v2[i];
                    c++;
                }
            }

            for (int i = 0; i < c; i++)
            {
                Console.Write($"{v3[i]} ");
            }
            Console.WriteLine("");

            // A - B
            c = 0;
            for (int i = 0; i < v1.Length; i++)
            {
                valid = true;
                for (int j = 0; j < v2.Length; j++)
                {
                    if (v1[i] == v2[j])
                    {
                        valid = false;
                        break;
                    }
                }

                if (valid)
                {
                    v3[c] = v1[i];
                    c++;
                }
            }

            for (int i = 0; i < c; i++)
            {
                Console.Write($"{v3[i]} ");
            }
            Console.WriteLine("");

            c = 0;
            for (int i = 0; i < v2.Length; i++)
            {
                valid = true;
                for (int j = 0; j < v1.Length; j++)
                {
                    if (v2[i] == v1[j])
                    {
                        valid = false;
                        break;
                    }
                }

                if (valid)
                {
                    v3[c] = v2[i];
                    c++;
                }
            }

            for (int i = 0; i < c; i++)
            {
                Console.Write($"{v3[i]} ");
            }
            Console.WriteLine(""); 

            // interclasare
            c = 0;
            int k1 = 0; int k2 = 0;

            while (k1 < v1.Length && k2 < v2.Length)
            {
                if (v1[k1] < v2[k2])
                {
                    v3[c] = v1[k1];
                    k1++;
                    c++;
                }
                else
                {
                    v3[c] = v2[k2];
                    k2++;
                    c++;
                }
            }

            while (k1 < v1.Length)
            {
                v3[c] = v1[k1];
                c++;
                k1++;
            }

            while (k2 < v2.Length)
            {
                v3[c] = v2[k2];
                c++;
                k2++;
            }

            for (int i = 0; i < c; i++)
            {
                Console.Write($"{v3[i]} ");
            }
        }

        private static void subArray()
        {
            int[] big = new int[] { 1, 2, 1, 2, 1, 3, 1, 2, 1 };
            int[] key = new int[] { 1, 2, 1 };
            int counter = 0;
            int subA = 0;

            for (int i = 0; i < big.Length-2; i++)
            {
                int innerLoopKey = i + 1;
                if (big[i] == key[0])
                {  
                    for (int j = 1; j < key.Length; j++)
                    {
                        if (key[j] == big[innerLoopKey])
                        {
                            counter++;
                            innerLoopKey++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (counter == 2)
                    {
                        subA++;
                        i++;
                    }
                    counter = 0;
                }
            }
            Console.WriteLine(subA);
        }

        private static void polinom()
        {
            int[] coeficienti = new int[] { 2, 5, 3, 1 };
            double sum = 0;
            Console.Write("x: ");
            int x = (int)getNumber();

            for (int i = 0; i < coeficienti.Length; i++)
            {
                sum = sum + (Math.Pow(x, i) * coeficienti[i]);
            }
            Console.WriteLine(sum);
        }

        private static void convertire()
        {
            Console.Write("Introduceti un numar: ");
            int n = (int)getNumber();
            int b;
            do
            {
                Console.Write("Baza IN care vreti covnertit: ");
                b = (int)getNumber();
            } while (b < 1 || b > 16);

            Stack<string> stiva = new Stack<string>();
            string result = "";
            while (n > 0)
            {
                int rest = n % b;
                switch (rest)
                {
                    case 10:
                        stiva.Push("A");
                        break;
                    case 11:
                        stiva.Push("B");
                        break;
                    case 12:
                        stiva.Push("C");
                        break;
                    case 13:
                        stiva.Push("D");
                        break;
                    case 14:
                        stiva.Push("E");
                        break;
                    case 15:
                        stiva.Push("F");
                        break;
                    default:
                        stiva.Push($"{rest}");
                        break;
                }
                n = n / b;
            }

            while (stiva.Count > 0)
            {
                result = result + stiva.Pop();
            }

            Console.WriteLine(result);
        }

        private static void cmmdc()
        {
            int[] arr = new int[] { 9, 12, 48, 60 };
            
            int min = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }

            int[] freq = new int[min + 1];

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 1; j <= min; j++)
                {
                    if (arr[i] % j == 0)
                    {
                        freq[j]++;
                    }
                }
            }
            int max = -1;
            int poz = 0;
            for (int i = 0; i < freq.Length; i++)
            {
                if (max <= freq[i])
                {
                    max = freq[i];
                    poz = i;
                }
            }
            Console.WriteLine($"Cel mai mare divizor comun este {poz}");
        }

        private static void repeatingElements()
        {

            int[] repeatingArray = new int[] { 12, 5, 7, 9, 7, 7, 12, 63, 213, 12, 3 };
            int n = repeatingArray.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == i)
                        j++;

                    if (repeatingArray[i] == repeatingArray[j])
                    {
                        repeatingArray[j] = 0;
                    }
                }
            }

            for (int i = 0; i < n; i++)
                Console.Write($"{repeatingArray[i]} ");

        }

        private static void interschimbZero()
        {
            int[] zeroArray = new int[] { 2, 0, 5, 9, 0, 0, 14, 12, 4, 3 };
            int n = zeroArray.Length;
            int counter = 0;

            for (int i = 0; i < n - counter; i++)
            {
                if (zeroArray[i] == 0)
                {
                    zeroArray[i] = zeroArray[n - counter - 1];
                    zeroArray[n - counter - 1] = 0;
                    counter++;
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{zeroArray[i] }");
            }
        }

        private static void InsertionSort(int[] hardCodedArr)
        {
            int n = hardCodedArr.Length;
            int key, aux;

            for (int j = 1; j < n; j++)
            {
                key = hardCodedArr[j];
                int i = j - 1; 
                while (i >= 0 && key < hardCodedArr[i])
                {
                    aux = hardCodedArr[i];
                    hardCodedArr[i] = key;
                    hardCodedArr[i+1] = aux;
                    i--;
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{hardCodedArr[i]} ");
            }
        }

        private static void SelectionSort(int[] hardCodedArr)
        {
            // method by me
            int aux = 0;
            int n = hardCodedArr.Length;
            for (int i = 0; i < n-1; i++)
            {
                int smallest = i;
                for (int j = i+1; j < n; j++)
                {
                    if (hardCodedArr[j] < hardCodedArr[smallest])
                    {
                        smallest = j;
                    }
                }
                aux = hardCodedArr[i];
                hardCodedArr[i] = hardCodedArr[smallest];
                hardCodedArr[smallest] = aux;
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{hardCodedArr[i]} ");
            }
        }

        private static int binarySearch(int[] hardCodedArr, int k, int s, int n)
        {
            Array.Sort(hardCodedArr);

            int middle = s + (n - s) / 2;
            Console.WriteLine(middle);

            Console.WriteLine(k);
            Console.WriteLine(s);
            Console.WriteLine(n);
            Console.WriteLine("");

                if (k == hardCodedArr[middle])
                {
                    return middle;
                }
                else if (k < hardCodedArr[middle])
                {
                    return binarySearch(hardCodedArr, k, s, middle);
                }
                else if (k > hardCodedArr[middle])
                {
                    return binarySearch(hardCodedArr, k, middle, n);
                }
            return -1;
        }

        private static void erastotene()
        {
            Console.Write("Care va fi upper bound of interval: ");
            int n = (int)getNumber();

            bool[] nums = new bool[n];

            nums[0] = false;

            for (int i = 1; i < nums.Length; i++)
            {
                nums[i] = true;
            }

            int p = 2;

            while (Math.Pow(p, 2) < n)
            {
                if (nums[p])
                {
                    int j = (int)Math.Pow(p, 2);
                    while (j < n)
                    {
                        nums[j] = false;
                        j = j + p;
                    }
                }
                p++;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i])
                {
                    Console.Write($"{i} ");
                }
            }
        }

        private static void rotireElemente(int[] hardCodedArr)
        {
            // int[] hardCodedArr2 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            int key = 0;
            do
            {
                Console.Write("Introduceti cu cate pozitii doriti rotirea pe stanga: ");
                key = (int)getNumber();
            } while (key < 0 || key > hardCodedArr.Length);

            int i, j, k, temp;
            int n = hardCodedArr.Length;
            key = key % n;

            int greatestComDiv = gcd(key, n);

            for (i = 0; i < greatestComDiv; i++)
            {
                temp = hardCodedArr[i];
                j = i;

                while (true)
                {
                    k = j + key;
                    if (k >= n)
                        k = k - n;
                    if (k == i)
                        break;

                    hardCodedArr[j] = hardCodedArr[k];
                    j = k;
                }
                hardCodedArr[j] = temp;
            }

            for (int z = 0; z < hardCodedArr.Length; z++)
            {
                Console.Write($"{hardCodedArr[z]} ");
            }
        }

        private static int gcd(int a, int b)
        {
            if (b == 0)
                return a;
            else
                return gcd(b, a % b);

        }

        private static void inversareElemente(int[] hardCodedArr)
        {
            int aux = 0;
            for (int i = 0; i < hardCodedArr.Length / 2; i++)
            {
                aux = hardCodedArr[i];
                hardCodedArr[i] = hardCodedArr[hardCodedArr.Length - i - 1];
                hardCodedArr[hardCodedArr.Length - i - 1] = aux;
            }

            for (int i = 0; i < hardCodedArr.Length; i++)
            {
                Console.Write($"{hardCodedArr[i]} ");
            }
        }

        private static void deleteValue(int[] hardCodedArr)
        {
            int k;
            do
            {
                Console.Write("Pozitia din care va fi stearsa valoarea: ");
                k = (int)getNumber();
            } while (k > hardCodedArr.Length + 1 || k < 0);

            for (int i = k; i < hardCodedArr.Length - 1; i++)
            {
                hardCodedArr[i] = hardCodedArr[i+1];
            }

            for (int i = 0; i < hardCodedArr.Length - 1; i++)
            {
                Console.Write($"{hardCodedArr[i]} ");
            }
            Console.WriteLine();
        }

        private static void insertValue(List<int> hardCodedList)
        {
            Console.Write("O valoare care va fi inserate in array: ");
            int n = (int)getNumber();
            int k;
            do
            {
                Console.Write("Ce pozitie: ");
                k = (int)getNumber();
            } while (k > hardCodedList.Count + 1 || k < 0);

            hardCodedList.Insert(k, n);

            for (int i = 0; i < hardCodedList.Count; i++)
            {
                Console.Write($"{hardCodedList[i]} ");
            }
        }

        private static void minMax(int[] hardCodedArr)
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            int maxCounter = 1;
            int minCounter = 1;

            for (int i = 0; i < hardCodedArr.Length; i++)
            {
                if (max <= hardCodedArr[i])
                {
                    if (max == hardCodedArr[i])
                        maxCounter++;
                    else
                        maxCounter = 1;
                    max = hardCodedArr[i];
                }
                if (min >= hardCodedArr[i])
                {
                    if (min == hardCodedArr[i])
                        minCounter++;
                    else
                        minCounter = 1;
                    min = hardCodedArr[i];
                }
            }

            Console.WriteLine($"max: {max}, counter: {maxCounter}");
            Console.WriteLine($"min: {min}, counter: {minCounter}");
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
                else
                {
                    min = hardCodedArr[i];
                    minPos = i;
                }
            }
            Console.WriteLine(minPos + " " + maxPos);
        }

        private static int kSearch(int[] hardCodedArr)
        {
            Console.Write("Numarul pe care cautati: ");
            int k = (int)getNumber();

            for (int i = 0; i < hardCodedArr.Length; i++)
            {
                if (hardCodedArr[i] == k)
                {
                    return i;
                }
            }
            return -1;
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
