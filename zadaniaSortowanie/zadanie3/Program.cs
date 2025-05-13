using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Podaj 6 liczb które dodasz do tablicy: ");
            List<int> list = new List<int>();
            for (int i = 0; i < 6; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Liczba {i + 1}:");
                Console.ForegroundColor = ConsoleColor.Green;
                int number = int.Parse(Console.ReadLine());
                list.Add(number);
                Console.ResetColor();
                
            }
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Tablica posortowana rosnąco");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(string.Join(",", InsertionSort(list.ToArray())));

            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Tablica posortowana malejąco");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(string.Join(",", InsertionSortReversed(list.ToArray())));
        }
        static int[] InsertionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int temp = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > temp)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = temp;

            }

            return arr;
        }
        static int[] InsertionSortReversed(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int temp = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] < temp)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = temp;

            }

            return arr;
        }
    }
}
