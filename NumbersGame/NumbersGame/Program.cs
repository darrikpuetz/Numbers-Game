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
            Console.WriteLine("Enter a number greater than zero");
            string input = Convert.ToInt32(Console.ReadLine());
            Populate();
            GetSum();
            GetProduct();
            GetQuotient();

        }
        public static void Populate()
        {
        }

        public static void GetSum()
        {
        }
        public static void GetProduct()
        {
        }
        public static void GetQuotient()
        {
        }
    }
}
