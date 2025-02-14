namespace ConsoleApp.UserInputDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            string name = string.Empty;
            int age = 0;
            int retirementAge = 60;

            //Prompt the user for input
            Console.WriteLine("Please enter your name: ");
            name  = Console.ReadLine();

            Console.WriteLine("Please enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            // Process the data
            int workingYearsRemaining = retirementAge - age;

            //Output the result to the user
            Console.WriteLine($"Full name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Working years remainign: {workingYearsRemaining}");
        }
    }
}
