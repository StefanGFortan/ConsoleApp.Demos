using System.Xml.Linq;

namespace ConsoleApp.UserInputDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            string? firstName;
            string? lastName;
            int age;
            int retirementAge = 60;
            decimal salary;
            char gender = char.MinValue;
            bool working = true; // if you do not initialize a bool, it will be automatically initialized with false

            //Prompt the user for input
            Console.Write("Please enter your first name: ");
            firstName  = Console.ReadLine();

            Console.Write("Please enter your last name: ");
            lastName = Console.ReadLine();

            Console.Write("Please enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter your last salary: ");
            salary = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Please enter your gender (M or F): ");
            gender = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Are you working? (true or false): ");
            working = Convert.ToBoolean(Console.ReadLine());
            // Process the data
            int workingYearsRemaining = retirementAge - age;

            //Output the result to the user
            Console.WriteLine($"Full name: {firstName} {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Your salary is: {salary}");
            Console.WriteLine($"Your gender is: {gender}");
            Console.WriteLine($"You are employed: {working}");
            Console.WriteLine($"Working years remainign: {workingYearsRemaining}");
        }
    }
}
