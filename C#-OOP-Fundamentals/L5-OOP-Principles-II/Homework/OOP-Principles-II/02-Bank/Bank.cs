namespace _02_Bank
{
    using System;
    using System.Collections.Generic;
    public class Bank
    {
        private List<Account> bankAccounts;
        private List<Customer> bankCustomers;

        public Bank()
        {
            this.bankAccounts = new List<Account>();
            this.bankCustomers = new List<Customer>();
        }
        public List<Account> BankAccounts
        {
            get
            {
                return new List<Account>(this.bankAccounts);
            }
            
        }

        public List<Customer> BankCusomers
        {
            get
            {
                return new List<Customer>(this.bankCustomers);
            }
            
        }

        public void AddCustomer(Customer customer)
        {
            this.bankCustomers.Add(customer);
        }
        public void AddAccount(Account account)
        {
            this.bankCustomers.Add(account.Customer);
            this.bankAccounts.Add(account);
        }
    }
}
