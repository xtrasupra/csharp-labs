using System;

class Program
{
    static void Main()
    {
        double y; // 1
        Console.WriteLine("    x       y    \n");

        for (Int32 x = 1; x <= 10; x++)
        {
            y = Math.Pow(x, 2);
            Console.WriteLine("| {0,6} | {1,6} |", x, y);
        }

        Console.WriteLine("\nНажмите Enter/return для перехода к следующему коду");
        Console.ReadKey(); // 1

        Console.WriteLine("\n   x  \n"); // 2

        for (char x1 = 'Z'; x1 >= 'A'; x1--)
        {
            Console.WriteLine("| {0,3} |", x1);
        }

        Console.WriteLine("\nНажмите Enter/return для перехода к следующему коду");
        Console.ReadKey(); // 2

        Random a = new Random((int)DateTime.Now.Ticks); // 3
        Int32 y2, k = 0;
        Console.WriteLine("\n    x       y    \n");

        for (int x2 = 1; x2 <= 10; x2++)
        {
            y2 = a.Next(100);
            Console.WriteLine("| {0,6} | {1,6} |", x2, y2);
            if (y2 % 3 == 0) k++;
        }
        Console.WriteLine("\nКоличество кратных 3 = " + k);

        Console.WriteLine("\nНажмите Enter/return для перехода к следующему коду");
        Console.ReadKey(); // 3

        Console.WriteLine("\nВведите число/сумму для умножения"); // 6.1
        double p3 = Convert.ToDouble(Console.ReadLine());
        double y3;

        for (Int32 t3 = 1; t3 <= 10; t3++)
        {
            y3 = p3 * t3;
            Console.WriteLine("| {0,6} |", $"   {p3} * {t3} = {y3}   ");
        }

        Console.WriteLine("\nНажмите Enter/return для перехода к следующему коду\n");
        Console.ReadKey(); // 6.1

        Console.WriteLine("Степени числа 2:"); // 6.2
        for (int i = 0; i <= 10; i++)
        {
            int power = (int)Math.Pow(2, i);
            Console.WriteLine($"2^{i} = {power}");
        }

        Console.WriteLine("\nНажмите Enter/return для перехода к следующему коду\n");
        Console.ReadKey(); // 6.2

        for (char c = 'R'; c >= 'A'; c--) // 6.3
        {
            Console.WriteLine(new string(' ', (int)(c - 'A')) + c);
        }

        Console.WriteLine("\nНажмите Enter/return для перехода к следующему коду\n");
        Console.ReadKey(); // 6.3

        Random rand = new Random(); // 6.4
        int sum = 0, count = 0;

        Console.WriteLine("Случайные числа (не кратные 4):\n");
        for (int i = 1; i <= 20; i++)
        {
            int num = rand.Next(201);
            if (num % 4 != 0)
            {
                Console.WriteLine(num);
                sum += num;
                count++;
            }
        }

        Console.WriteLine($"\nСумма: {sum}");
        Console.WriteLine($"Количество: {count}"); // 6.4
    }
}