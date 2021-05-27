using System;
using System.Collections.Generic;
using T2008M_AP.lab1;

namespace T2008M_AP.lab3
{
    public delegate void ChangeList();
    
    public class Cart : Product, Tools
    {
        public int id;
        public decimal grandTotal = 0;
        public List<string> productList;
        public string city;
        public string country;

        public event ChangeList CheckList;

        public Cart()
        {
            productList = new List<string>();
            if (CheckList == null)
            {
                CheckList += AddToCart;
            }
        }

        public Cart(int id, decimal grandTotal, string city, string country)
        {
            this.id = id;
            this.grandTotal = grandTotal;
            productList = new List<string>();
            this.city = city;
            this.country = country;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public decimal GrandTotal1
        {
            get => grandTotal;
            set => grandTotal = value;
        }

        public string City
        {
            get => city;
            set => city = value;
        }

        public string Country
        {
            get => country;
            set => country = value;
        }

        public void ShowList()
        {
            foreach (var l in productList)
            {
                Console.WriteLine(l);
            }
        }

        public void AddToCart()
        {
            Console.WriteLine("Nhap id: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap tong tien: ");
            grandTotal = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Nhap thanh pho: ");
            city = Console.ReadLine();
            Console.WriteLine("Nhap quoc gia: ");
            country = Console.ReadLine() + "\n";
            productList.Add(Convert.ToString(id));
            productList.Add(Convert.ToString(grandTotal));
            productList.Add(city);
            productList.Add(country);
        }

        public bool DeleteToCart()
        {
            Console.WriteLine("Nhap id can xoa: ");
            int i = Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j < productList.Count; j++)
            {
                if (id.Equals(i))
                {
                    productList.Remove(productList[j]);
                    ShowList();
                    return true;
                }
            }
            return false;
        }
        
        public bool GrandTotal(string c, string t)
        {
            if (country.Equals(t))
            {
                if (t == "VietNam")
                {
                    if (city.Equals(c))
                    {
                        if (c == "HN" || c == "HCM")
                            grandTotal += (price + ((price * 1) / 100));
                        grandTotal += (price + ((price * 2) / 100));
                    }
                }
                grandTotal += (price + ((price * 5) / 100));
            }
            return false;
        }

        public bool ChangeAddList(List<string> newList)
        {
            productList = newList;
            CheckList();
            return true;
        }
    }
}