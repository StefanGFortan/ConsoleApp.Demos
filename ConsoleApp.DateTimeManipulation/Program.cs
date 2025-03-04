using System.Globalization;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

namespace ConsoleApp.DateTimeManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("**** Date Time Manipulation ****");
            ////Empty DateTime object 
            //DateTime dateTim = new DateTime();

            ////Create DateTime from date and time
            //var dateOfBirth = new DateTime(2007, 4, 25);
            //Console.WriteLine($"My date of birth is : {dateOfBirth}");

            //var exactDateAndTimeOfBirth = new DateTime(2007, 4, 25,16,05,15, DateTimeKind.Local);
            //Console.WriteLine($"My date of birth is : {exactDateAndTimeOfBirth}");

            //Console.WriteLine($"Day of Week :{dateOfBirth.DayOfWeek}");
            //Console.WriteLine($"Day of Year :{dateOfBirth.DayOfYear}");
            //Console.WriteLine($"Time of Day :{exactDateAndTimeOfBirth.TimeOfDay}");
            //Console.WriteLine($"Tick :{exactDateAndTimeOfBirth.Ticks}");
            //Console.WriteLine($"Kind :{exactDateAndTimeOfBirth.Kind}");

            ////Create a DateTime from current timestamp
            DateTime now = DateTime.Now;
            //Console.WriteLine("The time now is : " + now);

            ////Create DateTime from String
            //Console.WriteLine("What is your DOB (MM/dd/yyyy): ");
            //string dob = Console.ReadLine();

            //var userDob = DateTime.Parse(dob);
            //Console.WriteLine($"Day of Week : {userDob.DayOfWeek}");
            //Console.WriteLine($"Day of Year : {userDob.DayOfYear}");
            //Console.WriteLine($"Time of Day : {userDob.TimeOfDay}");
            //Console.WriteLine($"Tick : {userDob.Ticks}");
            //Console.WriteLine($"Kind : {userDob.Kind}");

            ////Change Format DateTime
            //Console.WriteLine($"Formated date : {userDob.ToString("dd/MM/yyyy")}");
            //Console.WriteLine($"Formated date : {userDob.ToString("MM, dd-yyyy")}");
            //Console.WriteLine($"Formated date : {userDob.ToString("dd-MM-yyyy")}");
            //Console.WriteLine($"Formated date : {userDob.ToString("dddd, MMMM dd, yyyy")}");

            ////Add aditional time
            //Console.WriteLine("One hour from now is: " + now.AddHours(1));
            //Console.WriteLine("One day from now is: " + now.AddDays(1));
            //Console.WriteLine("One day ago from now is: " + now.AddDays(-1));

            //Console.WriteLine("**** DateTime Offset Manipulation ****");
            ////UTC - Coordinated Unviersal Time
            //var utcNow = DateTime.UtcNow;
            //Console.WriteLine($"Now the Date Time: {now}");
            //Console.WriteLine($"UTC Now Date Time : {utcNow}");

            ////DateTime offset and TimeZone info
            //var tz = TimeZoneInfo.Local.GetUtcOffset(utcNow);
            //Console.WriteLine($"User Time Zone: {tz}");

            //var dto = new DateTimeOffset(now, tz);
            //Console.WriteLine($"User Time Zone with UTC Offset: {dto}");
            //Console.WriteLine($"UTC Time Of Action: {dto.UtcDateTime}");
            //var indiaTz = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");
            //var indiaDateTime = TimeZoneInfo.ConvertTimeFromUtc(dto.UtcDateTime, indiaTz);
            //Console.WriteLine($"Action was completed in India at: {indiaDateTime}");

            Console.WriteLine("**** Date only and Time only Manipulation ****");
            //DateOnly
            var dateOnly = new DateOnly(2007,4,25);
            var nextDay = dateOnly.AddDays(1);
            var previousDay = dateOnly.AddDays(-1);
            var decadeLater = dateOnly.AddYears(10);
            var lastMonth = dateOnly.AddMonths(-1);

            Console.WriteLine($"The Date: {dateOnly}");
            Console.WriteLine($"The Next Day: {nextDay}");
            Console.WriteLine($"The Previous Day :{previousDay}");
            Console.WriteLine($"The Decade later : {decadeLater}");
            Console.WriteLine($"The Last month: {lastMonth}");

            var dateOnlyFromDateTime = DateOnly.FromDateTime(now);
            Console.WriteLine($"The Date Only from Date Time now is: {dateOnlyFromDateTime}");

            //Console.WriteLine("What is your DOB (dd MMM yyyy): ");
            //string dobDateOnly = Console.ReadLine();

            //var theDateOnly = DateOnly.ParseExact(dobDateOnly, "dd MMM yyyy", CultureInfo.InvariantCulture);

            //Console.WriteLine($"The Date Only: {theDateOnly}");

            //TimeOnly
            var timeNow = TimeOnly.FromDateTime(now);
            Console.WriteLine($"The time now is: {timeNow}");
            Console.WriteLine($"The time now is: {timeNow:hh:mm tt}");

            //Date Comparasion
            var date1 = new DateTime(1985, 11, 23);
            var date2 = new DateTime(1965, 1, 20);

            Console.WriteLine($"is '{nameof(date1)}' equal? {date1 == date2}");
            Console.WriteLine($"Is '{nameof(date1)}' equal? {date1.Equals(date2)}");
            Console.WriteLine($"Is '{date2}' after? {date2 > date1}");
            Console.WriteLine($"Is '{date2}' before? {date2 < date1}");
        }
    }
}
