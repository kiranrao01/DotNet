using System;

namespace ConsoleApplication
{
    class MainClass
    {
    //base class 
       class Human
        {
            public string name;
            public int strength;
            public float intelligence;

            public int dexterity;
            public double health;
            public Human(string person, int str, float intel, int dext, double heal)
            {
                name = person;
                strength = str;
                intelligence = intel;
                dexterity = dext;
                health = heal;                
            }
            // method

            public void printBase()
            {
                Console.WriteLine("Name:" + name);
                Console.WriteLine("Strength:" + strength);
                Console.WriteLine("Intelligence:" + intelligence);
                Console.WriteLine("Dexterity:" + dexterity);
                Console.WriteLine("Health:" + health);
            }
        }

        // Derived Class
           class Men : Human
            {
            public Men(string person, int str, float intel, int dext, double heal) : base(person, str, intel, dext, heal)
            {
            }

            public void attacker(){
                    base.strength -= 1;
                }
                public void defender(){
                    base.strength -= 5; 
                }
            } 
            class Woman : Human
            {
            public Woman(string person, int str, float intel, int dext, double heal) : base(person, str, intel, dext, heal)
            {
            }

            public void attacker(){
                    base.strength -= 1;
                }
                public void defender(){
                    base.strength -= 5; 
                }
            } 
        public static void Main(string[] args)
        {
            Men identity = new Men("John", 3, 0.9f,25,100);
            identity.printBase();
            Console.WriteLine();
            Woman id = new Woman("Liz", 3, 0.9f,25,100);
            id.printBase();
            id.attacker();
            id.defender();
            Console.WriteLine("new strength" + id.strength);
            
        }
    }
}