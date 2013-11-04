using System;

class CalculatingVariable
{
    static void Main() 
    {
        float result = 0.0f;
        double number1 = 0.0;
        double number2 = 0.0;
        double number3 = 0.0;
        Console.WriteLine("Give me a numbers and I will add them with a precision of 7 signs :");

        Console.Write("Number ONE : ");
        number1 = double.Parse(Console.ReadLine());

        Console.Write("Number TWO : ");
        number2 = double.Parse(Console.ReadLine());

        Console.Write("Number THREE /not neceserry : ");
        double.TryParse(Console.ReadLine(), out number3);
      
        result = (float)(number1 + number2 + number3);
        Console.WriteLine(result);
    }
}