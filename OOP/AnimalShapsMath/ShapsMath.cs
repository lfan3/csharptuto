using System;

namespace OOPSpace
{
    //static class contain only static method or const value
    public static class ShapeMath
    {
        public static double GetArea(string shape="", double len1=0, double len2=0)
        {
            if(String.Equals("Rectangle", 
                shape, 
                StringComparison.OrdinalIgnoreCase))
            {
                return len1 * len2;
            }else if(string.Equals("Circle", shape, StringComparison.OrdinalIgnoreCase))
            {
                return 3.1415 * Math.Pow(len1, 2);
            }else{
                return -1;
            }
        }
    }
}