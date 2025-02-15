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

            //Show calcultaor options
            Console.Write("Please select and operation: \n 1.Adition \n 2.Substraction \n 3. Multiplication \n 4.Division \n Enter please the number for the operation option:");
            int choise = Convert.ToInt32(Console.ReadLine());

            //Promt for user input
            Console.Write("Please enter the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            //Decide which operation is needed based on selected option
            switch (choise)
            {
                case 1:
                    Console.WriteLine($"The result is {num1 + num2}");
                    break;
                case 2:
                    Console.WriteLine($"The result is { num1 - num2}");
                    break;
                case 3:
                    Console.WriteLine($"The result is {num1 * num2}");
                    break;
                case 4:
                    Console.WriteLine($"The result is {num1 / num2}");
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }

            //print output
        }
    }
}
