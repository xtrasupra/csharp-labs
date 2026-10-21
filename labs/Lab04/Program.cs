using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите номер месяца: ");
        string buf = Console.ReadLine();
        string a2;

        switch (buf)
        {
            case "1": a2 = "Зима"; break;
            case "2": a2 = "Зима"; break;
            case "3": a2 = "Весна"; break;
            case "4": a2 = "Весна"; break;
            case "5": a2 = "Весна"; break;
            case "6": a2 = "Лето"; break;
            case "7": a2 = "Лето"; break;
            case "8": a2 = "Лето"; break;
            case "9": a2 = "Осень"; break;
            case "10": a2 = "Осень"; break;
            case "11": a2 = "Осень"; break;
            case "12": a2 = "Зима"; break;
            default: a2 = "Неправильный месяц"; break;
        }

        Console.WriteLine($"\nРезультат: {a2}");

        Console.WriteLine("\nEnter/return далее...");
        Console.ReadKey();

        Console.WriteLine("\nВведите число А=");
        int a1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nВведите число B=");
        int b1 = Convert.ToInt32(Console.ReadLine());


        if (a1 == b1)
        {
            Console.WriteLine("\nЧисла равны");
        }
        else
        {
            Console.WriteLine("\nЧисла не равны");
        }

        Console.WriteLine("\nEnter/return далее...");
        Console.ReadKey();

        Console.WriteLine("\nВведите число R"); // 4.1
        double R = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\nВведите число F");
        double F = Convert.ToDouble(Console.ReadLine()); ; ;
        if (R > F)
            Console.WriteLine("\nЧисло R больше числа F");
        else if (F > R)
            Console.WriteLine("\nЧисло F больше числа R");
        else
            Console.WriteLine("\nЧисла равны");

        Console.WriteLine("\nEnter/return далее...");
        Console.ReadKey(); // 4.1

        Console.WriteLine("\nВведите целое число: "); // 4.2
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 3 == 0)
            Console.WriteLine("\nЧисло кратно 0");
        else
            Console.WriteLine("\nЧисло не кратно 3");

        Console.WriteLine("\nEnter/return далее...");
        Console.ReadKey(); // 4.2

        Console.WriteLine("\nВведите оценку от 1 до 5"); // 4.3
        int grade = Convert.ToInt32(Console.ReadLine());

        switch (grade)
        {
            case 1:
            case 2:
                Console.WriteLine("\nНеудовлетворительно");
                break;
            case 3:
                Console.WriteLine("\nУдовлетворительно");
                break;
            case 4:
                Console.WriteLine("\nХорошо");
                break;
            case 5:
                Console.WriteLine("\nОтлично");
                break;
            default:
                Console.WriteLine("\nОшибка: оценка должна быть от 1 до 5");
                break;
        }

        Console.WriteLine("\nEnter/return далее...");
        Console.ReadKey(); // 4.3

        Console.Write("\nВведите коэффициент K: "); // 4.4
        double K = Convert.ToDouble(Console.ReadLine());

        Console.Write("\nВведите коэффициент B: ");
        double B = Convert.ToDouble(Console.ReadLine());

        Console.Write("\nВведите координату X точки: ");
        double X = Convert.ToDouble(Console.ReadLine());
        Console.Write("\nВведите координату Y точки: ");
        double Y = Convert.ToDouble(Console.ReadLine());

        double lineY = K * X + B;

        if (Y > lineY)
            Console.WriteLine("\nТочка выше прямой");
        else if (Y < lineY)
            Console.WriteLine("\nТочка ниже прямой");
        else
            Console.WriteLine("\nТочка лежит на прямой");

        Console.WriteLine("\nEnter/return далее...");
        Console.ReadKey(); // 4.4

        Console.Write("\nВведите коэффициент a: "); // 4.5
        double a = Convert.ToDouble(Console.ReadLine());
        Console.Write("\nВведите коэффициент b: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.Write("\nВведите коэффициент c: ");
        double c = Convert.ToDouble(Console.ReadLine());


        double discriminant = b * b - 4 * a * c;

        if (discriminant < 0)
        {
            Console.WriteLine("\nНЕТ КОРНЕЙ!");
        }
        else if (discriminant == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"\nОдин корень: x = {x:F3}");
        }
        else
        {
            double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double x2 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine($"Два корня: x1 = {x1:F3}, x2 = {x2:F3}"); // 4.5
        }
    }
}