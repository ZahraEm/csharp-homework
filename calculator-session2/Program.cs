using System;

namespace calculator_session2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                float result = 0;
                Console.WriteLine("Please enter first number:");
                float number1 = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine("Please enter an operator (+,-,*,/)");
                string op = Console.ReadLine();
                if(op != "+" && op != "-" && op != "*" && op != "/")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Please enter an operator that the app can support it");
                    Console.ResetColor();
                    return;
                }
                Console.WriteLine("Please enter second number:");
                float number2 = Convert.ToSingle(Console.ReadLine());
                
                switch (op)
                {
                    case "+":
                        result = number1 + number2;
                        break;
                    case "-":
                        result = number1 - number2;
                        break;
                    case "*":
                        result = number1 * number2;
                        break;
                    case "/":
                        result = number1 / number2;
                        break;
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"the result of {number1}{op}{number2} is: {result}");
                Console.ResetColor();
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please enter only number");
                Console.ResetColor();
            }
        }
    }
}
