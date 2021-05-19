using System;
using T2008M_AP.lab1;

namespace T2008M_AP.lab2
{
    public class Diamon : Product
    {
        public int cara;

        public bool checkAuFa()
        {
            if (cara > 1)
                return true;
            return false;
        }
    }
}