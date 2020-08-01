using System;

namespace ParticalClassSpace
{
    public partial class Program
    {
        public static void Main(string[] args)
        {
            ParticalClass pc = new ParticalClass("author_name", 5);
            pc.display();
        }
    }
}