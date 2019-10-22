using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[7];
            array1[0] = 55; // this sets element '0' = 55
            Console.WriteLine($"array1[0]: {array1[0]}");
            Console.WriteLine($"array1[6]: {array1[6]}");

            //Console.WriteLine($"array1[7]: {array1[7]}");
            //^note: results in an index out of range exception

            Console.WriteLine(array1); //will not print out the elements of the array
            
            foreach(int number in array1)
            {
                Console.WriteLine(number);
            }

        }
    }
}
