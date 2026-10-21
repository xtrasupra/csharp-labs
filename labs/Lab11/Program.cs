using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Лабораторная работа 11 ===");
            Console.WriteLine("Выберите вариант от 1-го до 3-го");
            Console.WriteLine("Для выхода введите 0");
            Console.Write("Ваш выбор: ");

            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Ошибка ввода! Нажмите любую клавишу...");
                Console.ReadKey();
                continue;
            }

            if (choice == 0)
            {
                Console.WriteLine("Выход из программы...");
                break;
            }

            switch (choice)
            {
                case 1:
                    Variant1();
                    break;
                case 2:
                    Variant2();
                    break;
                case 3:
                    Variant3();
                    break;
                default:
                    Console.WriteLine("Неверный выбор! Допустимые значения: 0-3");
                    Console.WriteLine("Нажмите любую клавишу...");
                    Console.ReadKey();
                    break;
            }

            if (choice >= 1 && choice <= 3)
            {
                Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
                Console.ReadKey();
            }
        }
    }
    static void Variant1()
    {
        {
            Console.Write("Введите количество строк: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            Console.WriteLine("Введите элементы матрицы:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"matrix[{i},{j}] = ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int rowsWithoutZero = 0;
            for (int i = 0; i < rows; i++)
            {
                bool hasZero = false;
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        hasZero = true;
                        break;
                    }
                }
                if (!hasZero)
                    rowsWithoutZero++;
            }

            Console.WriteLine($"1. Количество строк без нулевых элементов: {rowsWithoutZero}");

            Dictionary<int, int> frequency = new Dictionary<int, int>();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    int num = matrix[i, j];
                    if (frequency.ContainsKey(num))
                        frequency[num]++;
                    else
                        frequency[num] = 1;
                }
            }

            int maxRepeated = int.MinValue;
            foreach (var pair in frequency)
            {
                if (pair.Value > 1 && pair.Key > maxRepeated)
                {
                    maxRepeated = pair.Key;
                }
            }

            if (maxRepeated != int.MinValue)
                Console.WriteLine($"2. Максимальное число, встречающееся более одного раза: {maxRepeated}");
            else
                Console.WriteLine("2. Нет чисел, встречающихся более одного раза");
        }
    }

    static void Variant2()
    {
        Console.Write("Введите количество строк: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Введите количество столбцов: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, cols];

        Console.WriteLine("Введите элементы матрицы:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"matrix[{i},{j}] = ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int colsWithoutZero = 0;
        for (int j = 0; j < cols; j++)
        {
            bool hasZero = false;
            for (int i = 0; i < rows; i++)
            {
                if (matrix[i, j] == 0)
                {
                    hasZero = true;
                    break;
                }
            }
            if (!hasZero)
                colsWithoutZero++;
        }

        Console.WriteLine($"1. Количество столбцов без нулевых элементов: {colsWithoutZero}");

        int[] characteristics = new int[rows];

        for (int i = 0; i < rows; i++)
        {
            int sum = 0;
            for (int j = 0; j < cols; j++)
            {
                if (matrix[i, j] > 0 && matrix[i, j] % 2 == 0)
                {
                    sum += matrix[i, j];
                }
            }
            characteristics[i] = sum;
        }

        int[] rowIndices = new int[rows];
        for (int i = 0; i < rows; i++)
            rowIndices[i] = i;

        for (int i = 0; i < rows - 1; i++)
        {
            for (int j = 0; j < rows - i - 1; j++)
            {
                if (characteristics[rowIndices[j]] > characteristics[rowIndices[j + 1]])
                {
                    int temp = rowIndices[j];
                    rowIndices[j] = rowIndices[j + 1];
                    rowIndices[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("\nХарактеристики строк:");
        for (int i = 0; i < rows; i++)
        {
            Console.WriteLine($"Строка {i}: {characteristics[i]}");
        }

        Console.WriteLine("\nОтсортированная матрица:");
        for (int i = 0; i < rows; i++)
        {
            int rowIndex = rowIndices[i];
            Console.Write($"Характеристика {characteristics[rowIndex]}: ");
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[rowIndex, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void Variant3()
    {
        {
            Console.Write("Введите количество строк: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            Console.WriteLine("Введите элементы матрицы:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"matrix[{i},{j}] = ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int colsWithZero = 0;
            for (int j = 0; j < cols; j++)
            {
                bool hasZero = false;
                for (int i = 0; i < rows; i++)
                {
                    if (matrix[i, j] == 0)
                    {
                        hasZero = true;
                        break;
                    }
                }
                if (hasZero)
                    colsWithZero++;
            }

            Console.WriteLine($"1. Количество столбцов с нулевыми элементами: {colsWithZero}");

            int maxSeriesRow = 0;
            int maxSeriesLength = 1;

            for (int i = 0; i < rows; i++)
            {
                int currentSeriesLength = 1;
                int currentMaxSeries = 1;

                for (int j = 1; j < cols; j++)
                {
                    if (matrix[i, j] == matrix[i, j - 1])
                    {
                        currentSeriesLength++;
                        if (currentSeriesLength > currentMaxSeries)
                            currentMaxSeries = currentSeriesLength;
                    }
                    else
                    {
                        currentSeriesLength = 1;
                    }
                }

                if (currentMaxSeries > maxSeriesLength)
                {
                    maxSeriesLength = currentMaxSeries;
                    maxSeriesRow = i;
                }
            }

            Console.WriteLine($"2. Строка с самой длинной серией одинаковых элементов: {maxSeriesRow}");
            Console.WriteLine($"   Длина серии: {maxSeriesLength}");
        }
    }
}

