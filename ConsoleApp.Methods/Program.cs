namespace ConsoleApp.Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************** - Methods - *****************");
            //void methods - complete a task without returning a value
            void PrintName()
            {
                //Method code
                Console.WriteLine("Stefan Fortan");
            }

            //value returning methods - returns a value after an opertaion
            int GetFiveYearsAgo()
            {
                int year = DateTime.Now.AddYears(-5).Year;
                return year;
            }

            //methods with parameters - data beign passed into a method 
            void PrintNameWithParameter(string name)
            {
                //Method code
                Console.WriteLine("Your name is "+name);
            }

            int GetYearDiffrenceWithParameter(int year)
            {
                int yearDiffrence = DateTime.Now.Year - year;
                return yearDiffrence;
            }

            //methods with optional parameters - parameter not required.. has a default value
            int GetFutureOrPastYear(int numberOfYears = 0)
            {
                var year = DateTime.Now.AddYears(numberOfYears).Year;
                return year;
            }

            //methods with nullable parameters
            void PrintNullableParam(string ?name, int ?count = null)
            {
                //if(string.IsNullOrEmpty(name))
                //{
                //    name = "default name";
                //}
                //if(!count.HasValue)
                //{
                //    count = 1;
                //}
                name ??= "Default Name";
                count ??= 1;

                for(int i=0;i<count;i++)
                {
                    Console.WriteLine(name);
                }
            }

            /* Function Calls */
            PrintName();
            int fiveYearsAgo = GetFiveYearsAgo();
            Console.WriteLine($"The year five years ago was {fiveYearsAgo}");

            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            PrintNameWithParameter(name);

            Console.Write("Enter a year: ");
            int pastYear = Convert.ToInt32(Console.ReadLine());
            int yearsAgo = GetYearDiffrenceWithParameter(pastYear);
            Console.WriteLine($"Tis was: {yearsAgo} years ago");


            Console.Write("Enter a number of years in the past or future: ");
            int numberOfYears = Convert.ToInt32(Console.ReadLine());

            var pastYear1 = GetFutureOrPastYear();
            Console.WriteLine("The year is: " + pastYear1);

            var pastYear2 = GetFutureOrPastYear(numberOfYears);
            Console.WriteLine("The year is: " + pastYear2);

            PrintNullableParam(null, null);
            PrintNullableParam("Stefan",5);
        }
    }
}
