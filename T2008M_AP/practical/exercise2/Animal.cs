using System;

namespace T2008M_AP.practical.exercise2
{
    public class Animal
    {
        public string name = "";
        public int weight = 0;
        
        public virtual void show()
        {
            Console.WriteLine("Name: " + name +", " + "Weight: " + weight);
        }

        public virtual void SetMe(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }
    }
}