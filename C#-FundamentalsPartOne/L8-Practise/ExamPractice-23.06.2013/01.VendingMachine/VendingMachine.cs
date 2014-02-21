using System;

class VendingMachine
{
    static void Main()
    {
        int n_005_Cent = int.Parse(Console.ReadLine());
        int n_010_Cent = int.Parse(Console.ReadLine());
        int n_020_Cent = int.Parse(Console.ReadLine());
        int n_050_Cent = int.Parse(Console.ReadLine());
        int n_100_Cent = int.Parse(Console.ReadLine());
        int wholeAmout = (n_005_Cent * 5 + n_010_Cent * 10 + n_020_Cent * 20 + n_050_Cent * 50 + n_100_Cent * 100);

        float amauntA = float.Parse(Console.ReadLine());
        float priceP = float.Parse(Console.ReadLine());
        //first convert it to st.
        //second del it to amounts
        int amountAcents = (int)amauntA * 100;

        int pricePcents = (int)priceP * 100;
        if (priceP > amauntA)
        {
            Console.Write("More {0:F2}", (priceP - amauntA));
        }
        else if (priceP < amauntA && (amountAcents - pricePcents) > wholeAmout)
        {
            Console.Write("No {0:F2}", (float)((amountAcents - pricePcents) - wholeAmout) / 100f); ;
        }
        else
        {
            Console.Write("Yes");
            Console.WriteLine(" {0:F2}", (float)((wholeAmout / 100f) - (amauntA - priceP)));

        }

    }
}
