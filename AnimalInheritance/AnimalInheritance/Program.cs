using System;
using System.Drawing;
using static System.Console;

namespace AnimalInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal= new Animal();
            myAnimal.setName("Kilo");
            myAnimal.setType("Dog");
            myAnimal.color = "Brown";

            Reptile myReptile= new Reptile();
            myReptile.setName("Chi");
            myReptile.setType("Lizard");
            myReptile.color = "Tan";
            myReptile.setSpecies("Bearded Dragon");
            myReptile.setNumberOfLegs(4);
            myReptile.setClimateLife("Desert");

            WriteLine("Animal Information");
            WriteLine($"Name: {myAnimal.getName()}");
            WriteLine($"Type: {myAnimal.getType()}");
            WriteLine($"Color: {myAnimal.color}");
            WriteLine();
            WriteLine("Reptile Information");
            WriteLine($"Name: {myReptile.getName()}");
            WriteLine($"Type: {myReptile.getType()}");
            WriteLine($"Color: {myReptile.color}");
            WriteLine($"Species: {myReptile.getSpecies()}");
            WriteLine($"Number of Legs {myReptile.getNumberOfLegs()}");
            WriteLine($"Climate: {myReptile.getClimateLife()}");
        }
    }

    class Animal
    {
        private string name; // only accessible within this class
        protected string type; //accessible from derived classes
        public string color;  // accessible from any class

        public void setName(string name)
        {
            this.name = name;
        }
        public virtual string getName()
        {
            return this.name;
        }
        public void setType(string type)
        {
            this.type = type;
        }
        public virtual string getType()
        {
            return this.type;
        }
    }

    class Reptile : Animal
    {
        private string _species;
        private int _numberOfLegs;
        private string _climateLife;
        
        public void setSpecies(string species)
        {
            _species = species;
        }
        public string getSpecies()
        {
            return _species;
        }
        public void setNumberOfLegs(int numberOfLegs)
        {
            _numberOfLegs = numberOfLegs;
        }
        public int getNumberOfLegs()
        {
            return _numberOfLegs;
        }
        public void setClimateLife(string climateLife)
        {
            _climateLife = climateLife;
        }
        public string getClimateLife()
        {
            return _climateLife;
        }
        public override string getName()
        {
            return base.getName();
        }
        public override string getType()
        {
            return base.getType();
        }
        
    }
}