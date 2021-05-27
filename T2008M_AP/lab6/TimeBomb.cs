using System;
using System.Threading;

namespace T2008M_AP.lab6
{
    public class TimeBomb
    {
        public static void Main(string[] args)
        {
            new Thread(delegate(Object obj)
            {
                for (int i = 9; i >= 0; i--)
                {
                    for (int j = 59; j >= 0; j--)
                    {
                        try
                        {
                            Console.WriteLine(i + " : " + j);
                            Thread.Sleep(100);
                            Console.Clear();
                        }
                        catch (Exception e)
                        {
                        }
                    }
                }
                Console.WriteLine("BÙM ...");
            }).Start();
        }
    }
}