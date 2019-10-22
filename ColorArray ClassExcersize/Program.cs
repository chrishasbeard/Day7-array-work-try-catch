using System;

namespace ColorArray_ClassExcersize
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "ben", "bob", "chris", "alex" };
            string[] alphabet = { "abcdefghijklmnopqrstuvwxyz" };
            Array.Sort(names);
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
            // the second part of this exercise will be to put the letters in each word in alphabetical order
            // Anna should post the solutions to this exercise tonight of dotnet repo
        }
    }
}
