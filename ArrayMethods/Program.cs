
using System;

namespace ArrayMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tvArray = { "Game of Thrones", "Walking Dead", "Barry", "Southpark", "Futurama", "Samuri Jack" };
            // this is creating a reference to tvArray called tvShowArray
            string[] tvShowArray = tvArray;
            // anychanges to tvArray will also affect the tvShowArray

            tvShowArray[3] = "Breaking Bad";
            Console.WriteLine(tvArray[3]);

            string[] copyTvArray = new string[tvArray.Length];// this will copy tvArray to copyTvArray
            tvArray.CopyTo(copyTvArray, 0);

            copyTvArray[5] = "Parks and Rec";
            Console.WriteLine($"tvArray[5]: {tvArray[5]}, copyTvArray[5]: {copyTvArray[5]}");
            for (int i = 0; i < tvArray.Length;  i++)
            {
                Console.WriteLine($"tvArray[{i}]: {tvArray[i]},\t\t copyTvArray[{i}]: {copyTvArray[i]}");
            }
        }
    }
}
