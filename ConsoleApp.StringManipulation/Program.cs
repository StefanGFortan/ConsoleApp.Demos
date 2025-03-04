using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp.StringManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialize with a regular string literal
            string s1 = "This is a literal string";
            String s2 = "This is a literal string";
            Console.WriteLine($"{nameof(s1)} : {s1}");
            Console.WriteLine($"{nameof(s2)} : {s2}");

            //Declare without initializing. (possible null exception)
            string s3;
            //Console.WriteLine($"{nameof(s3)} : {s3}"); Syntax error, s3 needs a value before it can be used
            
            //Initialize to null. (possible null exception)
            string? s4 = null;
            Console.WriteLine($"{nameof(s4)} : {s4}");
            
            //Initialize as an empty string.
            string s5 = string.Empty; //""
            string s6 = "";
            Console.WriteLine($"{nameof(s5)} : {s5}");
            Console.WriteLine($"{nameof(s6)} : {s6}");
            
            //Escape sequences and characters
            // She said, " I have your phone"
            string sentence = "She said, \" I have your phone\" \r\n This is the next line ";
            Console.WriteLine($"{nameof(sentence)} : {sentence}");

            //Verbatim string literal.
            string oldPath = "C:\\program files\\program folder\\";
            string newPath = @"C:\program files\program folder\" ;
            Console.WriteLine($"{nameof(oldPath)} : {oldPath}");
            Console.WriteLine($"{nameof(newPath)} : {newPath}");

            //Use a const string to prevent modification to a string
            const string path = @"C:\program files\program folder\";
            // path = "new path" ; Illegal operation against a constant
            s1 = "New string";
            Console.WriteLine($"{nameof(s1)} : {s1}");

            //Raw string literals
            string rawLiteral = """ She said, "I have your phone" """;
            string rawLiteralMultipleLines = """
                Line 1;
                line 2:)))
                Path = C:\program files\program folder\
                """;
            Console.WriteLine($"{nameof(rawLiteral)} : {rawLiteral}");
            Console.WriteLine($"{nameof(rawLiteralMultipleLines)} : {rawLiteralMultipleLines}");

            //Review concatenation and interpolation
            s1 += s2;
            Console.WriteLine($"{nameof(s1)} : {s1}");
            s1 = s1 + s2;
            Console.WriteLine($"{nameof(s1)} : {s1}");
            string newString = $"{s1} {s2} Some random literal string ";
            string newString1 = s1 + $"{s1} {s2} Some random literal string ";
            string newString2 = string.Format("Literal string {0} {1}", s1, s2);
            Console.WriteLine($"{nameof(newString)} : {newString}");
            Console.WriteLine($"{nameof(newString1)} : {newString1}");
            Console.WriteLine($"{nameof(newString2)} : {newString2}");

            /* String manipulation methods and properties. Sometimes it just assesments */

            //Null or empty checks
            //find the length of a string

            Console.WriteLine($"{nameof(s1)} has a length of  {s1.Length}");
            Console.WriteLine($"{nameof(s6)} has a length of {s6.Length}");
            //Console.WriteLine($"{nameof(s4)} has a length of {s4.Length}"); //Will cause null exception
            
            //if(string.IsNullOrEmpty(s4) == flase)
            if (!string.IsNullOrEmpty(s4))
            {
                Console.WriteLine($"{nameof(s4)} has a length of {s6.Length}");
            }
            if (string.IsNullOrEmpty(s5) == false)
            {
                Console.WriteLine($"{nameof(s5)} has a length of {s5.Length}");
            }

            //Sub string 
            string subString = s1.Substring(5);
            Console.WriteLine($"{nameof(subString)} : {subString}");
            subString = s1.Substring(5, 5);
            Console.WriteLine($"{nameof(subString)} : {subString}");

            //Splitting strings
            var splitStings = s2.Split(' ');
            for(int i=0;i<splitStings.Length; i++)
            {
                Console.WriteLine(splitStings[i]);
            }

            //Replace
            string replacements1 = s1.Replace('s', 'V');
            Console.WriteLine($"{nameof(replacements1)} : {replacements1}");
            string replacements2 = s2.Replace("string", "chicken");
            Console.WriteLine($"{nameof(replacements2)} : {replacements2}");

            //Convert to a string
            string salalry = 45678998765.09.ToString();
            int value = 123546;
            string strValue = value.ToString();
            bool chosen = true;

            //Change fromating 
            Console.WriteLine($"{nameof(salalry)} : {salalry:C}");
            Console.WriteLine(nameof(salalry)+ ": "+value.ToString("C"));
        }
    }
}
