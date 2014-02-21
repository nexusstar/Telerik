using System;

class MethodExample
{
    static void PrintLogo(string logo)
    {
        logo = LogoName();
        Console.WriteLine(logo);
        Console.WriteLine("www.telerik.com");
    }
    static string LogoName() {
        return "Telerik";
    }

    static void Main()
    {
        PrintLogo(LogoName());
    }
}
