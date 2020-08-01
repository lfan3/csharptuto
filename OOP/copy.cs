using System;

namespace CopySpace
{
    class Program
    {
        public static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Age = 24;
            p1.Name = "Peter";
            p1.IdInfo = new IdInfo(6655);

            Person p2 = p1.ShallowCopy();
            p1.Age = 55;
            p1.Name = "Sam";
            p1.IdInfo.IdNumber = 9988;
            display(p2);

            Person p3 = p1.DeepCopy();
            p1.Age = 66;
            p1.Name = "Jean";
            p1.IdInfo.IdNumber = 7766;
            display(p3);
        }
        public static void display(Person p)
        {
            Console.WriteLine("{0} has {1} years old, personal info {2}", p.Name, p.Age, p.IdInfo.IdNumber);
        }
    }


    public class IdInfo
    {
        public int IdNumber;
        public IdInfo(int IdNumber)
        {
            this.IdNumber = IdNumber;
        }
    }
    public class Person
    {
        public int Age;
        public string Name;
        public IdInfo IdInfo;

        //public object Shallowcopy()
        //MemberwiseClone() return an object
        public Person ShallowCopy()
        {
            return (Person) this.MemberwiseClone();
        }

        public Person DeepCopy()
        {
            Person other = (Person) this.MemberwiseClone();
            other.IdInfo = new IdInfo(IdInfo.IdNumber);
            other.Name = String.Copy(Name);
            return other;
        }
    }

}