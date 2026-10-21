using System;

class Lab01
{
    static void Main()
    {
        Console.WriteLine("\n...::: 1.2 Практическая часть :::...");
        double s, d;
        Console.Write("Введите диаметр: ");
        d = Convert.ToDouble(Console.ReadLine());
        s = Math.PI * Math.Pow(d, 2) / 4;
        Console.Write("Площадь круга = ");
        Console.WriteLine(s);

        Console.WriteLine("\nНажмите Enter для перехода к следующему заданию...");
        Console.ReadKey();

        Console.WriteLine("\n...::: 1.2.2 Самостоятельная работа :::...");
        Console.WriteLine("\n ---=== Задание 1.1 ===---");

        Console.WriteLine("\nВведите длину сторон треугольника (a, b, c)");
        double a = Convert.ToDouble(Console.ReadLine());

        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());

        double p = (a + b + c) / 2;

        double S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

        double ha = (2 * S) / a;
        double hb = (2 * S) / b;
        double hc = (2 * S) / c;

        Console.WriteLine($"\nПлощадь треугольника: {S:F2} см²");
        Console.WriteLine($"\nВысота a: {ha:F2}");
        Console.WriteLine($"Высота b: {hb:F2}");
        Console.WriteLine($"Высота c: {hc:F2}");

        Console.WriteLine("\nНажмите Enter для перехода к следующему заданию...");
        Console.ReadKey();

        Console.WriteLine("\n ---=== Задание 1.2 ===---");

        Console.WriteLine("\nВведите сумму кредита, срок выплаты (в годах) и процентную ставку");
        double S0 = Convert.ToDouble(Console.ReadLine());
        double N = Convert.ToDouble(Console.ReadLine());
        double P = Convert.ToDouble(Console.ReadLine());

        double monthlyRate = P / 100 / 12;

        double totalMonths = N * 12;

        double Vp = S0 * monthlyRate * Math.Pow(1 + monthlyRate, totalMonths) /
            (Math.Pow(1 + monthlyRate, totalMonths) - 1);

        Console.WriteLine($"\nСумма кредита: {S0} руб");
        Console.WriteLine($"Срок: {N} год/лет");
        Console.WriteLine($"Процентная ставка: {P}%");
        Console.WriteLine($"Ежемесячный платёж: {Vp:F2} руб");
        Console.WriteLine($"Общая сумма выплат: {Vp * totalMonths:F2} руб");

        Console.WriteLine("\nНажмите Enter для перехода к следующему заданию, я выбрал вариант 1 =)...");
        Console.ReadKey();

        Console.Write("\nВведите радиус шара R: ");
        double R = Convert.ToDouble(Console.ReadLine());

        double V = (4.0 / 3.0) * Math.PI * Math.Pow(R, 3);

        Console.WriteLine($"Объём шара: {V:F2} куб. ед.");
        Console.ReadKey();
    }
}