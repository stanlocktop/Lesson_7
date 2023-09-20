using System;
using System.Linq;
//3) Написати програму створення масиву із двох масивів. У підсумковому масиві мають бути елементи першого та другого масиву

public static class Extension
{
    public static T[] Concatenate<T>(this T[] first, T[] second)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        if (first == null)
        {
            return second;
        }
        if (second == null)
        {
            return first;
        }

        return first.Concat(second).ToArray();
    }
}
public class Example
{
    public static void Main()
    {
        int[] first = { 1, 2, 3, 4, 5, };
        int[] second = { 6, 7, 8, 9, 10 };
        int[] result = first.Concatenate(second);
        Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
        Console.WriteLine("Результат зливання першого та другого масивів: ");
        Console.WriteLine(String.Join(",", result));
        Console.ResetColor(); // сбрасываем в стандартный
        Console.ReadKey();
    }
}


