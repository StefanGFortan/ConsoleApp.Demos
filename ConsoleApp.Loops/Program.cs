namespace ConsoleApp.Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Simple for loop demo
            // BinaryWriter "Hello world" 10 times
            //program sun
            int command = 1;

            while (command > -1)
            {
                Console.WriteLine("\nHello and welcome to the ConsoleApp.Loop Demo \n" +
                    "You can choose to run the next programs: " +
                    "\n- 1) for loop simple 10 times " +
                    "\n- 2) for loop with an input for the times repeated" +
                    "\n 3) while loop demo" +
                    "\n 4) Sum of numbers using while" +
                    "\n 5) Sum of numbers using do while" +
                    "\n---- please enter your number" +
                    "\n ----- to exit write -1");
                command = Convert.ToInt32(Console.ReadLine());
                int num = 0, sum = 0;
                switch (command)
                {
                    
                    case 1:
                        {
                            //Simple for loop demo
                            // BinaryWriter "Hello world" 10 times
                            for (int i = 0; i < 10; i++)
                            {
                                Console.WriteLine($"Hello, World! - {i}");
                            }
                            Console.WriteLine("Loop completed");
                            break;
                        }
                    case 2:
                        {
                            //Ask the user how many times they want to print out "Hello world" and print it acordingly
                            Console.Write("Pleaseenter the number of times you want \"Hello world\" to be printe: ");
                            int cond = Convert.ToInt32(Console.ReadLine());

                            for (int i = 0; i < cond; i++)
                            {
                                Console.WriteLine($"Hello world! - {i + 1}");
                            }
                            break;
                        }
                    case 3:
                        {
                            int counter = 0;
                            while (counter < 10)
                            {
                                Console.WriteLine($"Hello world! - {counter + 1}");
                                counter += 2;
                            }
                            break;
                        }
                    case 4:
                        {
                            //Ask the user for a number and find the total for each number that is entered. Print the 
                            //final sum when the user enters -1 to exit.

                            Console.WriteLine("Enter positive numbers. When you want to stop enter -1 \nand the program will show you the sum .");
                            num = Convert.ToInt32(Console.ReadLine());
                            while (num > -1)
                            {
                                sum += num;
                                num = Convert.ToInt32(Console.ReadLine());
                            }
                            Console.WriteLine($"The sum of all numbers is : {sum}");
                            break;
                        }
                    case 5:
                        {
                            do
                            {
                                Console.Write("Please enter the numbers to be sumed. (-1 to stop or exit) ");
                                num = Convert.ToInt32(Console.ReadLine());
                                if (num != -1)
                                    sum += num;
                            } while (num > -1);
                            Console.WriteLine($"The sum of all numbers is : {sum}");
                            

                            break;
                        }
                }
            }
        }
    }
}
