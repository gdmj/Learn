using System;

namespace CompanyInfo
{
    class CompanyInformation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Company name?");
            string companyName = Console.ReadLine();

            Console.WriteLine("Adress?");
            string adress = Console.ReadLine();

            Console.WriteLine("Phone number?");
            ulong phoneNumber = UInt64.Parse(Console.ReadLine());

            Console.WriteLine("Fax number?");
            ulong faxNumber = UInt64.Parse(Console.ReadLine());

            Console.WriteLine("Web site?");
            string webSite = Console.ReadLine();

            Console.WriteLine("Manager name?");
            string managerName = Console.ReadLine();

            Console.WriteLine("Manager surname?");
            string managerSurname = Console.ReadLine();

            Console.WriteLine("Manager phone number?");
            ulong managerPhoneNumber = UInt64.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine(@"Company:
Name: {0} 
Adress: {1}
Phone number: {2}
Fax number: {3}
Web site: {4}

Company manager
Name: {5}
Surname: {6}
Phone number: {7}", companyName, adress, phoneNumber, faxNumber, webSite, managerName, managerSurname, managerPhoneNumber);
            Console.ReadLine();
        }
    }
}
