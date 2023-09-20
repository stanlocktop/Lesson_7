
//1) Потрібно додати до масиву елемент на початок. 

//Масив заповнити рандомними числами. Той елемент, що потрібно додати, також взяти рандомно.  Зробити методи, які в якості параметру приймають масив (вивід на екран, заповнення масиву елементами, додавання елементу на початок).
class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        int[] array = new int[5]; 
        ArrayRandomNumbers(array); // Метод заповнення масиву випадковими числами
        OutputArray(array); // Метод виведення масиву 
        int numberToAdd = GenerateRandomNumber(); //Метод генерації випадкового числа, яке будемо додавати на початок масиву
        AddNumberToStart(array, numberToAdd); // Метод додавання елементу на початок масиву
        OutputArray(array); // Виведення фінального масиву
    }
    static void ArrayRandomNumbers(int[] array)
    {
        Random random = new Random();
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 11); 
        }
    }
    static void OutputArray(int[] array)
    {
        Console.ForegroundColor = ConsoleColor.Blue; // устанавливаем цвет
        Console.WriteLine("Масив: ");
        Console.ResetColor(); // сбрасываем в стандартный
        foreach (int number in array)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
    static int GenerateRandomNumber()
    {
        Random random = new Random();
        return random.Next(1, 11); 
    }
    static void AddNumberToStart(int[] array, int element)
    {
        int[] newArray = new int[array.Length + 1];
        newArray[0] = element;
        Array.Copy(array, 0, newArray, 1, array.Length);
        Array.Copy(newArray, array, array.Length);
        Console.ReadKey();
    }
}
