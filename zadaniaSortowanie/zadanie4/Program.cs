using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie4
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
            BubbleSort(list.ToArray());
        }
        static void BubbleSort(int[] arr)
        {
            int count = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temporary = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temporary;
                        count++;
                    }
                }
            }
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Posortowana tablica: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(string.Join(",",arr));

            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"Zamianę liczb wykonano w tylu krokach: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{count}");
        }
    }
}
