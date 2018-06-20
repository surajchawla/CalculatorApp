using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first operand : ");
            var leftOperandString = Console.ReadLine();
            
            if (!double.TryParse(leftOperandString, out double leftOperand))
                throw new Exception("Invalid Operand");
            

            Console.WriteLine("Enter the second operand : ");
            var rightOperandString = Console.ReadLine();
            if (!double.TryParse(rightOperandString, out double rightOperand))
                throw new Exception("Invalid Operand");


            UserCalculator userCalculator = new UserCalculator();

            int choice = 0;
            do
            {
                Console.WriteLine("Operations ");
                Console.WriteLine("1. ADD ");
                Console.WriteLine("2. SUBTRACT ");
                Console.WriteLine("3. MULTIPLY ");
                Console.WriteLine("4. DIVIDE ");
                Console.WriteLine("5. END PROGRAM ");

                Console.WriteLine("Enter choice : ");


                var userChoice = Console.ReadLine();
                if (int.TryParse(userChoice, out choice))
                {
                    if (choice >= 1 && choice <= 4)
                    {
                        double result = userCalculator.PerformOperation((Operator) choice, leftOperand, rightOperand);
                        Console.WriteLine($"Result : {result}");
                    }
                    else if (choice == 5)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please select correct choice");
                    }
                }
                else
                {
                    Console.WriteLine("Please select correct choice");
                }
            } while (choice != 5 );
            
        }
    }
}
