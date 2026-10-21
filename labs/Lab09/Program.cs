using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Практическая работа ===");
            Console.WriteLine("1.  Работа с массивом (замена нечетных на -1)");
            Console.WriteLine("2.  Подсчитать количество отрицательных чисел");
            Console.WriteLine("=== Самостоятельная работа ===");
            Console.WriteLine("3.  Положительные элементы заменить нулями (9.1)");
            Console.WriteLine("4.  Статистика нечетных элементов (9.2)");
            Console.WriteLine("5.  Вычисление функции y = f(x) (9.3)");
            Console.WriteLine("6.  Проверка упорядоченности массива по возрастанию (9.4)");
            Console.WriteLine("0.  Выход");
            Console.Write("\nВыберите задачу (0-6): ");

            string choice = Console.ReadLine();

            if (choice == "0")
            {
                Console.WriteLine("Выход из программы.");
                break;
            }

            switch (choice)
            {
                case "1": Task1(); break;
                case "2": Task2(); break;
                case "3": Task91(); break;
                case "4": Task92(); break;
                case "5": Task93(); break;
                case "6": Task94(); break;
                default: Console.WriteLine("Неверный выбор!"); break;
            }

            Console.WriteLine("\nНажмите Enter для продолжения...");
            Console.ReadLine();
        }
    }

    static void Task1()
    {
        Console.WriteLine("\nЗамена нечетных элементов на -1\n");
        const int n = 6;
        int[] a = new int[] { 3, 12, 5, -9, 9, -3 };
        Console.WriteLine("Исходный массив:\n");
        for (int i = 0; i < n; ++i)
            Console.Write("\t" + a[i]);
        Console.WriteLine();
        for (int i = 0; i < n; ++i)
        {
            if (a[i] % 2 == 0)
            {
                a[i] = -1;
            }
            Console.Write("\t" + a[i]);
        }
        Console.WriteLine();
    }

    static void Task2()
    {
        const int n = 6;
        int[] a = new int[] { -2, -3, 0, 1, 7, 5 };
        Console.WriteLine("\nИсходный массив  Sin\n");

        double[] F = new double[n];
        int kol = 0;
        for (int i = 0; i < n; ++i)
        {
            F[i] = Math.Sin(a[i]);
            if (F[i] < 0)
            {
                ++kol;
            }
            Console.WriteLine("\t {0,3}  {1,6:0.###}", a[i], F[i]);
        }
        Console.WriteLine("\nКол-во отрицательных = " + kol);
        Console.WriteLine();
    }

    static void Task91()
    {
        Console.WriteLine("Положительные элементы заменить нулями\n");

        double[] W = { -6.4, 12, 3.5, -2, 16.1, 5, 6, -9.7 };

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < W.Length; i++)
        {
            Console.Write($"{W[i],6:F1}");
        }
        Console.WriteLine();

        double[] transformed = new double[W.Length];
        Array.Copy(W, transformed, W.Length);

        for (int i = 0; i < transformed.Length; i++)
        {
            if (transformed[i] > 0)
            {
                transformed[i] = 0;
            }
        }

        Console.WriteLine("Преобразованный массив:");
        for (int i = 0; i < transformed.Length; i++)
        {
            Console.Write($"{transformed[i],6:F1}");
        }
        Console.WriteLine();
    }

    static void Task92()
    {
        Console.WriteLine("\nСтатистика нечетных элементов\n");

        Random random = new Random();
        int[] array = new int[12];

        Console.WriteLine("1) Массив случайных чисел (0-70):");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(0, 71);
            Console.Write($"{array[i],4}");
        }
        Console.WriteLine();

        int sumOdd = 0;
        double productOdd = 1;
        int countOdd = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 != 0)
            {
                sumOdd += array[i];
                productOdd *= array[i];
                countOdd++;
            }
        }

        Console.WriteLine("\n2) Статистика нечетных элементов:");
        Console.WriteLine($"Количество нечетных элементов: {countOdd}");

        if (countOdd > 0)
        {
            double averageArithmetic = (double)sumOdd / countOdd;
            double averageGeometric = Math.Pow(productOdd, 1.0 / countOdd);

            Console.WriteLine($"Сумма нечетных элементов: {sumOdd}");
            Console.WriteLine($"Произведение нечетных элементов: {productOdd}");
            Console.WriteLine($"Среднее арифметическое: {averageArithmetic:F2}");
            Console.WriteLine($"Среднее геометрическое: {averageGeometric:F2}");
        }
        else
        {
            Console.WriteLine("Нечетных элементов не найдено!");
        }
    }

    static void Task93()
    {
        Console.WriteLine("\nВычисление функции y = (0.8 * cos³(x + 2x²)) / (5/0.21x + 2.3)\n");

        double[] X = { 2.3, 3, 3.85, 4.2, 5.61, 6.12, 7.5, 8.1 };
        double[] Y = new double[X.Length];

        Console.WriteLine("Массив X и соответствующие значения Y:");
        Console.WriteLine("   X        Y");
        Console.WriteLine("-----------------");

        for (int i = 0; i < X.Length; i++)
        {
            double x = X[i];
            double numerator = 0.8 * Math.Pow(Math.Cos(x + 2 * x * x), 3);
            double denominator = (5 / (0.21 * x)) + 2.3;
            Y[i] = numerator / denominator;

            Console.WriteLine($"{x,6:F2}  {Y[i],10:F6}");
        }
    }

    static void Task94()
    {
        Console.WriteLine("\nПроверка упорядоченности массива по возрастанию\n");

        Console.WriteLine("Тест 1: Упорядоченный массив");
        int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        CheckArrayOrder(array1);

        Console.WriteLine("\nТест 2: Неупорядоченный массив");
        int[] array2 = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
        CheckArrayOrder(array2);

        Console.WriteLine("\nТест 3: Частично упорядоченный массив");
        int[] array3 = { 1, 2, 2, 3, 5, 4, 7, 8, 9 };
        CheckArrayOrder(array3);

        Console.WriteLine("\nТест 4: Массив с одинаковыми элементами");
        int[] array4 = { 5, 5, 5, 5, 5, 5, 5, 5, 5 };
        CheckArrayOrder(array4);

        Console.WriteLine("\nТест 5: Массив с возрастающими элементами");
        int[] array5 = { 1, 3, 5, 7, 9, 11, 13, 15, 17 };
        CheckArrayOrder(array5);
    }

    static void CheckArrayOrder(int[] array)
    {
        Console.Write("Массив: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"{array[i]} ");
        }

        bool isOrdered = true;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1])
            {
                isOrdered = false;
                break;
            }
        }

        if (isOrdered)
        {
            Console.WriteLine("- Упорядоченный");
        }
        else
        {
            Console.WriteLine("- Не упорядоченный");
        }
    }
}