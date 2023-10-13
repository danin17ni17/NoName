using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов первого массива:");
            int[] a = new int[Convert.ToInt32(Console.ReadLine())];
            Console.WriteLine("Введите количество элементов второго массива:");
            int[] b = new int[Convert.ToInt32(Console.ReadLine())];

            Random rnd = new Random();
            int t1 = Environment.TickCount;
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(100);
            }
            for (int i = 0; i < b.Length; i++)
            {
                b[i] = rnd.Next(100);
            }

            for (int i = 0; i < a.Length; i++)//Сортировка "Пузырьком" Массива А
                for (int j = a.Length - 1; j > i; j--)
                {
                    if (a[j - 1] > a[j])
                    {
                        int x = a[j - 1];
                        a[j - 1] = a[j];
                        a[j] = x;
                    }
                }
            for (int i = 0; i < b.Length; i++)//Сортировка "Пузырьком" Массива В
                for (int j = b.Length - 1; j > i; j--)
                {
                    if (b[j - 1] > b[j])
                    {
                        int x = b[j - 1];
                        b[j - 1] = b[j];
                        b[j] = x;
                    }
                }

            Console.Write("\nПервый массив заполненный случайными числами:\n");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");//Вывод в консоль отсортированного массива А
            }
            Console.Write("\nВторой массив заполненный случайными числами:\n");
            for (int i = 0; i < b.Length; i++)
            {
                Console.Write(b[i] + " ");//Вывод в консоль отсортированного массива В
            }

            Console.Write("\nЭлементы, которые присутствуют в первом массиве, но отсутствуют во втором массиве:\n");
            bool flag = true;//Линейный алгоритм поиска
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                    if (a[i] == b[j])
                    {
                        flag = false; break;
                    }
                if (flag == true)
                    Console.Write(a[i] + " ");
                flag = true;
            }

            int t2 = Environment.TickCount;
            Console.WriteLine("\nВремя работы программы равно " + (t2 - t1) + " мс");
            Console.ReadLine();
        }
    }
}
