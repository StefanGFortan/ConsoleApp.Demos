using System.Globalization;
using System.Xml.Linq;

namespace ConsoleApp.UserInputDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            const int retirementAge = 60; 
            string? firstName = string.Empty;
            string? lastName = string.Empty;
            int age;
            DateOnly dob = new DateOnly();
            decimal salary;
            char gender = char.MinValue;
            bool working = true; // if you do not initialize a bool, it will be automatically initialized with false

            //Prompt the user for input
            Console.Write("Please enter your first name: ");
            firstName  = Console.ReadLine();

            Console.Write("Please enter your last name: ");
            lastName = Console.ReadLine();

            Console.Write("Please enter your date of birth (dd/mm/yyyy): ");

            dob = DateOnly.ParseExact(Console.ReadLine(),"dd/MM/yyyy", CultureInfo.InvariantCulture);
            age = DateTime.Now.Year - dob.Year;

            Console.Write("Please enter your last salary: ");
            salary = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Please enter your gender (M or F): ");
            gender = Convert.ToChar(Console.ReadLine());

            Console.Write("Are you working? (true or false): ");
            working = Convert.ToBoolean(Console.ReadLine());

            // Process the data
            int workingYearsRemaining = retirementAge - age;
            var estimatedRetirementDate = DateTime.Now.AddYears(workingYearsRemaining);

            //Output the result to the user
            Console.WriteLine($"Full name: {firstName} {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Your salary is: {salary.ToString("C")}");
            Console.WriteLine($"Your gender is: {gender}");
            Console.WriteLine($"You are employed: {working}");
            Console.WriteLine($"Working years remainign: {workingYearsRemaining}");
            Console.WriteLine($"Estimated retirement year: {estimatedRetirementDate.Year}");
        }
    }
}
