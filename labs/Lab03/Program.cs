using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите данные R");
        double R = Convert.ToDouble(Console.ReadLine());
        double L = 2 * Math.PI * R;
        Console.WriteLine($"\nДолгота окружности: {L}");

        Console.WriteLine("Enter/return далее...\n");
        Console.ReadKey();

        //--------------------------------------------------------------------------------

        Console.WriteLine("Введите число: a"); // 4.1 --
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nВведите число: b");
        double b = Convert.ToDouble(Console.ReadLine());

        double a1 = a * a + b * b;
        double b1 = (a * a) + (b * b);

        Console.WriteLine($"\nСумма квадратов: {a1}");
        Console.WriteLine($"Произведение квадратов: {b1}\n");

        Console.WriteLine("Enter/return далее...\n");
        Console.ReadKey(); // 4.1 ---

        Console.WriteLine("Введите длину окружности L2"); // 4.2

        double L2 = Convert.ToDouble(Console.ReadLine());

        double R2 = L2 / (2 * Math.PI);
        double S2 = Math.PI * R * R;

        Console.WriteLine($"\nРадиус: {R2} едениц");
        Console.WriteLine($"Радиус: {S2} кв. едениц\n");

        Console.WriteLine("Enter/return далее...\n");
        Console.ReadKey(); // 4.2

        Console.WriteLine($"Введите длину в дюймах"); // 4.3
        double inch = Convert.ToDouble(Console.ReadLine());

        const double inchCM = 2.54;
        double cm = inch * inchCM;
        double m = cm / 100;
        double mm = cm * 10;

        Console.WriteLine($"\n{inch} дюймов = {m}м");
        Console.WriteLine($"{inch} дюймов = {cm}см");
        Console.WriteLine($"{inch} дюймов = {mm}мм\n");

        Console.WriteLine("Enter/return далее...\n");
        Console.ReadKey(); // 4.3

        Console.WriteLine($"Введите скорость Вашего космического корабля"); // 4.4
        double SPEET_STAR_SHIP = Convert.ToDouble(Console.ReadLine());
        double LIGHT_YEAR_KM = 9.461e12;

        double distanceLY = 4.3;
        double distanceKM = distanceLY * LIGHT_YEAR_KM;

        double timeSeconds = distanceKM / SPEET_STAR_SHIP;

        double secondsInYear = 60 * 60 * 24 * 365.25;
        double timeYears = timeSeconds / secondsInYear;

        Console.WriteLine($"\nВремя полёта: {timeYears} лет");

        Console.WriteLine("\nEnter/return далее...");
        Console.ReadKey(); // 4.4

        Console.WriteLine("\nВведите по очереди начало интервала (часы, минуты, секунды):"); // 4.5
        int h1 = Convert.ToInt32(Console.ReadLine());
        int m1 = Convert.ToInt32(Console.ReadLine());
        int s1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nВведите по очереди конец интервала (часы, минуты, секунды):");
        int h2 = Convert.ToInt32(Console.ReadLine());
        int m2 = Convert.ToInt32(Console.ReadLine());
        int s2 = Convert.ToInt32(Console.ReadLine());

        int totalSeconds1 = h1 * 3600 + m1 * 60 + s1;
        int totalSeconds2 = h2 * 3600 + m2 * 60 + s2;

        int diffSeconds = totalSeconds2 - totalSeconds1;


        if (diffSeconds < 0)
        {
            Console.WriteLine("\nКонец интервала раньше начала!");
            return;
        }

        int hours = diffSeconds / 3600;
        int minutes = (diffSeconds % 3600) / 60;
        int seconds = diffSeconds % 60;

        Console.WriteLine($"\nИнтервал: {hours} ч {minutes} мин {seconds} с");

        Console.WriteLine("\nEnter/return далее...");
        Console.ReadKey(); // 4.5

        Console.WriteLine("Введите угол по очереди (градусы, минуты, секунды):"); // 4.6
        int degrees = Convert.ToInt32(Console.ReadLine());
        int minutes2 = Convert.ToInt32(Console.ReadLine());
        int seconds2 = Convert.ToInt32(Console.ReadLine());

        double totalDegrees = degrees + minutes2 / 60.0 + seconds2 / 3600.0;

        double radians = totalDegrees * Math.PI / 180.0;

        Console.WriteLine($"\nУгол в радианах: {radians:F6}");

        Console.WriteLine("\nEnter/return далее...");
        Console.ReadKey(); // 4.6

        Console.Write("\nВведите угол в радианах: "); // 4.7

        double radians2 = Convert.ToDouble(Console.ReadLine());
        double degrees2 = radians2 * 180.0 / Math.PI;
        int deg = (int)degrees;
        double remainder = (degrees2 - deg) * 60;
        int min = (int)remainder;
        double sec = (remainder - min) * 60;

        Console.WriteLine($"\nУгол: {deg}° {min}' {sec:F2}"); // 4.7
    }
}