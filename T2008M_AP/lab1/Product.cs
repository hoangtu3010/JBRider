using System;
using System.Collections.Generic;

namespace T2008M_AP.lab1
{
    public class Product
    {
        public int id;
        public string name;
        public decimal price;
        public int qty;
        public string image;
        public string desc;
        public List<string> gallery = new List<string>();

        public Product()
        {
        }

        public Product(int id, string name, decimal price, int qty, string image, string desc)
        {
            this.id = id;
            this.name = name;
            this.price = price;
            this.qty = qty;
            this.image = image;
            this.desc = desc;
            gallery = new List<string>();
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public decimal Price
        {
            get => price;
            set => price = value;
        }

        public int Qty
        {
            get => qty;
            set => qty = value;
        }

        public string Image
        {
            get => image;
            set => image = value;
        }

        public string Desc
        {
            get => desc;
            set => desc = value;
        }

        public List<string> Gallery
        {
            get => gallery;
            set => gallery = value;
        }

        public void getInfo()
        {
            Console.WriteLine("id: " + id);
            Console.WriteLine("name: " + name);
            Console.WriteLine("price: " + price);
            Console.WriteLine("amount: " + qty);
            Console.WriteLine("image: " + image);
            Console.WriteLine("desc: " + desc);
            Console.WriteLine("gallery: ");
            foreach (var item in gallery)
            {
                Console.Write(item + "\n");
            }
        }

        public bool checkQty()
        {
            if (qty > 0 )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool addImage(string image)
        {
            if (gallery.Count >= 10)
            {
                return false;
            }
            gallery.Add(image);
            return true;
        }

        public bool deleteImage(string image)
        {
            gallery.Remove(image);
            return true;
        }
    }
}