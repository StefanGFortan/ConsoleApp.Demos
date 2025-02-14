namespace ConsoleApp.VariablesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
               Data types:
               text -> string
                letter -> char
               integers numbers -> int
               decimals -> double, float, decimal 
               logical -> bool
             */
            string name = "Stefan";
            Console.WriteLine("I am " + name); // string concatenation 
            Console.WriteLine($"They call me {name}"); // string interpolation
            Console.WriteLine("I was given the name {0}", name); // formatted string

            int age = 17;
            int retirementYearsLeft = 43;
            int retirementAge = age + retirementYearsLeft;
            Console.WriteLine(age);
            Console.WriteLine("My retirement age is " + retirementAge);

            bool isRetired = false;
            Console.WriteLine("Am I retired? " + isRetired);
        }
    }
}
