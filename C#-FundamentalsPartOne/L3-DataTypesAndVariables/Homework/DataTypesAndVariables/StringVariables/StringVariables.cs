using System;

class StringVariables
{
    /// <summary>
    /// Declare two string variables and assign them with “Hello” and “World”.
    /// Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval). 
    /// Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).
    /// </summary>
    static void Main()
    {
        string strHello = "Hello";
        
        string strWorld = "World";
        
        object helloWorld = strHello + " " + strWorld;
           
        string strObject = (string)helloWorld;
    }
}
