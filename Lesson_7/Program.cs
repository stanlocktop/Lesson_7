using System;
using Enum1;

namespace Lesson_7
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

            Console.WriteLine("Введіть операцію:");
            Console.WriteLine("1 - Додавання");
            Console.WriteLine("2 - Віднімання");
            Console.WriteLine("3 - Множення");
            Console.WriteLine("4 - Ділення");

            if (!TryGetOperation(out operation))
            {
                Console.WriteLine("Помилка: Введено некоректну операцію.");
                return;
            }

            result = DoOperation(oper1, oper2, operation);
            Console.WriteLine("{0} {1} {2} = {3}", oper1, Operation.GetOperationSymbol(operation), oper2, result);
        }

        static bool TryGetOperation(out Operation operation)
        {
            operation = Operation.None;
            string input = Console.ReadLine();
            if (Enum.TryParse(input, out operation) && Enum.IsDefined(typeof(Operation), operation))
            {
                return true;
            }
            return false;
        }

        static double GetDoubleNumber()
        {
            double number;
            while (!double.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Помилка: Введено некоректне число. Спробуйте ще раз.");
            }
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
                    if (oper2 != 0)
                    {
                        result = oper1 / oper2;
                    }
                    else
                    {
                        Console.WriteLine("Помилка: Ділення на нуль.");
                        throw new DivideByZeroException();
                    }
                    break;
                default:
                    throw new ArgumentException();
            }
            return result;
        }
    }
}
