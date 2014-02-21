using System;

class DeclaringVariables
{
    /// <summary>
    /// 4. Declare an integer variable and assign it with the value 254 in hexadecimal format.
    /// Use Windows Calculator to find its hexadecimal representation.
    /// 
    /// 5. Declare a character variable and assign it with the symbol that has Unicode code 72.
    /// Hint: first use the Windows Calculator to find the hexadecimal representation of 72.
    /// 
    /// 6. Declare a boolean variable called isFemale
    /// and assign an appropriate value corresponding to your gender.
    /// 
    /// </summary>
    static void Main()
    {
        //Geting the hexadecimal value from decimal one
        int valueOne = 254;
        int valueTwo = 72;
        string hexOutputOne = string.Format("{0:X}", valueOne);
        string hexOutputSecond = string.Format("{0:X}", valueTwo);
        Console.WriteLine("The hexadecimal for {0} = {1} and for {2} = {3}", valueOne, hexOutputOne, valueTwo, hexOutputSecond);
        
        //another solution more simpler one is:
        Console.WriteLine("The hexadecimal for {0} = {0:X} and for {1} = {1:X}", valueOne,valueTwo);
        
        //note from documentation: However, if a conversion cannot be made without a risk of losing information, 
        //the compiler requires that you perform an explicit conversion, which is called a cast. A cast is a way
        //of explicitly informing the compiler that you intend to make the conversion and that you are aware that
        //data loss might occur.

        int twoFiveFour = (int)0xFE; //explicit conversion.

        char sevenTwoHex = (char)0x48; //explicit conversion from hexadecimal
        char sevenTwoInt = (char)72; //explicit conversion from int
        char sevenTwoUni = '\u0048'; //Unicode code
        Console.WriteLine(sevenTwoUni);
        Console.WriteLine("The character which Unicode code is 72 is {0}", sevenTwoHex);

        string isFemaleQ;
        bool isFemale;
        Console.Write("Please enter your gender (female/male): ");
        isFemaleQ = Console.ReadLine();
        if (isFemaleQ == "female")
        {
            isFemale = true;
            Console.WriteLine("Variable isFemale is {0}. Glad to meet you Madam", isFemale);
        }
        else
        {
            isFemale = false;
            Console.WriteLine("Variable isFemale is {0}. Nice to meet you Sir", isFemale);
        }

        
    }
}

