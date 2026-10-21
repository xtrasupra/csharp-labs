using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Лабораторная работа 12 ===");
            Console.WriteLine("Выберите вариант от 1-го до 5-го");
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
                Console.WriteLine("Выход из программы");
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
                case 4:
                    Variant4();
                    break;
                case 5:
                    Variant5();
                    break;

                default:
                    Console.WriteLine("Неверный выбор! Допустимые значения: 0-5");
                    Console.WriteLine("Нажмите любую клавишу...");
                    Console.ReadKey();
                    break;
            }

            if (choice >= 1 && choice <= 5)
            {
                Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
                Console.ReadKey();
            }
        }
    }
    static void Variant1()
    {
        Console.WriteLine("\n=> [Практическая работа] Основные операции с типом string");
        string firstName = "Николай";
        Console.WriteLine("Имя: {0} ", firstName);
        Console.WriteLine("Имя содержит {0} символов.", firstName.Length);
        Console.WriteLine("Имя, записанное на верхнем регистре: " + firstName.ToUpper());
        Console.WriteLine("Имя, записанное на нижнем регистре: {0} ", firstName.ToLower());
        Console.WriteLine("Есть ли в имени буква й?:  {0} ", firstName.Contains("й"));
        Console.WriteLine("Имя после замены символов: {0} ", firstName.Replace("ай", "я"));
        Console.WriteLine("Для продолжения нажмите любой символ > ");
    }

    static void Variant2()
    {
        string boolean = "Булево";
        Console.WriteLine("\n=> 12.1 Дано слово 'Булево'. Вывести на экран его третий символ.");
        Console.WriteLine("Третий символ: {0}", boolean[2]);
    }

    static void Variant3()
    {
        string boolean = "Булево";
        char lastText = boolean.Last();
        Console.WriteLine("\n=> 12.2 Дано слово 'Булево'. Вывести на экран его последний символ.");
        Console.WriteLine("Последний символ: {0}", lastText);
    }

    static void Variant4()
    {
        Console.WriteLine("\n=> 12.4 Дано слово 'Булево'. Проверить второй и четвёртый символы.");
        string word = "Булево";

        if (word.Length >= 4)
        {
            char secondChar = word[1];
            char fourthChar = word[3];

            if (secondChar == fourthChar)
            {
                Console.WriteLine("Второй и четвёртый символы одинаковы: '{0}'", secondChar);
            }
            else
            {
                Console.WriteLine("Второй и четвёртый символы разные: '{0}' и '{1}'", secondChar, fourthChar);
            }
        }
        else
        {
            Console.WriteLine("В слове меньше четырёх символов, проверка невозможна.");
        }
    }

    static void Variant5()
    {
        Console.WriteLine("\n=> 12.5 Дано слово 'Булево'. Верно ли, что оно начинается и оканчивается на одну и ту же букву?");
        string word = "Булево";

        if (word.Length >= 1)
        {
            char firstChar = word[0];
            char lastChar = word[word.Length - 1];

            if (firstChar == lastChar)
            {
                Console.WriteLine("Первый и последний символ одинаковы: '{0}'", firstChar);
            }
            else
            {
                Console.WriteLine("Первый и последний символы разные: '{0}' и '{1}'", firstChar, lastChar);
            }
        }
        else
        {
            Console.WriteLine("Слово пустое, проверка невозможна.");
        }
    }
}
