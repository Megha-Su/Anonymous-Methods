using System;

namespace Anonymous_Method_Action_
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int, int> sumAction = delegate (int firstNumber, int secondNumber)
            {
               Console.WriteLine(firstNumber + secondNumber);
            };
            Action<int, int> subtractAction = delegate (int firstNumber, int secondNumber)
            {
                Console.WriteLine(firstNumber - secondNumber);
            };
            Action<int, int> multipliationAction = delegate (int firstNumber, int secondNumber)
            {
                Console.WriteLine(firstNumber * secondNumber);
            };
            Action<int, int> divisionAction = delegate (int firstNumber, int secondNumber)
            {
                Console.WriteLine(firstNumber / secondNumber);
            };

            Calculator(sumAction,7, 8);
            Calculator(subtractAction, 14, 8);
            Calculator(multipliationAction, 5, 8);
            Calculator(divisionAction, 16, 8);

        }
        static void Calculator(Action<int, int> operation, int number1,int number2)
        {
            operation(number1, number2);
        }

    }
}
