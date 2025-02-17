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
                    Console.Write("Please select an operation (-1 to exit) : " +
                        "\n 1.Adition " +
                        "\n 2.Substraction " +
                        "\n 3. Multiplication " +
                        "\n 4.Division " +
                        "\n 5. Fibonacci sequence" +
                        "\n Enter please the number for the operation option:");
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
                            answer = num1 + num2;
                            break;
                        case 2:
                            answer = num1 - num2;
                            break;
                        case 3:
                            answer = num1 * num2;
                            break;
                        case 4:
                            answer = num1 / num2;
                            break;
                        case 5:
                            for (int i = num1; i <= num2; i++)
                            {
                                answer += i;
                            }
                            break;
                        default:
                            throw new Exception("Invalid menu item selected.");
                    }

                    //print output
                    Console.WriteLine(answer);
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
                    Console.Clear();
                }
            }
            Console.WriteLine("Thank you for using this calculator");
       }
    }
}
