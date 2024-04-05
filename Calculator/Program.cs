namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division. 5 to quit program");

                var input = Console.ReadLine();
                var calculator = new Calculator();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("Enter 2 integers to add");
                        int[] additionNumbers = Calculator.GetNumbers();
                        Console.Write($"{additionNumbers[0]} + {additionNumbers[1]} = ");
                        Console.Write(calculator.Add(additionNumbers[0], additionNumbers[1]));
                        Console.WriteLine();
                        break;

                    case "2":
                        Console.WriteLine("Enter 2 integers to subtract");
                        int[] subtractionNumbers = Calculator.GetNumbers();
                        Console.Write($"{subtractionNumbers[0]} - {subtractionNumbers[1]} = ");
                        Console.Write(calculator.Subtract(subtractionNumbers[0], subtractionNumbers[1]));
                        Console.WriteLine();
                        break;

                    case "3":
                        Console.WriteLine("Enter 2 numbers to multiply");
                        int[] multiplicationNumbers = Calculator.GetNumbers();
                        Console.Write($"{multiplicationNumbers[0]} * {multiplicationNumbers[1]} = ");
                        Console.Write(calculator.Multiply(multiplicationNumbers[0], multiplicationNumbers[1]));
                        Console.WriteLine();
                        break;

                    case "4":
                        Console.WriteLine("Enter 2 integers to divide");
                        int[] divisionNumbers = Calculator.GetNumbers();
                        Console.Write($"{divisionNumbers[0]} / {divisionNumbers[1]} = ");
                        Console.Write(calculator.Divide(divisionNumbers[0], divisionNumbers[1]));
                        Console.WriteLine();
                        break;

                    case "5":
                        return;


                    default:
                        Console.WriteLine("Unknown input");
                        break;
                }
            }

        }
    }
}
