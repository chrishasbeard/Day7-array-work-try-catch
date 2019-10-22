using System;

namespace day7_class_work_try_catch_software_test
{
    //THIS IS AN EXTENSION OF THE DAY SIX REGULAR EXPRESSION CLASSWORK
    //THIS IS TRY CATCH EXAMPLE ONE
    class Program
    {
        static void Main(string[] args)
        {
            try ///if
            {
                Console.WriteLine("Please enter a number: ");
                int input1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter another number: ");
                int input2 = int.Parse(Console.ReadLine());

                int result = input1 / input2;
                Console.WriteLine(result);

            }
            catch (FormatException) //else if for try catch statement
            {
                Console.WriteLine("Bad input, we need a #");
            }
            catch (DivideByZeroException) //else if
            {
                Console.WriteLine("Cannot divide by zero.");
            }
            catch (OverflowException) // else if
            {
                Console.WriteLine("That number is tooooo big!");
            }
            catch //else
            {
                throw new Exception("Something went wrong.");
            }
        }
    }
}
