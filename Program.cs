using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human hum = new Human("poop");
        }
    }
    class Human
    {
        // Fields for Human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int health { get; }

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
        }
    }

}
