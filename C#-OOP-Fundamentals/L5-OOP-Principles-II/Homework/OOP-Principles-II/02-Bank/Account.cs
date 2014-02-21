namespace _02_Bank
{
    public abstract class Account
    {
        private Customer customer;
        private decimal balance;
        private decimal interstRate;

        public Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer Customer {
            get {
                return this.customer;
            }
            protected set
            {
                this.customer = value;
            }
        }
        public decimal Balance{
            get 
            {
                return this.balance;
            }
            protected set 
            {
                this.balance = value;
            }
        }
        public decimal InterestRate { 
            get {
                return this.interstRate;
            }
            protected set
            {
                this.interstRate = value;
            }
        }

        public virtual decimal GetInterestAmout(int numberOfMonths)
        {
            return numberOfMonths * this.interstRate;
        }
    }
}
