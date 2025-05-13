using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] table = { 20, 5, 15, 10};

            int[] indexes = new int[table.Length];

            for (int i = 0; i < table.Length; i++)
            {
                indexes[i] = i;
            }

            SelectionSort(table, indexes);

        }
        static void SelectionSort(int[] arr, int[] indexes)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    int temp = arr[i];
                    arr[i] = arr[min];
                    arr[min] = temp;

                    int tempIndex = indexes[i];
                    indexes[i] = indexes[min];
                    indexes[min] = tempIndex;

                }
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"Liczba ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{arr[i]} ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"była na indexie ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{indexes[i]}\n");
            }
            
        }
    }
}
