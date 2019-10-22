using System;

namespace ForLoopArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] animals = { "dog", "tiger", "wombat", "cat", "emu", "koala bear", "huntsman spider", "platypus", "kangaroo" };
            ListOutArray(animals);
            
        }
        public static void ListOutArray (string[] array)
        {
            for(int i = 0; i < array.Length ; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
