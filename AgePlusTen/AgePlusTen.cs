using System;

namespace YourAgeAfter10Years
{
    class AgePlusTen
    {
        static void Main(string[] args)
        {
            //Asking and reading your age from console
            Console.WriteLine("Year?");
            string yearStr = Console.ReadLine();
            Console.WriteLine();


            Console.WriteLine("Month? Please, write number."); //I need to do an exception
            string monthStr = Console.ReadLine();
            Console.WriteLine();


            Console.WriteLine("Day?");
            string dayStr = Console.ReadLine();
            //I can add hours, seconds and minutes, but I think that's not so necessary

            //Converts string representation of a number to its integer equivalent
            int yearI, monthI, dayI = 0;
            yearI = Int32.Parse(yearStr);
            monthI = Int32.Parse(monthStr);
            dayI = Int32.Parse(dayStr);

            //Creating DateTime with date of birthday and current time
            DateTime dateOfBirthday = new DateTime(yearI, monthI, dayI);
            DateTime today = DateTime.Now;

            //Did you celebrated your birthday this year?
            int age = today.Year - dateOfBirthday.Year; 
            if (today < dateOfBirthday.AddYears(age)) age--;

            int agePlus10Y = age + 10;
            Console.WriteLine();
            Console.WriteLine("Your age after 10 years: " + agePlus10Y + " years."); //Printing your age after 10 years
            Console.ReadLine();
        }
    }
}