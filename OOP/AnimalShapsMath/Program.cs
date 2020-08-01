using System;

namespace OOPSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            //TWO WAYS TO initialize a class
            Animal fox = new Animal(){
                name = "Red",
                sound = "Raaww"
            };
            fox.MakeSound();
            Console.WriteLine(Animal.GetNumOfAnimals());

            Animal dog = new Animal("doggy", "woff");
            dog.MakeSound();
            Console.WriteLine(Animal.GetNumOfAnimals());

            //static class, do not need initialisation.
            Console.WriteLine(ShapeMath.GetArea("rectangle", 20, 50));

            //privateAnimal
            PrivateAnimal cat = new PrivateAnimal();
            cat.SetName("Katty");

            //AnimalProperty
            AnimalProperty ap = new AnimalProperty("num123", "animalproperty");
            Console.WriteLine(ap.Num);
            ap.Num = "123";
            Console.WriteLine(ap.Num);
            Console.WriteLine(ap.Name);
            ap.Name = "new name";
            Console.WriteLine(ap.Name);
            
        }
    }

}