using System;

namespace T2008M_AP.lab5
{
    public delegate void ShowMath(float a, float b);
    
    public class Program
    {
        public static void Main(string[] args)
        {
            ShowMath sm1 = new ShowMath(Summation);
            sm1(4, 2);
            ShowMath sm2 = new ShowMath(new Program().Subtraction);
            sm2(4, 2);
            ShowMath sm3 = new ShowMath(Multiplication);
            sm3 += new Program().devision;
            sm3(5, 2);

        }

        public static void Summation(float a, float b)
        {
            float s = a + b;
            Console.WriteLine("Tong: " + s);
        }

        public void Subtraction(float a, float b)
        {
            float s = a - b;
            Console.WriteLine("Hieu: " + s);
        }

        public static void Multiplication(float a, float b)
        {
            float s = a * b;
            Console.WriteLine("Tich: " + s);
        }

        public void devision(float a, float b)
        {
            float s = a / b;
            Console.WriteLine("Thuong: " + s);
        }
    }
}