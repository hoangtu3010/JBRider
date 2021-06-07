namespace T2008M_AP.practical.exercise2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Lion l = new Lion();
            Tiger t = new Tiger();
            
            l.SetMe("tiger", 100);
            t.SetMe("lion", 200);
            
            l.show();
            t.show();
        }
    }
}