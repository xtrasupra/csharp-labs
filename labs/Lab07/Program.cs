using System;

class Program
{
    static void Main()
    {
        double Xn = -4.2, Xk = 8.4, dX = 1.12, y; // 1
        Console.WriteLine("    x        у ");
        double x = Xn;
        while (x <= Xk)
        {
            y = 3 * Math.Pow(x, 2) + 2 * x - 4;
            Console.WriteLine("| {0,5} | {1,8} |", x, y);
            x += dX;
        }

        Console.WriteLine("\nНажмите Enter/return для перехода к следующему коду\n");
        Console.ReadKey(); // 1

        double N = 1, Xk1 = 8.4, dX1 = 1.12, y1; // 2
        Console.WriteLine("    x        у ");
        double S = 0;
        do
        {
            S = S + 1 / N;
            Console.WriteLine("| {0,5} | {1,16} |", N, S);
            N++;
        }
        while (1 / N > 0.08);

        Console.WriteLine("\nНажмите Enter/return для перехода к следующему коду\n");
        Console.ReadKey(); // 2

        Random a2 = new Random((int)DateTime.Now.Ticks); // 3
        Int32 y2, k = 0;
        Console.WriteLine(" x           a ");

        for (int x2 = 1; x2 <= 20; x2++)
        {
            y2 = a2.Next(100);
            Console.WriteLine("| {0,6} | {1,6} |", x2, y2);
            if (y2 % 5 == 0) break;
        }

        Console.WriteLine("\nНажмите Enter/return для перехода к следующему коду\n");
        Console.ReadKey(); // 3

        double x_n = 1.63; // 7.1
        double x_k = 8.26;
        double dx = 0.8;
        double a3 = 4.8;
        double b3 = 0.18;

        Console.WriteLine("Табулирование функции для варианта 1\n");
        Console.WriteLine("x\t\ty(x)");
        Console.WriteLine("--------------------");

        for (double x3 = x_n; x3 <= x_k + dx / 2; x3 += dx)
        {
            double y3;
            if (x3 > a3)
            {
                y3 = Math.Exp(Math.Abs(x3 - a3)) / Math.Pow(Math.Cos(b3 * x3), 2);
            }
            else
            {
                y3 = Math.Pow(x3 - a3, 3) + b3;
            }

            Console.WriteLine("{0:F2}\t{1:F6}", x3, y3);
        }

        Console.WriteLine("\nНажмите Enter/return для перехода к следующему коду\n");
        Console.ReadKey(); // 7.1

        const double d4 = 0.001; // 7.2
        const double Pi = Math.PI;
        double sum = 0;
        double calculatedPi;
        int n = 1;

        do
        {
            sum += 1.0 / (n * n);
            calculatedPi = Math.Sqrt(6 * sum);
            n++;
        }
        while (Math.Abs(Pi - calculatedPi) >= d4);

        Console.WriteLine($"{calculatedPi}");

        Console.WriteLine("\nНажмите Enter/return для перехода к следующему коду\n");
        Console.ReadKey(); // 7.2

        int sum1 = 0; // 7.3
        int product = 1;
        int number;

        Console.WriteLine("\nВведите целые числа (0 — завершение):");

        while (true)
        {
            Console.Write("Число: ");
            number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                break;
            }

            sum1 += number;
            product *= number;
        }

        Console.WriteLine($"Сумма: {sum}");
        Console.WriteLine($"Произведение: {product}");

        Console.WriteLine("\nНажмите Enter/return для перехода к следующему коду\n");
        Console.ReadKey(); // 7.3

        const double PI = Math.PI; // 7.4

        Console.WriteLine("Угол (°) | Синус     | Косинус    | Тангенс   | Котангенс");
        Console.WriteLine("--------|----------|-----------|-----------|----------");

        for (int angle = 0; angle <= 180; angle += 10)
        {
            double radians = angle * PI / 180.0;
            double sinVal = Math.Sin(radians);
            double cosVal = Math.Cos(radians);

            string tanStr, cotStr;

            if (Math.Abs(cosVal) < 1e-10)
            {
                tanStr = "нет";
            }
            else
            {
                tanStr = $"{Math.Tan(radians):F4}";
            }

            if (Math.Abs(sinVal) < 1e-10)
            {
                cotStr = "нет";
            }
            else
            {
                cotStr = $"{(cosVal / sinVal):F4}";
            }

            Console.WriteLine($"{angle,6} | {sinVal:F4} | {cosVal:F4} | {tanStr,8} | {cotStr,8}");

            Console.WriteLine("\nНажмите Enter/return для перехода к следующему коду\n");
            Console.ReadKey(); // 7.4
        }
    }
}