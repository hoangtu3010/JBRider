using System;


namespace T2008M_AP.lab1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Product pr = new Product();
            pr.id = 1;
            pr.name = "Iphone 13";
            pr.price = 1000;
            pr.qty = 10;
            pr.image = "Anh dep";
            pr.desc = "xuong";
            pr.getInfo();
            if (pr.checkQty())
            {
                Console.WriteLine("con hang");
            }
            else
            {
                Console.WriteLine("het hang");
            }
            pr.addImage("anh 1");
            pr.deleteImage("anh 1");
        }
    }
}