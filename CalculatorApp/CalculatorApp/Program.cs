using System;
using OperationsLibrary;



namespace CalculatorApp
{
    public static class Program
    {
        static void Main(string[] args)
        {
            double value1 = 0, value2 = 0;
            var action = "";
            var perform = true;
            double result = 0;
            Operations calculate = new Operations();

            while (perform)
            {
                try
                {
                    Console.WriteLine("Enter 1st input");
                    value1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter 2nd input");
                    value2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Enter the action to be performed");
                    Console.WriteLine("Press + for Addition");
                    Console.WriteLine("Press - for Subtraction");
                    Console.WriteLine("Press * for Multiplication");
                    Console.WriteLine("Press / for Division");
                    action = Console.ReadLine();

                    
                    switch (action)
                    {
                        case "+":
                        {
                            result = calculate.Add(value1, value2);
                            break;
                        }
                        case "-":
                        {
                            result = calculate.Sub(value1, value2);
                            break;
                        }
                        case "*":
                        {
                            result = calculate.Multiply(value1, value2);
                            break;
                        }
                        case "/":
                        {
                            result = calculate.Div(value1, value2);
                            break;
                        }
                        default:
                            Console.WriteLine("Wrong action!! try again");
                            break;
                    }
                    Console.WriteLine("The result is {0}", result);

                    Console.WriteLine("Perform another calculation? y/n");

                    if (Console.ReadLine() != "y")
                        perform = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Enter only numbers");
                    throw new FormatException();
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Retry due to Overflow");
                    throw new OverflowException();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Retry due to error");
                    throw ex;
                }
            }
            
            Console.ReadKey();
        }


    }

}
