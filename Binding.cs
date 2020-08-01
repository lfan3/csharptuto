using System;
using System.Reflection;
using System.Collections;

namespace OOPSpace
{
    class Program
    {
        static void Main(string[] args)
            {
                //early binding, normal mode, easy
                /*
                Dog Tuffy = new Dog("tuffy","papillon", 5);
                string des = Tuffy.description();
                Console.WriteLine("Description = {0}", des);
*/
                /*
                Type objType1 = Tuffy.GetType();
                //??? nothing inside?
                PropertyInfo[] info = objType1.GetPsroperties();
                */

                //reflection is expensive for the speed!
                //late binding + reflection
                
                Assembly executingAssembly = Assembly.GetExecutingAssembly();
                Type DogType = executingAssembly.GetType("OOPSpace.Dog");
                object dogInstance = Activator.CreateInstance(DogType);
                MethodInfo descriptionMethod = DogType.GetMethod("description");

                string[] parameters = new string[2];
                parameters[0] = "Luffy";
                parameters[1] = "papillon";
     
                string luffy = (string)descriptionMethod.Invoke(dogInstance, parameters);
            }


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
    
}