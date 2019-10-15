using System;

namespace NumbersGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Something");
            StartSequence();
            try
            {

            }
            catch
            {

            }
            finally
            {
                Console.WriteLine("Program is done");
            }
        }

        public static void StartSequence()
        {
            string input = Console.ReadLine();
        }
    }
}
