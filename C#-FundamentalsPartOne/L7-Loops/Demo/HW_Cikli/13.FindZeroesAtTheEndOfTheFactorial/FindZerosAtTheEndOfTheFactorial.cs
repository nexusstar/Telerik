/** Write a program that calculates for given N how many trailing zeros present at the end of the number N!. Examples:
	N = 10  N! = 3628800  2
	N = 20  N! = 2432902008176640000  4
	Does your program work for N = 50 000?
	Hint: The trailing zeros in N! are equal to the number of its prime divisors of value 5. Think why!
 * 11.  Броят на нулите в края на n! зависи от това, колко пъти числото  10  е 
делител  на  факториела.  Понеже  произведението  1*2*3…*n  има 
повече на брой делители 2, отколкото 5, а 10 = 2 * 5, то броят нули в 
n!  е  точно  толкова,  колкото  са  множителите  със  стойност  5  в 
произведението  1*2*3….*n.  Понеже всяко пето число  се дели на 5, а 
всяко  25-то  число  се  дели  на  5  двукратно  и  т.н.,  то  броя  нули  в  n!  е 
сумата: n/5 + n/25 + n/125 + …
*/
using System;

class FindZerosAtTheEndOfTheFactorial
{
    static void Main()
    {
        uint n, zeros;

        Console.Write("Please enter N: ");
        bool isNValid = uint.TryParse(Console.ReadLine(), out n);

        if (isNValid)
        {
            zeros = 0;

            Console.Write("\nN = {0} -> {0}! -> ", n);

            for (int i = 5; i <= n; i *= 5)
            {
                zeros += (uint)(n / i);
            }

            Console.WriteLine("{0} zeros\n", zeros);
        }
        else
        {
            Console.WriteLine("Please enter valid number:");
        }
    }
}
