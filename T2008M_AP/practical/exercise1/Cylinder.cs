using System;

namespace T2008M_AP.practical
{
    public class Cylinder
    {
        public double Radius;
        public double Height;
        public double BaseArea;
        public double LateralArea;
        public double TotalArea;
        public double Volume;


        public Cylinder()
        {
        }

        public Cylinder(double radius, double height, double baseArea, double lateralArea, double totalArea, double volume)
        {
            Radius = radius;
            Height = height;
            BaseArea = baseArea;
            LateralArea = lateralArea;
            TotalArea = totalArea;
            Volume = volume;
        }

        public double Radius1
        {
            get => Radius;
            set => Radius = value;
        }

        public double Height1
        {
            get => Height;
            set => Height = value;
        }

        public double BaseArea1
        {
            get => BaseArea;
            set => BaseArea = value;
        }

        public double LateralArea1
        {
            get => LateralArea;
            set => LateralArea = value;
        }

        public double TotalArea1
        {
            get => TotalArea;
            set => TotalArea = value;
        }

        public double Volume1
        {
            get => Volume;
            set => Volume = value;
        }

        public void Process()
        {
            Console.WriteLine("Enter the dinenstions of the cylinder");
            Console.WriteLine("Radius: ");
            Radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Height: ");
            Height = Convert.ToDouble(Console.ReadLine());
            BaseArea = Radius * Radius * Math.PI;
            LateralArea = 2 * Math.PI * Radius * Height;
            TotalArea = 2 * Math.PI * Radius * (Height + Radius);
            Volume = Math.PI * Radius * Radius * Height;
        }

        public void Result()
        {
            Console.WriteLine("Cylinder Characteristics");
            Console.WriteLine("Radius: " + Radius + ", " + "Height: " + Height);
            Console.WriteLine("Base: " + BaseArea + " | " + "Lateral: " + LateralArea + " | " + "Total: " + TotalArea + " | " + "Volume: " + Volume);
        }
        
    }
}