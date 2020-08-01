using System;
using System.Reflection;

namespace OOPSpace
{
    public class Dog
    {
        string name;
        string breed;
        
        public Dog(string name, string breed)
        {
            this.name = name;
            this.breed = breed;
        }
        public string getName()
        {
            return name;
        }
        public string getBreed()
        {
            return breed;
        }

        public string description()
        {
            return(
                "My name is "+ this.name +
                ". My breed is "+ this.breed);
        }

    }
}