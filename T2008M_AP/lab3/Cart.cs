using System;
using System.Collections.Generic;
using T2008M_AP.lab1;

namespace T2008M_AP.lab3
{
    public class Cart : Product, Tools
    {
        public int id;
        public decimal grandTotal = 0;
        public List<string> productList;
        public string city;
        public string country;

        public Cart()
        {
            productList = new List<string>();
        }

        public Cart(int id, decimal grandTotal, string city, string country)
        {
            this.id = id;
            this.grandTotal = grandTotal;
            productList = new List<string>();
            this.city = city;
            this.country = country;
        }

        public void AddToCart(int id, decimal grandTotal, string city, string country)
        {
            productList.Add(Convert.ToString(id));
            productList.Add(Convert.ToString(grandTotal));
            productList.Add(city);
            productList.Add(country);
        }

        public bool DeleteToCart(string i)
        {
            for (int j = 0; j < productList.Count; j++)
            {
                if (id.Equals(i))
                {
                    productList.Remove(productList[j]);
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
    }
}