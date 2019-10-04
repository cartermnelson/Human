using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human hum = new Human("Sven");
            Human hum2 = new Human("Sbeve", 4, 4, 4, 200);
            Console.WriteLine(hum.Attack(hum2));
        }
    }
    class Human
    {
        // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health { get; set; }

        // add a public "getter" property to access health

        // Add a constructor that takes a value to set Name, and set the remaining fields to default values
        public Human(string nam)
        {
            Name = nam;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }

        // Add a constructor to assign custom values to all fields
        public Human(string nam, int str, int intel, int dex, int heal)
        {
            Name = nam;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            health = heal;
        }

        // Build Attack method
        public int Attack(Human target)
        {
            target.health -= 5*Strength;
            return target.health;
        }
    }

}
