namespace T2008M_AP.lab4
{
    public class CustomerNN : Customer
    {
        public string nationality;

        public CustomerNN(int id, string name, string dateTime, int amount, string nationality) : base(id, name, dateTime, amount)
        {
            this.nationality = nationality;
        }

        public string Nationality
        {
            get => nationality;
            set => nationality = value;
        }

        public override double totalPrice()
        {
            return amount * 2000;
        }
    }
}