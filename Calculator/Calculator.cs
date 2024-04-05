using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public int Add(int first, int second)
        {
            return first + second;
        }

        public int Subtract(int first, int second)
        {
            return first - second;
        }

        public int Multiply(int first, int second)
        {
            return first * second;
        }

        public double Divide(double first, double second)
        {
            return first / second;
        }

        public static int[] GetNumbers()
        {
            while (true)
            {
                var number1 = Console.ReadLine();
                var number2 = Console.ReadLine();
                if (int.TryParse(number1, out int numOne) && int.TryParse(number2, out int numTwo))
                {
                    int[] operationNumbers = [numOne, numTwo];
                    return operationNumbers;

                }
                else
                {
                    Console.WriteLine("One or more of the numbers is not an int. Please input 2 numbers");
                    Console.WriteLine();
                }
            }
        }
    }
}
