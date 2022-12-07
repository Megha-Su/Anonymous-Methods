using System;

namespace Anonymous_method_Func_
{
    class Program
    {
        static void Main(string[] args)
        {

            Func<int, int, int> Add = delegate (int firstNumber, int secondNumber)
            {
                return firstNumber + secondNumber;
            };
            Func<int, int, int> Subtract = delegate (int firstNumber, int secondNumber)
            {
                return firstNumber - secondNumber;
            };
            Func<int, int, int> Multipliation = delegate (int firstNumber, int secondNumber)
            {
                return firstNumber * secondNumber;
            };
            Func<int, int, int> Division= delegate (int firstNumber, int secondNumber)
            {
                return firstNumber / secondNumber;
            };

            Calculator(Add, 10, 2);
            Calculator(Subtract, 10, 2);
            Calculator(Multipliation, 10, 3);
            Calculator(Division, 10, 5);
        }

        static void Calculator(Func<int, int, int> operation, int firstNumber, int secondNumber)
        {
          Console.WriteLine (operation(firstNumber, secondNumber));
        }

    }
}
