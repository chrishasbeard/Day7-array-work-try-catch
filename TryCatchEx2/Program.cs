using System;

namespace TryCatchEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = ParseString("Give me a  number!");

        }

        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return input;
            //return Console.ReadLine();
        }

      c
    }
}
