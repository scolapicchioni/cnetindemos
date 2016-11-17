using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //we define an array with the [] notation
            int[] listOfInt;
            string[] listOfString;
            //we initialize an array with this notation
            listOfInt = new int[10]; //ten times 0
            listOfString = new string[5]; //ten times null
            //we can also initialize it during declaration

            decimal[] listOfDecimals = new decimal[10]; //ten times 0

            //but if we know all the items to use at declaration time, we can initialize them as well
            long[] listOfLongs = {10,20,30,40,50}; //5 elements in total

            //we have to initialize them all, this won't compile
            //long[] wrongListOfLongs = new int[10] {10,20,30,40,50}; //10 elements in total but only 5 initialized

            //the Length property of an array tells us how many items it can store
            Console.WriteLine(listOfInt.Length); //10

            //there is no property to tell us how many items we have initialized so far 
            
            //to access an item we use an indexer
            System.Console.WriteLine(listOfInt[2]); //third item, an array is zero-based

            //we can scroll the whole list with a for using indexer and Length
            for (int i = 0; i < listOfInt.Length; i++)
            {
                System.Console.WriteLine(listOfInt[i]);
            }

            //or we can scroll it with a foreach
            foreach (int item in listOfInt)
            {
                System.Console.WriteLine(item);
            }

            //arrays are reference types
            int[] listOfInt2 = listOfInt;
            listOfInt2[0] = 1234567890;
            System.Console.WriteLine(listOfInt[0]); //1234567890

            //we can also define multidimensional arrays
            int[,] grid = new int[5,3]
            {
                {1,2,3},
                {2,4,6},
                {8,2,9},
                {4,8,1},
                {8,1,0}
            };
            for (int r = 0; r < grid.GetLength(0); r++) //getLength(0) == 5
            {
                for (int c = 0; c < grid.GetLength(1); c++) //getLength(1) == 3
                {
                    System.Console.WriteLine($"grid[{r},{c}] == {grid[r,c]}");
                }
            }
        }
    }
}
