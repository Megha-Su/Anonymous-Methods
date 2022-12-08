using System;

namespace Anonymous_method_Func_
{
    class Program
    {
        static void Main(string[] args)
        {

            Func<int, int, int> add = delegate (int firstNumber, int secondNumber)
            {
                return firstNumber + secondNumber;
            };
            Func<int, int, int> subtract = delegate (int firstNumber, int secondNumber)
            {
                return firstNumber - secondNumber;
            };
            Func<int, int, int> multipliation = delegate (int firstNumber, int secondNumber)
            {
                return firstNumber * secondNumber;
            };
            Func<int, int, int> division= delegate (int firstNumber, int secondNumber)
            {
                return firstNumber / secondNumber;
            };

            Calculator(add, 10, 2);
            Calculator(subtract, 10, 2);
            Calculator(multipliation, 10, 3);
            Calculator(division, 10, 5);
        }

        static void Calculator(Func<int, int, int> operation, int firstNumber, int secondNumber)
        {
          Console.WriteLine (operation(firstNumber, secondNumber));
        }

    }
}
