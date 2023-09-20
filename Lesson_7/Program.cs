using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            double oper1, oper2, result;
            Operation operation;

            Console.Write("Введіть перший операнд: ");
            oper1 = GetDoubleNumber();
            Console.Write("Введіть другий операнд: ");
            oper2 = GetDoubleNumber();
            Console.WriteLine("Введіть операцію: ");
            Console.WriteLine("1 - Додавання");
            Console.WriteLine("2 - Віднімання");
            Console.WriteLine("3 - Множення");
            Console.WriteLine("4 - Ділення");
            operation = GetOperation();

            result = DoOperation(oper1, oper2, operation);
            Console.WriteLine("{0} {1} {2} = {3}", oper1, GetOperationSymbol(operation), oper2, result);
        }

        static Operation GetOperation()
        {
            Operation operation;
            do
            {
                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input))
                {
                    input = "5"; // Встановлюємо значення за замовчуванням на випадок пустого вводу.
                }
                operation = (Operation)System.Enum.Parse(typeof(Operation), input);
            }
            while (operation < Operation.Add || operation > Operation.Divide || operation == Operation.None);
            return operation;
        }

        static double GetDoubleNumber()
        {
            double number;
            bool resParse = false;
            do
            {
                string input = Console.ReadLine();
                resParse = double.TryParse(input, out number);
            }
            while (!resParse);
            return number;
        }

        static double DoOperation(double oper1, double oper2, Operation operation)
        {
            double result;
            switch (operation)
            {
                case Operation.Add:
                    result = oper1 + oper2;
                    break;
                case Operation.Subtract:
                    result = oper1 - oper2;
                    break;
                case Operation.Multiply:
                    result = oper1 * oper2;
                    break;
                case Operation.Divide:
                    if (oper2 != 0) // Перевірка на ділення на нуль.
                    {
                        result = oper1 / oper2;
                    }
                    else
                    {
                        Console.WriteLine("Помилка: Ділення на нуль.");
                        result = double.NaN; // Повертає "не число" у разі помилки.
                    }
                    break;
                default:
                    throw new ArgumentException("Невідома операція");
            }
            return result;
        }

        static string GetOperationSymbol(Operation operation)
        {
            // Функція для отримання символу операції для виводу.
            switch (operation)
            {
                case Operation.Add:
                    return "+";
                case Operation.Subtract:
                    return "-";
                case Operation.Multiply:
                    return "*";
                case Operation.Divide:
                    return "/";
                default:
                    return "";
            }
        }
    }
}

namespace Enum
{
    enum Operation
    {
        Add = 1,
        Subtract = 2,
        Multiply = 3,
        Divide = 4,
        None,
    }
}
