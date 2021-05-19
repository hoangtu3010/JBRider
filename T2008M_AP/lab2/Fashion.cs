using System;
using T2008M_AP.lab1;

namespace T2008M_AP.lab2
{
    public class Fashion : Product
    {
        public string color;
        public string size;

        public bool checkColorSize(string c, string s)
        {
            if (color.Equals(c) && size.Equals(s) && qty > 0)
                return true;
            return false;
        }
    }
}