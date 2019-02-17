using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Plant newPlant = new Plant("Hibiscus",34,45,67);
            Plant newPlant2 = new Plant("Rose", 24);
            Console.WriteLine("newPlant.Age");
            Flower BlueBells = new Flower();
            BlueBells.Age = 34;
            BlueBells.getFlowerColor();
            BlueBells.getPlantName();
        }
    }
    class Plant
    {
        private string name;
        private double height;
        private double weight;
        private int age;
        public Plant() //default constructor defined by developer //empty
        {

        }
        public Plant(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public Plant(string name, int age, int weight, int height)
        {
            Name = name;
            Age = age;
            Weight = weight;
            Height = height;
        }

        public string Name { get => name; set => name = value; } //setter
        public double Height { get => height; set => height = value; }
        public double Weight { get => weight; set => weight = value; }
        public int Age { get => age; set => age = value; }

        public void getPlantName()
        {
            Console.WriteLine("My name is" + Name);
        }
    }
    class Flower : Plant
    {
        private string worldRegion = "";

        public string WorldRegion { get => worldRegion; set => worldRegion = value; } // getter //property
        public void getFlowerColor()
        {
            Console.WriteLine("Blue");
        }
    }
}
