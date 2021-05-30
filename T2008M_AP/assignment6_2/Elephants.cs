using System;

namespace T2008M_AP.assignment6_2
{
    public class Elephants : Species, BodyCharacteristics, Diet, Reproduction, Domestication
    {
        public string name;
        public string height;
        public string weight;

        public Elephants()
        {
        }

        public Elephants(string name, string height, string weight)
        {
            this.name = name;
            this.height = height;
            this.weight = weight;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Height
        {
            get => height;
            set => height = value;
        }

        public string Weight1
        {
            get => weight;
            set => weight = value;
        }

        public void African()
        {
            name = "African";
            height = "4m";
            weight = "7000kg";
            Console.WriteLine("Name: " + name + " - " + "Height: " + height + " - " + "Weight: " + weight);
        }

        public void Asian()
        {
            name = "Asian";
            height = "3,4m";
            weight = "5400kg";
            Console.WriteLine("Name: " + name + " - " + "Height: " + height + " - " + "Weight: " + weight + "\n");
        }

        public void Trunk()
        {
            Console.WriteLine("- Trunk: Is used to tear up their food and then, place it in their mouth");
        }

        public void Tusk()
        {
            Console.WriteLine("- Tusk: Used to dig for water, salt, and roots; to debark trees, to eat the bark; to dig into baobab trees to get at the pulp inside; and to move trees and branches when clearing a path");
        }

        public void Teeth()
        {
            Console.WriteLine("- Teeth: They usually have 28 teeth");
        }

        public void Skin()
        {
            Console.WriteLine("- Skin: It is extremely tough around most parts of its body and measures about 2.5 cm (1 in) thick");
        }

        public void Legs()
        {
            Console.WriteLine("- Legs: They are great straight pillars, as they must be to support its bulk weight");
        }

        public void Ears()
        {
            Console.WriteLine("- Ears: Elephant ears are made of a very thin layer of skin stretched over cartilage and a rich network of blood vessels \n");
        }

        public void Herbivores()
        {
            Console.WriteLine("- Herbivores: Elephants are herbivores, spending 16 hours a day collecting plant food \n");
        }

        public void Interval()
        {
            Console.WriteLine("- Interval: Females give birth at intervals of about every 5 years");
        }

        public void Weight()
        {
            Console.WriteLine("- Weight: At birth, calves weigh around 90-115 kgs \n");
        }

        public void Use()
        {
            Console.WriteLine("- Use: Elephants have been working animals used in various capacities by humans \n");
        }

        public void ShowInfo()
        {
            Console.WriteLine("Species: \n");
            African();
            Asian();
            
            Console.WriteLine("Body Characteristics: \n");
            Trunk();
            Tusk();
            Teeth();
            Skin();
            Legs();
            Ears();
            
            Console.WriteLine("Diet: \n");
            Herbivores();
            
            Console.WriteLine("Reproduction: \n");
            Interval(); 
            Weight();
            
            Console.WriteLine("Domestication: \n");
            Use();
        }
    }
}