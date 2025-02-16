using System.ComponentModel.Design;

namespace ConsoleApp.ConditionsAndDecisions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Promt for input
            Console.Write("Please enter student's gadre: ");
            int grade = Convert.ToInt32(Console.ReadLine());

            // Simple If... Else...statements - Decide to print pass or fail based on input            
            if(grade >50)
            {
                Console.WriteLine("Student has passed");
            }
            else
            {
                Console.WriteLine("Student has failed");
                Console.WriteLine("please recommed student affair's office"); 
            }

            //Complex If... Else If... Statements - Decide to print letter based on grade value
            /*
             * A: 86-100
             * B: 75 -84
             * C: 65-74
             * D: 50-64
             * F: less than 50 X
             */

            if(grade<0 || grade > 100)
            {
                Console.WriteLine("Invalid value");
            }
            else if ( grade < 50)
            {
                Console.WriteLine("F");
            }
            else if(grade >= 50 && grade <=64)
            {
                Console.WriteLine("D");
            }
            else if (grade >= 65 && grade <= 74)
            {
                Console.WriteLine("C");
            }
            else if (grade >= 75 && grade <= 84)
            {
                Console.WriteLine("B");
            }
            else if(grade >=85 && grade <=100)
            {
                Console.WriteLine("A");
            }

            //Terany operations
            string passStatus = grade < 50 ? "Fail" : "Pass";
            Console.WriteLine(ceva);
            Console.WriteLine($"Your student status is: {passStatus}");

            Console.WriteLine("\n--------------------\n\n");

            /*Write a program to accept an integer as the day the week and print the 
             aproppiate message as outlined below
            1 - Sunday
            2 - Monday
            3 - Tuesday 
            4 - Wednesday(Hump Day!)
            5 - Thursady
            6 - Friday (TGIF)
            7 - Saturday(Beach day!!!)
            */

            Console.Write("Please enter a number between 1 and 7: ");
            int day = Convert.ToInt32(Console.ReadLine());
            string messageSwitch = string.Empty;
            string messageIf = string.Empty;
            if (day < 0 || day > 7)
            {
                messageIf = "Incorrect Value";
            }
            else if (day == 1)
            {
                messageIf = "Sunday";
            }
            else if(day == 2)
            {
                messageIf = "Monday";
            }
            else if(day == 3)
            {
                messageIf = "Tuesday";
            }
            else if (day == 4)
            {
                messageIf = "Wednesday(Hump Day)";
            }
            else if (day == 5)
            {
                messageIf = "Thursday";

            }
            else if (day == 6)
            {
                messageIf = "Friday(TGIF)";

            }
            else if (day == 7)
            {
                messageIf = "Saturday(Beach day!!!)";

            }

            switch (day)
            {
                case 1:
                    messageSwitch = "Sunday";
                    break;
                case 2:
                    messageSwitch = "Monday";
                    break;
                case 3:
                    messageSwitch = "Tuesday";
                    break;
                case 4:
                    messageSwitch = "Wednesday(Hump Day)";
                    break;
                case 5:
                    messageSwitch = "Thursday";
                    break;
                case 6:
                    messageSwitch = "Friday(TGIF)";
                    break;
                case 7:
                    messageSwitch = "Saturday(Beach day!!!)";
                    break;
                default:
                    messageSwitch = "Incorect value";
                    break;
            } 
            Console.WriteLine(messageIf);
            Console.WriteLine(messageSwitch);
            //The rest of the app
            Console.WriteLine("Thank you for using this program");
        }
    }
}
