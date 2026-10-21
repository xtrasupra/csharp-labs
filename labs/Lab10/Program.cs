using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Практическая работа ===");
            Console.WriteLine("1.  Нахождение максимального элемента в одномерном массиве (1)");
            Console.WriteLine("=== Самостоятельная работа ===");
            Console.WriteLine("2.  Поиск минимального элемента и его индекса в массиве (10.1)");
            Console.WriteLine("3.  Возведение в квадрат элементов с нечетными индексами (10.2)");
            Console.WriteLine("4.  Формирование обратного массива (10.3)");
            Console.WriteLine("0.  Выход");
            Console.Write("\nВыберите задачу (0-5): ");

            string choice = Console.ReadLine();

            if (choice == "0")
            {
                Console.WriteLine("Выход из программы.");
                break;
            }

            switch (choice)
            {
                case "1": Task1(); break;
                case "2": Task101(); break;
                case "3": Task102(); break;
                case "4": Task103(); break;
                default: Console.WriteLine("Неверный выбор!"); break;
            }

            Console.WriteLine("\nНажмите Enter для продолжения...");
            Console.ReadLine();
        }

        static void Task1()
        {
            const int n = 8;
            int[] a = new int[n] { 3, 12, 5, 9, 8, 7, 10, 1 };
            Console.WriteLine("\nИсходный массив: ");
            for (int i = 0; i < n; ++i)
                Console.Write("\t " + a[i]);
            Console.WriteLine();
            int max = 0;
            for (int i = 0; i < n; ++i)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            Console.Write("Максимальный элемент = " + max);
            Console.WriteLine();
        }

        static void Task101()
        {
            int[] array = new int[15];
            Random random = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 51);
            }

            Console.Write("\nМассив: ");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            int min = array[0];
            int minIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    minIndex = i;
                }
            }

            Console.WriteLine($"Минимальный элемент: {min}");
            Console.WriteLine($"Индекс минимального элемента: {minIndex}");
        }

        static void Task102()
        {
            int[] array = new int[15];
            Random random = new Random();

            Console.Write("\nИсходный массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 51);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0)
                {
                    array[i] = array[i] * array[i];
                }
            }

            Console.Write("Измененный массив: ");
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }

        static void Task103()
        {
            int[] W = new int[10];
            int[] R = new int[10];

            Console.WriteLine("\nВведите 10 целых чисел:");
            for (int i = 0; i < W.Length; i++)
            {
                Console.Write($"W[{i}] = ");
                W[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < W.Length; i++)
            {
                R[i] = W[W.Length - 1 - i];
            }

            Console.WriteLine("\nМассив W\tМассив R");
            Console.WriteLine("----------------------");
            for (int i = 0; i < W.Length; i++)
            {
                Console.WriteLine($"{W[i]}\t\t{R[i]}");
            }
        }
    }
}