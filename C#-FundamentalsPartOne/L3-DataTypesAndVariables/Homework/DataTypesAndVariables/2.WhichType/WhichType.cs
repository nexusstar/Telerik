using System;

class WhichType
{
    /// <summary>
    /// Excercise 2.  Which of the following values can be assigned to a variable of type float 
    /// and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
    /// </summary>
    
    static void Main()
    {
        //Float can accomodate 7 digit precision
        float varFloatZero = 12.345f;
        float varFloatOne = 3456.091f;
        
        //double can accomodate up to 15 digit precision
        double varDoubleZero = 34.567839023;
        double varDoubleOne = 8923.1234857;
       

    }
}
