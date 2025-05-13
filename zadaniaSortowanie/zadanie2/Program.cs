using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Podaj 10 liczb które dodasz do tablicy: ");
            List<int> list = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Liczba {i + 1}:");
                Console.ForegroundColor = ConsoleColor.Green;
                int number = int.Parse(Console.ReadLine());
                list.Add(number);
                Console.ResetColor();
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Pierwsze 5 liczb zostało posortowanych, reszta nie została ruszona.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(string.Join(",", InsertionSort(list.ToArray())));
        }
        static int[] InsertionSort(int[] arr)
        {
            for (int i = 0; i < 5; i++)
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
    
    }
}
