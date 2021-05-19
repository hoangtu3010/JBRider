namespace T2008M_AP.lab1
{
    public interface Tools
    {
        void AddToCart(int id, decimal grandTotal, string city, string country);
        bool DeleteToCart(string i);
        bool GrandTotal(string c, string t);
    }
}