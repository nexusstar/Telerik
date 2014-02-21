namespace _02_Bank
{
    using System;
    public class Deposit : Account, IDepositable, IWithdrawable
    {
        public Deposit(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate) { }

        
        public void DepositMoney(decimal amount)
        {
            this.Balance += amount;
        }

        public void WithDrawMoney(decimal amount)
        {
            if ((this.Balance - amount) < 0)
            {
                throw new ArgumentOutOfRangeException("Not sufficient balance");
            }
            this.Balance -= amount;
        }

        public override decimal GetInterestAmout(int numberOfMonths)
        {
            if (this.Balance > 0 || this.Balance < 0 )
            {
                this.InterestRate = 0;
            }
            return numberOfMonths * this.InterestRate;
        } 
    }
}
