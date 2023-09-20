using System;
//5 *) Вказано п'ять довільних цілих чисел (елементи масиву). Визначити, чи є їхнє розташування в масиві впорядкованим (тобто за зростанням або за спаданням) чи невпорядкованим.
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        {
            Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
            int[] numbers = { 3, 7, 5, 9, 4, 6, 1, -8 };
            Console.WriteLine("Вигляд масиву: ");
            Console.WriteLine(String.Join(",", numbers));
            Console.ResetColor(); // сбрасываем в стандартный
            bool isMoreArray = true;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i + 1])
                {
                    isMoreArray = false;
                    break;
                }
            }
            bool isLessArray = true;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] < numbers[i + 1])
                {
                    isLessArray = false;
                    break;
                }
            }
            Console.ForegroundColor = ConsoleColor.Yellow; // устанавливаем цвет
            Console.WriteLine();
            Console.WriteLine("Результат: ");
            if (isMoreArray)
            {
                Console.WriteLine("Масив впорядкований за зростанням.");
            }
            else if (isLessArray)
            {
                Console.WriteLine("Масив впорядкований за спаданням.");
            }
            else
            {
                Console.WriteLine("Масив невпорядкований.");
            }
            Console.ReadKey();
        }
    }
}
