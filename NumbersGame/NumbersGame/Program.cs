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
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Program is done");
            }
        }

        public static void StartSequence()
        {
            Console.WriteLine("Enter a number greater than zero");
            int input = Convert.ToInt32(Console.ReadLine());
            int [] startarr = new int[input];
            Populate(startarr);
            GetSum();
            GetProduct();
            GetQuotient();

        }
        public static int[] Populate(int [] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Please enter a number number {i+1}/{arr.Length}");
            arr[i]= Convert.ToInt32(Console.ReadLine());
            }
            return arr;
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
