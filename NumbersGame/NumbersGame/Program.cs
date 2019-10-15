using System;

namespace NumbersGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Something");
            try
            {
            StartSequence();

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
            int [] pop = Populate(startarr);
            int sum = GetSum(pop);
            int product = GetProduct(pop, sum);
            decimal quo = GetQuotient(product);

            Console.WriteLine($"Your array size is: {pop.Length} ");
            Console.WriteLine($"The numbers in the array are {String.Join(", " , pop) }");
            Console.WriteLine(" * = ");
            Console.WriteLine(" /  = ");

        }
        /// <summary>
        /// The Populate method is taking an input from the number entered and returning an array for the request number that is a long as the number entered.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static int[] Populate(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Please enter a number {i + 1}/{arr.Length}");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arr;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sumArr"></param>
        /// <returns></returns>
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="productArr"></param>
        /// <param name="productSum"></param>
        /// <returns></returns>
        public static int GetProduct(int[] productArr, int productSum)
        {
            try
            {
            Console.WriteLine($"Select a random number between 1 and {productArr.Length} ");
            int input = Convert.ToInt32(Console.ReadLine());
            int product = productSum * productArr[input - 1];
            return product;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="product"></param>
        /// <returns></returns>
        public static decimal GetQuotient(int product)
        {
            try
            {
                Console.WriteLine("Enter a number to divide by. ");
                int input = Convert.ToInt32(Console.ReadLine());
                decimal quotient = Decimal.Divide(product,input);

                return quotient;


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 0;
            }
        }
    }
}
