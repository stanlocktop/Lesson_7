using System;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        int[] numbers = {0, 1, 2, 3, 4, 5, 6, 7, 8, 10, 11 };
        Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
        Console.WriteLine("Першоначальний вигляд масиву: ");
        Console.WriteLine(String.Join(",", numbers));
        Console.ResetColor(); // сбрасываем в стандартный
        Console.ForegroundColor = ConsoleColor.Magenta; // устанавливаем цвет
        Console.WriteLine("Введіть позицію для видалення елементу в масиві від 0 до {0}:", numbers.Length - 1);
        int position = int.Parse(Console.ReadLine());
        Console.ResetColor(); // сбрасываем в стандартный
        if (position >= 0 && position < numbers.Length)
        {
            for (int i = position; i < numbers.Length - 1; i++)
            {
                numbers[i] = numbers[i + 1];
            }
            Array.Resize(ref numbers, numbers.Length - 1);
            Console.ForegroundColor = ConsoleColor.Yellow; // устанавливаем цвет
            Console.WriteLine("Елемент на позиції {0} був видалений! ^_^ ", position);
            Console.ResetColor(); // сбрасываем в стандартный
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
            Console.WriteLine("Немає такої позиції!");
            Console.ResetColor(); // сбрасываем в стандартный
        }
        Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
        Console.WriteLine("Оновлений масив: ");
        Console.ResetColor(); // сбрасываем в стандартный
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        Console.ReadKey();
    }
}
