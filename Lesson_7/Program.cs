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
            if (!TryGetDoubleNumber(out oper1))
            {
                Console.WriteLine("Помилка: Введено некоректне число.");
                return;
            }

            Console.Write("Введіть другий операнд: ");
            if (!TryGetDoubleNumber(out oper2))
            {
                Console.WriteLine("Помилка: Введено некоректне число.");
                return;
            }

            Console.WriteLine("Введіть операцію: ");
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
            Console.WriteLine("{0} {1} {2} = {3}", oper1, GetOperationSymbol(operation), oper2, result);
        }

        static bool TryGetOperation(out Operation operation)
        {
            int operationNumber;
            if (int.TryParse(Console.ReadLine(), out operationNumber))
            {
                operation = (Operation)operationNumber;
                return operation >= Operation.Add && operation <= Operation.Divide;
            }
            else
            {
                operation = Operation.None;
                return false;
            }
        }

        static bool TryGetDoubleNumber(out double number)
        {
            return double.TryParse(Console.ReadLine(), out number);
        }

        // Решта коду без змін.
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
