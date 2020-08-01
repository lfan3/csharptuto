
using System;

namespace Array
{
    class Program
    {   
        public static void Main()
        {
            //3 ways to declare 1D array
            int[] array = {1,2,3};
            Console.WriteLine(array[0]);

            string[] array3 = new string[2];
            array3[0] = "ab";
            array3[1] = "ef";
            Console.WriteLine(array3[1]);

            string[] week = new string[2]{"lundi", "mardi"};
            Console.WriteLine(week[0]);

            //nested array
            //multiple dimentions array: 2D
            int[,] mulArray1 = new int[,]{
                {1, 2}, {3, 4}, {5, 6}, {7, 8}
            };

            int[,] mulArray2 = new int[4,2]{
                {1,2}, {3,4}, {5,6}, {7,8}
            };
            Console.WriteLine("2DArray[0][1] : " + mulArray1[0, 1]); 
            Console.WriteLine("2DArray[0][1] : " + mulArray2[0, 1]); 

            //multiple dimentions array:3D
            int [,,] mulArray3 = new int[2,2,3]{
                {{1,2,3},{1,2,3}},
                {{1,2,3},{1,2,3}}
            };
            Console.WriteLine("3DArray[1][0][1] : " 
                           + mulArray3[1, 0, 2]); 

            //jagged array
            int[][] jagged1 = new int[2][];
            jagged1[0]= new int[2]{2,4};
            jagged1[1]= new int[3]{1,3,5};

            int[][] jagged2 = {new int[2]{5,6}, new int[3]{7,8,9}};
            
            for(int i = 0; i<jagged1.Length; i++)
            {
                for(int j=0; j<jagged1[i].Length; j++)
                {
                    Console.WriteLine("jagged1["+i+"]["+j+"]" + jagged1[i][j]);
                }
            }

            //jagged + 2d array
            int [][,] mixJagged = new int[3][,];
            mixJagged[0]= new int[,]{{1,2,3},{5,6,4}, {3,4,9}};
            mixJagged[1]= new int[,]{{4,2},{8,6},{4,6}};
            mixJagged[2]= new int[,]{{6,2},{9,6}};
            //get the first dimention length of mixJagged[1]:3
            Console.WriteLine(mixJagged[1].GetLength(0));
            //get the second dimention length of mixJagged[1]:2
            Console.WriteLine(mixJagged[1].GetLength(1));
            //Rank get the dimention of the array: 2dimentions array
            Console.WriteLine(mixJagged[0].Rank);
            //9
            Console.WriteLine(mixJagged[0].Length);
            //6
            Console.WriteLine(mixJagged[1].Length);
            //3
            Console.WriteLine(mixJagged.Length);

            for(int i=0; i<mixJagged.Length; i++)
            {
                int Dimention = 0;
                for(int j=0; j<mixJagged[i].GetLength(Dimention); j++)
                {
                    for (int k=0; k<mixJagged[i].GetLength(Dimention+1); k++)
                    {
                        Console.WriteLine("mixJagged[" + i + "]["+j+", "+k+"]:"+ mixJagged[i][j, k]);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

            }

      
            
        }

    }
    
}





