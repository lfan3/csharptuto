using System;
using System.Reflection;

namespace OOPSpace
{
    public class Dog
    {
        string name;
        string breed;
        int age;
        
        public Dog(string name, string breed, int age)
        {
            this.name = name;
            this.breed = breed;
            this.age = age;
        }
        public string getName()
        {
            return name;
        }
        public string getBreed()
        {
            return breed;
        }
        public int getAge()
        {
            return age;
        }
        public string description()
        {
            return(
                "My name is "+ this.name +
                ". My breed is "+ this.breed +
                ". I am "+this.age+" years old.");
        }

    }
}