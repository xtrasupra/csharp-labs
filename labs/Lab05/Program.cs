using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите радиус круга R: ");
        double R = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите координату X точки: ");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите координату Y точки: ");
        double y = Convert.ToDouble(Console.ReadLine());

        bool inCircle = (x * x + y * y) <= (R * R);
        bool inSectorI = (x >= 0 && y >= 0 && y <= x);
        bool inSectorIII = (x <= 0 && y <= 0 && y <= -x);

        if (inCircle && (inSectorI || inSectorIII))
        {
            Console.WriteLine("Точка попадает в закрашенную область.");
        }
        else
        {
            Console.WriteLine("Точка не попадает в закрашенную область.");
        }

        Console.WriteLine("\nEnter/return далее...");
        Console.ReadKey();

        Console.Write("\nВведите значение x: ");
        double x1 = Convert.ToDouble(Console.ReadLine());
        double y2 = 0;

        if (x1 <= 0)
        {
            y2 = -x1 - 6;
        }
        else if (x1 > 0 && x1 <= 6)
        {
            y2 = Math.Sqrt(9 - Math.Pow(x1 - 3, 2));
        }
        else
        {
            y2 = x1 - 6;
        }

        Console.WriteLine($"y2 = {y2:F2}");
    }
}