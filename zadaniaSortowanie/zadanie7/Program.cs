using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie7
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
            Console.Write("Tablica liczb gdzie posortowane malejąco zostały liczby o parzystym indeksie: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(string.Join(",", SelectionSort(list.ToArray())));

        }
        static int[] SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int min = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] > arr[min])
                    {
                        min = j;
                    }
                }

                if (min != i && arr[i]%2==0)
                {
                    int temp = arr[i];
                    arr[i] = arr[min];
                    arr[min] = temp;

                }

            }
            return arr;

        }
    }
}
