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
            catch (Exception e)
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
            int[] startarr = new int[input];
            Populate(startarr);
            GetSum();
            GetProduct();
            GetQuotient();

        }
        public static int[] Populate(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Please enter a number number {i + 1}/{arr.Length}");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arr;
        }

        public static int GetSum(int[] sumArr)
        {
            int sum = 0;

            for (int i = 0; i < sumArr.Length; i++)
            {
                sum += sumArr[i];
            }
            if (sum < 20)
            {
                throw (new Exception($"Value of {sum} is too low"));
            }
            Console.WriteLine($"The sum of the arr is {sum}");
            return sum;

        }
        public static int GetProduct(int[] productArr, int productSum)
        {
            Console.WriteLine($"Select a random number between 1 and {productArr.Length} ");
            int input = Convert.ToInt32(Console.ReadLine());
            int product = productSum * productArr[input - 1];
            return product;
            Console.WriteLine("")
        }
        public static decimal GetQuotient()
        {
        }
    }
}
