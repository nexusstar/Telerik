namespace _02_Bank
{
    using System; 
    public class Customer
    {
        private CustomerType customerType;
        private string name;

        public Customer(CustomerType type, string name)
        {
            this.CustomerType = type;
            this.Name = name;
        }

        public CustomerType CustomerType
        {
            get
            {
                return this.customerType;
            }
            protected set
            {
                switch (value)
                {
                    case CustomerType.Individual:
                    case CustomerType.Company:
                        this.customerType = value;
                        break;
                    default:
                        throw new ArgumentException("Invalid customer type");
                }   
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            protected set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Name must be larger than 2 letters");
                }
                this.name = value;
            }
        }
    }
}
