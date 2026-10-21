using System;

class Program
{
    static void Main() // Объединил код в один для быстрого выполнения кода
    {
        // Блок 1: ввод целых чисел и базовые арифметические операции
        int A, B, C, D, E, F, H;
        double X1, X2;

        Console.Write("Введите данные A для вычисления (целое число):\n");
        A = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"A = {A.ToString("000")}\n");

        Console.Write("Введите данные B для вычисления (целое число):\n");
        B = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"B = {B.ToString("000")}\n");

        Console.WriteLine("Ниже предоставлены математические вычисления (нажмите [Enter/Return])\n");
        Console.ReadKey();

        C = A + B;
        D = A - B;
        E = A * B;
        X1 = A / B;
        X2 = A / Convert.ToDouble(B);
        F = A % B;

        Console.WriteLine("Сложение A и B = " + C);
        Console.WriteLine("Вычитание A и B = " + D);
        Console.WriteLine("Умножение A и B = " + E);
        Console.WriteLine("Целочисленное деление A и B = " + X1);
        Console.WriteLine("Деление A и B = " + X2);
        Console.WriteLine("Остаток от деления A и B = " + F + "\n");

        // Блок 2: математические функции для числа A
        Console.WriteLine("Ниже предоставлены математические функции (нажмите [Enter/Return])\n");
        Console.ReadKey();

        H = Convert.ToInt32(Math.Pow(A, 2));
        double Y = Math.Sqrt(A);
        double Z = Math.Pow(A, 2);

        Console.WriteLine("Возведение в квадрат A = " + H);
        Console.WriteLine("Вычисление квадратного корня A = " + Y);
        Console.WriteLine("Возведение A в степень 2 = " + Z);

        // Блок 3: сложное выражение с заданными значениями (из «серверного» кода)
        double a = 8.3, b = 6.2, x = -8, z = 3.1;

        if (-x + 13 <= 0)
        {
            Console.WriteLine("Ошибка: подкоренное выражение <= 0 (√(-x + 13))");
        }
        else if (Math.Pow(z, 2) + 4 <= 0)
        {
            Console.WriteLine("Ошибка: аргумент логарифма <= 0 (ln(z² + 4))");
        }
        else
        {
            double result = (a * Math.Pow(Math.Sin(Math.Abs(b * x)), 2) - 24 * z) /
                (Math.Sqrt(-x + 13) - b * Math.Log(Math.Pow(z, 2) + 4));
            Console.WriteLine("Результат сложного выражения F = " + result.ToString("0.00"));
        }

        // Блок 4: вычисление Y для заданных x, a, b (первый вариант формулы)
        double y1X = 6.37, y1A = 2.56, y1B = 7.18;
        double Y1 = Math.Cos(y1X - y1A) / (Math.Exp(y1X - y1A) + Math.Sqrt(Math.Abs(y1B * y1X)));
        Console.WriteLine($"Y (cos/(exp+sqrt)) = {Y1}");

        // Блок 5: вычисление Y1 и Y2 по второму варианту формулы
        double y2A = 3.56, y2B = 5.86, y2X = 2.28;
        double Y2_1 = Math.Pow(y2X - y2A, 3);
        double Y2_2 = Math.Exp(y2X - y2A) / Math.Cos(y2B * y2X);
        Console.WriteLine($"Y1 (x-a)^3 = {Y2_1}");
        Console.WriteLine($"Y2 (exp/cos) = {Y2_2}");

        Console.WriteLine("\nВычисления завершены. Нажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}