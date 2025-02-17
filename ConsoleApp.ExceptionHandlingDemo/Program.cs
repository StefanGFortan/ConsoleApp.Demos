namespace ConsoleApp.ExceptionHandlingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter your age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"You are {age} years old");
            }
            catch (Exception)
            {
                Console.WriteLine("Your age value was incorect, please try numbers");
                //throw;
            }
            finally
            {
                Console.WriteLine("thank you for using this program");
            }
            
        }
    }
}
