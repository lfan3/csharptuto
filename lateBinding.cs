using System;
using System.Reflection;
using System.Collections;

namespace LateBinding
{
    public class Program
    {
        static void Main()
        {
            Assembly ass = Assembly.GetExecutingAssembly();
            Type CustomerType = ass.GetType("LateBinding.Customer");
            object CustomerInstance = Activator.CreateInstance(CustomerType);
            MethodInfo GetfullnameMethod = CustomerType.GetMethod("GetFullName");

            string[] param = new string[2]{"Tim", "WaterMann"};
            string fullName = (string)GetfullnameMethod.Invoke(CustomerInstance, param);
            Console.WriteLine(fullName);
        }
    }

    public class Customer
    {
        public string GetFullName(string firstname, string secondname)
        {
            return firstname+" "+secondname;
        }
    }
}