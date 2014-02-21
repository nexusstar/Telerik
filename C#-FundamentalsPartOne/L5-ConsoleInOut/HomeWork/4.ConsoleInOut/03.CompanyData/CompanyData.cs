using System;

class CompanyData
{
    /// <summary>
    /// ex.3 A company has name, address, phone number, fax number, web site and manager. 
    /// The manager has first name, last name, age and a phone number.
    /// Write a program that reads the information about a company and its manager and prints them on the console.
    /// </summary>
    static void Main()
    {
        Console.Write("Enter the company name: ");
        string companyName = Console.ReadLine();
        
        Console.Write("Enter the {0} address: ", companyName);
        string companyAddress = Console.ReadLine();

        string companyPhone;
        int companyPhoneNumber;

        do
        {
            Console.Write("Enter the phone number of company: ");
            companyPhone = Console.ReadLine();

        } while (!int.TryParse(companyPhone, out companyPhoneNumber));

        string companyFax;
        int companyFaxNumber;

        do
        {
            Console.Write("Enter the fax number of company: ");
            companyFax = Console.ReadLine();
        } while (!int.TryParse(companyFax, out companyFaxNumber));

        Console.Write("Enter company web site: ");
        string companyWebSite = Console.ReadLine();
        
        //manager info
        Console.Write("Enter manager informatin \nFirst Name: ");
        string manFirstName = Console.ReadLine();

        Console.Write("Last Name: ");
        string manLastName = Console.ReadLine();

        string manAge;
        byte manAgeData;

        do
        {
            Console.Write("Age: ");
            manAge = Console.ReadLine();
        } while (!byte.TryParse(manAge, out manAgeData));

        string manPhone;
        int manPhoneNumber;

        do
        {
            Console.Write("Phone Number: ");
            manPhone = Console.ReadLine();
        } while (!int.TryParse(manPhone, out manPhoneNumber));

        Console.WriteLine("Company:\n" +
            "Name . . . . . . . . . . . . . . . : {0}\n" +
            "Address. . . . . . . . . . . . . . : {1}\n" +
            "Phone number . . . . . . . . . . . : {2:(+359) (###) ## ## ##}\n" +
            "Fax number . . . . . . . . . . . . : {3}\n" +
            "Web site . . . . . . . . . . . . . : {4}\n",
            companyName, companyAddress, companyPhoneNumber, companyFaxNumber, companyWebSite );
        Console.WriteLine("Manager:\n" +
            "First name . . . . . . . . . . . . : {0}\n" +
            "Last name. . . . . . . . . . . . . : {1}\n" +
            "Age. . . . . . . . . . . . . . . . : {2}\n" +
            "Phone number . . . . . . . . . . . : {3:(+359) (###) ## ## ##}\n",
            manFirstName, manLastName, manAgeData, manPhoneNumber); 

    }
}
