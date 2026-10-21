using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Меню задач ===");
            Console.WriteLine("1.  Умножение через сложение");
            Console.WriteLine("2.  Перевернуть пятизначное число");
            Console.WriteLine("3.  Вычислить сложное выражение");
            Console.WriteLine("4.  Квадрат через сумму нечетных");
            Console.WriteLine("5.  Сумма квадратов чисел");
            Console.WriteLine("6.  Найти куб числа");
            Console.WriteLine("7.  Сумма цифр шестизначного числа");
            Console.WriteLine("8.  Сумма ряда с чередованием знаков");
            Console.WriteLine("9.  Вычислить угол наклона");
            Console.WriteLine("10. Поиск неподвижной точки");
            Console.WriteLine("11. Числа Фибоначчи");
            Console.WriteLine("12. Вычисление функций через ряды");
            Console.WriteLine("13. Вклад в банке");
            Console.WriteLine("14. Разрезание прямоугольника на квадраты");
            Console.WriteLine("0.  Выход");
            Console.Write("\nВыберите задачу (0-14): ");

            string choice = Console.ReadLine();

            if (choice == "0")
            {
                Console.WriteLine("Выход из программы.");
                break;
            }

            switch (choice)
            {
                case "1": Task81(); break;
                case "2": Task82(); break;
                case "3": Task83(); break;
                case "4": Task84(); break;
                case "5": Task85(); break;
                case "6": Task86(); break;
                case "7": Task87(); break;
                case "8": Task88(); break;
                case "9": Task89(); break;
                case "10": Task810(); break;
                case "11": Task811(); break;
                case "12": Task812(); break;
                case "13": Task813(); break;
                case "14": Task814(); break;
                default: Console.WriteLine("Неверный выбор!"); break;
            }

            Console.WriteLine("\nНажмите Enter для продолжения...");
            Console.ReadLine();
        }
    }

    static void Task81()
    {
        Console.Write("Введите первое число: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите второе число: ");
        int b = int.Parse(Console.ReadLine());

        int result = 0;
        for (int i = 0; i < Math.Abs(b); i++)
            result += a;

        Console.WriteLine($"{a} × {b} = {result}");
    }

    static void Task82()
    {
        Console.Write("Введите пятизначное число: ");
        int num = int.Parse(Console.ReadLine());

        if (num < 10000 || num > 99999)
        {
            Console.WriteLine("Не пятизначное число!");
            return;
        }

        int reversed = 0;
        while (num > 0)
        {
            reversed = reversed * 10 + num % 10;
            num /= 10;
        }
        Console.WriteLine($"Перевернутое: {reversed}");
    }

    static void Task83()
    {
        double result = Math.Pow(1.0 / (20 * 20) - 1.0 / (19 * 19), 2);
        result = Math.Pow(1.0 / (18 * 18), 2);

        for (int i = 17; i >= 1; i--)
            result -= Math.Pow(1.0 / (i * i), 2);

        Console.WriteLine($"Результат: {result:F6}");
    }

    static void Task84()
    {
        Console.Write("Введите число: ");
        int n = int.Parse(Console.ReadLine());

        int sum = 0, odd = 1;
        for (int i = 0; i < n; i++)
        {
            sum += odd;
            odd += 2;
        }
        Console.WriteLine($"{n}² = {sum}");
    }

    static void Task85()
    {
        int total = 0;
        for (int i = 1; i <= 10; i++)
            total += i * i;

        Console.WriteLine($"Сумма квадратов (1..10) = {total}");
    }

    static void Task86()
    {
        Console.Write("Введите число: ");
        int n = int.Parse(Console.ReadLine());

        long cube = 1;
        for (int i = 1; i < n; i++)
            cube += n * n;

        Console.WriteLine($"{n}³ = {cube}");
    }

    static void Task87()
    {
        Console.Write("Введите шестизначное число: ");
        string input = Console.ReadLine();

        if (input.Length != 6 || !int.TryParse(input, out _))
        {
            Console.WriteLine("Не шестизначное число!");
            return;
        }

        int sum = 0;
        foreach (char c in input)
            sum += c - '0';

        Console.WriteLine($"Сумма цифр: {sum}");
    }

    static void Task88()
    {
        Console.Write("Введите N: ");
        int n = int.Parse(Console.ReadLine());

        int sum = 0;
        for (int i = 1; i <= n; i++)
            sum += (i % 2 == 1 ? 1 : -1) * i * i;

        Console.WriteLine($"Сумма ряда: {sum}");
    }

    static void Task89()
    {
        double length = 4.5;
        Console.WriteLine("x (м)\tУгол (град)");
        Console.WriteLine("-----------------");

        for (double x = 3.0; x <= 4.5; x += 0.2)
        {
            double angle = Math.Acos(x / length) * 180 / Math.PI;
            Console.WriteLine($"{x:F1}\t{angle:F2}");
        }
    }

    static void Task810()
    {
        double a = 1.0;
        for (int i = 0; i < 10; i++)
        {
            a = 1 + 1 / a;
            Console.WriteLine($"Шаг {i + 1}: {a:F6}");
        }

        double phi = (1 + Math.Sqrt(5)) / 2;
        Console.WriteLine($"Золотое сечение: {phi:F6}");
    }

    static void FibonacciNumbers()
    {
        Console.WriteLine("\n=== Работа с числами Фибоначчи ===");
        Console.WriteLine("1. Найти первое число Фибоначчи большее n");
        Console.WriteLine("2. Найти все числа Фибоначчи сумма которых меньше пятизначного числа");
        Console.Write("Выберите подзадачу (1 или 2): ");

        string subChoice = Console.ReadLine();

        if (subChoice == "1")
        {
            FindFirstFibonacciGreaterThanN();
        }
        else if (subChoice == "2")
        {
            Task811();
        }
        else
        {
            Console.WriteLine("Неверный выбор!");
        }
    }

    static void FindFirstFibonacciGreaterThanN()
    {
        Console.Write("Введите число n (n > 1): ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n <= 1)
        {
            Console.WriteLine("Ошибка: n должно быть целым числом больше 1!");
            return;
        }

        int a = 1, b = 1, next;
        int position = 2;
        while (true)
        {
            next = a + b;
            position++;

            if (next > n)
            {
                Console.WriteLine($"Первое число Фибоначчи большее {n}: {next}");
                Console.WriteLine($"Его порядковый номер: {position}");
                Console.WriteLine($"Предыдущие числа: 1, 1, ..., {b}");
                break;
            }

            a = b;
            b = next;
        }
    }

    static void Task811()
    {
        Console.Write("Введите пятизначное число n: ");
        if (!int.TryParse(Console.ReadLine(), out int n) || n < 10000 || n > 99999)
        {
            Console.WriteLine("Ошибка: n должно быть пятизначным числом (от 10000 до 99999)!");
            return;
        }

        int a = 1, b = 1, next;
        int sum = a + b;
        string sequence = "1, 1";

        Console.WriteLine($"\nНаходим числа Фибоначчи, сумма которых меньше {n}:");
        Console.WriteLine($"Начальные числа: 1, 1");
        Console.WriteLine($"Текущая сумма: {sum}");

        while (true)
        {
            next = a + b;

            if (sum + next >= n)
            {
                Console.WriteLine($"\nСледующее число Фибоначчи: {next}");
                Console.WriteLine($"Если добавить {next}, сумма станет: {sum + next} (что >= {n})");
                Console.WriteLine($"Останавливаемся.");
                break;
            }

            sum += next;
            sequence += $", {next}";

            Console.WriteLine($"Добавляем {next}, новая сумма: {sum}");

            a = b;
            b = next;
        }

        Console.WriteLine($"\nИтоговые числа Фибоначчи: {sequence}");
        Console.WriteLine($"Их сумма: {sum} (меньше {n})");
        Console.WriteLine($"Количество чисел: {sequence.Split(',').Length}");
    }
    static void Task812()
    {
        Console.WriteLine("\n=== Вычисление функций через ряды ===");
        Console.WriteLine("1. e^x");
        Console.WriteLine("2. cos(x)");
        Console.WriteLine("3. arctg(x)");
        Console.Write("Выберите функцию (1-3): ");

        string funcChoice = Console.ReadLine();

        Console.Write("Введите x: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Введите точность ε (например, 0.0001): ");
        double epsilon = double.Parse(Console.ReadLine());

        switch (funcChoice)
        {
            case "1":
                CalculateExp(x, epsilon);
                break;
            case "2":
                CalculateCos(x, epsilon);
                break;
            case "3":
                CalculateArctg(x, epsilon);
                break;
            default:
                Console.WriteLine("Неверный выбор функции!");
                break;
        }
    }

    static void CalculateExp(double x, double epsilon)
    {
        double result = 1.0;
        double term = 1.0;
        int n = 1;

        Console.WriteLine("\nВычисление e^x:");
        Console.WriteLine($"x = {x}, ε = {epsilon}");
        Console.WriteLine("Текущий член ряда: 1");

        while (Math.Abs(term) >= epsilon)
        {
            term = term * x / n;
            result += term;

            Console.WriteLine($"Член {n}: {term:F8}, Сумма: {result:F8}");

            n++;

            if (n > 1000) break;
        }

        Console.WriteLine($"\nРезультат: e^{x} ≈ {result:F8}");
        Console.WriteLine($"Стандартная функция: Math.Exp({x}) = {Math.Exp(x):F8}");
        Console.WriteLine($"Разница: {Math.Abs(result - Math.Exp(x)):E2}");
    }

    static void CalculateCos(double x, double epsilon)
    {
        double result = 1.0;
        double term = 1.0;
        int n = 1;
        int sign = -1;

        Console.WriteLine("\nВычисление cos(x):");
        Console.WriteLine($"x = {x}, ε = {epsilon}");
        Console.WriteLine("Текущий член ряда: 1");

        n = 2;

        while (Math.Abs(term) >= epsilon)
        {
            long factorial = 1;
            for (int i = 1; i <= n; i++)
                factorial *= i;

            term = sign * Math.Pow(x, n) / factorial;
            result += term;

            Console.WriteLine($"Член x^{n}/{n}! = {term:F8}, Сумма: {result:F8}");

            n += 2;
            sign = -sign;
            if (n > 100) break;
        }

        Console.WriteLine($"\nРезультат: cos({x}) ≈ {result:F8}");
        Console.WriteLine($"Стандартная функция: Math.Cos({x}) = {Math.Cos(x):F8}");
        Console.WriteLine($"Разница: {Math.Abs(result - Math.Cos(x)):E2}");
    }

    static void CalculateArctg(double x, double epsilon)
    {
        if (Math.Abs(x) > 1)
        {
            Console.WriteLine("Внимание: ряд для arctg(x) сходится только при |x| <= 1");
            Console.WriteLine("Используем преобразование для |x| > 1");
        }

        double result = x;
        double term = x;
        int n = 1;

        Console.WriteLine("\nВычисление arctg(x):");
        Console.WriteLine($"x = {x}, ε = {epsilon}");
        Console.WriteLine("Текущий член ряда: x");

        while (Math.Abs(term) >= epsilon)
        {
            n += 2;
            int sign = ((n - 1) / 2) % 2 == 0 ? 1 : -1;

            term = sign * Math.Pow(x, n) / n;
            result += term;

            Console.WriteLine($"Член {sign}*x^{n}/{n} = {term:F8}, Сумма: {result:F8}");

            if (n > 100) break;
        }

        Console.WriteLine($"\nРезультат: arctg({x}) ≈ {result:F8}");
        Console.WriteLine($"Стандартная функция: Math.Atan({x}) = {Math.Atan(x):F8}");
        Console.WriteLine($"Разница: {Math.Abs(result - Math.Atan(x)):E2}");
    }
    static void Task813()
    {
        Console.WriteLine("\n=== Расчет вклада в банке ===");

        double deposit = 1000.0;
        double interestRate = 0.02;
        int month = 0;

        bool found30 = false;
        bool found1200 = false;
        int month30 = 0;
        int month1200 = 0;

        Console.WriteLine($"Начальный вклад (1 марта): {deposit:F2} руб.");

        while (!found30 || !found1200)
        {
            month++;
            double increase = deposit * interestRate;
            deposit += increase;

            Console.WriteLine($"\nМесяц {month}:");
            Console.WriteLine($"  Вклад: {deposit:F2} руб.");
            Console.WriteLine($"  Увеличение за месяц: {increase:F2} руб.");

            if (!found30 && increase > 30.0)
            {
                month30 = month;
                found30 = true;
                Console.WriteLine($"  ✓ Увеличение превысило 30 руб!");
            }

            if (!found1200 && deposit > 1200.0)
            {
                month1200 = month;
                found1200 = true;
                Console.WriteLine($"  ✓ Вклад превысил 1200 руб!");
            }

            if (month > 100) break;
        }
        string GetMonthName(int m)
        {
            string[] months = { "март", "апрель", "май", "июнь", "июль", "август",
                           "сентябрь", "октябрь", "ноябрь", "декабрь", "январь", "февраль" };
            int yearOffset = 0;

            while (m > 12)
            {
                m -= 12;
                yearOffset++;
            }

            string yearText = yearOffset > 0 ? $" {yearOffset + 2024} года" : "";
            return months[m - 1] + yearText;
        }

        Console.WriteLine("\n=== Результаты ===");
        Console.WriteLine($"Увеличение вклада превысит 30 руб в {GetMonthName(month30)} (через {month30} месяцев)");
        Console.WriteLine($"Сумма вклада превысит 1200 руб в {GetMonthName(month1200)} (через {month1200} месяцев)");
        Console.WriteLine($"Финальный размер вклада: {deposit:F2} руб.");
    }
    static void Task814()
    {
        Console.WriteLine("\n=== Разрезание прямоугольника на квадраты ===");

        int width = 425;
        int height = 131;

        Console.WriteLine($"Исходный прямоугольник: {width} x {height}");
        Console.WriteLine("\nПроцесс разрезания:");

        List<(int size, int count)> squares = new List<(int, int)>();
        int step = 1;

        while (width > 0 && height > 0)
        {
            int squareSize = Math.Min(width, height);
            int count;
            if (width >= height)
            {
                count = width / height;
                width = width % height;
            }
            else
            {
                count = height / width;
                height = height % width;
            }

            squares.Add((squareSize, count));

            Console.WriteLine($"Шаг {step}: Квадрат {squareSize}x{squareSize} - {count} шт.");
            if (width > 0 && height > 0)
            {
                Console.WriteLine($"  Остался прямоугольник: {width} x {height}");
            }

            step++;
        }

        Console.WriteLine("\n=== Итог ===");
        Console.WriteLine($"Всего квадратов: {squares.Sum(s => s.count)}");
        Console.WriteLine("Размеры квадратов:");

        int totalSquares = 0;
        foreach (var square in squares)
        {
            Console.WriteLine($"  {square.size}x{square.size} - {square.count} шт.");
            totalSquares += square.count;
        }

        Console.WriteLine($"\nПроверка площади:");
        int totalArea = 0;
        foreach (var square in squares)
        {
            int area = square.size * square.size * square.count;
            totalArea += area;
            Console.WriteLine($"  {square.count} × ({square.size}×{square.size}) = {area}");
        }
        Console.WriteLine($"Общая площадь: {totalArea}");
        Console.WriteLine($"Площадь исходного: {425 * 131} = {425 * 131}");
        Console.WriteLine($"Совпадает: {totalArea == 425 * 131}");
    }
}