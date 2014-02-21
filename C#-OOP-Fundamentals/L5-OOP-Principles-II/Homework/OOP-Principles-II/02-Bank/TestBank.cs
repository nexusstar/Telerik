namespace _02_Bank
{
    using System;
    class TestBank
    {
        static void Main()
        {
            Bank MGM = new Bank();
            Customer pesho = new Customer(CustomerType.Individual, "Pesho Peshev");
            Customer telerik = new Customer(CustomerType.Company, "Telerik AD");

            Mortage mortageAccount = new Mortage(pesho, 10000M, 0.666M);
            Deposit depositAccount = new Deposit(telerik, 10000m, 0.066M);

            MGM.AddAccount(mortageAccount);
            MGM.AddAccount(depositAccount);

        }
    }
}
