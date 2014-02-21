using System;

class IfSwitch
{
    /// <summary>
    /// ex.1 - Write an if statement that examines two integer variables and exchanges their values 
    /// if the first one is greater than the second one.
    /// </summary>
    static void Main()
    {
        string firstValue;
        int firstNum;
        do
        {
            Console.Write("Please enter first int: ");
            firstValue = Console.ReadLine();
        } while (!int.TryParse(firstValue, out firstNum));
        string secondValue;
        int secondNum;
        do
        {
            Console.Write("Please enter second int: ");
            secondValue = Console.ReadLine();
        } while (!int.TryParse(secondValue, out secondNum));

        if (firstNum > secondNum)
        {
            firstNum = firstNum + secondNum;
            secondNum = firstNum - secondNum;
            firstNum = firstNum - secondNum;
            Console.WriteLine("First Value {0}, second value {1}", firstNum, secondNum);
        }
        else
        {
            Console.WriteLine("First value is not greater no switch is executed");
        }
    }
}