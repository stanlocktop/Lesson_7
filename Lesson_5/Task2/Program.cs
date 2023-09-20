
//2) Написати програму, яка виводить всі елементи масиву доки не зустрінеться елемент -1.
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Random random = new Random();
        int[] array = new int[100];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(-11, 11);
        }
        Console.ForegroundColor = ConsoleColor.Green; // устанавливаем цвет
        Console.WriteLine("Виводимо елементи масиву, до моменту коли не зустрінемо -1: ");
        Console.ResetColor(); // сбрасываем в стандартный
        Console.ForegroundColor = ConsoleColor.Blue; // устанавливаем цвет
        foreach (int number in array)
        {
            if (number == -1)
                break; 
            Console.Write(number + " ");
        }
        Console.ResetColor(); // сбрасываем в стандартный
        Console.ReadKey();
    }
}
   