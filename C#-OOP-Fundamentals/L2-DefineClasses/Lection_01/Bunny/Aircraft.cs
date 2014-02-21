namespace Bunny
{
     public class Aircraft
    {
         public static int Weight
         {
             get
              {
                 return 250;
             }
         }
        
        public decimal Fuel { get; set; }
        public Aircraft()
        {
            this.Fuel = 200M;
        }
        
        public void Move()
        {
            this.Fuel -= 50;
        }
    }
}
