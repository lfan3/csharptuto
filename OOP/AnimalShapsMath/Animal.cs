using System;
using System.Linq;

namespace OOPSpace
{
    class Animal
    {
        public string name;
        public string sound;

        //static field/method: one change , all change
        static int numOfAnimals = 1;
        //constructor
        public Animal()
        {
            name = "No Name";
            sound = "No Sound";
        }
        //overload constructor
        public Animal(string name = "No Name", string s = "No sound")
        {
            //with this or not with this, both work
            this.name = name;
            sound = s;
            numOfAnimals = GetNumOfAnimals();
        }
        public void MakeSound()
        {
            Console.WriteLine("{0} says {1}", name, sound);
        }
        public static int GetNumOfAnimals()
        {
            return numOfAnimals++;
        }
    }

    class PrivateAnimal
    {
        private string name;
        private string sound;
        //const
        public const string SHELTER = "Home for Animals";
        //read only field:
        public readonly int idNum;
        public void MakeSound()
        {
            Console.WriteLine("{0} says {1}", name, sound);
        }
        //???constructor ???
        
        public PrivateAnimal()
        :this("No Name", "No Sound"){}
        public PrivateAnimal(string name)
        :this(name, "No Sound"){}
        
        public PrivateAnimal(string name, string Sound)
        {
            SetName(name);
            Sound = sound;

            NumOfAnimals = 1;

            Random rnd = new Random();
            idNum = rnd.Next(1, 214544);
        }
        public void SetName(string name)
        {
            if(!name.Any(char.IsDigit))
            {
                this.name = name;
            } else{
                this.name = "No Name";
                Console.WriteLine("Name can't contain numbers");
            }
        }
        public string GetName()
        {
            return name;
        }

        public string Sound
        {
            get {return sound;}
            set
            {
                if(value.Length > 10)
                {
                    sound = "No Sound";
                    Console.WriteLine("Sound is too long");
                }else{
                    sound = value;
                }
            }
        }

        public string Ower {get; set;} = "No Owner";
        public static int numOfAnimals = 0;
        public static int NumOfAnimals
        {
            get { return numOfAnimals;}
            set {numOfAnimals += value;}
        }
    }

    //class property understanding
    class AnimalProperty
    {
        private string num;
        public AnimalProperty(string num, string name)
        {
            Num = num;
            Name = name;
        }
        public string Num
        {
            get{return num;}
            set{num = value;}
        }
        //short hand, do not need to declare the private field
        public string Name{get; set;}
    }
    
}