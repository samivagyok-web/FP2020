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
            int[] hardCodedArr = new int[] { 39, 2, 47, 12, 24, 38, 100, 29, 4, 74 };
            List<int> hardCodedList = new List<int>() { 39, 47, 2, 12, 24, 38, 100, 29 };

            // did : 1 2 3 4 5 6 7 (8 9) 11 12 13 

            // sumaElement();
            // kSearch(hardCodedArr);
            // minMaxPos(hardCodedArr);         // GOTTA COME BACK HERE
            // minMax(hardCodedArr);
            // insertValue(hardCodedList);
            // deleteValue(hardCodedArr);
            // inversareElemente(hardCodedArr);
            // rotireElemente(hardCodedArr);

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
            int key;
            do
            {
                Console.Write("Introduceti cu cate pozitii doriti rotirea pe stanga: ");
                key = (int)getNumber();
            } while (key < 0 || key > hardCodedArr.Length);
            int aux = 123213;
            for (int i = 0; i < hardCodedArr.Length - key; i++)
            {
                int newPlace = (i + hardCodedArr.Length - key) % hardCodedArr.Length;
                Console.WriteLine($"{i}: {newPlace}");
                aux = hardCodedArr[newPlace];
                hardCodedArr[newPlace] = hardCodedArr[i];
                hardCodedArr[i] = aux; 
            }

            for (int i = 0; i < hardCodedArr.Length; i++)
            {
                Console.Write($"{hardCodedArr[i]} ");
            }
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

                if (min > hardCodedArr[i])
                {
                    min = hardCodedArr[i];
                    minPos = i;
                }
            }
            Console.WriteLine(minPos + " " + maxPos);
        }

        private static void kSearch(int[] hardCodedArr)
        {
            Console.Write("Numarul pe care cautati: ");
            int k = (int)getNumber();
            int sum = 0;

            for (int i = 0; i < hardCodedArr.Length; i++)
            {
                if (hardCodedArr[i] == k)
                {
                    Console.WriteLine($"{k} se afla pe pozitia {i}");
                    sum++;
                    break;
                }
            }

            if (sum == 0)
                Console.WriteLine("-1");
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
