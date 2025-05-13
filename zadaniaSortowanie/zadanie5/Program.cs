using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Podaj 5 liczb które dodasz do tablicy: ");
            List<int> list = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Liczba {i + 1}:");
                Console.ForegroundColor = ConsoleColor.Green;
                int number = int.Parse(Console.ReadLine());
                list.Add(number);
                Console.ResetColor();
            }
            
            int[] table = list.ToArray();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"\nPosortowana tablica: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(string.Join(",", BubbleSort(list.ToArray())));
            Console.WriteLine("");

            int median = table[table.Length/2];

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"Mediana z tablicy: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{median}");
            Console.WriteLine("");
        }
        static int[] BubbleSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                    }
                }
            }
            return arr;
        }
    }
}
