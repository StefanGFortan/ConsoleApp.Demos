using System.Diagnostics;

namespace ConsoleApp.SampleCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Welcome message
            Console.WriteLine("Welcome to the sample calculator!");
            Console.WriteLine("   /|  ._____.");
            Console.WriteLine("  / |  |     |");
            Console.WriteLine(" /  |  |     |");
            Console.WriteLine("/___|  |_____|\n");

            //Variable declaration
            int choise = 0;

            //Show calcultaor options
            while (choise != -1)
            {
                try
                {
                    //declare variables
                    int num1 = 0, num2 = 0, answer = 0;
                    PrintMenu();
                    choise = Convert.ToInt32(Console.ReadLine());

                    if (choise == -1)
                    {
                        break;
                    }

                    //Promt for user input
                    Console.Write("Please enter the first number:");
                    num1 = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Please enter the second number:");
                    num2 = Convert.ToInt32(Console.ReadLine());

                    //Decide which operation is needed based on selected option
                    switch (choise)
                    {
                        case 1:
                            answer = AddNumbers(num1,num2);
                            break;
                        case 2:
                            answer = SubtractNumbers(num1,num2);
                            break;
                        case 3:
                            answer = ProductNumbers(num1, num2);
                            break;
                        case 4:
                            answer = QuotientNumbers(num1,num2);
                            break;
                        case 5:
                            answer = Fibonacci(num1, num2);
                            break;
                        default:
                            throw new Exception("Invalid menu item selected.");
                    }

                    //print output
                    Console.WriteLine("The result is: "+answer);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Cannot devide by zero");

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("Press Enter to continue");
                    Console.ReadLine();
                }
            }
            Console.WriteLine("Thank you for using this calculator");
       }



        //Method Definitions
        private static int AddNumbers(int num1, int num2)
        {
            return num1 + num2;
        }
        private static int SubtractNumbers(int num1, int num2)
        {
            return num1 - num2;
        }
        private static int ProductNumbers(int num1, int num2)
        {
            return num1 * num2;
        }
        private static int QuotientNumbers(int num1, int num2)
        {
            return num1 / num2;
        }

        private static int Fibonacci(int num1, int num2)
        {
            var answer = 0 ;
            for (int i = num1; i <= num2; i++)
            {
                answer += i;
            }
            return answer;
        }
        private static void PrintMenu()
        {
            Console.Clear();
            Console.Write("Please select an operation (-1 to exit) : " +
                "\n 1. Adition " +
                "\n 2. Substraction " +
                "\n 3. Multiplication " +
                "\n 4. Division " +
                "\n 5. Fibonacci sequence" +
                "\n Enter please the number for the operation option:");
        }
    }
}
