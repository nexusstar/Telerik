namespace _02_Bank
{
    using System;
    public class Mortage : Account, IDepositable
    {
        private const int IndividualPromoMounths = 6;
        private const decimal IndividualPromoCoeficient = 0;
        private const int CompanyPromoMonths = 12;
        private const decimal CompanyPromoCoeficient = 0.5m;
        

        public Mortage(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate) { }

        
        public void DepositMoney(decimal amount)
        {
            this.Balance += amount;
        }
        public override decimal GetInterestAmout(int numberOfMonths)
        {
            switch (this.Customer.CustomerType)
            {
                case CustomerType.Individual:
                    if (numberOfMonths<=6)
                    {
                        return numberOfMonths * IndividualPromoCoeficient;
                    }
                    else
                    {
                        
                        return this.InterestRate * (numberOfMonths - IndividualPromoMounths) +
                            IndividualPromoMounths * IndividualPromoCoeficient * this.InterestRate; //provided only for consistency if coef > 0 
                    }
                case CustomerType.Company:
                    if (numberOfMonths <= 12)
                    {
                        return this.InterestRate * CompanyPromoCoeficient * numberOfMonths;
                    }
                    else
                    {
                        return this.InterestRate * (numberOfMonths - CompanyPromoMonths) +
                            CompanyPromoMonths * CompanyPromoCoeficient * this.InterestRate;
                    }
            }

            throw new ArgumentException("Ivalid argument supplied");
        } 
    }
}
