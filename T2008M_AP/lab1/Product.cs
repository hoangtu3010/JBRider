using System;
using System.Collections;

namespace T2008M_AP.lab1
{
    public class Product
    {
        public int id;
        public string name;
        public int qty;
        public string image;
        public string desc;
        public ArrayList gallery = new ArrayList();

        public Product()
        {
        }

        public Product(int id, string name, int qty, string image, string desc, ArrayList gallery)
        {
            this.id = id;
            this.name = name;
            this.qty = qty;
            this.image = image;
            this.desc = desc;
            this.gallery = gallery;
        }

        public void getInfo()
        {
            Console.WriteLine("id: " + id);
            Console.WriteLine("name: " + name);
            Console.WriteLine("qty: " + qty);
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

        public void addImage()
        {
            int c = 8;
            for (int i = 0; i < gallery.Count; i++)
            {
                if (gallery.Count < 10)
                {
                    Console.Write("Them anh: ");
                    string img = Console.ReadLine();
                    gallery.Add(c + " - " + img);
                    c++;
                }
                else
                {
                    Console.Write("So luong anh da vuot qua 10, moi ban xoa bo 1 anh! \n");
                    return;
                }
            }
            
            
        }

        public void deleteImage()
        {
            foreach (var item in gallery)
            {
                Console.Write(item + "\n");
            }
            
            Console.WriteLine("Vui long chon anh muon xoa: ");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < gallery.Count; i++)
            {
                if (n == i)
                {
                    gallery.Remove(i);
                    Console.Write("Da xoa " + gallery[i] + "\n");
                    return;
                }
            }
        }
    }
}