namespace ConsoleApp.Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter your second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            /*
                Math opretaions and operators
             */

            //add numbers
            int sum = num1 + num2;

            //multiply 
            int product = num1 * num2;

            //division
            int quotient = num1 / num2;

            //subtraction
            int diffrence = num1 - num2;

            //modulos
            int mod = num1 % num2;
            Console.WriteLine("\n**** Math results ****");
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Diffrence: {diffrence}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Quotient: {quotient}");
            Console.WriteLine($"Modulos: {mod}");
            Console.WriteLine("**** End math results ****\n");

            /*
             Logic Operations and operators
             */
            bool isGreaterThan = num1 > num2;
            bool isLessThan = num1 < num2;
            bool isEqualTo = num1 == num2;
            bool isGreaterThanOrEqualTo = num1 >= num2;
            bool isLessThanOrEqualTo = num1 <= num2;
            bool isNoTEqual = num1 != num2;

            Console.WriteLine("**** Logic result ****");
            Console.WriteLine($" Is num1 greater than num2: {isGreaterThan}");
            Console.WriteLine($" Is num1 less than num2: {isLessThan}");
            Console.WriteLine($" Is num1 equal to num2: {isEqualTo}");
            Console.WriteLine($" Is num1 greater or euqal than num2: {isGreaterThanOrEqualTo}");
            Console.WriteLine($" Is num1 less or euqal than num2: {isLessThanOrEqualTo}");
            Console.WriteLine($" Is num1 not equal to num2: {isNoTEqual}");
            Console.WriteLine("**** End logic result ****\n");

            /* 
              Assigment Operations and Operators
             */
            int randomValue;

            Console.WriteLine("**** Assigment result ****");
            Console.WriteLine($"Num 1 is {num1}");
            Console.Write("Enter a roandom value");
            randomValue = Convert.ToInt32(Console.ReadLine());
            num1 += randomValue;
            Console.WriteLine($"Num 1 increased by {randomValue} is {num1}");
            Console.Write("Enter a roandom value: ");
            randomValue = Convert.ToInt32(Console.ReadLine());
            num1 -= randomValue;
            Console.WriteLine($"Num 1 reduced by {randomValue} is {num1}");
            Console.Write("Enter a roandom value: ");
            randomValue = Convert.ToInt32(Console.ReadLine());
            num1 /= randomValue;
            Console.WriteLine($"Num 1 divided by {randomValue} is {num1}");
            Console.Write("Enter a roandom value: ");
            randomValue = Convert.ToInt32(Console.ReadLine());
            num1 %= randomValue;
            Console.WriteLine($"Num 1 mod by {randomValue} is {num1}");
            Console.Write("Enter a roandom value: ");
            randomValue = Convert.ToInt32(Console.ReadLine());
            num1 *= randomValue;
            Console.WriteLine($"Num 1 multiplied by {randomValue} is {num1}");
            Console.WriteLine("**** End assigment result ****");

        }
    }
}
