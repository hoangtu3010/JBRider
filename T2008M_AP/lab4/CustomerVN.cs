namespace T2008M_AP.lab4
{
    public class CustomerVN : Customer
    {
        public string userObject;

        public CustomerVN(int id, string name, string dateTime, int amount, string userObject) : base(id, name, dateTime, amount)
        {
            this.userObject = userObject;
        }

        public string UserObject
        {
            get => userObject;
            set => userObject = value;
        }

        public override double totalPrice()
        {
            if (amount <= 50)
            {
                return amount * 1000; 
            }else if(amount > 50 && amount <= 100)
            {
                return (amount - 50) * 1200 + 50 * 1000;
            }else if (amount > 100 && amount <= 200)
            {
                return (amount - 100) * 1500 + 50 * 1200 + 50 * 1000;
            }
            else
            {
                return (amount - 200) * 2000 + 100 * 1500 + 50 * 1200 + 50 * 1000;
            }
        }
        
    }
}