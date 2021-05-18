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
            pr.qty = 10;
            pr.image = "Anh dep";
            pr.desc = "xuong";
            pr.gallery.Add("0 - anh 1");
            pr.gallery.Add("1 - anh 2");
            pr.gallery.Add("2 - anh 3");
            pr.gallery.Add("3 - anh 4");
            pr.gallery.Add("4 - anh 5");
            pr.gallery.Add("5 - anh 6");
            pr.gallery.Add("6 - anh 7");
            pr.gallery.Add("7 - anh 8");
            pr.getInfo();
            if (pr.checkQty())
            {
                Console.WriteLine("con hang");
            }
            else
            {
                Console.WriteLine("het hang");
            }
            pr.addImage();
            pr.deleteImage();
        }
    }
}